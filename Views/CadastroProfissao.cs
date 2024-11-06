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
    public partial class CadastroProfissao : Pilates.Views.CadastroPAI
    {
        private ControllerProfissao<ModelProfissao> ProfissaoController;
        public CadastroProfissao()
        {
            InitializeComponent();
            ProfissaoController = new ControllerProfissao<ModelProfissao>();
        }
        public CadastroProfissao(int idProfissao) : this()
        {
            Alterar = idProfissao;
            Carrega();
        }
        public override void Carrega()
        {
            if (Alterar != -7)
            {
                ModelProfissao profissao = ProfissaoController.BuscarPorId(Alterar);
                if (profissao != null)
                {//carrega os dados do país
                    txtCodigo.Texts = profissao.idProfissao.ToString();
                    txtProfissao.Texts = profissao.profissao;
                    txtDescricao.Texts = profissao.descricao;
                    txtDataCadastro.Texts = profissao.dataCadastro.ToString();
                    txtDataUltAlt.Texts = profissao.dataUltAlt.ToString();
                    rbAtivo.Checked = profissao.Ativo;
                    rbInativo.Checked = !profissao.Ativo;
                    txtUsuarioUltAlt.Texts = profissao.usuarioUltAlt;
                }
                else
                {
                    MessageBox.Show("Profissão não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public override void Salvar()
        {
            if (!Validacoes.CampoObrigatorio(txtProfissao.Texts))
            {
                MessageBox.Show("Campo profissão é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProfissao.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtDescricao.Texts))
            {
                MessageBox.Show("Campo descrição é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescricao.Focus();
            }
            else
            {
                int idAtual = Alterar != -7 ? Alterar : -7;

                if (ProfissaoController.JaCadastrado(txtProfissao.Texts, idAtual))
                {
                    MessageBox.Show("Profissão já cadastrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProfissao.Focus();
                }
                else
                {
                    try
                    {
                        string profissao = txtProfissao.Texts;
                        string descricao = txtDescricao.Texts;
                        DateTime dataCadastro;
                        DateTime dataUltAlt;
                        string usuario = Program.usuarioLogado;

                        DateTime.TryParse(txtDataCadastro.Texts, out dataCadastro);

                        if (Alterar != -7)
                        {
                            DateTime.TryParse(DateTime.Now.ToString(), out dataUltAlt);
                        }
                        else
                        {
                            DateTime.TryParse(txtDataUltAlt.Texts, out dataUltAlt);
                        }

                        ModelProfissao novaProfissao = new ModelProfissao
                        {
                            profissao = profissao,
                            descricao = descricao,
                            dataCadastro = dataCadastro,
                            dataUltAlt = dataUltAlt,
                            usuarioUltAlt = usuario,
                            Ativo = Ativo
                        };

                        if (Alterar == -7)
                        {
                            ProfissaoController.Salvar(novaProfissao);
                        }
                        else
                        {
                            novaProfissao.idProfissao = Alterar; // ID da profissao alterado
                            ProfissaoController.Alterar(novaProfissao);
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
        public override void Bloqueia() { }
        public override void Desbloqueia() { }
        public override void LimparCampos() { }

        private void CadastroProfissao_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaProfissao)this.Owner).AtualizarConsultaProfissoes(false);
        }

        private void CadastroProfissao_Load(object sender, EventArgs e)
        {
            if (Alterar == -7)
            {
                int novoCodigo = ProfissaoController.BuscarUltimoCodigo() + 1;
                txtCodigo.Texts = novoCodigo.ToString();
            }
        }

        private void txtProfissao_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.VerificaLetras(txtProfissao.Texts))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProfissao.Focus();
            }
        }
    }
}
