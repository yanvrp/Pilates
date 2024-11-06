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
    public partial class ConsultaContasPagar : Pilates.ConsultaPAI
    {
        private ControllerContasPagar<ModelContasPagar> controllerContasPagar;
        private ControllerFornecedor<ModelFornecedor> controllerFornecedor;
        public ConsultaContasPagar()
        {
            InitializeComponent();
            controllerContasPagar = new ControllerContasPagar<ModelContasPagar>();
            controllerFornecedor = new ControllerFornecedor<ModelFornecedor>();
        }
        public override void Incluir()
        {
            CadastroContasPagar cadastroContasPagar = new CadastroContasPagar();
            cadastroContasPagar.Owner = this;
            cadastroContasPagar.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewContasPagar.SelectedRows.Count > 0)
            {
                int numero = (int)dataGridViewContasPagar.SelectedRows[0].Cells["numero"].Value;
                int parcela = (int)dataGridViewContasPagar.SelectedRows[0].Cells["parcela"].Value;
                CadastroContasPagar cadastroContasPagar = new CadastroContasPagar(numero, parcela);
                cadastroContasPagar.Bloqueia();
                cadastroContasPagar.Owner = this;
                cadastroContasPagar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma conta a pagar para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void AtualizarConsultaContasPagar(bool incluirInativos)
        {
            try
            {
                dataGridViewContasPagar.DataSource = controllerContasPagar.BuscarTodos(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de contas a pagar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaContasPagar_Load(object sender, EventArgs e)
        {
            try
            {
                CadastroContasPagar cadastroContasPagar = new CadastroContasPagar();
                cadastroContasPagar.FormClosed += (s, args) => AtualizarConsultaContasPagar(cbInativos.Checked);
                dataGridViewContasPagar.AutoGenerateColumns = false;
                dataGridViewContasPagar.Columns["numero"].DataPropertyName = "numero";
                dataGridViewContasPagar.Columns["parcela"].DataPropertyName = "parcela";
                dataGridViewContasPagar.Columns["valorParcela"].DataPropertyName = "valorParcela";
                dataGridViewContasPagar.Columns["idFornecedor"].DataPropertyName = "idFornecedor";
                dataGridViewContasPagar.Columns["dataVencimento"].DataPropertyName = "dataVencimento";
                dataGridViewContasPagar.Columns["dataPagamento"].DataPropertyName = "dataPagamento";
                dataGridViewContasPagar.Columns["dataCancelamento"].DataPropertyName = "dataCancelamento";
                dataGridViewContasPagar.Columns["dataVencimento"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridViewContasPagar.Columns["dataPagamento"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridViewContasPagar.Columns["dataCancelamento"].DefaultCellStyle.Format = "dd/MM/yyyy";
                AtualizarConsultaContasPagar(cbInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as contas a pagar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public override void Pesquisar()
        {
            string pesquisa = txtPesquisar.Texts.Trim();
            if (!string.IsNullOrEmpty(pesquisa))
            {
                try
                {
                    List<ModelContasPagar> resultadosPesquisa = new List<ModelContasPagar>();
                    bool buscaInativos = cbInativos.Checked;

                    if (int.TryParse(pesquisa, out int numeroNotaPesquisa))
                    {
                        resultadosPesquisa = controllerContasPagar.BuscarTodos(buscaInativos).Where(p => p.numero == numeroNotaPesquisa).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira um número de nota válido.", "Número inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    dataGridViewContasPagar.DataSource = resultadosPesquisa;
                    txtPesquisar.Texts = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaContasPagar(cbInativos.Checked);
            }
        }

        private void dataGridViewContasPagar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int numero = (int)dataGridViewContasPagar.Rows[e.RowIndex].Cells["numero"].Value;
                int parcela = (int)dataGridViewContasPagar.Rows[e.RowIndex].Cells["parcela"].Value;
                CadastroContasPagar cadastroContasPagar = new CadastroContasPagar(numero, parcela);
                cadastroContasPagar.Bloqueia();
                cadastroContasPagar.Owner = this;
                cadastroContasPagar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma conta a pagar para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewContasPagar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewContasPagar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewContasPagar.Columns[e.ColumnIndex].Name == "idFornecedor" && e.RowIndex >= 0)
            {
                var cellValue = dataGridViewContasPagar.Rows[e.RowIndex].Cells["idFornecedor"].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int idFornecedor))
                {
                    ModelFornecedor fornecedor = controllerFornecedor.BuscarPorId(idFornecedor);
                    if (fornecedor != null)
                    {
                        dataGridViewContasPagar.Rows[e.RowIndex].Cells["Fornecedor"].Value = fornecedor.fornecedor_razao_social;
                    }
                    else
                    {
                        dataGridViewContasPagar.Rows[e.RowIndex].Cells["Fornecedor"].Value = "Fornecedor não encontrado";
                    }
                }
            }
            if (dataGridViewContasPagar.Columns[e.ColumnIndex].Name == "dataPagamento" && e.RowIndex >= 0)
            {
                var dataPagamento = dataGridViewContasPagar.Rows[e.RowIndex].Cells["dataPagamento"].Value;
                if (dataPagamento != DBNull.Value && dataPagamento != null)
                {
                    dataGridViewContasPagar.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Green; //se estiver pago fica verde
                }
                else
                {
                    dataGridViewContasPagar.Rows[e.RowIndex].DefaultCellStyle.ForeColor = dataGridViewContasPagar.DefaultCellStyle.ForeColor;
                }
            }

            //verifica data vencimento e cancelamento
            var dataVencimentoValue = dataGridViewContasPagar.Rows[e.RowIndex].Cells["dataVencimento"].Value;
            var pagamentoValue = dataGridViewContasPagar.Rows[e.RowIndex].Cells["dataPagamento"].Value;
            var dataCancelamentoValue = dataGridViewContasPagar.Rows[e.RowIndex].Cells["dataCancelamento"].Value;

            if (dataCancelamentoValue != DBNull.Value && dataCancelamentoValue != null)
            {
                e.CellStyle.ForeColor = Color.Red;
            }
            else
            {
                //verifica vencimento e pagamento
                if (dataVencimentoValue != null && DateTime.TryParse(dataVencimentoValue.ToString(), out DateTime dataVencimento))
                {
                    if (dataVencimento < DateTime.Now.Date && string.IsNullOrEmpty(pagamentoValue?.ToString()))
                    {
                        e.CellStyle.ForeColor = ColorTranslator.FromHtml("#ff6400"); //se venceu fica laranja
                    }
                    else if (!string.IsNullOrEmpty(pagamentoValue?.ToString()))
                    {
                        e.CellStyle.ForeColor = Color.Green; //se ta pago verde
                    }
                    else
                    {
                        e.CellStyle.ForeColor = dataGridViewContasPagar.DefaultCellStyle.ForeColor; //se esta em dia fica a cor padrao
                    }
                }
            }
        }
    }
}
