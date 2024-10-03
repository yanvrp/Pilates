namespace Pilates.Views
{
    partial class ConsultaPais
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
            this.components = new System.ComponentModel.Container();
            this.pilates_BemEstarDataSet = new Pilates.pilates_BemEstarDataSet();
            this.paisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paisTableAdapter = new Pilates.pilates_BemEstarDataSetTableAdapters.paisTableAdapter();
            this.dataGridViewPais = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.País = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DDI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pilates_BemEstarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPais)).BeginInit();
            this.SuspendLayout();
            // 
            // cbInativos
            // 
            this.cbInativos.CheckedChanged += new System.EventHandler(this.cbInativos_CheckedChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(563, 464);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(482, 464);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(401, 464);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(644, 464);
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pilates_BemEstarDataSet
            // 
            this.pilates_BemEstarDataSet.DataSetName = "pilates_BemEstarDataSet";
            this.pilates_BemEstarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paisBindingSource
            // 
            this.paisBindingSource.DataMember = "pais";
            this.paisBindingSource.DataSource = this.pilates_BemEstarDataSet;
            // 
            // paisTableAdapter
            // 
            this.paisTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewPais
            // 
            this.dataGridViewPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.País,
            this.Sigla,
            this.DDI});
            this.dataGridViewPais.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewPais.Name = "dataGridViewPais";
            this.dataGridViewPais.Size = new System.Drawing.Size(707, 420);
            this.dataGridViewPais.TabIndex = 7;
            this.dataGridViewPais.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPais_CellDoubleClick);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // País
            // 
            this.País.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.País.HeaderText = "País";
            this.País.Name = "País";
            // 
            // Sigla
            // 
            this.Sigla.HeaderText = "Sigla";
            this.Sigla.Name = "Sigla";
            // 
            // DDI
            // 
            this.DDI.HeaderText = "DDI";
            this.DDI.Name = "DDI";
            // 
            // ConsultaPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(732, 499);
            this.Controls.Add(this.dataGridViewPais);
            this.Name = "ConsultaPais";
            this.Text = "Consulta de País";
            this.Load += new System.EventHandler(this.ConsultaPais_Load);
            this.Controls.SetChildIndex(this.cbInativos, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.txtPesquisar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.dataGridViewPais, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pilates_BemEstarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private pilates_BemEstarDataSet pilates_BemEstarDataSet;
        private System.Windows.Forms.BindingSource paisBindingSource;
        private pilates_BemEstarDataSetTableAdapters.paisTableAdapter paisTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn País;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sigla;
        private System.Windows.Forms.DataGridViewTextBoxColumn DDI;
    }
}
