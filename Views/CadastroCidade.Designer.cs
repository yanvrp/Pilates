namespace Pilates.Views
{
    partial class CadastroCidade
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
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblDDD = new System.Windows.Forms.Label();
            this.txtDDD = new System.Windows.Forms.TextBox();
            this.lblCodigoEstado = new System.Windows.Forms.Label();
            this.txtCodigoEstado = new System.Windows.Forms.TextBox();
            this.btnBuscarEstado = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
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
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(20, 71);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(47, 13);
            this.lblCidade.TabIndex = 9;
            this.lblCidade.Text = "Cidade:*";
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Location = new System.Drawing.Point(23, 87);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(181, 20);
            this.txtCidade.TabIndex = 1;
            this.txtCidade.Leave += new System.EventHandler(this.txtCidade_Leave);
            // 
            // lblDDD
            // 
            this.lblDDD.AutoSize = true;
            this.lblDDD.Location = new System.Drawing.Point(20, 119);
            this.lblDDD.Name = "lblDDD";
            this.lblDDD.Size = new System.Drawing.Size(38, 13);
            this.lblDDD.TabIndex = 11;
            this.lblDDD.Text = "DDD:*";
            // 
            // txtDDD
            // 
            this.txtDDD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDDD.Location = new System.Drawing.Point(23, 135);
            this.txtDDD.Name = "txtDDD";
            this.txtDDD.Size = new System.Drawing.Size(181, 20);
            this.txtDDD.TabIndex = 2;
            this.txtDDD.Leave += new System.EventHandler(this.txtDDD_Leave);
            // 
            // lblCodigoEstado
            // 
            this.lblCodigoEstado.AutoSize = true;
            this.lblCodigoEstado.Location = new System.Drawing.Point(20, 168);
            this.lblCodigoEstado.Name = "lblCodigoEstado";
            this.lblCodigoEstado.Size = new System.Drawing.Size(83, 13);
            this.lblCodigoEstado.TabIndex = 13;
            this.lblCodigoEstado.Text = "Codigo Estado:*";
            // 
            // txtCodigoEstado
            // 
            this.txtCodigoEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoEstado.Location = new System.Drawing.Point(23, 184);
            this.txtCodigoEstado.Name = "txtCodigoEstado";
            this.txtCodigoEstado.Size = new System.Drawing.Size(76, 20);
            this.txtCodigoEstado.TabIndex = 3;
            this.txtCodigoEstado.Leave += new System.EventHandler(this.txtCodigoEstado_Leave);
            // 
            // btnBuscarEstado
            // 
            this.btnBuscarEstado.Location = new System.Drawing.Point(105, 182);
            this.btnBuscarEstado.Name = "btnBuscarEstado";
            this.btnBuscarEstado.Size = new System.Drawing.Size(59, 23);
            this.btnBuscarEstado.TabIndex = 4;
            this.btnBuscarEstado.Text = "Buscar";
            this.btnBuscarEstado.UseVisualStyleBackColor = true;
            this.btnBuscarEstado.Click += new System.EventHandler(this.btnBuscarEstado_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(167, 168);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(47, 13);
            this.lblEstado.TabIndex = 16;
            this.lblEstado.Text = "Estado:*";
            // 
            // txtEstado
            // 
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(170, 185);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(158, 20);
            this.txtEstado.TabIndex = 5;
            // 
            // CadastroCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnBuscarEstado);
            this.Controls.Add(this.txtCodigoEstado);
            this.Controls.Add(this.lblCodigoEstado);
            this.Controls.Add(this.txtDDD);
            this.Controls.Add(this.lblDDD);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidade);
            this.Name = "CadastroCidade";
            this.Text = "Cadastro de Cidade";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroCidade_FormClosed);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.gbStatus, 0);
            this.Controls.SetChildIndex(this.lblCidade, 0);
            this.Controls.SetChildIndex(this.txtCidade, 0);
            this.Controls.SetChildIndex(this.lblDDD, 0);
            this.Controls.SetChildIndex(this.txtDDD, 0);
            this.Controls.SetChildIndex(this.lblCodigoEstado, 0);
            this.Controls.SetChildIndex(this.txtCodigoEstado, 0);
            this.Controls.SetChildIndex(this.btnBuscarEstado, 0);
            this.Controls.SetChildIndex(this.lblEstado, 0);
            this.Controls.SetChildIndex(this.txtEstado, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblDDD;
        private System.Windows.Forms.TextBox txtDDD;
        private System.Windows.Forms.Label lblCodigoEstado;
        private System.Windows.Forms.TextBox txtCodigoEstado;
        private System.Windows.Forms.Button btnBuscarEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtEstado;
    }
}
