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
            this.lblDDD = new System.Windows.Forms.Label();
            this.lblCodigoEstado = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnBuscarEstado = new Pilates.YControls.YButton();
            this.txtCidade = new Pilates.YControls.YTextBox();
            this.txtDDD = new Pilates.YControls.YTextBox();
            this.txtCodigoEstado = new Pilates.YControls.YTextBox();
            this.txtEstado = new Pilates.YControls.YTextBox();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbStatus
            // 
            this.gbStatus.Location = new System.Drawing.Point(271, 19);
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
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(264, 405);
            this.btnSalvar.TabIndex = 6;
            // 
            // txtCodigo
            // 
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
            this.btnSair.Location = new System.Drawing.Point(353, 405);
            this.btnSair.TabIndex = 7;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(20, 88);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(47, 13);
            this.lblCidade.TabIndex = 9;
            this.lblCidade.Text = "Cidade:*";
            // 
            // lblDDD
            // 
            this.lblDDD.AutoSize = true;
            this.lblDDD.Location = new System.Drawing.Point(20, 163);
            this.lblDDD.Name = "lblDDD";
            this.lblDDD.Size = new System.Drawing.Size(38, 13);
            this.lblDDD.TabIndex = 11;
            this.lblDDD.Text = "DDD:*";
            // 
            // lblCodigoEstado
            // 
            this.lblCodigoEstado.AutoSize = true;
            this.lblCodigoEstado.Location = new System.Drawing.Point(20, 239);
            this.lblCodigoEstado.Name = "lblCodigoEstado";
            this.lblCodigoEstado.Size = new System.Drawing.Size(83, 13);
            this.lblCodigoEstado.TabIndex = 13;
            this.lblCodigoEstado.Text = "Codigo Estado:*";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(180, 241);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(47, 13);
            this.lblEstado.TabIndex = 16;
            this.lblEstado.Text = "Estado:*";
            // 
            // btnBuscarEstado
            // 
            this.btnBuscarEstado.BackColor = System.Drawing.Color.GhostWhite;
            this.btnBuscarEstado.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnBuscarEstado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btnBuscarEstado.BorderRadius = 8;
            this.btnBuscarEstado.BorderSize = 1;
            this.btnBuscarEstado.FlatAppearance.BorderSize = 0;
            this.btnBuscarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEstado.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnBuscarEstado.Location = new System.Drawing.Point(113, 254);
            this.btnBuscarEstado.Name = "btnBuscarEstado";
            this.btnBuscarEstado.Size = new System.Drawing.Size(61, 31);
            this.btnBuscarEstado.TabIndex = 21;
            this.btnBuscarEstado.Text = "Buscar";
            this.btnBuscarEstado.TextColor = System.Drawing.Color.DarkViolet;
            this.btnBuscarEstado.UseVisualStyleBackColor = false;
            this.btnBuscarEstado.Click += new System.EventHandler(this.btnBuscarEstado_Click);
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.SystemColors.Window;
            this.txtCidade.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCidade.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtCidade.BorderRadius = 8;
            this.txtCidade.BorderSize = 1;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.DisabledBackColor = System.Drawing.Color.White;
            this.txtCidade.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCidade.DisabledForeColor = System.Drawing.Color.White;
            this.txtCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCidade.Location = new System.Drawing.Point(23, 104);
            this.txtCidade.MaxLength = 32767;
            this.txtCidade.Multiline = false;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCidade.PasswordChar = false;
            this.txtCidade.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCidade.PlaceholderText = "";
            this.txtCidade.Size = new System.Drawing.Size(413, 28);
            this.txtCidade.TabIndex = 22;
            this.txtCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCidade.Texts = "";
            this.txtCidade.UnderlinedStyle = false;
            this.txtCidade.Leave += new System.EventHandler(this.txtCidade_Leave);
            // 
            // txtDDD
            // 
            this.txtDDD.BackColor = System.Drawing.SystemColors.Window;
            this.txtDDD.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDDD.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtDDD.BorderRadius = 8;
            this.txtDDD.BorderSize = 1;
            this.txtDDD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDDD.DisabledBackColor = System.Drawing.Color.White;
            this.txtDDD.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtDDD.DisabledForeColor = System.Drawing.Color.White;
            this.txtDDD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDDD.Location = new System.Drawing.Point(23, 179);
            this.txtDDD.MaxLength = 32767;
            this.txtDDD.Multiline = false;
            this.txtDDD.Name = "txtDDD";
            this.txtDDD.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDDD.PasswordChar = false;
            this.txtDDD.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDDD.PlaceholderText = "";
            this.txtDDD.Size = new System.Drawing.Size(84, 28);
            this.txtDDD.TabIndex = 23;
            this.txtDDD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDDD.Texts = "";
            this.txtDDD.UnderlinedStyle = false;
            this.txtDDD.Leave += new System.EventHandler(this.txtDDD_Leave);
            // 
            // txtCodigoEstado
            // 
            this.txtCodigoEstado.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigoEstado.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCodigoEstado.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtCodigoEstado.BorderRadius = 8;
            this.txtCodigoEstado.BorderSize = 1;
            this.txtCodigoEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoEstado.DisabledBackColor = System.Drawing.Color.White;
            this.txtCodigoEstado.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCodigoEstado.DisabledForeColor = System.Drawing.Color.White;
            this.txtCodigoEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCodigoEstado.Location = new System.Drawing.Point(23, 256);
            this.txtCodigoEstado.MaxLength = 32767;
            this.txtCodigoEstado.Multiline = false;
            this.txtCodigoEstado.Name = "txtCodigoEstado";
            this.txtCodigoEstado.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodigoEstado.PasswordChar = false;
            this.txtCodigoEstado.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodigoEstado.PlaceholderText = "";
            this.txtCodigoEstado.Size = new System.Drawing.Size(84, 28);
            this.txtCodigoEstado.TabIndex = 24;
            this.txtCodigoEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodigoEstado.Texts = "";
            this.txtCodigoEstado.UnderlinedStyle = false;
            this.txtCodigoEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoEstado_KeyPress);
            this.txtCodigoEstado.Leave += new System.EventHandler(this.txtCodigoEstado_Leave);
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.SystemColors.Window;
            this.txtEstado.BorderColor = System.Drawing.Color.DarkGray;
            this.txtEstado.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtEstado.BorderRadius = 8;
            this.txtEstado.BorderSize = 1;
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.DisabledBackColor = System.Drawing.Color.White;
            this.txtEstado.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtEstado.DisabledForeColor = System.Drawing.Color.White;
            this.txtEstado.Enabled = false;
            this.txtEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtEstado.Location = new System.Drawing.Point(180, 257);
            this.txtEstado.MaxLength = 32767;
            this.txtEstado.Multiline = false;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtEstado.PasswordChar = false;
            this.txtEstado.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEstado.PlaceholderText = "";
            this.txtEstado.Size = new System.Drawing.Size(256, 28);
            this.txtEstado.TabIndex = 25;
            this.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEstado.Texts = "";
            this.txtEstado.UnderlinedStyle = false;
            // 
            // CadastroCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCodigoEstado);
            this.Controls.Add(this.txtDDD);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.btnBuscarEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCodigoEstado);
            this.Controls.Add(this.lblDDD);
            this.Controls.Add(this.lblCidade);
            this.Name = "CadastroCidade";
            this.Text = "Cadastro de Cidade";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroCidade_FormClosed);
            this.Load += new System.EventHandler(this.CadastroCidade_Load);
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
            this.Controls.SetChildIndex(this.lblDDD, 0);
            this.Controls.SetChildIndex(this.lblCodigoEstado, 0);
            this.Controls.SetChildIndex(this.lblEstado, 0);
            this.Controls.SetChildIndex(this.btnBuscarEstado, 0);
            this.Controls.SetChildIndex(this.txtCidade, 0);
            this.Controls.SetChildIndex(this.txtDDD, 0);
            this.Controls.SetChildIndex(this.txtCodigoEstado, 0);
            this.Controls.SetChildIndex(this.txtEstado, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblDDD;
        private System.Windows.Forms.Label lblCodigoEstado;
        private System.Windows.Forms.Label lblEstado;
        protected YControls.YButton btnBuscarEstado;
        private YControls.YTextBox txtCidade;
        private YControls.YTextBox txtDDD;
        private YControls.YTextBox txtCodigoEstado;
        private YControls.YTextBox txtEstado;
    }
}
