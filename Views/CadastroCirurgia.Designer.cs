namespace Pilates.Views
{
    partial class CadastroCirurgia
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
            this.lblCirurgia = new System.Windows.Forms.Label();
            this.txtDescricao = new Pilates.YControls.YTextBox();
            this.txtCirurgia = new Pilates.YControls.YTextBox();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbStatus
            // 
            this.gbStatus.Location = new System.Drawing.Point(293, 19);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(286, 405);
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
            this.lblDescricao.Location = new System.Drawing.Point(20, 157);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(62, 13);
            this.lblDescricao.TabIndex = 19;
            this.lblDescricao.Text = "Descrição:*";
            // 
            // lblCirurgia
            // 
            this.lblCirurgia.AutoSize = true;
            this.lblCirurgia.Location = new System.Drawing.Point(20, 88);
            this.lblCirurgia.Name = "lblCirurgia";
            this.lblCirurgia.Size = new System.Drawing.Size(49, 13);
            this.lblCirurgia.TabIndex = 17;
            this.lblCirurgia.Text = "Cirurgia:*";
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
            this.txtDescricao.Location = new System.Drawing.Point(23, 173);
            this.txtDescricao.MaxLength = 200;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDescricao.PasswordChar = false;
            this.txtDescricao.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDescricao.PlaceholderText = "";
            this.txtDescricao.Size = new System.Drawing.Size(432, 107);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescricao.Texts = "";
            this.txtDescricao.UnderlinedStyle = false;
            // 
            // txtCirurgia
            // 
            this.txtCirurgia.BackColor = System.Drawing.SystemColors.Window;
            this.txtCirurgia.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCirurgia.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtCirurgia.BorderRadius = 8;
            this.txtCirurgia.BorderSize = 1;
            this.txtCirurgia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCirurgia.DisabledBackColor = System.Drawing.Color.White;
            this.txtCirurgia.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCirurgia.DisabledForeColor = System.Drawing.Color.White;
            this.txtCirurgia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCirurgia.Location = new System.Drawing.Point(23, 104);
            this.txtCirurgia.MaxLength = 100;
            this.txtCirurgia.Multiline = false;
            this.txtCirurgia.Name = "txtCirurgia";
            this.txtCirurgia.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCirurgia.PasswordChar = false;
            this.txtCirurgia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCirurgia.PlaceholderText = "";
            this.txtCirurgia.Size = new System.Drawing.Size(435, 28);
            this.txtCirurgia.TabIndex = 1;
            this.txtCirurgia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCirurgia.Texts = "";
            this.txtCirurgia.UnderlinedStyle = false;
            this.txtCirurgia.Leave += new System.EventHandler(this.txtCirurgia_Leave);
            // 
            // CadastroCirurgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.txtCirurgia);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblCirurgia);
            this.Name = "CadastroCirurgia";
            this.Text = "Cadastro Cirurgia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroCirurgia_FormClosed);
            this.Load += new System.EventHandler(this.CadastroCirurgia_Load);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.gbStatus, 0);
            this.Controls.SetChildIndex(this.lblCirurgia, 0);
            this.Controls.SetChildIndex(this.lblDescricao, 0);
            this.Controls.SetChildIndex(this.txtDescricao, 0);
            this.Controls.SetChildIndex(this.txtCirurgia, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblCirurgia;
        private YControls.YTextBox txtDescricao;
        private YControls.YTextBox txtCirurgia;
    }
}
