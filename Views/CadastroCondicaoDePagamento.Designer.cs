namespace Pilates.Views
{
    partial class CadastroCondicaoDePagamento
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
            this.lblCondicaoPagamento = new System.Windows.Forms.Label();
            this.lblJuros = new System.Windows.Forms.Label();
            this.lblMulta = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblNumeroParcelas = new System.Windows.Forms.Label();
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.lblPorcentagemTotal = new System.Windows.Forms.Label();
            this.lblCodigoPagamento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewParcelas = new System.Windows.Forms.DataGridView();
            this.numeroParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CódFormaPag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCondicaoPagamento = new Pilates.YControls.YTextBox();
            this.txtJuros = new Pilates.YControls.YTextBox();
            this.txtDesconto = new Pilates.YControls.YTextBox();
            this.txtMulta = new Pilates.YControls.YTextBox();
            this.txtNumParcelas = new Pilates.YControls.YTextBox();
            this.txtPorcentagem = new Pilates.YControls.YTextBox();
            this.txtPorcentagemTotal = new Pilates.YControls.YTextBox();
            this.txtCodigoPagamento = new Pilates.YControls.YTextBox();
            this.btnPesquisarPagamento = new Pilates.YControls.YButton();
            this.txtFormaPagamento = new Pilates.YControls.YTextBox();
            this.btnAdicionar = new Pilates.YControls.YButton();
            this.btnExcluirParcela = new Pilates.YControls.YButton();
            this.gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(118, 445);
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(20, 444);
            // 
            // gbStatus
            // 
            this.gbStatus.Location = new System.Drawing.Point(508, 12);
            this.gbStatus.Size = new System.Drawing.Size(165, 51);
            // 
            // rbInativo
            // 
            this.rbInativo.Location = new System.Drawing.Point(90, 22);
            // 
            // rbAtivo
            // 
            this.rbAtivo.Location = new System.Drawing.Point(19, 22);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(501, 457);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Texts = "0";
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(23, 461);
            this.txtDataCadastro.Texts = "25/10/2024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(121, 461);
            this.txtDataUltAlt.Texts = "25/10/2024";
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(590, 457);
            // 
            // txtUsuarioUltAlt
            // 
            this.txtUsuarioUltAlt.Location = new System.Drawing.Point(219, 461);
            // 
            // lblUsuarioUltAlt
            // 
            this.lblUsuarioUltAlt.Location = new System.Drawing.Point(216, 445);
            // 
            // lblCondicaoPagamento
            // 
            this.lblCondicaoPagamento.AutoSize = true;
            this.lblCondicaoPagamento.Location = new System.Drawing.Point(20, 86);
            this.lblCondicaoPagamento.Name = "lblCondicaoPagamento";
            this.lblCondicaoPagamento.Size = new System.Drawing.Size(131, 13);
            this.lblCondicaoPagamento.TabIndex = 9;
            this.lblCondicaoPagamento.Text = "Condição de Pagamento:*";
            // 
            // lblJuros
            // 
            this.lblJuros.AutoSize = true;
            this.lblJuros.Location = new System.Drawing.Point(371, 86);
            this.lblJuros.Name = "lblJuros";
            this.lblJuros.Size = new System.Drawing.Size(43, 13);
            this.lblJuros.TabIndex = 11;
            this.lblJuros.Text = "% Juros";
            // 
            // lblMulta
            // 
            this.lblMulta.AutoSize = true;
            this.lblMulta.Location = new System.Drawing.Point(477, 85);
            this.lblMulta.Name = "lblMulta";
            this.lblMulta.Size = new System.Drawing.Size(44, 13);
            this.lblMulta.TabIndex = 14;
            this.lblMulta.Text = "% Multa";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(583, 85);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(64, 13);
            this.lblDesconto.TabIndex = 15;
            this.lblDesconto.Text = "% Desconto";
            // 
            // lblNumeroParcelas
            // 
            this.lblNumeroParcelas.AutoSize = true;
            this.lblNumeroParcelas.Location = new System.Drawing.Point(20, 155);
            this.lblNumeroParcelas.Name = "lblNumeroParcelas";
            this.lblNumeroParcelas.Size = new System.Drawing.Size(90, 13);
            this.lblNumeroParcelas.TabIndex = 17;
            this.lblNumeroParcelas.Text = "Numero Parcela *";
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.Location = new System.Drawing.Point(155, 155);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(15, 13);
            this.lblPorcentagem.TabIndex = 19;
            this.lblPorcentagem.Text = "%";
            // 
            // lblPorcentagemTotal
            // 
            this.lblPorcentagemTotal.AutoSize = true;
            this.lblPorcentagemTotal.Location = new System.Drawing.Point(211, 155);
            this.lblPorcentagemTotal.Name = "lblPorcentagemTotal";
            this.lblPorcentagemTotal.Size = new System.Drawing.Size(42, 13);
            this.lblPorcentagemTotal.TabIndex = 21;
            this.lblPorcentagemTotal.Text = "% Total";
            // 
            // lblCodigoPagamento
            // 
            this.lblCodigoPagamento.AutoSize = true;
            this.lblCodigoPagamento.Location = new System.Drawing.Point(299, 155);
            this.lblCodigoPagamento.Name = "lblCodigoPagamento";
            this.lblCodigoPagamento.Size = new System.Drawing.Size(47, 13);
            this.lblCodigoPagamento.TabIndex = 23;
            this.lblCodigoPagamento.Text = "Código *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Forma de Pagamento:";
            // 
            // dataGridViewParcelas
            // 
            this.dataGridViewParcelas.AllowUserToAddRows = false;
            this.dataGridViewParcelas.AllowUserToDeleteRows = false;
            this.dataGridViewParcelas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dataGridViewParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroParcela,
            this.porcentagem,
            this.CódFormaPag,
            this.formaPagamento});
            this.dataGridViewParcelas.Location = new System.Drawing.Point(23, 220);
            this.dataGridViewParcelas.Name = "dataGridViewParcelas";
            this.dataGridViewParcelas.Size = new System.Drawing.Size(650, 166);
            this.dataGridViewParcelas.TabIndex = 29;
            // 
            // numeroParcela
            // 
            this.numeroParcela.HeaderText = "Num. Parcela";
            this.numeroParcela.Name = "numeroParcela";
            // 
            // porcentagem
            // 
            this.porcentagem.HeaderText = "%";
            this.porcentagem.Name = "porcentagem";
            // 
            // CódFormaPag
            // 
            this.CódFormaPag.HeaderText = "Cód. Forma Pagamento";
            this.CódFormaPag.Name = "CódFormaPag";
            // 
            // formaPagamento
            // 
            this.formaPagamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.formaPagamento.HeaderText = "Forma de Pagamento";
            this.formaPagamento.Name = "formaPagamento";
            // 
            // txtCondicaoPagamento
            // 
            this.txtCondicaoPagamento.BackColor = System.Drawing.SystemColors.Window;
            this.txtCondicaoPagamento.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCondicaoPagamento.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtCondicaoPagamento.BorderRadius = 8;
            this.txtCondicaoPagamento.BorderSize = 1;
            this.txtCondicaoPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCondicaoPagamento.DisabledBackColor = System.Drawing.Color.White;
            this.txtCondicaoPagamento.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCondicaoPagamento.DisabledForeColor = System.Drawing.Color.White;
            this.txtCondicaoPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCondicaoPagamento.Location = new System.Drawing.Point(23, 102);
            this.txtCondicaoPagamento.MaxLength = 50;
            this.txtCondicaoPagamento.Multiline = false;
            this.txtCondicaoPagamento.Name = "txtCondicaoPagamento";
            this.txtCondicaoPagamento.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCondicaoPagamento.PasswordChar = false;
            this.txtCondicaoPagamento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCondicaoPagamento.PlaceholderText = "";
            this.txtCondicaoPagamento.Size = new System.Drawing.Size(332, 28);
            this.txtCondicaoPagamento.TabIndex = 1;
            this.txtCondicaoPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCondicaoPagamento.Texts = "";
            this.txtCondicaoPagamento.UnderlinedStyle = false;
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
            this.txtJuros.Location = new System.Drawing.Point(374, 102);
            this.txtJuros.MaxLength = 13;
            this.txtJuros.Multiline = false;
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtJuros.PasswordChar = false;
            this.txtJuros.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtJuros.PlaceholderText = "";
            this.txtJuros.Size = new System.Drawing.Size(87, 28);
            this.txtJuros.TabIndex = 2;
            this.txtJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtJuros.Texts = "";
            this.txtJuros.UnderlinedStyle = false;
            this.txtJuros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJuros_KeyPress);
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
            this.txtDesconto.Location = new System.Drawing.Point(586, 102);
            this.txtDesconto.MaxLength = 13;
            this.txtDesconto.Multiline = false;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDesconto.PasswordChar = false;
            this.txtDesconto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDesconto.PlaceholderText = "";
            this.txtDesconto.Size = new System.Drawing.Size(87, 28);
            this.txtDesconto.TabIndex = 4;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDesconto.Texts = "";
            this.txtDesconto.UnderlinedStyle = false;
            this.txtDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJuros_KeyPress);
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
            this.txtMulta.Location = new System.Drawing.Point(480, 102);
            this.txtMulta.MaxLength = 13;
            this.txtMulta.Multiline = false;
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtMulta.PasswordChar = false;
            this.txtMulta.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMulta.PlaceholderText = "";
            this.txtMulta.Size = new System.Drawing.Size(87, 28);
            this.txtMulta.TabIndex = 3;
            this.txtMulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMulta.Texts = "";
            this.txtMulta.UnderlinedStyle = false;
            this.txtMulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJuros_KeyPress);
            // 
            // txtNumParcelas
            // 
            this.txtNumParcelas.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumParcelas.BorderColor = System.Drawing.Color.DarkGray;
            this.txtNumParcelas.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtNumParcelas.BorderRadius = 8;
            this.txtNumParcelas.BorderSize = 1;
            this.txtNumParcelas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumParcelas.DisabledBackColor = System.Drawing.Color.White;
            this.txtNumParcelas.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtNumParcelas.DisabledForeColor = System.Drawing.Color.White;
            this.txtNumParcelas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtNumParcelas.Location = new System.Drawing.Point(23, 171);
            this.txtNumParcelas.MaxLength = 13;
            this.txtNumParcelas.Multiline = false;
            this.txtNumParcelas.Name = "txtNumParcelas";
            this.txtNumParcelas.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtNumParcelas.PasswordChar = false;
            this.txtNumParcelas.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumParcelas.PlaceholderText = "";
            this.txtNumParcelas.Size = new System.Drawing.Size(87, 28);
            this.txtNumParcelas.TabIndex = 5;
            this.txtNumParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumParcelas.Texts = "";
            this.txtNumParcelas.UnderlinedStyle = false;
            this.txtNumParcelas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumParcelas_KeyPress);
            this.txtNumParcelas.Leave += new System.EventHandler(this.txtNumParcelas_Leave);
            // 
            // txtPorcentagem
            // 
            this.txtPorcentagem.BackColor = System.Drawing.SystemColors.Window;
            this.txtPorcentagem.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPorcentagem.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtPorcentagem.BorderRadius = 8;
            this.txtPorcentagem.BorderSize = 1;
            this.txtPorcentagem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPorcentagem.DisabledBackColor = System.Drawing.Color.White;
            this.txtPorcentagem.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtPorcentagem.DisabledForeColor = System.Drawing.Color.White;
            this.txtPorcentagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtPorcentagem.Location = new System.Drawing.Point(126, 171);
            this.txtPorcentagem.MaxLength = 13;
            this.txtPorcentagem.Multiline = false;
            this.txtPorcentagem.Name = "txtPorcentagem";
            this.txtPorcentagem.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtPorcentagem.PasswordChar = false;
            this.txtPorcentagem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPorcentagem.PlaceholderText = "";
            this.txtPorcentagem.Size = new System.Drawing.Size(70, 28);
            this.txtPorcentagem.TabIndex = 6;
            this.txtPorcentagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPorcentagem.Texts = "";
            this.txtPorcentagem.UnderlinedStyle = false;
            this.txtPorcentagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentagem_KeyPress);
            this.txtPorcentagem.Leave += new System.EventHandler(this.txtPorcentagem_Leave);
            // 
            // txtPorcentagemTotal
            // 
            this.txtPorcentagemTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtPorcentagemTotal.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPorcentagemTotal.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtPorcentagemTotal.BorderRadius = 8;
            this.txtPorcentagemTotal.BorderSize = 1;
            this.txtPorcentagemTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPorcentagemTotal.DisabledBackColor = System.Drawing.Color.White;
            this.txtPorcentagemTotal.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtPorcentagemTotal.DisabledForeColor = System.Drawing.Color.White;
            this.txtPorcentagemTotal.Enabled = false;
            this.txtPorcentagemTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtPorcentagemTotal.Location = new System.Drawing.Point(214, 171);
            this.txtPorcentagemTotal.MaxLength = 13;
            this.txtPorcentagemTotal.Multiline = false;
            this.txtPorcentagemTotal.Name = "txtPorcentagemTotal";
            this.txtPorcentagemTotal.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtPorcentagemTotal.PasswordChar = false;
            this.txtPorcentagemTotal.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPorcentagemTotal.PlaceholderText = "";
            this.txtPorcentagemTotal.Size = new System.Drawing.Size(70, 28);
            this.txtPorcentagemTotal.TabIndex = 7;
            this.txtPorcentagemTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPorcentagemTotal.Texts = "";
            this.txtPorcentagemTotal.UnderlinedStyle = false;
            // 
            // txtCodigoPagamento
            // 
            this.txtCodigoPagamento.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigoPagamento.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCodigoPagamento.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtCodigoPagamento.BorderRadius = 8;
            this.txtCodigoPagamento.BorderSize = 1;
            this.txtCodigoPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoPagamento.DisabledBackColor = System.Drawing.Color.White;
            this.txtCodigoPagamento.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCodigoPagamento.DisabledForeColor = System.Drawing.Color.White;
            this.txtCodigoPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCodigoPagamento.Location = new System.Drawing.Point(302, 171);
            this.txtCodigoPagamento.MaxLength = 5;
            this.txtCodigoPagamento.Multiline = false;
            this.txtCodigoPagamento.Name = "txtCodigoPagamento";
            this.txtCodigoPagamento.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodigoPagamento.PasswordChar = false;
            this.txtCodigoPagamento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodigoPagamento.PlaceholderText = "";
            this.txtCodigoPagamento.Size = new System.Drawing.Size(70, 28);
            this.txtCodigoPagamento.TabIndex = 8;
            this.txtCodigoPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigoPagamento.Texts = "";
            this.txtCodigoPagamento.UnderlinedStyle = false;
            this.txtCodigoPagamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoPagamento_KeyPress);
            this.txtCodigoPagamento.Leave += new System.EventHandler(this.txtCodigoPagamento_Leave);
            // 
            // btnPesquisarPagamento
            // 
            this.btnPesquisarPagamento.BackColor = System.Drawing.Color.GhostWhite;
            this.btnPesquisarPagamento.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnPesquisarPagamento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btnPesquisarPagamento.BorderRadius = 8;
            this.btnPesquisarPagamento.BorderSize = 1;
            this.btnPesquisarPagamento.FlatAppearance.BorderSize = 0;
            this.btnPesquisarPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarPagamento.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnPesquisarPagamento.Location = new System.Drawing.Point(378, 170);
            this.btnPesquisarPagamento.Name = "btnPesquisarPagamento";
            this.btnPesquisarPagamento.Size = new System.Drawing.Size(61, 31);
            this.btnPesquisarPagamento.TabIndex = 40;
            this.btnPesquisarPagamento.Text = "Buscar";
            this.btnPesquisarPagamento.TextColor = System.Drawing.Color.DarkViolet;
            this.btnPesquisarPagamento.UseVisualStyleBackColor = false;
            this.btnPesquisarPagamento.Click += new System.EventHandler(this.btnPesquisarPagamento_Click);
            // 
            // txtFormaPagamento
            // 
            this.txtFormaPagamento.BackColor = System.Drawing.SystemColors.Window;
            this.txtFormaPagamento.BorderColor = System.Drawing.Color.DarkGray;
            this.txtFormaPagamento.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtFormaPagamento.BorderRadius = 8;
            this.txtFormaPagamento.BorderSize = 1;
            this.txtFormaPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFormaPagamento.DisabledBackColor = System.Drawing.Color.White;
            this.txtFormaPagamento.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtFormaPagamento.DisabledForeColor = System.Drawing.Color.White;
            this.txtFormaPagamento.Enabled = false;
            this.txtFormaPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtFormaPagamento.Location = new System.Drawing.Point(447, 172);
            this.txtFormaPagamento.MaxLength = 32767;
            this.txtFormaPagamento.Multiline = false;
            this.txtFormaPagamento.Name = "txtFormaPagamento";
            this.txtFormaPagamento.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtFormaPagamento.PasswordChar = false;
            this.txtFormaPagamento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFormaPagamento.PlaceholderText = "";
            this.txtFormaPagamento.Size = new System.Drawing.Size(154, 28);
            this.txtFormaPagamento.TabIndex = 39;
            this.txtFormaPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFormaPagamento.Texts = "";
            this.txtFormaPagamento.UnderlinedStyle = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.GhostWhite;
            this.btnAdicionar.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnAdicionar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btnAdicionar.BorderRadius = 8;
            this.btnAdicionar.BorderSize = 1;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnAdicionar.Location = new System.Drawing.Point(607, 171);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(66, 31);
            this.btnAdicionar.TabIndex = 41;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextColor = System.Drawing.Color.DarkViolet;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnExcluirParcela
            // 
            this.btnExcluirParcela.BackColor = System.Drawing.Color.GhostWhite;
            this.btnExcluirParcela.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnExcluirParcela.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btnExcluirParcela.BorderRadius = 8;
            this.btnExcluirParcela.BorderSize = 1;
            this.btnExcluirParcela.FlatAppearance.BorderSize = 0;
            this.btnExcluirParcela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirParcela.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnExcluirParcela.Location = new System.Drawing.Point(574, 392);
            this.btnExcluirParcela.Name = "btnExcluirParcela";
            this.btnExcluirParcela.Size = new System.Drawing.Size(99, 31);
            this.btnExcluirParcela.TabIndex = 42;
            this.btnExcluirParcela.Text = "Excluir Parcela";
            this.btnExcluirParcela.TextColor = System.Drawing.Color.DarkViolet;
            this.btnExcluirParcela.UseVisualStyleBackColor = false;
            this.btnExcluirParcela.Click += new System.EventHandler(this.btnExcluirParcela_Click);
            // 
            // CadastroCondicaoDePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(698, 497);
            this.Controls.Add(this.btnExcluirParcela);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnPesquisarPagamento);
            this.Controls.Add(this.txtFormaPagamento);
            this.Controls.Add(this.txtCodigoPagamento);
            this.Controls.Add(this.txtPorcentagemTotal);
            this.Controls.Add(this.txtPorcentagem);
            this.Controls.Add(this.txtNumParcelas);
            this.Controls.Add(this.txtMulta);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtJuros);
            this.Controls.Add(this.txtCondicaoPagamento);
            this.Controls.Add(this.dataGridViewParcelas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCodigoPagamento);
            this.Controls.Add(this.lblPorcentagemTotal);
            this.Controls.Add(this.lblPorcentagem);
            this.Controls.Add(this.lblNumeroParcelas);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.lblMulta);
            this.Controls.Add(this.lblJuros);
            this.Controls.Add(this.lblCondicaoPagamento);
            this.Name = "CadastroCondicaoDePagamento";
            this.Text = "Cadastro de Condição de Pagamento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroCondicaoDePagamento_FormClosed);
            this.Load += new System.EventHandler(this.CadastroCondicaoDePagamento_Load);
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
            this.Controls.SetChildIndex(this.lblCondicaoPagamento, 0);
            this.Controls.SetChildIndex(this.lblJuros, 0);
            this.Controls.SetChildIndex(this.lblMulta, 0);
            this.Controls.SetChildIndex(this.lblDesconto, 0);
            this.Controls.SetChildIndex(this.lblNumeroParcelas, 0);
            this.Controls.SetChildIndex(this.lblPorcentagem, 0);
            this.Controls.SetChildIndex(this.lblPorcentagemTotal, 0);
            this.Controls.SetChildIndex(this.lblCodigoPagamento, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dataGridViewParcelas, 0);
            this.Controls.SetChildIndex(this.txtCondicaoPagamento, 0);
            this.Controls.SetChildIndex(this.txtJuros, 0);
            this.Controls.SetChildIndex(this.txtDesconto, 0);
            this.Controls.SetChildIndex(this.txtMulta, 0);
            this.Controls.SetChildIndex(this.txtNumParcelas, 0);
            this.Controls.SetChildIndex(this.txtPorcentagem, 0);
            this.Controls.SetChildIndex(this.txtPorcentagemTotal, 0);
            this.Controls.SetChildIndex(this.txtCodigoPagamento, 0);
            this.Controls.SetChildIndex(this.txtFormaPagamento, 0);
            this.Controls.SetChildIndex(this.btnPesquisarPagamento, 0);
            this.Controls.SetChildIndex(this.btnAdicionar, 0);
            this.Controls.SetChildIndex(this.btnExcluirParcela, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCondicaoPagamento;
        private System.Windows.Forms.Label lblJuros;
        private System.Windows.Forms.Label lblMulta;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblNumeroParcelas;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.Label lblPorcentagemTotal;
        private System.Windows.Forms.Label lblCodigoPagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CódFormaPag;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagamento;
        private YControls.YTextBox txtCondicaoPagamento;
        private YControls.YTextBox txtJuros;
        private YControls.YTextBox txtDesconto;
        private YControls.YTextBox txtMulta;
        private YControls.YTextBox txtNumParcelas;
        private YControls.YTextBox txtPorcentagem;
        private YControls.YTextBox txtPorcentagemTotal;
        private YControls.YTextBox txtCodigoPagamento;
        protected YControls.YButton btnPesquisarPagamento;
        private YControls.YTextBox txtFormaPagamento;
        protected YControls.YButton btnAdicionar;
        protected YControls.YButton btnExcluirParcela;
    }
}
