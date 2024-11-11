using Pilates.Controller;
using Pilates.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace Pilates.Views
{
    public partial class ConsultaContrato : Pilates.ConsultaPAI
    {
        private ControllerContrato<ModelContrato> controllerContrato;
        private ControllerAluno<ModelAluno> controllerAluno;
        private ControllerPrograma<ModelPrograma> controllerPrograma;
        private ControllerCondicaoPagamento<ModelCondicaoPagamento> controllerCondicaoPagamento;

        public int codAluno { get; set; }

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
        public void AtualizarConsultaContratos(bool incluirInativos, bool incluirTerminados)
        {
            try
            {
                var contratos = controllerContrato.BuscarTodos(incluirInativos) ?? new List<ModelContrato>();

                if (incluirTerminados)
                {
                    //filtra contratos que já finalizaram e não foram cancelados 
                    contratos = contratos.Where(a => a.dataFinalContrato < DateTime.Now && a.dataCancelamento == null).ToList();
                }
                else
                {
                    //filtra contratos que ainda estão ativos ou cancelados
                    contratos = contratos.Where(a => a.dataFinalContrato >= DateTime.Now).ToList();
                }

                dataGridViewContrato.DataSource = contratos;
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
                cadastroContratos.FormClosed += (s, args) => AtualizarConsultaContratos(cbInativos.Checked, cbMostrarTerminados.Checked);
                dataGridViewContrato.AutoGenerateColumns = false;
                dataGridViewContrato.Columns["Código"].DataPropertyName = "idContrato";
                dataGridViewContrato.Columns["idAluno"].DataPropertyName = "idAluno";
                dataGridViewContrato.Columns["idPrograma"].DataPropertyName = "idPrograma";
                dataGridViewContrato.Columns["dataCancelamento"].DataPropertyName = "dataCancelamento";
                dataGridViewContrato.Columns["dataCancelamento"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridViewContrato.Columns["dataFinalContrato"].DataPropertyName = "dataFinalContrato";
                dataGridViewContrato.Columns["dataFinalContrato"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridViewContrato.Columns["dataInicio"].DataPropertyName = "dataInicioPrograma";
                dataGridViewContrato.Columns["dataInicio"].DefaultCellStyle.Format = "dd/MM/yyyy";
                AtualizarConsultaContratos(cbInativos.Checked, cbMostrarTerminados.Checked);
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
            var dataCancelamentoValue = dataGridViewContrato.Rows[e.RowIndex].Cells["dataCancelamento"].Value;
            var finalContratoValue = dataGridViewContrato.Rows[e.RowIndex].Cells["dataFinalContrato"].Value;

            if (dataCancelamentoValue != DBNull.Value && dataCancelamentoValue != null)
            {
                dataGridViewContrato.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
            }
            else if (finalContratoValue != DBNull.Value && finalContratoValue != null)
            {
                DateTime dataFinal = Convert.ToDateTime(finalContratoValue);
                if (dataFinal < DateTime.Now)
                {
                    dataGridViewContrato.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.OrangeRed;
                }
                else
                {
                    dataGridViewContrato.Rows[e.RowIndex].DefaultCellStyle.ForeColor = dataGridViewContrato.DefaultCellStyle.ForeColor;
                }
            }
            else
            {
                dataGridViewContrato.Rows[e.RowIndex].DefaultCellStyle.ForeColor = dataGridViewContrato.DefaultCellStyle.ForeColor;
            }
        }
        public override void Pesquisar()
        {
            string pesquisa = txtPesquisar.Texts.Trim();
            if (!string.IsNullOrEmpty(pesquisa))
            {
                try
                {
                    bool buscaInativos = cbInativos.Checked;
                    var todosContratos = controllerContrato.BuscarTodos(buscaInativos);

                    var resultadosPesquisa = todosContratos
                        .Where(contrato =>
                        {
                            var aluno = controllerAluno.BuscarPorId(contrato.idAluno);
                            return aluno != null && aluno.Aluno.Contains(pesquisa);
                        })
                        .ToList();

                    dataGridViewContrato.DataSource = resultadosPesquisa;
                    txtPesquisar.Texts = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaContratos(cbInativos.Checked, cbMostrarTerminados.Checked);
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

        private void cbInativos_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbInativos.Checked;
            AtualizarConsultaContratos(incluirInativos, cbMostrarTerminados.Checked);
        }
        string FormatarNomeParaArquivo(string nomeCompleto)
        {
            // Remove acentos e caracteres especiais, convertendo para caracteres sem acento
            nomeCompleto = RemoverAcentos(nomeCompleto);

            // Divide o nome completo em partes e seleciona os primeiros dois nomes
            string[] partes = nomeCompleto.Split(' ');
            string nomeFormatado = partes.Length > 1 ? $"{partes[0]}-{partes[1]}" : partes[0];

            // Remove qualquer caractere que não seja letra, número ou hífen
            nomeFormatado = Regex.Replace(nomeFormatado, "[^a-zA-Z0-9-]", "");

            return nomeFormatado;
        }

        string RemoverAcentos(string texto)
        {
            StringBuilder textoNormalizado = new StringBuilder();
            foreach (char c in texto.Normalize(NormalizationForm.FormD))
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    textoNormalizado.Append(c);
            }
            return textoNormalizado.ToString().Normalize(NormalizationForm.FormC);
        }
        private void btnImprimirContrato_Click(object sender, EventArgs e)
        {
            if (dataGridViewContrato.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um Contrato para imprimir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridViewContrato.SelectedRows[0];
            var dataCancelamento = selectedRow.Cells["dataCancelamento"].Value;

            if (dataCancelamento != null)
            {
                MessageBox.Show("Não é possível gerar um contrato cancelado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idContrato = Convert.ToInt32(selectedRow.Cells["Código"].Value);
            int idAluno = Convert.ToInt32(selectedRow.Cells["idAluno"].Value);
            ModelAluno aluno = controllerAluno.BuscarPorId(idAluno);

            if (aluno != null && !string.IsNullOrEmpty(aluno.Aluno))
            {
                string nomeFormatado = FormatarNomeParaArquivo(aluno.Aluno);
                string caminhoArquivo = $@"C:\Contratos\CONTRATO-{nomeFormatado}.pdf";

                controllerContrato.GerarContratoPdf(idContrato, caminhoArquivo);
                MessageBox.Show("Contrato gerado com sucesso! Você pode visualizá-lo em: " + caminhoArquivo, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Não foi possível encontrar o aluno associado ao contrato.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cbMostrarTerminados_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbInativos.Checked;
            bool incluirTerminados = cbMostrarTerminados.Checked;
            AtualizarConsultaContratos(incluirInativos, incluirTerminados);
        }
    }
}
