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
            this.lblObservacao = new System.Windows.Forms.Label();
            this.lblDataCancelamento = new System.Windows.Forms.Label();
            this.lblValorPago = new System.Windows.Forms.Label();
            this.lblDataPagamento = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblMulta = new System.Windows.Forms.Label();
            this.lblJuros = new System.Windows.Forms.Label();
            this.lblDataVencimento = new System.Windows.Forms.Label();
            this.lblValorParcela = new System.Windows.Forms.Label();
            this.lblParcelas = new System.Windows.Forms.Label();
            this.lblFormaPagamento = new System.Windows.Forms.Label();
            this.lblCodFormPag = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblDataEmissao = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.txtDataEmissao = new Pilates.YControls.YMaskedTextBox();
            this.txtDataCancelamento = new Pilates.YControls.YMaskedTextBox();
            this.txtDataPagamento = new Pilates.YControls.YMaskedTextBox();
            this.txtNumero = new Pilates.YControls.YTextBox();
            this.txtCodFormaPag = new Pilates.YControls.YTextBox();
            this.txtFormaPag = new Pilates.YControls.YTextBox();
            this.btnPesquisarFormaPag = new Pilates.YControls.YButton();
            this.txtParcelas = new Pilates.YControls.YTextBox();
            this.txtValorParcela = new Pilates.YControls.YTextBox();
            this.txtDataVencimento = new Pilates.YControls.YMaskedTextBox();
            this.txtMulta = new Pilates.YControls.YTextBox();
            this.txtDesconto = new Pilates.YControls.YTextBox();
            this.txtJuros = new Pilates.YControls.YTextBox();
            this.txtValorPago = new Pilates.YControls.YTextBox();
            this.txtTotalPagar = new Pilates.YControls.YTextBox();
            this.txtObservacao = new Pilates.YControls.YTextBox();
            this.btnPagar = new Pilates.YControls.YButton();
            this.btnCancelar = new Pilates.YControls.YButton();
            this.txtFornecedor = new Pilates.YControls.YTextBox();
            this.btnPesquisaFornecedor = new Pilates.YControls.YButton();
            this.txtCodFornecedor = new Pilates.YControls.YTextBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblCodFornecedor = new System.Windows.Forms.Label();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(562, 184);
            this.lblCodigo.Visible = false;
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(119, 473);
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(21, 472);
            // 
            // gbStatus
            // 
            this.gbStatus.Location = new System.Drawing.Point(390, 19);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(383, 484);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(552, 200);
            this.txtCodigo.Texts = "0";
            this.txtCodigo.Visible = false;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(24, 488);
            this.txtDataCadastro.Texts = "25/10/2024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(122, 488);
            this.txtDataUltAlt.Texts = "25/10/2024";
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(472, 484);
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(21, 408);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(68, 13);
            this.lblObservacao.TabIndex = 73;
            this.lblObservacao.Text = "Observação:";
            // 
            // lblDataCancelamento
            // 
            this.lblDataCancelamento.AutoSize = true;
            this.lblDataCancelamento.Location = new System.Drawing.Point(254, 337);
            this.lblDataCancelamento.Name = "lblDataCancelamento";
            this.lblDataCancelamento.Size = new System.Drawing.Size(104, 13);
            this.lblDataCancelamento.TabIndex = 71;
            this.lblDataCancelamento.Text = "Data Cancelamento:";
            // 
            // lblValorPago
            // 
            this.lblValorPago.AutoSize = true;
            this.lblValorPago.Location = new System.Drawing.Point(135, 337);
            this.lblValorPago.Name = "lblValorPago";
            this.lblValorPago.Size = new System.Drawing.Size(62, 13);
            this.lblValorPago.TabIndex = 69;
            this.lblValorPago.Text = "Valor Pago:";
            // 
            // lblDataPagamento
            // 
            this.lblDataPagamento.AutoSize = true;
            this.lblDataPagamento.Location = new System.Drawing.Point(20, 337);
            this.lblDataPagamento.Name = "lblDataPagamento";
            this.lblDataPagamento.Size = new System.Drawing.Size(90, 13);
            this.lblDataPagamento.TabIndex = 67;
            this.lblDataPagamento.Text = "Data Pagamento:";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(256, 270);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(56, 13);
            this.lblDesconto.TabIndex = 65;
            this.lblDesconto.Text = "Desconto:";
            // 
            // lblMulta
            // 
            this.lblMulta.AutoSize = true;
            this.lblMulta.Location = new System.Drawing.Point(135, 270);
            this.lblMulta.Name = "lblMulta";
            this.lblMulta.Size = new System.Drawing.Size(36, 13);
            this.lblMulta.TabIndex = 63;
            this.lblMulta.Text = "Multa:";
            // 
            // lblJuros
            // 
            this.lblJuros.AutoSize = true;
            this.lblJuros.Location = new System.Drawing.Point(21, 270);
            this.lblJuros.Name = "lblJuros";
            this.lblJuros.Size = new System.Drawing.Size(35, 13);
            this.lblJuros.TabIndex = 61;
            this.lblJuros.Text = "Juros:";
            // 
            // lblDataVencimento
            // 
            this.lblDataVencimento.AutoSize = true;
            this.lblDataVencimento.Location = new System.Drawing.Point(256, 199);
            this.lblDataVencimento.Name = "lblDataVencimento";
            this.lblDataVencimento.Size = new System.Drawing.Size(96, 13);
            this.lblDataVencimento.TabIndex = 59;
            this.lblDataVencimento.Text = "Data Vencimento:*";
            // 
            // lblValorParcela
            // 
            this.lblValorParcela.AutoSize = true;
            this.lblValorParcela.Location = new System.Drawing.Point(136, 199);
            this.lblValorParcela.Name = "lblValorParcela";
            this.lblValorParcela.Size = new System.Drawing.Size(77, 13);
            this.lblValorParcela.TabIndex = 57;
            this.lblValorParcela.Text = "Valor Parcela:*";
            // 
            // lblParcelas
            // 
            this.lblParcelas.AutoSize = true;
            this.lblParcelas.Location = new System.Drawing.Point(21, 199);
            this.lblParcelas.Name = "lblParcelas";
            this.lblParcelas.Size = new System.Drawing.Size(90, 13);
            this.lblParcelas.TabIndex = 55;
            this.lblParcelas.Text = "Numero Parcela:*";
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.AutoSize = true;
            this.lblFormaPagamento.Location = new System.Drawing.Point(200, 143);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(111, 13);
            this.lblFormaPagamento.TabIndex = 54;
            this.lblFormaPagamento.Text = "Forma de Pagamento:";
            // 
            // lblCodFormPag
            // 
            this.lblCodFormPag.AutoSize = true;
            this.lblCodFormPag.Location = new System.Drawing.Point(21, 142);
            this.lblCodFormPag.Name = "lblCodFormPag";
            this.lblCodFormPag.Size = new System.Drawing.Size(93, 13);
            this.lblCodFormPag.TabIndex = 51;
            this.lblCodFormPag.Text = "Cód. Forma Pag.:*";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(136, 18);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(51, 13);
            this.lblNumero.TabIndex = 78;
            this.lblNumero.Text = "Número*:";
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
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Location = new System.Drawing.Point(373, 337);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(61, 13);
            this.lblTotalPagar.TabIndex = 81;
            this.lblTotalPagar.Text = "Valor Total:";
            // 
            // txtDataEmissao
            // 
            this.txtDataEmissao.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataEmissao.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDataEmissao.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtDataEmissao.BorderRadius = 8;
            this.txtDataEmissao.BorderSize = 1;
            this.txtDataEmissao.DisabledBackColor = System.Drawing.Color.White;
            this.txtDataEmissao.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtDataEmissao.DisabledForeColor = System.Drawing.Color.White;
            this.txtDataEmissao.EnabledBackColor = System.Drawing.Color.White;
            this.txtDataEmissao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDataEmissao.Location = new System.Drawing.Point(24, 35);
            this.txtDataEmissao.Mask = "00/00/0000";
            this.txtDataEmissao.MaxLength = 32767;
            this.txtDataEmissao.Multiline = false;
            this.txtDataEmissao.Name = "txtDataEmissao";
            this.txtDataEmissao.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDataEmissao.PasswordChar = false;
            this.txtDataEmissao.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDataEmissao.PlaceholderText = "";
            this.txtDataEmissao.Size = new System.Drawing.Size(95, 27);
            this.txtDataEmissao.TabIndex = 1;
            this.txtDataEmissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataEmissao.Texts = "  /  /";
            this.txtDataEmissao.UnderlinedStyle = false;
            this.txtDataEmissao.Leave += new System.EventHandler(this.txtDataEmissao_Leave);
            // 
            // txtDataCancelamento
            // 
            this.txtDataCancelamento.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataCancelamento.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDataCancelamento.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtDataCancelamento.BorderRadius = 8;
            this.txtDataCancelamento.BorderSize = 1;
            this.txtDataCancelamento.DisabledBackColor = System.Drawing.Color.White;
            this.txtDataCancelamento.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtDataCancelamento.DisabledForeColor = System.Drawing.Color.White;
            this.txtDataCancelamento.Enabled = false;
            this.txtDataCancelamento.EnabledBackColor = System.Drawing.Color.White;
            this.txtDataCancelamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDataCancelamento.Location = new System.Drawing.Point(257, 353);
            this.txtDataCancelamento.Mask = "00/00/0000";
            this.txtDataCancelamento.MaxLength = 32767;
            this.txtDataCancelamento.Multiline = false;
            this.txtDataCancelamento.Name = "txtDataCancelamento";
            this.txtDataCancelamento.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDataCancelamento.PasswordChar = false;
            this.txtDataCancelamento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDataCancelamento.PlaceholderText = "";
            this.txtDataCancelamento.Size = new System.Drawing.Size(95, 27);
            this.txtDataCancelamento.TabIndex = 15;
            this.txtDataCancelamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataCancelamento.Texts = "  /  /";
            this.txtDataCancelamento.UnderlinedStyle = false;
            // 
            // txtDataPagamento
            // 
            this.txtDataPagamento.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataPagamento.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDataPagamento.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtDataPagamento.BorderRadius = 8;
            this.txtDataPagamento.BorderSize = 1;
            this.txtDataPagamento.DisabledBackColor = System.Drawing.Color.White;
            this.txtDataPagamento.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtDataPagamento.DisabledForeColor = System.Drawing.Color.White;
            this.txtDataPagamento.Enabled = false;
            this.txtDataPagamento.EnabledBackColor = System.Drawing.Color.White;
            this.txtDataPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDataPagamento.Location = new System.Drawing.Point(23, 353);
            this.txtDataPagamento.Mask = "00/00/0000";
            this.txtDataPagamento.MaxLength = 32767;
            this.txtDataPagamento.Multiline = false;
            this.txtDataPagamento.Name = "txtDataPagamento";
            this.txtDataPagamento.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDataPagamento.PasswordChar = false;
            this.txtDataPagamento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDataPagamento.PlaceholderText = "";
            this.txtDataPagamento.Size = new System.Drawing.Size(95, 27);
            this.txtDataPagamento.TabIndex = 13;
            this.txtDataPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataPagamento.Texts = "  /  /";
            this.txtDataPagamento.UnderlinedStyle = false;
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumero.BorderColor = System.Drawing.Color.DarkGray;
            this.txtNumero.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtNumero.BorderRadius = 8;
            this.txtNumero.BorderSize = 1;
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.DisabledBackColor = System.Drawing.Color.White;
            this.txtNumero.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtNumero.DisabledForeColor = System.Drawing.Color.White;
            this.txtNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtNumero.Location = new System.Drawing.Point(138, 34);
            this.txtNumero.MaxLength = 13;
            this.txtNumero.Multiline = false;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtNumero.PasswordChar = false;
            this.txtNumero.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumero.PlaceholderText = "";
            this.txtNumero.Size = new System.Drawing.Size(96, 28);
            this.txtNumero.TabIndex = 2;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumero.Texts = "";
            this.txtNumero.UnderlinedStyle = false;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // txtCodFormaPag
            // 
            this.txtCodFormaPag.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodFormaPag.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCodFormaPag.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtCodFormaPag.BorderRadius = 8;
            this.txtCodFormaPag.BorderSize = 1;
            this.txtCodFormaPag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodFormaPag.DisabledBackColor = System.Drawing.Color.White;
            this.txtCodFormaPag.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCodFormaPag.DisabledForeColor = System.Drawing.Color.White;
            this.txtCodFormaPag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCodFormaPag.Location = new System.Drawing.Point(24, 159);
            this.txtCodFormaPag.MaxLength = 5;
            this.txtCodFormaPag.Multiline = false;
            this.txtCodFormaPag.Name = "txtCodFormaPag";
            this.txtCodFormaPag.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodFormaPag.PasswordChar = false;
            this.txtCodFormaPag.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodFormaPag.PlaceholderText = "";
            this.txtCodFormaPag.Size = new System.Drawing.Size(96, 28);
            this.txtCodFormaPag.TabIndex = 5;
            this.txtCodFormaPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodFormaPag.Texts = "";
            this.txtCodFormaPag.UnderlinedStyle = false;
            this.txtCodFormaPag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodFormaPag_KeyPress);
            this.txtCodFormaPag.Leave += new System.EventHandler(this.txtCodFormaPag_Leave);
            // 
            // txtFormaPag
            // 
            this.txtFormaPag.BackColor = System.Drawing.SystemColors.Window;
            this.txtFormaPag.BorderColor = System.Drawing.Color.DarkGray;
            this.txtFormaPag.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtFormaPag.BorderRadius = 8;
            this.txtFormaPag.BorderSize = 1;
            this.txtFormaPag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFormaPag.DisabledBackColor = System.Drawing.Color.White;
            this.txtFormaPag.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtFormaPag.DisabledForeColor = System.Drawing.Color.White;
            this.txtFormaPag.Enabled = false;
            this.txtFormaPag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtFormaPag.Location = new System.Drawing.Point(203, 159);
            this.txtFormaPag.MaxLength = 32767;
            this.txtFormaPag.Multiline = false;
            this.txtFormaPag.Name = "txtFormaPag";
            this.txtFormaPag.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtFormaPag.PasswordChar = false;
            this.txtFormaPag.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFormaPag.PlaceholderText = "";
            this.txtFormaPag.Size = new System.Drawing.Size(352, 28);
            this.txtFormaPag.TabIndex = 89;
            this.txtFormaPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFormaPag.Texts = "";
            this.txtFormaPag.UnderlinedStyle = false;
            // 
            // btnPesquisarFormaPag
            // 
            this.btnPesquisarFormaPag.BackColor = System.Drawing.Color.GhostWhite;
            this.btnPesquisarFormaPag.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnPesquisarFormaPag.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btnPesquisarFormaPag.BorderRadius = 8;
            this.btnPesquisarFormaPag.BorderSize = 1;
            this.btnPesquisarFormaPag.FlatAppearance.BorderSize = 0;
            this.btnPesquisarFormaPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarFormaPag.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnPesquisarFormaPag.Location = new System.Drawing.Point(130, 156);
            this.btnPesquisarFormaPag.Name = "btnPesquisarFormaPag";
            this.btnPesquisarFormaPag.Size = new System.Drawing.Size(61, 31);
            this.btnPesquisarFormaPag.TabIndex = 6;
            this.btnPesquisarFormaPag.Text = "Buscar";
            this.btnPesquisarFormaPag.TextColor = System.Drawing.Color.DarkViolet;
            this.btnPesquisarFormaPag.UseVisualStyleBackColor = false;
            this.btnPesquisarFormaPag.Click += new System.EventHandler(this.btnPesquisarFormaPag_Click);
            // 
            // txtParcelas
            // 
            this.txtParcelas.BackColor = System.Drawing.SystemColors.Window;
            this.txtParcelas.BorderColor = System.Drawing.Color.DarkGray;
            this.txtParcelas.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtParcelas.BorderRadius = 8;
            this.txtParcelas.BorderSize = 1;
            this.txtParcelas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtParcelas.DisabledBackColor = System.Drawing.Color.White;
            this.txtParcelas.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtParcelas.DisabledForeColor = System.Drawing.Color.White;
            this.txtParcelas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtParcelas.Location = new System.Drawing.Point(24, 215);
            this.txtParcelas.MaxLength = 13;
            this.txtParcelas.Multiline = false;
            this.txtParcelas.Name = "txtParcelas";
            this.txtParcelas.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtParcelas.PasswordChar = false;
            this.txtParcelas.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtParcelas.PlaceholderText = "";
            this.txtParcelas.Size = new System.Drawing.Size(96, 28);
            this.txtParcelas.TabIndex = 7;
            this.txtParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtParcelas.Texts = "";
            this.txtParcelas.UnderlinedStyle = false;
            this.txtParcelas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodFormaPag_KeyPress);
            // 
            // txtValorParcela
            // 
            this.txtValorParcela.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorParcela.BorderColor = System.Drawing.Color.DarkGray;
            this.txtValorParcela.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtValorParcela.BorderRadius = 8;
            this.txtValorParcela.BorderSize = 1;
            this.txtValorParcela.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorParcela.DisabledBackColor = System.Drawing.Color.White;
            this.txtValorParcela.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtValorParcela.DisabledForeColor = System.Drawing.Color.White;
            this.txtValorParcela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtValorParcela.Location = new System.Drawing.Point(139, 215);
            this.txtValorParcela.MaxLength = 13;
            this.txtValorParcela.Multiline = false;
            this.txtValorParcela.Name = "txtValorParcela";
            this.txtValorParcela.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtValorParcela.PasswordChar = false;
            this.txtValorParcela.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtValorParcela.PlaceholderText = "";
            this.txtValorParcela.Size = new System.Drawing.Size(96, 28);
            this.txtValorParcela.TabIndex = 8;
            this.txtValorParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorParcela.Texts = "";
            this.txtValorParcela.UnderlinedStyle = false;
            this.txtValorParcela.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorParcela_KeyPress);
            this.txtValorParcela.Leave += new System.EventHandler(this.txtValorParcela_Leave);
            // 
            // txtDataVencimento
            // 
            this.txtDataVencimento.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataVencimento.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDataVencimento.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtDataVencimento.BorderRadius = 8;
            this.txtDataVencimento.BorderSize = 1;
            this.txtDataVencimento.DisabledBackColor = System.Drawing.Color.White;
            this.txtDataVencimento.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtDataVencimento.DisabledForeColor = System.Drawing.Color.White;
            this.txtDataVencimento.EnabledBackColor = System.Drawing.Color.White;
            this.txtDataVencimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDataVencimento.Location = new System.Drawing.Point(257, 216);
            this.txtDataVencimento.Mask = "00/00/0000";
            this.txtDataVencimento.MaxLength = 32767;
            this.txtDataVencimento.Multiline = false;
            this.txtDataVencimento.Name = "txtDataVencimento";
            this.txtDataVencimento.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDataVencimento.PasswordChar = false;
            this.txtDataVencimento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDataVencimento.PlaceholderText = "";
            this.txtDataVencimento.Size = new System.Drawing.Size(95, 27);
            this.txtDataVencimento.TabIndex = 9;
            this.txtDataVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataVencimento.Texts = "  /  /";
            this.txtDataVencimento.UnderlinedStyle = false;
            this.txtDataVencimento.Leave += new System.EventHandler(this.txtDataVencimento_Leave);
            // 
            // txtMulta
            // 
            this.txtMulta.BackColor = System.Drawing.SystemColors.Window;
            this.txtMulta.BorderColor = System.Drawing.Color.DarkGray;
            this.txtMulta.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtMulta.BorderRadius = 8;
            this.txtMulta.BorderSize = 1;
            this.txtMulta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMulta.DisabledBackColor = System.Drawing.Color.White;
            this.txtMulta.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtMulta.DisabledForeColor = System.Drawing.Color.White;
            this.txtMulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtMulta.Location = new System.Drawing.Point(139, 286);
            this.txtMulta.MaxLength = 13;
            this.txtMulta.Multiline = false;
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtMulta.PasswordChar = false;
            this.txtMulta.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMulta.PlaceholderText = "";
            this.txtMulta.Size = new System.Drawing.Size(96, 28);
            this.txtMulta.TabIndex = 11;
            this.txtMulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMulta.Texts = "";
            this.txtMulta.UnderlinedStyle = false;
            this.txtMulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJuros_KeyPress);
            // 
            // txtDesconto
            // 
            this.txtDesconto.BackColor = System.Drawing.SystemColors.Window;
            this.txtDesconto.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDesconto.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtDesconto.BorderRadius = 8;
            this.txtDesconto.BorderSize = 1;
            this.txtDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesconto.DisabledBackColor = System.Drawing.Color.White;
            this.txtDesconto.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtDesconto.DisabledForeColor = System.Drawing.Color.White;
            this.txtDesconto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDesconto.Location = new System.Drawing.Point(257, 286);
            this.txtDesconto.MaxLength = 13;
            this.txtDesconto.Multiline = false;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDesconto.PasswordChar = false;
            this.txtDesconto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDesconto.PlaceholderText = "";
            this.txtDesconto.Size = new System.Drawing.Size(95, 28);
            this.txtDesconto.TabIndex = 12;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesconto.Texts = "";
            this.txtDesconto.UnderlinedStyle = false;
            this.txtDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJuros_KeyPress);
            // 
            // txtJuros
            // 
            this.txtJuros.BackColor = System.Drawing.SystemColors.Window;
            this.txtJuros.BorderColor = System.Drawing.Color.DarkGray;
            this.txtJuros.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtJuros.BorderRadius = 8;
            this.txtJuros.BorderSize = 1;
            this.txtJuros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtJuros.DisabledBackColor = System.Drawing.Color.White;
            this.txtJuros.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtJuros.DisabledForeColor = System.Drawing.Color.White;
            this.txtJuros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtJuros.Location = new System.Drawing.Point(24, 286);
            this.txtJuros.MaxLength = 13;
            this.txtJuros.Multiline = false;
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtJuros.PasswordChar = false;
            this.txtJuros.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtJuros.PlaceholderText = "";
            this.txtJuros.Size = new System.Drawing.Size(96, 28);
            this.txtJuros.TabIndex = 10;
            this.txtJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtJuros.Texts = "";
            this.txtJuros.UnderlinedStyle = false;
            this.txtJuros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJuros_KeyPress);
            // 
            // txtValorPago
            // 
            this.txtValorPago.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorPago.BorderColor = System.Drawing.Color.DarkGray;
            this.txtValorPago.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtValorPago.BorderRadius = 8;
            this.txtValorPago.BorderSize = 1;
            this.txtValorPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorPago.DisabledBackColor = System.Drawing.Color.White;
            this.txtValorPago.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtValorPago.DisabledForeColor = System.Drawing.Color.White;
            this.txtValorPago.Enabled = false;
            this.txtValorPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtValorPago.Location = new System.Drawing.Point(138, 353);
            this.txtValorPago.MaxLength = 13;
            this.txtValorPago.Multiline = false;
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtValorPago.PasswordChar = false;
            this.txtValorPago.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtValorPago.PlaceholderText = "";
            this.txtValorPago.Size = new System.Drawing.Size(96, 28);
            this.txtValorPago.TabIndex = 14;
            this.txtValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorPago.Texts = "";
            this.txtValorPago.UnderlinedStyle = false;
            this.txtValorPago.Leave += new System.EventHandler(this.txtValorPago_Leave);
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalPagar.BorderColor = System.Drawing.Color.DarkGray;
            this.txtTotalPagar.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtTotalPagar.BorderRadius = 8;
            this.txtTotalPagar.BorderSize = 1;
            this.txtTotalPagar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalPagar.DisabledBackColor = System.Drawing.Color.White;
            this.txtTotalPagar.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtTotalPagar.DisabledForeColor = System.Drawing.Color.White;
            this.txtTotalPagar.Enabled = false;
            this.txtTotalPagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtTotalPagar.Location = new System.Drawing.Point(376, 353);
            this.txtTotalPagar.MaxLength = 32767;
            this.txtTotalPagar.Multiline = false;
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtTotalPagar.PasswordChar = false;
            this.txtTotalPagar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTotalPagar.PlaceholderText = "";
            this.txtTotalPagar.Size = new System.Drawing.Size(96, 28);
            this.txtTotalPagar.TabIndex = 16;
            this.txtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalPagar.Texts = "";
            this.txtTotalPagar.UnderlinedStyle = false;
            // 
            // txtObservacao
            // 
            this.txtObservacao.BackColor = System.Drawing.SystemColors.Window;
            this.txtObservacao.BorderColor = System.Drawing.Color.DarkGray;
            this.txtObservacao.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtObservacao.BorderRadius = 8;
            this.txtObservacao.BorderSize = 1;
            this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.DisabledBackColor = System.Drawing.Color.White;
            this.txtObservacao.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtObservacao.DisabledForeColor = System.Drawing.Color.White;
            this.txtObservacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtObservacao.Location = new System.Drawing.Point(24, 424);
            this.txtObservacao.MaxLength = 200;
            this.txtObservacao.Multiline = false;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtObservacao.PasswordChar = false;
            this.txtObservacao.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtObservacao.PlaceholderText = "";
            this.txtObservacao.Size = new System.Drawing.Size(531, 28);
            this.txtObservacao.TabIndex = 17;
            this.txtObservacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtObservacao.Texts = "";
            this.txtObservacao.UnderlinedStyle = false;
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.GhostWhite;
            this.btnPagar.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnPagar.BorderColor = System.Drawing.Color.Green;
            this.btnPagar.BorderRadius = 8;
            this.btnPagar.BorderSize = 1;
            this.btnPagar.FlatAppearance.BorderSize = 0;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.ForeColor = System.Drawing.Color.Green;
            this.btnPagar.Location = new System.Drawing.Point(307, 484);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(70, 31);
            this.btnPagar.TabIndex = 99;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.TextColor = System.Drawing.Color.Green;
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.GhostWhite;
            this.btnCancelar.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnCancelar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.BorderRadius = 8;
            this.btnCancelar.BorderSize = 1;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Location = new System.Drawing.Point(231, 484);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(70, 31);
            this.btnCancelar.TabIndex = 100;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.BackColor = System.Drawing.SystemColors.Window;
            this.txtFornecedor.BorderColor = System.Drawing.Color.DarkGray;
            this.txtFornecedor.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtFornecedor.BorderRadius = 8;
            this.txtFornecedor.BorderSize = 1;
            this.txtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedor.DisabledBackColor = System.Drawing.Color.White;
            this.txtFornecedor.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtFornecedor.DisabledForeColor = System.Drawing.Color.White;
            this.txtFornecedor.Enabled = false;
            this.txtFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtFornecedor.Location = new System.Drawing.Point(203, 97);
            this.txtFornecedor.MaxLength = 32767;
            this.txtFornecedor.Multiline = false;
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtFornecedor.PasswordChar = false;
            this.txtFornecedor.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFornecedor.PlaceholderText = "";
            this.txtFornecedor.Size = new System.Drawing.Size(352, 28);
            this.txtFornecedor.TabIndex = 105;
            this.txtFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFornecedor.Texts = "";
            this.txtFornecedor.UnderlinedStyle = false;
            // 
            // btnPesquisaFornecedor
            // 
            this.btnPesquisaFornecedor.BackColor = System.Drawing.Color.GhostWhite;
            this.btnPesquisaFornecedor.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnPesquisaFornecedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btnPesquisaFornecedor.BorderRadius = 8;
            this.btnPesquisaFornecedor.BorderSize = 1;
            this.btnPesquisaFornecedor.FlatAppearance.BorderSize = 0;
            this.btnPesquisaFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisaFornecedor.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnPesquisaFornecedor.Location = new System.Drawing.Point(130, 94);
            this.btnPesquisaFornecedor.Name = "btnPesquisaFornecedor";
            this.btnPesquisaFornecedor.Size = new System.Drawing.Size(61, 31);
            this.btnPesquisaFornecedor.TabIndex = 4;
            this.btnPesquisaFornecedor.Text = "Buscar";
            this.btnPesquisaFornecedor.TextColor = System.Drawing.Color.DarkViolet;
            this.btnPesquisaFornecedor.UseVisualStyleBackColor = false;
            this.btnPesquisaFornecedor.Click += new System.EventHandler(this.btnPesquisaFornecedor_Click);
            // 
            // txtCodFornecedor
            // 
            this.txtCodFornecedor.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodFornecedor.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCodFornecedor.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtCodFornecedor.BorderRadius = 8;
            this.txtCodFornecedor.BorderSize = 1;
            this.txtCodFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodFornecedor.DisabledBackColor = System.Drawing.Color.White;
            this.txtCodFornecedor.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCodFornecedor.DisabledForeColor = System.Drawing.Color.White;
            this.txtCodFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCodFornecedor.Location = new System.Drawing.Point(24, 97);
            this.txtCodFornecedor.MaxLength = 5;
            this.txtCodFornecedor.Multiline = false;
            this.txtCodFornecedor.Name = "txtCodFornecedor";
            this.txtCodFornecedor.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodFornecedor.PasswordChar = false;
            this.txtCodFornecedor.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodFornecedor.PlaceholderText = "";
            this.txtCodFornecedor.Size = new System.Drawing.Size(96, 28);
            this.txtCodFornecedor.TabIndex = 3;
            this.txtCodFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodFornecedor.Texts = "";
            this.txtCodFornecedor.UnderlinedStyle = false;
            this.txtCodFornecedor.Leave += new System.EventHandler(this.txtCodFornecedor_Leave);
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(200, 81);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(64, 13);
            this.lblFornecedor.TabIndex = 103;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // lblCodFornecedor
            // 
            this.lblCodFornecedor.AutoSize = true;
            this.lblCodFornecedor.Location = new System.Drawing.Point(21, 80);
            this.lblCodFornecedor.Name = "lblCodFornecedor";
            this.lblCodFornecedor.Size = new System.Drawing.Size(96, 13);
            this.lblCodFornecedor.TabIndex = 102;
            this.lblCodFornecedor.Text = "Cód. Fornecedor.:*";
            // 
            // CadastroContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(577, 539);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.btnPesquisaFornecedor);
            this.Controls.Add(this.txtCodFornecedor);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.lblCodFornecedor);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.txtValorPago);
            this.Controls.Add(this.txtMulta);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtJuros);
            this.Controls.Add(this.txtDataVencimento);
            this.Controls.Add(this.txtValorParcela);
            this.Controls.Add(this.txtParcelas);
            this.Controls.Add(this.txtFormaPag);
            this.Controls.Add(this.btnPesquisarFormaPag);
            this.Controls.Add(this.txtCodFormaPag);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtDataPagamento);
            this.Controls.Add(this.txtDataCancelamento);
            this.Controls.Add(this.txtDataEmissao);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblDataEmissao);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.lblDataCancelamento);
            this.Controls.Add(this.lblValorPago);
            this.Controls.Add(this.lblDataPagamento);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.lblMulta);
            this.Controls.Add(this.lblJuros);
            this.Controls.Add(this.lblDataVencimento);
            this.Controls.Add(this.lblValorParcela);
            this.Controls.Add(this.lblParcelas);
            this.Controls.Add(this.lblFormaPagamento);
            this.Controls.Add(this.lblCodFormPag);
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
            this.Controls.SetChildIndex(this.lblCodFormPag, 0);
            this.Controls.SetChildIndex(this.lblFormaPagamento, 0);
            this.Controls.SetChildIndex(this.lblParcelas, 0);
            this.Controls.SetChildIndex(this.lblValorParcela, 0);
            this.Controls.SetChildIndex(this.lblDataVencimento, 0);
            this.Controls.SetChildIndex(this.lblJuros, 0);
            this.Controls.SetChildIndex(this.lblMulta, 0);
            this.Controls.SetChildIndex(this.lblDesconto, 0);
            this.Controls.SetChildIndex(this.lblDataPagamento, 0);
            this.Controls.SetChildIndex(this.lblValorPago, 0);
            this.Controls.SetChildIndex(this.lblDataCancelamento, 0);
            this.Controls.SetChildIndex(this.lblObservacao, 0);
            this.Controls.SetChildIndex(this.lblDataEmissao, 0);
            this.Controls.SetChildIndex(this.lblNumero, 0);
            this.Controls.SetChildIndex(this.lblTotalPagar, 0);
            this.Controls.SetChildIndex(this.txtDataEmissao, 0);
            this.Controls.SetChildIndex(this.txtDataCancelamento, 0);
            this.Controls.SetChildIndex(this.txtDataPagamento, 0);
            this.Controls.SetChildIndex(this.txtNumero, 0);
            this.Controls.SetChildIndex(this.txtCodFormaPag, 0);
            this.Controls.SetChildIndex(this.btnPesquisarFormaPag, 0);
            this.Controls.SetChildIndex(this.txtFormaPag, 0);
            this.Controls.SetChildIndex(this.txtParcelas, 0);
            this.Controls.SetChildIndex(this.txtValorParcela, 0);
            this.Controls.SetChildIndex(this.txtDataVencimento, 0);
            this.Controls.SetChildIndex(this.txtJuros, 0);
            this.Controls.SetChildIndex(this.txtDesconto, 0);
            this.Controls.SetChildIndex(this.txtMulta, 0);
            this.Controls.SetChildIndex(this.txtValorPago, 0);
            this.Controls.SetChildIndex(this.txtTotalPagar, 0);
            this.Controls.SetChildIndex(this.txtObservacao, 0);
            this.Controls.SetChildIndex(this.btnPagar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.lblCodFornecedor, 0);
            this.Controls.SetChildIndex(this.lblFornecedor, 0);
            this.Controls.SetChildIndex(this.txtCodFornecedor, 0);
            this.Controls.SetChildIndex(this.btnPesquisaFornecedor, 0);
            this.Controls.SetChildIndex(this.txtFornecedor, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Label lblDataCancelamento;
        private System.Windows.Forms.Label lblValorPago;
        private System.Windows.Forms.Label lblDataPagamento;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblMulta;
        private System.Windows.Forms.Label lblJuros;
        private System.Windows.Forms.Label lblDataVencimento;
        private System.Windows.Forms.Label lblValorParcela;
        private System.Windows.Forms.Label lblParcelas;
        private System.Windows.Forms.Label lblFormaPagamento;
        private System.Windows.Forms.Label lblCodFormPag;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblDataEmissao;
        private System.Windows.Forms.Label lblTotalPagar;
        private YControls.YMaskedTextBox txtDataEmissao;
        private YControls.YMaskedTextBox txtDataCancelamento;
        private YControls.YMaskedTextBox txtDataPagamento;
        private YControls.YTextBox txtNumero;
        private YControls.YTextBox txtCodFormaPag;
        private YControls.YTextBox txtFormaPag;
        protected YControls.YButton btnPesquisarFormaPag;
        private YControls.YTextBox txtParcelas;
        private YControls.YTextBox txtValorParcela;
        private YControls.YMaskedTextBox txtDataVencimento;
        private YControls.YTextBox txtMulta;
        private YControls.YTextBox txtDesconto;
        private YControls.YTextBox txtJuros;
        private YControls.YTextBox txtValorPago;
        private YControls.YTextBox txtTotalPagar;
        private YControls.YTextBox txtObservacao;
        protected YControls.YButton btnPagar;
        protected YControls.YButton btnCancelar;
        private YControls.YTextBox txtFornecedor;
        protected YControls.YButton btnPesquisaFornecedor;
        private YControls.YTextBox txtCodFornecedor;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblCodFornecedor;
    }
}
