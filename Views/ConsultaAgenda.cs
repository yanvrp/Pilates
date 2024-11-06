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
        public void AtualizarConsultaAgenda(bool incluirInativos, bool incluirCancelados)
        {
            try
            {
                var agendamentos = controllerAgenda.BuscarTodos(incluirInativos) ?? new List<ModelAgenda>();

                //filtra apenas os agendamentos com situação diferente de "CANCELADO"
                if (!incluirCancelados)
                {
                    agendamentos = agendamentos.Where(a => a.situacao == null || !a.situacao.Equals("CANCELADO", StringComparison.OrdinalIgnoreCase)).ToList();
                }

                dataGridViewAgenda.DataSource = agendamentos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de Agenda: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public override void Pesquisar()
        {
            string pesquisa = txtPesquisar.Texts.Trim(); // obtém a pesquisa do txt
            bool pesquisaDataValida = DateTime.TryParseExact(pesquisa, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataPesquisa);

            // Verifica se há um termo de pesquisa
            if (!string.IsNullOrEmpty(pesquisa))
            {
                try
                {
                    List<ModelAgenda> resultadosPesquisa = new List<ModelAgenda>();

                    if (pesquisaDataValida)
                    {
                        resultadosPesquisa = controllerAgenda.BuscarTodos(cbInativos.Checked)
                                           .Where(p => p.data.Date == dataPesquisa.Date)
                                           .ToList();
                    }
                    
                    dataGridViewAgenda.DataSource = resultadosPesquisa;
                    txtPesquisar.Texts = string.Empty; // limpa o txt pesquisa
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaAgenda(cbInativos.Checked, cbMostrarCancelados.Checked);
            }
        }



        private void ConsultaAgenda_Load(object sender, EventArgs e)
        {
            try
            {
                CadastroAgenda cadastroAgenda = new CadastroAgenda();
                cadastroAgenda.FormClosed += (s, args) => AtualizarConsultaAgenda(cbInativos.Checked, cbMostrarCancelados.Checked);
                dataGridViewAgenda.AutoGenerateColumns = false;
                dataGridViewAgenda.Columns["Código"].DataPropertyName = "idAgenda";
                dataGridViewAgenda.Columns["Data"].DataPropertyName = "data";
                dataGridViewAgenda.Columns["Data"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridViewAgenda.Columns["Horário"].DataPropertyName = "horario";
                dataGridViewAgenda.Columns["idAluno"].DataPropertyName = "idAluno";
                dataGridViewAgenda.Columns["Situação"].DataPropertyName = "situacao";
                AtualizarConsultaAgenda(cbInativos.Checked, cbMostrarCancelados.Checked);
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
            if (dataGridViewAgenda.Columns.Contains("Situação") && e.RowIndex >= 0)
            {
                var situacaoValue = dataGridViewAgenda.Rows[e.RowIndex].Cells["Situação"].Value;

                if (situacaoValue != null && situacaoValue.ToString().Equals("CANCELADO", StringComparison.OrdinalIgnoreCase))
                {
                    dataGridViewAgenda.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                }
                else
                {
                    dataGridViewAgenda.Rows[e.RowIndex].DefaultCellStyle.ForeColor = dataGridViewAgenda.DefaultCellStyle.ForeColor;
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

        private void cbInativos_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbInativos.Checked;
            AtualizarConsultaAgenda(incluirInativos, cbMostrarCancelados.Checked);
        }

        private void cbMostrarCancelados_CheckedChanged(object sender, EventArgs e)
        {
            bool mostrarCancelados = cbMostrarCancelados.Checked;
            AtualizarConsultaAgenda(mostrarCancelados, cbMostrarCancelados.Checked);
        }
    }
}
