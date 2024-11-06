namespace Pilates.Views
{
    partial class CadastroPostura
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
            this.lblCabeca = new System.Windows.Forms.Label();
            this.lblOmbro = new System.Windows.Forms.Label();
            this.lblEscapula = new System.Windows.Forms.Label();
            this.lblMaos = new System.Windows.Forms.Label();
            this.lblCervical = new System.Windows.Forms.Label();
            this.lblToracica = new System.Windows.Forms.Label();
            this.lblLombar = new System.Windows.Forms.Label();
            this.lblQuadril = new System.Windows.Forms.Label();
            this.lblJoelhos = new System.Windows.Forms.Label();
            this.lblPes = new System.Windows.Forms.Label();
            this.lblAluno = new System.Windows.Forms.Label();
            this.lblCodAluno = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblOutros = new System.Windows.Forms.Label();
            this.txtCodAluno = new Pilates.YControls.YTextBox();
            this.txtAluno = new Pilates.YControls.YTextBox();
            this.txtTitulo = new Pilates.YControls.YTextBox();
            this.txtCabeca = new Pilates.YControls.YTextBox();
            this.txtOmbro = new Pilates.YControls.YTextBox();
            this.txtEscapula = new Pilates.YControls.YTextBox();
            this.txtMaos = new Pilates.YControls.YTextBox();
            this.txtCervical = new Pilates.YControls.YTextBox();
            this.txtToracica = new Pilates.YControls.YTextBox();
            this.txtLombar = new Pilates.YControls.YTextBox();
            this.txtQuadril = new Pilates.YControls.YTextBox();
            this.txtJoelhos = new Pilates.YControls.YTextBox();
            this.txtPes = new Pilates.YControls.YTextBox();
            this.txtOutros = new Pilates.YControls.YTextBox();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(12, 19);
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(123, 788);
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(9, 789);
            // 
            // gbStatus
            // 
            this.gbStatus.Location = new System.Drawing.Point(526, 12);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(523, 801);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(15, 37);
            this.txtCodigo.Texts = "0";
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(12, 805);
            this.txtDataCadastro.Texts = "24/10/2024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(126, 804);
            this.txtDataUltAlt.Texts = "24/10/2024";
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(612, 801);
            this.btnSair.TabIndex = 13;
            // 
            // lblCabeca
            // 
            this.lblCabeca.AutoSize = true;
            this.lblCabeca.Location = new System.Drawing.Point(17, 139);
            this.lblCabeca.Name = "lblCabeca";
            this.lblCabeca.Size = new System.Drawing.Size(51, 13);
            this.lblCabeca.TabIndex = 9;
            this.lblCabeca.Text = "Cabeça*:";
            // 
            // lblOmbro
            // 
            this.lblOmbro.AutoSize = true;
            this.lblOmbro.Location = new System.Drawing.Point(16, 192);
            this.lblOmbro.Name = "lblOmbro";
            this.lblOmbro.Size = new System.Drawing.Size(45, 13);
            this.lblOmbro.TabIndex = 10;
            this.lblOmbro.Text = "Ombro*:";
            // 
            // lblEscapula
            // 
            this.lblEscapula.AutoSize = true;
            this.lblEscapula.Location = new System.Drawing.Point(15, 246);
            this.lblEscapula.Name = "lblEscapula";
            this.lblEscapula.Size = new System.Drawing.Size(58, 13);
            this.lblEscapula.TabIndex = 11;
            this.lblEscapula.Text = "Escapula*:";
            // 
            // lblMaos
            // 
            this.lblMaos.AutoSize = true;
            this.lblMaos.Location = new System.Drawing.Point(17, 302);
            this.lblMaos.Name = "lblMaos";
            this.lblMaos.Size = new System.Drawing.Size(40, 13);
            this.lblMaos.TabIndex = 12;
            this.lblMaos.Text = "Mãos*:";
            // 
            // lblCervical
            // 
            this.lblCervical.AutoSize = true;
            this.lblCervical.Location = new System.Drawing.Point(17, 359);
            this.lblCervical.Name = "lblCervical";
            this.lblCervical.Size = new System.Drawing.Size(52, 13);
            this.lblCervical.TabIndex = 13;
            this.lblCervical.Text = "Cervical*:";
            // 
            // lblToracica
            // 
            this.lblToracica.AutoSize = true;
            this.lblToracica.Location = new System.Drawing.Point(17, 416);
            this.lblToracica.Name = "lblToracica";
            this.lblToracica.Size = new System.Drawing.Size(56, 13);
            this.lblToracica.TabIndex = 14;
            this.lblToracica.Text = "Torácica*:";
            // 
            // lblLombar
            // 
            this.lblLombar.AutoSize = true;
            this.lblLombar.Location = new System.Drawing.Point(17, 472);
            this.lblLombar.Name = "lblLombar";
            this.lblLombar.Size = new System.Drawing.Size(49, 13);
            this.lblLombar.TabIndex = 15;
            this.lblLombar.Text = "Lombar*:";
            // 
            // lblQuadril
            // 
            this.lblQuadril.AutoSize = true;
            this.lblQuadril.Location = new System.Drawing.Point(17, 530);
            this.lblQuadril.Name = "lblQuadril";
            this.lblQuadril.Size = new System.Drawing.Size(47, 13);
            this.lblQuadril.TabIndex = 16;
            this.lblQuadril.Text = "Quadril*:";
            // 
            // lblJoelhos
            // 
            this.lblJoelhos.AutoSize = true;
            this.lblJoelhos.Location = new System.Drawing.Point(17, 586);
            this.lblJoelhos.Name = "lblJoelhos";
            this.lblJoelhos.Size = new System.Drawing.Size(50, 13);
            this.lblJoelhos.TabIndex = 17;
            this.lblJoelhos.Text = "Joelhos*:";
            // 
            // lblPes
            // 
            this.lblPes.AutoSize = true;
            this.lblPes.Location = new System.Drawing.Point(17, 644);
            this.lblPes.Name = "lblPes";
            this.lblPes.Size = new System.Drawing.Size(32, 13);
            this.lblPes.TabIndex = 18;
            this.lblPes.Text = "Pés*:";
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(214, 21);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(37, 13);
            this.lblAluno.TabIndex = 29;
            this.lblAluno.Text = "Aluno:";
            // 
            // lblCodAluno
            // 
            this.lblCodAluno.AutoSize = true;
            this.lblCodAluno.Location = new System.Drawing.Point(112, 21);
            this.lblCodAluno.Name = "lblCodAluno";
            this.lblCodAluno.Size = new System.Drawing.Size(73, 13);
            this.lblCodAluno.TabIndex = 32;
            this.lblCodAluno.Text = "Código Aluno:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(17, 86);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(42, 13);
            this.lblTitulo.TabIndex = 44;
            this.lblTitulo.Text = "Título:*";
            // 
            // lblOutros
            // 
            this.lblOutros.AutoSize = true;
            this.lblOutros.Location = new System.Drawing.Point(15, 704);
            this.lblOutros.Name = "lblOutros";
            this.lblOutros.Size = new System.Drawing.Size(41, 13);
            this.lblOutros.TabIndex = 45;
            this.lblOutros.Text = "Outros:";
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
            this.txtCodAluno.Enabled = false;
            this.txtCodAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCodAluno.Location = new System.Drawing.Point(115, 37);
            this.txtCodAluno.MaxLength = 32767;
            this.txtCodAluno.Multiline = false;
            this.txtCodAluno.Name = "txtCodAluno";
            this.txtCodAluno.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodAluno.PasswordChar = false;
            this.txtCodAluno.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodAluno.PlaceholderText = "";
            this.txtCodAluno.Size = new System.Drawing.Size(84, 28);
            this.txtCodAluno.TabIndex = 47;
            this.txtCodAluno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodAluno.Texts = "";
            this.txtCodAluno.UnderlinedStyle = false;
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
            this.txtAluno.Location = new System.Drawing.Point(217, 37);
            this.txtAluno.MaxLength = 32767;
            this.txtAluno.Multiline = false;
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtAluno.PasswordChar = false;
            this.txtAluno.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAluno.PlaceholderText = "";
            this.txtAluno.Size = new System.Drawing.Size(285, 28);
            this.txtAluno.TabIndex = 48;
            this.txtAluno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAluno.Texts = "";
            this.txtAluno.UnderlinedStyle = false;
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.SystemColors.Window;
            this.txtTitulo.BorderColor = System.Drawing.Color.DarkGray;
            this.txtTitulo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtTitulo.BorderRadius = 8;
            this.txtTitulo.BorderSize = 1;
            this.txtTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTitulo.DisabledBackColor = System.Drawing.Color.White;
            this.txtTitulo.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtTitulo.DisabledForeColor = System.Drawing.Color.White;
            this.txtTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtTitulo.Location = new System.Drawing.Point(20, 102);
            this.txtTitulo.MaxLength = 200;
            this.txtTitulo.Multiline = false;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtTitulo.PasswordChar = false;
            this.txtTitulo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTitulo.PlaceholderText = "";
            this.txtTitulo.Size = new System.Drawing.Size(487, 28);
            this.txtTitulo.TabIndex = 1;
            this.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTitulo.Texts = "";
            this.txtTitulo.UnderlinedStyle = false;
            // 
            // txtCabeca
            // 
            this.txtCabeca.BackColor = System.Drawing.SystemColors.Window;
            this.txtCabeca.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCabeca.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtCabeca.BorderRadius = 8;
            this.txtCabeca.BorderSize = 1;
            this.txtCabeca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCabeca.DisabledBackColor = System.Drawing.Color.White;
            this.txtCabeca.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCabeca.DisabledForeColor = System.Drawing.Color.White;
            this.txtCabeca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCabeca.Location = new System.Drawing.Point(18, 155);
            this.txtCabeca.MaxLength = 200;
            this.txtCabeca.Multiline = false;
            this.txtCabeca.Name = "txtCabeca";
            this.txtCabeca.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCabeca.PasswordChar = false;
            this.txtCabeca.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCabeca.PlaceholderText = "";
            this.txtCabeca.Size = new System.Drawing.Size(675, 28);
            this.txtCabeca.TabIndex = 2;
            this.txtCabeca.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCabeca.Texts = "";
            this.txtCabeca.UnderlinedStyle = false;
            // 
            // txtOmbro
            // 
            this.txtOmbro.BackColor = System.Drawing.SystemColors.Window;
            this.txtOmbro.BorderColor = System.Drawing.Color.DarkGray;
            this.txtOmbro.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtOmbro.BorderRadius = 8;
            this.txtOmbro.BorderSize = 1;
            this.txtOmbro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOmbro.DisabledBackColor = System.Drawing.Color.White;
            this.txtOmbro.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtOmbro.DisabledForeColor = System.Drawing.Color.White;
            this.txtOmbro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtOmbro.Location = new System.Drawing.Point(18, 208);
            this.txtOmbro.MaxLength = 200;
            this.txtOmbro.Multiline = false;
            this.txtOmbro.Name = "txtOmbro";
            this.txtOmbro.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtOmbro.PasswordChar = false;
            this.txtOmbro.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtOmbro.PlaceholderText = "";
            this.txtOmbro.Size = new System.Drawing.Size(675, 28);
            this.txtOmbro.TabIndex = 3;
            this.txtOmbro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtOmbro.Texts = "";
            this.txtOmbro.UnderlinedStyle = false;
            // 
            // txtEscapula
            // 
            this.txtEscapula.BackColor = System.Drawing.SystemColors.Window;
            this.txtEscapula.BorderColor = System.Drawing.Color.DarkGray;
            this.txtEscapula.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtEscapula.BorderRadius = 8;
            this.txtEscapula.BorderSize = 1;
            this.txtEscapula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEscapula.DisabledBackColor = System.Drawing.Color.White;
            this.txtEscapula.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtEscapula.DisabledForeColor = System.Drawing.Color.White;
            this.txtEscapula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtEscapula.Location = new System.Drawing.Point(19, 262);
            this.txtEscapula.MaxLength = 200;
            this.txtEscapula.Multiline = false;
            this.txtEscapula.Name = "txtEscapula";
            this.txtEscapula.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtEscapula.PasswordChar = false;
            this.txtEscapula.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEscapula.PlaceholderText = "";
            this.txtEscapula.Size = new System.Drawing.Size(675, 28);
            this.txtEscapula.TabIndex = 4;
            this.txtEscapula.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEscapula.Texts = "";
            this.txtEscapula.UnderlinedStyle = false;
            // 
            // txtMaos
            // 
            this.txtMaos.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaos.BorderColor = System.Drawing.Color.DarkGray;
            this.txtMaos.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtMaos.BorderRadius = 8;
            this.txtMaos.BorderSize = 1;
            this.txtMaos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaos.DisabledBackColor = System.Drawing.Color.White;
            this.txtMaos.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtMaos.DisabledForeColor = System.Drawing.Color.White;
            this.txtMaos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtMaos.Location = new System.Drawing.Point(20, 318);
            this.txtMaos.MaxLength = 200;
            this.txtMaos.Multiline = false;
            this.txtMaos.Name = "txtMaos";
            this.txtMaos.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtMaos.PasswordChar = false;
            this.txtMaos.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaos.PlaceholderText = "";
            this.txtMaos.Size = new System.Drawing.Size(675, 28);
            this.txtMaos.TabIndex = 5;
            this.txtMaos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaos.Texts = "";
            this.txtMaos.UnderlinedStyle = false;
            // 
            // txtCervical
            // 
            this.txtCervical.BackColor = System.Drawing.SystemColors.Window;
            this.txtCervical.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCervical.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtCervical.BorderRadius = 8;
            this.txtCervical.BorderSize = 1;
            this.txtCervical.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCervical.DisabledBackColor = System.Drawing.Color.White;
            this.txtCervical.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCervical.DisabledForeColor = System.Drawing.Color.White;
            this.txtCervical.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCervical.Location = new System.Drawing.Point(20, 375);
            this.txtCervical.MaxLength = 200;
            this.txtCervical.Multiline = false;
            this.txtCervical.Name = "txtCervical";
            this.txtCervical.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCervical.PasswordChar = false;
            this.txtCervical.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCervical.PlaceholderText = "";
            this.txtCervical.Size = new System.Drawing.Size(675, 28);
            this.txtCervical.TabIndex = 6;
            this.txtCervical.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCervical.Texts = "";
            this.txtCervical.UnderlinedStyle = false;
            // 
            // txtToracica
            // 
            this.txtToracica.BackColor = System.Drawing.SystemColors.Window;
            this.txtToracica.BorderColor = System.Drawing.Color.DarkGray;
            this.txtToracica.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtToracica.BorderRadius = 8;
            this.txtToracica.BorderSize = 1;
            this.txtToracica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtToracica.DisabledBackColor = System.Drawing.Color.White;
            this.txtToracica.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtToracica.DisabledForeColor = System.Drawing.Color.White;
            this.txtToracica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtToracica.Location = new System.Drawing.Point(20, 432);
            this.txtToracica.MaxLength = 200;
            this.txtToracica.Multiline = false;
            this.txtToracica.Name = "txtToracica";
            this.txtToracica.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtToracica.PasswordChar = false;
            this.txtToracica.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtToracica.PlaceholderText = "";
            this.txtToracica.Size = new System.Drawing.Size(675, 28);
            this.txtToracica.TabIndex = 7;
            this.txtToracica.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtToracica.Texts = "";
            this.txtToracica.UnderlinedStyle = false;
            // 
            // txtLombar
            // 
            this.txtLombar.BackColor = System.Drawing.SystemColors.Window;
            this.txtLombar.BorderColor = System.Drawing.Color.DarkGray;
            this.txtLombar.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtLombar.BorderRadius = 8;
            this.txtLombar.BorderSize = 1;
            this.txtLombar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLombar.DisabledBackColor = System.Drawing.Color.White;
            this.txtLombar.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtLombar.DisabledForeColor = System.Drawing.Color.White;
            this.txtLombar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtLombar.Location = new System.Drawing.Point(20, 488);
            this.txtLombar.MaxLength = 200;
            this.txtLombar.Multiline = false;
            this.txtLombar.Name = "txtLombar";
            this.txtLombar.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtLombar.PasswordChar = false;
            this.txtLombar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLombar.PlaceholderText = "";
            this.txtLombar.Size = new System.Drawing.Size(675, 28);
            this.txtLombar.TabIndex = 8;
            this.txtLombar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLombar.Texts = "";
            this.txtLombar.UnderlinedStyle = false;
            // 
            // txtQuadril
            // 
            this.txtQuadril.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuadril.BorderColor = System.Drawing.Color.DarkGray;
            this.txtQuadril.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtQuadril.BorderRadius = 8;
            this.txtQuadril.BorderSize = 1;
            this.txtQuadril.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQuadril.DisabledBackColor = System.Drawing.Color.White;
            this.txtQuadril.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtQuadril.DisabledForeColor = System.Drawing.Color.White;
            this.txtQuadril.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtQuadril.Location = new System.Drawing.Point(20, 546);
            this.txtQuadril.MaxLength = 200;
            this.txtQuadril.Multiline = false;
            this.txtQuadril.Name = "txtQuadril";
            this.txtQuadril.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtQuadril.PasswordChar = false;
            this.txtQuadril.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtQuadril.PlaceholderText = "";
            this.txtQuadril.Size = new System.Drawing.Size(675, 28);
            this.txtQuadril.TabIndex = 9;
            this.txtQuadril.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQuadril.Texts = "";
            this.txtQuadril.UnderlinedStyle = false;
            // 
            // txtJoelhos
            // 
            this.txtJoelhos.BackColor = System.Drawing.SystemColors.Window;
            this.txtJoelhos.BorderColor = System.Drawing.Color.DarkGray;
            this.txtJoelhos.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtJoelhos.BorderRadius = 8;
            this.txtJoelhos.BorderSize = 1;
            this.txtJoelhos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtJoelhos.DisabledBackColor = System.Drawing.Color.White;
            this.txtJoelhos.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtJoelhos.DisabledForeColor = System.Drawing.Color.White;
            this.txtJoelhos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtJoelhos.Location = new System.Drawing.Point(19, 602);
            this.txtJoelhos.MaxLength = 200;
            this.txtJoelhos.Multiline = false;
            this.txtJoelhos.Name = "txtJoelhos";
            this.txtJoelhos.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtJoelhos.PasswordChar = false;
            this.txtJoelhos.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtJoelhos.PlaceholderText = "";
            this.txtJoelhos.Size = new System.Drawing.Size(675, 28);
            this.txtJoelhos.TabIndex = 10;
            this.txtJoelhos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtJoelhos.Texts = "";
            this.txtJoelhos.UnderlinedStyle = false;
            // 
            // txtPes
            // 
            this.txtPes.BackColor = System.Drawing.SystemColors.Window;
            this.txtPes.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPes.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtPes.BorderRadius = 8;
            this.txtPes.BorderSize = 1;
            this.txtPes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPes.DisabledBackColor = System.Drawing.Color.White;
            this.txtPes.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtPes.DisabledForeColor = System.Drawing.Color.White;
            this.txtPes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtPes.Location = new System.Drawing.Point(20, 660);
            this.txtPes.MaxLength = 200;
            this.txtPes.Multiline = false;
            this.txtPes.Name = "txtPes";
            this.txtPes.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtPes.PasswordChar = false;
            this.txtPes.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPes.PlaceholderText = "";
            this.txtPes.Size = new System.Drawing.Size(675, 28);
            this.txtPes.TabIndex = 11;
            this.txtPes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPes.Texts = "";
            this.txtPes.UnderlinedStyle = false;
            // 
            // txtOutros
            // 
            this.txtOutros.BackColor = System.Drawing.SystemColors.Window;
            this.txtOutros.BorderColor = System.Drawing.Color.DarkGray;
            this.txtOutros.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtOutros.BorderRadius = 8;
            this.txtOutros.BorderSize = 1;
            this.txtOutros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOutros.DisabledBackColor = System.Drawing.Color.White;
            this.txtOutros.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtOutros.DisabledForeColor = System.Drawing.Color.White;
            this.txtOutros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtOutros.Location = new System.Drawing.Point(16, 720);
            this.txtOutros.MaxLength = 200;
            this.txtOutros.Multiline = true;
            this.txtOutros.Name = "txtOutros";
            this.txtOutros.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtOutros.PasswordChar = false;
            this.txtOutros.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtOutros.PlaceholderText = "";
            this.txtOutros.Size = new System.Drawing.Size(679, 55);
            this.txtOutros.TabIndex = 12;
            this.txtOutros.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtOutros.Texts = "";
            this.txtOutros.UnderlinedStyle = false;
            // 
            // CadastroPostura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(714, 853);
            this.Controls.Add(this.txtOutros);
            this.Controls.Add(this.txtPes);
            this.Controls.Add(this.txtJoelhos);
            this.Controls.Add(this.txtQuadril);
            this.Controls.Add(this.txtLombar);
            this.Controls.Add(this.txtToracica);
            this.Controls.Add(this.txtCervical);
            this.Controls.Add(this.txtMaos);
            this.Controls.Add(this.txtEscapula);
            this.Controls.Add(this.txtOmbro);
            this.Controls.Add(this.txtCabeca);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtAluno);
            this.Controls.Add(this.txtCodAluno);
            this.Controls.Add(this.lblOutros);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCodAluno);
            this.Controls.Add(this.lblAluno);
            this.Controls.Add(this.lblPes);
            this.Controls.Add(this.lblJoelhos);
            this.Controls.Add(this.lblQuadril);
            this.Controls.Add(this.lblLombar);
            this.Controls.Add(this.lblToracica);
            this.Controls.Add(this.lblCervical);
            this.Controls.Add(this.lblMaos);
            this.Controls.Add(this.lblEscapula);
            this.Controls.Add(this.lblOmbro);
            this.Controls.Add(this.lblCabeca);
            this.Name = "CadastroPostura";
            this.Text = "Cadastro de Postura";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroPostura_FormClosed);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.gbStatus, 0);
            this.Controls.SetChildIndex(this.lblCabeca, 0);
            this.Controls.SetChildIndex(this.lblOmbro, 0);
            this.Controls.SetChildIndex(this.lblEscapula, 0);
            this.Controls.SetChildIndex(this.lblMaos, 0);
            this.Controls.SetChildIndex(this.lblCervical, 0);
            this.Controls.SetChildIndex(this.lblToracica, 0);
            this.Controls.SetChildIndex(this.lblLombar, 0);
            this.Controls.SetChildIndex(this.lblQuadril, 0);
            this.Controls.SetChildIndex(this.lblJoelhos, 0);
            this.Controls.SetChildIndex(this.lblPes, 0);
            this.Controls.SetChildIndex(this.lblAluno, 0);
            this.Controls.SetChildIndex(this.lblCodAluno, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.lblOutros, 0);
            this.Controls.SetChildIndex(this.txtCodAluno, 0);
            this.Controls.SetChildIndex(this.txtAluno, 0);
            this.Controls.SetChildIndex(this.txtTitulo, 0);
            this.Controls.SetChildIndex(this.txtCabeca, 0);
            this.Controls.SetChildIndex(this.txtOmbro, 0);
            this.Controls.SetChildIndex(this.txtEscapula, 0);
            this.Controls.SetChildIndex(this.txtMaos, 0);
            this.Controls.SetChildIndex(this.txtCervical, 0);
            this.Controls.SetChildIndex(this.txtToracica, 0);
            this.Controls.SetChildIndex(this.txtLombar, 0);
            this.Controls.SetChildIndex(this.txtQuadril, 0);
            this.Controls.SetChildIndex(this.txtJoelhos, 0);
            this.Controls.SetChildIndex(this.txtPes, 0);
            this.Controls.SetChildIndex(this.txtOutros, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCabeca;
        private System.Windows.Forms.Label lblOmbro;
        private System.Windows.Forms.Label lblEscapula;
        private System.Windows.Forms.Label lblMaos;
        private System.Windows.Forms.Label lblCervical;
        private System.Windows.Forms.Label lblToracica;
        private System.Windows.Forms.Label lblLombar;
        private System.Windows.Forms.Label lblQuadril;
        private System.Windows.Forms.Label lblJoelhos;
        private System.Windows.Forms.Label lblPes;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.Label lblCodAluno;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblOutros;
        private YControls.YTextBox txtCodAluno;
        private YControls.YTextBox txtAluno;
        private YControls.YTextBox txtTitulo;
        private YControls.YTextBox txtCabeca;
        private YControls.YTextBox txtOmbro;
        private YControls.YTextBox txtEscapula;
        private YControls.YTextBox txtMaos;
        private YControls.YTextBox txtCervical;
        private YControls.YTextBox txtToracica;
        private YControls.YTextBox txtLombar;
        private YControls.YTextBox txtQuadril;
        private YControls.YTextBox txtJoelhos;
        private YControls.YTextBox txtPes;
        private YControls.YTextBox txtOutros;
    }
}
