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
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtGestacao = new System.Windows.Forms.TextBox();
            this.lblGestacao = new System.Windows.Forms.Label();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Text = "0";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(507, 416);
            this.btnSair.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(426, 416);
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
            this.gbStatus.Location = new System.Drawing.Point(417, 12);
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(23, 153);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(559, 105);
            this.txtDescricao.TabIndex = 2;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(20, 137);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(62, 13);
            this.lblDescricao.TabIndex = 19;
            this.lblDescricao.Text = "Descrição:*";
            // 
            // txtGestacao
            // 
            this.txtGestacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGestacao.Location = new System.Drawing.Point(23, 97);
            this.txtGestacao.Name = "txtGestacao";
            this.txtGestacao.Size = new System.Drawing.Size(215, 20);
            this.txtGestacao.TabIndex = 1;
            // 
            // lblGestacao
            // 
            this.lblGestacao.AutoSize = true;
            this.lblGestacao.Location = new System.Drawing.Point(20, 80);
            this.lblGestacao.Name = "lblGestacao";
            this.lblGestacao.Size = new System.Drawing.Size(60, 13);
            this.lblGestacao.TabIndex = 17;
            this.lblGestacao.Text = "Gestação:*";
            // 
            // CadastroGestacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtGestacao);
            this.Controls.Add(this.lblGestacao);
            this.Name = "CadastroGestacao";
            this.Text = "Cadastro de Gestação";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroGestacao_FormClosed);
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
            this.Controls.SetChildIndex(this.txtGestacao, 0);
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
        private System.Windows.Forms.TextBox txtGestacao;
        private System.Windows.Forms.Label lblGestacao;
    }
}
