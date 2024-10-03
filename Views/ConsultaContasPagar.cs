using Pilates.Controller;
using Pilates.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pilates.Views
{
    public partial class ConsultaContasPagar : Pilates.ConsultaPAI
    {
        private ControllerContasPagar<ModelContasPagar> controllerContasPagar;
        public ConsultaContasPagar()
        {
            InitializeComponent();
            controllerContasPagar = new ControllerContasPagar<ModelContasPagar>();
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
    }
}
