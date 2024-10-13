namespace Pilates.Views
{
    partial class ConsultaContrato
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
            this.dataGridViewContrato = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPrograma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCancelamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVisualizar = new Pilates.YControls.YButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContrato)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIncluir
            // 
            this.btnIncluir.FlatAppearance.BorderSize = 0;
            this.btnIncluir.Location = new System.Drawing.Point(527, 439);
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.Location = new System.Drawing.Point(84, 439);
            this.btnAlterar.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Location = new System.Drawing.Point(3, 439);
            this.btnExcluir.Visible = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(705, 439);
            // 
            // dataGridViewContrato
            // 
            this.dataGridViewContrato.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dataGridViewContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContrato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.idAluno,
            this.aluno,
            this.idPrograma,
            this.programa,
            this.dataInicio,
            this.dataCancelamento});
            this.dataGridViewContrato.Location = new System.Drawing.Point(12, 49);
            this.dataGridViewContrato.Name = "dataGridViewContrato";
            this.dataGridViewContrato.Size = new System.Drawing.Size(776, 372);
            this.dataGridViewContrato.TabIndex = 7;
            this.dataGridViewContrato.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContrato_CellDoubleClick);
            this.dataGridViewContrato.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewContrato_CellFormatting);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.Width = 50;
            // 
            // idAluno
            // 
            this.idAluno.HeaderText = "Cod. Aluno";
            this.idAluno.Name = "idAluno";
            this.idAluno.Width = 50;
            // 
            // aluno
            // 
            this.aluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aluno.HeaderText = "Aluno";
            this.aluno.Name = "aluno";
            // 
            // idPrograma
            // 
            this.idPrograma.HeaderText = "Cod. Programa";
            this.idPrograma.Name = "idPrograma";
            this.idPrograma.Width = 50;
            // 
            // programa
            // 
            this.programa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.programa.HeaderText = "Programa";
            this.programa.Name = "programa";
            // 
            // dataInicio
            // 
            this.dataInicio.HeaderText = "Data de Inicio";
            this.dataInicio.Name = "dataInicio";
            // 
            // dataCancelamento
            // 
            this.dataCancelamento.HeaderText = "Data de Cancelamento";
            this.dataCancelamento.Name = "dataCancelamento";
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.BackColor = System.Drawing.Color.DarkViolet;
            this.btnVisualizar.BackgroundColor = System.Drawing.Color.DarkViolet;
            this.btnVisualizar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btnVisualizar.BorderRadius = 8;
            this.btnVisualizar.BorderSize = 1;
            this.btnVisualizar.FlatAppearance.BorderSize = 0;
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.ForeColor = System.Drawing.Color.White;
            this.btnVisualizar.Location = new System.Drawing.Point(616, 439);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(83, 31);
            this.btnVisualizar.TabIndex = 12;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.TextColor = System.Drawing.Color.White;
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // ConsultaContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.dataGridViewContrato);
            this.Name = "ConsultaContrato";
            this.Text = "Consulta de Contrato";
            this.Load += new System.EventHandler(this.ConsultaContrato_Load);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.txtPesquisar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.cbInativos, 0);
            this.Controls.SetChildIndex(this.dataGridViewContrato, 0);
            this.Controls.SetChildIndex(this.btnVisualizar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContrato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPrograma;
        private System.Windows.Forms.DataGridViewTextBoxColumn programa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCancelamento;
        protected YControls.YButton btnVisualizar;
    }
}
