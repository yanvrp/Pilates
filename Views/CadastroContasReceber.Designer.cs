namespace Pilates.Views
{
    partial class CadastroContasReceber
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
            this.txtCodAluno = new System.Windows.Forms.TextBox();
            this.lblCodAluno = new System.Windows.Forms.Label();
            this.btnPesquisarAluno = new System.Windows.Forms.Button();
            this.lblAluno = new System.Windows.Forms.Label();
            this.txtAluno = new System.Windows.Forms.TextBox();
            this.lblFormaPagamento = new System.Windows.Forms.Label();
            this.txtFormaPag = new System.Windows.Forms.TextBox();
            this.btnPesquisarFormaPag = new System.Windows.Forms.Button();
            this.lblCodFormPag = new System.Windows.Forms.Label();
            this.txtCodFormaPag = new System.Windows.Forms.TextBox();
            this.lblParcelas = new System.Windows.Forms.Label();
            this.txtParcelas = new System.Windows.Forms.TextBox();
            this.txtValorParcela = new System.Windows.Forms.TextBox();
            this.lblValorParcela = new System.Windows.Forms.Label();
            this.lblDataVencimento = new System.Windows.Forms.Label();
            this.txtDataVencimento = new System.Windows.Forms.MaskedTextBox();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.lblJuros = new System.Windows.Forms.Label();
            this.txtMulta = new System.Windows.Forms.TextBox();
            this.lblMulta = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.txtDataRecebimento = new System.Windows.Forms.MaskedTextBox();
            this.lblDataRecebimento = new System.Windows.Forms.Label();
            this.txtValorRecebido = new System.Windows.Forms.TextBox();
            this.lblValorRecebido = new System.Windows.Forms.Label();
            this.txtDataCancelamento = new System.Windows.Forms.MaskedTextBox();
            this.lblDataCancelamento = new System.Windows.Forms.Label();
            this.txtTotalReceber = new System.Windows.Forms.TextBox();
            this.lblTotalReceber = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtDataEmissao = new System.Windows.Forms.MaskedTextBox();
            this.lblDataEmissao = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnReceber = new System.Windows.Forms.Button();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(534, 198);
            this.lblCodigo.Visible = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(537, 214);
            this.txtCodigo.Text = "0";
            this.txtCodigo.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(459, 439);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(378, 439);
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(23, 442);
            this.txtDataCadastro.Size = new System.Drawing.Size(90, 20);
            this.txtDataCadastro.Text = "14092024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(125, 441);
            this.txtDataUltAlt.Size = new System.Drawing.Size(90, 20);
            this.txtDataUltAlt.Text = "14092024";
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(122, 425);
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(23, 425);
            // 
            // gbStatus
            // 
            this.gbStatus.Location = new System.Drawing.Point(387, 20);
            this.gbStatus.Size = new System.Drawing.Size(147, 46);
            // 
            // rbInativo
            // 
            this.rbInativo.Location = new System.Drawing.Point(78, 19);
            // 
            // rbAtivo
            // 
            this.rbAtivo.Location = new System.Drawing.Point(18, 19);
            // 
            // txtCodAluno
            // 
            this.txtCodAluno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodAluno.Location = new System.Drawing.Point(23, 96);
            this.txtCodAluno.Name = "txtCodAluno";
            this.txtCodAluno.Size = new System.Drawing.Size(90, 20);
            this.txtCodAluno.TabIndex = 9;
            this.txtCodAluno.Leave += new System.EventHandler(this.txtCodAluno_Leave);
            // 
            // lblCodAluno
            // 
            this.lblCodAluno.AutoSize = true;
            this.lblCodAluno.Location = new System.Drawing.Point(23, 76);
            this.lblCodAluno.Name = "lblCodAluno";
            this.lblCodAluno.Size = new System.Drawing.Size(66, 13);
            this.lblCodAluno.TabIndex = 10;
            this.lblCodAluno.Text = "Cód. Aluno:*";
            // 
            // btnPesquisarAluno
            // 
            this.btnPesquisarAluno.Location = new System.Drawing.Point(125, 93);
            this.btnPesquisarAluno.Name = "btnPesquisarAluno";
            this.btnPesquisarAluno.Size = new System.Drawing.Size(62, 23);
            this.btnPesquisarAluno.TabIndex = 11;
            this.btnPesquisarAluno.Text = "Pesquisar";
            this.btnPesquisarAluno.UseVisualStyleBackColor = true;
            this.btnPesquisarAluno.Click += new System.EventHandler(this.btnPesquisarAluno_Click);
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(199, 76);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(37, 13);
            this.lblAluno.TabIndex = 13;
            this.lblAluno.Text = "Aluno:";
            // 
            // txtAluno
            // 
            this.txtAluno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAluno.Enabled = false;
            this.txtAluno.Location = new System.Drawing.Point(199, 96);
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.Size = new System.Drawing.Size(335, 20);
            this.txtAluno.TabIndex = 12;
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.AutoSize = true;
            this.lblFormaPagamento.Location = new System.Drawing.Point(196, 135);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(111, 13);
            this.lblFormaPagamento.TabIndex = 18;
            this.lblFormaPagamento.Text = "Forma de Pagamento:";
            // 
            // txtFormaPag
            // 
            this.txtFormaPag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFormaPag.Enabled = false;
            this.txtFormaPag.Location = new System.Drawing.Point(199, 155);
            this.txtFormaPag.Name = "txtFormaPag";
            this.txtFormaPag.Size = new System.Drawing.Size(335, 20);
            this.txtFormaPag.TabIndex = 17;
            // 
            // btnPesquisarFormaPag
            // 
            this.btnPesquisarFormaPag.Location = new System.Drawing.Point(125, 153);
            this.btnPesquisarFormaPag.Name = "btnPesquisarFormaPag";
            this.btnPesquisarFormaPag.Size = new System.Drawing.Size(62, 23);
            this.btnPesquisarFormaPag.TabIndex = 16;
            this.btnPesquisarFormaPag.Text = "Pesquisar";
            this.btnPesquisarFormaPag.UseVisualStyleBackColor = true;
            this.btnPesquisarFormaPag.Click += new System.EventHandler(this.btnPesquisarFormaPag_Click);
            // 
            // lblCodFormPag
            // 
            this.lblCodFormPag.AutoSize = true;
            this.lblCodFormPag.Location = new System.Drawing.Point(20, 135);
            this.lblCodFormPag.Name = "lblCodFormPag";
            this.lblCodFormPag.Size = new System.Drawing.Size(93, 13);
            this.lblCodFormPag.TabIndex = 15;
            this.lblCodFormPag.Text = "Cód. Forma Pag.:*";
            // 
            // txtCodFormaPag
            // 
            this.txtCodFormaPag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodFormaPag.Location = new System.Drawing.Point(23, 155);
            this.txtCodFormaPag.Name = "txtCodFormaPag";
            this.txtCodFormaPag.Size = new System.Drawing.Size(90, 20);
            this.txtCodFormaPag.TabIndex = 14;
            this.txtCodFormaPag.Leave += new System.EventHandler(this.txtCodFormaPag_Leave);
            // 
            // lblParcelas
            // 
            this.lblParcelas.AutoSize = true;
            this.lblParcelas.Location = new System.Drawing.Point(20, 198);
            this.lblParcelas.Name = "lblParcelas";
            this.lblParcelas.Size = new System.Drawing.Size(90, 13);
            this.lblParcelas.TabIndex = 19;
            this.lblParcelas.Text = "Numero Parcela:*";
            // 
            // txtParcelas
            // 
            this.txtParcelas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtParcelas.Location = new System.Drawing.Point(23, 214);
            this.txtParcelas.Name = "txtParcelas";
            this.txtParcelas.Size = new System.Drawing.Size(90, 20);
            this.txtParcelas.TabIndex = 20;
            // 
            // txtValorParcela
            // 
            this.txtValorParcela.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorParcela.Location = new System.Drawing.Point(125, 214);
            this.txtValorParcela.Name = "txtValorParcela";
            this.txtValorParcela.Size = new System.Drawing.Size(90, 20);
            this.txtValorParcela.TabIndex = 22;
            // 
            // lblValorParcela
            // 
            this.lblValorParcela.AutoSize = true;
            this.lblValorParcela.Location = new System.Drawing.Point(122, 198);
            this.lblValorParcela.Name = "lblValorParcela";
            this.lblValorParcela.Size = new System.Drawing.Size(77, 13);
            this.lblValorParcela.TabIndex = 21;
            this.lblValorParcela.Text = "Valor Parcela:*";
            // 
            // lblDataVencimento
            // 
            this.lblDataVencimento.AutoSize = true;
            this.lblDataVencimento.Location = new System.Drawing.Point(227, 198);
            this.lblDataVencimento.Name = "lblDataVencimento";
            this.lblDataVencimento.Size = new System.Drawing.Size(96, 13);
            this.lblDataVencimento.TabIndex = 23;
            this.lblDataVencimento.Text = "Data Vencimento:*";
            // 
            // txtDataVencimento
            // 
            this.txtDataVencimento.Location = new System.Drawing.Point(230, 214);
            this.txtDataVencimento.Mask = "00/00/0000";
            this.txtDataVencimento.Name = "txtDataVencimento";
            this.txtDataVencimento.Size = new System.Drawing.Size(90, 20);
            this.txtDataVencimento.TabIndex = 24;
            this.txtDataVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataVencimento.ValidatingType = typeof(System.DateTime);
            this.txtDataVencimento.Leave += new System.EventHandler(this.txtDataVencimento_Leave);
            // 
            // txtJuros
            // 
            this.txtJuros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtJuros.Location = new System.Drawing.Point(23, 269);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(90, 20);
            this.txtJuros.TabIndex = 26;
            this.txtJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblJuros
            // 
            this.lblJuros.AutoSize = true;
            this.lblJuros.Location = new System.Drawing.Point(20, 245);
            this.lblJuros.Name = "lblJuros";
            this.lblJuros.Size = new System.Drawing.Size(35, 13);
            this.lblJuros.TabIndex = 25;
            this.lblJuros.Text = "Juros:";
            // 
            // txtMulta
            // 
            this.txtMulta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMulta.Location = new System.Drawing.Point(125, 269);
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.Size = new System.Drawing.Size(90, 20);
            this.txtMulta.TabIndex = 28;
            this.txtMulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMulta
            // 
            this.lblMulta.AutoSize = true;
            this.lblMulta.Location = new System.Drawing.Point(122, 253);
            this.lblMulta.Name = "lblMulta";
            this.lblMulta.Size = new System.Drawing.Size(36, 13);
            this.lblMulta.TabIndex = 27;
            this.lblMulta.Text = "Multa:";
            // 
            // txtDesconto
            // 
            this.txtDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesconto.Location = new System.Drawing.Point(230, 269);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(90, 20);
            this.txtDesconto.TabIndex = 30;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(227, 253);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(56, 13);
            this.lblDesconto.TabIndex = 29;
            this.lblDesconto.Text = "Desconto:";
            // 
            // txtDataRecebimento
            // 
            this.txtDataRecebimento.Enabled = false;
            this.txtDataRecebimento.Location = new System.Drawing.Point(23, 328);
            this.txtDataRecebimento.Mask = "00/00/0000";
            this.txtDataRecebimento.Name = "txtDataRecebimento";
            this.txtDataRecebimento.Size = new System.Drawing.Size(90, 20);
            this.txtDataRecebimento.TabIndex = 32;
            this.txtDataRecebimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataRecebimento.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataRecebimento
            // 
            this.lblDataRecebimento.AutoSize = true;
            this.lblDataRecebimento.Location = new System.Drawing.Point(20, 312);
            this.lblDataRecebimento.Name = "lblDataRecebimento";
            this.lblDataRecebimento.Size = new System.Drawing.Size(99, 13);
            this.lblDataRecebimento.TabIndex = 31;
            this.lblDataRecebimento.Text = "Data Recebimento:";
            // 
            // txtValorRecebido
            // 
            this.txtValorRecebido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorRecebido.Location = new System.Drawing.Point(125, 328);
            this.txtValorRecebido.Name = "txtValorRecebido";
            this.txtValorRecebido.Size = new System.Drawing.Size(90, 20);
            this.txtValorRecebido.TabIndex = 34;
            this.txtValorRecebido.TextChanged += new System.EventHandler(this.txtValorRecebido_TextChanged);
            this.txtValorRecebido.Leave += new System.EventHandler(this.txtValorRecebido_Leave);
            // 
            // lblValorRecebido
            // 
            this.lblValorRecebido.AutoSize = true;
            this.lblValorRecebido.Location = new System.Drawing.Point(126, 312);
            this.lblValorRecebido.Name = "lblValorRecebido";
            this.lblValorRecebido.Size = new System.Drawing.Size(83, 13);
            this.lblValorRecebido.TabIndex = 33;
            this.lblValorRecebido.Text = "Valor Recebido:";
            // 
            // txtDataCancelamento
            // 
            this.txtDataCancelamento.Enabled = false;
            this.txtDataCancelamento.Location = new System.Drawing.Point(230, 328);
            this.txtDataCancelamento.Mask = "00/00/0000";
            this.txtDataCancelamento.Name = "txtDataCancelamento";
            this.txtDataCancelamento.Size = new System.Drawing.Size(100, 20);
            this.txtDataCancelamento.TabIndex = 36;
            this.txtDataCancelamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataCancelamento.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataCancelamento
            // 
            this.lblDataCancelamento.AutoSize = true;
            this.lblDataCancelamento.Location = new System.Drawing.Point(227, 312);
            this.lblDataCancelamento.Name = "lblDataCancelamento";
            this.lblDataCancelamento.Size = new System.Drawing.Size(104, 13);
            this.lblDataCancelamento.TabIndex = 35;
            this.lblDataCancelamento.Text = "Data Cancelamento:";
            // 
            // txtTotalReceber
            // 
            this.txtTotalReceber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalReceber.Enabled = false;
            this.txtTotalReceber.Location = new System.Drawing.Point(434, 328);
            this.txtTotalReceber.Name = "txtTotalReceber";
            this.txtTotalReceber.Size = new System.Drawing.Size(100, 20);
            this.txtTotalReceber.TabIndex = 38;
            // 
            // lblTotalReceber
            // 
            this.lblTotalReceber.AutoSize = true;
            this.lblTotalReceber.Location = new System.Drawing.Point(431, 312);
            this.lblTotalReceber.Name = "lblTotalReceber";
            this.lblTotalReceber.Size = new System.Drawing.Size(61, 13);
            this.lblTotalReceber.TabIndex = 37;
            this.lblTotalReceber.Text = "Valor Total:";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(20, 369);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(68, 13);
            this.lblObservacao.TabIndex = 39;
            this.lblObservacao.Text = "Observação:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.Location = new System.Drawing.Point(23, 385);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(511, 20);
            this.txtObservacao.TabIndex = 40;
            // 
            // txtDataEmissao
            // 
            this.txtDataEmissao.Location = new System.Drawing.Point(23, 36);
            this.txtDataEmissao.Mask = "00/00/0000";
            this.txtDataEmissao.Name = "txtDataEmissao";
            this.txtDataEmissao.Size = new System.Drawing.Size(90, 20);
            this.txtDataEmissao.TabIndex = 42;
            this.txtDataEmissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataEmissao.ValidatingType = typeof(System.DateTime);
            this.txtDataEmissao.Leave += new System.EventHandler(this.txtDataEmissao_Leave);
            // 
            // lblDataEmissao
            // 
            this.lblDataEmissao.AutoSize = true;
            this.lblDataEmissao.Location = new System.Drawing.Point(20, 20);
            this.lblDataEmissao.Name = "lblDataEmissao";
            this.lblDataEmissao.Size = new System.Drawing.Size(79, 13);
            this.lblDataEmissao.TabIndex = 41;
            this.lblDataEmissao.Text = "Data Emissão:*";
            // 
            // txtNumero
            // 
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Location = new System.Drawing.Point(125, 36);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(104, 20);
            this.txtNumero.TabIndex = 44;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(122, 20);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 43;
            this.lblNumero.Text = "Número:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(239, 439);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(58, 23);
            this.btnCancelar.TabIndex = 45;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnReceber
            // 
            this.btnReceber.Location = new System.Drawing.Point(303, 439);
            this.btnReceber.Name = "btnReceber";
            this.btnReceber.Size = new System.Drawing.Size(69, 23);
            this.btnReceber.TabIndex = 46;
            this.btnReceber.Text = "Receber";
            this.btnReceber.UseVisualStyleBackColor = true;
            this.btnReceber.Visible = false;
            this.btnReceber.Click += new System.EventHandler(this.btnReceber_Click);
            // 
            // CadastroContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(553, 475);
            this.Controls.Add(this.btnReceber);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtDataEmissao);
            this.Controls.Add(this.lblDataEmissao);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.txtTotalReceber);
            this.Controls.Add(this.lblTotalReceber);
            this.Controls.Add(this.txtDataCancelamento);
            this.Controls.Add(this.lblDataCancelamento);
            this.Controls.Add(this.txtValorRecebido);
            this.Controls.Add(this.lblValorRecebido);
            this.Controls.Add(this.txtDataRecebimento);
            this.Controls.Add(this.lblDataRecebimento);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.txtMulta);
            this.Controls.Add(this.lblMulta);
            this.Controls.Add(this.txtJuros);
            this.Controls.Add(this.lblJuros);
            this.Controls.Add(this.txtDataVencimento);
            this.Controls.Add(this.lblDataVencimento);
            this.Controls.Add(this.txtValorParcela);
            this.Controls.Add(this.lblValorParcela);
            this.Controls.Add(this.txtParcelas);
            this.Controls.Add(this.lblParcelas);
            this.Controls.Add(this.lblFormaPagamento);
            this.Controls.Add(this.txtFormaPag);
            this.Controls.Add(this.btnPesquisarFormaPag);
            this.Controls.Add(this.lblCodFormPag);
            this.Controls.Add(this.txtCodFormaPag);
            this.Controls.Add(this.lblAluno);
            this.Controls.Add(this.txtAluno);
            this.Controls.Add(this.btnPesquisarAluno);
            this.Controls.Add(this.lblCodAluno);
            this.Controls.Add(this.txtCodAluno);
            this.Name = "CadastroContasReceber";
            this.Text = "Cadastro Contas a Receber";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroContasReceber_FormClosed);
            this.Load += new System.EventHandler(this.CadastroContasReceber_Load);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.gbStatus, 0);
            this.Controls.SetChildIndex(this.txtCodAluno, 0);
            this.Controls.SetChildIndex(this.lblCodAluno, 0);
            this.Controls.SetChildIndex(this.btnPesquisarAluno, 0);
            this.Controls.SetChildIndex(this.txtAluno, 0);
            this.Controls.SetChildIndex(this.lblAluno, 0);
            this.Controls.SetChildIndex(this.txtCodFormaPag, 0);
            this.Controls.SetChildIndex(this.lblCodFormPag, 0);
            this.Controls.SetChildIndex(this.btnPesquisarFormaPag, 0);
            this.Controls.SetChildIndex(this.txtFormaPag, 0);
            this.Controls.SetChildIndex(this.lblFormaPagamento, 0);
            this.Controls.SetChildIndex(this.lblParcelas, 0);
            this.Controls.SetChildIndex(this.txtParcelas, 0);
            this.Controls.SetChildIndex(this.lblValorParcela, 0);
            this.Controls.SetChildIndex(this.txtValorParcela, 0);
            this.Controls.SetChildIndex(this.lblDataVencimento, 0);
            this.Controls.SetChildIndex(this.txtDataVencimento, 0);
            this.Controls.SetChildIndex(this.lblJuros, 0);
            this.Controls.SetChildIndex(this.txtJuros, 0);
            this.Controls.SetChildIndex(this.lblMulta, 0);
            this.Controls.SetChildIndex(this.txtMulta, 0);
            this.Controls.SetChildIndex(this.lblDesconto, 0);
            this.Controls.SetChildIndex(this.txtDesconto, 0);
            this.Controls.SetChildIndex(this.lblDataRecebimento, 0);
            this.Controls.SetChildIndex(this.txtDataRecebimento, 0);
            this.Controls.SetChildIndex(this.lblValorRecebido, 0);
            this.Controls.SetChildIndex(this.txtValorRecebido, 0);
            this.Controls.SetChildIndex(this.lblDataCancelamento, 0);
            this.Controls.SetChildIndex(this.txtDataCancelamento, 0);
            this.Controls.SetChildIndex(this.lblTotalReceber, 0);
            this.Controls.SetChildIndex(this.txtTotalReceber, 0);
            this.Controls.SetChildIndex(this.lblObservacao, 0);
            this.Controls.SetChildIndex(this.txtObservacao, 0);
            this.Controls.SetChildIndex(this.lblDataEmissao, 0);
            this.Controls.SetChildIndex(this.txtDataEmissao, 0);
            this.Controls.SetChildIndex(this.lblNumero, 0);
            this.Controls.SetChildIndex(this.txtNumero, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnReceber, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodAluno;
        private System.Windows.Forms.Label lblCodAluno;
        private System.Windows.Forms.Button btnPesquisarAluno;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.TextBox txtAluno;
        private System.Windows.Forms.Label lblFormaPagamento;
        private System.Windows.Forms.TextBox txtFormaPag;
        private System.Windows.Forms.Button btnPesquisarFormaPag;
        private System.Windows.Forms.Label lblCodFormPag;
        private System.Windows.Forms.TextBox txtCodFormaPag;
        private System.Windows.Forms.Label lblParcelas;
        private System.Windows.Forms.TextBox txtParcelas;
        private System.Windows.Forms.TextBox txtValorParcela;
        private System.Windows.Forms.Label lblValorParcela;
        private System.Windows.Forms.Label lblDataVencimento;
        private System.Windows.Forms.MaskedTextBox txtDataVencimento;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.Label lblJuros;
        private System.Windows.Forms.TextBox txtMulta;
        private System.Windows.Forms.Label lblMulta;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.MaskedTextBox txtDataRecebimento;
        private System.Windows.Forms.Label lblDataRecebimento;
        private System.Windows.Forms.TextBox txtValorRecebido;
        private System.Windows.Forms.Label lblValorRecebido;
        private System.Windows.Forms.MaskedTextBox txtDataCancelamento;
        private System.Windows.Forms.Label lblDataCancelamento;
        private System.Windows.Forms.TextBox txtTotalReceber;
        private System.Windows.Forms.Label lblTotalReceber;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.MaskedTextBox txtDataEmissao;
        private System.Windows.Forms.Label lblDataEmissao;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnReceber;
    }
}
