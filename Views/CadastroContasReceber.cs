using MathNet.Numerics;
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
    public partial class CadastroContasReceber : Pilates.Views.CadastroPAI
    {
        private ConsultaFormaPagamento consultaFormaPagamento;
        private ControllerFormaPagamento<ModelFormaPagamento> controllerFormaPagamento;
        private ConsultaAluno ConsultaAluno;
        private ControllerAluno<ModelAluno> controllerAluno;
        private ControllerContasReceber<ModelContasReceber> controllerContasReceber;
        int Numero = -1;
        int IdAluno = -1;
        int Parcela = -1;
        decimal? porcentagemJuros;
        decimal? porcentagemMulta;
        decimal? porcentagemDesconto;
        public CadastroContasReceber()
        {
            InitializeComponent();
            consultaFormaPagamento = new ConsultaFormaPagamento();
            controllerFormaPagamento = new ControllerFormaPagamento<ModelFormaPagamento>();
            ConsultaAluno = new ConsultaAluno();
            controllerAluno = new ControllerAluno<ModelAluno>();
            controllerContasReceber = new ControllerContasReceber<ModelContasReceber>();
        }
        public CadastroContasReceber(int numero, int idAluno, int parcela) : this()
        {
            Numero = numero;
            IdAluno = idAluno;
            Parcela = parcela;
            Carrega();
        }

        private void CadastroContasReceber_Load(object sender, EventArgs e)
        {
            if (Numero != -1 && IdAluno != -1 && Parcela != -1)
            {
                btnReceber.Visible = true;
                btnSalvar.Visible = true;
            }
        }
        public override void Carrega()
        {
            base.Carrega();
            var contasReceber = controllerContasReceber.GetContaById(Numero,IdAluno, Parcela);
            if (contasReceber != null)
            {
                txtNumero.Text = contasReceber.numero.ToString();
                txtCodAluno.Text = contasReceber.idAluno.ToString();
                txtDataEmissao.Text = contasReceber.dataEmissao.ToString();
                txtCodFormaPag.Text = contasReceber.idFormaPagamento.ToString();
                txtParcelas.Text = contasReceber.parcela.ToString();
                txtValorParcela.Text = contasReceber.valorParcela.ToString();
                txtDataVencimento.Text = contasReceber.dataVencimento.ToString();
                porcentagemJuros = contasReceber.juros;
                porcentagemMulta = contasReceber.multa;
                porcentagemDesconto = contasReceber.desconto;
                txtValorRecebido.Text = contasReceber.valorRecebido.ToString();
                txtDataRecebimento.Text = contasReceber.dataRecebimento.ToString();
                txtObservacao.Text = contasReceber.observacao.ToString();
                txtDataCancelamento.Text = contasReceber.dataCancelamento.ToString();
                txtDataCadastro.Text = contasReceber.dataCadastro.ToString();
                txtDataUltAlt.Text = contasReceber.dataUltAlt.ToString();

                ModelAluno Aluno = controllerAluno.BuscarPorId(int.Parse(txtCodAluno.Text));
                ModelFormaPagamento formaPagamento = controllerFormaPagamento.BuscarPorId(int.Parse(txtCodFormaPag.Text));

                if (Aluno != null)
                    txtAluno.Text = Aluno.Aluno;
                if (formaPagamento != null)
                    txtFormaPag.Text = formaPagamento.formaPagamento;

                if (contasReceber.dataCancelamento != null)
                {
                    btnCancelar.Visible = false;
                    BloqueiaTudo();
                }
                else
                {
                    btnCancelar.Visible = true;
                }
                if (contasReceber.dataRecebimento == null)
                {
                    calcularJuros();
                    calcularMulta();
                    calcularDesconto();
                }
                else
                {
                    BloqueiaTudo();
                }
                calculaTotalReceber();
            }
        }
        public override void Salvar()
        {
            if (!VerificaCamposObrigatorios())
            {
                return;
            }
            int numero = int.Parse(txtNumero.Text);
            int idAluno = int.Parse(txtCodAluno.Text);
            int parcela = int.Parse(txtParcelas.Text);

            bool incluindo = Numero == -1 && IdAluno == -1 && Parcela == -1;

            if (controllerContasReceber.JaCadastrado(numero, idAluno, parcela, incluindo))
            {
                MessageBox.Show("Conta a Receber já cadastrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DateTime.TryParse(txtDataEmissao.Text, out DateTime dataEmissao);
                int idFormaPag = Convert.ToInt32(txtCodFormaPag.Text);
                int parcelas = Convert.ToInt32(txtParcelas.Text);
                decimal valorParcela = Convert.ToDecimal(txtValorParcela.Text);
                DateTime.TryParse(txtDataVencimento.Text, out DateTime dataVencimento);
                string dRecebimento = new string(txtDataRecebimento.Text.Where(char.IsDigit).ToArray());
                DateTime? dataRecebimento = string.IsNullOrEmpty(dRecebimento) || dRecebimento.Length != 8 ? (DateTime?)null : DateTime.ParseExact(txtDataRecebimento.Text, "dd/MM/yyyy", null);
                decimal valorRecebido = string.IsNullOrEmpty(txtValorRecebido.Text) ? 0 : Convert.ToDecimal(txtValorRecebido.Text);
                string dCancelamento = new string(txtDataCancelamento.Text.Where(char.IsDigit).ToArray());
                DateTime? dataCancelamento = string.IsNullOrEmpty(dCancelamento) || dCancelamento.Length != 8 ? (DateTime?)null : DateTime.ParseExact(txtDataCancelamento.Text, "dd/MM/yyyy", null);
                string observacao = txtObservacao.Text;
                DateTime.TryParse(txtDataCadastro.Text, out DateTime dataCadastro);
                DateTime dataUltAlt = Alterar != -7 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Text, out DateTime result) ? result : DateTime.MinValue;

                ModelContasReceber novaContaReceber = new ModelContasReceber
                {
                    numero = numero,
                    dataEmissao = dataEmissao,
                    idAluno = idAluno,
                    idFormaPagamento = idFormaPag,
                    parcela = parcela,
                    valorParcela = valorParcela,
                    dataVencimento = dataVencimento,
                    dataRecebimento = dataRecebimento,
                    valorRecebido = valorRecebido,
                    dataCancelamento = dataCancelamento,
                    desconto = porcentagemDesconto,
                    juros = porcentagemJuros,
                    multa = porcentagemMulta,
                    observacao = observacao,
                    dataCadastro = dataCadastro,
                    dataUltAlt = dataUltAlt
                };
                if (Numero != -1 && IdAluno != -1 && Parcela != -1)
                {
                    controllerContasReceber.Alterar(novaContaReceber);
                }
                else
                {
                    controllerContasReceber.Salvar(novaContaReceber);
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
            if (!Validacoes.CampoObrigatorio(txtCodAluno.Text))
            {
                MessageBox.Show("Campo Código Aluno é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodAluno.Focus();
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

        private void calculaTotalReceber()
        {
            decimal valorDesconto = string.IsNullOrWhiteSpace(txtDesconto.Text) ? 0 : Convert.ToDecimal(txtDesconto.Text);
            decimal valorJuros = string.IsNullOrWhiteSpace(txtJuros.Text) ? 0 : Convert.ToDecimal(txtJuros.Text);
            decimal valorMulta = string.IsNullOrWhiteSpace(txtMulta.Text) ? 0 : Convert.ToDecimal(txtMulta.Text);
            decimal valorParcela = string.IsNullOrWhiteSpace(txtValorParcela.Text) ? 0 : Convert.ToDecimal(txtValorParcela.Text);

            decimal totalPagar = valorParcela + valorJuros + valorMulta - valorDesconto;
            txtTotalReceber.Text = totalPagar.ToString("N2");
        }

        private void CadastroContasReceber_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaContasReceber)this.Owner).AtualizarConsultaContasReceber(false);
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

        private void btnPesquisarAluno_Click(object sender, EventArgs e)
        {
            {
                ConsultaAluno.btnSair.Text = "Selecionar";

                if (ConsultaAluno.ShowDialog() == DialogResult.OK)
                {
                    var infosAluno = ConsultaAluno.Tag as Tuple<int, string>;
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

        private void txtValorRecebido_Leave(object sender, EventArgs e)
        {
            txtValorRecebido.Text = Validacoes.FormataPreco(txtValorRecebido.Text);
        }

        private void btnReceber_Click(object sender, EventArgs e)
        {
            string dRecebimento = new string(txtDataRecebimento.Text.Where(char.IsDigit).ToArray());
            string dCancelamento = new string(txtDataCancelamento.Text.Where(char.IsDigit).ToArray());

            if (!string.IsNullOrEmpty(dCancelamento))
            {
                MessageBox.Show("Contrato Cancelada! Não é possível efetuar o pagamento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(dRecebimento))
            {
                MessageBox.Show("Pagamento já foi realizado dia " + txtDataRecebimento.Text, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //parcela atual
            int parcelaAtual = Convert.ToInt32(txtParcelas.Text);
            string numero = txtNumero.Text;
            int idAluno = Convert.ToInt32(txtCodAluno.Text);

            //verificar se existe uma parcela menor não paga
            bool parcelaNaoPaga = controllerContasReceber.VerificarParcelasNaoPagas(numero, idAluno, parcelaAtual);

            if (parcelaNaoPaga)
            {
                MessageBox.Show("Existem parcelas anteriores que não foram pagas. Pague as parcelas anteriores antes de pagar esta.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //se não existe parcelas menor não pagas, permitir o pagamento
            if (MessageBox.Show("Deseja realizar o pagamento?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Salvar();
                txtDataRecebimento.Text = DateTime.Now.ToString();
                txtValorRecebido.Text = txtTotalReceber.Text;
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
            txtCodAluno.Enabled = false;
            txtDataEmissao.Enabled = false;
            txtCodFormaPag.Enabled = false;
            txtParcelas.Enabled = false;
            txtValorParcela.Enabled = false;

            btnPesquisarFormaPag.Enabled = false;
            btnPesquisarAluno.Enabled = false;
        }
        public void BloqueiaTudo()
        {
            //usado quando a conta já está paga ou está cancelada
            txtJuros.Enabled = false;
            txtMulta.Enabled = false;
            txtDesconto.Enabled = false;
            txtValorRecebido.Enabled = false;
            txtDataVencimento.Enabled = false;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string dRecebimento = new string(txtDataRecebimento.Text.Where(char.IsDigit).ToArray());
            DialogResult result = MessageBox.Show("Tem certeza que deseja cancelar esta conta a receber?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(dRecebimento))
                {
                    try
                    {
                        ModelContasReceber contaReceber = new ModelContasReceber
                        {
                            numero = Numero,
                            idAluno = IdAluno,
                            parcela = Parcela,
                            dataCancelamento = DateTime.Now
                        };
                        bool cancelamentoRealizado = controllerContasReceber.CancelarConta(contaReceber);

                        if (cancelamentoRealizado)
                        {
                            txtDataCancelamento.Text = contaReceber.dataCancelamento?.ToString("dd/MM/yyyy");
                            lblDataCancelamento.Visible = true;
                            txtDataCancelamento.Visible = true;
                            BloqueiaTudo();

                            MessageBox.Show("Conta a receber cancelada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtValorRecebido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
