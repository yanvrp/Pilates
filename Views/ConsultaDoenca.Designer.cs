namespace Pilates.Views
{
    partial class ConsultaDoenca
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
            this.dataGridViewDoenca = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doença = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoenca)).BeginInit();
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
            // btnSair
            // 
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dataGridViewDoenca
            // 
            this.dataGridViewDoenca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoenca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Doença,
            this.Descrição});
            this.dataGridViewDoenca.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewDoenca.Name = "dataGridViewDoenca";
            this.dataGridViewDoenca.Size = new System.Drawing.Size(776, 371);
            this.dataGridViewDoenca.TabIndex = 7;
            this.dataGridViewDoenca.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoenca_CellDoubleClick);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // Doença
            // 
            this.Doença.HeaderText = "Doença";
            this.Doença.Name = "Doença";
            this.Doença.Width = 200;
            // 
            // Descrição
            // 
            this.Descrição.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            // 
            // ConsultaDoenca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewDoenca);
            this.Name = "ConsultaDoenca";
            this.Text = "Consulta de Doença";
            this.Load += new System.EventHandler(this.ConsultaDoenca_Load);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.txtPesquisar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.cbInativos, 0);
            this.Controls.SetChildIndex(this.dataGridViewDoenca, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoenca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDoenca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doença;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
    }
}
