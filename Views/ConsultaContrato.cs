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
    public partial class ConsultaContrato : Pilates.ConsultaPAI
    {
        private ControllerContrato<ModelContrato> controllerContrato;
        private ControllerAluno<ModelAluno> controllerAluno;
        private ControllerPrograma<ModelPrograma> controllerPrograma;
        private ControllerCondicaoPagamento<ModelCondicaoPagamento> controllerCondicaoPagamento;
        public ConsultaContrato()
        {
            InitializeComponent();
            controllerAluno = new ControllerAluno<ModelAluno>();
            controllerCondicaoPagamento = new ControllerCondicaoPagamento<ModelCondicaoPagamento>();
            controllerPrograma = new ControllerPrograma<ModelPrograma>();
            controllerContrato = new ControllerContrato<ModelContrato>();
        }
        public override void Incluir()
        {
            CadastroContrato cadastroContrato = new CadastroContrato();
            cadastroContrato.Owner = this;
            cadastroContrato.ShowDialog();
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {

        }
        public override void Alterar()
        {
            if (dataGridViewContrato.SelectedRows.Count > 0)
            {
                int idContrato = (int)dataGridViewContrato.SelectedRows[0].Cells["Código"].Value;
                CadastroContrato cadastroContrato = new CadastroContrato(idContrato);
                cadastroContrato.Owner = this;
                cadastroContrato.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um Contrato para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void AtualizarConsultaContratos(bool incluirInativos)
        {
            try
            {
                dataGridViewContrato.DataSource = controllerContrato.BuscarTodos(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de Contratos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaContrato_Load(object sender, EventArgs e)
        {
            try
            {
                CadastroContrato cadastroContratos = new CadastroContrato();
                cadastroContratos.FormClosed += (s, args) => AtualizarConsultaContratos(cbInativos.Checked);
                dataGridViewContrato.AutoGenerateColumns = false;
                dataGridViewContrato.Columns["Código"].DataPropertyName = "idContrato";
                dataGridViewContrato.Columns["idAluno"].DataPropertyName = "idAluno";
                dataGridViewContrato.Columns["idPrograma"].DataPropertyName = "idPrograma";
                dataGridViewContrato.Columns["dataCancelamento"].DataPropertyName = "dataCancelamento";
                dataGridViewContrato.Columns["dataCancelamento"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridViewContrato.Columns["dataInicio"].DataPropertyName = "dataInicioPrograma";
                dataGridViewContrato.Columns["dataInicio"].DefaultCellStyle.Format = "dd/MM/yyyy";
                AtualizarConsultaContratos(cbInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as Contratos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewContrato_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewContrato.Columns[e.ColumnIndex].Name == "idAluno" && e.RowIndex >= 0)
            {
                var cellValue = dataGridViewContrato.Rows[e.RowIndex].Cells["idAluno"].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int idAluno))
                {
                    ModelAluno aluno = controllerAluno.BuscarPorId(idAluno);
                    if (aluno != null)
                    {
                        dataGridViewContrato.Rows[e.RowIndex].Cells["Aluno"].Value = aluno.Aluno;
                    }
                    else
                    {
                        dataGridViewContrato.Rows[e.RowIndex].Cells["Aluno"].Value = "Aluno não encontrado";
                    }
                }
            }
            if (dataGridViewContrato.Columns[e.ColumnIndex].Name == "idPrograma" && e.RowIndex >= 0)
            {
                var cellValue = dataGridViewContrato.Rows[e.RowIndex].Cells["idPrograma"].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int idPrograma))
                {
                    ModelPrograma programa = controllerPrograma.BuscarPorId(idPrograma);
                    if (aluno != null)
                    {
                        dataGridViewContrato.Rows[e.RowIndex].Cells["Programa"].Value = programa.titulo;
                    }
                    else
                    {
                        dataGridViewContrato.Rows[e.RowIndex].Cells["Programa"].Value = "Programa não encontrado";
                    }
                }
            }
        }

        private void dataGridViewContrato_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idContrato = (int)dataGridViewContrato.Rows[e.RowIndex].Cells["Código"].Value;
                CadastroContrato cadastroContrato = new CadastroContrato(idContrato);
                cadastroContrato.BloqueiaTudo();
                cadastroContrato.Owner = this;
                cadastroContrato.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma conta a receber para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            int idContrato = (int)dataGridViewContrato.SelectedRows[0].Cells["Código"].Value;
            CadastroContrato cadastroContrato = new CadastroContrato(idContrato);
            cadastroContrato.BloqueiaTudo();
            cadastroContrato.Owner = this;
            cadastroContrato.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (btnSair.Text == "Selecionar")
            {
                if (dataGridViewContrato.SelectedRows.Count > 0)
                {
                    int idContrato = Convert.ToInt32(dataGridViewContrato.SelectedRows[0].Cells["Código"].Value);
                    this.Tag = new Tuple<int>(idContrato);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um Contrato.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Close();
            }
        }
    }
}
