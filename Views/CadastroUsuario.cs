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
    public partial class CadastroUsuario : Pilates.Views.CadastroPAI
    {
        private ControllerUsuario<ModelUsuario> usuarioController;
        public CadastroUsuario()
        {
            InitializeComponent();
            usuarioController = new ControllerUsuario<ModelUsuario>();
        }
        public CadastroUsuario(int idUser) : this()
        {
            Alterar = idUser;
            Carrega();
        }
        public override void Carrega()
        {
            base.Carrega();
            if (Alterar != -7)
            {
                ModelUsuario usuario = usuarioController.BuscarPorId(Alterar);
                if (usuario != null)
                {
                    txtCodigo.Texts = usuario.idUsuario.ToString();
                    txtUsuario.Texts = usuario.usuario;
                    // txtSenha.Texts = usuario.senha;
                    txtDataCadastro.Texts = usuario.dataCadastro.ToString();
                    txtDataUltAlt.Texts = usuario.dataUltAlt.ToString();
                    rbAtivo.Checked = usuario.Ativo;
                    rbInativo.Checked = !usuario.Ativo;
                    txtUsuarioUltAlt.Texts = usuario.usuarioUltAlt;
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public override void Salvar()
        {
            if (!Validacoes.CampoObrigatorio(txtUsuario.Texts))
            {
                MessageBox.Show("Campo Usuário é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtSenha.Texts))
            {
                MessageBox.Show("Campo Senha é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
            }
            else
            {
                int idAtual = Alterar != -7 ? Alterar : -7;

                if (usuarioController.JaCadastrado(txtUsuario.Texts, idAtual))
                {
                    MessageBox.Show("Usuário já cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Focus();
                }
                else
                {
                    try
                    {
                        string usuario = txtUsuario.Texts;
                        string senha = txtSenha.Texts;
                        string usuarioUltAlt = Program.usuarioLogado;

                        DateTime.TryParse(txtDataCadastro.Texts, out DateTime dataCadastro);
                        DateTime dataUltAlt = Alterar != -1 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Texts, out DateTime result) ? result : DateTime.MinValue;

                        ModelUsuario novoUser = new ModelUsuario
                        {
                            usuario = usuario,
                            senha = senha,
                            dataCadastro = dataCadastro,
                            dataUltAlt = dataUltAlt,
                            Ativo = Ativo,
                            usuarioUltAlt = usuarioUltAlt
                        };

                        if (Alterar == -7)
                        {
                            usuarioController.Salvar(novoUser);
                        }
                        else
                        {
                            novoUser.idUsuario = Alterar;
                            usuarioController.Alterar(novoUser);
                        }

                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CadastroUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaUsuarios)this.Owner).AtualizarConsultaUsuarios(false);
        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {
            if (Alterar == -7)
            {
                int novoCodigo = usuarioController.GetUltimoCodigo() + 1;
                txtCodigo.Texts = novoCodigo.ToString();
            }
        }
    }
}
