namespace Pilates.Views
{
    partial class CadastroGestacao
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
            this.lblGestacao = new System.Windows.Forms.Label();
            this.txtGestacao = new Pilates.YControls.YTextBox();
            this.txtDescricao = new Pilates.YControls.YTextBox();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbStatus
            // 
            this.gbStatus.Location = new System.Drawing.Point(291, 19);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(278, 405);
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
            this.btnSair.Location = new System.Drawing.Point(367, 405);
            this.btnSair.TabIndex = 4;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(20, 150);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(62, 13);
            this.lblDescricao.TabIndex = 19;
            this.lblDescricao.Text = "Descrição:*";
            // 
            // lblGestacao
            // 
            this.lblGestacao.AutoSize = true;
            this.lblGestacao.Location = new System.Drawing.Point(20, 84);
            this.lblGestacao.Name = "lblGestacao";
            this.lblGestacao.Size = new System.Drawing.Size(60, 13);
            this.lblGestacao.TabIndex = 17;
            this.lblGestacao.Text = "Gestação:*";
            // 
            // txtGestacao
            // 
            this.txtGestacao.BackColor = System.Drawing.SystemColors.Window;
            this.txtGestacao.BorderColor = System.Drawing.Color.DarkGray;
            this.txtGestacao.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtGestacao.BorderRadius = 8;
            this.txtGestacao.BorderSize = 1;
            this.txtGestacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGestacao.DisabledBackColor = System.Drawing.Color.White;
            this.txtGestacao.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtGestacao.DisabledForeColor = System.Drawing.Color.White;
            this.txtGestacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtGestacao.Location = new System.Drawing.Point(23, 100);
            this.txtGestacao.MaxLength = 100;
            this.txtGestacao.Multiline = false;
            this.txtGestacao.Name = "txtGestacao";
            this.txtGestacao.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtGestacao.PasswordChar = false;
            this.txtGestacao.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGestacao.PlaceholderText = "";
            this.txtGestacao.Size = new System.Drawing.Size(433, 28);
            this.txtGestacao.TabIndex = 1;
            this.txtGestacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtGestacao.Texts = "";
            this.txtGestacao.UnderlinedStyle = false;
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
            this.txtDescricao.Location = new System.Drawing.Point(23, 166);
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
            // CadastroGestacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtGestacao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblGestacao);
            this.Name = "CadastroGestacao";
            this.Text = "Cadastro de Gestação";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroGestacao_FormClosed);
            this.Load += new System.EventHandler(this.CadastroGestacao_Load);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.gbStatus, 0);
            this.Controls.SetChildIndex(this.lblGestacao, 0);
            this.Controls.SetChildIndex(this.lblDescricao, 0);
            this.Controls.SetChildIndex(this.txtGestacao, 0);
            this.Controls.SetChildIndex(this.txtDescricao, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblGestacao;
        private YControls.YTextBox txtGestacao;
        private YControls.YTextBox txtDescricao;
    }
}
