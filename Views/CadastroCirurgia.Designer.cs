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
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtCirurgia = new System.Windows.Forms.TextBox();
            this.lblCirurgia = new System.Windows.Forms.Label();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Text = "0";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(503, 418);
            this.btnSair.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(422, 418);
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Text = "18062024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Text = "18062024";
            // 
            // gbStatus
            // 
            this.gbStatus.Location = new System.Drawing.Point(422, 12);
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(23, 150);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(559, 105);
            this.txtDescricao.TabIndex = 2;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(20, 134);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(62, 13);
            this.lblDescricao.TabIndex = 19;
            this.lblDescricao.Text = "Descrição:*";
            // 
            // txtCirurgia
            // 
            this.txtCirurgia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCirurgia.Location = new System.Drawing.Point(23, 94);
            this.txtCirurgia.Name = "txtCirurgia";
            this.txtCirurgia.Size = new System.Drawing.Size(215, 20);
            this.txtCirurgia.TabIndex = 1;
            // 
            // lblCirurgia
            // 
            this.lblCirurgia.AutoSize = true;
            this.lblCirurgia.Location = new System.Drawing.Point(20, 77);
            this.lblCirurgia.Name = "lblCirurgia";
            this.lblCirurgia.Size = new System.Drawing.Size(49, 13);
            this.lblCirurgia.TabIndex = 17;
            this.lblCirurgia.Text = "Cirurgia:*";
            // 
            // CadastroCirurgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtCirurgia);
            this.Controls.Add(this.lblCirurgia);
            this.Name = "CadastroCirurgia";
            this.Text = "Cadastro Cirurgia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroCirurgia_FormClosed);
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
            this.Controls.SetChildIndex(this.txtCirurgia, 0);
            this.Controls.SetChildIndex(this.lblDescricao, 0);
            this.Controls.SetChildIndex(this.txtDescricao, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtCirurgia;
        private System.Windows.Forms.Label lblCirurgia;
    }
}
