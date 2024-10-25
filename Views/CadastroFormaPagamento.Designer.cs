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
            this.txtFormaPagamento = new Pilates.YControls.YTextBox();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(118, 203);
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(20, 203);
            // 
            // gbStatus
            // 
            this.gbStatus.Location = new System.Drawing.Point(247, 19);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(248, 219);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Texts = "0";
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(23, 219);
            this.txtDataCadastro.Texts = "24/10/2024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(121, 219);
            this.txtDataUltAlt.Texts = "24/10/2024";
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(337, 219);
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.AutoSize = true;
            this.lblFormaPagamento.Location = new System.Drawing.Point(20, 113);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(112, 13);
            this.lblFormaPagamento.TabIndex = 9;
            this.lblFormaPagamento.Text = "Forma de Pagamento*";
            // 
            // txtFormaPagamento
            // 
            this.txtFormaPagamento.BackColor = System.Drawing.SystemColors.Window;
            this.txtFormaPagamento.BorderColor = System.Drawing.Color.DarkGray;
            this.txtFormaPagamento.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtFormaPagamento.BorderRadius = 8;
            this.txtFormaPagamento.BorderSize = 1;
            this.txtFormaPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFormaPagamento.DisabledBackColor = System.Drawing.Color.White;
            this.txtFormaPagamento.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtFormaPagamento.DisabledForeColor = System.Drawing.Color.White;
            this.txtFormaPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtFormaPagamento.Location = new System.Drawing.Point(23, 129);
            this.txtFormaPagamento.MaxLength = 32767;
            this.txtFormaPagamento.Multiline = false;
            this.txtFormaPagamento.Name = "txtFormaPagamento";
            this.txtFormaPagamento.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtFormaPagamento.PasswordChar = false;
            this.txtFormaPagamento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFormaPagamento.PlaceholderText = "";
            this.txtFormaPagamento.Size = new System.Drawing.Size(389, 28);
            this.txtFormaPagamento.TabIndex = 16;
            this.txtFormaPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFormaPagamento.Texts = "";
            this.txtFormaPagamento.UnderlinedStyle = false;
            this.txtFormaPagamento.Leave += new System.EventHandler(this.txtFormaPagamento_Leave);
            // 
            // CadastroFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(434, 262);
            this.Controls.Add(this.txtFormaPagamento);
            this.Controls.Add(this.lblFormaPagamento);
            this.Name = "CadastroFormaPagamento";
            this.Text = "Cadastro de Forma de Pagamento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroFormaPagamento_FormClosed);
            this.Load += new System.EventHandler(this.CadastroFormaPagamento_Load);
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
        private YControls.YTextBox txtFormaPagamento;
    }
}
