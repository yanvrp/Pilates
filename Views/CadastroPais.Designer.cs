namespace Pilates.Views
{
    partial class CadastroPais
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
            this.lblPais = new System.Windows.Forms.Label();
            this.lblDDI = new System.Windows.Forms.Label();
            this.lblSigla = new System.Windows.Forms.Label();
            this.txtPais = new Pilates.YControls.YTextBox();
            this.txtDDI = new Pilates.YControls.YTextBox();
            this.txtSigla = new Pilates.YControls.YTextBox();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(22, 19);
            // 
            // gbStatus
            // 
            this.gbStatus.Location = new System.Drawing.Point(273, 19);
            this.gbStatus.TabIndex = 6;
            // 
            // rbInativo
            // 
            this.rbInativo.TabIndex = 8;
            // 
            // rbAtivo
            // 
            this.rbAtivo.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(266, 405);
            this.btnSalvar.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Texts = "0";
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Texts = "24/10/2024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Texts = "24/10/2024";
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(355, 405);
            this.btnSair.TabIndex = 5;
            // 
            // txtUsuarioUltAlt
            // 
            this.txtUsuarioUltAlt.Location = new System.Drawing.Point(23, 363);
            // 
            // lblUsuarioUltAlt
            // 
            this.lblUsuarioUltAlt.Location = new System.Drawing.Point(20, 347);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(22, 88);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(36, 13);
            this.lblPais.TabIndex = 9;
            this.lblPais.Text = "País:*";
            // 
            // lblDDI
            // 
            this.lblDDI.AutoSize = true;
            this.lblDDI.Location = new System.Drawing.Point(20, 159);
            this.lblDDI.Name = "lblDDI";
            this.lblDDI.Size = new System.Drawing.Size(33, 13);
            this.lblDDI.TabIndex = 11;
            this.lblDDI.Text = "DDI:*";
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Location = new System.Drawing.Point(20, 228);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(37, 13);
            this.lblSigla.TabIndex = 13;
            this.lblSigla.Text = "Sigla:*";
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
            this.txtPais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtPais.Location = new System.Drawing.Point(25, 104);
            this.txtPais.MaxLength = 100;
            this.txtPais.Multiline = false;
            this.txtPais.Name = "txtPais";
            this.txtPais.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtPais.PasswordChar = false;
            this.txtPais.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPais.PlaceholderText = "";
            this.txtPais.Size = new System.Drawing.Size(413, 28);
            this.txtPais.TabIndex = 1;
            this.txtPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPais.Texts = "";
            this.txtPais.UnderlinedStyle = false;
            this.txtPais.Leave += new System.EventHandler(this.txtPais_Leave);
            // 
            // txtDDI
            // 
            this.txtDDI.BackColor = System.Drawing.SystemColors.Window;
            this.txtDDI.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDDI.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtDDI.BorderRadius = 8;
            this.txtDDI.BorderSize = 1;
            this.txtDDI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDDI.DisabledBackColor = System.Drawing.Color.White;
            this.txtDDI.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtDDI.DisabledForeColor = System.Drawing.Color.White;
            this.txtDDI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDDI.Location = new System.Drawing.Point(23, 175);
            this.txtDDI.MaxLength = 5;
            this.txtDDI.Multiline = false;
            this.txtDDI.Name = "txtDDI";
            this.txtDDI.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDDI.PasswordChar = false;
            this.txtDDI.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDDI.PlaceholderText = "";
            this.txtDDI.Size = new System.Drawing.Size(84, 28);
            this.txtDDI.TabIndex = 2;
            this.txtDDI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDDI.Texts = "";
            this.txtDDI.UnderlinedStyle = false;
            this.txtDDI.Leave += new System.EventHandler(this.txtDDI_Leave);
            // 
            // txtSigla
            // 
            this.txtSigla.BackColor = System.Drawing.SystemColors.Window;
            this.txtSigla.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSigla.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtSigla.BorderRadius = 8;
            this.txtSigla.BorderSize = 1;
            this.txtSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSigla.DisabledBackColor = System.Drawing.Color.White;
            this.txtSigla.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtSigla.DisabledForeColor = System.Drawing.Color.White;
            this.txtSigla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtSigla.Location = new System.Drawing.Point(23, 244);
            this.txtSigla.MaxLength = 5;
            this.txtSigla.Multiline = false;
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtSigla.PasswordChar = false;
            this.txtSigla.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSigla.PlaceholderText = "";
            this.txtSigla.Size = new System.Drawing.Size(188, 28);
            this.txtSigla.TabIndex = 3;
            this.txtSigla.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSigla.Texts = "";
            this.txtSigla.UnderlinedStyle = false;
            this.txtSigla.Leave += new System.EventHandler(this.txtSigla_Leave);
            // 
            // CadastroPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(461, 450);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.txtDDI);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.lblSigla);
            this.Controls.Add(this.lblDDI);
            this.Controls.Add(this.lblPais);
            this.Name = "CadastroPais";
            this.Text = "Cadastro de País";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroPais_FormClosed);
            this.Load += new System.EventHandler(this.CadastroPais_Load);
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
            this.Controls.SetChildIndex(this.lblPais, 0);
            this.Controls.SetChildIndex(this.lblDDI, 0);
            this.Controls.SetChildIndex(this.lblSigla, 0);
            this.Controls.SetChildIndex(this.txtPais, 0);
            this.Controls.SetChildIndex(this.txtDDI, 0);
            this.Controls.SetChildIndex(this.txtSigla, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblDDI;
        private System.Windows.Forms.Label lblSigla;
        private YControls.YTextBox txtPais;
        private YControls.YTextBox txtDDI;
        private YControls.YTextBox txtSigla;
    }
}
