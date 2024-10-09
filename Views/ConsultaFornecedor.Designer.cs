namespace Pilates.Views
{
    partial class ConsultaFornecedor
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
            this.dataGridViewFornecedor = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // cbInativos
            // 
            this.cbInativos.CheckedChanged += new System.EventHandler(this.cbInativos_CheckedChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(514, 466);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(433, 466);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(352, 466);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(595, 466);
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dataGridViewFornecedor
            // 
            this.dataGridViewFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Fornecedor,
            this.Celular,
            this.Tipo});
            this.dataGridViewFornecedor.Location = new System.Drawing.Point(12, 49);
            this.dataGridViewFornecedor.Name = "dataGridViewFornecedor";
            this.dataGridViewFornecedor.ReadOnly = true;
            this.dataGridViewFornecedor.Size = new System.Drawing.Size(658, 402);
            this.dataGridViewFornecedor.TabIndex = 7;
            this.dataGridViewFornecedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFornecedor_CellDoubleClick);
            this.dataGridViewFornecedor.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewFornecedor_CellFormatting);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            // 
            // Fornecedor
            // 
            this.Fornecedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.ReadOnly = true;
            // 
            // Celular
            // 
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // ConsultaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(683, 501);
            this.Controls.Add(this.dataGridViewFornecedor);
            this.Name = "ConsultaFornecedor";
            this.Text = "Consulta Fornecedor";
            this.Load += new System.EventHandler(this.ConsultaFornecedor_Load);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.txtPesquisar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.cbInativos, 0);
            this.Controls.SetChildIndex(this.dataGridViewFornecedor, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
    }
}
