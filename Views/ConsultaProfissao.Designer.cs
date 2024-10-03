namespace Pilates.Views
{
    partial class ConsultaProfissao
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
            this.dataGridViewProfissao = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profissão = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfissao)).BeginInit();
            this.SuspendLayout();
            // 
            // cbInativos
            // 
            this.cbInativos.CheckedChanged += new System.EventHandler(this.cbInativos_CheckedChanged);
            // 
            // btnSair
            // 
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dataGridViewProfissao
            // 
            this.dataGridViewProfissao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfissao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Profissão,
            this.Descrição});
            this.dataGridViewProfissao.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewProfissao.Name = "dataGridViewProfissao";
            this.dataGridViewProfissao.Size = new System.Drawing.Size(776, 371);
            this.dataGridViewProfissao.TabIndex = 7;
            this.dataGridViewProfissao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProfissao_CellDoubleClick);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // Profissão
            // 
            this.Profissão.HeaderText = "Profissão";
            this.Profissão.Name = "Profissão";
            this.Profissão.Width = 200;
            // 
            // Descrição
            // 
            this.Descrição.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            // 
            // ConsultaProfissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewProfissao);
            this.Name = "ConsultaProfissao";
            this.Text = "Consulta de Profissão";
            this.Load += new System.EventHandler(this.ConsultaProfissao_Load);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.txtPesquisar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.cbInativos, 0);
            this.Controls.SetChildIndex(this.dataGridViewProfissao, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfissao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProfissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profissão;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
    }
}
