namespace Pilates.Views
{
    partial class CadastroProfissao
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
            this.lblProfissao = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtProfissao = new Pilates.YControls.YTextBox();
            this.txtDescricao = new Pilates.YControls.YTextBox();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbStatus
            // 
            this.gbStatus.Location = new System.Drawing.Point(290, 19);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(283, 404);
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
            this.btnSair.Location = new System.Drawing.Point(372, 405);
            this.btnSair.TabIndex = 4;
            // 
            // lblProfissao
            // 
            this.lblProfissao.AutoSize = true;
            this.lblProfissao.Location = new System.Drawing.Point(20, 86);
            this.lblProfissao.Name = "lblProfissao";
            this.lblProfissao.Size = new System.Drawing.Size(57, 13);
            this.lblProfissao.TabIndex = 9;
            this.lblProfissao.Text = "Profissão:*";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(20, 155);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(62, 13);
            this.lblDescricao.TabIndex = 11;
            this.lblDescricao.Text = "Descrição:*";
            // 
            // txtProfissao
            // 
            this.txtProfissao.BackColor = System.Drawing.SystemColors.Window;
            this.txtProfissao.BorderColor = System.Drawing.Color.DarkGray;
            this.txtProfissao.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtProfissao.BorderRadius = 8;
            this.txtProfissao.BorderSize = 1;
            this.txtProfissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProfissao.DisabledBackColor = System.Drawing.Color.White;
            this.txtProfissao.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtProfissao.DisabledForeColor = System.Drawing.Color.White;
            this.txtProfissao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtProfissao.Location = new System.Drawing.Point(23, 102);
            this.txtProfissao.MaxLength = 32767;
            this.txtProfissao.Multiline = false;
            this.txtProfissao.Name = "txtProfissao";
            this.txtProfissao.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtProfissao.PasswordChar = false;
            this.txtProfissao.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtProfissao.PlaceholderText = "";
            this.txtProfissao.Size = new System.Drawing.Size(432, 28);
            this.txtProfissao.TabIndex = 16;
            this.txtProfissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProfissao.Texts = "";
            this.txtProfissao.UnderlinedStyle = false;
            this.txtProfissao.Leave += new System.EventHandler(this.txtProfissao_Leave);
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
            this.txtDescricao.Location = new System.Drawing.Point(23, 171);
            this.txtDescricao.MaxLength = 32767;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDescricao.PasswordChar = false;
            this.txtDescricao.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDescricao.PlaceholderText = "";
            this.txtDescricao.Size = new System.Drawing.Size(432, 107);
            this.txtDescricao.TabIndex = 17;
            this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescricao.Texts = "";
            this.txtDescricao.UnderlinedStyle = false;
            // 
            // CadastroProfissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtProfissao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblProfissao);
            this.Name = "CadastroProfissao";
            this.Text = "Cadastro de Profissão";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroProfissao_FormClosed);
            this.Load += new System.EventHandler(this.CadastroProfissao_Load);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.gbStatus, 0);
            this.Controls.SetChildIndex(this.lblProfissao, 0);
            this.Controls.SetChildIndex(this.lblDescricao, 0);
            this.Controls.SetChildIndex(this.txtProfissao, 0);
            this.Controls.SetChildIndex(this.txtDescricao, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfissao;
        private System.Windows.Forms.Label lblDescricao;
        private YControls.YTextBox txtProfissao;
        private YControls.YTextBox txtDescricao;
    }
}
