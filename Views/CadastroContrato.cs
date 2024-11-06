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
        private ControllerAgenda<ModelAgenda> controllerAgenda;

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
            controllerAgenda = new ControllerAgenda<ModelAgenda>();
            PreencherDropDownList();
        }

        private void CadastroContrato_Load(object sender, EventArgs e)
        {
            if (Alterar == -7)
            {
                txtInicioPrograma.Texts = DateTime.Now.ToString();
                int novoCodigo = controllerContrato.GetUltimoNumero() + 1;
                txtCodigo.Texts = novoCodigo.ToString();
            }
        }
        public CadastroContrato(int idContrato) : this()
        {
            Alterar = idContrato;
            Carrega();
        }
        private void PreencherDropDownList()
        {
            cbHoras.Items.Clear();
            for (int i = 6; i <= 22; i++)
            {
                cbHoras.Items.Add(i.ToString("D2")); 
            }

            cbMinutos.Items.Clear();
            cbMinutos.Items.Add("00");
            cbMinutos.Items.Add("30");
        }

        private void exibirParcelasDGV(List<ModelParcela> parcelas)
        {
            dataGridViewParcelas.Rows.Clear();
            DateTime dataAtual = DateTime.Today; //data atual
            decimal valorTotal;
            int diaMes;

            if (decimal.TryParse(txtValorTotal.Texts, out valorTotal) &&
                int.TryParse(txtDiaPagar.Texts, out diaMes))
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
                txtCodigo.Texts = contrato.idContrato.ToString();
                txtCodAluno.Texts = contrato.idAluno.ToString();
                txtCodPrograma.Texts = contrato.idPrograma.ToString();
                txtPeriodo.Text = contrato.periodo.ToString();
                txtDiaPagar.Texts = contrato.diaAcordado.ToString();
                txtValorTotal.Texts = contrato.ValorTotal.ToString();
                txtCodCondPag.Texts = contrato.idCondPag.ToString();
                txtDataCancelamento.Texts = contrato.dataCancelamento.ToString();
                txtFinalContrato.Texts = contrato.dataFinalContrato.ToString();
                txtInicioPrograma.Texts = contrato.dataInicioPrograma.ToString();
                txtDataCadastro.Texts = contrato.dataCadastro.ToString();
                txtDataUltAlt.Texts = contrato.dataUltAlt.ToString();
                rbAtivo.Checked = contrato.Ativo;
                rbInativo.Checked = !contrato.Ativo;

                ModelAluno aluno = controllerAluno.BuscarPorId(int.Parse(txtCodAluno.Texts));
                ModelPrograma programa = controllerPrograma.BuscarPorId(int.Parse(txtCodPrograma.Texts));
                ModelCondicaoPagamento condPagamento = controllerCondicaoPagamento.BuscarPorId(int.Parse(txtCodCondPag.Texts));

                txtAluno.Texts = aluno.Aluno.ToString();
                txtPrograma.Texts = programa.titulo.ToString();
                txtCondPagamento.Texts = condPagamento.condicaoPagamento.ToString();
                txtValorMensal.Texts = programa.Valor.ToString();
                txtAulas.Texts = programa.numeroAulas.ToString();
                txtTipoPrograma.Texts = programa.tipoPrograma.ToString();

                TimeSpan horario = contrato.horario;
                cbHoras.SelectedItem = horario.Hours.ToString("D2");
                cbMinutos.SelectedItem = horario.Minutes.ToString("D2");

                if (!string.IsNullOrEmpty(contrato.diasSemana))
                {
                    string[] diasSelecionados = contrato.diasSemana.Split(';');
                    foreach (string dia in diasSelecionados)
                    {
                        switch (dia)
                        {
                            case "SEGUNDA":
                                cbSegunda.Checked = true;
                                break;
                            case "TERÇA":
                                cbTerca.Checked = true;
                                break;
                            case "QUARTA":
                                cbQuarta.Checked = true;
                                break;
                            case "QUINTA":
                                cbQuinta.Checked = true;
                                break;
                            case "SEXTA":
                                cbSexta.Checked = true;
                                break;
                            case "SÁBADO":
                                cbSabado.Checked = true;
                                break;
                        }
                    }
                }

                exibirParcelasDGV(condPagamento.Parcelas);
            }
        }

        public override void Salvar()
        {
            if (!Validacoes.CampoObrigatorio(txtCodAluno.Texts))
            {
                MessageBox.Show("Campo Código Aluno é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodAluno.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtCodPrograma.Texts))
            {
                MessageBox.Show("Campo Código do programa é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodPrograma.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(cbHoras.Text))
            {
                MessageBox.Show("Campo Horas é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbHoras.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(cbMinutos.Text))
            {
                MessageBox.Show("Campo Minutos é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbMinutos.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtDiaPagar.Texts))
            {
                MessageBox.Show("Campo Dia a Pagar é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaPagar.Focus();
            }
            else if (dataGridViewParcelas.Rows.Count <= 0)
            {
                MessageBox.Show("É necessário adicionar pelo menos uma parcela", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodCondPag.Focus();
            }
            else
            {
                try
                {
                    int numeroAulasSelecionadas = 0;
                    List<string> diasSelecionados = new List<string>(); // Mudamos o tipo para string

                    if (cbSegunda.Checked) { numeroAulasSelecionadas++; diasSelecionados.Add("SEGUNDA"); }
                    if (cbTerca.Checked) { numeroAulasSelecionadas++; diasSelecionados.Add("TERÇA"); }
                    if (cbQuarta.Checked) { numeroAulasSelecionadas++; diasSelecionados.Add("QUARTA"); }
                    if (cbQuinta.Checked) { numeroAulasSelecionadas++; diasSelecionados.Add("QUINTA"); }
                    if (cbSexta.Checked) { numeroAulasSelecionadas++; diasSelecionados.Add("SEXTA"); }
                    if (cbSabado.Checked) { numeroAulasSelecionadas++; diasSelecionados.Add("SÁBADO"); }

                    int numeroAulasDefinidas = Convert.ToInt32(txtAulas.Texts);
                    if (numeroAulasSelecionadas != numeroAulasDefinidas)
                    {
                        MessageBox.Show($"Número de aulas selecionadas ({numeroAulasSelecionadas}) não corresponde ao número definido ({numeroAulasDefinidas}).",
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DateTime.TryParse(txtInicioPrograma.Texts, out DateTime dataInicioPrograma);

                    string periodo = txtPeriodo.Text;
                    int periodoMeses = periodo == "MENSAL" ? 1 :
                                       periodo == "TRIMESTRAL" ? 3 :
                                       periodo == "SEMESTRAL" ? 6 :
                                       periodo == "ANUAL" ? 12 : 0;
                    DateTime dataFimPrograma = dataInicioPrograma.AddMonths(periodoMeses);

                    int idAluno = Convert.ToInt32(txtCodAluno.Texts);
                    int idPrograma = Convert.ToInt32(txtCodPrograma.Texts);
                    int idCondPag = Convert.ToInt32(txtCodCondPag.Texts);
                    int diaAcordado = Convert.ToInt32(txtDiaPagar.Texts);

                    string horas = cbHoras.Text;
                    string minutos = cbMinutos.Text;
                    string horarioString = $"{horas}:{minutos}";
                    TimeSpan horario = TimeSpan.Parse(horarioString);

                    decimal valorTotal = Convert.ToDecimal(txtValorTotal.Texts);
                   
                    string dCancelamento = new string(txtDataCancelamento.Texts.Where(char.IsDigit).ToArray());
                    DateTime? dataCancelamento = string.IsNullOrEmpty(dCancelamento) || dCancelamento.Length != 8 ? (DateTime?)null : DateTime.ParseExact(txtDataCancelamento.Texts, "dd/MM/yyyy", null);
                    
                    string dFinalContrato = new string(txtFinalContrato.Texts.Where(char.IsDigit).ToArray());
                    DateTime? dataFinalContrato = string.IsNullOrEmpty(dFinalContrato) || dFinalContrato.Length != 8 ? (DateTime?)null : DateTime.ParseExact(txtFinalContrato.Texts, "dd/MM/yyyy", null);
                    
                    DateTime.TryParse(txtDataCadastro.Texts, out DateTime dataCadastro);
                    DateTime dataUltAlt = Alterar != -7 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Texts, out DateTime result) ? result : DateTime.MinValue;

                    ModelContrato novoContrato = new ModelContrato
                    {
                        idAluno = idAluno,
                        idPrograma = idPrograma,
                        idCondPag = idCondPag,
                        diaAcordado = diaAcordado,
                        diasSemana = string.Join(";", diasSelecionados.Select(d => d.ToString())),
                        horario = horario,
                        periodo = periodo,
                        ValorTotal = valorTotal,
                        dataInicioPrograma = dataInicioPrograma,
                        dataCancelamento = dataCancelamento,
                        dataFinalContrato = dataFinalContrato,
                        dataCadastro = dataCadastro,
                        dataUltAlt = dataUltAlt,
                        Ativo = Ativo,
                    };
                    if (Alterar == -7)
                    {
                        novoContrato.idContrato = controllerContrato.SalvarC(novoContrato);
                    }
                    else
                    {
                        controllerContrato.Alterar(novoContrato);
                    }

                    List<ModelAgenda> aulasAgenda = new List<ModelAgenda>();

                    for (DateTime data = dataInicioPrograma; data <= dataFimPrograma; data = data.AddDays(1))
                    {
                        //mapeamento dos dias da semana para DayOfWeek
                        DayOfWeek diaAtual = data.DayOfWeek;
                        string diaFormatado = diaAtual switch
                        {
                            DayOfWeek.Monday => "SEGUNDA",
                            DayOfWeek.Tuesday => "TERÇA",
                            DayOfWeek.Wednesday => "QUARTA",
                            DayOfWeek.Thursday => "QUINTA",
                            DayOfWeek.Friday => "SEXTA",
                            DayOfWeek.Saturday => "SÁBADO",
                            DayOfWeek.Sunday => "DOMINGO",
                            _ => throw new ArgumentOutOfRangeException()
                        };

                        //ve dia atual
                        if (diasSelecionados.Contains(diaFormatado))
                        {
                            //ve se a aula marcada e horario ja passou
                            if (data == DateTime.Today && horario < DateTime.Now.TimeOfDay)
                            {
                                continue; //se passou, para pra prox data
                            }
                            if (data == dataInicioPrograma && diaFormatado == DateTime.Today.ToString("dddd").ToUpper() && horario.Hours == DateTime.Now.Hour && horario.Minutes == DateTime.Now.Minute)
                            {
                                data = data.AddDays(7);
                                continue;
                            }

                            ModelAgenda aula = new ModelAgenda
                            {
                                idAluno = idAluno,
                                idContrato = novoContrato.idContrato,
                                horario = horario,
                                data = data,
                                situacao = null,
                                Ativo = Ativo,
                                dataCadastro = dataCadastro,
                                dataUltAlt = dataUltAlt
                            };
                            aulasAgenda.Add(aula);
                        }
                    }

                    foreach (var aula in aulasAgenda)
                    {
                        controllerAgenda.Salvar(aula);
                    }

                    MessageBox.Show("Contrato e agenda salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;

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
                                numero = int.Parse(txtCodigo.Texts),
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
                                observacao = "REFERENTE AO CONTRATO NÚMERO: " + txtCodigo.Texts,
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

            if (txtPrograma.Texts.Length > 0 && txtPeriodo.Text.Length > 0)
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

                ModelPrograma programa = controllerPrograma.BuscarPorId(int.Parse(txtCodPrograma.Texts));
                valorParcial = programa.Valor;

                txtValorTotal.Texts = (valorParcial * multiplicador).ToString();

                if (DateTime.TryParse(txtInicioPrograma.Texts, out DateTime dataInicio))
                {
                    DateTime dataFinalContrato = dataInicio.AddMonths(multiplicador);
                    txtFinalContrato.Texts = dataFinalContrato.ToString("dd/MM/yyyy"); 
                }
                else
                {
                    MessageBox.Show("Data de início do programa inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtInicioPrograma.Focus();
                }
            }
        }


        public void BloqueiaTudo()
        {
            txtInicioPrograma.Enabled = false;
            txtCodAluno.Enabled = false;
            btnPesquisarAluno.Enabled = false;
            txtCodPrograma.Enabled = false;
            btnPesquisarPrograma.Enabled = false;
            cbHoras.Enabled = false;
            cbMinutos.Enabled = false;
            txtPeriodo.Enabled = false;
            txtDiaPagar.Enabled = false;
            txtCodCondPag.Enabled = false;
            btnPesquisarCond.Enabled = false;
            btnAdicionar.Enabled = false;
            cbSegunda.Enabled = false;
            cbTerca.Enabled = false;
            cbQuarta.Enabled = false;
            cbQuinta.Enabled = false;
            cbSexta.Enabled = false;
            cbSabado.Enabled = false;

            btnCancelar.Visible = true;
        }

        private void txtPeriodo_Leave(object sender, EventArgs e)
        {
            CalculaValorTotal();            
        }

        private void txtPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisarAluno_Click(object sender, EventArgs e)
        {
            consultaAluno.btnSair.Text = "Selecionar";
            consultaAluno.cbInativos.Visible = false;

            if (consultaAluno.ShowDialog() == DialogResult.OK)
            {
                var infosAluno = consultaAluno.Tag as Tuple<int, string>;
                if (infosAluno != null)
                {
                    int idAluno = infosAluno.Item1;
                    string Aluno = infosAluno.Item2;

                    txtCodAluno.Texts = idAluno.ToString();
                    txtAluno.Texts = Aluno;
                }
            }
        }

        private void btnPesquisarCond_Click(object sender, EventArgs e)
        {
            consultaCondicaoPagamento.btnSair.Text = "Selecionar";
            consultaCondicaoPagamento.cbInativos.Visible = false;

            if (consultaCondicaoPagamento.ShowDialog() == DialogResult.OK)
            {
                var infosCondPag = consultaCondicaoPagamento.Tag as Tuple<int, string>;
                if (infosCondPag != null)
                {
                    int idCondPag = infosCondPag.Item1;
                    string condPag = infosCondPag.Item2;

                    txtCodCondPag.Texts = idCondPag.ToString();
                    txtCondPagamento.Texts = condPag;
                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ModelCondicaoPagamento condPagamento = controllerCondicaoPagamento.BuscarPorId(int.Parse(txtCodCondPag.Texts));
            exibirParcelasDGV(condPagamento.Parcelas);
        }

        private void btnPesquisarPrograma_Click(object sender, EventArgs e)
        {
            consultaPrograma.btnSair.Text = "Selecionar";
            consultaPrograma.cbInativos.Visible = false;

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

                    txtCodPrograma.Texts = idPrograma.ToString();
                    txtPrograma.Texts = Programa;
                    txtValorMensal.Texts = valor.ToString();
                    txtTipoPrograma.Texts = tipoPrograma;
                    txtAulas.Texts = aulas.ToString();
                }
            }
        }

        private void txtCodAluno_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodAluno.Texts))
            {
                string aluno = controllerAluno.getAluno(int.Parse(txtCodAluno.Texts));
                if (aluno != null)
                {
                    txtAluno.Texts = aluno;
                }
                else
                {
                    MessageBox.Show("Aluno não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodAluno.Focus();
                    txtCodAluno.Clear();
                    txtAluno.Clear();
                }
            }
        }

        private void txtCodPrograma_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodPrograma.Texts))
            {
                ModelPrograma programa = controllerPrograma.getPrograma(int.Parse(txtCodPrograma.Texts));
                if (programa != null)
                {
                    txtPrograma.Texts = programa.titulo;
                    txtAulas.Texts = programa.numeroAulas.ToString();
                    txtTipoPrograma.Texts = programa.tipoPrograma;
                    txtValorMensal.Texts = programa.Valor.ToString();
                }
                else
                {
                    MessageBox.Show("Programa não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodPrograma.Focus();
                    txtCodPrograma.Clear();
                    txtPrograma.Clear();
                    txtAulas.Clear();
                    txtTipoPrograma.Clear();
                    txtValorMensal.Clear();
                }
            }
            CalculaValorTotal();
        }

        private void txtCodCondPag_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodCondPag.Texts))
            {
                string condPagamento = controllerCondicaoPagamento.getCondicaoPag(int.Parse(txtCodCondPag.Texts));
                if (condPagamento != null)
                {
                    txtCondPagamento.Texts = condPagamento;
                }
                else
                {
                    MessageBox.Show("Condição de Pagamento não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodCondPag.Focus();
                    txtCodCondPag.Clear();
                    txtCondPagamento.Clear();
                }
            }
        }

        private void txtCodAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodPrograma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodCondPag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHorario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ':')
            {
                e.Handled = true;
            }
        }

        private void txtDiaPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtInicioPrograma_Leave(object sender, EventArgs e)
        {
            DateTime dataInicio;
            string dataI = new string(txtInicioPrograma.Texts.Where(char.IsDigit).ToArray());
            bool dataValida = DateTime.TryParse(txtInicioPrograma.Texts, out dataInicio);

            if (!string.IsNullOrEmpty(dataI))
            {
                if (!dataValida)
                {
                    MessageBox.Show("Data de Início do Programa inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtInicioPrograma.Focus();
                    return;
                }
                if (!Validacoes.VerificarDataMenorOuIgualHoje(dataInicio.ToString("dd/MM/yyyy"), "Início Programa"))
                {
                    txtInicioPrograma.Focus();
                    return;
                }
            }
        }
        private string diasSelecionados = string.Empty;

        private void AtualizarDiasSelecionados()
        {
            diasSelecionados = string.Empty; 

            if (cbSegunda.Checked)
                diasSelecionados += "SEGUNDA;";
            if (cbTerca.Checked)
                diasSelecionados += "TERÇA;";
            if (cbQuarta.Checked)
                diasSelecionados += "QUARTA;";
            if (cbQuinta.Checked)
                diasSelecionados += "QUINTA;";
            if (cbSexta.Checked)
                diasSelecionados += "SEXTA;";
            if (cbSabado.Checked)
                diasSelecionados += "SÁBADO;";

            if (diasSelecionados.Length > 0)
            {
                diasSelecionados = diasSelecionados.TrimEnd(';'); 
            }
        }

        private void cbSegunda_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarDiasSelecionados();
        }

        private void cbTerca_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarDiasSelecionados();
        }

        private void cbQuarta_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarDiasSelecionados();
        }

        private void cbQuinta_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarDiasSelecionados();
        }

        private void cbSexta_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarDiasSelecionados();
        }

        private void cbSabado_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarDiasSelecionados();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DateTime.TryParse(txtFinalContrato.Texts, out DateTime dataFinalContrato);
            if (dataFinalContrato < DateTime.Now)
            {
                MessageBox.Show("Este contrato já foi finalizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string dCancelamento = new string(txtDataCancelamento.Texts.Where(char.IsDigit).ToArray());
            if (dCancelamento == "")
            {
                DialogResult result = MessageBox.Show("Você tem certeza que deseja cancelar o contrato?",
                                          "Confirmação de Cancelamento",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int idContrato = Convert.ToInt32(txtCodigo.Texts);
                    controllerContrato.CancelarContrato(idContrato);

                    MessageBox.Show("Contrato cancelado com sucesso!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("O Contrato já foi cancelado anteriormente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtDiaPagar_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDiaPagar.Texts))
            {
                if (int.TryParse(txtDiaPagar.Texts, out int diaAPagar))
                {
                    if (diaAPagar < 1 || diaAPagar > 28)
                    {
                        MessageBox.Show("O dia a pagar deve ser entre os dias 1 e 28.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDiaPagar.Focus();
                        txtDiaPagar.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira um número válido para o dia a pagar.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDiaPagar.Focus();
                    txtDiaPagar.Clear();
                }
            }
        }
    }
}
