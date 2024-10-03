namespace Pilates.Views
{
    partial class CadastroContasPagar
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtDataEmissao = new System.Windows.Forms.MaskedTextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtDataCancelamento = new System.Windows.Forms.MaskedTextBox();
            this.lblDataCancelamento = new System.Windows.Forms.Label();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.lblValorPago = new System.Windows.Forms.Label();
            this.txtDataPagamento = new System.Windows.Forms.MaskedTextBox();
            this.lblDataPagamento = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.txtMulta = new System.Windows.Forms.TextBox();
            this.lblMulta = new System.Windows.Forms.Label();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.lblJuros = new System.Windows.Forms.Label();
            this.txtDataVencimento = new System.Windows.Forms.MaskedTextBox();
            this.lblDataVencimento = new System.Windows.Forms.Label();
            this.txtValorParcela = new System.Windows.Forms.TextBox();
            this.lblValorParcela = new System.Windows.Forms.Label();
            this.txtParcelas = new System.Windows.Forms.TextBox();
            this.lblParcelas = new System.Windows.Forms.Label();
            this.lblFormaPagamento = new System.Windows.Forms.Label();
            this.txtFormaPag = new System.Windows.Forms.TextBox();
            this.btnPesquisarFormaPag = new System.Windows.Forms.Button();
            this.lblCodFormPag = new System.Windows.Forms.Label();
            this.txtCodFormaPag = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblDataEmissao = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(529, 220);
            this.lblCodigo.Visible = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(532, 197);
            this.txtCodigo.Text = "0";
            this.txtCodigo.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(468, 371);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(387, 371);
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(16, 374);
            this.txtDataCadastro.Text = "23092024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(130, 373);
            this.txtDataUltAlt.Text = "23092024";
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(127, 348);
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(13, 348);
            // 
            // gbStatus
            // 
            this.gbStatus.Location = new System.Drawing.Point(370, 19);
            // 
            // txtNumero
            // 
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Location = new System.Drawing.Point(126, 35);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(104, 20);
            this.txtNumero.TabIndex = 76;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDataEmissao
            // 
            this.txtDataEmissao.Location = new System.Drawing.Point(24, 35);
            this.txtDataEmissao.Mask = "00/00/0000";
            this.txtDataEmissao.Name = "txtDataEmissao";
            this.txtDataEmissao.Size = new System.Drawing.Size(90, 20);
            this.txtDataEmissao.TabIndex = 75;
            this.txtDataEmissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataEmissao.ValidatingType = typeof(System.DateTime);
            this.txtDataEmissao.Leave += new System.EventHandler(this.txtDataEmissao_Leave);
            // 
            // txtObservacao
            // 
            this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.Location = new System.Drawing.Point(24, 313);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(511, 20);
            this.txtObservacao.TabIndex = 74;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(21, 297);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(68, 13);
            this.lblObservacao.TabIndex = 73;
            this.lblObservacao.Text = "Observação:";
            // 
            // txtDataCancelamento
            // 
            this.txtDataCancelamento.Enabled = false;
            this.txtDataCancelamento.Location = new System.Drawing.Point(231, 256);
            this.txtDataCancelamento.Mask = "00/00/0000";
            this.txtDataCancelamento.Name = "txtDataCancelamento";
            this.txtDataCancelamento.Size = new System.Drawing.Size(100, 20);
            this.txtDataCancelamento.TabIndex = 72;
            this.txtDataCancelamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataCancelamento.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataCancelamento
            // 
            this.lblDataCancelamento.AutoSize = true;
            this.lblDataCancelamento.Location = new System.Drawing.Point(228, 240);
            this.lblDataCancelamento.Name = "lblDataCancelamento";
            this.lblDataCancelamento.Size = new System.Drawing.Size(104, 13);
            this.lblDataCancelamento.TabIndex = 71;
            this.lblDataCancelamento.Text = "Data Cancelamento:";
            // 
            // txtValorPago
            // 
            this.txtValorPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorPago.Location = new System.Drawing.Point(126, 256);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(90, 20);
            this.txtValorPago.TabIndex = 70;
            this.txtValorPago.TextChanged += new System.EventHandler(this.txtValorPago_TextChanged);
            this.txtValorPago.Leave += new System.EventHandler(this.txtValorPago_Leave);
            // 
            // lblValorPago
            // 
            this.lblValorPago.AutoSize = true;
            this.lblValorPago.Location = new System.Drawing.Point(127, 240);
            this.lblValorPago.Name = "lblValorPago";
            this.lblValorPago.Size = new System.Drawing.Size(62, 13);
            this.lblValorPago.TabIndex = 69;
            this.lblValorPago.Text = "Valor Pago:";
            // 
            // txtDataPagamento
            // 
            this.txtDataPagamento.Enabled = false;
            this.txtDataPagamento.Location = new System.Drawing.Point(24, 256);
            this.txtDataPagamento.Mask = "00/00/0000";
            this.txtDataPagamento.Name = "txtDataPagamento";
            this.txtDataPagamento.Size = new System.Drawing.Size(90, 20);
            this.txtDataPagamento.TabIndex = 68;
            this.txtDataPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataPagamento.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataPagamento
            // 
            this.lblDataPagamento.AutoSize = true;
            this.lblDataPagamento.Location = new System.Drawing.Point(21, 240);
            this.lblDataPagamento.Name = "lblDataPagamento";
            this.lblDataPagamento.Size = new System.Drawing.Size(90, 13);
            this.lblDataPagamento.TabIndex = 67;
            this.lblDataPagamento.Text = "Data Pagamento:";
            // 
            // txtDesconto
            // 
            this.txtDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesconto.Location = new System.Drawing.Point(231, 197);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(90, 20);
            this.txtDesconto.TabIndex = 66;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(228, 181);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(56, 13);
            this.lblDesconto.TabIndex = 65;
            this.lblDesconto.Text = "Desconto:";
            // 
            // txtMulta
            // 
            this.txtMulta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMulta.Location = new System.Drawing.Point(126, 197);
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.Size = new System.Drawing.Size(90, 20);
            this.txtMulta.TabIndex = 64;
            this.txtMulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMulta
            // 
            this.lblMulta.AutoSize = true;
            this.lblMulta.Location = new System.Drawing.Point(123, 181);
            this.lblMulta.Name = "lblMulta";
            this.lblMulta.Size = new System.Drawing.Size(36, 13);
            this.lblMulta.TabIndex = 63;
            this.lblMulta.Text = "Multa:";
            // 
            // txtJuros
            // 
            this.txtJuros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtJuros.Location = new System.Drawing.Point(24, 197);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(90, 20);
            this.txtJuros.TabIndex = 62;
            this.txtJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblJuros
            // 
            this.lblJuros.AutoSize = true;
            this.lblJuros.Location = new System.Drawing.Point(21, 173);
            this.lblJuros.Name = "lblJuros";
            this.lblJuros.Size = new System.Drawing.Size(35, 13);
            this.lblJuros.TabIndex = 61;
            this.lblJuros.Text = "Juros:";
            // 
            // txtDataVencimento
            // 
            this.txtDataVencimento.Location = new System.Drawing.Point(231, 142);
            this.txtDataVencimento.Mask = "00/00/0000";
            this.txtDataVencimento.Name = "txtDataVencimento";
            this.txtDataVencimento.Size = new System.Drawing.Size(90, 20);
            this.txtDataVencimento.TabIndex = 60;
            this.txtDataVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataVencimento.ValidatingType = typeof(System.DateTime);
            this.txtDataVencimento.Leave += new System.EventHandler(this.txtDataVencimento_Leave);
            // 
            // lblDataVencimento
            // 
            this.lblDataVencimento.AutoSize = true;
            this.lblDataVencimento.Location = new System.Drawing.Point(228, 126);
            this.lblDataVencimento.Name = "lblDataVencimento";
            this.lblDataVencimento.Size = new System.Drawing.Size(96, 13);
            this.lblDataVencimento.TabIndex = 59;
            this.lblDataVencimento.Text = "Data Vencimento:*";
            // 
            // txtValorParcela
            // 
            this.txtValorParcela.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorParcela.Location = new System.Drawing.Point(126, 142);
            this.txtValorParcela.Name = "txtValorParcela";
            this.txtValorParcela.Size = new System.Drawing.Size(90, 20);
            this.txtValorParcela.TabIndex = 58;
            // 
            // lblValorParcela
            // 
            this.lblValorParcela.AutoSize = true;
            this.lblValorParcela.Location = new System.Drawing.Point(123, 126);
            this.lblValorParcela.Name = "lblValorParcela";
            this.lblValorParcela.Size = new System.Drawing.Size(77, 13);
            this.lblValorParcela.TabIndex = 57;
            this.lblValorParcela.Text = "Valor Parcela:*";
            // 
            // txtParcelas
            // 
            this.txtParcelas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtParcelas.Location = new System.Drawing.Point(24, 142);
            this.txtParcelas.Name = "txtParcelas";
            this.txtParcelas.Size = new System.Drawing.Size(90, 20);
            this.txtParcelas.TabIndex = 56;
            // 
            // lblParcelas
            // 
            this.lblParcelas.AutoSize = true;
            this.lblParcelas.Location = new System.Drawing.Point(21, 126);
            this.lblParcelas.Name = "lblParcelas";
            this.lblParcelas.Size = new System.Drawing.Size(90, 13);
            this.lblParcelas.TabIndex = 55;
            this.lblParcelas.Text = "Numero Parcela:*";
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.AutoSize = true;
            this.lblFormaPagamento.Location = new System.Drawing.Point(197, 63);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(111, 13);
            this.lblFormaPagamento.TabIndex = 54;
            this.lblFormaPagamento.Text = "Forma de Pagamento:";
            // 
            // txtFormaPag
            // 
            this.txtFormaPag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFormaPag.Enabled = false;
            this.txtFormaPag.Location = new System.Drawing.Point(200, 83);
            this.txtFormaPag.Name = "txtFormaPag";
            this.txtFormaPag.Size = new System.Drawing.Size(335, 20);
            this.txtFormaPag.TabIndex = 53;
            // 
            // btnPesquisarFormaPag
            // 
            this.btnPesquisarFormaPag.Location = new System.Drawing.Point(126, 81);
            this.btnPesquisarFormaPag.Name = "btnPesquisarFormaPag";
            this.btnPesquisarFormaPag.Size = new System.Drawing.Size(62, 23);
            this.btnPesquisarFormaPag.TabIndex = 52;
            this.btnPesquisarFormaPag.Text = "Pesquisar";
            this.btnPesquisarFormaPag.UseVisualStyleBackColor = true;
            this.btnPesquisarFormaPag.Click += new System.EventHandler(this.btnPesquisarFormaPag_Click);
            // 
            // lblCodFormPag
            // 
            this.lblCodFormPag.AutoSize = true;
            this.lblCodFormPag.Location = new System.Drawing.Point(21, 63);
            this.lblCodFormPag.Name = "lblCodFormPag";
            this.lblCodFormPag.Size = new System.Drawing.Size(93, 13);
            this.lblCodFormPag.TabIndex = 51;
            this.lblCodFormPag.Text = "Cód. Forma Pag.:*";
            // 
            // txtCodFormaPag
            // 
            this.txtCodFormaPag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodFormaPag.Location = new System.Drawing.Point(24, 83);
            this.txtCodFormaPag.Name = "txtCodFormaPag";
            this.txtCodFormaPag.Size = new System.Drawing.Size(90, 20);
            this.txtCodFormaPag.TabIndex = 50;
            this.txtCodFormaPag.Leave += new System.EventHandler(this.txtCodFormaPag_Leave);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(123, 19);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 78;
            this.lblNumero.Text = "Número:";
            // 
            // lblDataEmissao
            // 
            this.lblDataEmissao.AutoSize = true;
            this.lblDataEmissao.Location = new System.Drawing.Point(21, 19);
            this.lblDataEmissao.Name = "lblDataEmissao";
            this.lblDataEmissao.Size = new System.Drawing.Size(79, 13);
            this.lblDataEmissao.TabIndex = 77;
            this.lblDataEmissao.Text = "Data Emissão:*";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(312, 371);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(69, 23);
            this.btnPagar.TabIndex = 80;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Visible = false;
            this.btnPagar.Click += new System.EventHandler(this.btnReceber_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(248, 371);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(58, 23);
            this.btnCancelar.TabIndex = 79;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalPagar.Enabled = false;
            this.txtTotalPagar.Location = new System.Drawing.Point(435, 256);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPagar.TabIndex = 82;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Location = new System.Drawing.Point(432, 240);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(61, 13);
            this.lblTotalPagar.TabIndex = 81;
            this.lblTotalPagar.Text = "Valor Total:";
            // 
            // CadastroContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(555, 406);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblDataEmissao);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtDataEmissao);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.txtDataCancelamento);
            this.Controls.Add(this.lblDataCancelamento);
            this.Controls.Add(this.txtValorPago);
            this.Controls.Add(this.lblValorPago);
            this.Controls.Add(this.txtDataPagamento);
            this.Controls.Add(this.lblDataPagamento);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.txtMulta);
            this.Controls.Add(this.lblMulta);
            this.Controls.Add(this.txtJuros);
            this.Controls.Add(this.lblJuros);
            this.Controls.Add(this.txtDataVencimento);
            this.Controls.Add(this.lblDataVencimento);
            this.Controls.Add(this.txtValorParcela);
            this.Controls.Add(this.lblValorParcela);
            this.Controls.Add(this.txtParcelas);
            this.Controls.Add(this.lblParcelas);
            this.Controls.Add(this.lblFormaPagamento);
            this.Controls.Add(this.txtFormaPag);
            this.Controls.Add(this.btnPesquisarFormaPag);
            this.Controls.Add(this.lblCodFormPag);
            this.Controls.Add(this.txtCodFormaPag);
            this.Name = "CadastroContasPagar";
            this.Text = "Cadastro Contas a Pagar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroContasPagar_FormClosed);
            this.Load += new System.EventHandler(this.CadastroContasPagar_Load);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.gbStatus, 0);
            this.Controls.SetChildIndex(this.txtCodFormaPag, 0);
            this.Controls.SetChildIndex(this.lblCodFormPag, 0);
            this.Controls.SetChildIndex(this.btnPesquisarFormaPag, 0);
            this.Controls.SetChildIndex(this.txtFormaPag, 0);
            this.Controls.SetChildIndex(this.lblFormaPagamento, 0);
            this.Controls.SetChildIndex(this.lblParcelas, 0);
            this.Controls.SetChildIndex(this.txtParcelas, 0);
            this.Controls.SetChildIndex(this.lblValorParcela, 0);
            this.Controls.SetChildIndex(this.txtValorParcela, 0);
            this.Controls.SetChildIndex(this.lblDataVencimento, 0);
            this.Controls.SetChildIndex(this.txtDataVencimento, 0);
            this.Controls.SetChildIndex(this.lblJuros, 0);
            this.Controls.SetChildIndex(this.txtJuros, 0);
            this.Controls.SetChildIndex(this.lblMulta, 0);
            this.Controls.SetChildIndex(this.txtMulta, 0);
            this.Controls.SetChildIndex(this.lblDesconto, 0);
            this.Controls.SetChildIndex(this.txtDesconto, 0);
            this.Controls.SetChildIndex(this.lblDataPagamento, 0);
            this.Controls.SetChildIndex(this.txtDataPagamento, 0);
            this.Controls.SetChildIndex(this.lblValorPago, 0);
            this.Controls.SetChildIndex(this.txtValorPago, 0);
            this.Controls.SetChildIndex(this.lblDataCancelamento, 0);
            this.Controls.SetChildIndex(this.txtDataCancelamento, 0);
            this.Controls.SetChildIndex(this.lblObservacao, 0);
            this.Controls.SetChildIndex(this.txtObservacao, 0);
            this.Controls.SetChildIndex(this.txtDataEmissao, 0);
            this.Controls.SetChildIndex(this.txtNumero, 0);
            this.Controls.SetChildIndex(this.lblDataEmissao, 0);
            this.Controls.SetChildIndex(this.lblNumero, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnPagar, 0);
            this.Controls.SetChildIndex(this.lblTotalPagar, 0);
            this.Controls.SetChildIndex(this.txtTotalPagar, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.MaskedTextBox txtDataEmissao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.MaskedTextBox txtDataCancelamento;
        private System.Windows.Forms.Label lblDataCancelamento;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.Label lblValorPago;
        private System.Windows.Forms.MaskedTextBox txtDataPagamento;
        private System.Windows.Forms.Label lblDataPagamento;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.TextBox txtMulta;
        private System.Windows.Forms.Label lblMulta;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.Label lblJuros;
        private System.Windows.Forms.MaskedTextBox txtDataVencimento;
        private System.Windows.Forms.Label lblDataVencimento;
        private System.Windows.Forms.TextBox txtValorParcela;
        private System.Windows.Forms.Label lblValorParcela;
        private System.Windows.Forms.TextBox txtParcelas;
        private System.Windows.Forms.Label lblParcelas;
        private System.Windows.Forms.Label lblFormaPagamento;
        private System.Windows.Forms.TextBox txtFormaPag;
        private System.Windows.Forms.Button btnPesquisarFormaPag;
        private System.Windows.Forms.Label lblCodFormPag;
        private System.Windows.Forms.TextBox txtCodFormaPag;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblDataEmissao;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Label lblTotalPagar;
    }
}
