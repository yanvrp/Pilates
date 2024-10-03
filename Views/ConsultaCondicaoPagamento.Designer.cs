namespace Pilates.Views
{
    partial class ConsultaCondicaoPagamento
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
            this.dataGridViewCondicaoPagamento = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicaoPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCondicaoPagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // cbInativos
            // 
            this.cbInativos.CheckedChanged += new System.EventHandler(this.cbInativos_CheckedChanged);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(447, 415);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(366, 415);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(285, 415);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(528, 415);
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dataGridViewCondicaoPagamento
            // 
            this.dataGridViewCondicaoPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCondicaoPagamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.condicaoPagamento});
            this.dataGridViewCondicaoPagamento.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewCondicaoPagamento.Name = "dataGridViewCondicaoPagamento";
            this.dataGridViewCondicaoPagamento.Size = new System.Drawing.Size(591, 371);
            this.dataGridViewCondicaoPagamento.TabIndex = 7;
            this.dataGridViewCondicaoPagamento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCondicaoPagamento_CellDoubleClick);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // condicaoPagamento
            // 
            this.condicaoPagamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.condicaoPagamento.HeaderText = "Condição de Pagamento";
            this.condicaoPagamento.Name = "condicaoPagamento";
            // 
            // ConsultaCondicaoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.dataGridViewCondicaoPagamento);
            this.Name = "ConsultaCondicaoPagamento";
            this.Text = "Consulta de Condição de Pagamento";
            this.Load += new System.EventHandler(this.ConsultaCondicaoPagamento_Load);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.txtPesquisar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.cbInativos, 0);
            this.Controls.SetChildIndex(this.dataGridViewCondicaoPagamento, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCondicaoPagamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCondicaoPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicaoPagamento;
    }
}
