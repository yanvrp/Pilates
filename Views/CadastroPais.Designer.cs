﻿namespace Pilates.Views
{
    partial class CadastroPais
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
            this.lblPais = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.lblDDI = new System.Windows.Forms.Label();
            this.txtDDI = new System.Windows.Forms.TextBox();
            this.lblSigla = new System.Windows.Forms.Label();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(22, 19);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Text = "0";
            // 
            // btnSair
            // 
            this.btnSair.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.TabIndex = 4;
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
            this.gbStatus.TabIndex = 6;
            // 
            // rbInativo
            // 
            this.rbInativo.TabIndex = 8;
            // 
            // rbAtivo
            // 
            this.rbAtivo.TabIndex = 7;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(22, 71);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(36, 13);
            this.lblPais.TabIndex = 9;
            this.lblPais.Text = "País:*";
            // 
            // txtPais
            // 
            this.txtPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPais.Location = new System.Drawing.Point(23, 87);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(162, 20);
            this.txtPais.TabIndex = 1;
            this.txtPais.Leave += new System.EventHandler(this.txtPais_Leave);
            // 
            // lblDDI
            // 
            this.lblDDI.AutoSize = true;
            this.lblDDI.Location = new System.Drawing.Point(20, 120);
            this.lblDDI.Name = "lblDDI";
            this.lblDDI.Size = new System.Drawing.Size(33, 13);
            this.lblDDI.TabIndex = 11;
            this.lblDDI.Text = "DDI:*";
            // 
            // txtDDI
            // 
            this.txtDDI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDDI.Location = new System.Drawing.Point(21, 136);
            this.txtDDI.Name = "txtDDI";
            this.txtDDI.Size = new System.Drawing.Size(164, 20);
            this.txtDDI.TabIndex = 2;
            this.txtDDI.Leave += new System.EventHandler(this.txtDDI_Leave);
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Location = new System.Drawing.Point(22, 168);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(37, 13);
            this.lblSigla.TabIndex = 13;
            this.lblSigla.Text = "Sigla:*";
            // 
            // txtSigla
            // 
            this.txtSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSigla.Location = new System.Drawing.Point(23, 184);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(162, 20);
            this.txtSigla.TabIndex = 3;
            this.txtSigla.Leave += new System.EventHandler(this.txtSigla_Leave);
            // 
            // CadastroPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.lblSigla);
            this.Controls.Add(this.txtDDI);
            this.Controls.Add(this.lblDDI);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.lblPais);
            this.Name = "CadastroPais";
            this.Text = "Cadastro de País";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroPais_FormClosed);
            this.Load += new System.EventHandler(this.CadastroPais_Load);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.gbStatus, 0);
            this.Controls.SetChildIndex(this.lblPais, 0);
            this.Controls.SetChildIndex(this.txtPais, 0);
            this.Controls.SetChildIndex(this.lblDDI, 0);
            this.Controls.SetChildIndex(this.txtDDI, 0);
            this.Controls.SetChildIndex(this.lblSigla, 0);
            this.Controls.SetChildIndex(this.txtSigla, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblDDI;
        private System.Windows.Forms.Label lblSigla;
        protected System.Windows.Forms.TextBox txtPais;
        protected System.Windows.Forms.TextBox txtDDI;
        protected System.Windows.Forms.TextBox txtSigla;
    }
}
