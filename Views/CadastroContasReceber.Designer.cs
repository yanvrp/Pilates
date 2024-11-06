namespace Pilates.Views
{
    partial class CadastroContasReceber
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
            this.lblCodAluno = new System.Windows.Forms.Label();
            this.lblAluno = new System.Windows.Forms.Label();
            this.lblFormaPagamento = new System.Windows.Forms.Label();
            this.lblCodFormPag = new System.Windows.Forms.Label();
            this.lblParcelas = new System.Windows.Forms.Label();
            this.lblValorParcela = new System.Windows.Forms.Label();
            this.lblDataVencimento = new System.Windows.Forms.Label();
            this.lblJuros = new System.Windows.Forms.Label();
            this.lblMulta = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblDataRecebimento = new System.Windows.Forms.Label();
            this.lblValorRecebido = new System.Windows.Forms.Label();
            this.lblDataCancelamento = new System.Windows.Forms.Label();
            this.lblTotalReceber = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.lblDataEmissao = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new Pilates.YControls.YTextBox();
            this.txtDataEmissao = new Pilates.YControls.YMaskedTextBox();
            this.txtFormaPag = new Pilates.YControls.YTextBox();
            this.btnPesquisarFormaPag = new Pilates.YControls.YButton();
            this.txtCodFormaPag = new Pilates.YControls.YTextBox();
            this.txtAluno = new Pilates.YControls.YTextBox();
            this.btnPesquisarAluno = new Pilates.YControls.YButton();
            this.txtCodAluno = new Pilates.YControls.YTextBox();
            this.txtDataVencimento = new Pilates.YControls.YMaskedTextBox();
            this.txtValorParcela = new Pilates.YControls.YTextBox();
            this.txtParcelas = new Pilates.YControls.YTextBox();
            this.txtMulta = new Pilates.YControls.YTextBox();
            this.txtDesconto = new Pilates.YControls.YTextBox();
            this.txtJuros = new Pilates.YControls.YTextBox();
            this.txtTotalReceber = new Pilates.YControls.YTextBox();
            this.txtValorRecebido = new Pilates.YControls.YTextBox();
            this.txtDataRecebimento = new Pilates.YControls.YMaskedTextBox();
            this.txtDataCancelamento = new Pilates.YControls.YMaskedTextBox();
            this.txtObservacao = new Pilates.YControls.YTextBox();
            this.btnCancelar = new Pilates.YControls.YButton();
            this.btnReceber = new Pilates.YControls.YButton();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(534, 198);
            this.lblCodigo.Visible = false;
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(122, 445);
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(23, 445);
            // 
            // gbStatus
            // 
            this.gbStatus.Location = new System.Drawing.Point(387, 20);
            this.gbStatus.Size = new System.Drawing.Size(147, 46);
            // 
            // rbInativo
            // 
            this.rbInativo.Location = new System.Drawing.Point(78, 19);
            // 
            // rbAtivo
            // 
            this.rbAtivo.Location = new System.Drawing.Point(18, 19);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(382, 458);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(537, 214);
            this.txtCodigo.Texts = "0";
            this.txtCodigo.Visible = false;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(23, 462);
            this.txtDataCadastro.Size = new System.Drawing.Size(90, 27);
            this.txtDataCadastro.Texts = "25/10/2024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(125, 461);
            this.txtDataUltAlt.Size = new System.Drawing.Size(90, 27);
            this.txtDataUltAlt.Texts = "25/10/2024";
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(471, 458);
            // 
            // txtUsuarioUltAlt
            // 
            this.txtUsuarioUltAlt.Location = new System.Drawing.Point(283, 35);
            // 
            // lblUsuarioUltAlt
            // 
            this.lblUsuarioUltAlt.Location = new System.Drawing.Point(280, 19);
            // 
            // lblCodAluno
            // 
            this.lblCodAluno.AutoSize = true;
            this.lblCodAluno.Location = new System.Drawing.Point(23, 76);
            this.lblCodAluno.Name = "lblCodAluno";
            this.lblCodAluno.Size = new System.Drawing.Size(66, 13);
            this.lblCodAluno.TabIndex = 10;
            this.lblCodAluno.Text = "Cód. Aluno:*";
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(199, 76);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(37, 13);
            this.lblAluno.TabIndex = 13;
            this.lblAluno.Text = "Aluno:";
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.AutoSize = true;
            this.lblFormaPagamento.Location = new System.Drawing.Point(199, 135);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(111, 13);
            this.lblFormaPagamento.TabIndex = 18;
            this.lblFormaPagamento.Text = "Forma de Pagamento:";
            // 
            // lblCodFormPag
            // 
            this.lblCodFormPag.AutoSize = true;
            this.lblCodFormPag.Location = new System.Drawing.Point(20, 135);
            this.lblCodFormPag.Name = "lblCodFormPag";
            this.lblCodFormPag.Size = new System.Drawing.Size(93, 13);
            this.lblCodFormPag.TabIndex = 15;
            this.lblCodFormPag.Text = "Cód. Forma Pag.:*";
            // 
            // lblParcelas
            // 
            this.lblParcelas.AutoSize = true;
            this.lblParcelas.Location = new System.Drawing.Point(20, 198);
            this.lblParcelas.Name = "lblParcelas";
            this.lblParcelas.Size = new System.Drawing.Size(90, 13);
            this.lblParcelas.TabIndex = 19;
            this.lblParcelas.Text = "Numero Parcela:*";
            // 
            // lblValorParcela
            // 
            this.lblValorParcela.AutoSize = true;
            this.lblValorParcela.Location = new System.Drawing.Point(135, 198);
            this.lblValorParcela.Name = "lblValorParcela";
            this.lblValorParcela.Size = new System.Drawing.Size(77, 13);
            this.lblValorParcela.TabIndex = 21;
            this.lblValorParcela.Text = "Valor Parcela:*";
            // 
            // lblDataVencimento
            // 
            this.lblDataVencimento.AutoSize = true;
            this.lblDataVencimento.Location = new System.Drawing.Point(253, 198);
            this.lblDataVencimento.Name = "lblDataVencimento";
            this.lblDataVencimento.Size = new System.Drawing.Size(96, 13);
            this.lblDataVencimento.TabIndex = 23;
            this.lblDataVencimento.Text = "Data Vencimento:*";
            // 
            // lblJuros
            // 
            this.lblJuros.AutoSize = true;
            this.lblJuros.Location = new System.Drawing.Point(20, 257);
            this.lblJuros.Name = "lblJuros";
            this.lblJuros.Size = new System.Drawing.Size(35, 13);
            this.lblJuros.TabIndex = 25;
            this.lblJuros.Text = "Juros:";
            // 
            // lblMulta
            // 
            this.lblMulta.AutoSize = true;
            this.lblMulta.Location = new System.Drawing.Point(135, 257);
            this.lblMulta.Name = "lblMulta";
            this.lblMulta.Size = new System.Drawing.Size(36, 13);
            this.lblMulta.TabIndex = 27;
            this.lblMulta.Text = "Multa:";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(253, 257);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(56, 13);
            this.lblDesconto.TabIndex = 29;
            this.lblDesconto.Text = "Desconto:";
            // 
            // lblDataRecebimento
            // 
            this.lblDataRecebimento.AutoSize = true;
            this.lblDataRecebimento.Location = new System.Drawing.Point(20, 322);
            this.lblDataRecebimento.Name = "lblDataRecebimento";
            this.lblDataRecebimento.Size = new System.Drawing.Size(99, 13);
            this.lblDataRecebimento.TabIndex = 31;
            this.lblDataRecebimento.Text = "Data Recebimento:";
            // 
            // lblValorRecebido
            // 
            this.lblValorRecebido.AutoSize = true;
            this.lblValorRecebido.Location = new System.Drawing.Point(135, 322);
            this.lblValorRecebido.Name = "lblValorRecebido";
            this.lblValorRecebido.Size = new System.Drawing.Size(83, 13);
            this.lblValorRecebido.TabIndex = 33;
            this.lblValorRecebido.Text = "Valor Recebido:";
            // 
            // lblDataCancelamento
            // 
            this.lblDataCancelamento.AutoSize = true;
            this.lblDataCancelamento.Location = new System.Drawing.Point(254, 322);
            this.lblDataCancelamento.Name = "lblDataCancelamento";
            this.lblDataCancelamento.Size = new System.Drawing.Size(104, 13);
            this.lblDataCancelamento.TabIndex = 35;
            this.lblDataCancelamento.Text = "Data Cancelamento:";
            // 
            // lblTotalReceber
            // 
            this.lblTotalReceber.AutoSize = true;
            this.lblTotalReceber.Location = new System.Drawing.Point(375, 322);
            this.lblTotalReceber.Name = "lblTotalReceber";
            this.lblTotalReceber.Size = new System.Drawing.Size(61, 13);
            this.lblTotalReceber.TabIndex = 37;
            this.lblTotalReceber.Text = "Valor Total:";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(20, 384);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(68, 13);
            this.lblObservacao.TabIndex = 39;
            this.lblObservacao.Text = "Observação:";
            // 
            // lblDataEmissao
            // 
            this.lblDataEmissao.AutoSize = true;
            this.lblDataEmissao.Location = new System.Drawing.Point(20, 20);
            this.lblDataEmissao.Name = "lblDataEmissao";
            this.lblDataEmissao.Size = new System.Drawing.Size(79, 13);
            this.lblDataEmissao.TabIndex = 41;
            this.lblDataEmissao.Text = "Data Emissão:*";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(134, 19);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(51, 13);
            this.lblNumero.TabIndex = 43;
            this.lblNumero.Text = "Número*:";
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
            this.txtNumero.Location = new System.Drawing.Point(137, 35);
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
            this.txtDataEmissao.Location = new System.Drawing.Point(23, 36);
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
            this.txtFormaPag.Location = new System.Drawing.Point(202, 151);
            this.txtFormaPag.MaxLength = 32767;
            this.txtFormaPag.Multiline = false;
            this.txtFormaPag.Name = "txtFormaPag";
            this.txtFormaPag.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtFormaPag.PasswordChar = false;
            this.txtFormaPag.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFormaPag.PlaceholderText = "";
            this.txtFormaPag.Size = new System.Drawing.Size(352, 28);
            this.txtFormaPag.TabIndex = 92;
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
            this.btnPesquisarFormaPag.Location = new System.Drawing.Point(129, 148);
            this.btnPesquisarFormaPag.Name = "btnPesquisarFormaPag";
            this.btnPesquisarFormaPag.Size = new System.Drawing.Size(61, 31);
            this.btnPesquisarFormaPag.TabIndex = 91;
            this.btnPesquisarFormaPag.Text = "Buscar";
            this.btnPesquisarFormaPag.TextColor = System.Drawing.Color.DarkViolet;
            this.btnPesquisarFormaPag.UseVisualStyleBackColor = false;
            this.btnPesquisarFormaPag.Click += new System.EventHandler(this.btnPesquisarFormaPag_Click);
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
            this.txtCodFormaPag.Location = new System.Drawing.Point(23, 151);
            this.txtCodFormaPag.MaxLength = 5;
            this.txtCodFormaPag.Multiline = false;
            this.txtCodFormaPag.Name = "txtCodFormaPag";
            this.txtCodFormaPag.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodFormaPag.PasswordChar = false;
            this.txtCodFormaPag.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodFormaPag.PlaceholderText = "";
            this.txtCodFormaPag.Size = new System.Drawing.Size(96, 28);
            this.txtCodFormaPag.TabIndex = 4;
            this.txtCodFormaPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodFormaPag.Texts = "";
            this.txtCodFormaPag.UnderlinedStyle = false;
            this.txtCodFormaPag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodFormaPag_KeyPress);
            this.txtCodFormaPag.Leave += new System.EventHandler(this.txtCodFormaPag_Leave);
            // 
            // txtAluno
            // 
            this.txtAluno.BackColor = System.Drawing.SystemColors.Window;
            this.txtAluno.BorderColor = System.Drawing.Color.DarkGray;
            this.txtAluno.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtAluno.BorderRadius = 8;
            this.txtAluno.BorderSize = 1;
            this.txtAluno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAluno.DisabledBackColor = System.Drawing.Color.White;
            this.txtAluno.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtAluno.DisabledForeColor = System.Drawing.Color.White;
            this.txtAluno.Enabled = false;
            this.txtAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtAluno.Location = new System.Drawing.Point(202, 92);
            this.txtAluno.MaxLength = 32767;
            this.txtAluno.Multiline = false;
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtAluno.PasswordChar = false;
            this.txtAluno.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAluno.PlaceholderText = "";
            this.txtAluno.Size = new System.Drawing.Size(352, 28);
            this.txtAluno.TabIndex = 95;
            this.txtAluno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAluno.Texts = "";
            this.txtAluno.UnderlinedStyle = false;
            // 
            // btnPesquisarAluno
            // 
            this.btnPesquisarAluno.BackColor = System.Drawing.Color.GhostWhite;
            this.btnPesquisarAluno.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnPesquisarAluno.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btnPesquisarAluno.BorderRadius = 8;
            this.btnPesquisarAluno.BorderSize = 1;
            this.btnPesquisarAluno.FlatAppearance.BorderSize = 0;
            this.btnPesquisarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarAluno.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnPesquisarAluno.Location = new System.Drawing.Point(129, 92);
            this.btnPesquisarAluno.Name = "btnPesquisarAluno";
            this.btnPesquisarAluno.Size = new System.Drawing.Size(61, 31);
            this.btnPesquisarAluno.TabIndex = 94;
            this.btnPesquisarAluno.Text = "Buscar";
            this.btnPesquisarAluno.TextColor = System.Drawing.Color.DarkViolet;
            this.btnPesquisarAluno.UseVisualStyleBackColor = false;
            this.btnPesquisarAluno.Click += new System.EventHandler(this.btnPesquisarAluno_Click);
            // 
            // txtCodAluno
            // 
            this.txtCodAluno.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodAluno.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCodAluno.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtCodAluno.BorderRadius = 8;
            this.txtCodAluno.BorderSize = 1;
            this.txtCodAluno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodAluno.DisabledBackColor = System.Drawing.Color.White;
            this.txtCodAluno.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCodAluno.DisabledForeColor = System.Drawing.Color.White;
            this.txtCodAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCodAluno.Location = new System.Drawing.Point(23, 92);
            this.txtCodAluno.MaxLength = 5;
            this.txtCodAluno.Multiline = false;
            this.txtCodAluno.Name = "txtCodAluno";
            this.txtCodAluno.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodAluno.PasswordChar = false;
            this.txtCodAluno.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodAluno.PlaceholderText = "";
            this.txtCodAluno.Size = new System.Drawing.Size(95, 28);
            this.txtCodAluno.TabIndex = 3;
            this.txtCodAluno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodAluno.Texts = "";
            this.txtCodAluno.UnderlinedStyle = false;
            this.txtCodAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodFormaPag_KeyPress);
            this.txtCodAluno.Leave += new System.EventHandler(this.txtCodAluno_Leave);
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
            this.txtDataVencimento.Location = new System.Drawing.Point(256, 215);
            this.txtDataVencimento.Mask = "00/00/0000";
            this.txtDataVencimento.MaxLength = 32767;
            this.txtDataVencimento.Multiline = false;
            this.txtDataVencimento.Name = "txtDataVencimento";
            this.txtDataVencimento.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDataVencimento.PasswordChar = false;
            this.txtDataVencimento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDataVencimento.PlaceholderText = "";
            this.txtDataVencimento.Size = new System.Drawing.Size(95, 27);
            this.txtDataVencimento.TabIndex = 7;
            this.txtDataVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataVencimento.Texts = "  /  /";
            this.txtDataVencimento.UnderlinedStyle = false;
            this.txtDataVencimento.Leave += new System.EventHandler(this.txtDataVencimento_Leave);
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
            this.txtValorParcela.Location = new System.Drawing.Point(138, 214);
            this.txtValorParcela.MaxLength = 13;
            this.txtValorParcela.Multiline = false;
            this.txtValorParcela.Name = "txtValorParcela";
            this.txtValorParcela.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtValorParcela.PasswordChar = false;
            this.txtValorParcela.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtValorParcela.PlaceholderText = "";
            this.txtValorParcela.Size = new System.Drawing.Size(96, 28);
            this.txtValorParcela.TabIndex = 6;
            this.txtValorParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorParcela.Texts = "";
            this.txtValorParcela.UnderlinedStyle = false;
            this.txtValorParcela.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorParcela_KeyPress);
            this.txtValorParcela.Leave += new System.EventHandler(this.txtValorParcela_Leave);
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
            this.txtParcelas.Location = new System.Drawing.Point(23, 214);
            this.txtParcelas.MaxLength = 13;
            this.txtParcelas.Multiline = false;
            this.txtParcelas.Name = "txtParcelas";
            this.txtParcelas.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtParcelas.PasswordChar = false;
            this.txtParcelas.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtParcelas.PlaceholderText = "";
            this.txtParcelas.Size = new System.Drawing.Size(96, 28);
            this.txtParcelas.TabIndex = 5;
            this.txtParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtParcelas.Texts = "";
            this.txtParcelas.UnderlinedStyle = false;
            this.txtParcelas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
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
            this.txtMulta.Location = new System.Drawing.Point(138, 273);
            this.txtMulta.MaxLength = 13;
            this.txtMulta.Multiline = false;
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtMulta.PasswordChar = false;
            this.txtMulta.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMulta.PlaceholderText = "";
            this.txtMulta.Size = new System.Drawing.Size(96, 28);
            this.txtMulta.TabIndex = 9;
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
            this.txtDesconto.Location = new System.Drawing.Point(256, 273);
            this.txtDesconto.MaxLength = 13;
            this.txtDesconto.Multiline = false;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDesconto.PasswordChar = false;
            this.txtDesconto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDesconto.PlaceholderText = "";
            this.txtDesconto.Size = new System.Drawing.Size(95, 28);
            this.txtDesconto.TabIndex = 10;
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
            this.txtJuros.Location = new System.Drawing.Point(23, 273);
            this.txtJuros.MaxLength = 13;
            this.txtJuros.Multiline = false;
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtJuros.PasswordChar = false;
            this.txtJuros.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtJuros.PlaceholderText = "";
            this.txtJuros.Size = new System.Drawing.Size(96, 28);
            this.txtJuros.TabIndex = 8;
            this.txtJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtJuros.Texts = "";
            this.txtJuros.UnderlinedStyle = false;
            this.txtJuros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJuros_KeyPress);
            // 
            // txtTotalReceber
            // 
            this.txtTotalReceber.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalReceber.BorderColor = System.Drawing.Color.DarkGray;
            this.txtTotalReceber.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtTotalReceber.BorderRadius = 8;
            this.txtTotalReceber.BorderSize = 1;
            this.txtTotalReceber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalReceber.DisabledBackColor = System.Drawing.Color.White;
            this.txtTotalReceber.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtTotalReceber.DisabledForeColor = System.Drawing.Color.White;
            this.txtTotalReceber.Enabled = false;
            this.txtTotalReceber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtTotalReceber.Location = new System.Drawing.Point(376, 338);
            this.txtTotalReceber.MaxLength = 13;
            this.txtTotalReceber.Multiline = false;
            this.txtTotalReceber.Name = "txtTotalReceber";
            this.txtTotalReceber.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtTotalReceber.PasswordChar = false;
            this.txtTotalReceber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTotalReceber.PlaceholderText = "";
            this.txtTotalReceber.Size = new System.Drawing.Size(96, 28);
            this.txtTotalReceber.TabIndex = 14;
            this.txtTotalReceber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalReceber.Texts = "";
            this.txtTotalReceber.UnderlinedStyle = false;
            // 
            // txtValorRecebido
            // 
            this.txtValorRecebido.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorRecebido.BorderColor = System.Drawing.Color.DarkGray;
            this.txtValorRecebido.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtValorRecebido.BorderRadius = 8;
            this.txtValorRecebido.BorderSize = 1;
            this.txtValorRecebido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorRecebido.DisabledBackColor = System.Drawing.Color.White;
            this.txtValorRecebido.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtValorRecebido.DisabledForeColor = System.Drawing.Color.White;
            this.txtValorRecebido.Enabled = false;
            this.txtValorRecebido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtValorRecebido.Location = new System.Drawing.Point(138, 338);
            this.txtValorRecebido.MaxLength = 13;
            this.txtValorRecebido.Multiline = false;
            this.txtValorRecebido.Name = "txtValorRecebido";
            this.txtValorRecebido.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtValorRecebido.PasswordChar = false;
            this.txtValorRecebido.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtValorRecebido.PlaceholderText = "";
            this.txtValorRecebido.Size = new System.Drawing.Size(96, 28);
            this.txtValorRecebido.TabIndex = 12;
            this.txtValorRecebido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorRecebido.Texts = "";
            this.txtValorRecebido.UnderlinedStyle = false;
            this.txtValorRecebido.Leave += new System.EventHandler(this.txtValorRecebido_Leave);
            // 
            // txtDataRecebimento
            // 
            this.txtDataRecebimento.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataRecebimento.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDataRecebimento.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtDataRecebimento.BorderRadius = 8;
            this.txtDataRecebimento.BorderSize = 1;
            this.txtDataRecebimento.DisabledBackColor = System.Drawing.Color.White;
            this.txtDataRecebimento.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtDataRecebimento.DisabledForeColor = System.Drawing.Color.White;
            this.txtDataRecebimento.Enabled = false;
            this.txtDataRecebimento.EnabledBackColor = System.Drawing.Color.White;
            this.txtDataRecebimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDataRecebimento.Location = new System.Drawing.Point(23, 338);
            this.txtDataRecebimento.Mask = "00/00/0000";
            this.txtDataRecebimento.MaxLength = 32767;
            this.txtDataRecebimento.Multiline = false;
            this.txtDataRecebimento.Name = "txtDataRecebimento";
            this.txtDataRecebimento.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDataRecebimento.PasswordChar = false;
            this.txtDataRecebimento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDataRecebimento.PlaceholderText = "";
            this.txtDataRecebimento.Size = new System.Drawing.Size(95, 27);
            this.txtDataRecebimento.TabIndex = 11;
            this.txtDataRecebimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataRecebimento.Texts = "  /  /";
            this.txtDataRecebimento.UnderlinedStyle = false;
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
            this.txtDataCancelamento.Location = new System.Drawing.Point(257, 338);
            this.txtDataCancelamento.Mask = "00/00/0000";
            this.txtDataCancelamento.MaxLength = 32767;
            this.txtDataCancelamento.Multiline = false;
            this.txtDataCancelamento.Name = "txtDataCancelamento";
            this.txtDataCancelamento.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDataCancelamento.PasswordChar = false;
            this.txtDataCancelamento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDataCancelamento.PlaceholderText = "";
            this.txtDataCancelamento.Size = new System.Drawing.Size(95, 27);
            this.txtDataCancelamento.TabIndex = 13;
            this.txtDataCancelamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataCancelamento.Texts = "  /  /";
            this.txtDataCancelamento.UnderlinedStyle = false;
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
            this.txtObservacao.Location = new System.Drawing.Point(23, 400);
            this.txtObservacao.MaxLength = 200;
            this.txtObservacao.Multiline = false;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtObservacao.PasswordChar = false;
            this.txtObservacao.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtObservacao.PlaceholderText = "";
            this.txtObservacao.Size = new System.Drawing.Size(531, 28);
            this.txtObservacao.TabIndex = 15;
            this.txtObservacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtObservacao.Texts = "";
            this.txtObservacao.UnderlinedStyle = false;
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
            this.btnCancelar.Location = new System.Drawing.Point(230, 458);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(70, 31);
            this.btnCancelar.TabIndex = 108;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnReceber
            // 
            this.btnReceber.BackColor = System.Drawing.Color.GhostWhite;
            this.btnReceber.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnReceber.BorderColor = System.Drawing.Color.Green;
            this.btnReceber.BorderRadius = 8;
            this.btnReceber.BorderSize = 1;
            this.btnReceber.FlatAppearance.BorderSize = 0;
            this.btnReceber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceber.ForeColor = System.Drawing.Color.Green;
            this.btnReceber.Location = new System.Drawing.Point(306, 458);
            this.btnReceber.Name = "btnReceber";
            this.btnReceber.Size = new System.Drawing.Size(70, 31);
            this.btnReceber.TabIndex = 107;
            this.btnReceber.Text = "Receber";
            this.btnReceber.TextColor = System.Drawing.Color.Green;
            this.btnReceber.UseVisualStyleBackColor = false;
            this.btnReceber.Click += new System.EventHandler(this.btnReceber_Click);
            // 
            // CadastroContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(577, 506);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnReceber);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.txtTotalReceber);
            this.Controls.Add(this.txtValorRecebido);
            this.Controls.Add(this.txtDataRecebimento);
            this.Controls.Add(this.txtDataCancelamento);
            this.Controls.Add(this.txtMulta);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtJuros);
            this.Controls.Add(this.txtDataVencimento);
            this.Controls.Add(this.txtValorParcela);
            this.Controls.Add(this.txtParcelas);
            this.Controls.Add(this.txtAluno);
            this.Controls.Add(this.btnPesquisarAluno);
            this.Controls.Add(this.txtCodAluno);
            this.Controls.Add(this.txtFormaPag);
            this.Controls.Add(this.btnPesquisarFormaPag);
            this.Controls.Add(this.txtCodFormaPag);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtDataEmissao);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblDataEmissao);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.lblTotalReceber);
            this.Controls.Add(this.lblDataCancelamento);
            this.Controls.Add(this.lblValorRecebido);
            this.Controls.Add(this.lblDataRecebimento);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.lblMulta);
            this.Controls.Add(this.lblJuros);
            this.Controls.Add(this.lblDataVencimento);
            this.Controls.Add(this.lblValorParcela);
            this.Controls.Add(this.lblParcelas);
            this.Controls.Add(this.lblFormaPagamento);
            this.Controls.Add(this.lblCodFormPag);
            this.Controls.Add(this.lblAluno);
            this.Controls.Add(this.lblCodAluno);
            this.Name = "CadastroContasReceber";
            this.Text = "Cadastro Contas a Receber";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroContasReceber_FormClosed);
            this.Load += new System.EventHandler(this.CadastroContasReceber_Load);
            this.Controls.SetChildIndex(this.lblUsuarioUltAlt, 0);
            this.Controls.SetChildIndex(this.txtUsuarioUltAlt, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.gbStatus, 0);
            this.Controls.SetChildIndex(this.lblCodAluno, 0);
            this.Controls.SetChildIndex(this.lblAluno, 0);
            this.Controls.SetChildIndex(this.lblCodFormPag, 0);
            this.Controls.SetChildIndex(this.lblFormaPagamento, 0);
            this.Controls.SetChildIndex(this.lblParcelas, 0);
            this.Controls.SetChildIndex(this.lblValorParcela, 0);
            this.Controls.SetChildIndex(this.lblDataVencimento, 0);
            this.Controls.SetChildIndex(this.lblJuros, 0);
            this.Controls.SetChildIndex(this.lblMulta, 0);
            this.Controls.SetChildIndex(this.lblDesconto, 0);
            this.Controls.SetChildIndex(this.lblDataRecebimento, 0);
            this.Controls.SetChildIndex(this.lblValorRecebido, 0);
            this.Controls.SetChildIndex(this.lblDataCancelamento, 0);
            this.Controls.SetChildIndex(this.lblTotalReceber, 0);
            this.Controls.SetChildIndex(this.lblObservacao, 0);
            this.Controls.SetChildIndex(this.lblDataEmissao, 0);
            this.Controls.SetChildIndex(this.lblNumero, 0);
            this.Controls.SetChildIndex(this.txtDataEmissao, 0);
            this.Controls.SetChildIndex(this.txtNumero, 0);
            this.Controls.SetChildIndex(this.txtCodFormaPag, 0);
            this.Controls.SetChildIndex(this.btnPesquisarFormaPag, 0);
            this.Controls.SetChildIndex(this.txtFormaPag, 0);
            this.Controls.SetChildIndex(this.txtCodAluno, 0);
            this.Controls.SetChildIndex(this.btnPesquisarAluno, 0);
            this.Controls.SetChildIndex(this.txtAluno, 0);
            this.Controls.SetChildIndex(this.txtParcelas, 0);
            this.Controls.SetChildIndex(this.txtValorParcela, 0);
            this.Controls.SetChildIndex(this.txtDataVencimento, 0);
            this.Controls.SetChildIndex(this.txtJuros, 0);
            this.Controls.SetChildIndex(this.txtDesconto, 0);
            this.Controls.SetChildIndex(this.txtMulta, 0);
            this.Controls.SetChildIndex(this.txtDataCancelamento, 0);
            this.Controls.SetChildIndex(this.txtDataRecebimento, 0);
            this.Controls.SetChildIndex(this.txtValorRecebido, 0);
            this.Controls.SetChildIndex(this.txtTotalReceber, 0);
            this.Controls.SetChildIndex(this.txtObservacao, 0);
            this.Controls.SetChildIndex(this.btnReceber, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCodAluno;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.Label lblFormaPagamento;
        private System.Windows.Forms.Label lblCodFormPag;
        private System.Windows.Forms.Label lblParcelas;
        private System.Windows.Forms.Label lblValorParcela;
        private System.Windows.Forms.Label lblDataVencimento;
        private System.Windows.Forms.Label lblJuros;
        private System.Windows.Forms.Label lblMulta;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblDataRecebimento;
        private System.Windows.Forms.Label lblValorRecebido;
        private System.Windows.Forms.Label lblDataCancelamento;
        private System.Windows.Forms.Label lblTotalReceber;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Label lblDataEmissao;
        private System.Windows.Forms.Label lblNumero;
        private YControls.YTextBox txtNumero;
        private YControls.YMaskedTextBox txtDataEmissao;
        private YControls.YTextBox txtFormaPag;
        protected YControls.YButton btnPesquisarFormaPag;
        private YControls.YTextBox txtCodFormaPag;
        private YControls.YTextBox txtAluno;
        protected YControls.YButton btnPesquisarAluno;
        private YControls.YTextBox txtCodAluno;
        private YControls.YMaskedTextBox txtDataVencimento;
        private YControls.YTextBox txtValorParcela;
        private YControls.YTextBox txtParcelas;
        private YControls.YTextBox txtMulta;
        private YControls.YTextBox txtDesconto;
        private YControls.YTextBox txtJuros;
        private YControls.YTextBox txtTotalReceber;
        private YControls.YTextBox txtValorRecebido;
        private YControls.YMaskedTextBox txtDataRecebimento;
        private YControls.YMaskedTextBox txtDataCancelamento;
        private YControls.YTextBox txtObservacao;
        protected YControls.YButton btnCancelar;
        protected YControls.YButton btnReceber;
    }
}
