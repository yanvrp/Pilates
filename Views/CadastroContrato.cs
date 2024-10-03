using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;
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
    public partial class CadastroContrato : Pilates.Views.CadastroPAI
    {
        private ConsultaAluno consultaAluno;
        private ConsultaCondicaoPagamento consultaCondicaoPagamento;
        private ConsultaPrograma consultaPrograma;
        private ControllerCondicaoPagamento<ModelCondicaoPagamento> controllerCondicaoPagamento;
        private ControllerContrato<ModelContrato> controllerContrato;
        private ControllerAluno<ModelAluno> controllerAluno;
        private ControllerPrograma<ModelPrograma> controllerPrograma;
        private ControllerContasReceber<ModelContasReceber> controllerContasReceber;
        public CadastroContrato()
        {
            InitializeComponent();
            consultaAluno = new ConsultaAluno();
            consultaCondicaoPagamento = new ConsultaCondicaoPagamento();
            consultaPrograma = new ConsultaPrograma();
            controllerCondicaoPagamento = new ControllerCondicaoPagamento<ModelCondicaoPagamento>();
            controllerContrato = new ControllerContrato<ModelContrato>();
            controllerAluno = new ControllerAluno<ModelAluno>();
            controllerPrograma = new ControllerPrograma<ModelPrograma>();
            controllerContasReceber = new ControllerContasReceber<ModelContasReceber>();
        }

        private void CadastroContrato_Load(object sender, EventArgs e)
        {
            if (Alterar == -7)
            {
                txtInicioPrograma.Text = DateTime.Now.ToString();
                int novoCodigo = controllerContrato.GetUltimoNumero() + 1;
                txtCodigo.Text = novoCodigo.ToString();
            }
        }
        public CadastroContrato(int idContrato) : this()
        {
            Alterar = idContrato;
            Carrega();
        }

        private void btnPesquisarAluno_Click(object sender, EventArgs e)
        {
            {
                consultaAluno.btnSair.Text = "Selecionar";

                if (consultaAluno.ShowDialog() == DialogResult.OK)
                {
                    var infosAluno = consultaAluno.Tag as Tuple<int, string>;
                    if (infosAluno != null)
                    {
                        int idAluno = infosAluno.Item1;
                        string Aluno = infosAluno.Item2;

                        txtCodAluno.Text = idAluno.ToString();
                        txtAluno.Text = Aluno;
                    }
                }
            }
        }

        private void btnPesquisarPrograma_Click(object sender, EventArgs e)
        {
            {
                consultaPrograma.btnSair.Text = "Selecionar";

                if (consultaPrograma.ShowDialog() == DialogResult.OK)
                {
                    var infosPrograma = consultaPrograma.Tag as Tuple<int, string, decimal, string, int>;
                    if (infosPrograma != null)
                    {
                        int idPrograma = infosPrograma.Item1;
                        string Programa = infosPrograma.Item2;
                        decimal valor = infosPrograma.Item3;
                        string tipoPrograma = infosPrograma.Item4;
                        int aulas = infosPrograma.Item5;

                        txtCodPrograma.Text = idPrograma.ToString();
                        txtPrograma.Text = Programa;
                        txtValorMensal.Text = valor.ToString();
                        txtTipoPrograma.Text = tipoPrograma;
                        txtAulas.Text = aulas.ToString();
                    }
                }
            }
        }

        private void btnPesquisarCond_Click(object sender, EventArgs e)
        {
            {
                consultaCondicaoPagamento.btnSair.Text = "Selecionar";

                if (consultaCondicaoPagamento.ShowDialog() == DialogResult.OK)
                {
                    var infosCondPag = consultaCondicaoPagamento.Tag as Tuple<int, string>;
                    if (infosCondPag != null)
                    {
                        int idCondPag = infosCondPag.Item1;
                        string condPag = infosCondPag.Item2;

                        txtCodCondPag.Text = idCondPag.ToString();
                        txtCondPagamento.Text = condPag;
                    }
                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ModelCondicaoPagamento condPagamento = controllerCondicaoPagamento.BuscarPorId(int.Parse(txtCodCondPag.Text));
            exibirParcelasDGV(condPagamento.Parcelas);
        }
        private void exibirParcelasDGV(List<ModelParcela> parcelas)
        {
            dataGridViewParcelas.Rows.Clear();
            DateTime dataAtual = DateTime.Today; //data atual
            decimal valorTotal;
            int diaMes;

            if (decimal.TryParse(txtValorTotal.Text, out valorTotal) &&
                int.TryParse(txtDiaPagar.Text, out diaMes))
            {
                //verifica se o dia do mês é válido
                if (diaMes < 1 || diaMes > 31)
                {
                    MessageBox.Show("Dia do mês inválido.");
                    return;
                }

                decimal somaParcelas = 0m;
                decimal valorParcelaBase = Math.Round(valorTotal / parcelas.Count, 2);
                decimal diferenca = valorTotal - (valorParcelaBase * parcelas.Count);
                DateTime dataParcela = dataAtual;

                for (int i = 0; i < parcelas.Count; i++)
                {
                    var parcela = parcelas[i]; //parcela atual
                    int codFormaPagamento = parcela.idFormaPagamento;
                    string formaPagamento = controllerCondicaoPagamento.GetFormaPagByParcelaId(parcela.idParcela);

                    //define a data de vencimento com base no dia do mês
                    if (i == 0)
                    {
                        //para a primeira parcela, define a data de vencimento no mesmo mês que a data atual
                        dataParcela = new DateTime(dataAtual.Year, dataAtual.Month, diaMes);
                        if (dataParcela <= dataAtual)
                        {
                            //se a data de vencimento estiver antes da data atual, passa pro prox mes
                            dataParcela = dataParcela.AddMonths(1);
                        }
                    }
                    else
                    {
                        //nas próximas parcelas, define a data de vencimento para o dia do mês do próximo mês
                        dataParcela = dataParcela.AddMonths(1);
                    }

                    //corrige se o dia do mês não for válido no mês específico
                    try
                    {
                        dataParcela = new DateTime(dataParcela.Year, dataParcela.Month, diaMes);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        //ajusta para o último dia do mês
                        dataParcela = new DateTime(dataParcela.Year, dataParcela.Month, DateTime.DaysInMonth(dataParcela.Year, dataParcela.Month));
                    }

                    decimal valorParcela = valorParcelaBase;

                    if (i == parcelas.Count - 1) //se for a última parcela
                    {
                        //adiciona a diferença à última parcela para corrigir arredondamentos  
                        valorParcela += diferenca;
                    }
                    somaParcelas += valorParcela;

                    dataGridViewParcelas.Rows.Add(
                        parcela.numeroParcela,
                        codFormaPagamento,
                        formaPagamento,
                        dataParcela.ToString("dd/MM/yyyy"),
                        valorParcela.ToString("F2")
                    );
                }
            }
            else
            {
                MessageBox.Show("Valor total ou dia do mês inválido.");
            }
        }
        public override void Carrega()
        {
            var contrato = controllerContrato.BuscarPorId(Alterar);
            if (contrato != null)
            {
                txtCodigo.Text = contrato.idContrato.ToString();
                txtCodAluno.Text = contrato.idAluno.ToString();
                txtCodPrograma.Text = contrato.idPrograma.ToString();
                txtHorario.Text = contrato.horario.ToString();
                txtPeriodo.Text = contrato.periodo.ToString();
                txtDiaPagar.Text = contrato.diaAcordado.ToString();
                txtValorTotal.Text = contrato.ValorTotal.ToString();
                txtCodCondPag.Text = contrato.idCondPag.ToString();
                txtDataCancelamento.Text = contrato.dataCancelamento.ToString();
                txtInicioPrograma.Text = contrato.dataInicioPrograma.ToString();
                txtDataCadastro.Text = contrato.dataCadastro.ToString();
                txtDataUltAlt.Text = contrato.dataUltAlt.ToString();
                rbAtivo.Checked = contrato.Ativo;
                rbInativo.Checked = !contrato.Ativo;
                ModelAluno aluno = controllerAluno.BuscarPorId(int.Parse(txtCodAluno.Text));
                ModelPrograma programa = controllerPrograma.BuscarPorId(int.Parse(txtCodPrograma.Text));
                ModelCondicaoPagamento condPagamento = controllerCondicaoPagamento.BuscarPorId(int.Parse(txtCodCondPag.Text));
                txtAluno.Text = aluno.Aluno.ToString();
                txtPrograma.Text = programa.titulo.ToString();
                txtCondPagamento.Text = condPagamento.condicaoPagamento.ToString();
                txtValorMensal.Text = programa.Valor.ToString();
                txtAulas.Text = programa.numeroAulas.ToString();
                txtTipoPrograma.Text = programa.tipoPrograma.ToString();

                exibirParcelasDGV(condPagamento.Parcelas);
            }
        }
        public override void Salvar()
        {
            if (!Validacoes.CampoObrigatorio(txtCodAluno.Text))
            {
                MessageBox.Show("Campo Código Aluno é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodAluno.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtCodPrograma.Text))
            {
                MessageBox.Show("Campo Código do programa é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodPrograma.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtHorario.Text))
            {
                MessageBox.Show("Campo horario é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHorario.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtDiaPagar.Text))
            {
                MessageBox.Show("Campo dia a pagar é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaPagar.Focus();
            }
            else
            {
                try
                {
                    int idAluno = Convert.ToInt32(txtCodAluno.Text);
                    int idPrograma = Convert.ToInt32(txtCodPrograma.Text);
                    int idCondPag = Convert.ToInt32(txtCodCondPag.Text);
                    int diaAcordado = Convert.ToInt32(txtDiaPagar.Text);
                    TimeSpan.TryParse(txtHorario.Text, out TimeSpan horario);
                    string periodo = txtPeriodo.Text;
                    decimal valorTotal = Convert.ToDecimal(txtValorTotal.Text);
                    DateTime.TryParse(txtInicioPrograma.Text, out DateTime dataInicioPrograma);
                    string dCancelamento = new string(txtDataCancelamento.Text.Where(char.IsDigit).ToArray());
                    DateTime? dataCancelamento = string.IsNullOrEmpty(dCancelamento) || dCancelamento.Length != 8 ? (DateTime?)null : DateTime.ParseExact(txtDataCancelamento.Text, "dd/MM/yyyy", null);
                    DateTime.TryParse(txtDataCadastro.Text, out DateTime dataCadastro);
                    DateTime dataUltAlt = Alterar != -7 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Text, out DateTime result) ? result : DateTime.MinValue;

                    ModelContrato novoContrato = new ModelContrato
                    {
                        idAluno = idAluno,
                        idPrograma = idPrograma,
                        idCondPag = idCondPag,
                        diaAcordado = diaAcordado,
                        horario = horario,
                        periodo = periodo,
                        ValorTotal = valorTotal,
                        dataInicioPrograma = dataInicioPrograma,
                        dataCancelamento = dataCancelamento,
                        dataCadastro = dataCadastro,
                        dataUltAlt = dataUltAlt,
                        Ativo = Ativo,
                    };
                    if (Alterar == -7)
                    {
                        controllerContrato.Salvar(novoContrato);
                    }
                    else
                    {
                        controllerContrato.Alterar(novoContrato);
                    }
                    try //salvar contas a receber
                    {
                        foreach (DataGridViewRow row in dataGridViewParcelas.Rows)
                        {
                            if (row.IsNewRow) continue;
                            //validação do que está no datagrid
                            if (row.Cells["idFormaPagamento"].Value == null || !int.TryParse(row.Cells["idFormaPagamento"].Value.ToString(), out int idFormaPagamento))
                            {
                                MessageBox.Show("Forma de pagamento inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            if (row.Cells["Parcela"].Value == null || !int.TryParse(row.Cells["Parcela"].Value.ToString(), out int parcela))
                            {
                                MessageBox.Show("Número de parcela inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            if (row.Cells["valorParcela"].Value == null || !decimal.TryParse(row.Cells["valorParcela"].Value.ToString(), out decimal valorParcela))
                            {
                                MessageBox.Show("Valor da parcela inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            if (row.Cells["dataVencimento"].Value == null || !DateTime.TryParse(row.Cells["dataVencimento"].Value.ToString(), out DateTime dataVencimento))
                            {
                                MessageBox.Show("Data de vencimento inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            ModelContasReceber contaReceber = new ModelContasReceber
                            {
                                numero = int.Parse(txtCodigo.Text),
                                idAluno = idAluno,
                                dataEmissao = dataInicioPrograma,
                                idFormaPagamento = idFormaPagamento,
                                parcela = parcela,
                                valorParcela = valorParcela,
                                dataVencimento = dataVencimento,
                                dataRecebimento = null,
                                desconto = null,
                                valorRecebido = null,
                                dataCancelamento = null,
                                observacao = "REFERENTE AO CONTRATO NÚMERO: " + txtCodigo.Text,
                                dataCadastro = DateTime.Now,
                                dataUltAlt = DateTime.Now
                            };

                            controllerContasReceber.Salvar(contaReceber);
                        }
                    }
                    catch (FormatException fe)
                    {
                        MessageBox.Show("Erro ao converter valores: " + fe.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao salvar as Contas a Receber: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CadastroContrato_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaContrato)this.Owner).AtualizarConsultaContratos(false);
        }
        private void CalculaValorTotal()
        {
            int multiplicador;
            decimal valorParcial;
            if (txtPrograma.Text.Length > 0 && txtPeriodo.Text.Length > 0)
            {
                switch (txtPeriodo.Text.ToLower())
                {
                    case "mensal":
                        multiplicador = 1;
                        break;
                    case "bimestral":
                        multiplicador = 2;
                        break;
                    case "trimestral":
                        multiplicador = 3;
                        break;
                    case "semestral":
                        multiplicador = 6;
                        break;
                    case "anual":
                        multiplicador = 12;
                        break;
                    default:
                        throw new ArgumentException("Periodicidade inválida");
                }
                ModelPrograma programa = controllerPrograma.BuscarPorId(int.Parse(txtCodPrograma.Text));
                valorParcial = programa.Valor;
                txtValorTotal.Text = (valorParcial * multiplicador).ToString();
            }
        }

        private void txtCodAluno_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodAluno.Text))
            {
                ModelAluno aluno = controllerAluno.BuscarPorId(int.Parse(txtCodAluno.Text));
                if (aluno != null)
                {
                    txtAluno.Text = aluno.Aluno;
                }
                else
                {
                    MessageBox.Show("Aluno não encontrado(a).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodAluno.Focus();
                    txtCodAluno.Clear();
                    txtCodAluno.Clear();
                }
            }
        }

        private void txtCodPrograma_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodPrograma.Text))
            {
                ModelPrograma programa = controllerPrograma.BuscarPorId(int.Parse(txtCodPrograma.Text));
                if (programa != null)
                {
                    txtPrograma.Text = programa.titulo;
                    txtAulas.Text = programa.numeroAulas.ToString();
                    txtTipoPrograma.Text = programa.tipoPrograma;
                    txtValorMensal.Text = programa.Valor.ToString();
                }
                else
                {
                    MessageBox.Show("Programa não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodAluno.Focus();
                    txtCodAluno.Clear();
                    txtCodAluno.Clear();
                }
            }
            CalculaValorTotal();
        }
        public void BloqueiaTudo()
        {
            //usado quando a conta já está paga ou está cancelada
            txtInicioPrograma.Enabled = false;
            txtCodAluno.Enabled = false;
            btnPesquisarAluno.Enabled = false;
            txtCodPrograma.Enabled = false;
            btnPesquisarPrograma.Enabled = false;
            txtHorario.Enabled = false;
            txtPeriodo.Enabled = false;
            txtDiaPagar.Enabled = false;
            txtCodCondPag.Enabled = false;
            btnPesquisarCond.Enabled = false;
            btnAdicionar.Enabled = false;
        }
        private void txtCodCondPag_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodCondPag.Text))
            {
                ModelCondicaoPagamento condPag = controllerCondicaoPagamento.BuscarPorId(int.Parse(txtCodCondPag.Text));
                if (condPag != null)
                {
                    txtCondPagamento.Text = condPag.condicaoPagamento;
                }
                else
                {
                    MessageBox.Show("Condição de Pagamento não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodCondPag.Focus();
                    txtCodCondPag.Clear();
                    txtCodCondPag.Clear();
                }
            }
        }

        private void txtPeriodo_Leave(object sender, EventArgs e)
        {
            CalculaValorTotal();
        }

        private void txtPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
