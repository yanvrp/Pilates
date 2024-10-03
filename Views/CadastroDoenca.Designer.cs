namespace Pilates.Views
{
    partial class CadastroDoenca
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
            this.txtDoenca = new System.Windows.Forms.TextBox();
            this.lblDoenca = new System.Windows.Forms.Label();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(12, 21);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 37);
            this.txtCodigo.Text = "0";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(496, 414);
            this.btnSair.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(415, 414);
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
            this.gbStatus.Location = new System.Drawing.Point(406, 12);
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(12, 160);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(559, 105);
            this.txtDescricao.TabIndex = 2;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(9, 144);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(62, 13);
            this.lblDescricao.TabIndex = 15;
            this.lblDescricao.Text = "Descrição:*";
            // 
            // txtDoenca
            // 
            this.txtDoenca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDoenca.Location = new System.Drawing.Point(12, 104);
            this.txtDoenca.Name = "txtDoenca";
            this.txtDoenca.Size = new System.Drawing.Size(215, 20);
            this.txtDoenca.TabIndex = 1;
            // 
            // lblDoenca
            // 
            this.lblDoenca.AutoSize = true;
            this.lblDoenca.Location = new System.Drawing.Point(9, 87);
            this.lblDoenca.Name = "lblDoenca";
            this.lblDoenca.Size = new System.Drawing.Size(52, 13);
            this.lblDoenca.TabIndex = 13;
            this.lblDoenca.Text = "Doenca:*";
            // 
            // CadastroDoenca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDoenca);
            this.Controls.Add(this.lblDoenca);
            this.Name = "CadastroDoenca";
            this.Text = "Cadastro de Doença";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroDoenca_FormClosed);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.gbStatus, 0);
            this.Controls.SetChildIndex(this.lblDoenca, 0);
            this.Controls.SetChildIndex(this.txtDoenca, 0);
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
        private System.Windows.Forms.TextBox txtDoenca;
        private System.Windows.Forms.Label lblDoenca;
    }
}
