namespace Pilates.Views
{
    partial class CadastroAluno
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblApelido = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.ComboBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.dataGridViewPostura = new System.Windows.Forms.DataGridView();
            this.CodigoPostura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TituloPostura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewEvolucao = new System.Windows.Forms.DataGridView();
            this.CodigoEvolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TituloEvolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPostura = new System.Windows.Forms.Label();
            this.lblEvolucao = new System.Windows.Forms.Label();
            this.lblProfissao = new System.Windows.Forms.Label();
            this.lblCodProfissao = new System.Windows.Forms.Label();
            this.btnBuscarProfissao = new Pilates.YControls.YButton();
            this.txtNome = new Pilates.YControls.YTextBox();
            this.txtApelido = new Pilates.YControls.YTextBox();
            this.txtCelular = new Pilates.YControls.YTextBox();
            this.txtEmail = new Pilates.YControls.YTextBox();
            this.txtCPF = new Pilates.YControls.YMaskedTextBox();
            this.txtCodProfissao = new Pilates.YControls.YTextBox();
            this.txtProfissão = new Pilates.YControls.YTextBox();
            this.txtDataNasc = new Pilates.YControls.YMaskedTextBox();
            this.btnExcluirPostura = new Pilates.YControls.YButton();
            this.btnAlterarPostura = new Pilates.YControls.YButton();
            this.btnIncluirPostura = new Pilates.YControls.YButton();
            this.btnExcluirEvolucao = new Pilates.YControls.YButton();
            this.btnAlterarEvolucao = new Pilates.YControls.YButton();
            this.btnIncluirEvolucao = new Pilates.YControls.YButton();
            this.gbStatus.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvolucao)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(134, 796);
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(20, 797);
            // 
            // gbStatus
            // 
            this.gbStatus.Location = new System.Drawing.Point(742, 19);
            this.gbStatus.TabIndex = 20;
            // 
            // rbInativo
            // 
            this.rbInativo.TabIndex = 22;
            // 
            // rbAtivo
            // 
            this.rbAtivo.TabIndex = 21;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(727, 808);
            this.btnSalvar.TabIndex = 16;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Texts = "0";
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(23, 813);
            this.txtDataCadastro.Texts = "24/10/2024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(137, 812);
            this.txtDataUltAlt.Texts = "24/10/2024";
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(824, 808);
            this.btnSair.TabIndex = 17;
            // 
            // txtUsuarioUltAlt
            // 
            this.txtUsuarioUltAlt.Location = new System.Drawing.Point(255, 811);
            // 
            // lblUsuarioUltAlt
            // 
            this.lblUsuarioUltAlt.Location = new System.Drawing.Point(252, 795);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(21, 83);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(42, 13);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Nome:*";
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Location = new System.Drawing.Point(320, 83);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(45, 13);
            this.lblApelido.TabIndex = 11;
            this.lblApelido.Text = "Apelido:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(620, 83);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(38, 13);
            this.lblSexo.TabIndex = 13;
            this.lblSexo.Text = "Sexo:*";
            // 
            // txtSexo
            // 
            this.txtSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSexo.FormattingEnabled = true;
            this.txtSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMININO",
            "OUTROS"});
            this.txtSexo.Location = new System.Drawing.Point(623, 103);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(141, 21);
            this.txtSexo.TabIndex = 3;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(21, 148);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(46, 13);
            this.lblCelular.TabIndex = 15;
            this.lblCelular.Text = "Celular:*";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(183, 395);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(68, 13);
            this.lblDataNasc.TabIndex = 17;
            this.lblDataNasc.Text = "Data Nasc.:*";
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
            this.gbEndereco.Location = new System.Drawing.Point(18, 219);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(887, 157);
            this.gbEndereco.TabIndex = 6;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereço";
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
            this.txtPais.Size = new System.Drawing.Size(213, 28);
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
            this.txtCodCidade.TabIndex = 12;
            this.txtCodCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodCidade.Texts = "";
            this.txtCodCidade.UnderlinedStyle = false;
            this.txtCodCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodCidade_KeyPress);
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
            this.txtBairro.TabIndex = 11;
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
            this.txtComplemento.MaxLength = 100;
            this.txtComplemento.Multiline = false;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtComplemento.PasswordChar = false;
            this.txtComplemento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtComplemento.PlaceholderText = "";
            this.txtComplemento.Size = new System.Drawing.Size(329, 28);
            this.txtComplemento.TabIndex = 10;
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
            this.txtNumero.MaxLength = 32767;
            this.txtNumero.Multiline = false;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtNumero.PasswordChar = false;
            this.txtNumero.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumero.PlaceholderText = "";
            this.txtNumero.Size = new System.Drawing.Size(113, 28);
            this.txtNumero.TabIndex = 9;
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
            this.txtEndereco.TabIndex = 8;
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
            this.txtCEP.TabIndex = 7;
            this.txtCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCEP.Texts = "";
            this.txtCEP.UnderlinedStyle = false;
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
            this.btnBuscarCidade.TabIndex = 36;
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
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(200, 148);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 13);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "Email:*";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(18, 395);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(34, 13);
            this.lblCPF.TabIndex = 23;
            this.lblCPF.Text = "CPF:*";
            // 
            // dataGridViewPostura
            // 
            this.dataGridViewPostura.AllowUserToAddRows = false;
            this.dataGridViewPostura.AllowUserToDeleteRows = false;
            this.dataGridViewPostura.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dataGridViewPostura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPostura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoPostura,
            this.TituloPostura});
            this.dataGridViewPostura.Location = new System.Drawing.Point(23, 471);
            this.dataGridViewPostura.Name = "dataGridViewPostura";
            this.dataGridViewPostura.ReadOnly = true;
            this.dataGridViewPostura.Size = new System.Drawing.Size(416, 266);
            this.dataGridViewPostura.TabIndex = 24;
            this.dataGridViewPostura.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPostura_CellDoubleClick);
            // 
            // CodigoPostura
            // 
            this.CodigoPostura.HeaderText = "Código";
            this.CodigoPostura.Name = "CodigoPostura";
            this.CodigoPostura.ReadOnly = true;
            // 
            // TituloPostura
            // 
            this.TituloPostura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TituloPostura.HeaderText = "Título";
            this.TituloPostura.Name = "TituloPostura";
            this.TituloPostura.ReadOnly = true;
            // 
            // dataGridViewEvolucao
            // 
            this.dataGridViewEvolucao.AllowUserToAddRows = false;
            this.dataGridViewEvolucao.AllowUserToDeleteRows = false;
            this.dataGridViewEvolucao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dataGridViewEvolucao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvolucao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoEvolucao,
            this.TituloEvolucao});
            this.dataGridViewEvolucao.Location = new System.Drawing.Point(462, 471);
            this.dataGridViewEvolucao.Name = "dataGridViewEvolucao";
            this.dataGridViewEvolucao.ReadOnly = true;
            this.dataGridViewEvolucao.Size = new System.Drawing.Size(444, 266);
            this.dataGridViewEvolucao.TabIndex = 25;
            this.dataGridViewEvolucao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEvolucao_CellContentClick);
            this.dataGridViewEvolucao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEvolucao_CellDoubleClick);
            // 
            // CodigoEvolucao
            // 
            this.CodigoEvolucao.HeaderText = "Código";
            this.CodigoEvolucao.Name = "CodigoEvolucao";
            this.CodigoEvolucao.ReadOnly = true;
            // 
            // TituloEvolucao
            // 
            this.TituloEvolucao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TituloEvolucao.HeaderText = "Título";
            this.TituloEvolucao.Name = "TituloEvolucao";
            this.TituloEvolucao.ReadOnly = true;
            // 
            // lblPostura
            // 
            this.lblPostura.AutoSize = true;
            this.lblPostura.Location = new System.Drawing.Point(21, 455);
            this.lblPostura.Name = "lblPostura";
            this.lblPostura.Size = new System.Drawing.Size(46, 13);
            this.lblPostura.TabIndex = 26;
            this.lblPostura.Text = "Postura:";
            this.lblPostura.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEvolucao
            // 
            this.lblEvolucao.AutoSize = true;
            this.lblEvolucao.Location = new System.Drawing.Point(459, 455);
            this.lblEvolucao.Name = "lblEvolucao";
            this.lblEvolucao.Size = new System.Drawing.Size(55, 13);
            this.lblEvolucao.TabIndex = 27;
            this.lblEvolucao.Text = "Evolução:";
            // 
            // lblProfissao
            // 
            this.lblProfissao.AutoSize = true;
            this.lblProfissao.Location = new System.Drawing.Point(612, 395);
            this.lblProfissao.Name = "lblProfissao";
            this.lblProfissao.Size = new System.Drawing.Size(53, 13);
            this.lblProfissao.TabIndex = 37;
            this.lblProfissao.Text = "Profissão:";
            // 
            // lblCodProfissao
            // 
            this.lblCodProfissao.AutoSize = true;
            this.lblCodProfissao.Location = new System.Drawing.Point(459, 395);
            this.lblCodProfissao.Name = "lblCodProfissao";
            this.lblCodProfissao.Size = new System.Drawing.Size(82, 13);
            this.lblCodProfissao.TabIndex = 38;
            this.lblCodProfissao.Text = "Cod. Profissão*:";
            // 
            // btnBuscarProfissao
            // 
            this.btnBuscarProfissao.BackColor = System.Drawing.Color.GhostWhite;
            this.btnBuscarProfissao.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnBuscarProfissao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btnBuscarProfissao.BorderRadius = 8;
            this.btnBuscarProfissao.BorderSize = 1;
            this.btnBuscarProfissao.FlatAppearance.BorderSize = 0;
            this.btnBuscarProfissao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProfissao.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnBuscarProfissao.Location = new System.Drawing.Point(548, 409);
            this.btnBuscarProfissao.Name = "btnBuscarProfissao";
            this.btnBuscarProfissao.Size = new System.Drawing.Size(61, 31);
            this.btnBuscarProfissao.TabIndex = 39;
            this.btnBuscarProfissao.Text = "Buscar";
            this.btnBuscarProfissao.TextColor = System.Drawing.Color.DarkViolet;
            this.btnBuscarProfissao.UseVisualStyleBackColor = false;
            this.btnBuscarProfissao.Click += new System.EventHandler(this.btnBuscarProfissao_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.BorderColor = System.Drawing.Color.DarkGray;
            this.txtNome.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtNome.BorderRadius = 8;
            this.txtNome.BorderSize = 1;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.DisabledBackColor = System.Drawing.Color.White;
            this.txtNome.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtNome.DisabledForeColor = System.Drawing.Color.White;
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtNome.Location = new System.Drawing.Point(23, 98);
            this.txtNome.MaxLength = 50;
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtNome.PasswordChar = false;
            this.txtNome.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNome.PlaceholderText = "";
            this.txtNome.Size = new System.Drawing.Size(278, 28);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNome.Texts = "";
            this.txtNome.UnderlinedStyle = false;
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
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
            this.txtApelido.Location = new System.Drawing.Point(323, 99);
            this.txtApelido.MaxLength = 50;
            this.txtApelido.Multiline = false;
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtApelido.PasswordChar = false;
            this.txtApelido.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtApelido.PlaceholderText = "";
            this.txtApelido.Size = new System.Drawing.Size(278, 28);
            this.txtApelido.TabIndex = 2;
            this.txtApelido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtApelido.Texts = "";
            this.txtApelido.UnderlinedStyle = false;
            this.txtApelido.Leave += new System.EventHandler(this.txtApelido_Leave);
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
            this.txtCelular.Location = new System.Drawing.Point(24, 164);
            this.txtCelular.MaxLength = 50;
            this.txtCelular.Multiline = false;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCelular.PasswordChar = false;
            this.txtCelular.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCelular.PlaceholderText = "";
            this.txtCelular.Size = new System.Drawing.Size(142, 28);
            this.txtCelular.TabIndex = 4;
            this.txtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCelular.Texts = "";
            this.txtCelular.UnderlinedStyle = false;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
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
            this.txtEmail.Location = new System.Drawing.Point(203, 164);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.Size = new System.Drawing.Size(398, 28);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.SystemColors.Window;
            this.txtCPF.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCPF.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtCPF.BorderRadius = 8;
            this.txtCPF.BorderSize = 1;
            this.txtCPF.DisabledBackColor = System.Drawing.Color.White;
            this.txtCPF.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCPF.DisabledForeColor = System.Drawing.Color.White;
            this.txtCPF.EnabledBackColor = System.Drawing.Color.White;
            this.txtCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCPF.Location = new System.Drawing.Point(18, 411);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.MaxLength = 32767;
            this.txtCPF.Multiline = false;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCPF.PasswordChar = false;
            this.txtCPF.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCPF.PlaceholderText = "";
            this.txtCPF.Size = new System.Drawing.Size(150, 27);
            this.txtCPF.TabIndex = 13;
            this.txtCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCPF.Texts = "   ,   ,   -";
            this.txtCPF.UnderlinedStyle = false;
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // txtCodProfissao
            // 
            this.txtCodProfissao.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodProfissao.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCodProfissao.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtCodProfissao.BorderRadius = 8;
            this.txtCodProfissao.BorderSize = 1;
            this.txtCodProfissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodProfissao.DisabledBackColor = System.Drawing.Color.White;
            this.txtCodProfissao.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCodProfissao.DisabledForeColor = System.Drawing.Color.White;
            this.txtCodProfissao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCodProfissao.Location = new System.Drawing.Point(462, 410);
            this.txtCodProfissao.MaxLength = 5;
            this.txtCodProfissao.Multiline = false;
            this.txtCodProfissao.Name = "txtCodProfissao";
            this.txtCodProfissao.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodProfissao.PasswordChar = false;
            this.txtCodProfissao.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodProfissao.PlaceholderText = "";
            this.txtCodProfissao.Size = new System.Drawing.Size(80, 28);
            this.txtCodProfissao.TabIndex = 15;
            this.txtCodProfissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodProfissao.Texts = "";
            this.txtCodProfissao.UnderlinedStyle = false;
            this.txtCodProfissao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodProfissao_KeyPress);
            this.txtCodProfissao.Leave += new System.EventHandler(this.txtCodProfissao_Leave);
            // 
            // txtProfissão
            // 
            this.txtProfissão.BackColor = System.Drawing.SystemColors.Window;
            this.txtProfissão.BorderColor = System.Drawing.Color.DarkGray;
            this.txtProfissão.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtProfissão.BorderRadius = 8;
            this.txtProfissão.BorderSize = 1;
            this.txtProfissão.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProfissão.DisabledBackColor = System.Drawing.Color.White;
            this.txtProfissão.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtProfissão.DisabledForeColor = System.Drawing.Color.White;
            this.txtProfissão.Enabled = false;
            this.txtProfissão.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtProfissão.Location = new System.Drawing.Point(615, 410);
            this.txtProfissão.MaxLength = 32767;
            this.txtProfissão.Multiline = false;
            this.txtProfissão.Name = "txtProfissão";
            this.txtProfissão.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtProfissão.PasswordChar = false;
            this.txtProfissão.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtProfissão.PlaceholderText = "";
            this.txtProfissão.Size = new System.Drawing.Size(290, 28);
            this.txtProfissão.TabIndex = 51;
            this.txtProfissão.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProfissão.Texts = "";
            this.txtProfissão.UnderlinedStyle = false;
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
            this.txtDataNasc.Location = new System.Drawing.Point(186, 412);
            this.txtDataNasc.Mask = "00/00/0000";
            this.txtDataNasc.MaxLength = 32767;
            this.txtDataNasc.Multiline = false;
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDataNasc.PasswordChar = false;
            this.txtDataNasc.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDataNasc.PlaceholderText = "";
            this.txtDataNasc.Size = new System.Drawing.Size(101, 27);
            this.txtDataNasc.TabIndex = 14;
            this.txtDataNasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataNasc.Texts = "  /  /";
            this.txtDataNasc.UnderlinedStyle = false;
            this.txtDataNasc.Leave += new System.EventHandler(this.txtDataNasc_Leave);
            // 
            // btnExcluirPostura
            // 
            this.btnExcluirPostura.BackColor = System.Drawing.Color.DarkViolet;
            this.btnExcluirPostura.BackgroundColor = System.Drawing.Color.DarkViolet;
            this.btnExcluirPostura.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btnExcluirPostura.BorderRadius = 8;
            this.btnExcluirPostura.BorderSize = 1;
            this.btnExcluirPostura.Enabled = false;
            this.btnExcluirPostura.FlatAppearance.BorderSize = 0;
            this.btnExcluirPostura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirPostura.ForeColor = System.Drawing.Color.White;
            this.btnExcluirPostura.Location = new System.Drawing.Point(356, 743);
            this.btnExcluirPostura.Name = "btnExcluirPostura";
            this.btnExcluirPostura.Size = new System.Drawing.Size(83, 31);
            this.btnExcluirPostura.TabIndex = 54;
            this.btnExcluirPostura.Text = "Excluir";
            this.btnExcluirPostura.TextColor = System.Drawing.Color.White;
            this.btnExcluirPostura.UseVisualStyleBackColor = false;
            this.btnExcluirPostura.Click += new System.EventHandler(this.btnExcluirPostura_Click);
            // 
            // btnAlterarPostura
            // 
            this.btnAlterarPostura.BackColor = System.Drawing.Color.DarkViolet;
            this.btnAlterarPostura.BackgroundColor = System.Drawing.Color.DarkViolet;
            this.btnAlterarPostura.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btnAlterarPostura.BorderRadius = 8;
            this.btnAlterarPostura.BorderSize = 1;
            this.btnAlterarPostura.Enabled = false;
            this.btnAlterarPostura.FlatAppearance.BorderSize = 0;
            this.btnAlterarPostura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarPostura.ForeColor = System.Drawing.Color.White;
            this.btnAlterarPostura.Location = new System.Drawing.Point(267, 743);
            this.btnAlterarPostura.Name = "btnAlterarPostura";
            this.btnAlterarPostura.Size = new System.Drawing.Size(83, 31);
            this.btnAlterarPostura.TabIndex = 53;
            this.btnAlterarPostura.Text = "Alterar";
            this.btnAlterarPostura.TextColor = System.Drawing.Color.White;
            this.btnAlterarPostura.UseVisualStyleBackColor = false;
            this.btnAlterarPostura.Click += new System.EventHandler(this.btnAlterarPostura_Click);
            // 
            // btnIncluirPostura
            // 
            this.btnIncluirPostura.BackColor = System.Drawing.Color.DarkViolet;
            this.btnIncluirPostura.BackgroundColor = System.Drawing.Color.DarkViolet;
            this.btnIncluirPostura.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btnIncluirPostura.BorderRadius = 8;
            this.btnIncluirPostura.BorderSize = 1;
            this.btnIncluirPostura.Enabled = false;
            this.btnIncluirPostura.FlatAppearance.BorderSize = 0;
            this.btnIncluirPostura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluirPostura.ForeColor = System.Drawing.Color.White;
            this.btnIncluirPostura.Location = new System.Drawing.Point(178, 743);
            this.btnIncluirPostura.Name = "btnIncluirPostura";
            this.btnIncluirPostura.Size = new System.Drawing.Size(83, 31);
            this.btnIncluirPostura.TabIndex = 52;
            this.btnIncluirPostura.Text = "Incluir";
            this.btnIncluirPostura.TextColor = System.Drawing.Color.White;
            this.btnIncluirPostura.UseVisualStyleBackColor = false;
            this.btnIncluirPostura.Click += new System.EventHandler(this.btnIncluirPostura_Click);
            // 
            // btnExcluirEvolucao
            // 
            this.btnExcluirEvolucao.BackColor = System.Drawing.Color.DarkViolet;
            this.btnExcluirEvolucao.BackgroundColor = System.Drawing.Color.DarkViolet;
            this.btnExcluirEvolucao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btnExcluirEvolucao.BorderRadius = 8;
            this.btnExcluirEvolucao.BorderSize = 1;
            this.btnExcluirEvolucao.Enabled = false;
            this.btnExcluirEvolucao.FlatAppearance.BorderSize = 0;
            this.btnExcluirEvolucao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirEvolucao.ForeColor = System.Drawing.Color.White;
            this.btnExcluirEvolucao.Location = new System.Drawing.Point(823, 743);
            this.btnExcluirEvolucao.Name = "btnExcluirEvolucao";
            this.btnExcluirEvolucao.Size = new System.Drawing.Size(83, 31);
            this.btnExcluirEvolucao.TabIndex = 57;
            this.btnExcluirEvolucao.Text = "Excluir";
            this.btnExcluirEvolucao.TextColor = System.Drawing.Color.White;
            this.btnExcluirEvolucao.UseVisualStyleBackColor = false;
            this.btnExcluirEvolucao.Click += new System.EventHandler(this.btnExcluirEvolucao_Click);
            // 
            // btnAlterarEvolucao
            // 
            this.btnAlterarEvolucao.BackColor = System.Drawing.Color.DarkViolet;
            this.btnAlterarEvolucao.BackgroundColor = System.Drawing.Color.DarkViolet;
            this.btnAlterarEvolucao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btnAlterarEvolucao.BorderRadius = 8;
            this.btnAlterarEvolucao.BorderSize = 1;
            this.btnAlterarEvolucao.Enabled = false;
            this.btnAlterarEvolucao.FlatAppearance.BorderSize = 0;
            this.btnAlterarEvolucao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarEvolucao.ForeColor = System.Drawing.Color.White;
            this.btnAlterarEvolucao.Location = new System.Drawing.Point(734, 743);
            this.btnAlterarEvolucao.Name = "btnAlterarEvolucao";
            this.btnAlterarEvolucao.Size = new System.Drawing.Size(83, 31);
            this.btnAlterarEvolucao.TabIndex = 56;
            this.btnAlterarEvolucao.Text = "Alterar";
            this.btnAlterarEvolucao.TextColor = System.Drawing.Color.White;
            this.btnAlterarEvolucao.UseVisualStyleBackColor = false;
            this.btnAlterarEvolucao.Click += new System.EventHandler(this.btnAlterarEvolucao_Click);
            // 
            // btnIncluirEvolucao
            // 
            this.btnIncluirEvolucao.BackColor = System.Drawing.Color.DarkViolet;
            this.btnIncluirEvolucao.BackgroundColor = System.Drawing.Color.DarkViolet;
            this.btnIncluirEvolucao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btnIncluirEvolucao.BorderRadius = 8;
            this.btnIncluirEvolucao.BorderSize = 1;
            this.btnIncluirEvolucao.Enabled = false;
            this.btnIncluirEvolucao.FlatAppearance.BorderSize = 0;
            this.btnIncluirEvolucao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluirEvolucao.ForeColor = System.Drawing.Color.White;
            this.btnIncluirEvolucao.Location = new System.Drawing.Point(645, 743);
            this.btnIncluirEvolucao.Name = "btnIncluirEvolucao";
            this.btnIncluirEvolucao.Size = new System.Drawing.Size(83, 31);
            this.btnIncluirEvolucao.TabIndex = 55;
            this.btnIncluirEvolucao.Text = "Incluir";
            this.btnIncluirEvolucao.TextColor = System.Drawing.Color.White;
            this.btnIncluirEvolucao.UseVisualStyleBackColor = false;
            this.btnIncluirEvolucao.Click += new System.EventHandler(this.btnIncluirEvolucao_Click);
            // 
            // CadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(941, 862);
            this.Controls.Add(this.btnExcluirEvolucao);
            this.Controls.Add(this.btnAlterarEvolucao);
            this.Controls.Add(this.btnIncluirEvolucao);
            this.Controls.Add(this.btnExcluirPostura);
            this.Controls.Add(this.btnAlterarPostura);
            this.Controls.Add(this.btnIncluirPostura);
            this.Controls.Add(this.txtDataNasc);
            this.Controls.Add(this.txtProfissão);
            this.Controls.Add(this.txtCodProfissao);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnBuscarProfissao);
            this.Controls.Add(this.lblProfissao);
            this.Controls.Add(this.lblCodProfissao);
            this.Controls.Add(this.lblEvolucao);
            this.Controls.Add(this.lblPostura);
            this.Controls.Add(this.dataGridViewEvolucao);
            this.Controls.Add(this.dataGridViewPostura);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.gbEndereco);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblApelido);
            this.Controls.Add(this.lblNome);
            this.Name = "CadastroAluno";
            this.Text = "Cadastro de Aluno";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroAluno_FormClosed);
            this.Load += new System.EventHandler(this.CadastroAluno_Load);
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
            this.Controls.SetChildIndex(this.lblNome, 0);
            this.Controls.SetChildIndex(this.lblApelido, 0);
            this.Controls.SetChildIndex(this.lblSexo, 0);
            this.Controls.SetChildIndex(this.txtSexo, 0);
            this.Controls.SetChildIndex(this.lblCelular, 0);
            this.Controls.SetChildIndex(this.lblDataNasc, 0);
            this.Controls.SetChildIndex(this.gbEndereco, 0);
            this.Controls.SetChildIndex(this.lblEmail, 0);
            this.Controls.SetChildIndex(this.lblCPF, 0);
            this.Controls.SetChildIndex(this.dataGridViewPostura, 0);
            this.Controls.SetChildIndex(this.dataGridViewEvolucao, 0);
            this.Controls.SetChildIndex(this.lblPostura, 0);
            this.Controls.SetChildIndex(this.lblEvolucao, 0);
            this.Controls.SetChildIndex(this.lblCodProfissao, 0);
            this.Controls.SetChildIndex(this.lblProfissao, 0);
            this.Controls.SetChildIndex(this.btnBuscarProfissao, 0);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.Controls.SetChildIndex(this.txtApelido, 0);
            this.Controls.SetChildIndex(this.txtCelular, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.txtCPF, 0);
            this.Controls.SetChildIndex(this.txtCodProfissao, 0);
            this.Controls.SetChildIndex(this.txtProfissão, 0);
            this.Controls.SetChildIndex(this.txtDataNasc, 0);
            this.Controls.SetChildIndex(this.btnIncluirPostura, 0);
            this.Controls.SetChildIndex(this.btnAlterarPostura, 0);
            this.Controls.SetChildIndex(this.btnExcluirPostura, 0);
            this.Controls.SetChildIndex(this.btnIncluirEvolucao, 0);
            this.Controls.SetChildIndex(this.btnAlterarEvolucao, 0);
            this.Controls.SetChildIndex(this.btnExcluirEvolucao, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvolucao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox txtSexo;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCodCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.DataGridView dataGridViewPostura;
        private System.Windows.Forms.DataGridView dataGridViewEvolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoEvolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TituloEvolucao;
        private System.Windows.Forms.Label lblPostura;
        private System.Windows.Forms.Label lblEvolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPostura;
        private System.Windows.Forms.DataGridViewTextBoxColumn TituloPostura;
        private System.Windows.Forms.Label lblProfissao;
        private System.Windows.Forms.Label lblCodProfissao;
        protected YControls.YButton btnBuscarCidade;
        protected YControls.YButton btnBuscarProfissao;
        private YControls.YTextBox txtNome;
        private YControls.YTextBox txtApelido;
        private YControls.YTextBox txtCelular;
        private YControls.YTextBox txtEmail;
        private YControls.YMaskedTextBox txtCEP;
        private YControls.YTextBox txtCidade;
        private YControls.YTextBox txtCodCidade;
        private YControls.YTextBox txtBairro;
        private YControls.YTextBox txtComplemento;
        private YControls.YTextBox txtNumero;
        private YControls.YTextBox txtEndereco;
        private YControls.YTextBox txtPais;
        private YControls.YTextBox txtUF;
        private YControls.YMaskedTextBox txtCPF;
        private YControls.YTextBox txtCodProfissao;
        private YControls.YTextBox txtProfissão;
        private YControls.YMaskedTextBox txtDataNasc;
        protected YControls.YButton btnExcluirPostura;
        protected YControls.YButton btnAlterarPostura;
        protected YControls.YButton btnIncluirPostura;
        protected YControls.YButton btnExcluirEvolucao;
        protected YControls.YButton btnAlterarEvolucao;
        protected YControls.YButton btnIncluirEvolucao;
    }
}
