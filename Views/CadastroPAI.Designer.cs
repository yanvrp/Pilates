namespace Pilates.Views
{
    partial class CadastroPAI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtDataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.txtDataUltAlt = new System.Windows.Forms.MaskedTextBox();
            this.lblDataUltAlt = new System.Windows.Forms.Label();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(20, 19);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(23, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(51, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(464, 415);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(383, 415);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Enabled = false;
            this.txtDataCadastro.Location = new System.Drawing.Point(23, 418);
            this.txtDataCadastro.Mask = "00/00/0000";
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.Size = new System.Drawing.Size(108, 20);
            this.txtDataCadastro.TabIndex = 4;
            this.txtDataCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Enabled = false;
            this.txtDataUltAlt.Location = new System.Drawing.Point(137, 417);
            this.txtDataUltAlt.Mask = "00/00/0000";
            this.txtDataUltAlt.Name = "txtDataUltAlt";
            this.txtDataUltAlt.Size = new System.Drawing.Size(101, 20);
            this.txtDataUltAlt.TabIndex = 5;
            this.txtDataUltAlt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataUltAlt.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.AutoSize = true;
            this.lblDataUltAlt.Location = new System.Drawing.Point(134, 392);
            this.lblDataUltAlt.Name = "lblDataUltAlt";
            this.lblDataUltAlt.Size = new System.Drawing.Size(73, 13);
            this.lblDataUltAlt.TabIndex = 6;
            this.lblDataUltAlt.Text = "Data Ult. Alt. :";
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Location = new System.Drawing.Point(20, 392);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(78, 13);
            this.lblDataCadastro.TabIndex = 7;
            this.lblDataCadastro.Text = "Data Cadastro:";
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Location = new System.Drawing.Point(374, 12);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(165, 58);
            this.gbStatus.TabIndex = 8;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(90, 26);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(57, 17);
            this.rbInativo.TabIndex = 1;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            this.rbInativo.CheckedChanged += new System.EventHandler(this.rbInativo_CheckedChanged);
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Checked = true;
            this.rbAtivo.Location = new System.Drawing.Point(19, 26);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(49, 17);
            this.rbAtivo.TabIndex = 0;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            this.rbAtivo.CheckedChanged += new System.EventHandler(this.rbAtivo_CheckedChanged);
            // 
            // CadastroPAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.lblDataCadastro);
            this.Controls.Add(this.lblDataUltAlt);
            this.Controls.Add(this.txtDataUltAlt);
            this.Controls.Add(this.txtDataCadastro);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "CadastroPAI";
            this.Text = "CadastroPAI";
            this.Load += new System.EventHandler(this.CadastroPAI_Load);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label lblCodigo;
        protected System.Windows.Forms.TextBox txtCodigo;
        protected System.Windows.Forms.Button btnSair;
        protected System.Windows.Forms.Button btnSalvar;
        protected System.Windows.Forms.MaskedTextBox txtDataCadastro;
        protected System.Windows.Forms.MaskedTextBox txtDataUltAlt;
        protected System.Windows.Forms.Label lblDataUltAlt;
        protected System.Windows.Forms.Label lblDataCadastro;
        protected System.Windows.Forms.GroupBox gbStatus;
        protected System.Windows.Forms.RadioButton rbInativo;
        protected System.Windows.Forms.RadioButton rbAtivo;
    }
}