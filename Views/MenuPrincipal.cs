using Pilates.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilates
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void paisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaPais consultaPais = new ConsultaPais();
            consultaPais.ShowDialog();
        }

        private void estad0ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaEstado consultaEstado = new ConsultaEstado();
            consultaEstado.ShowDialog();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaCidade consultaCidade = new ConsultaCidade();
            consultaCidade.ShowDialog();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaAluno consultaAluno = new ConsultaAluno();
            consultaAluno.ShowDialog();
        }
        private void posturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ConsultaPostura consultaPostura = new ConsultaPostura();
           // consultaPostura.ShowDialog();
        }

        private void profissãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ConsultaProfissao consultaProfissao = new ConsultaProfissao();
           // consultaProfissao.ShowDialog();
        }

        private void profissãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaProfissao consultaProfissao = new ConsultaProfissao();
            consultaProfissao.ShowDialog();
        }

        private void doençaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaDoenca consultaDoenca = new ConsultaDoenca();
            consultaDoenca.ShowDialog();
        }

        private void medicamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaMedicamento consultaMedicamento = new ConsultaMedicamento();
            consultaMedicamento.ShowDialog();
        }

        private void cirurgiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaCirurgia consultaCirurgia = new ConsultaCirurgia();
            consultaCirurgia.ShowDialog();
        }

        private void gestaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaGestacao consultaGestacao = new ConsultaGestacao();
            consultaGestacao.ShowDialog();
        }

        private void doresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaDores consultaDores = new ConsultaDores();
            consultaDores.ShowDialog();
        }

        private void evoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ConsultaEvolucao consultaEvolucao = new ConsultaEvolucao();
            //consultaEvolucao.ShowDialog();
        }

        private void programaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaPrograma consultaPrograma = new ConsultaPrograma();
            consultaPrograma.ShowDialog();
        }

        private void formaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaFormaPagamento consultaFormaPAgamento = new ConsultaFormaPagamento();
            consultaFormaPAgamento.ShowDialog();
        }

        private void condiçãoDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaCondicaoPagamento consultaCondicaoPagamento = new ConsultaCondicaoPagamento();
            consultaCondicaoPagamento.ShowDialog();
        }

        private void programaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaPrograma consultaPrograma = new ConsultaPrograma();
            consultaPrograma.ShowDialog();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void contratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaContrato consultaContrato = new ConsultaContrato();
            consultaContrato.ShowDialog();
        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaContasReceber consultaContasReceber = new ConsultaContasReceber();
            consultaContasReceber.ShowDialog();
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaContasPagar consultaContasPagar = new ConsultaContasPagar();
            consultaContasPagar.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaFornecedor consultaFornecedor = new ConsultaFornecedor();
            consultaFornecedor.ShowDialog();
        }

        private void avaliaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaAvaliacao consultaAvaliacao = new ConsultaAvaliacao();
            consultaAvaliacao.ShowDialog();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaAgenda consultaAgenda = new ConsultaAgenda();
            consultaAgenda.ShowDialog();
        }
    }
}
