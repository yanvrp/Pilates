namespace Pilates.Views
{
    partial class CadastroEstado
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
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblCodigoPais = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtEstado = new Pilates.YControls.YTextBox();
            this.txtUF = new Pilates.YControls.YTextBox();
            this.txtCodigoPais = new Pilates.YControls.YTextBox();
            this.txtPais = new Pilates.YControls.YTextBox();
            this.btnBuscarPais = new Pilates.YControls.YButton();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbStatus
            // 
            this.gbStatus.Location = new System.Drawing.Point(271, 12);
            this.gbStatus.TabIndex = 7;
            // 
            // rbInativo
            // 
            this.rbInativo.TabIndex = 9;
            // 
            // rbAtivo
            // 
            this.rbAtivo.TabIndex = 8;
            this.rbAtivo.CheckedChanged += new System.EventHandler(this.rbAtivo_CheckedChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(264, 405);
            this.btnSalvar.TabIndex = 6;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Texts = "0";
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Size = new System.Drawing.Size(92, 27);
            this.txtDataCadastro.Texts = "24/10/2024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Texts = "24/10/2024";
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(353, 405);
            this.btnSair.TabIndex = 7;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(20, 86);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(47, 13);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado:*";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(20, 160);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(28, 13);
            this.lblUF.TabIndex = 10;
            this.lblUF.Text = "UF:*";
            // 
            // lblCodigoPais
            // 
            this.lblCodigoPais.AutoSize = true;
            this.lblCodigoPais.Location = new System.Drawing.Point(20, 231);
            this.lblCodigoPais.Name = "lblCodigoPais";
            this.lblCodigoPais.Size = new System.Drawing.Size(72, 13);
            this.lblCodigoPais.TabIndex = 13;
            this.lblCodigoPais.Text = "Código País:*";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(179, 231);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(36, 13);
            this.lblPais.TabIndex = 15;
            this.lblPais.Text = "País:*";
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.SystemColors.Window;
            this.txtEstado.BorderColor = System.Drawing.Color.DarkGray;
            this.txtEstado.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtEstado.BorderRadius = 8;
            this.txtEstado.BorderSize = 1;
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.DisabledBackColor = System.Drawing.Color.White;
            this.txtEstado.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtEstado.DisabledForeColor = System.Drawing.Color.White;
            this.txtEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtEstado.Location = new System.Drawing.Point(23, 102);
            this.txtEstado.MaxLength = 32767;
            this.txtEstado.Multiline = false;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtEstado.PasswordChar = false;
            this.txtEstado.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEstado.PlaceholderText = "";
            this.txtEstado.Size = new System.Drawing.Size(413, 28);
            this.txtEstado.TabIndex = 16;
            this.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEstado.Texts = "";
            this.txtEstado.UnderlinedStyle = false;
            this.txtEstado.Leave += new System.EventHandler(this.txtEstado_Leave);
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
            this.txtUF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtUF.Location = new System.Drawing.Point(23, 176);
            this.txtUF.MaxLength = 32767;
            this.txtUF.Multiline = false;
            this.txtUF.Name = "txtUF";
            this.txtUF.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtUF.PasswordChar = false;
            this.txtUF.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUF.PlaceholderText = "";
            this.txtUF.Size = new System.Drawing.Size(84, 28);
            this.txtUF.TabIndex = 17;
            this.txtUF.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUF.Texts = "";
            this.txtUF.UnderlinedStyle = false;
            this.txtUF.Leave += new System.EventHandler(this.txtUF_Leave);
            // 
            // txtCodigoPais
            // 
            this.txtCodigoPais.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigoPais.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCodigoPais.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtCodigoPais.BorderRadius = 8;
            this.txtCodigoPais.BorderSize = 1;
            this.txtCodigoPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoPais.DisabledBackColor = System.Drawing.Color.White;
            this.txtCodigoPais.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCodigoPais.DisabledForeColor = System.Drawing.Color.White;
            this.txtCodigoPais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCodigoPais.Location = new System.Drawing.Point(23, 247);
            this.txtCodigoPais.MaxLength = 32767;
            this.txtCodigoPais.Multiline = false;
            this.txtCodigoPais.Name = "txtCodigoPais";
            this.txtCodigoPais.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodigoPais.PasswordChar = false;
            this.txtCodigoPais.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodigoPais.PlaceholderText = "";
            this.txtCodigoPais.Size = new System.Drawing.Size(84, 28);
            this.txtCodigoPais.TabIndex = 18;
            this.txtCodigoPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodigoPais.Texts = "";
            this.txtCodigoPais.UnderlinedStyle = false;
            this.txtCodigoPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoPais_KeyPress);
            this.txtCodigoPais.Leave += new System.EventHandler(this.txtCodigoPais_Leave);
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
            this.txtPais.Location = new System.Drawing.Point(182, 247);
            this.txtPais.MaxLength = 32767;
            this.txtPais.Multiline = false;
            this.txtPais.Name = "txtPais";
            this.txtPais.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtPais.PasswordChar = false;
            this.txtPais.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPais.PlaceholderText = "";
            this.txtPais.Size = new System.Drawing.Size(254, 28);
            this.txtPais.TabIndex = 19;
            this.txtPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPais.Texts = "";
            this.txtPais.UnderlinedStyle = false;
            // 
            // btnBuscarPais
            // 
            this.btnBuscarPais.BackColor = System.Drawing.Color.GhostWhite;
            this.btnBuscarPais.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnBuscarPais.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btnBuscarPais.BorderRadius = 8;
            this.btnBuscarPais.BorderSize = 1;
            this.btnBuscarPais.FlatAppearance.BorderSize = 0;
            this.btnBuscarPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPais.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnBuscarPais.Location = new System.Drawing.Point(113, 246);
            this.btnBuscarPais.Name = "btnBuscarPais";
            this.btnBuscarPais.Size = new System.Drawing.Size(61, 31);
            this.btnBuscarPais.TabIndex = 20;
            this.btnBuscarPais.Text = "Buscar";
            this.btnBuscarPais.TextColor = System.Drawing.Color.DarkViolet;
            this.btnBuscarPais.UseVisualStyleBackColor = false;
            this.btnBuscarPais.Click += new System.EventHandler(this.btnBuscarPais_Click);
            // 
            // CadastroEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(462, 450);
            this.Controls.Add(this.btnBuscarPais);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtCodigoPais);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblCodigoPais);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.lblEstado);
            this.Name = "CadastroEstado";
            this.Text = "Cadastro de Estado";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroEstado_FormClosed);
            this.Load += new System.EventHandler(this.CadastroEstado_Load);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.gbStatus, 0);
            this.Controls.SetChildIndex(this.lblEstado, 0);
            this.Controls.SetChildIndex(this.lblUF, 0);
            this.Controls.SetChildIndex(this.lblCodigoPais, 0);
            this.Controls.SetChildIndex(this.lblPais, 0);
            this.Controls.SetChildIndex(this.txtEstado, 0);
            this.Controls.SetChildIndex(this.txtUF, 0);
            this.Controls.SetChildIndex(this.txtCodigoPais, 0);
            this.Controls.SetChildIndex(this.txtPais, 0);
            this.Controls.SetChildIndex(this.btnBuscarPais, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblCodigoPais;
        private System.Windows.Forms.Label lblPais;
        private YControls.YTextBox txtEstado;
        private YControls.YTextBox txtUF;
        private YControls.YTextBox txtCodigoPais;
        private YControls.YTextBox txtPais;
        protected YControls.YButton btnBuscarPais;
    }
}
