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
    public partial class CadastroContasPagar : Pilates.Views.CadastroPAI
    {
        private ConsultaFormaPagamento consultaFormaPagamento;
        private ControllerFormaPagamento<ModelFormaPagamento> controllerFormaPagamento;
        private ControllerContasPagar<ModelContasPagar> controllerContasPagar;
        private ConsultaFornecedor consultaFornecedor;
        private ControllerFornecedor<ModelFornecedor> controllerFornecedor;
        int Numero;
        int Parcela;
        decimal? porcentagemJuros;
        decimal? porcentagemMulta;
        decimal? porcentagemDesconto;
        public CadastroContasPagar()
        {
            InitializeComponent();
            consultaFormaPagamento = new ConsultaFormaPagamento();
            controllerFormaPagamento = new ControllerFormaPagamento<ModelFormaPagamento>();
            controllerContasPagar = new ControllerContasPagar<ModelContasPagar>();
            consultaFornecedor = new ConsultaFornecedor();
            controllerFornecedor = new ControllerFornecedor<ModelFornecedor>();
            Numero = -1;
            Parcela = -1;
        }
        public CadastroContasPagar(int numero, int parcela) : this()
        {
            Numero = numero;
            Parcela = parcela;
            Carrega();
        }

        private void CadastroContasPagar_Load(object sender, EventArgs e)
        {
            if (Numero != -1 && Parcela != -1)
            {
                btnPagar.Visible = true;
                btnSalvar.Visible = true;
            } else
            {
                btnPagar.Visible = false;
                btnCancelar.Visible = false;
            }
        }
        public override void Carrega()
        {
            base.Carrega();
            var contasPagar = controllerContasPagar.GetContaById(Numero, Parcela);
            if (contasPagar != null)
            {
                txtNumero.Texts = contasPagar.numero.ToString();
                txtDataEmissao.Texts = contasPagar.dataEmissao.ToString();
                txtCodFormaPag.Texts = contasPagar.idFormaPagamento.ToString();
                txtCodFornecedor.Texts = contasPagar.idFornecedor.ToString();
                txtParcelas.Texts = contasPagar.parcela.ToString();
                txtValorParcela.Texts = contasPagar.valorParcela.ToString();
                txtDataVencimento.Texts = contasPagar.dataVencimento.ToString();
                porcentagemJuros = contasPagar.juros;
                porcentagemMulta = contasPagar.multa;
                porcentagemDesconto = contasPagar.desconto;
                txtValorPago.Texts = contasPagar.valorPago.ToString();
                txtDataPagamento.Texts = contasPagar.dataPagamento.ToString();
                txtObservacao.Texts = contasPagar.observacao.ToString();
                txtDataCancelamento.Texts = contasPagar.dataCancelamento.ToString();
                txtDataCadastro.Texts = contasPagar.dataCadastro.ToString();
                txtDataUltAlt.Texts = contasPagar.dataUltAlt.ToString();
                txtUsuarioUltAlt.Texts = contasPagar.usuarioUltAlt;

                ModelFormaPagamento formaPagamento = controllerFormaPagamento.BuscarPorId(int.Parse(txtCodFormaPag.Texts));
                ModelFornecedor fornecedor = controllerFornecedor.BuscarPorId(int.Parse(txtCodFornecedor.Texts));
                if (fornecedor != null)
                    txtFornecedor.Texts = fornecedor.fornecedor_razao_social;

                if (formaPagamento != null)
                    txtFormaPag.Texts = formaPagamento.formaPagamento;

                if (contasPagar.dataCancelamento != null)
                {
                    btnCancelar.Visible = false;
                    BloqueiaTudo();
                }
                else
                {
                    btnCancelar.Visible = true;
                }
                if (contasPagar.dataPagamento == null)
                {
                    calcularJuros();
                    calcularMulta();
                    calcularDesconto();
                }
                else
                {
                    BloqueiaTudo();
                }
                calculaTotalPagar();
            }
        }
        public override void Salvar()
        {
            if (!VerificaCamposObrigatorios())
            {
                return;
            }
            int numero = int.Parse(txtNumero.Texts);
            int parcela = int.Parse(txtParcelas.Texts);

            bool incluindo = Numero == -1 && Parcela == -1;

            if (controllerContasPagar.JaCadastrado(numero, parcela, incluindo))
            {
                MessageBox.Show("Conta a pagar já cadastrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DateTime.TryParse(txtDataEmissao.Texts, out DateTime dataEmissao);
                int idFormaPag = Convert.ToInt32(txtCodFormaPag.Texts);
                int idFornecedor = Convert.ToInt32(txtCodFornecedor.Texts);
                int parcelas = Convert.ToInt32(txtParcelas.Texts);
                decimal valorParcela = Convert.ToDecimal(txtValorParcela.Texts);
                DateTime.TryParse(txtDataVencimento.Texts, out DateTime dataVencimento);
                string dPagamento = new string(txtDataPagamento.Texts.Where(char.IsDigit).ToArray());
                DateTime? dataPagamento = string.IsNullOrEmpty(dPagamento) || dPagamento.Length != 8 ? (DateTime?)null : DateTime.ParseExact(txtDataPagamento.Texts, "dd/MM/yyyy", null);
                decimal valorPago = string.IsNullOrEmpty(txtValorPago.Texts) ? 0 : Convert.ToDecimal(txtValorPago.Texts);
                string dCancelamento = new string(txtDataCancelamento.Texts.Where(char.IsDigit).ToArray());
                DateTime? dataCancelamento = string.IsNullOrEmpty(dCancelamento) || dCancelamento.Length != 8 ? (DateTime?)null : DateTime.ParseExact(txtDataCancelamento.Texts, "dd/MM/yyyy", null);
                string observacao = txtObservacao.Texts;
                DateTime.TryParse(txtDataCadastro.Texts, out DateTime dataCadastro);
                DateTime dataUltAlt = Alterar != -7 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Texts, out DateTime result) ? result : DateTime.MinValue;
                string usuario = Program.usuarioLogado;

                ModelContasPagar novaContaPagar = new ModelContasPagar
                {
                    numero = numero,
                    dataEmissao = dataEmissao,
                    idFormaPagamento = idFormaPag,
                    idFornecedor = idFornecedor,
                    parcela = parcela,
                    valorParcela = valorParcela,
                    dataVencimento = dataVencimento,
                    dataPagamento = dataPagamento,
                    valorPago = valorPago,
                    dataCancelamento = dataCancelamento,
                    desconto = porcentagemDesconto,
                    juros = porcentagemJuros,
                    multa = porcentagemMulta,
                    observacao = observacao,
                    dataCadastro = dataCadastro,
                    dataUltAlt = dataUltAlt,
                    usuarioUltAlt = usuario
                };
                if (Numero != -1 && Parcela != -1)
                {
                    controllerContasPagar.Alterar(novaContaPagar);
                }
                else
                {
                    controllerContasPagar.Salvar(novaContaPagar);
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected bool VerificaCamposObrigatorios()
        {
            string dEmissao = new string(txtDataEmissao.Texts.Where(char.IsDigit).ToArray());
            string dVencimento = new string(txtDataVencimento.Texts.Where(char.IsDigit).ToArray());
            if (!Validacoes.CampoObrigatorio(txtNumero.Texts))
            {
                MessageBox.Show("Campo Número é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Focus();
                return false;
            }
            if (!Validacoes.CampoObrigatorio(dEmissao))
            {
                MessageBox.Show("Campo Data Emissão é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDataEmissao.Focus();
                return false;
            }
            if (!Validacoes.CampoObrigatorio(txtCodFormaPag.Texts))
            {
                MessageBox.Show("Campo Código Forma Pagamento é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodFormaPag.Focus();
                return false;
            }
            if (!Validacoes.CampoObrigatorio(txtCodFornecedor.Texts))
            {
                MessageBox.Show("Campo Código fornecedor é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodFornecedor.Focus();
                return false;
            }
            if (!Validacoes.CampoObrigatorio(txtParcelas.Texts))
            {
                MessageBox.Show("Campo Nº Parcela é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtParcelas.Focus();
                return false;
            }
            if (!Validacoes.CampoObrigatorio(txtValorParcela.Texts))
            {
                MessageBox.Show("Campo Valor Parcela é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValorParcela.Focus();
                return false;
            }
            if (!Validacoes.CampoObrigatorio(dVencimento))
            {
                MessageBox.Show("Campo Data Vencimento é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDataVencimento.Focus();
                return false;
            }
            return true;
        }
        private void calcularJuros()
        {
            if (Validacoes.DataValida(txtDataVencimento.Texts))
            {
                DateTime dataVencimento = DateTime.Parse(txtDataVencimento.Texts);
                DateTime dataAtual = DateTime.Now;

                int diasAtraso = (dataAtual - dataVencimento).Days;
                decimal valorJuros = 0;

                if (diasAtraso > 0 && porcentagemJuros.HasValue)
                {
                    valorJuros = (diasAtraso * porcentagemJuros.Value / 100) * Convert.ToDecimal(txtValorParcela.Texts);
                }
                txtJuros.Texts = valorJuros.ToString("N2");
            }
        }
        private void calcularMulta()
        {
            if (Validacoes.DataValida(txtDataVencimento.Texts))
            {
                DateTime dataVencimento = Convert.ToDateTime(txtDataVencimento.Texts).Date;
                DateTime dataAtual = DateTime.Now.Date;

                //verifica se a data atual é posterior à data de vencimento
                if (dataAtual > dataVencimento && porcentagemMulta.HasValue)
                {
                    //aplica a porcentagem da multa ao valor da parcela
                    decimal valorParcela = Convert.ToDecimal(txtValorParcela.Texts);
                    decimal valorMulta = (porcentagemMulta.Value / 100) * valorParcela;

                    txtMulta.Texts = valorMulta.ToString("N2");
                }
                else
                {
                    //se não houver atraso, a multa é zero
                    txtMulta.Texts = "0.00";
                }
            }
        }
        private void calcularDesconto()
        {
            if (Validacoes.DataValida(txtDataVencimento.Texts))
            {
                DateTime dataVencimento = Convert.ToDateTime(txtDataVencimento.Texts).Date;
                DateTime dataAtual = DateTime.Now.Date;

                //verificar se a data atual é menor ou igual à data de vencimento.
                if (dataAtual <= dataVencimento)
                {
                    if (porcentagemDesconto.HasValue && !string.IsNullOrWhiteSpace(txtValorParcela.Texts))
                    {
                        decimal valorParcela = Convert.ToDecimal(txtValorParcela.Texts);
                        decimal valorDesconto = (porcentagemDesconto.Value / 100) * valorParcela;

                        txtDesconto.Texts = valorDesconto.ToString("N2");
                    }
                    else
                    {
                        txtDesconto.Texts = "0.00";
                    }
                }
                else
                {
                    //se a data de vencimento já passou, o desconto deve ser zero.
                    txtDesconto.Texts = "0.00";
                }
            }
        }

        private void calculaTotalPagar()
        {
            decimal valorDesconto = string.IsNullOrWhiteSpace(txtDesconto.Texts) ? 0 : Convert.ToDecimal(txtDesconto.Texts);
            decimal valorJuros = string.IsNullOrWhiteSpace(txtJuros.Texts) ? 0 : Convert.ToDecimal(txtJuros.Texts);
            decimal valorMulta = string.IsNullOrWhiteSpace(txtMulta.Texts) ? 0 : Convert.ToDecimal(txtMulta.Texts);
            decimal valorParcela = string.IsNullOrWhiteSpace(txtValorParcela.Texts) ? 0 : Convert.ToDecimal(txtValorParcela.Texts);

            decimal totalPagar = valorParcela + valorJuros + valorMulta - valorDesconto;
            txtTotalPagar.Texts = totalPagar.ToString("N2");
        }

        private void CadastroContasPagar_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaContasPagar)this.Owner).AtualizarConsultaContasPagar(false);
        }

        public override void Bloqueia()
        {
            base.Bloqueia();
            txtNumero.Enabled = false;
            txtDataEmissao.Enabled = false;
            txtCodFormaPag.Enabled = false;
            txtCodFornecedor.Enabled = false;
            txtParcelas.Enabled = false;
            txtValorParcela.Enabled = false;
            btnPesquisarFormaPag.Enabled = false;
            btnPesquisaFornecedor .Enabled = false;
            txtDataVencimento.Enabled = false;
            txtJuros.Enabled = false;
            txtMulta.Enabled = false;
            txtDesconto.Enabled = false;
            txtValorPago.Enabled = false;
            txtDataVencimento.Enabled = false;
        }
        public void BloqueiaTudo()
        {
            //usado quando a conta já está paga ou está cancelada
            txtJuros.Enabled = false;
            txtMulta.Enabled = false;
            txtDesconto.Enabled = false;
            txtValorPago.Enabled = false;
            txtDataVencimento.Enabled = false;
        }
        private void btnPesquisarFormaPag_Click(object sender, EventArgs e)
        {
            consultaFormaPagamento.btnSair.Text = "Selecionar";

            if (consultaFormaPagamento.ShowDialog() == DialogResult.OK)
            {
                var infosFormaPag = consultaFormaPagamento.Tag as Tuple<int, string>;
                if (infosFormaPag != null)
                {
                    int idFormaPag = infosFormaPag.Item1;
                    string formaPag = infosFormaPag.Item2;

                    txtCodFormaPag.Texts = idFormaPag.ToString();
                    txtFormaPag.Texts = formaPag;
                }
            }
        }

        private void txtCodFormaPag_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodFormaPag.Texts))
            {
                ModelFormaPagamento formaPag = controllerFormaPagamento.BuscarPorId(int.Parse(txtCodFormaPag.Texts));
                if (formaPag != null)
                {
                    txtFormaPag.Texts = formaPag.formaPagamento;
                }
                else
                {
                    MessageBox.Show("Forma de Pagamento não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodFormaPag.Focus();
                    txtCodFormaPag.Clear();
                    txtFormaPag.Clear();
                }
            }
        }

        private void txtDataVencimento_Leave(object sender, EventArgs e)
        {
            string dVencimento = new string(txtDataVencimento.Texts.Where(char.IsDigit).ToArray());
            string dEmissao = new string(txtDataEmissao.Texts.Where(char.IsDigit).ToArray());
            if (!string.IsNullOrEmpty(dVencimento) && !string.IsNullOrEmpty(dEmissao))
            {
                if (Validacoes.DataValida(txtDataEmissao.Texts) && Validacoes.DataValida(txtDataVencimento.Texts))
                {
                    DateTime dataEmissao;
                    DateTime dataVencimento;

                    bool dataEmissaoValida = DateTime.TryParseExact(txtDataEmissao.Texts, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataEmissao);
                    bool dataVencimentoValida = DateTime.TryParseExact(txtDataVencimento.Texts, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataVencimento);

                    if (dataEmissaoValida && dataVencimentoValida)
                    {
                        if (dataVencimento < dataEmissao)
                        {
                            MessageBox.Show("Data de vencimento inválida! A data de vencimento deve ser maior ou igual à data de emissão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtDataVencimento.Focus();
                            return;
                        }
                    }
                    calcularJuros();
                    calcularMulta();
                    calcularDesconto();
                }
                else
                {
                    MessageBox.Show("Data de emissão ou data de vencimento inválida! Verifique os valores inseridos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDataVencimento.Focus();
                }
            }
        }

        private void txtValorPago_Leave(object sender, EventArgs e)
        {
            txtValorPago.Texts = Validacoes.FormataPreco(txtValorPago.Texts);
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            string dPagamento = new string(txtDataPagamento.Texts.Where(char.IsDigit).ToArray());
            string dCancelamento = new string(txtDataCancelamento.Texts.Where(char.IsDigit).ToArray());

            if (!string.IsNullOrEmpty(dCancelamento))
            {
                MessageBox.Show("Contrato Cancelada! Não é possível efetuar o pagamento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(dPagamento))
            {
                MessageBox.Show("Pagamento já foi realizado dia " + txtDataPagamento.Texts, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //parcela atual
            int parcelaAtual = Convert.ToInt32(txtParcelas.Texts);
            string numero = txtNumero.Texts;

            //verificar se existe uma parcela menor não paga
            bool parcelaNaoPaga = controllerContasPagar.VerificarParcelasNaoPagas(numero, parcelaAtual);

            if (parcelaNaoPaga)
            {
                MessageBox.Show("Existem parcelas anteriores que não foram pagas. Pague as parcelas anteriores antes de pagar esta.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //se não existe parcelas menor não pagas, permitir o pagamento
            if (MessageBox.Show("Deseja realizar o pagamento?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Salvar();
                txtDataPagamento.Texts = DateTime.Now.ToString();
                txtValorPago.Texts = txtTotalPagar.Texts;
                Salvar();
            }
        }

        private void txtDataEmissao_Leave(object sender, EventArgs e)
        {
            DateTime dataEmissao;
            DateTime dataHoje = DateTime.Now;
            bool dataValida = DateTime.TryParse(txtDataEmissao.Texts, out dataEmissao);

            string dataE = new string(txtDataEmissao.Texts.Where(char.IsDigit).ToArray());

            if (!string.IsNullOrEmpty(dataE))
            {
                if (Validacoes.DataValida(txtDataEmissao.Texts))
                {
                    if (!string.IsNullOrWhiteSpace(dataE) && dataValida)
                    {
                        if (dataEmissao > dataHoje)
                        {
                            MessageBox.Show("Data de emissão inválida! A data deve ser menor ou igual a hoje.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtDataEmissao.Focus();
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Data de emissão inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDataEmissao.Focus();
                    return;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string dPagamento = new string(txtDataPagamento.Texts.Where(char.IsDigit).ToArray());
            DialogResult result = MessageBox.Show("Tem certeza que deseja cancelar esta conta a PAGAR?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(dPagamento))
                {
                    try
                    {
                        ModelContasPagar contaPagar = new ModelContasPagar
                        {
                            numero = Numero,
                            parcela = Parcela,
                            dataCancelamento = DateTime.Now
                        };
                        bool cancelamentoRealizado = controllerContasPagar.CancelarConta(contaPagar);

                        if (cancelamentoRealizado)
                        {
                            txtDataCancelamento.Texts = contaPagar.dataCancelamento?.ToString("dd/MM/yyyy");
                            lblDataCancelamento.Visible = true;
                            txtDataCancelamento.Visible = true;
                            BloqueiaTudo();

                            MessageBox.Show("Conta a pagar cancelada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível cancelar a conta, pois ela está associada a um contrato.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao cancelar a conta: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Não é possível cancelar uma conta que o pagamento já foi realizado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtParcelas_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtValorParcela_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtValorParcela_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtValorParcela.Texts))
            {
                try
                {
                    txtValorParcela.Texts = Validacoes.FormataPreco(txtValorParcela.Texts);

                    //verifica se o valor é maior que zero
                    if (decimal.TryParse(txtValorParcela.Texts, out decimal preco) && preco > 0)
                    {
                        //valor é válido e maior que zero
                    }
                    else
                    {
                        MessageBox.Show("O valor deve ser maior que zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtValorParcela.Focus();
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtValorParcela.Focus();
                }
            }
        }

        private void txtJuros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodFormaPag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnPesquisaFornecedor_Click(object sender, EventArgs e)
        {
            consultaFornecedor.btnSair.Text = "Selecionar";

            if (consultaFornecedor.ShowDialog() == DialogResult.OK)
            {
                var infosFornecedor = consultaFornecedor.Tag as Tuple<int, string>;
                if (infosFornecedor != null)
                {
                    int idFornecedor = infosFornecedor.Item1;
                    string Fornecedor = infosFornecedor.Item2;

                    txtCodFornecedor.Texts = idFornecedor.ToString();
                    txtFornecedor.Texts = Fornecedor;
                }
            }
        }

        private void txtCodFornecedor_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodFornecedor.Texts))
            {
                ModelFornecedor fornecedor = controllerFornecedor.BuscarPorId(int.Parse(txtCodFornecedor.Texts));
                if (fornecedor != null)
                {
                    txtFornecedor.Texts = fornecedor.fornecedor_razao_social;
                }
                else
                {
                    MessageBox.Show("Fornecedor não encontrado(a).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodFornecedor.Focus();
                    txtCodFornecedor.Clear();
                    txtFornecedor.Clear();
                }
            }
        }

        private void txtCodFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtParcelas_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtParcelas.Texts))
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(txtParcelas.Texts.TrimStart('0')))
            {
                MessageBox.Show("O número da parcela não pode ser 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtParcelas.Focus();
                txtParcelas.Clear();
            }
        }
    }
}
