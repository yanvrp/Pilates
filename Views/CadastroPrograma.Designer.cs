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
            this.lblNumAulas = new System.Windows.Forms.Label();
            this.txtNumAula = new System.Windows.Forms.ComboBox();
            this.txtTipoPrograma = new System.Windows.Forms.ComboBox();
            this.lblTipoPrograma = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtTitulo = new Pilates.YControls.YTextBox();
            this.txtValor = new Pilates.YControls.YTextBox();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(127, 283);
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(20, 282);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(327, 295);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Texts = "0";
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(23, 299);
            this.txtDataCadastro.Texts = "24/10/2024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(130, 299);
            this.txtDataUltAlt.Texts = "24/10/2024";
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(416, 295);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(20, 82);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(42, 13);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Título:*";
            // 
            // lblNumAulas
            // 
            this.lblNumAulas.AutoSize = true;
            this.lblNumAulas.Location = new System.Drawing.Point(20, 149);
            this.lblNumAulas.Name = "lblNumAulas";
            this.lblNumAulas.Size = new System.Drawing.Size(94, 13);
            this.lblNumAulas.TabIndex = 11;
            this.lblNumAulas.Text = "Número de aulas:*";
            // 
            // txtNumAula
            // 
            this.txtNumAula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtNumAula.FormattingEnabled = true;
            this.txtNumAula.ItemHeight = 13;
            this.txtNumAula.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.txtNumAula.Location = new System.Drawing.Point(23, 171);
            this.txtNumAula.Name = "txtNumAula";
            this.txtNumAula.Size = new System.Drawing.Size(121, 21);
            this.txtNumAula.TabIndex = 2;
            // 
            // txtTipoPrograma
            // 
            this.txtTipoPrograma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTipoPrograma.FormattingEnabled = true;
            this.txtTipoPrograma.Items.AddRange(new object[] {
            "EM GRUPO",
            "INDIVIDUAL"});
            this.txtTipoPrograma.Location = new System.Drawing.Point(205, 171);
            this.txtTipoPrograma.Name = "txtTipoPrograma";
            this.txtTipoPrograma.Size = new System.Drawing.Size(121, 21);
            this.txtTipoPrograma.TabIndex = 3;
            // 
            // lblTipoPrograma
            // 
            this.lblTipoPrograma.AutoSize = true;
            this.lblTipoPrograma.Location = new System.Drawing.Point(202, 148);
            this.lblTipoPrograma.Name = "lblTipoPrograma";
            this.lblTipoPrograma.Size = new System.Drawing.Size(98, 13);
            this.lblTipoPrograma.TabIndex = 14;
            this.lblTipoPrograma.Text = "Tipo do Programa:*";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(378, 149);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(38, 13);
            this.lblValor.TabIndex = 15;
            this.lblValor.Text = "Valor:*";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.SystemColors.Window;
            this.txtTitulo.BorderColor = System.Drawing.Color.DarkGray;
            this.txtTitulo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtTitulo.BorderRadius = 8;
            this.txtTitulo.BorderSize = 1;
            this.txtTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTitulo.DisabledBackColor = System.Drawing.Color.White;
            this.txtTitulo.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtTitulo.DisabledForeColor = System.Drawing.Color.White;
            this.txtTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtTitulo.Location = new System.Drawing.Point(20, 98);
            this.txtTitulo.MaxLength = 200;
            this.txtTitulo.Multiline = false;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtTitulo.PasswordChar = false;
            this.txtTitulo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTitulo.PlaceholderText = "";
            this.txtTitulo.Size = new System.Drawing.Size(479, 28);
            this.txtTitulo.TabIndex = 1;
            this.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTitulo.Texts = "";
            this.txtTitulo.UnderlinedStyle = false;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.SystemColors.Window;
            this.txtValor.BorderColor = System.Drawing.Color.DarkGray;
            this.txtValor.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtValor.BorderRadius = 8;
            this.txtValor.BorderSize = 1;
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValor.DisabledBackColor = System.Drawing.Color.White;
            this.txtValor.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtValor.DisabledForeColor = System.Drawing.Color.White;
            this.txtValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtValor.Location = new System.Drawing.Point(381, 165);
            this.txtValor.MaxLength = 13;
            this.txtValor.Multiline = false;
            this.txtValor.Name = "txtValor";
            this.txtValor.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtValor.PasswordChar = false;
            this.txtValor.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtValor.PlaceholderText = "";
            this.txtValor.Size = new System.Drawing.Size(118, 28);
            this.txtValor.TabIndex = 4;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor.Texts = "";
            this.txtValor.UnderlinedStyle = false;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // CadastroPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(522, 342);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblTipoPrograma);
            this.Controls.Add(this.txtTipoPrograma);
            this.Controls.Add(this.txtNumAula);
            this.Controls.Add(this.lblNumAulas);
            this.Controls.Add(this.lblTitulo);
            this.Name = "CadastroPrograma";
            this.Text = "Cadastro de Programa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroPrograma_FormClosed);
            this.Load += new System.EventHandler(this.CadastroPrograma_Load);
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
            this.Controls.SetChildIndex(this.lblNumAulas, 0);
            this.Controls.SetChildIndex(this.txtNumAula, 0);
            this.Controls.SetChildIndex(this.txtTipoPrograma, 0);
            this.Controls.SetChildIndex(this.lblTipoPrograma, 0);
            this.Controls.SetChildIndex(this.lblValor, 0);
            this.Controls.SetChildIndex(this.txtTitulo, 0);
            this.Controls.SetChildIndex(this.txtValor, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNumAulas;
        private System.Windows.Forms.ComboBox txtNumAula;
        private System.Windows.Forms.ComboBox txtTipoPrograma;
        private System.Windows.Forms.Label lblTipoPrograma;
        private System.Windows.Forms.Label lblValor;
        private YControls.YTextBox txtTitulo;
        private YControls.YTextBox txtValor;
    }
}
