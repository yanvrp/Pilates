namespace Pilates.Views
{
    partial class CadastroAvaliacao
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
            this.yButton1 = new Pilates.YControls.YButton();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Text = "0";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(464, 672);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(383, 672);
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(23, 675);
            this.txtDataCadastro.Text = "13102024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(137, 674);
            this.txtDataUltAlt.Text = "13102024";
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(134, 649);
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(20, 649);
            // 
            // gbStatus
            // 
            this.gbStatus.Location = new System.Drawing.Point(642, 12);
            // 
            // yButton1
            // 
            this.yButton1.BackColor = System.Drawing.Color.DarkViolet;
            this.yButton1.BackgroundColor = System.Drawing.Color.DarkViolet;
            this.yButton1.BorderColor = System.Drawing.Color.DarkViolet;
            this.yButton1.BorderRadius = 8;
            this.yButton1.BorderSize = 1;
            this.yButton1.FlatAppearance.BorderSize = 0;
            this.yButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yButton1.ForeColor = System.Drawing.Color.White;
            this.yButton1.Location = new System.Drawing.Point(383, 265);
            this.yButton1.Name = "yButton1";
            this.yButton1.Size = new System.Drawing.Size(150, 40);
            this.yButton1.TabIndex = 9;
            this.yButton1.Text = "yButton1";
            this.yButton1.TextColor = System.Drawing.Color.White;
            this.yButton1.UseVisualStyleBackColor = false;
            // 
            // CadastroAvaliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(819, 707);
            this.Controls.Add(this.yButton1);
            this.Name = "CadastroAvaliacao";
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.gbStatus, 0);
            this.Controls.SetChildIndex(this.yButton1, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private YControls.YButton yButton1;
    }
}
