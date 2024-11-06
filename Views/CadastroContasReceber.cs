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
                txtNumero.Texts = contasReceber.numero.ToString();
                txtCodAluno.Texts = contasReceber.idAluno.ToString();
                txtDataEmissao.Texts = contasReceber.dataEmissao.ToString();
                txtCodFormaPag.Texts = contasReceber.idFormaPagamento.ToString();
                txtParcelas.Texts = contasReceber.parcela.ToString();
                txtValorParcela.Texts = contasReceber.valorParcela.ToString();
                txtDataVencimento.Texts = contasReceber.dataVencimento.ToString();
                porcentagemJuros = contasReceber.juros;
                porcentagemMulta = contasReceber.multa;
                porcentagemDesconto = contasReceber.desconto;
                txtValorRecebido.Texts = contasReceber.valorRecebido.ToString();
                txtDataRecebimento.Texts = contasReceber.dataRecebimento.ToString();
                txtObservacao.Texts = contasReceber.observacao.ToString();
                txtDataCancelamento.Texts = contasReceber.dataCancelamento.ToString();
                txtDataCadastro.Texts = contasReceber.dataCadastro.ToString();
                txtDataUltAlt.Texts = contasReceber.dataUltAlt.ToString();
                txtUsuarioUltAlt.Texts = contasReceber.usuarioUltAlt;

                ModelAluno Aluno = controllerAluno.BuscarPorId(int.Parse(txtCodAluno.Texts));
                ModelFormaPagamento formaPagamento = controllerFormaPagamento.BuscarPorId(int.Parse(txtCodFormaPag.Texts));

                if (Aluno != null)
                    txtAluno.Texts = Aluno.Aluno;
                if (formaPagamento != null)
                    txtFormaPag.Texts = formaPagamento.formaPagamento;

                if (contasReceber.dataCancelamento != null)
                {
                    btnCancelar.Visible = false;
                    BloqueiaTudo();
                }
                else
                {
                  //  btnCancelar.Visible = true;
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
            int numero = int.Parse(txtNumero.Texts);
            int idAluno = int.Parse(txtCodAluno.Texts);
            int parcela = int.Parse(txtParcelas.Texts);

            bool incluindo = Numero == -1 && IdAluno == -1 && Parcela == -1;

            if (controllerContasReceber.JaCadastrado(numero, idAluno, parcela, incluindo))
            {
                MessageBox.Show("Conta a Receber já cadastrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DateTime.TryParse(txtDataEmissao.Texts, out DateTime dataEmissao);
                int idFormaPag = Convert.ToInt32(txtCodFormaPag.Texts);
                int parcelas = Convert.ToInt32(txtParcelas.Texts);
                decimal valorParcela = Convert.ToDecimal(txtValorParcela.Texts);
                DateTime.TryParse(txtDataVencimento.Texts, out DateTime dataVencimento);
                string dRecebimento = new string(txtDataRecebimento.Texts.Where(char.IsDigit).ToArray());
                DateTime? dataRecebimento = string.IsNullOrEmpty(dRecebimento) || dRecebimento.Length != 8 ? (DateTime?)null : DateTime.ParseExact(txtDataRecebimento.Texts, "dd/MM/yyyy", null);
                decimal valorRecebido = string.IsNullOrEmpty(txtValorRecebido.Texts) ? 0 : Convert.ToDecimal(txtValorRecebido.Texts);
                string dCancelamento = new string(txtDataCancelamento.Texts.Where(char.IsDigit).ToArray());
                DateTime? dataCancelamento = string.IsNullOrEmpty(dCancelamento) || dCancelamento.Length != 8 ? (DateTime?)null : DateTime.ParseExact(txtDataCancelamento.Texts, "dd/MM/yyyy", null);
                string observacao = txtObservacao.Texts;
                DateTime.TryParse(txtDataCadastro.Texts, out DateTime dataCadastro);
                DateTime dataUltAlt = Alterar != -7 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Texts, out DateTime result) ? result : DateTime.MinValue;
                string usuario = Program.usuarioLogado;

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
                    dataUltAlt = dataUltAlt,
                    usuarioUltAlt = usuario,
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
            string dEmissao = new string(txtDataEmissao.Texts.Where(char.IsDigit).ToArray());
            string dVencimento = new string(txtDataVencimento.Texts.Where(char.IsDigit).ToArray());
            if (!Validacoes.CampoObrigatorio(txtNumero.Texts))
            {
                MessageBox.Show("Campo Número é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Focus();
                return false;
            }
            if (!Validacoes.CampoObrigatorio(txtCodAluno.Texts))
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
            if (!Validacoes.CampoObrigatorio(txtCodFormaPag.Texts))
            {
                MessageBox.Show("Campo Código Forma Pagamento é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodFormaPag.Focus();
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

        private void calculaTotalReceber()
        {
            decimal valorDesconto = string.IsNullOrWhiteSpace(txtDesconto.Texts) ? 0 : Convert.ToDecimal(txtDesconto.Texts);
            decimal valorJuros = string.IsNullOrWhiteSpace(txtJuros.Texts) ? 0 : Convert.ToDecimal(txtJuros.Texts);
            decimal valorMulta = string.IsNullOrWhiteSpace(txtMulta.Texts) ? 0 : Convert.ToDecimal(txtMulta.Texts);
            decimal valorParcela = string.IsNullOrWhiteSpace(txtValorParcela.Texts) ? 0 : Convert.ToDecimal(txtValorParcela.Texts);

            decimal totalPagar = valorParcela + valorJuros + valorMulta - valorDesconto;
            txtTotalReceber.Texts = totalPagar.ToString("N2");
        }

        private void CadastroContasReceber_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaContasReceber)this.Owner).AtualizarConsultaContasReceber(false);
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
            txtJuros.Enabled = false;
            txtMulta.Enabled = false;
            txtDesconto.Enabled = false;
            txtValorRecebido.Enabled = false;
            txtDataVencimento.Enabled = false;
            txtObservacao.Enabled = false;

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

        private void btnPesquisarAluno_Click(object sender, EventArgs e)
        {
            ConsultaAluno.btnSair.Text = "Selecionar";

            if (ConsultaAluno.ShowDialog() == DialogResult.OK)
            {
                var infosAluno = ConsultaAluno.Tag as Tuple<int, string>;
                if (infosAluno != null)
                {
                    int idAluno = infosAluno.Item1;
                    string Aluno = infosAluno.Item2;

                    txtCodAluno.Texts = idAluno.ToString();
                    txtAluno.Texts = Aluno;
                }
            }
        }

        private void txtCodAluno_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodAluno.Texts))
            {
                ModelAluno aluno = controllerAluno.BuscarPorId(int.Parse(txtCodAluno.Texts));
                if (aluno != null)
                {
                    txtAluno.Texts = aluno.Aluno;
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

        private void txtValorRecebido_Leave(object sender, EventArgs e)
        {
            txtValorRecebido.Texts = Validacoes.FormataPreco(txtValorRecebido.Texts);
        }

        private void btnReceber_Click(object sender, EventArgs e)
        {
            string dRecebimento = new string(txtDataRecebimento.Texts.Where(char.IsDigit).ToArray());
            string dCancelamento = new string(txtDataCancelamento.Texts.Where(char.IsDigit).ToArray());

            if (!string.IsNullOrEmpty(dCancelamento))
            {
                MessageBox.Show("Contrato Cancelada! Não é possível efetuar o pagamento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(dRecebimento))
            {
                MessageBox.Show("Pagamento já foi realizado dia " + txtDataRecebimento.Texts, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //parcela atual
            int parcelaAtual = Convert.ToInt32(txtParcelas.Texts);
            string numero = txtNumero.Texts;
            int idAluno = Convert.ToInt32(txtCodAluno.Texts);

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
                txtDataRecebimento.Texts = DateTime.Now.ToString();
                txtValorRecebido.Texts = txtTotalReceber.Texts;
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
            string dRecebimento = new string(txtDataRecebimento.Texts.Where(char.IsDigit).ToArray());
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
                            txtDataCancelamento.Texts = contaReceber.dataCancelamento?.ToString("dd/MM/yyyy");
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

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtJuros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
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

        private void txtCodFormaPag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
