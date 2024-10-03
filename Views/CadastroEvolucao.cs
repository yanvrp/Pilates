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
            txtCodAluno.Text = buscaID.ToString();
            string nomeAluno = controllerEvolucao.GetNomeAlunoByAlunoID(buscaID);
            if (!string.IsNullOrEmpty(nomeAluno))
            {
                txtAluno.Text = nomeAluno;
            }
        }
        public CadastroEvolucao(int idEvolucao, int idBusca) : this()
        {
            Alterar = idEvolucao;
            buscaID = idBusca;
            txtCodAluno.Text = buscaID.ToString();
            string nomeAluno = controllerEvolucao.GetNomeAlunoByAlunoID(buscaID);
            if (!string.IsNullOrEmpty(nomeAluno))
            {
                txtAluno.Text = nomeAluno;
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
                    txtCodigo.Text = evolucao.idEvolucao.ToString();
                    txtTitulo.Text = evolucao.titulo.ToString();
                    txtCodAluno.Text = evolucao.idAluno.ToString();
                    txtObservacao.Text = evolucao.observacao;
                    txtDataCadastro.Text = evolucao.dataCadastro.ToString();
                    txtDataUltAlt.Text = evolucao.dataUltAlt.ToString();
                    rbAtivo.Checked = evolucao.Ativo;
                    rbInativo.Checked = !evolucao.Ativo;

                    string nomeAluno = controllerEvolucao.GetNomeAlunoByEvolucaoId(evolucao.idEvolucao);

                    if (!string.IsNullOrEmpty(nomeAluno))
                    {
                        txtAluno.Text = nomeAluno;
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
            if (!Validacoes.CampoObrigatorio(txtCodAluno.Text))
            {
                MessageBox.Show("Campo código aluno é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodAluno.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtObservacao.Text))
            {
                MessageBox.Show("Campo observação é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtObservacao.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtTitulo.Text))
            {
                MessageBox.Show("Campo titulo é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitulo.Focus();
            }
            else
            {

                try
                {
                    int idAluno = int.Parse(txtCodAluno.Text);
                    string titulo = txtTitulo.Text;
                    string observacao = txtObservacao.Text;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consultaAluno.btnSair.Text = "Selecionar";

            if (consultaAluno.ShowDialog() == DialogResult.OK)
            {
                // Receber os detalhes do aluno selecionado
                var alunoDetalhes = consultaAluno.Tag as Tuple<int, string>;
                if (alunoDetalhes != null)
                {
                    int alunoID = alunoDetalhes.Item1;
                    string alunoNome = alunoDetalhes.Item2;

                    // Atualizar o campo aluno com o nome do país selecionado
                    txtCodAluno.Text = alunoID.ToString();
                    txtAluno.Text = alunoNome;
                }
            }
        }

        private void txtCodAluno_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.VerificaNumeros(txtCodAluno.Text))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodAluno.Focus();
            }
            else
            {
                if (!string.IsNullOrEmpty(txtCodAluno.Text))
                {
                    ModelAluno aluno = controllerAluno.BuscarPorId(int.Parse(txtCodAluno.Text));
                    if (aluno != null)
                    {
                        txtAluno.Text = aluno.Aluno;
                    }
                    else
                    {
                        MessageBox.Show("Aluno(a) não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCodAluno.Focus();
                    }
                }
            }
        }

        private void CadastroEvolucao_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((CadastroAluno)this.Owner).AtualizarConsultaEvolucao();
        }
    }
}

