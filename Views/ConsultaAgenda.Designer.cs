namespace Pilates.Views
{
    partial class ConsultaAgenda
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
            this.dataGridViewAgenda = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.cbMostrarCancelados = new System.Windows.Forms.CheckBox();
            this.btnProximo = new Pilates.YControls.YButton();
            this.btnAnterior = new Pilates.YControls.YButton();
            this.lblPaginas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgenda)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIncluir
            // 
            this.btnIncluir.FlatAppearance.BorderSize = 0;
            this.btnIncluir.Location = new System.Drawing.Point(527, 419);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.Location = new System.Drawing.Point(616, 419);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Location = new System.Drawing.Point(12, 426);
            this.btnExcluir.Visible = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.Location = new System.Drawing.Point(416, 15);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(705, 419);
            // 
            // cbInativos
            // 
            this.cbInativos.Location = new System.Drawing.Point(668, 16);
            this.cbInativos.CheckedChanged += new System.EventHandler(this.cbInativos_CheckedChanged);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(12, 16);
            // 
            // dataGridViewAgenda
            // 
            this.dataGridViewAgenda.AllowUserToAddRows = false;
            this.dataGridViewAgenda.AllowUserToDeleteRows = false;
            this.dataGridViewAgenda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dataGridViewAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Data,
            this.Horário,
            this.idAluno,
            this.Aluno,
            this.Situação});
            this.dataGridViewAgenda.Location = new System.Drawing.Point(12, 65);
            this.dataGridViewAgenda.Name = "dataGridViewAgenda";
            this.dataGridViewAgenda.ReadOnly = true;
            this.dataGridViewAgenda.Size = new System.Drawing.Size(776, 336);
            this.dataGridViewAgenda.TabIndex = 12;
            this.dataGridViewAgenda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAgenda_CellDoubleClick);
            this.dataGridViewAgenda.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewAgenda_CellFormatting);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            this.Código.Visible = false;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Horário
            // 
            this.Horário.HeaderText = "Horário";
            this.Horário.Name = "Horário";
            this.Horário.ReadOnly = true;
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
            // Situação
            // 
            this.Situação.HeaderText = "Situação";
            this.Situação.Name = "Situação";
            this.Situação.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(505, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(78, 40);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Por";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Data";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // cbMostrarCancelados
            // 
            this.cbMostrarCancelados.AutoSize = true;
            this.cbMostrarCancelados.Location = new System.Drawing.Point(668, 37);
            this.cbMostrarCancelados.Name = "cbMostrarCancelados";
            this.cbMostrarCancelados.Size = new System.Drawing.Size(120, 17);
            this.cbMostrarCancelados.TabIndex = 16;
            this.cbMostrarCancelados.Text = "Mostrar Cancelados";
            this.cbMostrarCancelados.UseVisualStyleBackColor = true;
            this.cbMostrarCancelados.CheckedChanged += new System.EventHandler(this.cbMostrarCancelados_CheckedChanged);
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.GhostWhite;
            this.btnProximo.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnProximo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btnProximo.BorderRadius = 8;
            this.btnProximo.BorderSize = 1;
            this.btnProximo.FlatAppearance.BorderSize = 0;
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnProximo.Location = new System.Drawing.Point(396, 419);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(83, 31);
            this.btnProximo.TabIndex = 17;
            this.btnProximo.Text = "Próximo >";
            this.btnProximo.TextColor = System.Drawing.Color.DarkViolet;
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.GhostWhite;
            this.btnAnterior.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.btnAnterior.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.btnAnterior.BorderRadius = 8;
            this.btnAnterior.BorderSize = 1;
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnAnterior.Location = new System.Drawing.Point(297, 419);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(83, 31);
            this.btnAnterior.TabIndex = 18;
            this.btnAnterior.Text = "< Anterior";
            this.btnAnterior.TextColor = System.Drawing.Color.DarkViolet;
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.Location = new System.Drawing.Point(12, 410);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(35, 13);
            this.lblPaginas.TabIndex = 19;
            this.lblPaginas.Text = "label1";
            // 
            // ConsultaAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.lblPaginas);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.cbMostrarCancelados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewAgenda);
            this.Name = "ConsultaAgenda";
            this.Text = "Consulta Agenda";
            this.Load += new System.EventHandler(this.ConsultaAgenda_Load);
            this.Controls.SetChildIndex(this.txtPesquisar, 0);
            this.Controls.SetChildIndex(this.cbInativos, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.dataGridViewAgenda, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.cbMostrarCancelados, 0);
            this.Controls.SetChildIndex(this.btnProximo, 0);
            this.Controls.SetChildIndex(this.btnAnterior, 0);
            this.Controls.SetChildIndex(this.lblPaginas, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgenda)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAgenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horário;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situação;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox cbMostrarCancelados;
        protected YControls.YButton btnProximo;
        protected YControls.YButton btnAnterior;
        private System.Windows.Forms.Label lblPaginas;
    }
}
