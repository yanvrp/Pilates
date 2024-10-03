namespace Pilates.Views
{
    partial class CadastroFormaPagamento
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
            this.lblFormaPagamento = new System.Windows.Forms.Label();
            this.txtFormaPagamento = new System.Windows.Forms.TextBox();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Text = "0";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(337, 208);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(256, 208);
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(23, 212);
            this.txtDataCadastro.Text = "17082024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(137, 211);
            this.txtDataUltAlt.Text = "17082024";
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(134, 186);
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(20, 186);
            // 
            // gbStatus
            // 
            this.gbStatus.Location = new System.Drawing.Point(247, 19);
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.AutoSize = true;
            this.lblFormaPagamento.Location = new System.Drawing.Point(20, 93);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(112, 13);
            this.lblFormaPagamento.TabIndex = 9;
            this.lblFormaPagamento.Text = "Forma de Pagamento*";
            // 
            // txtFormaPagamento
            // 
            this.txtFormaPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFormaPagamento.Location = new System.Drawing.Point(23, 119);
            this.txtFormaPagamento.Name = "txtFormaPagamento";
            this.txtFormaPagamento.Size = new System.Drawing.Size(389, 20);
            this.txtFormaPagamento.TabIndex = 10;
            this.txtFormaPagamento.Leave += new System.EventHandler(this.txtFormaPagamento_Leave);
            // 
            // CadastroFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(426, 252);
            this.Controls.Add(this.txtFormaPagamento);
            this.Controls.Add(this.lblFormaPagamento);
            this.Name = "CadastroFormaPagamento";
            this.Text = "Cadastro de Forma de Pagamento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroFormaPagamento_FormClosed);
            this.Controls.SetChildIndex(this.lblFormaPagamento, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.gbStatus, 0);
            this.Controls.SetChildIndex(this.txtFormaPagamento, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormaPagamento;
        private System.Windows.Forms.TextBox txtFormaPagamento;
    }
}
