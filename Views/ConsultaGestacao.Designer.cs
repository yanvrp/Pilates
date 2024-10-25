namespace Pilates.Views
{
    partial class ConsultaGestacao
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
            this.dataGridViewGestacao = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gestação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGestacao)).BeginInit();
            this.SuspendLayout();
            // 
            // cbInativos
            // 
            this.cbInativos.CheckedChanged += new System.EventHandler(this.cbInativos_CheckedChanged);
            // 
            // btnIncluir
            // 
            this.btnIncluir.FlatAppearance.BorderSize = 0;
            this.btnIncluir.Location = new System.Drawing.Point(438, 437);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.Location = new System.Drawing.Point(527, 437);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Location = new System.Drawing.Point(616, 437);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(705, 437);
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dataGridViewGestacao
            // 
            this.dataGridViewGestacao.AllowUserToAddRows = false;
            this.dataGridViewGestacao.AllowUserToDeleteRows = false;
            this.dataGridViewGestacao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dataGridViewGestacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGestacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Gestação,
            this.Descrição});
            this.dataGridViewGestacao.Location = new System.Drawing.Point(12, 49);
            this.dataGridViewGestacao.Name = "dataGridViewGestacao";
            this.dataGridViewGestacao.ReadOnly = true;
            this.dataGridViewGestacao.Size = new System.Drawing.Size(776, 371);
            this.dataGridViewGestacao.TabIndex = 8;
            this.dataGridViewGestacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGestacao_CellContentClick);
            this.dataGridViewGestacao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGestacao_CellDoubleClick);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            // 
            // Gestação
            // 
            this.Gestação.HeaderText = "Gestação";
            this.Gestação.Name = "Gestação";
            this.Gestação.ReadOnly = true;
            this.Gestação.Width = 200;
            // 
            // Descrição
            // 
            this.Descrição.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.ReadOnly = true;
            // 
            // ConsultaGestacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.dataGridViewGestacao);
            this.Name = "ConsultaGestacao";
            this.Text = "Consulta de Gestação";
            this.Load += new System.EventHandler(this.ConsultaGestacao_Load);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.txtPesquisar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.cbInativos, 0);
            this.Controls.SetChildIndex(this.dataGridViewGestacao, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGestacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGestacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gestação;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
    }
}
