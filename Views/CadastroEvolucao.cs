using Pilates.Controller;
using Pilates.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Pilates.Views
{
    public partial class CadastroEvolucao : Pilates.Views.CadastroPAI
    {
        public int buscaID;
        private ControllerEvolucao<ModelEvolucao> controllerEvolucao;
        private ConsultaAluno consultaAluno;
        private ControllerAluno<ModelAluno> controllerAluno;
        public CadastroEvolucao()
        {
            InitializeComponent();
            controllerEvolucao = new ControllerEvolucao<ModelEvolucao>();
            consultaAluno = new ConsultaAluno();
            controllerAluno = new ControllerAluno<ModelAluno>();
            txtCodAluno.Texts = buscaID.ToString();
            string nomeAluno = controllerEvolucao.GetNomeAlunoByAlunoID(buscaID);
            if (!string.IsNullOrEmpty(nomeAluno))
            {
                txtAluno.Texts = nomeAluno;
            }
        }
        public CadastroEvolucao(int idEvolucao, int idBusca) : this()
        {
            Alterar = idEvolucao;
            buscaID = idBusca;
            txtCodAluno.Texts = buscaID.ToString();
            string nomeAluno = controllerEvolucao.GetNomeAlunoByAlunoID(buscaID);
            if (!string.IsNullOrEmpty(nomeAluno))
            {
                txtAluno.Texts = nomeAluno;
            }
            Carrega();
        }
        public override void Carrega()
        {
            if (Alterar != -7)
            {
                ModelEvolucao evolucao = controllerEvolucao.BuscarPorId(Alterar);
                if (evolucao != null)
                {
                    txtCodigo.Texts = evolucao.idEvolucao.ToString();
                    txtTitulo.Texts = evolucao.titulo.ToString();
                    txtCodAluno.Texts = evolucao.idAluno.ToString();
                    txtObservacao.Texts = evolucao.observacao;
                    txtDataCadastro.Texts = evolucao.dataCadastro.ToString();
                    txtDataUltAlt.Texts = evolucao.dataUltAlt.ToString();
                    rbAtivo.Checked = evolucao.Ativo;
                    rbInativo.Checked = !evolucao.Ativo;

                    string nomeAluno = controllerEvolucao.GetNomeAlunoByEvolucaoId(evolucao.idEvolucao);

                    if (!string.IsNullOrEmpty(nomeAluno))
                    {
                        txtAluno.Texts = nomeAluno;
                    }
                }
                else
                {
                    MessageBox.Show("Aluno não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public override void Salvar()
        {
            if (!Validacoes.CampoObrigatorio(txtCodAluno.Texts))
            {
                MessageBox.Show("Campo código aluno é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodAluno.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtObservacao.Texts))
            {
                MessageBox.Show("Campo observação é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtObservacao.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtTitulo.Texts))
            {
                MessageBox.Show("Campo titulo é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitulo.Focus();
            }
            else
            {

                try
                {
                    int idAluno = int.Parse(txtCodAluno.Texts);
                    string titulo = txtTitulo.Texts;
                    string observacao = txtObservacao.Texts;
                    DateTime dataCadastro;
                    DateTime dataUltAlt;

                    DateTime.TryParse(txtDataCadastro.Texts, out dataCadastro);

                    if (Alterar != -7)
                    {
                        DateTime.TryParse(DateTime.Now.ToString(), out dataUltAlt);
                    }
                    else
                    {
                        DateTime.TryParse(txtDataUltAlt.Texts, out dataUltAlt);
                    }

                    ModelEvolucao novaEvolucao = new ModelEvolucao
                    {
                        idAluno = idAluno,
                        titulo = titulo,
                        observacao = observacao,
                        dataCadastro = dataCadastro,
                        dataUltAlt = dataUltAlt,
                        Ativo = Ativo
                    };

                    if (Alterar == -7)
                    {
                        controllerEvolucao.Salvar(novaEvolucao);
                    }
                    else
                    {
                        novaEvolucao.idEvolucao = Alterar; // ID da dor alterado
                        controllerEvolucao.Alterar(novaEvolucao);
                    }

                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }

        private void CadastroEvolucao_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((CadastroAluno)this.Owner).AtualizarConsultaEvolucao();
        }
    }
}

