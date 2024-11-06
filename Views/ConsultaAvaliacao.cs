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
    public partial class ConsultaAvaliacao : Pilates.ConsultaPAI
    {
        private ControllerAvaliacao<ModelAvaliacao> controllerAvaliacao;
        private ControllerAluno<ModelAluno> controllerAluno;
        public ConsultaAvaliacao()
        {
            InitializeComponent();
            controllerAvaliacao = new ControllerAvaliacao<ModelAvaliacao> ();
            controllerAluno = new ControllerAluno<ModelAluno> ();
        }

        private void ConsultaAvaliacao_Load(object sender, EventArgs e)
        {
            try
            {
                CadastroAvaliacao cadastroAvaliacao = new CadastroAvaliacao();
                cadastroAvaliacao.FormClosed += (s, args) => AtualizarConsultaAvaliacoes(cbInativos.Checked); //quando aciona o Form Closed chama o AtualizarConsulta

                dataGridViewAvaliacao.AutoGenerateColumns = false;
                dataGridViewAvaliacao.Columns["idAvaliação"].DataPropertyName = "idAvaliacao";
                dataGridViewAvaliacao.Columns["idAluno"].DataPropertyName = "idAluno";
                dataGridViewAvaliacao.Columns["dataAvaliação"].DataPropertyName = "data";
                dataGridViewAvaliacao.Columns["dataAvaliação"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridViewAvaliacao.Columns["dataCancelamento"].DataPropertyName = "dataCancelamento";
                dataGridViewAvaliacao.Columns["dataCancelamento"].DefaultCellStyle.Format = "dd/MM/yyyy";

                AtualizarConsultaAvaliacoes(cbInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as avaliações: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public override void Incluir()
        {
            CadastroAvaliacao cadastroAvaliacao = new CadastroAvaliacao();
            cadastroAvaliacao.Owner = this;
            cadastroAvaliacao.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewAvaliacao.SelectedRows.Count > 0) {             
                int codAvaliacao = (int)dataGridViewAvaliacao.SelectedRows[0].Cells["idAvaliação"].Value;
                CadastroAvaliacao cadastroAvaliacao = new CadastroAvaliacao(codAvaliacao);
                cadastroAvaliacao.Owner = this;
                cadastroAvaliacao.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma avaliação para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public override void Excluir()
        {
            if (dataGridViewAvaliacao.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir esta avaliação?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int codAvaliacao = (int)dataGridViewAvaliacao.SelectedRows[0].Cells["idAvaliação"].Value;
                    controllerAvaliacao.Deletar(codAvaliacao);
                    dataGridViewAvaliacao.DataSource = controllerAvaliacao.BuscarTodos(cbInativos.Checked);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma avaliação para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public override void Pesquisar()
        {
            string pesquisa = txtPesquisar.Texts.Trim();

            if (!string.IsNullOrEmpty(pesquisa))
            {
                try
                {
                    if (int.TryParse(pesquisa, out int idAvaliacao))
                    {
                        List<ModelAvaliacao> resultadosPesquisa = controllerAvaliacao.BuscarTodos(cbInativos.Checked)
                            .Where(p => p.idAvaliacao == idAvaliacao)
                            .ToList();

                        // Atualiza o DataSource do DataGridView com os resultados da pesquisa
                        dataGridViewAvaliacao.DataSource = resultadosPesquisa;
                    }
                    else
                    {
                        MessageBox.Show("O código da avaliação deve ser um número válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    txtPesquisar.Texts = string.Empty; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar avaliações: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaAvaliacoes(cbInativos.Checked);
            }
        }

        public void AtualizarConsultaAvaliacoes(bool incluirInativos)
        {
            try
            {
                //recarrega os dados das gestações na consulta
                dataGridViewAvaliacao.DataSource = controllerAvaliacao.BuscarTodos(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de avaliações: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbInativos_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbInativos.Checked;
            AtualizarConsultaAvaliacoes(incluirInativos);
        }

        private void dataGridViewAvaliacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int codAvaliacao = (int)dataGridViewAvaliacao.Rows[e.RowIndex].Cells["idAvaliação"].Value;
                CadastroAvaliacao cadastroAvaliacao = new CadastroAvaliacao(codAvaliacao);
                cadastroAvaliacao.Owner = this;
                cadastroAvaliacao.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma avaliação para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewAvaliacao_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewAvaliacao.Columns[e.ColumnIndex].Name == "Aluno" && e.RowIndex >= 0)
            {
                int idAluno = (int)dataGridViewAvaliacao.Rows[e.RowIndex].Cells["idAluno"].Value;
                ModelAluno aluno = controllerAluno.BuscarPorId(idAluno);

                e.Value = aluno != null ? aluno.Aluno : "Aluno não encontrado";
                e.FormattingApplied = true;
            }
            var dataCancelamentoValue = dataGridViewAvaliacao.Rows[e.RowIndex].Cells["dataCancelamento"].Value;
            if (dataCancelamentoValue != DBNull.Value && dataCancelamentoValue != null)
            {
                dataGridViewAvaliacao.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
            }
        }
    }
}
