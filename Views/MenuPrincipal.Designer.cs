namespace Pilates
{
    partial class MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profissãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profissãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.doençaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cirurgiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estad0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.condiçãoDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formasDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contratoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.avaliaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAReceberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.planoToolStripMenuItem,
            this.financeiroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.profissãoToolStripMenuItem,
            this.toolStripSeparator1,
            this.cidadeToolStripMenuItem,
            this.estad0ToolStripMenuItem,
            this.paisToolStripMenuItem,
            this.toolStripSeparator2,
            this.condiçãoDePagamentoToolStripMenuItem,
            this.formasDePagamentoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.alunoToolStripMenuItem.Text = "Aluno";
            this.alunoToolStripMenuItem.Click += new System.EventHandler(this.alunoToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            this.fornecedorToolStripMenuItem.Click += new System.EventHandler(this.fornecedorToolStripMenuItem_Click);
            // 
            // profissãoToolStripMenuItem
            // 
            this.profissãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profissãoToolStripMenuItem1,
            this.doençaToolStripMenuItem,
            this.medicamentoToolStripMenuItem,
            this.cirurgiaToolStripMenuItem,
            this.gestaçãoToolStripMenuItem,
            this.doresToolStripMenuItem});
            this.profissãoToolStripMenuItem.Name = "profissãoToolStripMenuItem";
            this.profissãoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.profissãoToolStripMenuItem.Text = "Complicações";
            this.profissãoToolStripMenuItem.Click += new System.EventHandler(this.profissãoToolStripMenuItem_Click);
            // 
            // profissãoToolStripMenuItem1
            // 
            this.profissãoToolStripMenuItem1.Name = "profissãoToolStripMenuItem1";
            this.profissãoToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.profissãoToolStripMenuItem1.Text = "Profissão";
            this.profissãoToolStripMenuItem1.Click += new System.EventHandler(this.profissãoToolStripMenuItem1_Click);
            // 
            // doençaToolStripMenuItem
            // 
            this.doençaToolStripMenuItem.Name = "doençaToolStripMenuItem";
            this.doençaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.doençaToolStripMenuItem.Text = "Doença";
            this.doençaToolStripMenuItem.Click += new System.EventHandler(this.doençaToolStripMenuItem_Click);
            // 
            // medicamentoToolStripMenuItem
            // 
            this.medicamentoToolStripMenuItem.Name = "medicamentoToolStripMenuItem";
            this.medicamentoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.medicamentoToolStripMenuItem.Text = "Medicamento";
            this.medicamentoToolStripMenuItem.Click += new System.EventHandler(this.medicamentoToolStripMenuItem_Click);
            // 
            // cirurgiaToolStripMenuItem
            // 
            this.cirurgiaToolStripMenuItem.Name = "cirurgiaToolStripMenuItem";
            this.cirurgiaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.cirurgiaToolStripMenuItem.Text = "Cirurgia";
            this.cirurgiaToolStripMenuItem.Click += new System.EventHandler(this.cirurgiaToolStripMenuItem_Click);
            // 
            // gestaçãoToolStripMenuItem
            // 
            this.gestaçãoToolStripMenuItem.Name = "gestaçãoToolStripMenuItem";
            this.gestaçãoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.gestaçãoToolStripMenuItem.Text = "Gestação";
            this.gestaçãoToolStripMenuItem.Click += new System.EventHandler(this.gestaçãoToolStripMenuItem_Click);
            // 
            // doresToolStripMenuItem
            // 
            this.doresToolStripMenuItem.Name = "doresToolStripMenuItem";
            this.doresToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.doresToolStripMenuItem.Text = "Dores";
            this.doresToolStripMenuItem.Click += new System.EventHandler(this.doresToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // cidadeToolStripMenuItem
            // 
            this.cidadeToolStripMenuItem.Name = "cidadeToolStripMenuItem";
            this.cidadeToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.cidadeToolStripMenuItem.Text = "Cidade";
            this.cidadeToolStripMenuItem.Click += new System.EventHandler(this.cidadeToolStripMenuItem_Click);
            // 
            // estad0ToolStripMenuItem
            // 
            this.estad0ToolStripMenuItem.Name = "estad0ToolStripMenuItem";
            this.estad0ToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.estad0ToolStripMenuItem.Text = "Estado";
            this.estad0ToolStripMenuItem.Click += new System.EventHandler(this.estad0ToolStripMenuItem_Click);
            // 
            // paisToolStripMenuItem
            // 
            this.paisToolStripMenuItem.Name = "paisToolStripMenuItem";
            this.paisToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.paisToolStripMenuItem.Text = "Pais";
            this.paisToolStripMenuItem.Click += new System.EventHandler(this.paisToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
            // 
            // condiçãoDePagamentoToolStripMenuItem
            // 
            this.condiçãoDePagamentoToolStripMenuItem.Name = "condiçãoDePagamentoToolStripMenuItem";
            this.condiçãoDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.condiçãoDePagamentoToolStripMenuItem.Text = "Condição de Pagamento";
            this.condiçãoDePagamentoToolStripMenuItem.Click += new System.EventHandler(this.condiçãoDePagamentoToolStripMenuItem_Click_1);
            // 
            // formasDePagamentoToolStripMenuItem
            // 
            this.formasDePagamentoToolStripMenuItem.Name = "formasDePagamentoToolStripMenuItem";
            this.formasDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.formasDePagamentoToolStripMenuItem.Text = "Formas de Pagamento";
            this.formasDePagamentoToolStripMenuItem.Click += new System.EventHandler(this.formasDePagamentoToolStripMenuItem_Click);
            // 
            // planoToolStripMenuItem
            // 
            this.planoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avaliaçãoToolStripMenuItem,
            this.agendaToolStripMenuItem,
            this.contratoToolStripMenuItem,
            this.programaToolStripMenuItem1});
            this.planoToolStripMenuItem.Name = "planoToolStripMenuItem";
            this.planoToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.planoToolStripMenuItem.Text = "Plano";
            // 
            // contratoToolStripMenuItem
            // 
            this.contratoToolStripMenuItem.Name = "contratoToolStripMenuItem";
            this.contratoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contratoToolStripMenuItem.Text = "Contrato";
            this.contratoToolStripMenuItem.Click += new System.EventHandler(this.contratoToolStripMenuItem_Click);
            // 
            // programaToolStripMenuItem1
            // 
            this.programaToolStripMenuItem1.Name = "programaToolStripMenuItem1";
            this.programaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.programaToolStripMenuItem1.Text = "Programa";
            this.programaToolStripMenuItem1.Click += new System.EventHandler(this.programaToolStripMenuItem1_Click);
            // 
            // avaliaçãoToolStripMenuItem
            // 
            this.avaliaçãoToolStripMenuItem.Name = "avaliaçãoToolStripMenuItem";
            this.avaliaçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.avaliaçãoToolStripMenuItem.Text = "Avaliação";
            this.avaliaçãoToolStripMenuItem.Click += new System.EventHandler(this.avaliaçãoToolStripMenuItem_Click);
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agendaToolStripMenuItem.Text = "Agenda";
            this.agendaToolStripMenuItem.Click += new System.EventHandler(this.agendaToolStripMenuItem_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contasAPagarToolStripMenuItem,
            this.contasAReceberToolStripMenuItem});
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // contasAReceberToolStripMenuItem
            // 
            this.contasAReceberToolStripMenuItem.Name = "contasAReceberToolStripMenuItem";
            this.contasAReceberToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contasAReceberToolStripMenuItem.Text = "Contas a Receber";
            this.contasAReceberToolStripMenuItem.Click += new System.EventHandler(this.contasAReceberToolStripMenuItem_Click);
            // 
            // contasAPagarToolStripMenuItem
            // 
            this.contasAPagarToolStripMenuItem.Name = "contasAPagarToolStripMenuItem";
            this.contasAPagarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contasAPagarToolStripMenuItem.Text = "Contas a Pagar";
            this.contasAPagarToolStripMenuItem.Click += new System.EventHandler(this.contasAPagarToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estad0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profissãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profissãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem doençaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cirurgiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contratoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAReceberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avaliaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem condiçãoDePagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formasDePagamentoToolStripMenuItem;
    }
}

