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
                    txtCodigo.Text = profissao.idProfissao.ToString();
                    txtProfissao.Text = profissao.profissao;
                    txtDescricao.Text = profissao.descricao;
                    txtDataCadastro.Text = profissao.dataCadastro.ToString();
                    txtDataUltAlt.Text = profissao.dataUltAlt.ToString();
                    rbAtivo.Checked = profissao.Ativo;
                    rbInativo.Checked = !profissao.Ativo;
                }
                else
                {
                    MessageBox.Show("Profissão não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public override void Salvar()
        {
            if (!Validacoes.CampoObrigatorio(txtProfissao.Text))
            {
                MessageBox.Show("Campo profissão é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProfissao.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtDescricao.Text))
            {
                MessageBox.Show("Campo descrição é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescricao.Focus();
            }
            else
            {
                int idAtual = Alterar != -7 ? Alterar : -7;

                if (ProfissaoController.JaCadastrado(txtProfissao.Text, idAtual))
                {
                    MessageBox.Show("Profissão já cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProfissao.Focus();
                }
                else
                {
                    try
                    {
                        string profissao = txtProfissao.Text;
                        string descricao = txtDescricao.Text;
                        DateTime dataCadastro;
                        DateTime dataUltAlt;

                        DateTime.TryParse(txtDataCadastro.Text, out dataCadastro);

                        if (Alterar != -7)
                        {
                            DateTime.TryParse(DateTime.Now.ToString(), out dataUltAlt);
                        }
                        else
                        {
                            DateTime.TryParse(txtDataUltAlt.Text, out dataUltAlt);
                        }

                        ModelProfissao novaProfissao = new ModelProfissao
                        {
                            profissao = profissao,
                            descricao = descricao,
                            dataCadastro = dataCadastro,
                            dataUltAlt = dataUltAlt,
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
    }
}
