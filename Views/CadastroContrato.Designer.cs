namespace Pilates.Views
{
    partial class CadastroContrato
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
            this.lblCodAluno = new System.Windows.Forms.Label();
            this.lblAluno = new System.Windows.Forms.Label();
            this.lblCodPrograma = new System.Windows.Forms.Label();
            this.lblPrograma = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.ComboBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblCodCondPag = new System.Windows.Forms.Label();
            this.lblCondPagamento = new System.Windows.Forms.Label();
            this.dataGridViewParcelas = new System.Windows.Forms.DataGridView();
            this.Parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDiaPagamento = new System.Windows.Forms.Label();
            this.lblInicioPrograma = new System.Windows.Forms.Label();
            this.lblDataCancelamento = new System.Windows.Forms.Label();
            this.lblAulas = new System.Windows.Forms.Label();
            this.lblTipoPrograma = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInicioPrograma = new Pilates.YControls.YMaskedTextBox();
            this.txtCodAluno = new Pilates.YControls.YTextBox();
            this.txtCodPrograma = new Pilates.YControls.YTextBox();
            this.btnPesquisarAluno = new Pilates.YControls.YButton();
            this.btnPesquisarPrograma = new Pilates.YControls.YButton();
            this.txtAluno = new Pilates.YControls.YTextBox();
            this.txtPrograma = new Pilates.YControls.YTextBox();
            this.txtAulas = new Pilates.YControls.YTextBox();
            this.txtTipoPrograma = new Pilates.YControls.YTextBox();
            this.txtValorMensal = new Pilates.YControls.YTextBox();
            this.txtValorTotal = new Pilates.YControls.YTextBox();
            this.txtDiaPagar = new Pilates.YControls.YTextBox();
            this.txtCodCondPag = new Pilates.YControls.YTextBox();
            this.txtCondPagamento = new Pilates.YControls.YTextBox();
            this.btnPesquisarCond = new Pilates.YControls.YButton();
            this.btnAdicionar = new Pilates.YControls.YButton();
            this.txtDataCancelamento = new Pilates.YControls.YMaskedTextBox();
            this.cbHoras = new System.Windows.Forms.ComboBox();
            this.cbMinutos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSegunda = new System.Windows.Forms.CheckBox();
            this.cbSabado = new System.Windows.Forms.CheckBox();
            this.cbSexta = new System.Windows.Forms.CheckBox();
            this.cbQuinta = new System.Windows.Forms.CheckBox();
            this.cbQuarta = new System.Windows.Forms.CheckBox();
            this.cbTerca = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new Pilates.YControls.YButton();
            this.txtFinalContrato = new Pilates.YControls.YMaskedTextBox();
            this.lblFinalContrato = new System.Windows.Forms.Label();
            this.gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParcelas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(16, 19);
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(116, 566);
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(20, 565);
            // 
            // gbStatus
            // 
            this.gbStatus.Location = new System.Drawing.Point(480, 19);
            this.gbStatus.Size = new System.Drawing.Size(165, 55);
            // 
            // rbInativo
            // 
            this.rbInativo.Location = new System.Drawing.Point(90, 23);
            // 
            // rbAtivo
            // 
            this.rbAtivo.Location = new System.Drawing.Point(19, 23);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(473, 577);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(19, 35);
            this.txtCodigo.Size = new System.Drawing.Size(76, 28);
            this.txtCodigo.Texts = "0";
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(20, 581);
            this.txtDataCadastro.Size = new System.Drawing.Size(85, 27);
            this.txtDataCadastro.Texts = "25/10/2024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(119, 581);
            this.txtDataUltAlt.Size = new System.Drawing.Size(79, 27);
            this.txtDataUltAlt.Texts = "25/10/2024";
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(562, 577);
            // 
            // lblCodAluno
            // 
            this.lblCodAluno.AutoSize = true;
            this.lblCodAluno.Location = new System.Drawing.Point(17, 82);
            this.lblCodAluno.Name = "lblCodAluno";
            this.lblCodAluno.Size = new System.Drawing.Size(66, 13);
            this.lblCodAluno.TabIndex = 2;
            this.lblCodAluno.Text = "Cód. Aluno*:";
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(180, 82);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(37, 13);
            this.lblAluno.TabIndex = 10;
            this.lblAluno.Text = "Aluno:";
            // 
            // lblCodPrograma
            // 
            this.lblCodPrograma.AutoSize = true;
            this.lblCodPrograma.Location = new System.Drawing.Point(17, 146);
            this.lblCodPrograma.Name = "lblCodPrograma";
            this.lblCodPrograma.Size = new System.Drawing.Size(84, 13);
            this.lblCodPrograma.TabIndex = 12;
            this.lblCodPrograma.Text = "Cód. Programa*:";
            // 
            // lblPrograma
            // 
            this.lblPrograma.AutoSize = true;
            this.lblPrograma.Location = new System.Drawing.Point(180, 146);
            this.lblPrograma.Name = "lblPrograma";
            this.lblPrograma.Size = new System.Drawing.Size(55, 13);
            this.lblPrograma.TabIndex = 14;
            this.lblPrograma.Text = "Programa:";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(219, 284);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(61, 13);
            this.lblValorTotal.TabIndex = 16;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(104, 283);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(48, 13);
            this.lblPeriodo.TabIndex = 18;
            this.lblPeriodo.Text = "Período:";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPeriodo.FormattingEnabled = true;
            this.txtPeriodo.Items.AddRange(new object[] {
            "MENSAL",
            "TRIMESTRAL",
            "SEMESTRAL",
            "ANUAL"});
            this.txtPeriodo.Location = new System.Drawing.Point(107, 304);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(100, 21);
            this.txtPeriodo.TabIndex = 6;
            this.txtPeriodo.SelectedIndexChanged += new System.EventHandler(this.txtPeriodo_SelectedIndexChanged);
            this.txtPeriodo.Leave += new System.EventHandler(this.txtPeriodo_Leave);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(219, 216);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(48, 13);
            this.lblHorario.TabIndex = 20;
            this.lblHorario.Text = "Horário*:";
            // 
            // lblCodCondPag
            // 
            this.lblCodCondPag.AutoSize = true;
            this.lblCodCondPag.Location = new System.Drawing.Point(16, 343);
            this.lblCodCondPag.Name = "lblCodCondPag";
            this.lblCodCondPag.Size = new System.Drawing.Size(47, 13);
            this.lblCodCondPag.TabIndex = 22;
            this.lblCodCondPag.Text = "Código:*";
            // 
            // lblCondPagamento
            // 
            this.lblCondPagamento.AutoSize = true;
            this.lblCondPagamento.Location = new System.Drawing.Point(180, 345);
            this.lblCondPagamento.Name = "lblCondPagamento";
            this.lblCondPagamento.Size = new System.Drawing.Size(126, 13);
            this.lblCondPagamento.TabIndex = 25;
            this.lblCondPagamento.Text = "Condição de pagamento:";
            // 
            // dataGridViewParcelas
            // 
            this.dataGridViewParcelas.AllowUserToAddRows = false;
            this.dataGridViewParcelas.AllowUserToDeleteRows = false;
            this.dataGridViewParcelas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dataGridViewParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Parcela,
            this.idFormaPagamento,
            this.formaPagamento,
            this.dataVencimento,
            this.valorParcela});
            this.dataGridViewParcelas.Location = new System.Drawing.Point(20, 406);
            this.dataGridViewParcelas.Name = "dataGridViewParcelas";
            this.dataGridViewParcelas.Size = new System.Drawing.Size(625, 147);
            this.dataGridViewParcelas.TabIndex = 27;
            // 
            // Parcela
            // 
            this.Parcela.HeaderText = "Parcela";
            this.Parcela.Name = "Parcela";
            // 
            // idFormaPagamento
            // 
            this.idFormaPagamento.HeaderText = "Cód. Forma Pagamento";
            this.idFormaPagamento.Name = "idFormaPagamento";
            // 
            // formaPagamento
            // 
            this.formaPagamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.formaPagamento.HeaderText = "Forma de Pagamento";
            this.formaPagamento.Name = "formaPagamento";
            // 
            // dataVencimento
            // 
            this.dataVencimento.HeaderText = "Data de vencimento";
            this.dataVencimento.Name = "dataVencimento";
            // 
            // valorParcela
            // 
            this.valorParcela.HeaderText = "Valor Parcela";
            this.valorParcela.Name = "valorParcela";
            // 
            // lblDiaPagamento
            // 
            this.lblDiaPagamento.AutoSize = true;
            this.lblDiaPagamento.Location = new System.Drawing.Point(316, 283);
            this.lblDiaPagamento.Name = "lblDiaPagamento";
            this.lblDiaPagamento.Size = new System.Drawing.Size(69, 13);
            this.lblDiaPagamento.TabIndex = 31;
            this.lblDiaPagamento.Text = "Dia a pagar:*";
            // 
            // lblInicioPrograma
            // 
            this.lblInicioPrograma.AutoSize = true;
            this.lblInicioPrograma.Location = new System.Drawing.Point(105, 19);
            this.lblInicioPrograma.Name = "lblInicioPrograma";
            this.lblInicioPrograma.Size = new System.Drawing.Size(97, 13);
            this.lblInicioPrograma.TabIndex = 33;
            this.lblInicioPrograma.Text = "Inicio do Contrato*:";
            // 
            // lblDataCancelamento
            // 
            this.lblDataCancelamento.AutoSize = true;
            this.lblDataCancelamento.Location = new System.Drawing.Point(210, 566);
            this.lblDataCancelamento.Name = "lblDataCancelamento";
            this.lblDataCancelamento.Size = new System.Drawing.Size(104, 13);
            this.lblDataCancelamento.TabIndex = 35;
            this.lblDataCancelamento.Text = "Data Cancelamento:";
            // 
            // lblAulas
            // 
            this.lblAulas.AutoSize = true;
            this.lblAulas.Location = new System.Drawing.Point(17, 216);
            this.lblAulas.Name = "lblAulas";
            this.lblAulas.Size = new System.Drawing.Size(83, 13);
            this.lblAulas.TabIndex = 39;
            this.lblAulas.Text = "Aulas semanais:";
            // 
            // lblTipoPrograma
            // 
            this.lblTipoPrograma.AutoSize = true;
            this.lblTipoPrograma.Location = new System.Drawing.Point(105, 216);
            this.lblTipoPrograma.Name = "lblTipoPrograma";
            this.lblTipoPrograma.Size = new System.Drawing.Size(79, 13);
            this.lblTipoPrograma.TabIndex = 37;
            this.lblTipoPrograma.Text = "Tipo Programa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Valor mensal:";
            // 
            // txtInicioPrograma
            // 
            this.txtInicioPrograma.BackColor = System.Drawing.SystemColors.Window;
            this.txtInicioPrograma.BorderColor = System.Drawing.Color.DarkGray;
            this.txtInicioPrograma.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtInicioPrograma.BorderRadius = 8;
            this.txtInicioPrograma.BorderSize = 1;
            this.txtInicioPrograma.DisabledBackColor = System.Drawing.Color.White;
            this.txtInicioPrograma.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtInicioPrograma.DisabledForeColor = System.Drawing.Color.White;
            this.txtInicioPrograma.Enabled = false;
            this.txtInicioPrograma.EnabledBackColor = System.Drawing.Color.White;
            this.txtInicioPrograma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtInicioPrograma.Location = new System.Drawing.Point(108, 35);
            this.txtInicioPrograma.Mask = "00/00/0000";
            this.txtInicioPrograma.MaxLength = 32767;
            this.txtInicioPrograma.Multiline = false;
            this.txtInicioPrograma.Name = "txtInicioPrograma";
            this.txtInicioPrograma.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtInicioPrograma.PasswordChar = false;
            this.txtInicioPrograma.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtInicioPrograma.PlaceholderText = "";
            this.txtInicioPrograma.Size = new System.Drawing.Size(95, 27);
            this.txtInicioPrograma.TabIndex = 1;
            this.txtInicioPrograma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInicioPrograma.Texts = "  /  /";
            this.txtInicioPrograma.UnderlinedStyle = false;
            this.txtInicioPrograma.Leave += new System.EventHandler(this.txtInicioPrograma_Leave);
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
            this.txtCodAluno.Location = new System.Drawing.Point(18, 99);
            this.txtCodAluno.MaxLength = 5;
            this.txtCodAluno.Multiline = false;
            this.txtCodAluno.Name = "txtCodAluno";
            this.txtCodAluno.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodAluno.PasswordChar = false;
            this.txtCodAluno.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodAluno.PlaceholderText = "";
            this.txtCodAluno.Size = new System.Drawing.Size(77, 28);
            this.txtCodAluno.TabIndex = 2;
            this.txtCodAluno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodAluno.Texts = "";
            this.txtCodAluno.UnderlinedStyle = false;
            this.txtCodAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodAluno_KeyPress);
            this.txtCodAluno.Leave += new System.EventHandler(this.txtCodAluno_Leave);
            // 
            // txtCodPrograma
            // 
            this.txtCodPrograma.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodPrograma.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCodPrograma.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtCodPrograma.BorderRadius = 8;
            this.txtCodPrograma.BorderSize = 1;
            this.txtCodPrograma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodPrograma.DisabledBackColor = System.Drawing.Color.White;
            this.txtCodPrograma.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCodPrograma.DisabledForeColor = System.Drawing.Color.White;
            this.txtCodPrograma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCodPrograma.Location = new System.Drawing.Point(18, 162);
            this.txtCodPrograma.MaxLength = 5;
            this.txtCodPrograma.Multiline = false;
            this.txtCodPrograma.Name = "txtCodPrograma";
            this.txtCodPrograma.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodPrograma.PasswordChar = false;
            this.txtCodPrograma.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodPrograma.PlaceholderText = "";
            this.txtCodPrograma.Size = new System.Drawing.Size(77, 28);
            this.txtCodPrograma.TabIndex = 3;
            this.txtCodPrograma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodPrograma.Texts = "";
            this.txtCodPrograma.UnderlinedStyle = false;
            this.txtCodPrograma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodPrograma_KeyPress);
            this.txtCodPrograma.Leave += new System.EventHandler(this.txtCodPrograma_Leave);
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
            this.btnPesquisarAluno.Location = new System.Drawing.Point(107, 99);
            this.btnPesquisarAluno.Name = "btnPesquisarAluno";
            this.btnPesquisarAluno.Size = new System.Drawing.Size(61, 31);
            this.btnPesquisarAluno.TabIndex = 47;
            this.btnPesquisarAluno.Text = "Buscar";
            this.btnPesquisarAluno.TextColor = System.Drawing.Color.DarkViolet;
            this.btnPesquisarAluno.UseVisualStyleBackColor = false;
            this.btnPesquisarAluno.Click += new System.EventHandler(this.btnPesquisarAluno_Click);
            // 
            // btnPesquisarPrograma
            // 
            this.btnPesquisarPrograma.BackColor = System.Drawing.Color.GhostWhite;
            this.btnPesquisarPrograma.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnPesquisarPrograma.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btnPesquisarPrograma.BorderRadius = 8;
            this.btnPesquisarPrograma.BorderSize = 1;
            this.btnPesquisarPrograma.FlatAppearance.BorderSize = 0;
            this.btnPesquisarPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarPrograma.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnPesquisarPrograma.Location = new System.Drawing.Point(107, 160);
            this.btnPesquisarPrograma.Name = "btnPesquisarPrograma";
            this.btnPesquisarPrograma.Size = new System.Drawing.Size(61, 31);
            this.btnPesquisarPrograma.TabIndex = 48;
            this.btnPesquisarPrograma.Text = "Buscar";
            this.btnPesquisarPrograma.TextColor = System.Drawing.Color.DarkViolet;
            this.btnPesquisarPrograma.UseVisualStyleBackColor = false;
            this.btnPesquisarPrograma.Click += new System.EventHandler(this.btnPesquisarPrograma_Click);
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
            this.txtAluno.Location = new System.Drawing.Point(183, 99);
            this.txtAluno.MaxLength = 32767;
            this.txtAluno.Multiline = false;
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtAluno.PasswordChar = false;
            this.txtAluno.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAluno.PlaceholderText = "";
            this.txtAluno.Size = new System.Drawing.Size(331, 28);
            this.txtAluno.TabIndex = 49;
            this.txtAluno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAluno.Texts = "";
            this.txtAluno.UnderlinedStyle = false;
            // 
            // txtPrograma
            // 
            this.txtPrograma.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrograma.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPrograma.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtPrograma.BorderRadius = 8;
            this.txtPrograma.BorderSize = 1;
            this.txtPrograma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrograma.DisabledBackColor = System.Drawing.Color.White;
            this.txtPrograma.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtPrograma.DisabledForeColor = System.Drawing.Color.White;
            this.txtPrograma.Enabled = false;
            this.txtPrograma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtPrograma.Location = new System.Drawing.Point(183, 162);
            this.txtPrograma.MaxLength = 32767;
            this.txtPrograma.Multiline = false;
            this.txtPrograma.Name = "txtPrograma";
            this.txtPrograma.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtPrograma.PasswordChar = false;
            this.txtPrograma.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrograma.PlaceholderText = "";
            this.txtPrograma.Size = new System.Drawing.Size(331, 28);
            this.txtPrograma.TabIndex = 50;
            this.txtPrograma.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrograma.Texts = "";
            this.txtPrograma.UnderlinedStyle = false;
            // 
            // txtAulas
            // 
            this.txtAulas.BackColor = System.Drawing.SystemColors.Window;
            this.txtAulas.BorderColor = System.Drawing.Color.DarkGray;
            this.txtAulas.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtAulas.BorderRadius = 8;
            this.txtAulas.BorderSize = 1;
            this.txtAulas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAulas.DisabledBackColor = System.Drawing.Color.White;
            this.txtAulas.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtAulas.DisabledForeColor = System.Drawing.Color.White;
            this.txtAulas.Enabled = false;
            this.txtAulas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtAulas.Location = new System.Drawing.Point(19, 232);
            this.txtAulas.MaxLength = 32767;
            this.txtAulas.Multiline = false;
            this.txtAulas.Name = "txtAulas";
            this.txtAulas.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtAulas.PasswordChar = false;
            this.txtAulas.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAulas.PlaceholderText = "";
            this.txtAulas.Size = new System.Drawing.Size(76, 28);
            this.txtAulas.TabIndex = 4;
            this.txtAulas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAulas.Texts = "";
            this.txtAulas.UnderlinedStyle = false;
            // 
            // txtTipoPrograma
            // 
            this.txtTipoPrograma.BackColor = System.Drawing.SystemColors.Window;
            this.txtTipoPrograma.BorderColor = System.Drawing.Color.DarkGray;
            this.txtTipoPrograma.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtTipoPrograma.BorderRadius = 8;
            this.txtTipoPrograma.BorderSize = 1;
            this.txtTipoPrograma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipoPrograma.DisabledBackColor = System.Drawing.Color.White;
            this.txtTipoPrograma.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtTipoPrograma.DisabledForeColor = System.Drawing.Color.White;
            this.txtTipoPrograma.Enabled = false;
            this.txtTipoPrograma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtTipoPrograma.Location = new System.Drawing.Point(108, 232);
            this.txtTipoPrograma.MaxLength = 32767;
            this.txtTipoPrograma.Multiline = false;
            this.txtTipoPrograma.Name = "txtTipoPrograma";
            this.txtTipoPrograma.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtTipoPrograma.PasswordChar = false;
            this.txtTipoPrograma.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTipoPrograma.PlaceholderText = "";
            this.txtTipoPrograma.Size = new System.Drawing.Size(99, 28);
            this.txtTipoPrograma.TabIndex = 5;
            this.txtTipoPrograma.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTipoPrograma.Texts = "";
            this.txtTipoPrograma.UnderlinedStyle = false;
            // 
            // txtValorMensal
            // 
            this.txtValorMensal.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorMensal.BorderColor = System.Drawing.Color.DarkGray;
            this.txtValorMensal.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtValorMensal.BorderRadius = 8;
            this.txtValorMensal.BorderSize = 1;
            this.txtValorMensal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorMensal.DisabledBackColor = System.Drawing.Color.White;
            this.txtValorMensal.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtValorMensal.DisabledForeColor = System.Drawing.Color.White;
            this.txtValorMensal.Enabled = false;
            this.txtValorMensal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtValorMensal.Location = new System.Drawing.Point(19, 299);
            this.txtValorMensal.MaxLength = 32767;
            this.txtValorMensal.Multiline = false;
            this.txtValorMensal.Name = "txtValorMensal";
            this.txtValorMensal.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtValorMensal.PasswordChar = false;
            this.txtValorMensal.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtValorMensal.PlaceholderText = "";
            this.txtValorMensal.Size = new System.Drawing.Size(76, 28);
            this.txtValorMensal.TabIndex = 54;
            this.txtValorMensal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorMensal.Texts = "";
            this.txtValorMensal.UnderlinedStyle = false;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorTotal.BorderColor = System.Drawing.Color.DarkGray;
            this.txtValorTotal.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtValorTotal.BorderRadius = 8;
            this.txtValorTotal.BorderSize = 1;
            this.txtValorTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorTotal.DisabledBackColor = System.Drawing.Color.White;
            this.txtValorTotal.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtValorTotal.DisabledForeColor = System.Drawing.Color.White;
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtValorTotal.Location = new System.Drawing.Point(222, 299);
            this.txtValorTotal.MaxLength = 32767;
            this.txtValorTotal.Multiline = false;
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtValorTotal.PasswordChar = false;
            this.txtValorTotal.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtValorTotal.PlaceholderText = "";
            this.txtValorTotal.Size = new System.Drawing.Size(76, 28);
            this.txtValorTotal.TabIndex = 55;
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorTotal.Texts = "";
            this.txtValorTotal.UnderlinedStyle = false;
            // 
            // txtDiaPagar
            // 
            this.txtDiaPagar.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiaPagar.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDiaPagar.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtDiaPagar.BorderRadius = 8;
            this.txtDiaPagar.BorderSize = 1;
            this.txtDiaPagar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDiaPagar.DisabledBackColor = System.Drawing.Color.White;
            this.txtDiaPagar.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtDiaPagar.DisabledForeColor = System.Drawing.Color.White;
            this.txtDiaPagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDiaPagar.Location = new System.Drawing.Point(319, 299);
            this.txtDiaPagar.MaxLength = 3;
            this.txtDiaPagar.Multiline = false;
            this.txtDiaPagar.Name = "txtDiaPagar";
            this.txtDiaPagar.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDiaPagar.PasswordChar = false;
            this.txtDiaPagar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDiaPagar.PlaceholderText = "";
            this.txtDiaPagar.Size = new System.Drawing.Size(76, 28);
            this.txtDiaPagar.TabIndex = 7;
            this.txtDiaPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiaPagar.Texts = "";
            this.txtDiaPagar.UnderlinedStyle = false;
            this.txtDiaPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiaPagar_KeyPress);
            this.txtDiaPagar.Leave += new System.EventHandler(this.txtDiaPagar_Leave);
            // 
            // txtCodCondPag
            // 
            this.txtCodCondPag.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodCondPag.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCodCondPag.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtCodCondPag.BorderRadius = 8;
            this.txtCodCondPag.BorderSize = 1;
            this.txtCodCondPag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodCondPag.DisabledBackColor = System.Drawing.Color.White;
            this.txtCodCondPag.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCodCondPag.DisabledForeColor = System.Drawing.Color.White;
            this.txtCodCondPag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCodCondPag.Location = new System.Drawing.Point(20, 359);
            this.txtCodCondPag.MaxLength = 5;
            this.txtCodCondPag.Multiline = false;
            this.txtCodCondPag.Name = "txtCodCondPag";
            this.txtCodCondPag.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodCondPag.PasswordChar = false;
            this.txtCodCondPag.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodCondPag.PlaceholderText = "";
            this.txtCodCondPag.Size = new System.Drawing.Size(76, 28);
            this.txtCodCondPag.TabIndex = 8;
            this.txtCodCondPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodCondPag.Texts = "";
            this.txtCodCondPag.UnderlinedStyle = false;
            this.txtCodCondPag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodCondPag_KeyPress);
            this.txtCodCondPag.Leave += new System.EventHandler(this.txtCodCondPag_Leave);
            // 
            // txtCondPagamento
            // 
            this.txtCondPagamento.BackColor = System.Drawing.SystemColors.Window;
            this.txtCondPagamento.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCondPagamento.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtCondPagamento.BorderRadius = 8;
            this.txtCondPagamento.BorderSize = 1;
            this.txtCondPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCondPagamento.DisabledBackColor = System.Drawing.Color.White;
            this.txtCondPagamento.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCondPagamento.DisabledForeColor = System.Drawing.Color.White;
            this.txtCondPagamento.Enabled = false;
            this.txtCondPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCondPagamento.Location = new System.Drawing.Point(183, 359);
            this.txtCondPagamento.MaxLength = 32767;
            this.txtCondPagamento.Multiline = false;
            this.txtCondPagamento.Name = "txtCondPagamento";
            this.txtCondPagamento.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCondPagamento.PasswordChar = false;
            this.txtCondPagamento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCondPagamento.PlaceholderText = "";
            this.txtCondPagamento.Size = new System.Drawing.Size(250, 28);
            this.txtCondPagamento.TabIndex = 58;
            this.txtCondPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCondPagamento.Texts = "";
            this.txtCondPagamento.UnderlinedStyle = false;
            // 
            // btnPesquisarCond
            // 
            this.btnPesquisarCond.BackColor = System.Drawing.Color.GhostWhite;
            this.btnPesquisarCond.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnPesquisarCond.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btnPesquisarCond.BorderRadius = 8;
            this.btnPesquisarCond.BorderSize = 1;
            this.btnPesquisarCond.FlatAppearance.BorderSize = 0;
            this.btnPesquisarCond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarCond.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnPesquisarCond.Location = new System.Drawing.Point(107, 358);
            this.btnPesquisarCond.Name = "btnPesquisarCond";
            this.btnPesquisarCond.Size = new System.Drawing.Size(61, 31);
            this.btnPesquisarCond.TabIndex = 59;
            this.btnPesquisarCond.Text = "Buscar";
            this.btnPesquisarCond.TextColor = System.Drawing.Color.DarkViolet;
            this.btnPesquisarCond.UseVisualStyleBackColor = false;
            this.btnPesquisarCond.Click += new System.EventHandler(this.btnPesquisarCond_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.GhostWhite;
            this.btnAdicionar.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnAdicionar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btnAdicionar.BorderRadius = 8;
            this.btnAdicionar.BorderSize = 1;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnAdicionar.Location = new System.Drawing.Point(446, 359);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(68, 31);
            this.btnAdicionar.TabIndex = 60;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextColor = System.Drawing.Color.DarkViolet;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
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
            this.txtDataCancelamento.Location = new System.Drawing.Point(213, 581);
            this.txtDataCancelamento.Mask = "00/00/0000";
            this.txtDataCancelamento.MaxLength = 32767;
            this.txtDataCancelamento.Multiline = false;
            this.txtDataCancelamento.Name = "txtDataCancelamento";
            this.txtDataCancelamento.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDataCancelamento.PasswordChar = false;
            this.txtDataCancelamento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDataCancelamento.PlaceholderText = "";
            this.txtDataCancelamento.Size = new System.Drawing.Size(102, 27);
            this.txtDataCancelamento.TabIndex = 61;
            this.txtDataCancelamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataCancelamento.Texts = "  /  /";
            this.txtDataCancelamento.UnderlinedStyle = false;
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
            this.cbHoras.Location = new System.Drawing.Point(223, 237);
            this.cbHoras.Name = "cbHoras";
            this.cbHoras.Size = new System.Drawing.Size(57, 21);
            this.cbHoras.TabIndex = 4;
            // 
            // cbMinutos
            // 
            this.cbMinutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMinutos.FormattingEnabled = true;
            this.cbMinutos.Items.AddRange(new object[] {
            "00",
            "30"});
            this.cbMinutos.Location = new System.Drawing.Point(296, 237);
            this.cbMinutos.Name = "cbMinutos";
            this.cbMinutos.Size = new System.Drawing.Size(57, 21);
            this.cbMinutos.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = ":";
            // 
            // cbSegunda
            // 
            this.cbSegunda.AutoSize = true;
            this.cbSegunda.Location = new System.Drawing.Point(17, 19);
            this.cbSegunda.Name = "cbSegunda";
            this.cbSegunda.Size = new System.Drawing.Size(79, 17);
            this.cbSegunda.TabIndex = 65;
            this.cbSegunda.Text = "SEGUNDA";
            this.cbSegunda.UseVisualStyleBackColor = true;
            this.cbSegunda.CheckedChanged += new System.EventHandler(this.cbSegunda_CheckedChanged);
            // 
            // cbSabado
            // 
            this.cbSabado.AutoSize = true;
            this.cbSabado.Location = new System.Drawing.Point(187, 46);
            this.cbSabado.Name = "cbSabado";
            this.cbSabado.Size = new System.Drawing.Size(70, 17);
            this.cbSabado.TabIndex = 66;
            this.cbSabado.Text = "SÁBADO";
            this.cbSabado.UseVisualStyleBackColor = true;
            this.cbSabado.CheckedChanged += new System.EventHandler(this.cbSabado_CheckedChanged);
            // 
            // cbSexta
            // 
            this.cbSexta.AutoSize = true;
            this.cbSexta.Location = new System.Drawing.Point(108, 46);
            this.cbSexta.Name = "cbSexta";
            this.cbSexta.Size = new System.Drawing.Size(61, 17);
            this.cbSexta.TabIndex = 67;
            this.cbSexta.Text = "SEXTA";
            this.cbSexta.UseVisualStyleBackColor = true;
            this.cbSexta.CheckedChanged += new System.EventHandler(this.cbSexta_CheckedChanged);
            // 
            // cbQuinta
            // 
            this.cbQuinta.AutoSize = true;
            this.cbQuinta.Location = new System.Drawing.Point(17, 46);
            this.cbQuinta.Name = "cbQuinta";
            this.cbQuinta.Size = new System.Drawing.Size(67, 17);
            this.cbQuinta.TabIndex = 68;
            this.cbQuinta.Text = "QUINTA";
            this.cbQuinta.UseVisualStyleBackColor = true;
            this.cbQuinta.CheckedChanged += new System.EventHandler(this.cbQuinta_CheckedChanged);
            // 
            // cbQuarta
            // 
            this.cbQuarta.AutoSize = true;
            this.cbQuarta.Location = new System.Drawing.Point(187, 19);
            this.cbQuarta.Name = "cbQuarta";
            this.cbQuarta.Size = new System.Drawing.Size(71, 17);
            this.cbQuarta.TabIndex = 69;
            this.cbQuarta.Text = "QUARTA";
            this.cbQuarta.UseVisualStyleBackColor = true;
            this.cbQuarta.CheckedChanged += new System.EventHandler(this.cbQuarta_CheckedChanged);
            // 
            // cbTerca
            // 
            this.cbTerca.AutoSize = true;
            this.cbTerca.Location = new System.Drawing.Point(108, 18);
            this.cbTerca.Name = "cbTerca";
            this.cbTerca.Size = new System.Drawing.Size(62, 17);
            this.cbTerca.TabIndex = 70;
            this.cbTerca.Text = "TERÇA";
            this.cbTerca.UseVisualStyleBackColor = true;
            this.cbTerca.CheckedChanged += new System.EventHandler(this.cbTerca_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbQuinta);
            this.groupBox1.Controls.Add(this.cbTerca);
            this.groupBox1.Controls.Add(this.cbSegunda);
            this.groupBox1.Controls.Add(this.cbQuarta);
            this.groupBox1.Controls.Add(this.cbSabado);
            this.groupBox1.Controls.Add(this.cbSexta);
            this.groupBox1.Location = new System.Drawing.Point(374, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 69);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dias Semana*";
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
            this.btnCancelar.Location = new System.Drawing.Point(436, 577);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 31);
            this.btnCancelar.TabIndex = 101;
            this.btnCancelar.Text = "Cancelar Contrato";
            this.btnCancelar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtFinalContrato
            // 
            this.txtFinalContrato.BackColor = System.Drawing.SystemColors.Window;
            this.txtFinalContrato.BorderColor = System.Drawing.Color.DarkGray;
            this.txtFinalContrato.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.txtFinalContrato.BorderRadius = 8;
            this.txtFinalContrato.BorderSize = 1;
            this.txtFinalContrato.DisabledBackColor = System.Drawing.Color.White;
            this.txtFinalContrato.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtFinalContrato.DisabledForeColor = System.Drawing.Color.White;
            this.txtFinalContrato.Enabled = false;
            this.txtFinalContrato.EnabledBackColor = System.Drawing.Color.White;
            this.txtFinalContrato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtFinalContrato.Location = new System.Drawing.Point(419, 300);
            this.txtFinalContrato.Mask = "00/00/0000";
            this.txtFinalContrato.MaxLength = 32767;
            this.txtFinalContrato.Multiline = false;
            this.txtFinalContrato.Name = "txtFinalContrato";
            this.txtFinalContrato.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtFinalContrato.PasswordChar = false;
            this.txtFinalContrato.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFinalContrato.PlaceholderText = "";
            this.txtFinalContrato.Size = new System.Drawing.Size(95, 27);
            this.txtFinalContrato.TabIndex = 102;
            this.txtFinalContrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFinalContrato.Texts = "  /  /";
            this.txtFinalContrato.UnderlinedStyle = false;
            // 
            // lblFinalContrato
            // 
            this.lblFinalContrato.AutoSize = true;
            this.lblFinalContrato.Location = new System.Drawing.Point(416, 284);
            this.lblFinalContrato.Name = "lblFinalContrato";
            this.lblFinalContrato.Size = new System.Drawing.Size(87, 13);
            this.lblFinalContrato.TabIndex = 103;
            this.lblFinalContrato.Text = "Final do Contrato";
            // 
            // CadastroContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(665, 624);
            this.Controls.Add(this.txtFinalContrato);
            this.Controls.Add(this.lblFinalContrato);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMinutos);
            this.Controls.Add(this.cbHoras);
            this.Controls.Add(this.txtDataCancelamento);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnPesquisarCond);
            this.Controls.Add(this.txtCondPagamento);
            this.Controls.Add(this.txtCodCondPag);
            this.Controls.Add(this.txtDiaPagar);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtValorMensal);
            this.Controls.Add(this.txtTipoPrograma);
            this.Controls.Add(this.txtAulas);
            this.Controls.Add(this.txtPrograma);
            this.Controls.Add(this.txtAluno);
            this.Controls.Add(this.btnPesquisarPrograma);
            this.Controls.Add(this.btnPesquisarAluno);
            this.Controls.Add(this.txtCodPrograma);
            this.Controls.Add(this.txtCodAluno);
            this.Controls.Add(this.txtInicioPrograma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAulas);
            this.Controls.Add(this.lblTipoPrograma);
            this.Controls.Add(this.lblDataCancelamento);
            this.Controls.Add(this.lblInicioPrograma);
            this.Controls.Add(this.lblDiaPagamento);
            this.Controls.Add(this.dataGridViewParcelas);
            this.Controls.Add(this.lblCondPagamento);
            this.Controls.Add(this.lblCodCondPag);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblPrograma);
            this.Controls.Add(this.lblCodPrograma);
            this.Controls.Add(this.lblAluno);
            this.Controls.Add(this.lblCodAluno);
            this.Name = "CadastroContrato";
            this.Text = "Cadastro de Contrato";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroContrato_FormClosed);
            this.Load += new System.EventHandler(this.CadastroContrato_Load);
            this.Controls.SetChildIndex(this.lblCodAluno, 0);
            this.Controls.SetChildIndex(this.lblAluno, 0);
            this.Controls.SetChildIndex(this.lblCodPrograma, 0);
            this.Controls.SetChildIndex(this.lblPrograma, 0);
            this.Controls.SetChildIndex(this.lblValorTotal, 0);
            this.Controls.SetChildIndex(this.lblPeriodo, 0);
            this.Controls.SetChildIndex(this.txtPeriodo, 0);
            this.Controls.SetChildIndex(this.lblHorario, 0);
            this.Controls.SetChildIndex(this.lblCodCondPag, 0);
            this.Controls.SetChildIndex(this.lblCondPagamento, 0);
            this.Controls.SetChildIndex(this.dataGridViewParcelas, 0);
            this.Controls.SetChildIndex(this.lblDiaPagamento, 0);
            this.Controls.SetChildIndex(this.lblInicioPrograma, 0);
            this.Controls.SetChildIndex(this.lblDataCancelamento, 0);
            this.Controls.SetChildIndex(this.lblTipoPrograma, 0);
            this.Controls.SetChildIndex(this.lblAulas, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.gbStatus, 0);
            this.Controls.SetChildIndex(this.txtInicioPrograma, 0);
            this.Controls.SetChildIndex(this.txtCodAluno, 0);
            this.Controls.SetChildIndex(this.txtCodPrograma, 0);
            this.Controls.SetChildIndex(this.btnPesquisarAluno, 0);
            this.Controls.SetChildIndex(this.btnPesquisarPrograma, 0);
            this.Controls.SetChildIndex(this.txtAluno, 0);
            this.Controls.SetChildIndex(this.txtPrograma, 0);
            this.Controls.SetChildIndex(this.txtAulas, 0);
            this.Controls.SetChildIndex(this.txtTipoPrograma, 0);
            this.Controls.SetChildIndex(this.txtValorMensal, 0);
            this.Controls.SetChildIndex(this.txtValorTotal, 0);
            this.Controls.SetChildIndex(this.txtDiaPagar, 0);
            this.Controls.SetChildIndex(this.txtCodCondPag, 0);
            this.Controls.SetChildIndex(this.txtCondPagamento, 0);
            this.Controls.SetChildIndex(this.btnPesquisarCond, 0);
            this.Controls.SetChildIndex(this.btnAdicionar, 0);
            this.Controls.SetChildIndex(this.txtDataCancelamento, 0);
            this.Controls.SetChildIndex(this.cbHoras, 0);
            this.Controls.SetChildIndex(this.cbMinutos, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.lblFinalContrato, 0);
            this.Controls.SetChildIndex(this.txtFinalContrato, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParcelas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodAluno;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.Label lblCodPrograma;
        private System.Windows.Forms.Label lblPrograma;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.ComboBox txtPeriodo;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblCodCondPag;
        private System.Windows.Forms.Label lblCondPagamento;
        private System.Windows.Forms.DataGridView dataGridViewParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorParcela;
        private System.Windows.Forms.Label lblDiaPagamento;
        private System.Windows.Forms.Label lblInicioPrograma;
        private System.Windows.Forms.Label lblDataCancelamento;
        private System.Windows.Forms.Label lblAulas;
        private System.Windows.Forms.Label lblTipoPrograma;
        private System.Windows.Forms.Label label1;
        private YControls.YMaskedTextBox txtInicioPrograma;
        private YControls.YTextBox txtCodAluno;
        private YControls.YTextBox txtCodPrograma;
        protected YControls.YButton btnPesquisarAluno;
        protected YControls.YButton btnPesquisarPrograma;
        private YControls.YTextBox txtAluno;
        private YControls.YTextBox txtPrograma;
        private YControls.YTextBox txtAulas;
        private YControls.YTextBox txtTipoPrograma;
        private YControls.YTextBox txtValorMensal;
        private YControls.YTextBox txtValorTotal;
        private YControls.YTextBox txtDiaPagar;
        private YControls.YTextBox txtCodCondPag;
        private YControls.YTextBox txtCondPagamento;
        protected YControls.YButton btnPesquisarCond;
        protected YControls.YButton btnAdicionar;
        private YControls.YMaskedTextBox txtDataCancelamento;
        private System.Windows.Forms.ComboBox cbHoras;
        private System.Windows.Forms.ComboBox cbMinutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbSegunda;
        private System.Windows.Forms.CheckBox cbSabado;
        private System.Windows.Forms.CheckBox cbSexta;
        private System.Windows.Forms.CheckBox cbQuinta;
        private System.Windows.Forms.CheckBox cbQuarta;
        private System.Windows.Forms.CheckBox cbTerca;
        private System.Windows.Forms.GroupBox groupBox1;
        protected YControls.YButton btnCancelar;
        private YControls.YMaskedTextBox txtFinalContrato;
        private System.Windows.Forms.Label lblFinalContrato;
    }
}
