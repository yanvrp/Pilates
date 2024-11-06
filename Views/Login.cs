﻿using Pilates.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilates.Views
{
    public partial class Login : Form
    {
        private LoginController loginController;
        public Login()
        {
            InitializeComponent();
            loginController = new LoginController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Texts;
            string senha = txtSenha.Texts;

            string permissao = loginController.ValidarUsuario(usuario, senha);

            if (permissao == "inativo")
            {
                MessageBox.Show("Este usuário está inativo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(permissao))
            {
                Program.usuarioLogado = usuario;
                MenuPrincipal menuPrincipal = new MenuPrincipal();
                this.Hide();
                menuPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Sair do sistema?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
