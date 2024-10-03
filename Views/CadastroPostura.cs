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
    public partial class CadastroPostura : Pilates.Views.CadastroPAI
    {
        public int buscaID;
        private ControllerPostura<ModelPostura> controllerPostura;
        private ConsultaAluno consultaAluno;
        private ControllerAluno<ModelAluno> controllerAluno;
        public CadastroPostura()
        {
            InitializeComponent();
            controllerPostura = new ControllerPostura<ModelPostura>();
            consultaAluno = new ConsultaAluno();
            controllerAluno = new ControllerAluno<ModelAluno>();
            txtCodAluno.Text = buscaID.ToString();
            string nomeAluno = controllerPostura.GetNomeAlunoByAlunoID(buscaID);
            if (!string.IsNullOrEmpty(nomeAluno))
            {
                txtAluno.Text = nomeAluno;
            }
        }
        public CadastroPostura(int idPostura, int idBusca) : this()
        {
            Alterar = idPostura;
            buscaID = idBusca;
            txtCodAluno.Text = buscaID.ToString();
            string nomeAluno = controllerPostura.GetNomeAlunoByAlunoID(buscaID);
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
                ModelPostura postura = controllerPostura.BuscarPorId(Alterar);
                if (postura != null)
                {
                    txtCodigo.Text = postura.idPostura.ToString();
                    txtTitulo.Text = postura.titulo.ToString();
                    txtCabeca.Text = postura.cabecaPostura;
                    txtOmbro.Text = postura.ombroPostura;
                    txtEscapula.Text = postura.escapuloPostura;
                    txtMaos.Text = postura.maosPostura;
                    txtCervical.Text = postura.cervicalPostura;
                    txtToracica.Text = postura.toracicaPostura;
                    txtLombar.Text = postura.lombarPostura;
                    txtQuadril.Text = postura.quadrilPostura;
                    txtJoelhos.Text = postura.joelhoPostura;
                    txtPes.Text = postura.pesPostura;
                    txtCodAluno.Text = postura.idAluno.ToString();
                    txtDataCadastro.Text = postura.dataCadastro.ToString();
                    txtDataUltAlt.Text = postura.dataUltAlt.ToString();
                    txtOutros.Text = postura.Outros;
                    rbAtivo.Checked = postura.Ativo;
                    rbInativo.Checked = !postura.Ativo;

                    string nomeAluno = controllerPostura.GetNomeAlunoByPosturaId(postura.idPostura);

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
            if (!Validacoes.CampoObrigatorio(txtCabeca.Text))
            {
                MessageBox.Show("Campo cabeça é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCabeca.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtOmbro.Text))
            {
                MessageBox.Show("Campo ombro é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOmbro.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtEscapula.Text))
            {
                MessageBox.Show("Campo escapula é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEscapula.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtMaos.Text))
            {
                MessageBox.Show("Campo mãos é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaos.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtCervical.Text))
            {
                MessageBox.Show("Campo cervical é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCervical.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtToracica.Text))
            {
                MessageBox.Show("Campo toracica é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtToracica.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtLombar.Text))
            {
                MessageBox.Show("Campo lombar é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLombar.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtQuadril.Text))
            {
                MessageBox.Show("Campo quadril é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuadril.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtJoelhos.Text))
            {
                MessageBox.Show("Campo joelhos é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtJoelhos.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtPes.Text))
            {
                MessageBox.Show("Campo pés País é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPes.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtCodAluno.Text))
            {
                MessageBox.Show("Campo código aluno é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodAluno.Focus();
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
                        string titulo = txtTitulo.Text;
                        string cabeca = txtCabeca.Text;
                        string ombro = txtOmbro.Text;
                        string escapula = txtEscapula.Text;
                        string maos = txtMaos.Text;
                        string cervical = txtCervical.Text;
                        string toracica = txtToracica.Text;
                        string lombar = txtLombar.Text;
                        string quadril = txtQuadril.Text;
                        string joelhos = txtJoelhos.Text;
                        string pes = txtPes.Text;
                        string Outros = txtOutros.Text;
                        int idAluno = int.Parse(txtCodAluno.Text);
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

                        ModelPostura novaPostura = new ModelPostura
                        {
                            titulo = titulo,    
                            cabecaPostura = cabeca,
                            ombroPostura = ombro,
                            escapuloPostura = escapula,
                            maosPostura = maos,
                            cervicalPostura = cervical,
                            toracicaPostura = toracica,
                            lombarPostura = lombar,
                            quadrilPostura = quadril,
                            joelhoPostura = joelhos,
                            pesPostura = pes,
                            idAluno = idAluno,
                            dataCadastro = dataCadastro,
                            dataUltAlt = dataUltAlt,
                            Outros = Outros,
                            Ativo = Ativo
                        };

                        if (Alterar == -7)
                        {
                            controllerPostura.Salvar(novaPostura);
                        }
                        else
                        {
                        novaPostura.idPostura = Alterar;
                        controllerPostura.Alterar(novaPostura);
                    }

                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consultaAluno.btnSair.Text = "Selecionar";

            if (consultaAluno.ShowDialog() == DialogResult.OK)
            {
                // Receber os detalhes do país selecionado
                var alunoDetalhes = consultaAluno.Tag as Tuple<int, string>;
                if (alunoDetalhes != null)
                {
                    int alunoID = alunoDetalhes.Item1;
                    string alunoNome = alunoDetalhes.Item2;

                    // Atualizar o campo txtPais com o nome do país selecionado
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

        private void CadastroPostura_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((CadastroAluno)this.Owner).AtualizarConsultaPostura();
        }
    }
     

    }

