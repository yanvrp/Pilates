namespace Pilates.Views
{
    partial class CadastroDoenca
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
            this.lblDoenca = new System.Windows.Forms.Label();
            this.lblCid = new System.Windows.Forms.Label();
            this.txtDescricao = new Pilates.YControls.YTextBox();
            this.txtDoenca = new Pilates.YControls.YTextBox();
            this.txtCID = new Pilates.YControls.YTextBox();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(23, 21);
            // 
            // gbStatus
            // 
            this.gbStatus.Location = new System.Drawing.Point(347, 21);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(340, 405);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(23, 37);
            this.txtCodigo.Texts = "0";
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Size = new System.Drawing.Size(92, 27);
            this.txtDataCadastro.Texts = "24/10/2024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Texts = "24/10/2024";
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(429, 405);
            this.btnSair.TabIndex = 4;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(20, 158);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(62, 13);
            this.lblDescricao.TabIndex = 15;
            this.lblDescricao.Text = "Descrição:*";
            // 
            // lblDoenca
            // 
            this.lblDoenca.AutoSize = true;
            this.lblDoenca.Location = new System.Drawing.Point(20, 87);
            this.lblDoenca.Name = "lblDoenca";
            this.lblDoenca.Size = new System.Drawing.Size(52, 13);
            this.lblDoenca.TabIndex = 13;
            this.lblDoenca.Text = "Doenca:*";
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.Location = new System.Drawing.Point(304, 88);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(28, 13);
            this.lblCid.TabIndex = 18;
            this.lblCid.Text = "CID:";
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
            this.txtDescricao.Location = new System.Drawing.Point(23, 174);
            this.txtDescricao.MaxLength = 32767;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDescricao.PasswordChar = false;
            this.txtDescricao.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDescricao.PlaceholderText = "";
            this.txtDescricao.Size = new System.Drawing.Size(489, 107);
            this.txtDescricao.TabIndex = 21;
            this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescricao.Texts = "";
            this.txtDescricao.UnderlinedStyle = false;
            // 
            // txtDoenca
            // 
            this.txtDoenca.BackColor = System.Drawing.SystemColors.Window;
            this.txtDoenca.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDoenca.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtDoenca.BorderRadius = 8;
            this.txtDoenca.BorderSize = 1;
            this.txtDoenca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDoenca.DisabledBackColor = System.Drawing.Color.White;
            this.txtDoenca.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtDoenca.DisabledForeColor = System.Drawing.Color.White;
            this.txtDoenca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDoenca.Location = new System.Drawing.Point(23, 104);
            this.txtDoenca.MaxLength = 32767;
            this.txtDoenca.Multiline = false;
            this.txtDoenca.Name = "txtDoenca";
            this.txtDoenca.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDoenca.PasswordChar = false;
            this.txtDoenca.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDoenca.PlaceholderText = "";
            this.txtDoenca.Size = new System.Drawing.Size(263, 28);
            this.txtDoenca.TabIndex = 22;
            this.txtDoenca.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDoenca.Texts = "";
            this.txtDoenca.UnderlinedStyle = false;
            // 
            // txtCID
            // 
            this.txtCID.BackColor = System.Drawing.SystemColors.Window;
            this.txtCID.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCID.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtCID.BorderRadius = 8;
            this.txtCID.BorderSize = 1;
            this.txtCID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCID.DisabledBackColor = System.Drawing.Color.White;
            this.txtCID.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCID.DisabledForeColor = System.Drawing.Color.White;
            this.txtCID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCID.Location = new System.Drawing.Point(307, 104);
            this.txtCID.MaxLength = 32767;
            this.txtCID.Multiline = false;
            this.txtCID.Name = "txtCID";
            this.txtCID.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCID.PasswordChar = false;
            this.txtCID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCID.PlaceholderText = "";
            this.txtCID.Size = new System.Drawing.Size(205, 28);
            this.txtCID.TabIndex = 23;
            this.txtCID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCID.Texts = "";
            this.txtCID.UnderlinedStyle = false;
            // 
            // CadastroDoenca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(538, 450);
            this.Controls.Add(this.txtCID);
            this.Controls.Add(this.txtDoenca);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblCid);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblDoenca);
            this.Name = "CadastroDoenca";
            this.Text = "Cadastro de Doença";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroDoenca_FormClosed);
            this.Load += new System.EventHandler(this.CadastroDoenca_Load);
            this.Controls.SetChildIndex(this.lblDoenca, 0);
            this.Controls.SetChildIndex(this.lblDescricao, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.gbStatus, 0);
            this.Controls.SetChildIndex(this.lblCid, 0);
            this.Controls.SetChildIndex(this.txtDescricao, 0);
            this.Controls.SetChildIndex(this.txtDoenca, 0);
            this.Controls.SetChildIndex(this.txtCID, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblDoenca;
        private System.Windows.Forms.Label lblCid;
        private YControls.YTextBox txtDescricao;
        private YControls.YTextBox txtDoenca;
        private YControls.YTextBox txtCID;
    }
}
