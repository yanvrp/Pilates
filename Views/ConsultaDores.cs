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
    public partial class ConsultaDores : Pilates.ConsultaPAI
    {
        private ControllerDores<ModelDores> DoresController;
        public ConsultaDores()
        {
            InitializeComponent();
            DoresController = new ControllerDores<ModelDores>();
        }

        private void ConsultaDores_Load(object sender, EventArgs e)
        {
            try
            {
                CadastroDores cadastroDores = new CadastroDores();
                cadastroDores.FormClosed += (s, args) => AtualizarConsultaDores(cbInativos.Checked); //quando aciona o Form Closed chama o AtualizarConsulta

                dataGridViewDores.AutoGenerateColumns = false;
                dataGridViewDores.Columns["Código"].DataPropertyName = "idDores";
                dataGridViewDores.Columns["Dores"].DataPropertyName = "dores";
                dataGridViewDores.Columns["Descrição"].DataPropertyName = "descricao";

                AtualizarConsultaDores(cbInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as dores: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public override void Incluir()
        {
            CadastroDores cadastroDores = new CadastroDores();
            cadastroDores.Owner = this;
            cadastroDores.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewDores.SelectedRows.Count > 0)
            {
                int idDores = (int)dataGridViewDores.SelectedRows[0].Cells["Código"].Value;
                CadastroDores cadastroDores = new CadastroDores(idDores);
                cadastroDores.Owner = this;
                cadastroDores.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma dor para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public override void Excluir()
        {
            if (dataGridViewDores.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir esta dor?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idDores = (int)dataGridViewDores.SelectedRows[0].Cells["Código"].Value;
                    DoresController.Deletar(idDores);
                    dataGridViewDores.DataSource = DoresController.BuscarTodos(cbInativos.Checked);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma dor para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public override void Pesquisar()
        {
            string pesquisa = txtPesquisar.Text.Trim(); //obtem a pesquisa do txt

            //verifica se há um termo de pesquisa
            if (!string.IsNullOrEmpty(pesquisa))
            {
                try
                {
                    //filtra os dados das dores
                    List<ModelDores> resultadosPesquisa = DoresController.BuscarTodos(cbInativos.Checked).Where(p => p.dores.ToLower().Contains(pesquisa.ToLower())).ToList();
                    dataGridViewDores.DataSource = resultadosPesquisa; //atualiza o DataSource do DataGridView com os resultados da pesquisa
                    txtPesquisar.Text = string.Empty; //limpa o txt pesquisa
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar dores: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaDores(cbInativos.Checked);
            }
        }
        public void AtualizarConsultaDores(bool incluirInativos)
        {
            try
            {
                //recarrega os dados das doença na consulta de doençass
                dataGridViewDores.DataSource = DoresController.BuscarTodos(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de dores: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbInativos_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbInativos.Checked;
            AtualizarConsultaDores(incluirInativos);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (btnSair.Text == "Selecionar")
            {
                if (dataGridViewDores.SelectedRows.Count > 0)
                {
                    // Capturar o ID e o nome das dores selecionado
                    int doresID = Convert.ToInt32(dataGridViewDores.SelectedRows[0].Cells["Código"].Value);
                    string doresNome = dataGridViewDores.SelectedRows[0].Cells["Dores"].Value.ToString();

                    // Passar os detalhes da doença selecionada de volta para a tela principal
                    this.Tag = new Tuple<int, string>(doresID, doresNome);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma dor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Close();
            }
        }

        private void dataGridViewDores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idDores = (int)dataGridViewDores.Rows[e.RowIndex].Cells["Código"].Value;
                CadastroDores cadastroDores = new CadastroDores(idDores);
                cadastroDores.Owner = this;
                cadastroDores.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma dor para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
