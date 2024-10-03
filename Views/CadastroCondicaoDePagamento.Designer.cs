namespace Pilates.Views
{
    partial class CadastroCondicaoDePagamento
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
            this.lblCondicaoPagamento = new System.Windows.Forms.Label();
            this.txtCondicaoPagamento = new System.Windows.Forms.TextBox();
            this.lblJuros = new System.Windows.Forms.Label();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.txtMulta = new System.Windows.Forms.TextBox();
            this.lblMulta = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.lblNumeroParcelas = new System.Windows.Forms.Label();
            this.txtNumParcelas = new System.Windows.Forms.TextBox();
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.txtPorcentagem = new System.Windows.Forms.TextBox();
            this.txtPorcentagemTotal = new System.Windows.Forms.TextBox();
            this.lblPorcentagemTotal = new System.Windows.Forms.Label();
            this.lblCodigoPagamento = new System.Windows.Forms.Label();
            this.txtCodigoPagamento = new System.Windows.Forms.TextBox();
            this.btnPesquisarPagamento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFormaPagamento = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dataGridViewParcelas = new System.Windows.Forms.DataGridView();
            this.numeroParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CódFormaPag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluirParcela = new System.Windows.Forms.Button();
            this.gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Text = "0";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(549, 570);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(468, 570);
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(12, 570);
            this.txtDataCadastro.Text = "17082024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(126, 569);
            this.txtDataUltAlt.Text = "17082024";
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(123, 544);
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(9, 544);
            // 
            // gbStatus
            // 
            this.gbStatus.Location = new System.Drawing.Point(459, 12);
            // 
            // lblCondicaoPagamento
            // 
            this.lblCondicaoPagamento.AutoSize = true;
            this.lblCondicaoPagamento.Location = new System.Drawing.Point(20, 77);
            this.lblCondicaoPagamento.Name = "lblCondicaoPagamento";
            this.lblCondicaoPagamento.Size = new System.Drawing.Size(131, 13);
            this.lblCondicaoPagamento.TabIndex = 9;
            this.lblCondicaoPagamento.Text = "Condição de Pagamento:*";
            // 
            // txtCondicaoPagamento
            // 
            this.txtCondicaoPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCondicaoPagamento.Location = new System.Drawing.Point(23, 93);
            this.txtCondicaoPagamento.Name = "txtCondicaoPagamento";
            this.txtCondicaoPagamento.Size = new System.Drawing.Size(279, 20);
            this.txtCondicaoPagamento.TabIndex = 10;
            // 
            // lblJuros
            // 
            this.lblJuros.AutoSize = true;
            this.lblJuros.Location = new System.Drawing.Point(309, 77);
            this.lblJuros.Name = "lblJuros";
            this.lblJuros.Size = new System.Drawing.Size(43, 13);
            this.lblJuros.TabIndex = 11;
            this.lblJuros.Text = "% Juros";
            // 
            // txtJuros
            // 
            this.txtJuros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtJuros.Location = new System.Drawing.Point(312, 93);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(100, 20);
            this.txtJuros.TabIndex = 12;
            this.txtJuros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJuros_KeyPress);
            this.txtJuros.Leave += new System.EventHandler(this.txtJuros_Leave);
            // 
            // txtMulta
            // 
            this.txtMulta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMulta.Location = new System.Drawing.Point(418, 92);
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.Size = new System.Drawing.Size(100, 20);
            this.txtMulta.TabIndex = 13;
            this.txtMulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMulta_KeyPress);
            // 
            // lblMulta
            // 
            this.lblMulta.AutoSize = true;
            this.lblMulta.Location = new System.Drawing.Point(415, 76);
            this.lblMulta.Name = "lblMulta";
            this.lblMulta.Size = new System.Drawing.Size(44, 13);
            this.lblMulta.TabIndex = 14;
            this.lblMulta.Text = "% Multa";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(521, 76);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(64, 13);
            this.lblDesconto.TabIndex = 15;
            this.lblDesconto.Text = "% Desconto";
            // 
            // txtDesconto
            // 
            this.txtDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesconto.Location = new System.Drawing.Point(524, 92);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(100, 20);
            this.txtDesconto.TabIndex = 16;
            this.txtDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesconto_KeyPress);
            // 
            // lblNumeroParcelas
            // 
            this.lblNumeroParcelas.AutoSize = true;
            this.lblNumeroParcelas.Location = new System.Drawing.Point(20, 125);
            this.lblNumeroParcelas.Name = "lblNumeroParcelas";
            this.lblNumeroParcelas.Size = new System.Drawing.Size(110, 13);
            this.lblNumeroParcelas.TabIndex = 17;
            this.lblNumeroParcelas.Text = "Numero de Parcelas *";
            // 
            // txtNumParcelas
            // 
            this.txtNumParcelas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumParcelas.Location = new System.Drawing.Point(23, 141);
            this.txtNumParcelas.Name = "txtNumParcelas";
            this.txtNumParcelas.Size = new System.Drawing.Size(100, 20);
            this.txtNumParcelas.TabIndex = 18;
            this.txtNumParcelas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumParcelas_KeyPress);
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.Location = new System.Drawing.Point(161, 125);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(15, 13);
            this.lblPorcentagem.TabIndex = 19;
            this.lblPorcentagem.Text = "%";
            // 
            // txtPorcentagem
            // 
            this.txtPorcentagem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPorcentagem.Location = new System.Drawing.Point(139, 141);
            this.txtPorcentagem.Name = "txtPorcentagem";
            this.txtPorcentagem.Size = new System.Drawing.Size(57, 20);
            this.txtPorcentagem.TabIndex = 20;
            this.txtPorcentagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentagem_KeyPress);
            this.txtPorcentagem.Leave += new System.EventHandler(this.txtPorcentagem_Leave);
            // 
            // txtPorcentagemTotal
            // 
            this.txtPorcentagemTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPorcentagemTotal.Enabled = false;
            this.txtPorcentagemTotal.Location = new System.Drawing.Point(207, 141);
            this.txtPorcentagemTotal.Name = "txtPorcentagemTotal";
            this.txtPorcentagemTotal.Size = new System.Drawing.Size(57, 20);
            this.txtPorcentagemTotal.TabIndex = 22;
            // 
            // lblPorcentagemTotal
            // 
            this.lblPorcentagemTotal.AutoSize = true;
            this.lblPorcentagemTotal.Location = new System.Drawing.Point(204, 125);
            this.lblPorcentagemTotal.Name = "lblPorcentagemTotal";
            this.lblPorcentagemTotal.Size = new System.Drawing.Size(42, 13);
            this.lblPorcentagemTotal.TabIndex = 21;
            this.lblPorcentagemTotal.Text = "% Total";
            // 
            // lblCodigoPagamento
            // 
            this.lblCodigoPagamento.AutoSize = true;
            this.lblCodigoPagamento.Location = new System.Drawing.Point(270, 125);
            this.lblCodigoPagamento.Name = "lblCodigoPagamento";
            this.lblCodigoPagamento.Size = new System.Drawing.Size(47, 13);
            this.lblCodigoPagamento.TabIndex = 23;
            this.lblCodigoPagamento.Text = "Código *";
            // 
            // txtCodigoPagamento
            // 
            this.txtCodigoPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoPagamento.Location = new System.Drawing.Point(273, 141);
            this.txtCodigoPagamento.Name = "txtCodigoPagamento";
            this.txtCodigoPagamento.Size = new System.Drawing.Size(57, 20);
            this.txtCodigoPagamento.TabIndex = 24;
            this.txtCodigoPagamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoPagamento_KeyPress);
            this.txtCodigoPagamento.Leave += new System.EventHandler(this.txtCodigoPagamento_Leave);
            // 
            // btnPesquisarPagamento
            // 
            this.btnPesquisarPagamento.Location = new System.Drawing.Point(336, 139);
            this.btnPesquisarPagamento.Name = "btnPesquisarPagamento";
            this.btnPesquisarPagamento.Size = new System.Drawing.Size(63, 23);
            this.btnPesquisarPagamento.TabIndex = 25;
            this.btnPesquisarPagamento.Text = "Pesquisar";
            this.btnPesquisarPagamento.UseVisualStyleBackColor = true;
            this.btnPesquisarPagamento.Click += new System.EventHandler(this.btnPesquisarPagamento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Forma de Pagamento:";
            // 
            // txtFormaPagamento
            // 
            this.txtFormaPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFormaPagamento.Enabled = false;
            this.txtFormaPagamento.Location = new System.Drawing.Point(408, 141);
            this.txtFormaPagamento.Name = "txtFormaPagamento";
            this.txtFormaPagamento.Size = new System.Drawing.Size(144, 20);
            this.txtFormaPagamento.TabIndex = 27;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(558, 138);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(66, 23);
            this.btnAdicionar.TabIndex = 28;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dataGridViewParcelas
            // 
            this.dataGridViewParcelas.AllowUserToAddRows = false;
            this.dataGridViewParcelas.AllowUserToDeleteRows = false;
            this.dataGridViewParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroParcela,
            this.porcentagem,
            this.CódFormaPag,
            this.formaPagamento});
            this.dataGridViewParcelas.Location = new System.Drawing.Point(23, 167);
            this.dataGridViewParcelas.Name = "dataGridViewParcelas";
            this.dataGridViewParcelas.Size = new System.Drawing.Size(601, 291);
            this.dataGridViewParcelas.TabIndex = 29;
            // 
            // numeroParcela
            // 
            this.numeroParcela.HeaderText = "Num. Parcela";
            this.numeroParcela.Name = "numeroParcela";
            // 
            // porcentagem
            // 
            this.porcentagem.HeaderText = "%";
            this.porcentagem.Name = "porcentagem";
            // 
            // CódFormaPag
            // 
            this.CódFormaPag.HeaderText = "Cód. Forma Pagamento";
            this.CódFormaPag.Name = "CódFormaPag";
            // 
            // formaPagamento
            // 
            this.formaPagamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.formaPagamento.HeaderText = "Forma de Pagamento";
            this.formaPagamento.Name = "formaPagamento";
            // 
            // btnExcluirParcela
            // 
            this.btnExcluirParcela.Location = new System.Drawing.Point(524, 464);
            this.btnExcluirParcela.Name = "btnExcluirParcela";
            this.btnExcluirParcela.Size = new System.Drawing.Size(100, 23);
            this.btnExcluirParcela.TabIndex = 30;
            this.btnExcluirParcela.Text = "Excluir Parcela";
            this.btnExcluirParcela.UseVisualStyleBackColor = true;
            this.btnExcluirParcela.Click += new System.EventHandler(this.btnExcluirParcela_Click);
            // 
            // CadastroCondicaoDePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(637, 605);
            this.Controls.Add(this.btnExcluirParcela);
            this.Controls.Add(this.dataGridViewParcelas);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtFormaPagamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisarPagamento);
            this.Controls.Add(this.txtCodigoPagamento);
            this.Controls.Add(this.lblCodigoPagamento);
            this.Controls.Add(this.txtPorcentagemTotal);
            this.Controls.Add(this.lblPorcentagemTotal);
            this.Controls.Add(this.txtPorcentagem);
            this.Controls.Add(this.lblPorcentagem);
            this.Controls.Add(this.txtNumParcelas);
            this.Controls.Add(this.lblNumeroParcelas);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.lblMulta);
            this.Controls.Add(this.txtMulta);
            this.Controls.Add(this.txtJuros);
            this.Controls.Add(this.lblJuros);
            this.Controls.Add(this.txtCondicaoPagamento);
            this.Controls.Add(this.lblCondicaoPagamento);
            this.Name = "CadastroCondicaoDePagamento";
            this.Text = "Cadastro de Condição de Pagamento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroCondicaoDePagamento_FormClosed);
            this.Load += new System.EventHandler(this.CadastroCondicaoDePagamento_Load);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.gbStatus, 0);
            this.Controls.SetChildIndex(this.lblCondicaoPagamento, 0);
            this.Controls.SetChildIndex(this.txtCondicaoPagamento, 0);
            this.Controls.SetChildIndex(this.lblJuros, 0);
            this.Controls.SetChildIndex(this.txtJuros, 0);
            this.Controls.SetChildIndex(this.txtMulta, 0);
            this.Controls.SetChildIndex(this.lblMulta, 0);
            this.Controls.SetChildIndex(this.lblDesconto, 0);
            this.Controls.SetChildIndex(this.txtDesconto, 0);
            this.Controls.SetChildIndex(this.lblNumeroParcelas, 0);
            this.Controls.SetChildIndex(this.txtNumParcelas, 0);
            this.Controls.SetChildIndex(this.lblPorcentagem, 0);
            this.Controls.SetChildIndex(this.txtPorcentagem, 0);
            this.Controls.SetChildIndex(this.lblPorcentagemTotal, 0);
            this.Controls.SetChildIndex(this.txtPorcentagemTotal, 0);
            this.Controls.SetChildIndex(this.lblCodigoPagamento, 0);
            this.Controls.SetChildIndex(this.txtCodigoPagamento, 0);
            this.Controls.SetChildIndex(this.btnPesquisarPagamento, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtFormaPagamento, 0);
            this.Controls.SetChildIndex(this.btnAdicionar, 0);
            this.Controls.SetChildIndex(this.dataGridViewParcelas, 0);
            this.Controls.SetChildIndex(this.btnExcluirParcela, 0);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCondicaoPagamento;
        private System.Windows.Forms.TextBox txtCondicaoPagamento;
        private System.Windows.Forms.Label lblJuros;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.TextBox txtMulta;
        private System.Windows.Forms.Label lblMulta;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label lblNumeroParcelas;
        private System.Windows.Forms.TextBox txtNumParcelas;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.TextBox txtPorcentagem;
        private System.Windows.Forms.TextBox txtPorcentagemTotal;
        private System.Windows.Forms.Label lblPorcentagemTotal;
        private System.Windows.Forms.Label lblCodigoPagamento;
        private System.Windows.Forms.TextBox txtCodigoPagamento;
        private System.Windows.Forms.Button btnPesquisarPagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFormaPagamento;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dataGridViewParcelas;
        private System.Windows.Forms.Button btnExcluirParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CódFormaPag;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagamento;
    }
}
