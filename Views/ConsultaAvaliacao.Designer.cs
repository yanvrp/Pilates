namespace Pilates.Views
{
    partial class ConsultaAvaliacao
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
            this.dataGridViewAvaliacao = new System.Windows.Forms.DataGridView();
            this.idAvaliação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAvaliação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvaliacao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIncluir
            // 
            this.btnIncluir.FlatAppearance.BorderSize = 0;
            this.btnIncluir.Location = new System.Drawing.Point(527, 426);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.Location = new System.Drawing.Point(616, 426);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Location = new System.Drawing.Point(12, 412);
            this.btnExcluir.Visible = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            // 
            // cbInativos
            // 
            this.cbInativos.CheckedChanged += new System.EventHandler(this.cbInativos_CheckedChanged);
            // 
            // dataGridViewAvaliacao
            // 
            this.dataGridViewAvaliacao.AllowUserToAddRows = false;
            this.dataGridViewAvaliacao.AllowUserToDeleteRows = false;
            this.dataGridViewAvaliacao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dataGridViewAvaliacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvaliacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAvaliação,
            this.idAluno,
            this.Aluno,
            this.dataAvaliação});
            this.dataGridViewAvaliacao.Location = new System.Drawing.Point(12, 47);
            this.dataGridViewAvaliacao.Name = "dataGridViewAvaliacao";
            this.dataGridViewAvaliacao.ReadOnly = true;
            this.dataGridViewAvaliacao.Size = new System.Drawing.Size(776, 359);
            this.dataGridViewAvaliacao.TabIndex = 12;
            this.dataGridViewAvaliacao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAvaliacao_CellDoubleClick);
            this.dataGridViewAvaliacao.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewAvaliacao_CellFormatting);
            // 
            // idAvaliação
            // 
            this.idAvaliação.HeaderText = "Código";
            this.idAvaliação.Name = "idAvaliação";
            this.idAvaliação.ReadOnly = true;
            // 
            // idAluno
            // 
            this.idAluno.HeaderText = "Cód. Aluno";
            this.idAluno.Name = "idAluno";
            this.idAluno.ReadOnly = true;
            // 
            // Aluno
            // 
            this.Aluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Aluno.HeaderText = "Aluno";
            this.Aluno.Name = "Aluno";
            this.Aluno.ReadOnly = true;
            // 
            // dataAvaliação
            // 
            this.dataAvaliação.HeaderText = "Data Avaliação";
            this.dataAvaliação.Name = "dataAvaliação";
            this.dataAvaliação.ReadOnly = true;
            // 
            // ConsultaAvaliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.dataGridViewAvaliacao);
            this.Name = "ConsultaAvaliacao";
            this.Text = "Consulta Avaliação";
            this.Load += new System.EventHandler(this.ConsultaAvaliacao_Load);
            this.Controls.SetChildIndex(this.txtPesquisar, 0);
            this.Controls.SetChildIndex(this.cbInativos, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.dataGridViewAvaliacao, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvaliacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAvaliacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAvaliação;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAvaliação;
    }
}
