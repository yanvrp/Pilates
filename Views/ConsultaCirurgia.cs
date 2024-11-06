using Pilates.Controller;
using Pilates.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pilates.Views
{
    public partial class ConsultaCirurgia : Pilates.ConsultaPAI
    {
        private ControllerCirurgia<ModelCirurgia> CirurgiaController;
        public ConsultaCirurgia()
        {
            InitializeComponent();
            CirurgiaController = new ControllerCirurgia<ModelCirurgia>();
        }

        private void ConsultaCirurgia_Load(object sender, EventArgs e)
        {
            try
            {
                CadastroCirurgia cadastroCirurgia = new CadastroCirurgia();
                cadastroCirurgia.FormClosed += (s, args) => AtualizarConsultaCirurgias(cbInativos.Checked); //quando aciona o Form Closed chama o AtualizarConsulta

                dataGridViewCirurgia.AutoGenerateColumns = false;
                dataGridViewCirurgia.Columns["Código"].DataPropertyName = "idCirurgia";
                dataGridViewCirurgia.Columns["Cirurgia"].DataPropertyName = "cirurgia";
                dataGridViewCirurgia.Columns["Descrição"].DataPropertyName = "descricao";

                AtualizarConsultaCirurgias(cbInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as cirurgias: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public override void Incluir()
        {
            CadastroCirurgia cadastroCirurgia = new CadastroCirurgia();
            cadastroCirurgia.Owner = this;
            cadastroCirurgia.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewCirurgia.SelectedRows.Count > 0)
            {
                int idCirurgia = (int)dataGridViewCirurgia.SelectedRows[0].Cells["Código"].Value;
                CadastroCirurgia cadastroCirurgia = new CadastroCirurgia(idCirurgia);
                cadastroCirurgia.Owner = this;
                cadastroCirurgia.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma cirurgia para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public override void Excluir()
        {
            if (dataGridViewCirurgia.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir esta cirurgia?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idCirurgia = (int)dataGridViewCirurgia.SelectedRows[0].Cells["Código"].Value;
                    CirurgiaController.Deletar(idCirurgia);
                    dataGridViewCirurgia.DataSource = CirurgiaController.BuscarTodos(cbInativos.Checked);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma cirurgia para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public override void Pesquisar()
        {
            string pesquisa = txtPesquisar.Texts.Trim(); //obtem a pesquisa do txt

            //verifica se há um termo de pesquisa
            if (!string.IsNullOrEmpty(pesquisa))
            {
                try
                {
                    //filtra os dados das doenças
                    List<ModelCirurgia> resultadosPesquisa = CirurgiaController.BuscarTodos(cbInativos.Checked).Where(p => p.cirurgia.ToLower().Contains(pesquisa.ToLower())).ToList();
                    dataGridViewCirurgia.DataSource = resultadosPesquisa; //atualiza o DataSource do DataGridView com os resultados da pesquisa
                    txtPesquisar.Texts = string.Empty; //limpa o txt pesquisa
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar cirurgias: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaCirurgias(cbInativos.Checked);
            }
        }
        public void AtualizarConsultaCirurgias(bool incluirInativos)
        {
            try
            {
                //recarrega os dados das doença na consulta de doençass
                dataGridViewCirurgia.DataSource = CirurgiaController.BuscarTodos(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de cirurgias: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbInativos_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbInativos.Checked;
            AtualizarConsultaCirurgias(incluirInativos);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (btnSair.Text == "Selecionar")
            {
                if (dataGridViewCirurgia.SelectedRows.Count > 0)
                {
                    // Capturar o ID e o nome da cirurgia selecionado
                    int cirurgiaID = Convert.ToInt32(dataGridViewCirurgia.SelectedRows[0].Cells["Código"].Value);
                    string cirurgiaNome = dataGridViewCirurgia.SelectedRows[0].Cells["Cirurgia"].Value.ToString();
                    string cirurgiaDescricao = dataGridViewCirurgia.SelectedRows[0].Cells["Descrição"].Value.ToString();

                    // Passar os detalhes da cirurgia selecionada de volta para a tela principal
                    this.Tag = new Tuple<int, string, string>(cirurgiaID, cirurgiaNome, cirurgiaDescricao);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma cirurgia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Close();
            }
        }

        private void dataGridViewCirurgia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idCirurgia = (int)dataGridViewCirurgia.Rows[e.RowIndex].Cells["Código"].Value;
                CadastroCirurgia cadastroCirurgia = new CadastroCirurgia(idCirurgia);
                cadastroCirurgia.Owner = this;
                cadastroCirurgia.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma cirurgia para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
