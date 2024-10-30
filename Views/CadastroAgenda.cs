using Pilates.Controller;
using Pilates.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pilates.Views
{
    public partial class CadastroAgenda : Pilates.Views.CadastroPAI
    {
        private ConsultaAluno consultaAluno;
        private ControllerAluno<ModelAluno> controllerAluno;
        public CadastroAgenda()
        {
            InitializeComponent();
        }

        private void CadastroAgenda_Load(object sender, EventArgs e)
        {

        }

        private void txtCodAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodAluno_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodAluno.Texts))
            {
                ModelAluno aluno = controllerAluno.BuscarPorId(int.Parse(txtCodAluno.Texts));
                if (aluno != null)
                {
                    txtAluno.Texts = aluno.Aluno;
                }
                else
                {
                    MessageBox.Show("Aluno não encontrado(a).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodAluno.Focus();
                    txtCodAluno.Clear();
                    txtAluno.Clear();
                }
            }
        }

        private void btnPesquisarAluno_Click(object sender, EventArgs e)
        {
            consultaAluno.btnSair.Text = "Selecionar";

            if (consultaAluno.ShowDialog() == DialogResult.OK)
            {
                var infosAluno = consultaAluno.Tag as Tuple<int, string>;
                if (infosAluno != null)
                {
                    int idAluno = infosAluno.Item1;
                    string Aluno = infosAluno.Item2;

                    txtCodAluno.Texts = idAluno.ToString();
                    txtAluno.Texts = Aluno;
                }
            }
        }
    }
}
