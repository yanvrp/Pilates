namespace Pilates.Views
{
    partial class CadastroPrograma
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblNumAulas = new System.Windows.Forms.Label();
            this.txtNumAula = new System.Windows.Forms.ComboBox();
            this.txtTipoPrograma = new System.Windows.Forms.ComboBox();
            this.lblTipoPrograma = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Text = "0";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(464, 305);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(383, 305);
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(23, 308);
            this.txtDataCadastro.Text = "02072024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(137, 307);
            this.txtDataUltAlt.Text = "02072024";
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(134, 282);
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(20, 282);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(20, 72);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(42, 13);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Título:*";
            // 
            // txtTitulo
            // 
            this.txtTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTitulo.Location = new System.Drawing.Point(23, 89);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(516, 20);
            this.txtTitulo.TabIndex = 10;
            // 
            // lblNumAulas
            // 
            this.lblNumAulas.AutoSize = true;
            this.lblNumAulas.Location = new System.Drawing.Point(20, 122);
            this.lblNumAulas.Name = "lblNumAulas";
            this.lblNumAulas.Size = new System.Drawing.Size(94, 13);
            this.lblNumAulas.TabIndex = 11;
            this.lblNumAulas.Text = "Número de aulas:*";
            // 
            // txtNumAula
            // 
            this.txtNumAula.FormattingEnabled = true;
            this.txtNumAula.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.txtNumAula.Location = new System.Drawing.Point(23, 139);
            this.txtNumAula.Name = "txtNumAula";
            this.txtNumAula.Size = new System.Drawing.Size(121, 21);
            this.txtNumAula.TabIndex = 12;
            // 
            // txtTipoPrograma
            // 
            this.txtTipoPrograma.FormattingEnabled = true;
            this.txtTipoPrograma.Items.AddRange(new object[] {
            "EM GRUPO",
            "INDIVIDUAL"});
            this.txtTipoPrograma.Location = new System.Drawing.Point(175, 139);
            this.txtTipoPrograma.Name = "txtTipoPrograma";
            this.txtTipoPrograma.Size = new System.Drawing.Size(121, 21);
            this.txtTipoPrograma.TabIndex = 13;
            // 
            // lblTipoPrograma
            // 
            this.lblTipoPrograma.AutoSize = true;
            this.lblTipoPrograma.Location = new System.Drawing.Point(172, 122);
            this.lblTipoPrograma.Name = "lblTipoPrograma";
            this.lblTipoPrograma.Size = new System.Drawing.Size(98, 13);
            this.lblTipoPrograma.TabIndex = 14;
            this.lblTipoPrograma.Text = "Tipo do Programa:*";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(322, 122);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(38, 13);
            this.lblValor.TabIndex = 15;
            this.lblValor.Text = "Valor:*";
            // 
            // txtValor
            // 
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValor.Location = new System.Drawing.Point(325, 139);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 16;
            // 
            // CadastroPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(551, 342);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblTipoPrograma);
            this.Controls.Add(this.txtTipoPrograma);
            this.Controls.Add(this.txtNumAula);
            this.Controls.Add(this.lblNumAulas);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "CadastroPrograma";
            this.Text = "Cadastro de Programa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroPrograma_FormClosed);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.gbStatus, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.txtTitulo, 0);
            this.Controls.SetChildIndex(this.lblNumAulas, 0);
            this.Controls.SetChildIndex(this.txtNumAula, 0);
            this.Controls.SetChildIndex(this.txtTipoPrograma, 0);
            this.Controls.SetChildIndex(this.lblTipoPrograma, 0);
            this.Controls.SetChildIndex(this.lblValor, 0);
            this.Controls.SetChildIndex(this.txtValor, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblNumAulas;
        private System.Windows.Forms.ComboBox txtNumAula;
        private System.Windows.Forms.ComboBox txtTipoPrograma;
        private System.Windows.Forms.Label lblTipoPrograma;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
    }
}
