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
            this.txtCodAluno = new System.Windows.Forms.TextBox();
            this.lblAluno = new System.Windows.Forms.Label();
            this.txtAluno = new System.Windows.Forms.TextBox();
            this.lblCodPrograma = new System.Windows.Forms.Label();
            this.txtCodPrograma = new System.Windows.Forms.TextBox();
            this.lblPrograma = new System.Windows.Forms.Label();
            this.txtPrograma = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.ComboBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.lblCodCondPag = new System.Windows.Forms.Label();
            this.txtCodCondPag = new System.Windows.Forms.TextBox();
            this.lblCondPagamento = new System.Windows.Forms.Label();
            this.dataGridViewParcelas = new System.Windows.Forms.DataGridView();
            this.Parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisarAluno = new System.Windows.Forms.Button();
            this.btnPesquisarPrograma = new System.Windows.Forms.Button();
            this.lblDiaPagamento = new System.Windows.Forms.Label();
            this.txtDiaPagar = new System.Windows.Forms.TextBox();
            this.lblInicioPrograma = new System.Windows.Forms.Label();
            this.txtInicioPrograma = new System.Windows.Forms.MaskedTextBox();
            this.lblDataCancelamento = new System.Windows.Forms.Label();
            this.txtAulas = new System.Windows.Forms.TextBox();
            this.lblAulas = new System.Windows.Forms.Label();
            this.txtTipoPrograma = new System.Windows.Forms.TextBox();
            this.lblTipoPrograma = new System.Windows.Forms.Label();
            this.txtValorMensal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisarCond = new System.Windows.Forms.Button();
            this.txtCondPagamento = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtDataCancelamento = new System.Windows.Forms.MaskedTextBox();
            this.gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(7, 19);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(10, 35);
            this.txtCodigo.Size = new System.Drawing.Size(71, 20);
            this.txtCodigo.Text = "0";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(586, 588);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(505, 588);
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(10, 592);
            this.txtDataCadastro.Size = new System.Drawing.Size(85, 20);
            this.txtDataCadastro.Text = "14082024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(112, 592);
            this.txtDataUltAlt.Size = new System.Drawing.Size(79, 20);
            this.txtDataUltAlt.Text = "14082024";
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(109, 577);
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(10, 576);
            // 
            // gbStatus
            // 
            this.gbStatus.Location = new System.Drawing.Point(498, 12);
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
            // lblCodAluno
            // 
            this.lblCodAluno.AutoSize = true;
            this.lblCodAluno.Location = new System.Drawing.Point(9, 73);
            this.lblCodAluno.Name = "lblCodAluno";
            this.lblCodAluno.Size = new System.Drawing.Size(72, 13);
            this.lblCodAluno.TabIndex = 2;
            this.lblCodAluno.Text = "Código aluno:";
            // 
            // txtCodAluno
            // 
            this.txtCodAluno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodAluno.Location = new System.Drawing.Point(12, 89);
            this.txtCodAluno.Name = "txtCodAluno";
            this.txtCodAluno.Size = new System.Drawing.Size(83, 20);
            this.txtCodAluno.TabIndex = 9;
            this.txtCodAluno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodAluno.Leave += new System.EventHandler(this.txtCodAluno_Leave);
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(203, 74);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(37, 13);
            this.lblAluno.TabIndex = 10;
            this.lblAluno.Text = "Aluno:";
            // 
            // txtAluno
            // 
            this.txtAluno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAluno.Enabled = false;
            this.txtAluno.Location = new System.Drawing.Point(205, 90);
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.Size = new System.Drawing.Size(311, 20);
            this.txtAluno.TabIndex = 11;
            // 
            // lblCodPrograma
            // 
            this.lblCodPrograma.AutoSize = true;
            this.lblCodPrograma.Location = new System.Drawing.Point(9, 126);
            this.lblCodPrograma.Name = "lblCodPrograma";
            this.lblCodPrograma.Size = new System.Drawing.Size(90, 13);
            this.lblCodPrograma.TabIndex = 12;
            this.lblCodPrograma.Text = "Código programa:";
            // 
            // txtCodPrograma
            // 
            this.txtCodPrograma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodPrograma.Location = new System.Drawing.Point(12, 142);
            this.txtCodPrograma.Name = "txtCodPrograma";
            this.txtCodPrograma.Size = new System.Drawing.Size(83, 20);
            this.txtCodPrograma.TabIndex = 13;
            this.txtCodPrograma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodPrograma.Leave += new System.EventHandler(this.txtCodPrograma_Leave);
            // 
            // lblPrograma
            // 
            this.lblPrograma.AutoSize = true;
            this.lblPrograma.Location = new System.Drawing.Point(203, 127);
            this.lblPrograma.Name = "lblPrograma";
            this.lblPrograma.Size = new System.Drawing.Size(55, 13);
            this.lblPrograma.TabIndex = 14;
            this.lblPrograma.Text = "Programa:";
            // 
            // txtPrograma
            // 
            this.txtPrograma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrograma.Enabled = false;
            this.txtPrograma.Location = new System.Drawing.Point(205, 143);
            this.txtPrograma.Name = "txtPrograma";
            this.txtPrograma.Size = new System.Drawing.Size(311, 20);
            this.txtPrograma.TabIndex = 15;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(206, 236);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(61, 13);
            this.lblValorTotal.TabIndex = 16;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(206, 252);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(89, 20);
            this.txtValorTotal.TabIndex = 17;
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(108, 235);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(48, 13);
            this.lblPeriodo.TabIndex = 18;
            this.lblPeriodo.Text = "Período:";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.FormattingEnabled = true;
            this.txtPeriodo.Items.AddRange(new object[] {
            "MENSAL",
            "TRIMESTRAL",
            "SEMESTRAL",
            "ANUAL"});
            this.txtPeriodo.Location = new System.Drawing.Point(111, 251);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(80, 21);
            this.txtPeriodo.TabIndex = 19;
            this.txtPeriodo.SelectedIndexChanged += new System.EventHandler(this.txtPeriodo_SelectedIndexChanged);
            this.txtPeriodo.Leave += new System.EventHandler(this.txtPeriodo_Leave);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(203, 181);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(44, 13);
            this.lblHorario.TabIndex = 20;
            this.lblHorario.Text = "Horário:";
            // 
            // txtHorario
            // 
            this.txtHorario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHorario.Location = new System.Drawing.Point(206, 198);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(89, 20);
            this.txtHorario.TabIndex = 21;
            // 
            // lblCodCondPag
            // 
            this.lblCodCondPag.AutoSize = true;
            this.lblCodCondPag.Location = new System.Drawing.Point(12, 291);
            this.lblCodCondPag.Name = "lblCodCondPag";
            this.lblCodCondPag.Size = new System.Drawing.Size(47, 13);
            this.lblCodCondPag.TabIndex = 22;
            this.lblCodCondPag.Text = "Código:*";
            // 
            // txtCodCondPag
            // 
            this.txtCodCondPag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodCondPag.Location = new System.Drawing.Point(15, 307);
            this.txtCodCondPag.Name = "txtCodCondPag";
            this.txtCodCondPag.Size = new System.Drawing.Size(80, 20);
            this.txtCodCondPag.TabIndex = 23;
            this.txtCodCondPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodCondPag.Leave += new System.EventHandler(this.txtCodCondPag_Leave);
            // 
            // lblCondPagamento
            // 
            this.lblCondPagamento.AutoSize = true;
            this.lblCondPagamento.Location = new System.Drawing.Point(202, 290);
            this.lblCondPagamento.Name = "lblCondPagamento";
            this.lblCondPagamento.Size = new System.Drawing.Size(126, 13);
            this.lblCondPagamento.TabIndex = 25;
            this.lblCondPagamento.Text = "Condição de pagamento:";
            // 
            // dataGridViewParcelas
            // 
            this.dataGridViewParcelas.AllowUserToAddRows = false;
            this.dataGridViewParcelas.AllowUserToDeleteRows = false;
            this.dataGridViewParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Parcela,
            this.idFormaPagamento,
            this.formaPagamento,
            this.dataVencimento,
            this.valorParcela});
            this.dataGridViewParcelas.Location = new System.Drawing.Point(10, 351);
            this.dataGridViewParcelas.Name = "dataGridViewParcelas";
            this.dataGridViewParcelas.Size = new System.Drawing.Size(651, 209);
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
            // btnPesquisarAluno
            // 
            this.btnPesquisarAluno.Location = new System.Drawing.Point(111, 87);
            this.btnPesquisarAluno.Name = "btnPesquisarAluno";
            this.btnPesquisarAluno.Size = new System.Drawing.Size(73, 23);
            this.btnPesquisarAluno.TabIndex = 29;
            this.btnPesquisarAluno.Text = "Pesquisar";
            this.btnPesquisarAluno.UseVisualStyleBackColor = true;
            this.btnPesquisarAluno.Click += new System.EventHandler(this.btnPesquisarAluno_Click);
            // 
            // btnPesquisarPrograma
            // 
            this.btnPesquisarPrograma.Location = new System.Drawing.Point(111, 139);
            this.btnPesquisarPrograma.Name = "btnPesquisarPrograma";
            this.btnPesquisarPrograma.Size = new System.Drawing.Size(73, 23);
            this.btnPesquisarPrograma.TabIndex = 30;
            this.btnPesquisarPrograma.Text = "Pesquisar";
            this.btnPesquisarPrograma.UseVisualStyleBackColor = true;
            this.btnPesquisarPrograma.Click += new System.EventHandler(this.btnPesquisarPrograma_Click);
            // 
            // lblDiaPagamento
            // 
            this.lblDiaPagamento.AutoSize = true;
            this.lblDiaPagamento.Location = new System.Drawing.Point(310, 235);
            this.lblDiaPagamento.Name = "lblDiaPagamento";
            this.lblDiaPagamento.Size = new System.Drawing.Size(69, 13);
            this.lblDiaPagamento.TabIndex = 31;
            this.lblDiaPagamento.Text = "Dia a pagar:*";
            // 
            // txtDiaPagar
            // 
            this.txtDiaPagar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDiaPagar.Location = new System.Drawing.Point(313, 252);
            this.txtDiaPagar.Name = "txtDiaPagar";
            this.txtDiaPagar.Size = new System.Drawing.Size(89, 20);
            this.txtDiaPagar.TabIndex = 32;
            this.txtDiaPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblInicioPrograma
            // 
            this.lblInicioPrograma.AutoSize = true;
            this.lblInicioPrograma.Location = new System.Drawing.Point(108, 19);
            this.lblInicioPrograma.Name = "lblInicioPrograma";
            this.lblInicioPrograma.Size = new System.Drawing.Size(98, 13);
            this.lblInicioPrograma.TabIndex = 33;
            this.lblInicioPrograma.Text = "Inicio do Programa:";
            // 
            // txtInicioPrograma
            // 
            this.txtInicioPrograma.Location = new System.Drawing.Point(111, 35);
            this.txtInicioPrograma.Mask = "00/00/0000";
            this.txtInicioPrograma.Name = "txtInicioPrograma";
            this.txtInicioPrograma.Size = new System.Drawing.Size(92, 20);
            this.txtInicioPrograma.TabIndex = 34;
            this.txtInicioPrograma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInicioPrograma.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataCancelamento
            // 
            this.lblDataCancelamento.AutoSize = true;
            this.lblDataCancelamento.Location = new System.Drawing.Point(209, 576);
            this.lblDataCancelamento.Name = "lblDataCancelamento";
            this.lblDataCancelamento.Size = new System.Drawing.Size(119, 13);
            this.lblDataCancelamento.TabIndex = 35;
            this.lblDataCancelamento.Text = "Data de Cancelamento:";
            // 
            // txtAulas
            // 
            this.txtAulas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAulas.Enabled = false;
            this.txtAulas.Location = new System.Drawing.Point(15, 198);
            this.txtAulas.Name = "txtAulas";
            this.txtAulas.Size = new System.Drawing.Size(80, 20);
            this.txtAulas.TabIndex = 40;
            this.txtAulas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAulas
            // 
            this.lblAulas.AutoSize = true;
            this.lblAulas.Location = new System.Drawing.Point(12, 182);
            this.lblAulas.Name = "lblAulas";
            this.lblAulas.Size = new System.Drawing.Size(83, 13);
            this.lblAulas.TabIndex = 39;
            this.lblAulas.Text = "Aulas semanais:";
            // 
            // txtTipoPrograma
            // 
            this.txtTipoPrograma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipoPrograma.Enabled = false;
            this.txtTipoPrograma.Location = new System.Drawing.Point(111, 198);
            this.txtTipoPrograma.Name = "txtTipoPrograma";
            this.txtTipoPrograma.Size = new System.Drawing.Size(80, 20);
            this.txtTipoPrograma.TabIndex = 38;
            // 
            // lblTipoPrograma
            // 
            this.lblTipoPrograma.AutoSize = true;
            this.lblTipoPrograma.Location = new System.Drawing.Point(108, 182);
            this.lblTipoPrograma.Name = "lblTipoPrograma";
            this.lblTipoPrograma.Size = new System.Drawing.Size(79, 13);
            this.lblTipoPrograma.TabIndex = 37;
            this.lblTipoPrograma.Text = "Tipo Programa:";
            // 
            // txtValorMensal
            // 
            this.txtValorMensal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorMensal.Enabled = false;
            this.txtValorMensal.Location = new System.Drawing.Point(15, 252);
            this.txtValorMensal.Name = "txtValorMensal";
            this.txtValorMensal.Size = new System.Drawing.Size(80, 20);
            this.txtValorMensal.TabIndex = 42;
            this.txtValorMensal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Valor mensal:";
            // 
            // btnPesquisarCond
            // 
            this.btnPesquisarCond.Location = new System.Drawing.Point(111, 304);
            this.btnPesquisarCond.Name = "btnPesquisarCond";
            this.btnPesquisarCond.Size = new System.Drawing.Size(73, 23);
            this.btnPesquisarCond.TabIndex = 24;
            this.btnPesquisarCond.Text = "Pesquisar";
            this.btnPesquisarCond.UseVisualStyleBackColor = true;
            this.btnPesquisarCond.Click += new System.EventHandler(this.btnPesquisarCond_Click);
            // 
            // txtCondPagamento
            // 
            this.txtCondPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCondPagamento.Enabled = false;
            this.txtCondPagamento.Location = new System.Drawing.Point(205, 307);
            this.txtCondPagamento.Name = "txtCondPagamento";
            this.txtCondPagamento.Size = new System.Drawing.Size(197, 20);
            this.txtCondPagamento.TabIndex = 26;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(418, 305);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 28;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtDataCancelamento
            // 
            this.txtDataCancelamento.Location = new System.Drawing.Point(212, 592);
            this.txtDataCancelamento.Mask = "00/00/0000";
            this.txtDataCancelamento.Name = "txtDataCancelamento";
            this.txtDataCancelamento.Size = new System.Drawing.Size(116, 20);
            this.txtDataCancelamento.TabIndex = 43;
            this.txtDataCancelamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataCancelamento.ValidatingType = typeof(System.DateTime);
            // 
            // CadastroContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(673, 624);
            this.Controls.Add(this.txtDataCancelamento);
            this.Controls.Add(this.txtValorMensal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAulas);
            this.Controls.Add(this.lblAulas);
            this.Controls.Add(this.txtTipoPrograma);
            this.Controls.Add(this.lblTipoPrograma);
            this.Controls.Add(this.lblDataCancelamento);
            this.Controls.Add(this.txtInicioPrograma);
            this.Controls.Add(this.lblInicioPrograma);
            this.Controls.Add(this.txtDiaPagar);
            this.Controls.Add(this.lblDiaPagamento);
            this.Controls.Add(this.btnPesquisarPrograma);
            this.Controls.Add(this.btnPesquisarAluno);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dataGridViewParcelas);
            this.Controls.Add(this.txtCondPagamento);
            this.Controls.Add(this.lblCondPagamento);
            this.Controls.Add(this.btnPesquisarCond);
            this.Controls.Add(this.txtCodCondPag);
            this.Controls.Add(this.lblCodCondPag);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.txtPrograma);
            this.Controls.Add(this.lblPrograma);
            this.Controls.Add(this.txtCodPrograma);
            this.Controls.Add(this.lblCodPrograma);
            this.Controls.Add(this.txtAluno);
            this.Controls.Add(this.lblAluno);
            this.Controls.Add(this.txtCodAluno);
            this.Controls.Add(this.lblCodAluno);
            this.Name = "CadastroContrato";
            this.Text = "Cadastro de Contrato";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroContrato_FormClosed);
            this.Load += new System.EventHandler(this.CadastroContrato_Load);
            this.Controls.SetChildIndex(this.lblCodAluno, 0);
            this.Controls.SetChildIndex(this.txtCodAluno, 0);
            this.Controls.SetChildIndex(this.lblAluno, 0);
            this.Controls.SetChildIndex(this.txtAluno, 0);
            this.Controls.SetChildIndex(this.lblCodPrograma, 0);
            this.Controls.SetChildIndex(this.txtCodPrograma, 0);
            this.Controls.SetChildIndex(this.lblPrograma, 0);
            this.Controls.SetChildIndex(this.txtPrograma, 0);
            this.Controls.SetChildIndex(this.lblValorTotal, 0);
            this.Controls.SetChildIndex(this.txtValorTotal, 0);
            this.Controls.SetChildIndex(this.lblPeriodo, 0);
            this.Controls.SetChildIndex(this.txtPeriodo, 0);
            this.Controls.SetChildIndex(this.lblHorario, 0);
            this.Controls.SetChildIndex(this.txtHorario, 0);
            this.Controls.SetChildIndex(this.lblCodCondPag, 0);
            this.Controls.SetChildIndex(this.txtCodCondPag, 0);
            this.Controls.SetChildIndex(this.btnPesquisarCond, 0);
            this.Controls.SetChildIndex(this.lblCondPagamento, 0);
            this.Controls.SetChildIndex(this.txtCondPagamento, 0);
            this.Controls.SetChildIndex(this.dataGridViewParcelas, 0);
            this.Controls.SetChildIndex(this.btnAdicionar, 0);
            this.Controls.SetChildIndex(this.btnPesquisarAluno, 0);
            this.Controls.SetChildIndex(this.btnPesquisarPrograma, 0);
            this.Controls.SetChildIndex(this.lblDiaPagamento, 0);
            this.Controls.SetChildIndex(this.txtDiaPagar, 0);
            this.Controls.SetChildIndex(this.lblInicioPrograma, 0);
            this.Controls.SetChildIndex(this.txtInicioPrograma, 0);
            this.Controls.SetChildIndex(this.lblDataCancelamento, 0);
            this.Controls.SetChildIndex(this.lblTipoPrograma, 0);
            this.Controls.SetChildIndex(this.txtTipoPrograma, 0);
            this.Controls.SetChildIndex(this.lblAulas, 0);
            this.Controls.SetChildIndex(this.txtAulas, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtValorMensal, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.gbStatus, 0);
            this.Controls.SetChildIndex(this.txtDataCancelamento, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodAluno;
        private System.Windows.Forms.TextBox txtCodAluno;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.TextBox txtAluno;
        private System.Windows.Forms.Label lblCodPrograma;
        private System.Windows.Forms.TextBox txtCodPrograma;
        private System.Windows.Forms.Label lblPrograma;
        private System.Windows.Forms.TextBox txtPrograma;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.ComboBox txtPeriodo;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.Label lblCodCondPag;
        private System.Windows.Forms.TextBox txtCodCondPag;
        private System.Windows.Forms.Label lblCondPagamento;
        private System.Windows.Forms.DataGridView dataGridViewParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorParcela;
        private System.Windows.Forms.Button btnPesquisarAluno;
        private System.Windows.Forms.Button btnPesquisarPrograma;
        private System.Windows.Forms.Label lblDiaPagamento;
        private System.Windows.Forms.TextBox txtDiaPagar;
        private System.Windows.Forms.Label lblInicioPrograma;
        private System.Windows.Forms.MaskedTextBox txtInicioPrograma;
        private System.Windows.Forms.Label lblDataCancelamento;
        private System.Windows.Forms.TextBox txtAulas;
        private System.Windows.Forms.Label lblAulas;
        private System.Windows.Forms.TextBox txtTipoPrograma;
        private System.Windows.Forms.Label lblTipoPrograma;
        private System.Windows.Forms.TextBox txtValorMensal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisarCond;
        private System.Windows.Forms.TextBox txtCondPagamento;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.MaskedTextBox txtDataCancelamento;
    }
}
