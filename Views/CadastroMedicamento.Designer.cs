namespace Pilates.Views
{
    partial class CadastroMedicamento
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
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblMedicamento = new System.Windows.Forms.Label();
            this.txtMedicamento = new Pilates.YControls.YTextBox();
            this.txtDescricao = new Pilates.YControls.YTextBox();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbStatus
            // 
            this.gbStatus.Location = new System.Drawing.Point(292, 19);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(285, 405);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Texts = "0";
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Texts = "24/10/2024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Texts = "24/10/2024";
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(374, 405);
            this.btnSair.TabIndex = 4;
            // 
            // txtUsuarioUltAlt
            // 
            this.txtUsuarioUltAlt.Location = new System.Drawing.Point(23, 363);
            // 
            // lblUsuarioUltAlt
            // 
            this.lblUsuarioUltAlt.Location = new System.Drawing.Point(20, 347);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(21, 162);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(62, 13);
            this.lblDescricao.TabIndex = 19;
            this.lblDescricao.Text = "Descrição:*";
            // 
            // lblMedicamento
            // 
            this.lblMedicamento.AutoSize = true;
            this.lblMedicamento.Location = new System.Drawing.Point(20, 89);
            this.lblMedicamento.Name = "lblMedicamento";
            this.lblMedicamento.Size = new System.Drawing.Size(78, 13);
            this.lblMedicamento.TabIndex = 17;
            this.lblMedicamento.Text = "Medicamento:*";
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.BackColor = System.Drawing.SystemColors.Window;
            this.txtMedicamento.BorderColor = System.Drawing.Color.DarkGray;
            this.txtMedicamento.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtMedicamento.BorderRadius = 8;
            this.txtMedicamento.BorderSize = 1;
            this.txtMedicamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMedicamento.DisabledBackColor = System.Drawing.Color.White;
            this.txtMedicamento.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtMedicamento.DisabledForeColor = System.Drawing.Color.White;
            this.txtMedicamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtMedicamento.Location = new System.Drawing.Point(23, 105);
            this.txtMedicamento.MaxLength = 100;
            this.txtMedicamento.Multiline = false;
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtMedicamento.PasswordChar = false;
            this.txtMedicamento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMedicamento.PlaceholderText = "";
            this.txtMedicamento.Size = new System.Drawing.Size(434, 28);
            this.txtMedicamento.TabIndex = 1;
            this.txtMedicamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMedicamento.Texts = "";
            this.txtMedicamento.UnderlinedStyle = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescricao.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDescricao.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtDescricao.BorderRadius = 8;
            this.txtDescricao.BorderSize = 1;
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.DisabledBackColor = System.Drawing.Color.White;
            this.txtDescricao.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtDescricao.DisabledForeColor = System.Drawing.Color.White;
            this.txtDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDescricao.Location = new System.Drawing.Point(24, 178);
            this.txtDescricao.MaxLength = 200;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDescricao.PasswordChar = false;
            this.txtDescricao.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDescricao.PlaceholderText = "";
            this.txtDescricao.Size = new System.Drawing.Size(433, 107);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescricao.Texts = "";
            this.txtDescricao.UnderlinedStyle = false;
            // 
            // CadastroMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtMedicamento);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblMedicamento);
            this.Name = "CadastroMedicamento";
            this.Text = "Cadastro de Medicamento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroMedicamento_FormClosed);
            this.Load += new System.EventHandler(this.CadastroMedicamento_Load);
            this.Controls.SetChildIndex(this.lblUsuarioUltAlt, 0);
            this.Controls.SetChildIndex(this.txtUsuarioUltAlt, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.gbStatus, 0);
            this.Controls.SetChildIndex(this.lblMedicamento, 0);
            this.Controls.SetChildIndex(this.lblDescricao, 0);
            this.Controls.SetChildIndex(this.txtMedicamento, 0);
            this.Controls.SetChildIndex(this.txtDescricao, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblMedicamento;
        private YControls.YTextBox txtMedicamento;
        private YControls.YTextBox txtDescricao;
    }
}
