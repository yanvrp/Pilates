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
    public partial class ConsultaAgenda : Pilates.ConsultaPAI
    {
        private ControllerAluno<ModelAluno> controllerAluno;
        private ControllerAgenda<ModelAgenda> controllerAgenda;
        public ConsultaAgenda()
        {
            InitializeComponent();
            controllerAgenda = new ControllerAgenda<ModelAgenda>();
            controllerAluno = new ControllerAluno<ModelAluno>();
        }
        public override void Incluir()
        {
            CadastroAgenda cadastroAgenda = new CadastroAgenda();
            cadastroAgenda.Owner = this;
            cadastroAgenda.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewAgenda.SelectedRows.Count > 0)
            {
                int idAgenda = (int)dataGridViewAgenda.SelectedRows[0].Cells["Código"].Value;
                CadastroAgenda cadastroAgenda = new CadastroAgenda(idAgenda);
                cadastroAgenda.Owner = this;
                cadastroAgenda.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um agendamento para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void AtualizarConsultaAgenda(bool incluirInativos)
        {
            try
            {
                dataGridViewAgenda.DataSource = controllerAgenda.BuscarTodos(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de Agenda: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaAgenda_Load(object sender, EventArgs e)
        {
            try
            {
                CadastroAgenda cadastroAgenda = new CadastroAgenda();
                cadastroAgenda.FormClosed += (s, args) => AtualizarConsultaAgenda(cbInativos.Checked);
                dataGridViewAgenda.AutoGenerateColumns = false;
                dataGridViewAgenda.Columns["Código"].DataPropertyName = "idAgenda";
                dataGridViewAgenda.Columns["Data"].DataPropertyName = "data";
                dataGridViewAgenda.Columns["Data"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridViewAgenda.Columns["Horário"].DataPropertyName = "horario";
                dataGridViewAgenda.Columns["idAluno"].DataPropertyName = "idAluno";
                dataGridViewAgenda.Columns["Situação"].DataPropertyName = "situacao";
                AtualizarConsultaAgenda(cbInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os Agendamentos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewAgenda_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewAgenda.Columns[e.ColumnIndex].Name == "idAluno" && e.RowIndex >= 0)
            {
                var cellValue = dataGridViewAgenda.Rows[e.RowIndex].Cells["idAluno"].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int idAluno))
                {
                    ModelAluno aluno = controllerAluno.BuscarPorId(idAluno);
                    if (aluno != null)
                    {
                        dataGridViewAgenda.Rows[e.RowIndex].Cells["Aluno"].Value = aluno.Aluno;
                    }
                    else
                    {
                        dataGridViewAgenda.Rows[e.RowIndex].Cells["Aluno"].Value = "Aluno não encontrado";
                    }
                }
            }
        }

        private void dataGridViewAgenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idAgenda = (int)dataGridViewAgenda.Rows[e.RowIndex].Cells["Código"].Value;
                CadastroAgenda cadastroAgenda = new CadastroAgenda(idAgenda);
             //   cadastroAgenda.BloqueiaTudo();
                cadastroAgenda.Owner = this;
                cadastroAgenda.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma conta a receber para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
