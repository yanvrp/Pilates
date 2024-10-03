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
    public partial class ConsultaFormaPagamento : Pilates.ConsultaPAI
    {
        private ControllerFormaPagamento<ModelFormaPagamento> controllerFormaPagamento;
        public ConsultaFormaPagamento()
        {
            InitializeComponent();
            controllerFormaPagamento = new ControllerFormaPagamento<ModelFormaPagamento>();
        }
        public override void Incluir()
        {
            CadastroFormaPagamento cadastroFormaPagamento = new CadastroFormaPagamento();
            cadastroFormaPagamento.Owner = this;
            cadastroFormaPagamento.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewFormaPagamento.SelectedRows.Count > 0)
            {
                int idFormaPagamento = (int)dataGridViewFormaPagamento.SelectedRows[0].Cells["Código"].Value;
                CadastroFormaPagamento cadastroFormaPagamento = new CadastroFormaPagamento(idFormaPagamento);
                cadastroFormaPagamento.Owner = this;
                cadastroFormaPagamento.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma forma de pagamento para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public override void Excluir()
        {
            if (dataGridViewFormaPagamento.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir esta Forma de Pagamento?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idFormaPagamento = (int)dataGridViewFormaPagamento.SelectedRows[0].Cells["Código"].Value;
                    controllerFormaPagamento.Deletar(idFormaPagamento);
                    dataGridViewFormaPagamento.DataSource = controllerFormaPagamento.BuscarTodos(cbInativos.Checked);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma Forma de Pagamento para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    List<ModelFormaPagamento> resultadosPesquisa = controllerFormaPagamento.BuscarTodos(cbInativos.Checked).Where(p => p.formaPagamento.ToLower().Contains(pesquisa.ToLower())).ToList();
                    dataGridViewFormaPagamento.DataSource = resultadosPesquisa; //atualiza o DataSource do DataGridView com os resultados da pesquisa
                    txtPesquisar.Text = string.Empty; //limpa o txt pesquisa
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar Formas de Pagamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaFormasPag(cbInativos.Checked);
            }
        }
        public void AtualizarConsultaFormasPag(bool incluirInativos)
        {
            try
            {
                dataGridViewFormaPagamento.DataSource = controllerFormaPagamento.BuscarTodos(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de Formas de Pagamento: " + ex.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaFormaPagamento_Load(object sender, EventArgs e)
        {
            try
            {
                CadastroFormaPagamento cadastroFormaPagamento = new CadastroFormaPagamento();
                cadastroFormaPagamento.FormClosed += (s, args) => AtualizarConsultaFormasPag(cbInativos.Checked); //quando aciona o Form Closed chama o AtualizarConsulta

                dataGridViewFormaPagamento.AutoGenerateColumns = false;
                dataGridViewFormaPagamento.Columns["Código"].DataPropertyName = "idFormaPagamento";
                dataGridViewFormaPagamento.Columns["formaPagamento"].DataPropertyName = "formaPagamento";

                AtualizarConsultaFormasPag(cbInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar Formas de Pagamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (btnSair.Text == "Selecionar")
            {
                if (dataGridViewFormaPagamento.SelectedRows.Count > 0)
                {
                    int idFormaPagamento = Convert.ToInt32(dataGridViewFormaPagamento.SelectedRows[0].Cells["Código"].Value);
                    string formaPagamento = dataGridViewFormaPagamento.SelectedRows[0].Cells["formaPagamento"].Value.ToString();

                    this.Tag = new Tuple<int, string>(idFormaPagamento, formaPagamento);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma Forma de Pagamento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            AtualizarConsultaFormasPag(incluirInativos);
        }

        private void dataGridViewFormaPagamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idFormaPagamento = (int)dataGridViewFormaPagamento.Rows[e.RowIndex].Cells["Código"].Value;
                CadastroFormaPagamento cadastroFormaPagamento = new CadastroFormaPagamento(idFormaPagamento);
                cadastroFormaPagamento.Owner = this;
                cadastroFormaPagamento.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma forma de pagamento para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
