namespace Pilates.Views
{
    partial class CadastroAgenda
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
            this.txtAluno = new Pilates.YControls.YTextBox();
            this.btnPesquisarAluno = new Pilates.YControls.YButton();
            this.txtCodAluno = new Pilates.YControls.YTextBox();
            this.lblAluno = new System.Windows.Forms.Label();
            this.lblCodAluno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMinutos = new System.Windows.Forms.ComboBox();
            this.cbHoras = new System.Windows.Forms.ComboBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.txtData = new Pilates.YControls.YMaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.txtCodContrato = new Pilates.YControls.YTextBox();
            this.lblCodContrato = new System.Windows.Forms.Label();
            this.txtDataCancelamento = new Pilates.YControls.YMaskedTextBox();
            this.lblDataCancelamento = new System.Windows.Forms.Label();
            this.btnCancelar = new Pilates.YControls.YButton();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(110, 316);
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(22, 317);
            // 
            // gbStatus
            // 
            this.gbStatus.Location = new System.Drawing.Point(346, 12);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(339, 329);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Texts = "0";
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(25, 333);
            this.txtDataCadastro.Size = new System.Drawing.Size(82, 27);
            this.txtDataCadastro.Texts = "30/10/2024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(113, 332);
            this.txtDataUltAlt.Size = new System.Drawing.Size(82, 27);
            this.txtDataUltAlt.Texts = "30/10/2024";
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(428, 329);
            // 
            // txtAluno
            // 
            this.txtAluno.BackColor = System.Drawing.SystemColors.Window;
            this.txtAluno.BorderColor = System.Drawing.Color.DarkGray;
            this.txtAluno.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtAluno.BorderRadius = 8;
            this.txtAluno.BorderSize = 1;
            this.txtAluno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAluno.DisabledBackColor = System.Drawing.Color.White;
            this.txtAluno.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtAluno.DisabledForeColor = System.Drawing.Color.White;
            this.txtAluno.Enabled = false;
            this.txtAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtAluno.Location = new System.Drawing.Point(180, 104);
            this.txtAluno.MaxLength = 32767;
            this.txtAluno.Multiline = false;
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtAluno.PasswordChar = false;
            this.txtAluno.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAluno.PlaceholderText = "";
            this.txtAluno.Size = new System.Drawing.Size(242, 28);
            this.txtAluno.TabIndex = 54;
            this.txtAluno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAluno.Texts = "";
            this.txtAluno.UnderlinedStyle = false;
            // 
            // btnPesquisarAluno
            // 
            this.btnPesquisarAluno.BackColor = System.Drawing.Color.GhostWhite;
            this.btnPesquisarAluno.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnPesquisarAluno.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btnPesquisarAluno.BorderRadius = 8;
            this.btnPesquisarAluno.BorderSize = 1;
            this.btnPesquisarAluno.FlatAppearance.BorderSize = 0;
            this.btnPesquisarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarAluno.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnPesquisarAluno.Location = new System.Drawing.Point(113, 102);
            this.btnPesquisarAluno.Name = "btnPesquisarAluno";
            this.btnPesquisarAluno.Size = new System.Drawing.Size(61, 31);
            this.btnPesquisarAluno.TabIndex = 53;
            this.btnPesquisarAluno.Text = "Buscar";
            this.btnPesquisarAluno.TextColor = System.Drawing.Color.DarkViolet;
            this.btnPesquisarAluno.UseVisualStyleBackColor = false;
            this.btnPesquisarAluno.Click += new System.EventHandler(this.btnPesquisarAluno_Click);
            // 
            // txtCodAluno
            // 
            this.txtCodAluno.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodAluno.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCodAluno.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtCodAluno.BorderRadius = 8;
            this.txtCodAluno.BorderSize = 1;
            this.txtCodAluno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodAluno.DisabledBackColor = System.Drawing.Color.White;
            this.txtCodAluno.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCodAluno.DisabledForeColor = System.Drawing.Color.White;
            this.txtCodAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCodAluno.Location = new System.Drawing.Point(23, 104);
            this.txtCodAluno.MaxLength = 5;
            this.txtCodAluno.Multiline = false;
            this.txtCodAluno.Name = "txtCodAluno";
            this.txtCodAluno.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodAluno.PasswordChar = false;
            this.txtCodAluno.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodAluno.PlaceholderText = "";
            this.txtCodAluno.Size = new System.Drawing.Size(84, 28);
            this.txtCodAluno.TabIndex = 1;
            this.txtCodAluno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodAluno.Texts = "";
            this.txtCodAluno.UnderlinedStyle = false;
            this.txtCodAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodAluno_KeyPress);
            this.txtCodAluno.Leave += new System.EventHandler(this.txtCodAluno_Leave);
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(177, 88);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(37, 13);
            this.lblAluno.TabIndex = 51;
            this.lblAluno.Text = "Aluno:";
            // 
            // lblCodAluno
            // 
            this.lblCodAluno.AutoSize = true;
            this.lblCodAluno.Location = new System.Drawing.Point(22, 87);
            this.lblCodAluno.Name = "lblCodAluno";
            this.lblCodAluno.Size = new System.Drawing.Size(66, 13);
            this.lblCodAluno.TabIndex = 50;
            this.lblCodAluno.Text = "Cód. Aluno*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 16);
            this.label2.TabIndex = 68;
            this.label2.Text = ":";
            // 
            // cbMinutos
            // 
            this.cbMinutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMinutos.FormattingEnabled = true;
            this.cbMinutos.Items.AddRange(new object[] {
            "00",
            "30"});
            this.cbMinutos.Location = new System.Drawing.Point(232, 184);
            this.cbMinutos.Name = "cbMinutos";
            this.cbMinutos.Size = new System.Drawing.Size(57, 21);
            this.cbMinutos.TabIndex = 5;
            // 
            // cbHoras
            // 
            this.cbHoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHoras.FormattingEnabled = true;
            this.cbHoras.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22"});
            this.cbHoras.Location = new System.Drawing.Point(159, 184);
            this.cbHoras.Name = "cbHoras";
            this.cbHoras.Size = new System.Drawing.Size(57, 21);
            this.cbHoras.TabIndex = 4;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(156, 163);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(48, 13);
            this.lblHorario.TabIndex = 65;
            this.lblHorario.Text = "Horário*:";
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.SystemColors.Window;
            this.txtData.BorderColor = System.Drawing.Color.DarkGray;
            this.txtData.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtData.BorderRadius = 8;
            this.txtData.BorderSize = 1;
            this.txtData.DisabledBackColor = System.Drawing.Color.White;
            this.txtData.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtData.DisabledForeColor = System.Drawing.Color.White;
            this.txtData.EnabledBackColor = System.Drawing.Color.White;
            this.txtData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtData.Location = new System.Drawing.Point(25, 179);
            this.txtData.Mask = "00/00/0000";
            this.txtData.MaxLength = 32767;
            this.txtData.Multiline = false;
            this.txtData.Name = "txtData";
            this.txtData.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtData.PasswordChar = false;
            this.txtData.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtData.PlaceholderText = "";
            this.txtData.Size = new System.Drawing.Size(95, 27);
            this.txtData.TabIndex = 3;
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtData.Texts = "  /  /";
            this.txtData.UnderlinedStyle = false;
            this.txtData.Leave += new System.EventHandler(this.txtData_Leave);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(22, 163);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(37, 13);
            this.lblData.TabIndex = 70;
            this.lblData.Text = "Data*:";
            // 
            // cbSituacao
            // 
            this.cbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Items.AddRange(new object[] {
            "REPOSIÇÃO",
            "EXPERIMENTAL"});
            this.cbSituacao.Location = new System.Drawing.Point(329, 184);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(182, 21);
            this.cbSituacao.TabIndex = 6;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(324, 168);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(52, 13);
            this.lblSituacao.TabIndex = 72;
            this.lblSituacao.Text = "Situação:";
            // 
            // txtCodContrato
            // 
            this.txtCodContrato.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodContrato.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCodContrato.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtCodContrato.BorderRadius = 8;
            this.txtCodContrato.BorderSize = 1;
            this.txtCodContrato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodContrato.DisabledBackColor = System.Drawing.Color.White;
            this.txtCodContrato.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCodContrato.DisabledForeColor = System.Drawing.Color.White;
            this.txtCodContrato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCodContrato.Location = new System.Drawing.Point(437, 105);
            this.txtCodContrato.MaxLength = 5;
            this.txtCodContrato.Multiline = false;
            this.txtCodContrato.Name = "txtCodContrato";
            this.txtCodContrato.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodContrato.PasswordChar = false;
            this.txtCodContrato.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodContrato.PlaceholderText = "";
            this.txtCodContrato.Size = new System.Drawing.Size(74, 28);
            this.txtCodContrato.TabIndex = 2;
            this.txtCodContrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodContrato.Texts = "";
            this.txtCodContrato.UnderlinedStyle = false;
            this.txtCodContrato.Visible = false;
            this.txtCodContrato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodAluno_KeyPress);
            this.txtCodContrato.Leave += new System.EventHandler(this.txtCodContrato_Leave);
            // 
            // lblCodContrato
            // 
            this.lblCodContrato.AutoSize = true;
            this.lblCodContrato.Location = new System.Drawing.Point(436, 88);
            this.lblCodContrato.Name = "lblCodContrato";
            this.lblCodContrato.Size = new System.Drawing.Size(75, 13);
            this.lblCodContrato.TabIndex = 73;
            this.lblCodContrato.Text = "Cód. Contrato:";
            this.lblCodContrato.Visible = false;
            // 
            // txtDataCancelamento
            // 
            this.txtDataCancelamento.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataCancelamento.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDataCancelamento.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtDataCancelamento.BorderRadius = 8;
            this.txtDataCancelamento.BorderSize = 1;
            this.txtDataCancelamento.DisabledBackColor = System.Drawing.Color.White;
            this.txtDataCancelamento.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtDataCancelamento.DisabledForeColor = System.Drawing.Color.White;
            this.txtDataCancelamento.Enabled = false;
            this.txtDataCancelamento.EnabledBackColor = System.Drawing.Color.White;
            this.txtDataCancelamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDataCancelamento.Location = new System.Drawing.Point(23, 278);
            this.txtDataCancelamento.Mask = "00/00/0000";
            this.txtDataCancelamento.MaxLength = 32767;
            this.txtDataCancelamento.Multiline = false;
            this.txtDataCancelamento.Name = "txtDataCancelamento";
            this.txtDataCancelamento.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDataCancelamento.PasswordChar = false;
            this.txtDataCancelamento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDataCancelamento.PlaceholderText = "";
            this.txtDataCancelamento.Size = new System.Drawing.Size(84, 27);
            this.txtDataCancelamento.TabIndex = 75;
            this.txtDataCancelamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataCancelamento.Texts = "  /  /";
            this.txtDataCancelamento.UnderlinedStyle = false;
            this.txtDataCancelamento.Visible = false;
            // 
            // lblDataCancelamento
            // 
            this.lblDataCancelamento.AutoSize = true;
            this.lblDataCancelamento.Location = new System.Drawing.Point(21, 262);
            this.lblDataCancelamento.Name = "lblDataCancelamento";
            this.lblDataCancelamento.Size = new System.Drawing.Size(104, 13);
            this.lblDataCancelamento.TabIndex = 74;
            this.lblDataCancelamento.Text = "Data Cancelamento:";
            this.lblDataCancelamento.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.GhostWhite;
            this.btnCancelar.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnCancelar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.BorderRadius = 8;
            this.btnCancelar.BorderSize = 1;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Location = new System.Drawing.Point(250, 329);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 31);
            this.btnCancelar.TabIndex = 102;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CadastroAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(533, 378);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtDataCancelamento);
            this.Controls.Add(this.lblDataCancelamento);
            this.Controls.Add(this.txtCodContrato);
            this.Controls.Add(this.lblCodContrato);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.cbSituacao);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMinutos);
            this.Controls.Add(this.cbHoras);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.txtAluno);
            this.Controls.Add(this.btnPesquisarAluno);
            this.Controls.Add(this.txtCodAluno);
            this.Controls.Add(this.lblAluno);
            this.Controls.Add(this.lblCodAluno);
            this.Name = "CadastroAgenda";
            this.Text = "Cadastro Agenda";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroAgenda_FormClosed);
            this.Load += new System.EventHandler(this.CadastroAgenda_Load);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.gbStatus, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblCodAluno, 0);
            this.Controls.SetChildIndex(this.lblAluno, 0);
            this.Controls.SetChildIndex(this.txtCodAluno, 0);
            this.Controls.SetChildIndex(this.btnPesquisarAluno, 0);
            this.Controls.SetChildIndex(this.txtAluno, 0);
            this.Controls.SetChildIndex(this.lblHorario, 0);
            this.Controls.SetChildIndex(this.cbHoras, 0);
            this.Controls.SetChildIndex(this.cbMinutos, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtData, 0);
            this.Controls.SetChildIndex(this.lblData, 0);
            this.Controls.SetChildIndex(this.cbSituacao, 0);
            this.Controls.SetChildIndex(this.lblSituacao, 0);
            this.Controls.SetChildIndex(this.lblCodContrato, 0);
            this.Controls.SetChildIndex(this.txtCodContrato, 0);
            this.Controls.SetChildIndex(this.lblDataCancelamento, 0);
            this.Controls.SetChildIndex(this.txtDataCancelamento, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private YControls.YTextBox txtAluno;
        protected YControls.YButton btnPesquisarAluno;
        private YControls.YTextBox txtCodAluno;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.Label lblCodAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMinutos;
        private System.Windows.Forms.ComboBox cbHoras;
        private System.Windows.Forms.Label lblHorario;
        private YControls.YMaskedTextBox txtData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ComboBox cbSituacao;
        private System.Windows.Forms.Label lblSituacao;
        private YControls.YTextBox txtCodContrato;
        private System.Windows.Forms.Label lblCodContrato;
        private YControls.YMaskedTextBox txtDataCancelamento;
        private System.Windows.Forms.Label lblDataCancelamento;
        protected YControls.YButton btnCancelar;
    }
}
