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
    public partial class ConsultaCidade : Pilates.ConsultaPAI
    {
        private ControllerCidade<ModelCidade> cidadeController;
        public ConsultaCidade()
        {
            InitializeComponent();
            cidadeController = new ControllerCidade<ModelCidade>();
        }
        public override void Incluir()
        {
            CadastroCidade cadastroCidades = new CadastroCidade();
            cadastroCidades.Owner = this;
            cadastroCidades.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewCidade.SelectedRows.Count > 0)
            {
                int idCidade = (int)dataGridViewCidade.SelectedRows[0].Cells["Código"].Value;
                CadastroCidade cadastroCidades = new CadastroCidade(idCidade);
                cadastroCidades.Owner = this;
                cadastroCidades.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma cidade para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public override void Excluir()
        {
            if (dataGridViewCidade.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir esta cidade?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idCidade = (int)dataGridViewCidade.SelectedRows[0].Cells["Código"].Value;
                    cidadeController.Deletar(idCidade);
                    dataGridViewCidade.DataSource = cidadeController.BuscarTodos(cbInativos.Checked);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma cidade para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    //filtra os dados
                    List<ModelCidade> resultadosPesquisa = cidadeController.BuscarTodos(cbInativos.Checked).Where(p => p.Cidade.ToLower().Contains(pesquisa.ToLower())).ToList();
                    dataGridViewCidade.DataSource = resultadosPesquisa; //atualiza o DataSource do DataGridView com os resultados da pesquisa
                    txtPesquisar.Texts = string.Empty; //limpa o txt pesquisa
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar cidades: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //se não houver nada no txt, atualiza a consulta de cidades normalmente
                AtualizarConsultaCidades(cbInativos.Checked);
            }
        }

        //atualizar a consulta de cidades
        public void AtualizarConsultaCidades(bool incluirInativos)
        {
            try
            {
                //recarrega os dados das cidades na consulta 
                dataGridViewCidade.DataSource = cidadeController.BuscarTodos(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de cidades: " + ex.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaCidade_Load(object sender, EventArgs e)
        {
            try
            {
                CadastroCidade cadastroCidades = new CadastroCidade();
                cadastroCidades.FormClosed += (s, args) => AtualizarConsultaCidades(cbInativos.Checked); //quando aciona o Form Closed chama o AtualizarConsulta

                dataGridViewCidade.AutoGenerateColumns = false;
                dataGridViewCidade.Columns["Código"].DataPropertyName = "idCidade";
                dataGridViewCidade.Columns["Cidade"].DataPropertyName = "Cidade";
                dataGridViewCidade.Columns["DDD"].DataPropertyName = "DDD";

                AtualizarConsultaCidades(cbInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as cidades: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbInativos_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbInativos.Checked;
            AtualizarConsultaCidades(incluirInativos);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (btnSair.Text == "Selecionar")
            {
                if (dataGridViewCidade.SelectedRows.Count > 0)
                {
                    int idCidade = Convert.ToInt32(dataGridViewCidade.SelectedRows[0].Cells["Código"].Value);
                    string nomeCidade = dataGridViewCidade.SelectedRows[0].Cells["Cidade"].Value.ToString();
                    this.Tag = new Tuple<int, string>(idCidade, nomeCidade);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma cidade.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Close();
            }
        }

        private void dataGridViewCidade_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idCidade = (int)dataGridViewCidade.Rows[e.RowIndex].Cells["Código"].Value;
                CadastroCidade cadastroCidades = new CadastroCidade(idCidade);
                cadastroCidades.Owner = this;
                cadastroCidades.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma cidade para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
