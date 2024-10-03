namespace Pilates.Views
{
    partial class CadastroEvolucao
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
            this.txtAluno = new System.Windows.Forms.TextBox();
            this.txtCodAluno = new System.Windows.Forms.TextBox();
            this.lblCodAluno = new System.Windows.Forms.Label();
            this.lblAluno = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Text = "0";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(507, 373);
            this.btnSair.TabIndex = 4;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(426, 373);
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(23, 375);
            this.txtDataCadastro.Text = "18062024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(137, 374);
            this.txtDataUltAlt.Text = "18062024";
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(134, 349);
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(20, 349);
            // 
            // gbStatus
            // 
            this.gbStatus.Location = new System.Drawing.Point(417, 12);
            // 
            // txtAluno
            // 
            this.txtAluno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAluno.Enabled = false;
            this.txtAluno.Location = new System.Drawing.Point(137, 89);
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.Size = new System.Drawing.Size(321, 20);
            this.txtAluno.TabIndex = 39;
            // 
            // txtCodAluno
            // 
            this.txtCodAluno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodAluno.Enabled = false;
            this.txtCodAluno.Location = new System.Drawing.Point(23, 89);
            this.txtCodAluno.Name = "txtCodAluno";
            this.txtCodAluno.Size = new System.Drawing.Size(100, 20);
            this.txtCodAluno.TabIndex = 38;
            this.txtCodAluno.Leave += new System.EventHandler(this.txtCodAluno_Leave);
            // 
            // lblCodAluno
            // 
            this.lblCodAluno.AutoSize = true;
            this.lblCodAluno.Location = new System.Drawing.Point(20, 71);
            this.lblCodAluno.Name = "lblCodAluno";
            this.lblCodAluno.Size = new System.Drawing.Size(73, 13);
            this.lblCodAluno.TabIndex = 37;
            this.lblCodAluno.Text = "Código Aluno:";
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(134, 71);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(37, 13);
            this.lblAluno.TabIndex = 35;
            this.lblAluno.Text = "Aluno:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.Location = new System.Drawing.Point(23, 183);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(559, 105);
            this.txtObservacao.TabIndex = 2;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(20, 167);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(72, 13);
            this.lblObservacao.TabIndex = 40;
            this.lblObservacao.Text = "Observação:*";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(23, 116);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(42, 13);
            this.lblTitulo.TabIndex = 42;
            this.lblTitulo.Text = "Título:*";
            // 
            // txtTitulo
            // 
            this.txtTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTitulo.Location = new System.Drawing.Point(23, 132);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(435, 20);
            this.txtTitulo.TabIndex = 1;
            // 
            // CadastroEvolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(594, 411);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.txtAluno);
            this.Controls.Add(this.txtCodAluno);
            this.Controls.Add(this.lblCodAluno);
            this.Controls.Add(this.lblAluno);
            this.Name = "CadastroEvolucao";
            this.Text = "Cadastro de Evolução";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroEvolucao_FormClosed);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.gbStatus, 0);
            this.Controls.SetChildIndex(this.lblAluno, 0);
            this.Controls.SetChildIndex(this.lblCodAluno, 0);
            this.Controls.SetChildIndex(this.txtCodAluno, 0);
            this.Controls.SetChildIndex(this.txtAluno, 0);
            this.Controls.SetChildIndex(this.lblObservacao, 0);
            this.Controls.SetChildIndex(this.txtObservacao, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.txtTitulo, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAluno;
        private System.Windows.Forms.TextBox txtCodAluno;
        private System.Windows.Forms.Label lblCodAluno;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
    }
}
