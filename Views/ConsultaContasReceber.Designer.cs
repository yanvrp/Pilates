namespace Pilates.Views
{
    partial class ConsultaContasReceber
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
            this.dataGridViewContasReceber = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRecebimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCancelamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContasReceber)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(12, 481);
            this.btnExcluir.Visible = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(838, 481);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(757, 481);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(919, 480);
            // 
            // dataGridViewContasReceber
            // 
            this.dataGridViewContasReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContasReceber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.idAluno,
            this.aluno,
            this.parcela,
            this.valorParcela,
            this.dataVencimento,
            this.dataRecebimento,
            this.dataCancelamento});
            this.dataGridViewContasReceber.Location = new System.Drawing.Point(12, 39);
            this.dataGridViewContasReceber.Name = "dataGridViewContasReceber";
            this.dataGridViewContasReceber.Size = new System.Drawing.Size(982, 436);
            this.dataGridViewContasReceber.TabIndex = 7;
            this.dataGridViewContasReceber.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContasReceber_CellDoubleClick);
            this.dataGridViewContasReceber.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewContasReceber_CellFormatting);
            // 
            // numero
            // 
            this.numero.HeaderText = "Número";
            this.numero.Name = "numero";
            // 
            // idAluno
            // 
            this.idAluno.HeaderText = "Cód. Aluno";
            this.idAluno.Name = "idAluno";
            // 
            // aluno
            // 
            this.aluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aluno.HeaderText = "Aluno";
            this.aluno.Name = "aluno";
            // 
            // parcela
            // 
            this.parcela.HeaderText = "Parcela";
            this.parcela.Name = "parcela";
            // 
            // valorParcela
            // 
            this.valorParcela.HeaderText = "Valor";
            this.valorParcela.Name = "valorParcela";
            // 
            // dataVencimento
            // 
            this.dataVencimento.HeaderText = "Data Vencimento";
            this.dataVencimento.Name = "dataVencimento";
            // 
            // dataRecebimento
            // 
            this.dataRecebimento.HeaderText = "Data Recebimento";
            this.dataRecebimento.Name = "dataRecebimento";
            // 
            // dataCancelamento
            // 
            this.dataCancelamento.HeaderText = "Data Cancelamento";
            this.dataCancelamento.Name = "dataCancelamento";
            // 
            // ConsultaContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1006, 515);
            this.Controls.Add(this.dataGridViewContasReceber);
            this.Name = "ConsultaContasReceber";
            this.Text = "Consulta Contas a Receber";
            this.Load += new System.EventHandler(this.ConsultaContasReceber_Load);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.txtPesquisar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.cbInativos, 0);
            this.Controls.SetChildIndex(this.dataGridViewContasReceber, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContasReceber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewContasReceber;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRecebimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCancelamento;
    }
}
