namespace Pilates.Views
{
    partial class CadastroFornecedor
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
            this.lblCPF_CNPJ = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCodCidade = new System.Windows.Forms.TextBox();
            this.lblCodCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.lblApelido = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtCPF_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtNomeContato = new System.Windows.Forms.TextBox();
            this.lblNomeContato = new System.Windows.Forms.Label();
            this.gpPessoa = new System.Windows.Forms.GroupBox();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.lblRG_IE = new System.Windows.Forms.Label();
            this.txtRG_IE = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gpPagamento = new System.Windows.Forms.GroupBox();
            this.txtCondPag = new System.Windows.Forms.TextBox();
            this.lblCondPag = new System.Windows.Forms.Label();
            this.btnBuscarCondPag = new System.Windows.Forms.Button();
            this.txtCodCondPag = new System.Windows.Forms.TextBox();
            this.lblCodCondPag = new System.Windows.Forms.Label();
            this.gbStatus.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            this.gpPessoa.SuspendLayout();
            this.gpPagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Text = "0";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(778, 489);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(697, 489);
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(23, 492);
            this.txtDataCadastro.Text = "05102024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(137, 491);
            this.txtDataUltAlt.Text = "05102024";
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(134, 476);
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(20, 476);
            // 
            // gbStatus
            // 
            this.gbStatus.Location = new System.Drawing.Point(688, 12);
            // 
            // lblCPF_CNPJ
            // 
            this.lblCPF_CNPJ.AutoSize = true;
            this.lblCPF_CNPJ.Location = new System.Drawing.Point(26, 351);
            this.lblCPF_CNPJ.Name = "lblCPF_CNPJ";
            this.lblCPF_CNPJ.Size = new System.Drawing.Size(34, 13);
            this.lblCPF_CNPJ.TabIndex = 32;
            this.lblCPF_CNPJ.Text = "CPF:*";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 137);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 13);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "Email:*";
            // 
            // gbEndereco
            // 
            this.gbEndereco.Controls.Add(this.lblPais);
            this.gbEndereco.Controls.Add(this.txtPais);
            this.gbEndereco.Controls.Add(this.txtUF);
            this.gbEndereco.Controls.Add(this.lblUF);
            this.gbEndereco.Controls.Add(this.txtCidade);
            this.gbEndereco.Controls.Add(this.lblCidade);
            this.gbEndereco.Controls.Add(this.btnBuscar);
            this.gbEndereco.Controls.Add(this.txtCodCidade);
            this.gbEndereco.Controls.Add(this.lblCodCidade);
            this.gbEndereco.Controls.Add(this.txtBairro);
            this.gbEndereco.Controls.Add(this.lblBairro);
            this.gbEndereco.Controls.Add(this.txtComplemento);
            this.gbEndereco.Controls.Add(this.lblComplemento);
            this.gbEndereco.Controls.Add(this.txtNumero);
            this.gbEndereco.Controls.Add(this.lblNumero);
            this.gbEndereco.Controls.Add(this.txtEndereco);
            this.gbEndereco.Controls.Add(this.lblEndereco);
            this.gbEndereco.Controls.Add(this.txtCEP);
            this.gbEndereco.Controls.Add(this.lblCEP);
            this.gbEndereco.Location = new System.Drawing.Point(23, 196);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(830, 133);
            this.gbEndereco.TabIndex = 27;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereço";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(653, 79);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(30, 13);
            this.lblPais.TabIndex = 35;
            this.lblPais.Text = "Pais:";
            // 
            // txtPais
            // 
            this.txtPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPais.Enabled = false;
            this.txtPais.Location = new System.Drawing.Point(656, 96);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(153, 20);
            this.txtPais.TabIndex = 14;
            // 
            // txtUF
            // 
            this.txtUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUF.Enabled = false;
            this.txtUF.Location = new System.Drawing.Point(562, 95);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(71, 20);
            this.txtUF.TabIndex = 13;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(559, 79);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 13);
            this.lblUF.TabIndex = 20;
            this.lblUF.Text = "UF:";
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(338, 94);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(206, 20);
            this.txtCidade.TabIndex = 12;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(335, 79);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 20;
            this.lblCidade.Text = "Cidade:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(259, 93);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(53, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCodCidade
            // 
            this.txtCodCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodCidade.Location = new System.Drawing.Point(173, 95);
            this.txtCodCidade.Name = "txtCodCidade";
            this.txtCodCidade.Size = new System.Drawing.Size(80, 20);
            this.txtCodCidade.TabIndex = 12;
            this.txtCodCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodCidade_KeyPress);
            this.txtCodCidade.Leave += new System.EventHandler(this.txtCodCidade_Leave);
            // 
            // lblCodCidade
            // 
            this.lblCodCidade.AutoSize = true;
            this.lblCodCidade.Location = new System.Drawing.Point(170, 79);
            this.lblCodCidade.Name = "lblCodCidade";
            this.lblCodCidade.Size = new System.Drawing.Size(83, 13);
            this.lblCodCidade.TabIndex = 20;
            this.lblCodCidade.Text = "Código Cidade:*";
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Location = new System.Drawing.Point(6, 95);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(155, 20);
            this.txtBairro.TabIndex = 11;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(6, 79);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(41, 13);
            this.lblBairro.TabIndex = 28;
            this.lblBairro.Text = "Bairro:*";
            // 
            // txtComplemento
            // 
            this.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplemento.Location = new System.Drawing.Point(562, 41);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(247, 20);
            this.txtComplemento.TabIndex = 10;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(559, 26);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 26;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtNumero
            // 
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Location = new System.Drawing.Point(444, 42);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 9;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(441, 26);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(51, 13);
            this.lblNumero.TabIndex = 24;
            this.lblNumero.Text = "Numero:*";
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Location = new System.Drawing.Point(104, 42);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(318, 20);
            this.txtEndereco.TabIndex = 8;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(101, 26);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(60, 13);
            this.lblEndereco.TabIndex = 22;
            this.lblEndereco.Text = "Endereço:*";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(9, 43);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(62, 20);
            this.txtCEP.TabIndex = 7;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(6, 26);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(35, 13);
            this.lblCEP.TabIndex = 20;
            this.lblCEP.Text = "CEP:*";
            // 
            // txtSexo
            // 
            this.txtSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSexo.FormattingEnabled = true;
            this.txtSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMININO",
            "OUTROS"});
            this.txtSexo.Location = new System.Drawing.Point(617, 92);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(121, 21);
            this.txtSexo.TabIndex = 26;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(614, 77);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(38, 13);
            this.lblSexo.TabIndex = 30;
            this.lblSexo.Text = "Sexo:*";
            // 
            // txtApelido
            // 
            this.txtApelido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApelido.Location = new System.Drawing.Point(321, 92);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(281, 20);
            this.txtApelido.TabIndex = 25;
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Location = new System.Drawing.Point(318, 76);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(45, 13);
            this.lblApelido.TabIndex = 29;
            this.lblApelido.Text = "Apelido:";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedor.Location = new System.Drawing.Point(23, 92);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(281, 20);
            this.txtFornecedor.TabIndex = 24;
            this.txtFornecedor.Leave += new System.EventHandler(this.txtFornecedor_Leave);
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(20, 76);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(68, 13);
            this.lblFornecedor.TabIndex = 28;
            this.lblFornecedor.Text = "Fornecedor:*";
            // 
            // txtCelular
            // 
            this.txtCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCelular.Location = new System.Drawing.Point(321, 153);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(124, 20);
            this.txtCelular.TabIndex = 33;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Location = new System.Drawing.Point(234, 372);
            this.txtDataNasc.Mask = "00/00/0000";
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(70, 20);
            this.txtDataNasc.TabIndex = 34;
            this.txtDataNasc.ValidatingType = typeof(System.DateTime);
            this.txtDataNasc.Leave += new System.EventHandler(this.txtDataNasc_Leave);
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(230, 356);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(68, 13);
            this.lblDataNasc.TabIndex = 36;
            this.lblDataNasc.Text = "Data Nasc.:*";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(318, 138);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(46, 13);
            this.lblCelular.TabIndex = 35;
            this.lblCelular.Text = "Celular:*";
            // 
            // txtCPF_CNPJ
            // 
            this.txtCPF_CNPJ.Location = new System.Drawing.Point(29, 372);
            this.txtCPF_CNPJ.Mask = "000.000.000-00";
            this.txtCPF_CNPJ.Name = "txtCPF_CNPJ";
            this.txtCPF_CNPJ.Size = new System.Drawing.Size(86, 20);
            this.txtCPF_CNPJ.TabIndex = 37;
            this.txtCPF_CNPJ.Leave += new System.EventHandler(this.txtCPF_CNPJ_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Location = new System.Drawing.Point(23, 153);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(281, 20);
            this.txtEmail.TabIndex = 38;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtTelefone
            // 
            this.txtTelefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefone.Location = new System.Drawing.Point(467, 153);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(135, 20);
            this.txtTelefone.TabIndex = 39;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(464, 138);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 40;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtNomeContato
            // 
            this.txtNomeContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeContato.Location = new System.Drawing.Point(617, 153);
            this.txtNomeContato.Name = "txtNomeContato";
            this.txtNomeContato.Size = new System.Drawing.Size(215, 20);
            this.txtNomeContato.TabIndex = 41;
            this.txtNomeContato.Visible = false;
            this.txtNomeContato.Leave += new System.EventHandler(this.txtNomeContato_Leave);
            // 
            // lblNomeContato
            // 
            this.lblNomeContato.AutoSize = true;
            this.lblNomeContato.Location = new System.Drawing.Point(614, 137);
            this.lblNomeContato.Name = "lblNomeContato";
            this.lblNomeContato.Size = new System.Drawing.Size(96, 13);
            this.lblNomeContato.TabIndex = 42;
            this.lblNomeContato.Text = "Nome do contato:*";
            this.lblNomeContato.Visible = false;
            // 
            // gpPessoa
            // 
            this.gpPessoa.Controls.Add(this.rbJuridica);
            this.gpPessoa.Controls.Add(this.rbFisica);
            this.gpPessoa.Location = new System.Drawing.Point(94, 12);
            this.gpPessoa.Name = "gpPessoa";
            this.gpPessoa.Size = new System.Drawing.Size(133, 50);
            this.gpPessoa.TabIndex = 43;
            this.gpPessoa.TabStop = false;
            this.gpPessoa.Text = "Pessoa";
            // 
            // rbJuridica
            // 
            this.rbJuridica.AutoSize = true;
            this.rbJuridica.Location = new System.Drawing.Point(66, 19);
            this.rbJuridica.Name = "rbJuridica";
            this.rbJuridica.Size = new System.Drawing.Size(63, 17);
            this.rbJuridica.TabIndex = 1;
            this.rbJuridica.Text = "Jurídica";
            this.rbJuridica.UseVisualStyleBackColor = true;
            this.rbJuridica.CheckedChanged += new System.EventHandler(this.rbJuridica_CheckedChanged);
            // 
            // rbFisica
            // 
            this.rbFisica.AutoSize = true;
            this.rbFisica.Checked = true;
            this.rbFisica.Location = new System.Drawing.Point(6, 19);
            this.rbFisica.Name = "rbFisica";
            this.rbFisica.Size = new System.Drawing.Size(54, 17);
            this.rbFisica.TabIndex = 0;
            this.rbFisica.TabStop = true;
            this.rbFisica.Text = "Física";
            this.rbFisica.UseVisualStyleBackColor = true;
            this.rbFisica.CheckedChanged += new System.EventHandler(this.rbFisica_CheckedChanged);
            // 
            // lblRG_IE
            // 
            this.lblRG_IE.AutoSize = true;
            this.lblRG_IE.Location = new System.Drawing.Point(124, 356);
            this.lblRG_IE.Name = "lblRG_IE";
            this.lblRG_IE.Size = new System.Drawing.Size(26, 13);
            this.lblRG_IE.TabIndex = 44;
            this.lblRG_IE.Text = "RG:";
            // 
            // txtRG_IE
            // 
            this.txtRG_IE.Location = new System.Drawing.Point(127, 372);
            this.txtRG_IE.Name = "txtRG_IE";
            this.txtRG_IE.Size = new System.Drawing.Size(96, 20);
            this.txtRG_IE.TabIndex = 45;
            this.txtRG_IE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRG_IE_KeyPress);
            this.txtRG_IE.Leave += new System.EventHandler(this.txtRG_IE_Leave);
            // 
            // gpPagamento
            // 
            this.gpPagamento.Controls.Add(this.txtCondPag);
            this.gpPagamento.Controls.Add(this.lblCondPag);
            this.gpPagamento.Controls.Add(this.btnBuscarCondPag);
            this.gpPagamento.Controls.Add(this.txtCodCondPag);
            this.gpPagamento.Controls.Add(this.lblCodCondPag);
            this.gpPagamento.Location = new System.Drawing.Point(343, 345);
            this.gpPagamento.Name = "gpPagamento";
            this.gpPagamento.Size = new System.Drawing.Size(382, 79);
            this.gpPagamento.TabIndex = 46;
            this.gpPagamento.TabStop = false;
            this.gpPagamento.Text = "Pagamento";
            // 
            // txtCondPag
            // 
            this.txtCondPag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCondPag.Enabled = false;
            this.txtCondPag.Location = new System.Drawing.Point(163, 44);
            this.txtCondPag.Name = "txtCondPag";
            this.txtCondPag.Size = new System.Drawing.Size(206, 20);
            this.txtCondPag.TabIndex = 50;
            // 
            // lblCondPag
            // 
            this.lblCondPag.AutoSize = true;
            this.lblCondPag.Location = new System.Drawing.Point(160, 29);
            this.lblCondPag.Name = "lblCondPag";
            this.lblCondPag.Size = new System.Drawing.Size(127, 13);
            this.lblCondPag.TabIndex = 51;
            this.lblCondPag.Text = "Condição de Pagamento:";
            // 
            // btnBuscarCondPag
            // 
            this.btnBuscarCondPag.Location = new System.Drawing.Point(104, 41);
            this.btnBuscarCondPag.Name = "btnBuscarCondPag";
            this.btnBuscarCondPag.Size = new System.Drawing.Size(53, 23);
            this.btnBuscarCondPag.TabIndex = 48;
            this.btnBuscarCondPag.Text = "Buscar";
            this.btnBuscarCondPag.UseVisualStyleBackColor = true;
            this.btnBuscarCondPag.Click += new System.EventHandler(this.btnBuscarCondPag_Click);
            // 
            // txtCodCondPag
            // 
            this.txtCodCondPag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodCondPag.Location = new System.Drawing.Point(18, 43);
            this.txtCodCondPag.Name = "txtCodCondPag";
            this.txtCodCondPag.Size = new System.Drawing.Size(80, 20);
            this.txtCodCondPag.TabIndex = 47;
            this.txtCodCondPag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodCondPag_KeyPress);
            this.txtCodCondPag.Leave += new System.EventHandler(this.txtCodCondPag_Leave);
            // 
            // lblCodCondPag
            // 
            this.lblCodCondPag.AutoSize = true;
            this.lblCodCondPag.Location = new System.Drawing.Point(15, 27);
            this.lblCodCondPag.Name = "lblCodCondPag";
            this.lblCodCondPag.Size = new System.Drawing.Size(47, 13);
            this.lblCodCondPag.TabIndex = 49;
            this.lblCodCondPag.Text = "Código:*";
            // 
            // CadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(873, 529);
            this.Controls.Add(this.gpPagamento);
            this.Controls.Add(this.txtRG_IE);
            this.Controls.Add(this.lblRG_IE);
            this.Controls.Add(this.gpPessoa);
            this.Controls.Add(this.txtNomeContato);
            this.Controls.Add(this.lblNomeContato);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCPF_CNPJ);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtDataNasc);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblCPF_CNPJ);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.gbEndereco);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.lblApelido);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.lblFornecedor);
            this.Name = "CadastroFornecedor";
            this.Text = "Cadastro de Fornecedor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroFornecedor_FormClosed);
            this.Load += new System.EventHandler(this.CadastroFornecedor_Load);
            this.Controls.SetChildIndex(this.lblFornecedor, 0);
            this.Controls.SetChildIndex(this.txtFornecedor, 0);
            this.Controls.SetChildIndex(this.lblApelido, 0);
            this.Controls.SetChildIndex(this.txtApelido, 0);
            this.Controls.SetChildIndex(this.lblSexo, 0);
            this.Controls.SetChildIndex(this.txtSexo, 0);
            this.Controls.SetChildIndex(this.gbEndereco, 0);
            this.Controls.SetChildIndex(this.lblEmail, 0);
            this.Controls.SetChildIndex(this.lblCPF_CNPJ, 0);
            this.Controls.SetChildIndex(this.lblCelular, 0);
            this.Controls.SetChildIndex(this.lblDataNasc, 0);
            this.Controls.SetChildIndex(this.txtDataNasc, 0);
            this.Controls.SetChildIndex(this.txtCelular, 0);
            this.Controls.SetChildIndex(this.txtCPF_CNPJ, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.lblTelefone, 0);
            this.Controls.SetChildIndex(this.txtTelefone, 0);
            this.Controls.SetChildIndex(this.lblNomeContato, 0);
            this.Controls.SetChildIndex(this.txtNomeContato, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.gbStatus, 0);
            this.Controls.SetChildIndex(this.gpPessoa, 0);
            this.Controls.SetChildIndex(this.lblRG_IE, 0);
            this.Controls.SetChildIndex(this.txtRG_IE, 0);
            this.Controls.SetChildIndex(this.gpPagamento, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.gpPessoa.ResumeLayout(false);
            this.gpPessoa.PerformLayout();
            this.gpPagamento.ResumeLayout(false);
            this.gpPagamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCPF_CNPJ;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCodCidade;
        private System.Windows.Forms.Label lblCodCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.ComboBox txtSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.MaskedTextBox txtDataNasc;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.MaskedTextBox txtCPF_CNPJ;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtNomeContato;
        private System.Windows.Forms.Label lblNomeContato;
        private System.Windows.Forms.GroupBox gpPessoa;
        private System.Windows.Forms.RadioButton rbJuridica;
        private System.Windows.Forms.RadioButton rbFisica;
        private System.Windows.Forms.Label lblRG_IE;
        private System.Windows.Forms.TextBox txtRG_IE;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gpPagamento;
        private System.Windows.Forms.TextBox txtCondPag;
        private System.Windows.Forms.Label lblCondPag;
        private System.Windows.Forms.Button btnBuscarCondPag;
        private System.Windows.Forms.TextBox txtCodCondPag;
        private System.Windows.Forms.Label lblCodCondPag;
    }
}
