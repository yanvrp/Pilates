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
    public partial class CadastroGestacao : Pilates.Views.CadastroPAI
    {
        private ControllerGestacao<ModelGestacao> GestacaoController;
        public CadastroGestacao()
        {
            InitializeComponent();
            GestacaoController = new ControllerGestacao<ModelGestacao>();
        }
        public CadastroGestacao(int idGestacao) : this()
        {
            Alterar = idGestacao;
            Carrega();
        }
        public override void Carrega()
        {
            if (Alterar != -7)
            {
                ModelGestacao gestacao = GestacaoController.BuscarPorId(Alterar);
                if (gestacao != null)
                {//carrega os dados da gestacao
                    txtCodigo.Text = gestacao.idGestacao.ToString();
                    txtGestacao.Text = gestacao.gestacao;
                    txtDescricao.Text = gestacao.descricao;
                    txtDataCadastro.Text = gestacao.dataCadastro.ToString();
                    txtDataUltAlt.Text = gestacao.dataUltAlt.ToString();
                    rbAtivo.Checked = gestacao.Ativo;
                    rbInativo.Checked = !gestacao.Ativo;
                }
                else
                {
                    MessageBox.Show("Gestação não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public override void Salvar()
        {
            if (!Validacoes.CampoObrigatorio(txtGestacao.Text))
            {
                MessageBox.Show("Campo gestação é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGestacao.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtDescricao.Text))
            {
                MessageBox.Show("Campo descrição é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescricao.Focus();
            }
            else
            {
                int idAtual = Alterar != -7 ? Alterar : -7;

                if (GestacaoController.JaCadastrado(txtGestacao.Text, idAtual))
                {
                    MessageBox.Show("Gestação já cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtGestacao.Focus();
                }
                else
                {
                    try
                    {
                        string gestacao = txtGestacao.Text;
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

                        ModelGestacao novaGestacao = new ModelGestacao
                        {
                            gestacao = gestacao,
                            descricao = descricao,
                            dataCadastro = dataCadastro,
                            dataUltAlt = dataUltAlt,
                            Ativo = Ativo
                        };

                        if (Alterar == -7)
                        {
                            GestacaoController.Salvar(novaGestacao);
                        }
                        else
                        {
                            novaGestacao.idGestacao = Alterar; // ID da gestacao alterado
                            GestacaoController.Alterar(novaGestacao);
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

        private void CadastroGestacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaGestacao)this.Owner).AtualizarConsultaGestacoes(false);
        }
    }
}
