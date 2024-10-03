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
    public partial class ConsultaContasReceber : Pilates.ConsultaPAI
    {
        private ControllerAluno<ModelAluno> controllerAluno;
        private ControllerContasReceber<ModelContasReceber> controllerContasReceber;
        public ConsultaContasReceber()
        {
            InitializeComponent();
            controllerAluno = new ControllerAluno<ModelAluno>();
            controllerContasReceber = new ControllerContasReceber<ModelContasReceber>();
        }
        public override void Incluir()
        {
            CadastroContasReceber cadastroContasReceber = new CadastroContasReceber();
            cadastroContasReceber.Owner = this;
            cadastroContasReceber.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewContasReceber.SelectedRows.Count > 0)
            {
                int numero = (int)dataGridViewContasReceber.SelectedRows[0].Cells["numero"].Value;
                int codAluno = (int)dataGridViewContasReceber.SelectedRows[0].Cells["idAluno"].Value;
                int parcela = (int)dataGridViewContasReceber.SelectedRows[0].Cells["parcela"].Value;
                CadastroContasReceber cadastroContasReceber = new CadastroContasReceber(numero, codAluno, parcela);
                cadastroContasReceber.Bloqueia();
                cadastroContasReceber.Owner = this;
                cadastroContasReceber.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma conta a receber para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void AtualizarConsultaContasReceber(bool incluirInativos)
        {
            try
            {
                dataGridViewContasReceber.DataSource = controllerContasReceber.BuscarTodos(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de contas a receber: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConsultaContasReceber_Load(object sender, EventArgs e)
        {
            try
            {
                CadastroContasReceber cadastroContasReceber = new CadastroContasReceber();
                cadastroContasReceber.FormClosed += (s, args) => AtualizarConsultaContasReceber(cbInativos.Checked);
                dataGridViewContasReceber.AutoGenerateColumns = false;
                dataGridViewContasReceber.Columns["numero"].DataPropertyName = "numero";
                dataGridViewContasReceber.Columns["idAluno"].DataPropertyName = "idAluno";
                dataGridViewContasReceber.Columns["parcela"].DataPropertyName = "parcela";
                dataGridViewContasReceber.Columns["valorParcela"].DataPropertyName = "valorParcela";
                dataGridViewContasReceber.Columns["dataVencimento"].DataPropertyName = "dataVencimento";
                dataGridViewContasReceber.Columns["dataRecebimento"].DataPropertyName = "dataRecebimento";
                dataGridViewContasReceber.Columns["dataCancelamento"].DataPropertyName = "dataCancelamento";
                dataGridViewContasReceber.Columns["dataVencimento"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridViewContasReceber.Columns["dataRecebimento"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridViewContasReceber.Columns["dataCancelamento"].DefaultCellStyle.Format = "dd/MM/yyyy";
                AtualizarConsultaContasReceber(cbInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as Contas a receber: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewContasReceber_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewContasReceber.Columns[e.ColumnIndex].Name == "idAluno" && e.RowIndex >= 0)
            {
                var cellValue = dataGridViewContasReceber.Rows[e.RowIndex].Cells["idAluno"].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int idAluno))
                {
                    ModelAluno aluno = controllerAluno.BuscarPorId(idAluno);
                    if (aluno != null)
                    {
                        dataGridViewContasReceber.Rows[e.RowIndex].Cells["Aluno"].Value = aluno.Aluno;
                    }
                    else
                    {
                        dataGridViewContasReceber.Rows[e.RowIndex].Cells["Aluno"].Value = "Aluno não encontrado";
                    }
                }
            }
        }

        private void dataGridViewContasReceber_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int numero = (int)dataGridViewContasReceber.Rows[e.RowIndex].Cells["numero"].Value;
                int codAluno = (int)dataGridViewContasReceber.Rows[e.RowIndex].Cells["idAluno"].Value;
                int parcela = (int)dataGridViewContasReceber.Rows[e.RowIndex].Cells["parcela"].Value;
                CadastroContasReceber cadastroContasReceber = new CadastroContasReceber(numero, codAluno, parcela);
                cadastroContasReceber.Bloqueia();
                cadastroContasReceber.Owner = this;
                cadastroContasReceber.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma conta a receber para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
