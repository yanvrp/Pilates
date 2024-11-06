namespace Pilates.Views
{
    partial class CadastroFornecedor
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
            this.lblCPF_CNPJ = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblApelido = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNomeContato = new System.Windows.Forms.Label();
            this.gpPessoa = new System.Windows.Forms.GroupBox();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.lblRG_IE = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gpPagamento = new System.Windows.Forms.GroupBox();
            this.txtCondPag = new Pilates.YControls.YTextBox();
            this.txtCodCondPag = new Pilates.YControls.YTextBox();
            this.btnBuscarCond = new Pilates.YControls.YButton();
            this.lblCondPag = new System.Windows.Forms.Label();
            this.lblCodCondPag = new System.Windows.Forms.Label();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.txtPais = new Pilates.YControls.YTextBox();
            this.txtUF = new Pilates.YControls.YTextBox();
            this.txtCidade = new Pilates.YControls.YTextBox();
            this.txtCodCidade = new Pilates.YControls.YTextBox();
            this.txtBairro = new Pilates.YControls.YTextBox();
            this.txtComplemento = new Pilates.YControls.YTextBox();
            this.txtNumero = new Pilates.YControls.YTextBox();
            this.txtEndereco = new Pilates.YControls.YTextBox();
            this.txtCEP = new Pilates.YControls.YMaskedTextBox();
            this.btnBuscarCidade = new Pilates.YControls.YButton();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblCodCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtFornecedor = new Pilates.YControls.YTextBox();
            this.txtApelido = new Pilates.YControls.YTextBox();
            this.txtEmail = new Pilates.YControls.YTextBox();
            this.txtCelular = new Pilates.YControls.YTextBox();
            this.txtTelefone = new Pilates.YControls.YTextBox();
            this.txtNomeContato = new Pilates.YControls.YTextBox();
            this.txtCPF_CNPJ = new Pilates.YControls.YMaskedTextBox();
            this.txtRG_IE = new Pilates.YControls.YTextBox();
            this.txtDataNasc = new Pilates.YControls.YMaskedTextBox();
            this.gbStatus.SuspendLayout();
            this.gpPessoa.SuspendLayout();
            this.gpPagamento.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(124, 506);
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(20, 505);
            // 
            // gbStatus
            // 
            this.gbStatus.Location = new System.Drawing.Point(716, 12);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(709, 521);
            this.btnSalvar.TabIndex = 21;
            // 
            // txtCodigo
            // 
            this.txtCodigo.TabIndex = 60;
            this.txtCodigo.Texts = "0";
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(23, 521);
            this.txtDataCadastro.Texts = "25/10/2024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(127, 521);
            this.txtDataUltAlt.Texts = "25/10/2024";
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(798, 521);
            this.btnSair.TabIndex = 22;
            // 
            // lblCPF_CNPJ
            // 
            this.lblCPF_CNPJ.AutoSize = true;
            this.lblCPF_CNPJ.Location = new System.Drawing.Point(20, 401);
            this.lblCPF_CNPJ.Name = "lblCPF_CNPJ";
            this.lblCPF_CNPJ.Size = new System.Drawing.Size(34, 13);
            this.lblCPF_CNPJ.TabIndex = 32;
            this.lblCPF_CNPJ.Text = "CPF:*";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 157);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 13);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "Email:*";
            // 
            // txtSexo
            // 
            this.txtSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSexo.FormattingEnabled = true;
            this.txtSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMININO",
            "OUTROS"});
            this.txtSexo.Location = new System.Drawing.Point(618, 112);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(121, 21);
            this.txtSexo.TabIndex = 3;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(615, 93);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(38, 13);
            this.lblSexo.TabIndex = 30;
            this.lblSexo.Text = "Sexo:*";
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Location = new System.Drawing.Point(318, 91);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(45, 13);
            this.lblApelido.TabIndex = 29;
            this.lblApelido.Text = "Apelido:";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(20, 91);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(68, 13);
            this.lblFornecedor.TabIndex = 28;
            this.lblFornecedor.Text = "Fornecedor:*";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(337, 401);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(68, 13);
            this.lblDataNasc.TabIndex = 36;
            this.lblDataNasc.Text = "Data Nasc.:*";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(467, 157);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(46, 13);
            this.lblCelular.TabIndex = 35;
            this.lblCelular.Text = "Celular:*";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(318, 157);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 40;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblNomeContato
            // 
            this.lblNomeContato.AutoSize = true;
            this.lblNomeContato.Location = new System.Drawing.Point(618, 157);
            this.lblNomeContato.Name = "lblNomeContato";
            this.lblNomeContato.Size = new System.Drawing.Size(96, 13);
            this.lblNomeContato.TabIndex = 42;
            this.lblNomeContato.Text = "Nome do contato:*";
            this.lblNomeContato.Visible = false;
            // 
            // gpPessoa
            // 
            this.gpPessoa.Controls.Add(this.rbJuridica);
            this.gpPessoa.Controls.Add(this.rbFisica);
            this.gpPessoa.Location = new System.Drawing.Point(127, 19);
            this.gpPessoa.Name = "gpPessoa";
            this.gpPessoa.Size = new System.Drawing.Size(133, 50);
            this.gpPessoa.TabIndex = 43;
            this.gpPessoa.TabStop = false;
            this.gpPessoa.Text = "Pessoa";
            // 
            // rbJuridica
            // 
            this.rbJuridica.AutoSize = true;
            this.rbJuridica.Location = new System.Drawing.Point(66, 19);
            this.rbJuridica.Name = "rbJuridica";
            this.rbJuridica.Size = new System.Drawing.Size(63, 17);
            this.rbJuridica.TabIndex = 1;
            this.rbJuridica.Text = "Jurídica";
            this.rbJuridica.UseVisualStyleBackColor = true;
            this.rbJuridica.CheckedChanged += new System.EventHandler(this.rbJuridica_CheckedChanged);
            // 
            // rbFisica
            // 
            this.rbFisica.AutoSize = true;
            this.rbFisica.Checked = true;
            this.rbFisica.Location = new System.Drawing.Point(6, 19);
            this.rbFisica.Name = "rbFisica";
            this.rbFisica.Size = new System.Drawing.Size(54, 17);
            this.rbFisica.TabIndex = 0;
            this.rbFisica.TabStop = true;
            this.rbFisica.Text = "Física";
            this.rbFisica.UseVisualStyleBackColor = true;
            this.rbFisica.CheckedChanged += new System.EventHandler(this.rbFisica_CheckedChanged);
            // 
            // lblRG_IE
            // 
            this.lblRG_IE.AutoSize = true;
            this.lblRG_IE.Location = new System.Drawing.Point(189, 402);
            this.lblRG_IE.Name = "lblRG_IE";
            this.lblRG_IE.Size = new System.Drawing.Size(26, 13);
            this.lblRG_IE.TabIndex = 44;
            this.lblRG_IE.Text = "RG:";
            // 
            // gpPagamento
            // 
            this.gpPagamento.Controls.Add(this.txtCondPag);
            this.gpPagamento.Controls.Add(this.txtCodCondPag);
            this.gpPagamento.Controls.Add(this.btnBuscarCond);
            this.gpPagamento.Controls.Add(this.lblCondPag);
            this.gpPagamento.Controls.Add(this.lblCodCondPag);
            this.gpPagamento.Location = new System.Drawing.Point(470, 401);
            this.gpPagamento.Name = "gpPagamento";
            this.gpPagamento.Size = new System.Drawing.Size(411, 93);
            this.gpPagamento.TabIndex = 17;
            this.gpPagamento.TabStop = false;
            this.gpPagamento.Text = "Pagamento";
            // 
            // txtCondPag
            // 
            this.txtCondPag.BackColor = System.Drawing.SystemColors.Window;
            this.txtCondPag.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCondPag.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtCondPag.BorderRadius = 8;
            this.txtCondPag.BorderSize = 1;
            this.txtCondPag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCondPag.DisabledBackColor = System.Drawing.Color.White;
            this.txtCondPag.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCondPag.DisabledForeColor = System.Drawing.Color.White;
            this.txtCondPag.Enabled = false;
            this.txtCondPag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCondPag.Location = new System.Drawing.Point(171, 43);
            this.txtCondPag.MaxLength = 32767;
            this.txtCondPag.Multiline = false;
            this.txtCondPag.Name = "txtCondPag";
            this.txtCondPag.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCondPag.PasswordChar = false;
            this.txtCondPag.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCondPag.PlaceholderText = "";
            this.txtCondPag.Size = new System.Drawing.Size(222, 28);
            this.txtCondPag.TabIndex = 54;
            this.txtCondPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCondPag.Texts = "";
            this.txtCondPag.UnderlinedStyle = false;
            // 
            // txtCodCondPag
            // 
            this.txtCodCondPag.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodCondPag.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCodCondPag.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtCodCondPag.BorderRadius = 8;
            this.txtCodCondPag.BorderSize = 1;
            this.txtCodCondPag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodCondPag.DisabledBackColor = System.Drawing.Color.White;
            this.txtCodCondPag.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCodCondPag.DisabledForeColor = System.Drawing.Color.White;
            this.txtCodCondPag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCodCondPag.Location = new System.Drawing.Point(18, 43);
            this.txtCodCondPag.MaxLength = 32767;
            this.txtCodCondPag.Multiline = false;
            this.txtCodCondPag.Name = "txtCodCondPag";
            this.txtCodCondPag.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodCondPag.PasswordChar = false;
            this.txtCodCondPag.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodCondPag.PlaceholderText = "";
            this.txtCodCondPag.Size = new System.Drawing.Size(80, 28);
            this.txtCodCondPag.TabIndex = 19;
            this.txtCodCondPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodCondPag.Texts = "";
            this.txtCodCondPag.UnderlinedStyle = false;
            this.txtCodCondPag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CadastroFornecedor_KeyPress);
            this.txtCodCondPag.Leave += new System.EventHandler(this.txtCodCondPag_Leave);
            // 
            // btnBuscarCond
            // 
            this.btnBuscarCond.BackColor = System.Drawing.Color.GhostWhite;
            this.btnBuscarCond.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnBuscarCond.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btnBuscarCond.BorderRadius = 8;
            this.btnBuscarCond.BorderSize = 1;
            this.btnBuscarCond.FlatAppearance.BorderSize = 0;
            this.btnBuscarCond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCond.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnBuscarCond.Location = new System.Drawing.Point(104, 42);
            this.btnBuscarCond.Name = "btnBuscarCond";
            this.btnBuscarCond.Size = new System.Drawing.Size(61, 31);
            this.btnBuscarCond.TabIndex = 20;
            this.btnBuscarCond.Text = "Buscar";
            this.btnBuscarCond.TextColor = System.Drawing.Color.DarkViolet;
            this.btnBuscarCond.UseVisualStyleBackColor = false;
            this.btnBuscarCond.Click += new System.EventHandler(this.btnBuscarCond_Click);
            // 
            // lblCondPag
            // 
            this.lblCondPag.AutoSize = true;
            this.lblCondPag.Location = new System.Drawing.Point(168, 27);
            this.lblCondPag.Name = "lblCondPag";
            this.lblCondPag.Size = new System.Drawing.Size(127, 13);
            this.lblCondPag.TabIndex = 51;
            this.lblCondPag.Text = "Condição de Pagamento:";
            // 
            // lblCodCondPag
            // 
            this.lblCodCondPag.AutoSize = true;
            this.lblCodCondPag.Location = new System.Drawing.Point(15, 27);
            this.lblCodCondPag.Name = "lblCodCondPag";
            this.lblCodCondPag.Size = new System.Drawing.Size(47, 13);
            this.lblCodCondPag.TabIndex = 49;
            this.lblCodCondPag.Text = "Código:*";
            // 
            // gbEndereco
            // 
            this.gbEndereco.Controls.Add(this.txtPais);
            this.gbEndereco.Controls.Add(this.txtUF);
            this.gbEndereco.Controls.Add(this.txtCidade);
            this.gbEndereco.Controls.Add(this.txtCodCidade);
            this.gbEndereco.Controls.Add(this.txtBairro);
            this.gbEndereco.Controls.Add(this.txtComplemento);
            this.gbEndereco.Controls.Add(this.txtNumero);
            this.gbEndereco.Controls.Add(this.txtEndereco);
            this.gbEndereco.Controls.Add(this.txtCEP);
            this.gbEndereco.Controls.Add(this.btnBuscarCidade);
            this.gbEndereco.Controls.Add(this.lblPais);
            this.gbEndereco.Controls.Add(this.lblUF);
            this.gbEndereco.Controls.Add(this.lblCidade);
            this.gbEndereco.Controls.Add(this.lblCodCidade);
            this.gbEndereco.Controls.Add(this.lblBairro);
            this.gbEndereco.Controls.Add(this.lblComplemento);
            this.gbEndereco.Controls.Add(this.lblNumero);
            this.gbEndereco.Controls.Add(this.lblEndereco);
            this.gbEndereco.Controls.Add(this.lblCEP);
            this.gbEndereco.Location = new System.Drawing.Point(23, 222);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(858, 157);
            this.gbEndereco.TabIndex = 8;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereço";
            this.gbEndereco.Enter += new System.EventHandler(this.gbEndereco_Enter);
            // 
            // txtPais
            // 
            this.txtPais.BackColor = System.Drawing.SystemColors.Window;
            this.txtPais.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPais.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtPais.BorderRadius = 8;
            this.txtPais.BorderSize = 1;
            this.txtPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPais.DisabledBackColor = System.Drawing.Color.White;
            this.txtPais.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtPais.DisabledForeColor = System.Drawing.Color.White;
            this.txtPais.Enabled = false;
            this.txtPais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtPais.Location = new System.Drawing.Point(656, 104);
            this.txtPais.MaxLength = 32767;
            this.txtPais.Multiline = false;
            this.txtPais.Name = "txtPais";
            this.txtPais.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtPais.PasswordChar = false;
            this.txtPais.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPais.PlaceholderText = "";
            this.txtPais.Size = new System.Drawing.Size(184, 28);
            this.txtPais.TabIndex = 50;
            this.txtPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPais.Texts = "";
            this.txtPais.UnderlinedStyle = false;
            // 
            // txtUF
            // 
            this.txtUF.BackColor = System.Drawing.SystemColors.Window;
            this.txtUF.BorderColor = System.Drawing.Color.DarkGray;
            this.txtUF.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtUF.BorderRadius = 8;
            this.txtUF.BorderSize = 1;
            this.txtUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUF.DisabledBackColor = System.Drawing.Color.White;
            this.txtUF.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtUF.DisabledForeColor = System.Drawing.Color.White;
            this.txtUF.Enabled = false;
            this.txtUF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtUF.Location = new System.Drawing.Point(559, 104);
            this.txtUF.MaxLength = 32767;
            this.txtUF.Multiline = false;
            this.txtUF.Name = "txtUF";
            this.txtUF.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtUF.PasswordChar = false;
            this.txtUF.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUF.PlaceholderText = "";
            this.txtUF.Size = new System.Drawing.Size(83, 28);
            this.txtUF.TabIndex = 49;
            this.txtUF.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUF.Texts = "";
            this.txtUF.UnderlinedStyle = false;
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.SystemColors.Window;
            this.txtCidade.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCidade.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtCidade.BorderRadius = 8;
            this.txtCidade.BorderSize = 1;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.DisabledBackColor = System.Drawing.Color.White;
            this.txtCidade.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCidade.DisabledForeColor = System.Drawing.Color.White;
            this.txtCidade.Enabled = false;
            this.txtCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCidade.Location = new System.Drawing.Point(327, 104);
            this.txtCidade.MaxLength = 32767;
            this.txtCidade.Multiline = false;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCidade.PasswordChar = false;
            this.txtCidade.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCidade.PlaceholderText = "";
            this.txtCidade.Size = new System.Drawing.Size(215, 28);
            this.txtCidade.TabIndex = 48;
            this.txtCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCidade.Texts = "";
            this.txtCidade.UnderlinedStyle = false;
            // 
            // txtCodCidade
            // 
            this.txtCodCidade.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodCidade.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCodCidade.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtCodCidade.BorderRadius = 8;
            this.txtCodCidade.BorderSize = 1;
            this.txtCodCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodCidade.DisabledBackColor = System.Drawing.Color.White;
            this.txtCodCidade.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCodCidade.DisabledForeColor = System.Drawing.Color.White;
            this.txtCodCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCodCidade.Location = new System.Drawing.Point(174, 104);
            this.txtCodCidade.MaxLength = 5;
            this.txtCodCidade.Multiline = false;
            this.txtCodCidade.Name = "txtCodCidade";
            this.txtCodCidade.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodCidade.PasswordChar = false;
            this.txtCodCidade.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodCidade.PlaceholderText = "";
            this.txtCodCidade.Size = new System.Drawing.Size(80, 28);
            this.txtCodCidade.TabIndex = 14;
            this.txtCodCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodCidade.Texts = "";
            this.txtCodCidade.UnderlinedStyle = false;
            this.txtCodCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CadastroFornecedor_KeyPress);
            this.txtCodCidade.Leave += new System.EventHandler(this.txtCodCidade_Leave);
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.SystemColors.Window;
            this.txtBairro.BorderColor = System.Drawing.Color.DarkGray;
            this.txtBairro.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtBairro.BorderRadius = 8;
            this.txtBairro.BorderSize = 1;
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.DisabledBackColor = System.Drawing.Color.White;
            this.txtBairro.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtBairro.DisabledForeColor = System.Drawing.Color.White;
            this.txtBairro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtBairro.Location = new System.Drawing.Point(7, 104);
            this.txtBairro.MaxLength = 100;
            this.txtBairro.Multiline = false;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtBairro.PasswordChar = false;
            this.txtBairro.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBairro.PlaceholderText = "";
            this.txtBairro.Size = new System.Drawing.Size(149, 28);
            this.txtBairro.TabIndex = 13;
            this.txtBairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBairro.Texts = "";
            this.txtBairro.UnderlinedStyle = false;
            // 
            // txtComplemento
            // 
            this.txtComplemento.BackColor = System.Drawing.SystemColors.Window;
            this.txtComplemento.BorderColor = System.Drawing.Color.DarkGray;
            this.txtComplemento.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtComplemento.BorderRadius = 8;
            this.txtComplemento.BorderSize = 1;
            this.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplemento.DisabledBackColor = System.Drawing.Color.White;
            this.txtComplemento.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtComplemento.DisabledForeColor = System.Drawing.Color.White;
            this.txtComplemento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtComplemento.Location = new System.Drawing.Point(540, 42);
            this.txtComplemento.MaxLength = 50;
            this.txtComplemento.Multiline = false;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtComplemento.PasswordChar = false;
            this.txtComplemento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtComplemento.PlaceholderText = "";
            this.txtComplemento.Size = new System.Drawing.Size(300, 28);
            this.txtComplemento.TabIndex = 12;
            this.txtComplemento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtComplemento.Texts = "";
            this.txtComplemento.UnderlinedStyle = false;
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
            this.txtNumero.Location = new System.Drawing.Point(406, 42);
            this.txtNumero.MaxLength = 8;
            this.txtNumero.Multiline = false;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtNumero.PasswordChar = false;
            this.txtNumero.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumero.PlaceholderText = "";
            this.txtNumero.Size = new System.Drawing.Size(113, 28);
            this.txtNumero.TabIndex = 11;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumero.Texts = "";
            this.txtNumero.UnderlinedStyle = false;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndereco.BorderColor = System.Drawing.Color.DarkGray;
            this.txtEndereco.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtEndereco.BorderRadius = 8;
            this.txtEndereco.BorderSize = 1;
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.DisabledBackColor = System.Drawing.Color.White;
            this.txtEndereco.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtEndereco.DisabledForeColor = System.Drawing.Color.White;
            this.txtEndereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtEndereco.Location = new System.Drawing.Point(126, 42);
            this.txtEndereco.MaxLength = 150;
            this.txtEndereco.Multiline = false;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtEndereco.PasswordChar = false;
            this.txtEndereco.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEndereco.PlaceholderText = "";
            this.txtEndereco.Size = new System.Drawing.Size(258, 28);
            this.txtEndereco.TabIndex = 10;
            this.txtEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEndereco.Texts = "";
            this.txtEndereco.UnderlinedStyle = false;
            // 
            // txtCEP
            // 
            this.txtCEP.BackColor = System.Drawing.SystemColors.Window;
            this.txtCEP.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCEP.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtCEP.BorderRadius = 8;
            this.txtCEP.BorderSize = 1;
            this.txtCEP.DisabledBackColor = System.Drawing.Color.White;
            this.txtCEP.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCEP.DisabledForeColor = System.Drawing.Color.White;
            this.txtCEP.EnabledBackColor = System.Drawing.Color.White;
            this.txtCEP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCEP.Location = new System.Drawing.Point(6, 42);
            this.txtCEP.Mask = "";
            this.txtCEP.MaxLength = 32767;
            this.txtCEP.Multiline = false;
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCEP.PasswordChar = false;
            this.txtCEP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCEP.PlaceholderText = "";
            this.txtCEP.Size = new System.Drawing.Size(101, 27);
            this.txtCEP.TabIndex = 9;
            this.txtCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCEP.Texts = "";
            this.txtCEP.UnderlinedStyle = false;
            this.txtCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCEP_KeyPress);
            // 
            // btnBuscarCidade
            // 
            this.btnBuscarCidade.BackColor = System.Drawing.Color.GhostWhite;
            this.btnBuscarCidade.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnBuscarCidade.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btnBuscarCidade.BorderRadius = 8;
            this.btnBuscarCidade.BorderSize = 1;
            this.btnBuscarCidade.FlatAppearance.BorderSize = 0;
            this.btnBuscarCidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCidade.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnBuscarCidade.Location = new System.Drawing.Point(260, 103);
            this.btnBuscarCidade.Name = "btnBuscarCidade";
            this.btnBuscarCidade.Size = new System.Drawing.Size(61, 31);
            this.btnBuscarCidade.TabIndex = 15;
            this.btnBuscarCidade.Text = "Buscar";
            this.btnBuscarCidade.TextColor = System.Drawing.Color.DarkViolet;
            this.btnBuscarCidade.UseVisualStyleBackColor = false;
            this.btnBuscarCidade.Click += new System.EventHandler(this.btnBuscarCidade_Click);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(653, 88);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(30, 13);
            this.lblPais.TabIndex = 35;
            this.lblPais.Text = "Pais:";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(556, 88);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 13);
            this.lblUF.TabIndex = 20;
            this.lblUF.Text = "UF:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(324, 88);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 20;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblCodCidade
            // 
            this.lblCodCidade.AutoSize = true;
            this.lblCodCidade.Location = new System.Drawing.Point(171, 87);
            this.lblCodCidade.Name = "lblCodCidade";
            this.lblCodCidade.Size = new System.Drawing.Size(83, 13);
            this.lblCodCidade.TabIndex = 20;
            this.lblCodCidade.Text = "Código Cidade:*";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(7, 87);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(41, 13);
            this.lblBairro.TabIndex = 28;
            this.lblBairro.Text = "Bairro:*";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(537, 26);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 26;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(403, 26);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(51, 13);
            this.lblNumero.TabIndex = 24;
            this.lblNumero.Text = "Numero:*";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(123, 26);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(60, 13);
            this.lblEndereco.TabIndex = 22;
            this.lblEndereco.Text = "Endereço:*";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(6, 26);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(35, 13);
            this.lblCEP.TabIndex = 20;
            this.lblCEP.Text = "CEP:*";
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
            this.txtFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtFornecedor.Location = new System.Drawing.Point(23, 107);
            this.txtFornecedor.MaxLength = 70;
            this.txtFornecedor.Multiline = false;
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtFornecedor.PasswordChar = false;
            this.txtFornecedor.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFornecedor.PlaceholderText = "";
            this.txtFornecedor.Size = new System.Drawing.Size(275, 28);
            this.txtFornecedor.TabIndex = 1;
            this.txtFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFornecedor.Texts = "";
            this.txtFornecedor.UnderlinedStyle = false;
            this.txtFornecedor.Leave += new System.EventHandler(this.txtFornecedor_Leave);
            // 
            // txtApelido
            // 
            this.txtApelido.BackColor = System.Drawing.SystemColors.Window;
            this.txtApelido.BorderColor = System.Drawing.Color.DarkGray;
            this.txtApelido.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtApelido.BorderRadius = 8;
            this.txtApelido.BorderSize = 1;
            this.txtApelido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApelido.DisabledBackColor = System.Drawing.Color.White;
            this.txtApelido.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtApelido.DisabledForeColor = System.Drawing.Color.White;
            this.txtApelido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtApelido.Location = new System.Drawing.Point(321, 107);
            this.txtApelido.MaxLength = 70;
            this.txtApelido.Multiline = false;
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtApelido.PasswordChar = false;
            this.txtApelido.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtApelido.PlaceholderText = "";
            this.txtApelido.Size = new System.Drawing.Size(271, 28);
            this.txtApelido.TabIndex = 2;
            this.txtApelido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtApelido.Texts = "";
            this.txtApelido.UnderlinedStyle = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtEmail.BorderRadius = 8;
            this.txtEmail.BorderSize = 1;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.DisabledBackColor = System.Drawing.Color.White;
            this.txtEmail.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.DisabledForeColor = System.Drawing.Color.White;
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtEmail.Location = new System.Drawing.Point(23, 173);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.Size = new System.Drawing.Size(275, 28);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.SystemColors.Window;
            this.txtCelular.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCelular.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtCelular.BorderRadius = 8;
            this.txtCelular.BorderSize = 1;
            this.txtCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCelular.DisabledBackColor = System.Drawing.Color.White;
            this.txtCelular.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCelular.DisabledForeColor = System.Drawing.Color.White;
            this.txtCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCelular.Location = new System.Drawing.Point(470, 173);
            this.txtCelular.MaxLength = 50;
            this.txtCelular.Multiline = false;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCelular.PasswordChar = false;
            this.txtCelular.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCelular.PlaceholderText = "";
            this.txtCelular.Size = new System.Drawing.Size(122, 28);
            this.txtCelular.TabIndex = 6;
            this.txtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCelular.Texts = "";
            this.txtCelular.UnderlinedStyle = false;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.SystemColors.Window;
            this.txtTelefone.BorderColor = System.Drawing.Color.DarkGray;
            this.txtTelefone.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtTelefone.BorderRadius = 8;
            this.txtTelefone.BorderSize = 1;
            this.txtTelefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefone.DisabledBackColor = System.Drawing.Color.White;
            this.txtTelefone.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtTelefone.DisabledForeColor = System.Drawing.Color.White;
            this.txtTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtTelefone.Location = new System.Drawing.Point(321, 173);
            this.txtTelefone.MaxLength = 50;
            this.txtTelefone.Multiline = false;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtTelefone.PasswordChar = false;
            this.txtTelefone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTelefone.PlaceholderText = "";
            this.txtTelefone.Size = new System.Drawing.Size(122, 28);
            this.txtTelefone.TabIndex = 5;
            this.txtTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefone.Texts = "";
            this.txtTelefone.UnderlinedStyle = false;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            // 
            // txtNomeContato
            // 
            this.txtNomeContato.BackColor = System.Drawing.SystemColors.Window;
            this.txtNomeContato.BorderColor = System.Drawing.Color.DarkGray;
            this.txtNomeContato.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtNomeContato.BorderRadius = 8;
            this.txtNomeContato.BorderSize = 1;
            this.txtNomeContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeContato.DisabledBackColor = System.Drawing.Color.White;
            this.txtNomeContato.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtNomeContato.DisabledForeColor = System.Drawing.Color.White;
            this.txtNomeContato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtNomeContato.Location = new System.Drawing.Point(618, 173);
            this.txtNomeContato.MaxLength = 70;
            this.txtNomeContato.Multiline = false;
            this.txtNomeContato.Name = "txtNomeContato";
            this.txtNomeContato.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtNomeContato.PasswordChar = false;
            this.txtNomeContato.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNomeContato.PlaceholderText = "";
            this.txtNomeContato.Size = new System.Drawing.Size(263, 28);
            this.txtNomeContato.TabIndex = 7;
            this.txtNomeContato.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNomeContato.Texts = "";
            this.txtNomeContato.UnderlinedStyle = false;
            this.txtNomeContato.Leave += new System.EventHandler(this.txtNomeContato_Leave);
            // 
            // txtCPF_CNPJ
            // 
            this.txtCPF_CNPJ.BackColor = System.Drawing.SystemColors.Window;
            this.txtCPF_CNPJ.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCPF_CNPJ.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtCPF_CNPJ.BorderRadius = 8;
            this.txtCPF_CNPJ.BorderSize = 1;
            this.txtCPF_CNPJ.DisabledBackColor = System.Drawing.Color.White;
            this.txtCPF_CNPJ.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCPF_CNPJ.DisabledForeColor = System.Drawing.Color.White;
            this.txtCPF_CNPJ.EnabledBackColor = System.Drawing.Color.White;
            this.txtCPF_CNPJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCPF_CNPJ.Location = new System.Drawing.Point(23, 417);
            this.txtCPF_CNPJ.Mask = "000.000.000-00";
            this.txtCPF_CNPJ.MaxLength = 32767;
            this.txtCPF_CNPJ.Multiline = false;
            this.txtCPF_CNPJ.Name = "txtCPF_CNPJ";
            this.txtCPF_CNPJ.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCPF_CNPJ.PasswordChar = false;
            this.txtCPF_CNPJ.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCPF_CNPJ.PlaceholderText = "";
            this.txtCPF_CNPJ.Size = new System.Drawing.Size(150, 27);
            this.txtCPF_CNPJ.TabIndex = 16;
            this.txtCPF_CNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCPF_CNPJ.Texts = "   ,   ,   -";
            this.txtCPF_CNPJ.UnderlinedStyle = false;
            this.txtCPF_CNPJ.Leave += new System.EventHandler(this.txtCPF_CNPJ_Leave);
            // 
            // txtRG_IE
            // 
            this.txtRG_IE.BackColor = System.Drawing.SystemColors.Window;
            this.txtRG_IE.BorderColor = System.Drawing.Color.DarkGray;
            this.txtRG_IE.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtRG_IE.BorderRadius = 8;
            this.txtRG_IE.BorderSize = 1;
            this.txtRG_IE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRG_IE.DisabledBackColor = System.Drawing.Color.White;
            this.txtRG_IE.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtRG_IE.DisabledForeColor = System.Drawing.Color.White;
            this.txtRG_IE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtRG_IE.Location = new System.Drawing.Point(192, 417);
            this.txtRG_IE.MaxLength = 14;
            this.txtRG_IE.Multiline = false;
            this.txtRG_IE.Name = "txtRG_IE";
            this.txtRG_IE.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtRG_IE.PasswordChar = false;
            this.txtRG_IE.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtRG_IE.PlaceholderText = "";
            this.txtRG_IE.Size = new System.Drawing.Size(122, 28);
            this.txtRG_IE.TabIndex = 17;
            this.txtRG_IE.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRG_IE.Texts = "";
            this.txtRG_IE.UnderlinedStyle = false;
            this.txtRG_IE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRG_IE_KeyPress);
            this.txtRG_IE.Leave += new System.EventHandler(this.txtRG_IE_Leave);
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataNasc.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDataNasc.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtDataNasc.BorderRadius = 8;
            this.txtDataNasc.BorderSize = 1;
            this.txtDataNasc.DisabledBackColor = System.Drawing.Color.White;
            this.txtDataNasc.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtDataNasc.DisabledForeColor = System.Drawing.Color.White;
            this.txtDataNasc.EnabledBackColor = System.Drawing.Color.White;
            this.txtDataNasc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDataNasc.Location = new System.Drawing.Point(340, 418);
            this.txtDataNasc.Mask = "00/00/0000";
            this.txtDataNasc.MaxLength = 32767;
            this.txtDataNasc.Multiline = false;
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDataNasc.PasswordChar = false;
            this.txtDataNasc.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDataNasc.PlaceholderText = "";
            this.txtDataNasc.Size = new System.Drawing.Size(101, 27);
            this.txtDataNasc.TabIndex = 18;
            this.txtDataNasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataNasc.Texts = "  /  /";
            this.txtDataNasc.UnderlinedStyle = false;
            this.txtDataNasc.Leave += new System.EventHandler(this.txtDataNasc_Leave);
            // 
            // CadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(909, 570);
            this.Controls.Add(this.txtDataNasc);
            this.Controls.Add(this.txtRG_IE);
            this.Controls.Add(this.txtCPF_CNPJ);
            this.Controls.Add(this.txtNomeContato);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.gbEndereco);
            this.Controls.Add(this.gpPagamento);
            this.Controls.Add(this.lblRG_IE);
            this.Controls.Add(this.gpPessoa);
            this.Controls.Add(this.lblNomeContato);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblCPF_CNPJ);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblApelido);
            this.Controls.Add(this.lblFornecedor);
            this.Name = "CadastroFornecedor";
            this.Text = "Cadastro de Fornecedor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroFornecedor_FormClosed);
            this.Load += new System.EventHandler(this.CadastroFornecedor_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CadastroFornecedor_KeyPress);
            this.Controls.SetChildIndex(this.lblFornecedor, 0);
            this.Controls.SetChildIndex(this.lblApelido, 0);
            this.Controls.SetChildIndex(this.lblSexo, 0);
            this.Controls.SetChildIndex(this.txtSexo, 0);
            this.Controls.SetChildIndex(this.lblEmail, 0);
            this.Controls.SetChildIndex(this.lblCPF_CNPJ, 0);
            this.Controls.SetChildIndex(this.lblCelular, 0);
            this.Controls.SetChildIndex(this.lblDataNasc, 0);
            this.Controls.SetChildIndex(this.lblTelefone, 0);
            this.Controls.SetChildIndex(this.lblNomeContato, 0);
            this.Controls.SetChildIndex(this.gpPessoa, 0);
            this.Controls.SetChildIndex(this.lblRG_IE, 0);
            this.Controls.SetChildIndex(this.gpPagamento, 0);
            this.Controls.SetChildIndex(this.gbEndereco, 0);
            this.Controls.SetChildIndex(this.txtFornecedor, 0);
            this.Controls.SetChildIndex(this.txtApelido, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.txtCelular, 0);
            this.Controls.SetChildIndex(this.txtTelefone, 0);
            this.Controls.SetChildIndex(this.txtNomeContato, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.gbStatus, 0);
            this.Controls.SetChildIndex(this.txtCPF_CNPJ, 0);
            this.Controls.SetChildIndex(this.txtRG_IE, 0);
            this.Controls.SetChildIndex(this.txtDataNasc, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gpPessoa.ResumeLayout(false);
            this.gpPessoa.PerformLayout();
            this.gpPagamento.ResumeLayout(false);
            this.gpPagamento.PerformLayout();
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCPF_CNPJ;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox txtSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNomeContato;
        private System.Windows.Forms.GroupBox gpPessoa;
        private System.Windows.Forms.RadioButton rbJuridica;
        private System.Windows.Forms.RadioButton rbFisica;
        private System.Windows.Forms.Label lblRG_IE;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gpPagamento;
        private System.Windows.Forms.Label lblCondPag;
        private System.Windows.Forms.Label lblCodCondPag;
        private System.Windows.Forms.GroupBox gbEndereco;
        private YControls.YTextBox txtPais;
        private YControls.YTextBox txtUF;
        private YControls.YTextBox txtCidade;
        private YControls.YTextBox txtCodCidade;
        private YControls.YTextBox txtBairro;
        private YControls.YTextBox txtComplemento;
        private YControls.YTextBox txtNumero;
        private YControls.YTextBox txtEndereco;
        private YControls.YMaskedTextBox txtCEP;
        protected YControls.YButton btnBuscarCidade;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblCodCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCEP;
        private YControls.YTextBox txtFornecedor;
        private YControls.YTextBox txtApelido;
        private YControls.YTextBox txtEmail;
        private YControls.YTextBox txtCelular;
        private YControls.YTextBox txtTelefone;
        private YControls.YTextBox txtNomeContato;
        private YControls.YMaskedTextBox txtCPF_CNPJ;
        private YControls.YTextBox txtRG_IE;
        private YControls.YMaskedTextBox txtDataNasc;
        private YControls.YTextBox txtCondPag;
        private YControls.YTextBox txtCodCondPag;
        protected YControls.YButton btnBuscarCond;
    }
}
