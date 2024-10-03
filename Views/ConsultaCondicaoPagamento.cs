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
    public partial class ConsultaCondicaoPagamento : Pilates.ConsultaPAI
    {
        private ControllerCondicaoPagamento<ModelCondicaoPagamento> controllerCondicaoPagamento;
        public ConsultaCondicaoPagamento()
        {
            InitializeComponent();
            controllerCondicaoPagamento = new ControllerCondicaoPagamento<ModelCondicaoPagamento>();
        }
        public override void Incluir()
        {
            CadastroCondicaoDePagamento cadastroCondicaoPagamento = new CadastroCondicaoDePagamento();
            cadastroCondicaoPagamento.Owner = this;
            cadastroCondicaoPagamento.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewCondicaoPagamento.SelectedRows.Count > 0)
            {
                int idCondicaoPagamento = (int)dataGridViewCondicaoPagamento.SelectedRows[0].Cells["Código"].Value;
                CadastroCondicaoDePagamento cadastroCondicaoPagamento = new CadastroCondicaoDePagamento(idCondicaoPagamento);
                cadastroCondicaoPagamento.Owner = this;
                cadastroCondicaoPagamento.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma condição de pagamento para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public override void Excluir()
        {
            if (dataGridViewCondicaoPagamento.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir esta condição de Pagamento?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idCondicaoPagamento = (int)dataGridViewCondicaoPagamento.SelectedRows[0].Cells["Código"].Value;
                    controllerCondicaoPagamento.Deletar(idCondicaoPagamento);
                    dataGridViewCondicaoPagamento.DataSource = controllerCondicaoPagamento.BuscarTodos(cbInativos.Checked);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma condição de Pagamento para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    //filtra os dados
                    List<ModelCondicaoPagamento> resultadosPesquisa = controllerCondicaoPagamento.BuscarTodos(cbInativos.Checked).Where(p => p.condicaoPagamento.ToLower().Contains(pesquisa.ToLower())).ToList();
                    dataGridViewCondicaoPagamento.DataSource = resultadosPesquisa; //atualiza o DataSource do DataGridView com os resultados da pesquisa
                    txtPesquisar.Text = string.Empty; //limpa o txt pesquisa
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar condições de Pagamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaCondPag(cbInativos.Checked);
            }
        }
        public void AtualizarConsultaCondPag(bool incluirInativos)
        {
            try
            {
                dataGridViewCondicaoPagamento.DataSource = controllerCondicaoPagamento.BuscarTodos(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de condições de Pagamento: " + ex.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaCondicaoPagamento_Load(object sender, EventArgs e)
        {
            try
            {
                CadastroCondicaoDePagamento cadastroCondicaoPagamento = new CadastroCondicaoDePagamento();
                cadastroCondicaoPagamento.FormClosed += (s, args) => AtualizarConsultaCondPag(cbInativos.Checked); //quando aciona o Form Closed chama o AtualizarConsulta

                dataGridViewCondicaoPagamento.AutoGenerateColumns = false;
                dataGridViewCondicaoPagamento.Columns["Código"].DataPropertyName = "idCondPagamento";
                dataGridViewCondicaoPagamento.Columns["condicaoPagamento"].DataPropertyName = "condicaoPagamento";

                AtualizarConsultaCondPag(cbInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar condições de Pagamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (btnSair.Text == "Selecionar")
            {
                if (dataGridViewCondicaoPagamento.SelectedRows.Count > 0)
                {
                    int idCondicaoPagamento = Convert.ToInt32(dataGridViewCondicaoPagamento.SelectedRows[0].Cells["Código"].Value);
                    string condicaoPagamento = dataGridViewCondicaoPagamento.SelectedRows[0].Cells["condicaoPagamento"].Value.ToString();

                    this.Tag = new Tuple<int, string>(idCondicaoPagamento, condicaoPagamento);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma condição de Pagamento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Close();
            }
        }

        private void cbInativos_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbInativos.Checked;
            AtualizarConsultaCondPag(incluirInativos);
        }

        private void dataGridViewCondicaoPagamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idCondicaoPagamento = (int)dataGridViewCondicaoPagamento.Rows[e.RowIndex].Cells["Código"].Value;
                CadastroCondicaoDePagamento cadastroCondicaoPagamento = new CadastroCondicaoDePagamento(idCondicaoPagamento);
                cadastroCondicaoPagamento.Owner = this;
                cadastroCondicaoPagamento.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma condição de pagamento para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
