namespace Pilates.Views
{
    partial class CadastroAluno
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblApelido = new System.Windows.Forms.Label();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.ComboBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.txtDataNasc = new System.Windows.Forms.MaskedTextBox();
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.dataGridViewPostura = new System.Windows.Forms.DataGridView();
            this.CodigoPostura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TituloPostura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewEvolucao = new System.Windows.Forms.DataGridView();
            this.CodigoEvolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TituloEvolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPostura = new System.Windows.Forms.Label();
            this.lblEvolucao = new System.Windows.Forms.Label();
            this.btnIncluirPostura = new System.Windows.Forms.Button();
            this.btnAlterarPostura = new System.Windows.Forms.Button();
            this.btnExcluirPostura = new System.Windows.Forms.Button();
            this.btnExcluirEvolucao = new System.Windows.Forms.Button();
            this.btnAlterarEvolucao = new System.Windows.Forms.Button();
            this.btnIncluirEvolucao = new System.Windows.Forms.Button();
            this.gbStatus.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvolucao)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Text = "0";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(841, 687);
            this.btnSair.TabIndex = 17;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(760, 687);
            this.btnSalvar.TabIndex = 16;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(16, 691);
            this.txtDataCadastro.Text = "12062024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(130, 690);
            this.txtDataUltAlt.Text = "12062024";
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(127, 665);
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(13, 665);
            // 
            // gbStatus
            // 
            this.gbStatus.Location = new System.Drawing.Point(764, 19);
            this.gbStatus.TabIndex = 20;
            // 
            // rbInativo
            // 
            this.rbInativo.TabIndex = 22;
            // 
            // rbAtivo
            // 
            this.rbAtivo.TabIndex = 21;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(21, 83);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(42, 13);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Nome:*";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(24, 99);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(312, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Location = new System.Drawing.Point(359, 83);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(45, 13);
            this.lblApelido.TabIndex = 11;
            this.lblApelido.Text = "Apelido:";
            // 
            // txtApelido
            // 
            this.txtApelido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApelido.Location = new System.Drawing.Point(362, 99);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(236, 20);
            this.txtApelido.TabIndex = 2;
            this.txtApelido.Leave += new System.EventHandler(this.txtApelido_Leave);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(604, 83);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(38, 13);
            this.lblSexo.TabIndex = 13;
            this.lblSexo.Text = "Sexo:*";
            // 
            // txtSexo
            // 
            this.txtSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSexo.FormattingEnabled = true;
            this.txtSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMININO",
            "OUTROS"});
            this.txtSexo.Location = new System.Drawing.Point(607, 98);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(121, 21);
            this.txtSexo.TabIndex = 3;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(734, 83);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(46, 13);
            this.lblCelular.TabIndex = 15;
            this.lblCelular.Text = "Celular:*";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(838, 83);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(68, 13);
            this.lblDataNasc.TabIndex = 17;
            this.lblDataNasc.Text = "Data Nasc.:*";
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Location = new System.Drawing.Point(841, 98);
            this.txtDataNasc.Mask = "00/00/0000";
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(70, 20);
            this.txtDataNasc.TabIndex = 5;
            this.txtDataNasc.ValidatingType = typeof(System.DateTime);
            this.txtDataNasc.Leave += new System.EventHandler(this.txtDataNasc_Leave);
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
            this.gbEndereco.Location = new System.Drawing.Point(23, 139);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(887, 133);
            this.gbEndereco.TabIndex = 6;
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
            this.txtPais.Size = new System.Drawing.Size(225, 20);
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
            this.txtBairro.Size = new System.Drawing.Size(152, 20);
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
            this.txtComplemento.Size = new System.Drawing.Size(319, 20);
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
            this.txtNumero.Leave += new System.EventHandler(this.txtNumero_Leave);
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
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(24, 275);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 13);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "Email:*";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Location = new System.Drawing.Point(28, 291);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(312, 20);
            this.txtEmail.TabIndex = 14;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtCelular
            // 
            this.txtCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCelular.Location = new System.Drawing.Point(737, 98);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 20);
            this.txtCelular.TabIndex = 4;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            this.txtCelular.Leave += new System.EventHandler(this.txtCelular_Leave);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(344, 275);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(34, 13);
            this.lblCPF.TabIndex = 23;
            this.lblCPF.Text = "CPF:*";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(347, 290);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(86, 20);
            this.txtCPF.TabIndex = 15;
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // dataGridViewPostura
            // 
            this.dataGridViewPostura.AllowUserToAddRows = false;
            this.dataGridViewPostura.AllowUserToDeleteRows = false;
            this.dataGridViewPostura.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dataGridViewPostura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPostura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoPostura,
            this.TituloPostura});
            this.dataGridViewPostura.Location = new System.Drawing.Point(29, 358);
            this.dataGridViewPostura.Name = "dataGridViewPostura";
            this.dataGridViewPostura.ReadOnly = true;
            this.dataGridViewPostura.Size = new System.Drawing.Size(416, 266);
            this.dataGridViewPostura.TabIndex = 24;
            this.dataGridViewPostura.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPostura_CellDoubleClick);
            // 
            // CodigoPostura
            // 
            this.CodigoPostura.HeaderText = "Código";
            this.CodigoPostura.Name = "CodigoPostura";
            this.CodigoPostura.ReadOnly = true;
            // 
            // TituloPostura
            // 
            this.TituloPostura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TituloPostura.HeaderText = "Título";
            this.TituloPostura.Name = "TituloPostura";
            this.TituloPostura.ReadOnly = true;
            // 
            // dataGridViewEvolucao
            // 
            this.dataGridViewEvolucao.AllowUserToAddRows = false;
            this.dataGridViewEvolucao.AllowUserToDeleteRows = false;
            this.dataGridViewEvolucao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dataGridViewEvolucao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvolucao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoEvolucao,
            this.TituloEvolucao});
            this.dataGridViewEvolucao.Location = new System.Drawing.Point(468, 358);
            this.dataGridViewEvolucao.Name = "dataGridViewEvolucao";
            this.dataGridViewEvolucao.ReadOnly = true;
            this.dataGridViewEvolucao.Size = new System.Drawing.Size(444, 266);
            this.dataGridViewEvolucao.TabIndex = 25;
            this.dataGridViewEvolucao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEvolucao_CellContentClick);
            this.dataGridViewEvolucao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEvolucao_CellDoubleClick);
            // 
            // CodigoEvolucao
            // 
            this.CodigoEvolucao.HeaderText = "Código";
            this.CodigoEvolucao.Name = "CodigoEvolucao";
            this.CodigoEvolucao.ReadOnly = true;
            // 
            // TituloEvolucao
            // 
            this.TituloEvolucao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TituloEvolucao.HeaderText = "Título";
            this.TituloEvolucao.Name = "TituloEvolucao";
            this.TituloEvolucao.ReadOnly = true;
            // 
            // lblPostura
            // 
            this.lblPostura.AutoSize = true;
            this.lblPostura.Location = new System.Drawing.Point(29, 333);
            this.lblPostura.Name = "lblPostura";
            this.lblPostura.Size = new System.Drawing.Size(46, 13);
            this.lblPostura.TabIndex = 26;
            this.lblPostura.Text = "Postura:";
            this.lblPostura.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEvolucao
            // 
            this.lblEvolucao.AutoSize = true;
            this.lblEvolucao.Location = new System.Drawing.Point(465, 333);
            this.lblEvolucao.Name = "lblEvolucao";
            this.lblEvolucao.Size = new System.Drawing.Size(55, 13);
            this.lblEvolucao.TabIndex = 27;
            this.lblEvolucao.Text = "Evolução:";
            // 
            // btnIncluirPostura
            // 
            this.btnIncluirPostura.Location = new System.Drawing.Point(208, 630);
            this.btnIncluirPostura.Name = "btnIncluirPostura";
            this.btnIncluirPostura.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirPostura.TabIndex = 28;
            this.btnIncluirPostura.Text = "Incluir";
            this.btnIncluirPostura.UseVisualStyleBackColor = true;
            this.btnIncluirPostura.Click += new System.EventHandler(this.btnIncluirPostura_Click);
            // 
            // btnAlterarPostura
            // 
            this.btnAlterarPostura.Location = new System.Drawing.Point(289, 630);
            this.btnAlterarPostura.Name = "btnAlterarPostura";
            this.btnAlterarPostura.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarPostura.TabIndex = 29;
            this.btnAlterarPostura.Text = "Alterar";
            this.btnAlterarPostura.UseVisualStyleBackColor = true;
            this.btnAlterarPostura.Click += new System.EventHandler(this.btnAlterarPostura_Click);
            // 
            // btnExcluirPostura
            // 
            this.btnExcluirPostura.Location = new System.Drawing.Point(370, 630);
            this.btnExcluirPostura.Name = "btnExcluirPostura";
            this.btnExcluirPostura.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirPostura.TabIndex = 30;
            this.btnExcluirPostura.Text = "Excluir";
            this.btnExcluirPostura.UseVisualStyleBackColor = true;
            this.btnExcluirPostura.Click += new System.EventHandler(this.btnExcluirPostura_Click);
            // 
            // btnExcluirEvolucao
            // 
            this.btnExcluirEvolucao.Location = new System.Drawing.Point(841, 630);
            this.btnExcluirEvolucao.Name = "btnExcluirEvolucao";
            this.btnExcluirEvolucao.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirEvolucao.TabIndex = 33;
            this.btnExcluirEvolucao.Text = "Excluir";
            this.btnExcluirEvolucao.UseVisualStyleBackColor = true;
            this.btnExcluirEvolucao.Click += new System.EventHandler(this.btnExcluirEvolucao_Click);
            // 
            // btnAlterarEvolucao
            // 
            this.btnAlterarEvolucao.Location = new System.Drawing.Point(760, 630);
            this.btnAlterarEvolucao.Name = "btnAlterarEvolucao";
            this.btnAlterarEvolucao.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarEvolucao.TabIndex = 32;
            this.btnAlterarEvolucao.Text = "Alterar";
            this.btnAlterarEvolucao.UseVisualStyleBackColor = true;
            this.btnAlterarEvolucao.Click += new System.EventHandler(this.btnAlterarEvolucao_Click);
            // 
            // btnIncluirEvolucao
            // 
            this.btnIncluirEvolucao.Location = new System.Drawing.Point(679, 630);
            this.btnIncluirEvolucao.Name = "btnIncluirEvolucao";
            this.btnIncluirEvolucao.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirEvolucao.TabIndex = 31;
            this.btnIncluirEvolucao.Text = "Incluir";
            this.btnIncluirEvolucao.UseVisualStyleBackColor = true;
            this.btnIncluirEvolucao.Click += new System.EventHandler(this.btnIncluirEvolucao_Click);
            // 
            // CadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(941, 722);
            this.Controls.Add(this.btnExcluirEvolucao);
            this.Controls.Add(this.btnAlterarEvolucao);
            this.Controls.Add(this.btnIncluirEvolucao);
            this.Controls.Add(this.btnExcluirPostura);
            this.Controls.Add(this.btnAlterarPostura);
            this.Controls.Add(this.btnIncluirPostura);
            this.Controls.Add(this.lblEvolucao);
            this.Controls.Add(this.lblPostura);
            this.Controls.Add(this.dataGridViewEvolucao);
            this.Controls.Add(this.dataGridViewPostura);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.gbEndereco);
            this.Controls.Add(this.txtDataNasc);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.lblApelido);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "CadastroAluno";
            this.Text = "Cadastro de Aluno";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroAluno_FormClosed);
            this.Load += new System.EventHandler(this.CadastroAluno_Load);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.gbStatus, 0);
            this.Controls.SetChildIndex(this.lblNome, 0);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.Controls.SetChildIndex(this.lblApelido, 0);
            this.Controls.SetChildIndex(this.txtApelido, 0);
            this.Controls.SetChildIndex(this.lblSexo, 0);
            this.Controls.SetChildIndex(this.txtSexo, 0);
            this.Controls.SetChildIndex(this.lblCelular, 0);
            this.Controls.SetChildIndex(this.lblDataNasc, 0);
            this.Controls.SetChildIndex(this.txtDataNasc, 0);
            this.Controls.SetChildIndex(this.gbEndereco, 0);
            this.Controls.SetChildIndex(this.lblEmail, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.txtCelular, 0);
            this.Controls.SetChildIndex(this.lblCPF, 0);
            this.Controls.SetChildIndex(this.txtCPF, 0);
            this.Controls.SetChildIndex(this.dataGridViewPostura, 0);
            this.Controls.SetChildIndex(this.dataGridViewEvolucao, 0);
            this.Controls.SetChildIndex(this.lblPostura, 0);
            this.Controls.SetChildIndex(this.lblEvolucao, 0);
            this.Controls.SetChildIndex(this.btnIncluirPostura, 0);
            this.Controls.SetChildIndex(this.btnAlterarPostura, 0);
            this.Controls.SetChildIndex(this.btnExcluirPostura, 0);
            this.Controls.SetChildIndex(this.btnIncluirEvolucao, 0);
            this.Controls.SetChildIndex(this.btnAlterarEvolucao, 0);
            this.Controls.SetChildIndex(this.btnExcluirEvolucao, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvolucao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox txtSexo;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.MaskedTextBox txtDataNasc;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCodCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCodCidade;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.DataGridView dataGridViewPostura;
        private System.Windows.Forms.DataGridView dataGridViewEvolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoEvolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TituloEvolucao;
        private System.Windows.Forms.Label lblPostura;
        private System.Windows.Forms.Label lblEvolucao;
        private System.Windows.Forms.Button btnIncluirPostura;
        private System.Windows.Forms.Button btnAlterarPostura;
        private System.Windows.Forms.Button btnExcluirPostura;
        private System.Windows.Forms.Button btnExcluirEvolucao;
        private System.Windows.Forms.Button btnAlterarEvolucao;
        private System.Windows.Forms.Button btnIncluirEvolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPostura;
        private System.Windows.Forms.DataGridViewTextBoxColumn TituloPostura;
    }
}
