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
    public partial class ConsultaGestacao : Pilates.ConsultaPAI
    {
        private ControllerGestacao<ModelGestacao> GestacaoController;
        public ConsultaGestacao()
        {
            InitializeComponent();
            GestacaoController = new ControllerGestacao<ModelGestacao>();
        }

        private void ConsultaGestacao_Load(object sender, EventArgs e)
        {
            try
            {
                CadastroGestacao cadastroGestacao = new CadastroGestacao();
                cadastroGestacao.FormClosed += (s, args) => AtualizarConsultaGestacoes(cbInativos.Checked); //quando aciona o Form Closed chama o AtualizarConsulta

                dataGridViewGestacao.AutoGenerateColumns = false;
                dataGridViewGestacao.Columns["Código"].DataPropertyName = "idGestacao";
                dataGridViewGestacao.Columns["Gestação"].DataPropertyName = "gestacao";
                dataGridViewGestacao.Columns["Descrição"].DataPropertyName = "descricao";

                AtualizarConsultaGestacoes(cbInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as gestações: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public override void Incluir()
        {
            CadastroGestacao cadastroGestacao = new CadastroGestacao();
            cadastroGestacao.Owner = this;
            cadastroGestacao.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewGestacao.SelectedRows.Count > 0)
            {
                int idGestacao = (int)dataGridViewGestacao.SelectedRows[0].Cells["Código"].Value;
                CadastroGestacao cadastroGestacao = new CadastroGestacao(idGestacao);
                cadastroGestacao.Owner = this;
                cadastroGestacao.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma gestação para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public override void Excluir()
        {
            if (dataGridViewGestacao.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir esta gestação?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idGestacao = (int)dataGridViewGestacao.SelectedRows[0].Cells["Código"].Value;
                    GestacaoController.Deletar(idGestacao);
                    dataGridViewGestacao.DataSource = GestacaoController.BuscarTodos(cbInativos.Checked);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma gestação para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    //filtra os dados das doenças
                    List<ModelGestacao> resultadosPesquisa = GestacaoController.BuscarTodos(cbInativos.Checked).Where(p => p.gestacao.ToLower().Contains(pesquisa.ToLower())).ToList();
                    dataGridViewGestacao.DataSource = resultadosPesquisa; //atualiza o DataSource do DataGridView com os resultados da pesquisa
                    txtPesquisar.Text = string.Empty; //limpa o txt pesquisa
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar gestações: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaGestacoes(cbInativos.Checked);
            }
        }
        public void AtualizarConsultaGestacoes(bool incluirInativos)
        {
            try
            {
                //recarrega os dados das gestações na consulta de gestação
                dataGridViewGestacao.DataSource = GestacaoController.BuscarTodos(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de gestações: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbInativos_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbInativos.Checked;
            AtualizarConsultaGestacoes(incluirInativos);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (btnSair.Text == "Selecionar")
            {
                if (dataGridViewGestacao.SelectedRows.Count > 0)
                {
                    // Capturar o ID e o nome da Gestação selecionado
                    int gestacaoID = Convert.ToInt32(dataGridViewGestacao.SelectedRows[0].Cells["Código"].Value);
                    string gestacaoNome = dataGridViewGestacao.SelectedRows[0].Cells["Gestação"].Value.ToString();
                    string gestacaoDescricao = dataGridViewGestacao.SelectedRows[0].Cells["Descrição"].Value.ToString();

                    // Passar os detalhes da Gestação selecionada de volta para a tela principal
                    this.Tag = new Tuple<int, string, string>(gestacaoID, gestacaoNome, gestacaoDescricao);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma gestação.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Close();
            }
        }

        private void dataGridViewGestacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewGestacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idGestacao = (int)dataGridViewGestacao.Rows[e.RowIndex].Cells["Código"].Value;
                CadastroGestacao cadastroGestacao = new CadastroGestacao(idGestacao);
                cadastroGestacao.Owner = this;
                cadastroGestacao.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma gestação para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
