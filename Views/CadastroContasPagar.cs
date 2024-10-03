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
        int Numero = -1;
        int Parcela = -1;
        decimal? porcentagemJuros;
        decimal? porcentagemMulta;
        decimal? porcentagemDesconto;
        public CadastroContasPagar()
        {
            InitializeComponent();
            consultaFormaPagamento = new ConsultaFormaPagamento();
            controllerFormaPagamento = new ControllerFormaPagamento<ModelFormaPagamento>();
            controllerContasPagar = new ControllerContasPagar<ModelContasPagar>();
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
            }
        }
        public override void Carrega()
        {
            base.Carrega();
            var contasPagar = controllerContasPagar.GetContaById(Numero, Parcela);
            if (contasPagar != null)
            {
                txtNumero.Text = contasPagar.numero.ToString();
                txtDataEmissao.Text = contasPagar.dataEmissao.ToString();
                txtCodFormaPag.Text = contasPagar.idFormaPagamento.ToString();
                txtParcelas.Text = contasPagar.parcela.ToString();
                txtValorParcela.Text = contasPagar.valorParcela.ToString();
                txtDataVencimento.Text = contasPagar.dataVencimento.ToString();
                porcentagemJuros = contasPagar.juros;
                porcentagemMulta = contasPagar.multa;
                porcentagemDesconto = contasPagar.desconto;
                txtValorPago.Text = contasPagar.valorPago.ToString();
                txtDataPagamento.Text = contasPagar.dataPagamento.ToString();
                txtObservacao.Text = contasPagar.observacao.ToString();
                txtDataCancelamento.Text = contasPagar.dataCancelamento.ToString();
                txtDataCadastro.Text = contasPagar.dataCadastro.ToString();
                txtDataUltAlt.Text = contasPagar.dataUltAlt.ToString();

                ModelFormaPagamento formaPagamento = controllerFormaPagamento.BuscarPorId(int.Parse(txtCodFormaPag.Text));

                if (formaPagamento != null)
                    txtFormaPag.Text = formaPagamento.formaPagamento;

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
            int numero = int.Parse(txtNumero.Text);
            int parcela = int.Parse(txtParcelas.Text);

            bool incluindo = Numero == -1 && Parcela == -1;

            if (controllerContasPagar.JaCadastrado(numero, parcela, incluindo))
            {
                MessageBox.Show("Conta a pagar já cadastrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DateTime.TryParse(txtDataEmissao.Text, out DateTime dataEmissao);
                int idFormaPag = Convert.ToInt32(txtCodFormaPag.Text);
                int parcelas = Convert.ToInt32(txtParcelas.Text);
                decimal valorParcela = Convert.ToDecimal(txtValorParcela.Text);
                DateTime.TryParse(txtDataVencimento.Text, out DateTime dataVencimento);
                string dPagamento = new string(txtDataPagamento.Text.Where(char.IsDigit).ToArray());
                DateTime? dataPagamento = string.IsNullOrEmpty(dPagamento) || dPagamento.Length != 8 ? (DateTime?)null : DateTime.ParseExact(txtDataPagamento.Text, "dd/MM/yyyy", null);
                decimal valorPago = string.IsNullOrEmpty(txtValorPago.Text) ? 0 : Convert.ToDecimal(txtValorPago.Text);
                string dCancelamento = new string(txtDataCancelamento.Text.Where(char.IsDigit).ToArray());
                DateTime? dataCancelamento = string.IsNullOrEmpty(dCancelamento) || dCancelamento.Length != 8 ? (DateTime?)null : DateTime.ParseExact(txtDataCancelamento.Text, "dd/MM/yyyy", null);
                string observacao = txtObservacao.Text;
                DateTime.TryParse(txtDataCadastro.Text, out DateTime dataCadastro);
                DateTime dataUltAlt = Alterar != -7 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Text, out DateTime result) ? result : DateTime.MinValue;

                ModelContasPagar novaContaPagar = new ModelContasPagar
                {
                    numero = numero,
                    dataEmissao = dataEmissao,
                    idFormaPagamento = idFormaPag,
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
                    dataUltAlt = dataUltAlt
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
            string dEmissao = new string(txtDataEmissao.Text.Where(char.IsDigit).ToArray());
            string dVencimento = new string(txtDataVencimento.Text.Where(char.IsDigit).ToArray());
            if (!Validacoes.CampoObrigatorio(txtNumero.Text))
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
            if (!Validacoes.CampoObrigatorio(txtCodFormaPag.Text))
            {
                MessageBox.Show("Campo Código Forma Pagamento é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodFormaPag.Focus();
                return false;
            }
            if (!Validacoes.CampoObrigatorio(txtParcelas.Text))
            {
                MessageBox.Show("Campo Nº Parcela é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtParcelas.Focus();
                return false;
            }
            if (!Validacoes.CampoObrigatorio(txtValorParcela.Text))
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
            if (Validacoes.DataValida(txtDataVencimento.Text))
            {
                DateTime dataVencimento = DateTime.Parse(txtDataVencimento.Text);
                DateTime dataAtual = DateTime.Now;

                int diasAtraso = (dataAtual - dataVencimento).Days;
                decimal valorJuros = 0;

                if (diasAtraso > 0 && porcentagemJuros.HasValue)
                {
                    valorJuros = (diasAtraso * porcentagemJuros.Value / 100) * Convert.ToDecimal(txtValorParcela.Text);
                }
                txtJuros.Text = valorJuros.ToString("N2");
            }
        }
        private void calcularMulta()
        {
            if (Validacoes.DataValida(txtDataVencimento.Text))
            {
                DateTime dataVencimento = DateTime.Parse(txtDataVencimento.Text);
                DateTime dataAtual = DateTime.Now;

                int diasAtraso = (dataAtual - dataVencimento).Days;
                decimal valorMulta = 0;

                if (diasAtraso > 0 && porcentagemJuros.HasValue)
                {
                    valorMulta = (diasAtraso * porcentagemMulta.Value / 100) * Convert.ToDecimal(txtValorParcela.Text);
                }
                txtMulta.Text = valorMulta.ToString("N2");
            }
        }
        private void calcularDesconto()
        {
            if (Validacoes.DataValida(txtDataVencimento.Text))
            {
                if (porcentagemDesconto.HasValue && !string.IsNullOrWhiteSpace(txtValorParcela.Text))
                {
                    decimal valorParcela = Convert.ToDecimal(txtValorParcela.Text);
                    decimal valorDesconto = (porcentagemDesconto.Value / 100) * valorParcela;

                    txtDesconto.Text = valorDesconto.ToString("N2");
                }
                else
                {
                    txtDesconto.Text = "0.00";
                }
            }
        }

        private void calculaTotalPagar()
        {
            decimal valorDesconto = string.IsNullOrWhiteSpace(txtDesconto.Text) ? 0 : Convert.ToDecimal(txtDesconto.Text);
            decimal valorJuros = string.IsNullOrWhiteSpace(txtJuros.Text) ? 0 : Convert.ToDecimal(txtJuros.Text);
            decimal valorMulta = string.IsNullOrWhiteSpace(txtMulta.Text) ? 0 : Convert.ToDecimal(txtMulta.Text);
            decimal valorParcela = string.IsNullOrWhiteSpace(txtValorParcela.Text) ? 0 : Convert.ToDecimal(txtValorParcela.Text);

            decimal totalPagar = valorParcela + valorJuros + valorMulta - valorDesconto;
            txtTotalPagar.Text = totalPagar.ToString("N2");
        }

        private void CadastroContasPagar_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaContasPagar)this.Owner).AtualizarConsultaContasPagar(false);
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

                    txtCodFormaPag.Text = idFormaPag.ToString();
                    txtFormaPag.Text = formaPag;
                }
            }
        }

        private void txtCodFormaPag_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodFormaPag.Text))
            {
                ModelFormaPagamento formaPag = controllerFormaPagamento.BuscarPorId(int.Parse(txtCodFormaPag.Text));
                if (formaPag != null)
                {
                    txtFormaPag.Text = formaPag.formaPagamento;
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
            string dVencimento = new string(txtDataVencimento.Text.Where(char.IsDigit).ToArray());
            string dEmissao = new string(txtDataEmissao.Text.Where(char.IsDigit).ToArray());
            if (!string.IsNullOrEmpty(dVencimento) && !string.IsNullOrEmpty(dEmissao))
            {
                if (Validacoes.DataValida(txtDataEmissao.Text) && Validacoes.DataValida(txtDataVencimento.Text))
                {
                    DateTime dataEmissao;
                    DateTime dataVencimento;

                    bool dataEmissaoValida = DateTime.TryParseExact(txtDataEmissao.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataEmissao);
                    bool dataVencimentoValida = DateTime.TryParseExact(txtDataVencimento.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataVencimento);

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

        private void txtValorPago_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorPago_Leave(object sender, EventArgs e)
        {
            txtValorPago.Text = Validacoes.FormataPreco(txtValorPago.Text);
        }

        private void btnReceber_Click(object sender, EventArgs e)
        {
            string dPagamento = new string(txtDataPagamento.Text.Where(char.IsDigit).ToArray());
            string dCancelamento = new string(txtDataCancelamento.Text.Where(char.IsDigit).ToArray());

            if (!string.IsNullOrEmpty(dCancelamento))
            {
                MessageBox.Show("Contrato Cancelada! Não é possível efetuar o pagamento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(dPagamento))
            {
                MessageBox.Show("Pagamento já foi realizado dia " + txtDataPagamento.Text, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //parcela atual
            int parcelaAtual = Convert.ToInt32(txtParcelas.Text);
            string numero = txtNumero.Text;

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
                txtDataPagamento.Text = DateTime.Now.ToString();
                txtValorPago.Text = txtTotalPagar.Text;
                Salvar();
            }
        }

        private void txtDataEmissao_Leave(object sender, EventArgs e)
        {
            DateTime dataEmissao;
            DateTime dataHoje = DateTime.Now;
            bool dataValida = DateTime.TryParse(txtDataEmissao.Text, out dataEmissao);

            string dataE = new string(txtDataEmissao.Text.Where(char.IsDigit).ToArray());

            if (!string.IsNullOrEmpty(dataE))
            {
                if (Validacoes.DataValida(txtDataEmissao.Text))
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
        public override void Bloqueia()
        {
            base.Bloqueia();
            txtNumero.Enabled = false;
            txtDataEmissao.Enabled = false;
            txtCodFormaPag.Enabled = false;
            txtParcelas.Enabled = false;
            txtValorParcela.Enabled = false;
            btnPesquisarFormaPag.Enabled = false;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string dPagamento = new string(txtDataPagamento.Text.Where(char.IsDigit).ToArray());
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
                            txtDataCancelamento.Text = contaPagar.dataCancelamento?.ToString("dd/MM/yyyy");
                            lblDataCancelamento.Visible = true;
                            txtDataCancelamento.Visible = true;
                            BloqueiaTudo();

                            MessageBox.Show("Conta a pagar cancelada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
