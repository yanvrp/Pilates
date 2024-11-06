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
            this.btnVisualizar = new Pilates.YControls.YButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPrograma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCancelamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFinalContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContrato)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.btnPesquisar.Size = new System.Drawing.Size(80, 31);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(705, 439);
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // cbInativos
            // 
            this.cbInativos.Location = new System.Drawing.Point(725, 17);
            this.cbInativos.CheckedChanged += new System.EventHandler(this.cbInativos_CheckedChanged);
            // 
            // dataGridViewContrato
            // 
            this.dataGridViewContrato.AllowUserToAddRows = false;
            this.dataGridViewContrato.AllowUserToDeleteRows = false;
            this.dataGridViewContrato.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dataGridViewContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContrato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.idAluno,
            this.aluno,
            this.idPrograma,
            this.programa,
            this.dataInicio,
            this.dataCancelamento,
            this.dataFinalContrato});
            this.dataGridViewContrato.Location = new System.Drawing.Point(12, 49);
            this.dataGridViewContrato.Name = "dataGridViewContrato";
            this.dataGridViewContrato.ReadOnly = true;
            this.dataGridViewContrato.Size = new System.Drawing.Size(776, 372);
            this.dataGridViewContrato.TabIndex = 7;
            this.dataGridViewContrato.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContrato_CellDoubleClick);
            this.dataGridViewContrato.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewContrato_CellFormatting);
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
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 17);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nome";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(505, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(78, 40);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Por";
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            this.Código.Width = 50;
            // 
            // idAluno
            // 
            this.idAluno.HeaderText = "Cod. Aluno";
            this.idAluno.Name = "idAluno";
            this.idAluno.ReadOnly = true;
            this.idAluno.Width = 50;
            // 
            // aluno
            // 
            this.aluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aluno.HeaderText = "Aluno";
            this.aluno.Name = "aluno";
            this.aluno.ReadOnly = true;
            // 
            // idPrograma
            // 
            this.idPrograma.HeaderText = "Cod. Programa";
            this.idPrograma.Name = "idPrograma";
            this.idPrograma.ReadOnly = true;
            this.idPrograma.Width = 60;
            // 
            // programa
            // 
            this.programa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.programa.HeaderText = "Programa";
            this.programa.Name = "programa";
            this.programa.ReadOnly = true;
            // 
            // dataInicio
            // 
            this.dataInicio.HeaderText = "Data de Inicio";
            this.dataInicio.Name = "dataInicio";
            this.dataInicio.ReadOnly = true;
            // 
            // dataCancelamento
            // 
            this.dataCancelamento.HeaderText = "Data de Cancelamento";
            this.dataCancelamento.Name = "dataCancelamento";
            this.dataCancelamento.ReadOnly = true;
            // 
            // dataFinalContrato
            // 
            this.dataFinalContrato.HeaderText = "Data Final Contrato";
            this.dataFinalContrato.Name = "dataFinalContrato";
            this.dataFinalContrato.ReadOnly = true;
            // 
            // ConsultaContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.groupBox1);
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
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContrato)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewContrato;
        protected YControls.YButton btnVisualizar;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPrograma;
        private System.Windows.Forms.DataGridViewTextBoxColumn programa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCancelamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFinalContrato;
    }
}
