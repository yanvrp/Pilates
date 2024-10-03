namespace Pilates.Views
{
    partial class ConsultaPostura
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
            this.dataGridViewPostura = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Título = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostura)).BeginInit();
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
            // btnIncluir
            // 
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // dataGridViewPostura
            // 
            this.dataGridViewPostura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPostura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Título,
            this.DataCadastro});
            this.dataGridViewPostura.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewPostura.Name = "dataGridViewPostura";
            this.dataGridViewPostura.Size = new System.Drawing.Size(776, 371);
            this.dataGridViewPostura.TabIndex = 7;
            this.dataGridViewPostura.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewPostura_CellFormatting);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // Título
            // 
            this.Título.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Título.HeaderText = "Título";
            this.Título.Name = "Título";
            // 
            // DataCadastro
            // 
            this.DataCadastro.HeaderText = "DataCadastro";
            this.DataCadastro.Name = "DataCadastro";
            // 
            // ConsultaPostura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewPostura);
            this.Name = "ConsultaPostura";
            this.Text = "Consulta de Postura";
            this.Load += new System.EventHandler(this.ConsultaPostura_Load);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.txtPesquisar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.cbInativos, 0);
            this.Controls.SetChildIndex(this.dataGridViewPostura, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPostura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Título;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCadastro;
    }
}
