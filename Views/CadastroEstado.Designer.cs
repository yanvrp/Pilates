namespace Pilates.Views
{
    partial class CadastroEstado
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
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.lblCodigoPais = new System.Windows.Forms.Label();
            this.txtCodigoPais = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.btnBuscarPais = new System.Windows.Forms.Button();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Text = "0";
            // 
            // btnSair
            // 
            this.btnSair.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.TabIndex = 6;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Text = "09062024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Text = "09062024";
            // 
            // gbStatus
            // 
            this.gbStatus.TabIndex = 7;
            // 
            // rbInativo
            // 
            this.rbInativo.TabIndex = 9;
            // 
            // rbAtivo
            // 
            this.rbAtivo.TabIndex = 8;
            this.rbAtivo.CheckedChanged += new System.EventHandler(this.rbAtivo_CheckedChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(20, 70);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(47, 13);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado:*";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(20, 119);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(28, 13);
            this.lblUF.TabIndex = 10;
            this.lblUF.Text = "UF:*";
            // 
            // txtEstado
            // 
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Location = new System.Drawing.Point(23, 86);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(205, 20);
            this.txtEstado.TabIndex = 1;
            this.txtEstado.Leave += new System.EventHandler(this.txtEstado_Leave);
            // 
            // txtUF
            // 
            this.txtUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUF.Location = new System.Drawing.Point(23, 135);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(205, 20);
            this.txtUF.TabIndex = 2;
            this.txtUF.Leave += new System.EventHandler(this.txtUF_Leave);
            // 
            // lblCodigoPais
            // 
            this.lblCodigoPais.AutoSize = true;
            this.lblCodigoPais.Location = new System.Drawing.Point(20, 168);
            this.lblCodigoPais.Name = "lblCodigoPais";
            this.lblCodigoPais.Size = new System.Drawing.Size(72, 13);
            this.lblCodigoPais.TabIndex = 13;
            this.lblCodigoPais.Text = "Código País:*";
            // 
            // txtCodigoPais
            // 
            this.txtCodigoPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoPais.Location = new System.Drawing.Point(23, 184);
            this.txtCodigoPais.Name = "txtCodigoPais";
            this.txtCodigoPais.Size = new System.Drawing.Size(63, 20);
            this.txtCodigoPais.TabIndex = 3;
            this.txtCodigoPais.Leave += new System.EventHandler(this.txtCodigoPais_Leave);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(148, 168);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(36, 13);
            this.lblPais.TabIndex = 15;
            this.lblPais.Text = "País:*";
            // 
            // btnBuscarPais
            // 
            this.btnBuscarPais.Location = new System.Drawing.Point(89, 182);
            this.btnBuscarPais.Name = "btnBuscarPais";
            this.btnBuscarPais.Size = new System.Drawing.Size(56, 23);
            this.btnBuscarPais.TabIndex = 4;
            this.btnBuscarPais.Text = "Buscar";
            this.btnBuscarPais.UseVisualStyleBackColor = true;
            this.btnBuscarPais.Click += new System.EventHandler(this.btnBuscarPais_Click);
            // 
            // txtPais
            // 
            this.txtPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPais.Enabled = false;
            this.txtPais.Location = new System.Drawing.Point(151, 184);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(134, 20);
            this.txtPais.TabIndex = 5;
            // 
            // CadastroEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.btnBuscarPais);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.txtCodigoPais);
            this.Controls.Add(this.lblCodigoPais);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.lblEstado);
            this.Name = "CadastroEstado";
            this.Text = "Cadastro de Estado";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroEstado_FormClosed);
            this.Load += new System.EventHandler(this.CadastroEstado_Load);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.gbStatus, 0);
            this.Controls.SetChildIndex(this.lblEstado, 0);
            this.Controls.SetChildIndex(this.lblUF, 0);
            this.Controls.SetChildIndex(this.txtEstado, 0);
            this.Controls.SetChildIndex(this.txtUF, 0);
            this.Controls.SetChildIndex(this.lblCodigoPais, 0);
            this.Controls.SetChildIndex(this.txtCodigoPais, 0);
            this.Controls.SetChildIndex(this.lblPais, 0);
            this.Controls.SetChildIndex(this.btnBuscarPais, 0);
            this.Controls.SetChildIndex(this.txtPais, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label lblCodigoPais;
        private System.Windows.Forms.TextBox txtCodigoPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Button btnBuscarPais;
        private System.Windows.Forms.TextBox txtPais;
    }
}
