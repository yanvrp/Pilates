namespace Pilates.Views
{
    partial class CadastroDores
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
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblDores = new System.Windows.Forms.Label();
            this.txtDores = new Pilates.YControls.YTextBox();
            this.txtDescricao = new Pilates.YControls.YTextBox();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbStatus
            // 
            this.gbStatus.Location = new System.Drawing.Point(293, 12);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(285, 405);
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
            this.btnSair.Location = new System.Drawing.Point(375, 405);
            this.btnSair.TabIndex = 4;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(20, 158);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(62, 13);
            this.lblDescricao.TabIndex = 19;
            this.lblDescricao.Text = "Descrição:*";
            // 
            // lblDores
            // 
            this.lblDores.AutoSize = true;
            this.lblDores.Location = new System.Drawing.Point(20, 85);
            this.lblDores.Name = "lblDores";
            this.lblDores.Size = new System.Drawing.Size(42, 13);
            this.lblDores.TabIndex = 17;
            this.lblDores.Text = "Dores:*";
            // 
            // txtDores
            // 
            this.txtDores.BackColor = System.Drawing.SystemColors.Window;
            this.txtDores.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDores.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtDores.BorderRadius = 8;
            this.txtDores.BorderSize = 1;
            this.txtDores.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDores.DisabledBackColor = System.Drawing.Color.White;
            this.txtDores.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtDores.DisabledForeColor = System.Drawing.Color.White;
            this.txtDores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDores.Location = new System.Drawing.Point(23, 101);
            this.txtDores.MaxLength = 100;
            this.txtDores.Multiline = false;
            this.txtDores.Name = "txtDores";
            this.txtDores.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDores.PasswordChar = false;
            this.txtDores.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDores.PlaceholderText = "";
            this.txtDores.Size = new System.Drawing.Size(435, 28);
            this.txtDores.TabIndex = 1;
            this.txtDores.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDores.Texts = "";
            this.txtDores.UnderlinedStyle = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescricao.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDescricao.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtDescricao.BorderRadius = 8;
            this.txtDescricao.BorderSize = 1;
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.DisabledBackColor = System.Drawing.Color.White;
            this.txtDescricao.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtDescricao.DisabledForeColor = System.Drawing.Color.White;
            this.txtDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDescricao.Location = new System.Drawing.Point(23, 174);
            this.txtDescricao.MaxLength = 200;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDescricao.PasswordChar = false;
            this.txtDescricao.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDescricao.PlaceholderText = "";
            this.txtDescricao.Size = new System.Drawing.Size(433, 107);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescricao.Texts = "";
            this.txtDescricao.UnderlinedStyle = false;
            // 
            // CadastroDores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtDores);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblDores);
            this.Name = "CadastroDores";
            this.Text = "Cadastro de Dores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroDores_FormClosed);
            this.Load += new System.EventHandler(this.CadastroDores_Load);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.gbStatus, 0);
            this.Controls.SetChildIndex(this.lblDores, 0);
            this.Controls.SetChildIndex(this.lblDescricao, 0);
            this.Controls.SetChildIndex(this.txtDores, 0);
            this.Controls.SetChildIndex(this.txtDescricao, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblDores;
        private YControls.YTextBox txtDores;
        private YControls.YTextBox txtDescricao;
    }
}
