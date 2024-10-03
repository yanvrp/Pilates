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
            this.txtProfissao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Text = "0";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(514, 414);
            this.btnSair.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(433, 414);
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Text = "17062024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Text = "17062024";
            // 
            // gbStatus
            // 
            this.gbStatus.Location = new System.Drawing.Point(424, 19);
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
            // txtProfissao
            // 
            this.txtProfissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProfissao.Location = new System.Drawing.Point(23, 103);
            this.txtProfissao.Name = "txtProfissao";
            this.txtProfissao.Size = new System.Drawing.Size(215, 20);
            this.txtProfissao.TabIndex = 1;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(20, 143);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(62, 13);
            this.lblDescricao.TabIndex = 11;
            this.lblDescricao.Text = "Descrição:*";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(23, 159);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(548, 85);
            this.txtDescricao.TabIndex = 2;
            // 
            // CadastroProfissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtProfissao);
            this.Controls.Add(this.lblProfissao);
            this.Name = "CadastroProfissao";
            this.Text = "Cadastro de Profissão";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroProfissao_FormClosed);
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
            this.Controls.SetChildIndex(this.txtProfissao, 0);
            this.Controls.SetChildIndex(this.lblDescricao, 0);
            this.Controls.SetChildIndex(this.txtDescricao, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfissao;
        private System.Windows.Forms.TextBox txtProfissao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
    }
}
