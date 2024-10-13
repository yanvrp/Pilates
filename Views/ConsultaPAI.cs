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
    public partial class ConsultaPAI : Form
    {
        public ConsultaPAI()
        {
            InitializeComponent();
        }
        public virtual void Incluir() { }
        public virtual void Alterar() { }
        public virtual void Excluir() { }
        public virtual void Pesquisar() { }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Incluir();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConsultaPAI_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
