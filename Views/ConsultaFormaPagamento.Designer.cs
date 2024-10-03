﻿namespace Pilates.Views
{
    partial class ConsultaFormaPagamento
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
            this.dataGridViewFormaPagamento = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormaPagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // cbInativos
            // 
            this.cbInativos.CheckedChanged += new System.EventHandler(this.cbInativos_CheckedChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(405, 415);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(324, 415);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(243, 415);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(486, 415);
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dataGridViewFormaPagamento
            // 
            this.dataGridViewFormaPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFormaPagamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.formaPagamento});
            this.dataGridViewFormaPagamento.Location = new System.Drawing.Point(12, 63);
            this.dataGridViewFormaPagamento.Name = "dataGridViewFormaPagamento";
            this.dataGridViewFormaPagamento.Size = new System.Drawing.Size(549, 323);
            this.dataGridViewFormaPagamento.TabIndex = 7;
            this.dataGridViewFormaPagamento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFormaPagamento_CellDoubleClick);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // formaPagamento
            // 
            this.formaPagamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.formaPagamento.HeaderText = "Forma de Pagamento";
            this.formaPagamento.Name = "formaPagamento";
            // 
            // ConsultaFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.dataGridViewFormaPagamento);
            this.Name = "ConsultaFormaPagamento";
            this.Text = "Consulta Formas de Pagamento";
            this.Load += new System.EventHandler(this.ConsultaFormaPagamento_Load);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.txtPesquisar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.cbInativos, 0);
            this.Controls.SetChildIndex(this.dataGridViewFormaPagamento, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormaPagamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagamento;
    }
}