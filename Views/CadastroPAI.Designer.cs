namespace Pilates.Views
{
    partial class CadastroPAI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDataUltAlt = new System.Windows.Forms.Label();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.txtCodigo = new Pilates.YControls.YTextBox();
            this.btnSalvar = new Pilates.YControls.YButton();
            this.btnSair = new Pilates.YControls.YButton();
            this.txtDataCadastro = new Pilates.YControls.YMaskedTextBox();
            this.txtDataUltAlt = new Pilates.YControls.YMaskedTextBox();
            this.txtUsuarioUltAlt = new Pilates.YControls.YTextBox();
            this.lblUsuarioUltAlt = new System.Windows.Forms.Label();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(20, 19);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.AutoSize = true;
            this.lblDataUltAlt.Location = new System.Drawing.Point(118, 396);
            this.lblDataUltAlt.Name = "lblDataUltAlt";
            this.lblDataUltAlt.Size = new System.Drawing.Size(73, 13);
            this.lblDataUltAlt.TabIndex = 6;
            this.lblDataUltAlt.Text = "Data Ult. Alt. :";
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Location = new System.Drawing.Point(20, 394);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(78, 13);
            this.lblDataCadastro.TabIndex = 7;
            this.lblDataCadastro.Text = "Data Cadastro:";
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Location = new System.Drawing.Point(334, 12);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(165, 58);
            this.gbStatus.TabIndex = 8;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(90, 26);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(57, 17);
            this.rbInativo.TabIndex = 1;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            this.rbInativo.CheckedChanged += new System.EventHandler(this.rbInativo_CheckedChanged);
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Checked = true;
            this.rbAtivo.Location = new System.Drawing.Point(19, 26);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(49, 17);
            this.rbAtivo.TabIndex = 0;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            this.rbAtivo.CheckedChanged += new System.EventHandler(this.rbAtivo_CheckedChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigo.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCodigo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtCodigo.BorderRadius = 8;
            this.txtCodigo.BorderSize = 1;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.DisabledBackColor = System.Drawing.Color.White;
            this.txtCodigo.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCodigo.DisabledForeColor = System.Drawing.Color.White;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCodigo.Location = new System.Drawing.Point(23, 35);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodigo.PasswordChar = false;
            this.txtCodigo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodigo.PlaceholderText = "";
            this.txtCodigo.Size = new System.Drawing.Size(84, 28);
            this.txtCodigo.TabIndex = 13;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodigo.Texts = "";
            this.txtCodigo.UnderlinedStyle = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.DarkViolet;
            this.btnSalvar.BackgroundColor = System.Drawing.Color.DarkViolet;
            this.btnSalvar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btnSalvar.BorderRadius = 8;
            this.btnSalvar.BorderSize = 1;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(327, 406);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(83, 31);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextColor = System.Drawing.Color.White;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSair.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnSair.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btnSair.BorderRadius = 8;
            this.btnSair.BorderSize = 1;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnSair.Location = new System.Drawing.Point(416, 406);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(83, 31);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.TextColor = System.Drawing.Color.DarkViolet;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataCadastro.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDataCadastro.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtDataCadastro.BorderRadius = 8;
            this.txtDataCadastro.BorderSize = 1;
            this.txtDataCadastro.DisabledBackColor = System.Drawing.Color.White;
            this.txtDataCadastro.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtDataCadastro.DisabledForeColor = System.Drawing.Color.White;
            this.txtDataCadastro.Enabled = false;
            this.txtDataCadastro.EnabledBackColor = System.Drawing.Color.White;
            this.txtDataCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDataCadastro.Location = new System.Drawing.Point(23, 410);
            this.txtDataCadastro.Mask = "00/00/0000";
            this.txtDataCadastro.MaxLength = 32767;
            this.txtDataCadastro.Multiline = false;
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDataCadastro.PasswordChar = false;
            this.txtDataCadastro.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDataCadastro.PlaceholderText = "";
            this.txtDataCadastro.Size = new System.Drawing.Size(92, 27);
            this.txtDataCadastro.TabIndex = 14;
            this.txtDataCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataCadastro.Texts = "  /  /";
            this.txtDataCadastro.UnderlinedStyle = false;
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataUltAlt.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDataUltAlt.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtDataUltAlt.BorderRadius = 8;
            this.txtDataUltAlt.BorderSize = 1;
            this.txtDataUltAlt.DisabledBackColor = System.Drawing.Color.White;
            this.txtDataUltAlt.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtDataUltAlt.DisabledForeColor = System.Drawing.Color.White;
            this.txtDataUltAlt.Enabled = false;
            this.txtDataUltAlt.EnabledBackColor = System.Drawing.Color.White;
            this.txtDataUltAlt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDataUltAlt.Location = new System.Drawing.Point(121, 410);
            this.txtDataUltAlt.Mask = "00/00/0000";
            this.txtDataUltAlt.MaxLength = 32767;
            this.txtDataUltAlt.Multiline = false;
            this.txtDataUltAlt.Name = "txtDataUltAlt";
            this.txtDataUltAlt.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDataUltAlt.PasswordChar = false;
            this.txtDataUltAlt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDataUltAlt.PlaceholderText = "";
            this.txtDataUltAlt.Size = new System.Drawing.Size(92, 27);
            this.txtDataUltAlt.TabIndex = 15;
            this.txtDataUltAlt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataUltAlt.Texts = "  /  /";
            this.txtDataUltAlt.UnderlinedStyle = false;
            // 
            // txtUsuarioUltAlt
            // 
            this.txtUsuarioUltAlt.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsuarioUltAlt.BorderColor = System.Drawing.Color.DarkGray;
            this.txtUsuarioUltAlt.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtUsuarioUltAlt.BorderRadius = 8;
            this.txtUsuarioUltAlt.BorderSize = 1;
            this.txtUsuarioUltAlt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuarioUltAlt.DisabledBackColor = System.Drawing.Color.White;
            this.txtUsuarioUltAlt.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtUsuarioUltAlt.DisabledForeColor = System.Drawing.Color.White;
            this.txtUsuarioUltAlt.Enabled = false;
            this.txtUsuarioUltAlt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtUsuarioUltAlt.Location = new System.Drawing.Point(219, 410);
            this.txtUsuarioUltAlt.MaxLength = 32767;
            this.txtUsuarioUltAlt.Multiline = false;
            this.txtUsuarioUltAlt.Name = "txtUsuarioUltAlt";
            this.txtUsuarioUltAlt.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtUsuarioUltAlt.PasswordChar = false;
            this.txtUsuarioUltAlt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsuarioUltAlt.PlaceholderText = "";
            this.txtUsuarioUltAlt.Size = new System.Drawing.Size(84, 28);
            this.txtUsuarioUltAlt.TabIndex = 17;
            this.txtUsuarioUltAlt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuarioUltAlt.Texts = "";
            this.txtUsuarioUltAlt.UnderlinedStyle = false;
            // 
            // lblUsuarioUltAlt
            // 
            this.lblUsuarioUltAlt.AutoSize = true;
            this.lblUsuarioUltAlt.Location = new System.Drawing.Point(216, 394);
            this.lblUsuarioUltAlt.Name = "lblUsuarioUltAlt";
            this.lblUsuarioUltAlt.Size = new System.Drawing.Size(83, 13);
            this.lblUsuarioUltAlt.TabIndex = 16;
            this.lblUsuarioUltAlt.Text = "Usuário Ult. Alt.:";
            // 
            // CadastroPAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.txtUsuarioUltAlt);
            this.Controls.Add(this.lblUsuarioUltAlt);
            this.Controls.Add(this.txtDataUltAlt);
            this.Controls.Add(this.txtDataCadastro);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.lblDataCadastro);
            this.Controls.Add(this.lblDataUltAlt);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CadastroPAI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroPAI";
            this.Load += new System.EventHandler(this.CadastroPAI_Load);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label lblCodigo;
        protected System.Windows.Forms.Label lblDataUltAlt;
        protected System.Windows.Forms.Label lblDataCadastro;
        protected System.Windows.Forms.GroupBox gbStatus;
        protected System.Windows.Forms.RadioButton rbInativo;
        protected System.Windows.Forms.RadioButton rbAtivo;
        protected YControls.YButton btnSalvar;
        protected YControls.YTextBox txtCodigo;
        protected YControls.YMaskedTextBox txtDataCadastro;
        protected YControls.YMaskedTextBox txtDataUltAlt;
        protected YControls.YButton btnSair;
        protected YControls.YTextBox txtUsuarioUltAlt;
        protected System.Windows.Forms.Label lblUsuarioUltAlt;
    }
}