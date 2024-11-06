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

        private List<ModelPostura> posturasTemporarias = new List<ModelPostura>();
        public CadastroPostura()
        {
            InitializeComponent();
            controllerPostura = new ControllerPostura<ModelPostura>();
            consultaAluno = new ConsultaAluno();
            controllerAluno = new ControllerAluno<ModelAluno>();
            txtCodAluno.Texts = buscaID.ToString();
            string nomeAluno = controllerPostura.GetNomeAlunoByAlunoID(buscaID);
            if (!string.IsNullOrEmpty(nomeAluno))
            {
                txtAluno.Texts = nomeAluno;
            }
        }
        public CadastroPostura(int idPostura, int idBusca) : this()
        {
            Alterar = idPostura;
            buscaID = idBusca;
            txtCodAluno.Texts = buscaID.ToString();
            string nomeAluno = controllerPostura.GetNomeAlunoByAlunoID(buscaID);
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
                ModelPostura postura = controllerPostura.BuscarPorId(Alterar);
                if (postura != null)
                {
                    txtCodigo.Texts = postura.idPostura.ToString();
                    txtTitulo.Texts = postura.titulo.ToString();
                    txtCabeca.Texts = postura.cabecaPostura;
                    txtOmbro.Texts = postura.ombroPostura;
                    txtEscapula.Texts = postura.escapuloPostura;
                    txtMaos.Texts = postura.maosPostura;
                    txtCervical.Texts = postura.cervicalPostura;
                    txtToracica.Texts = postura.toracicaPostura;
                    txtLombar.Texts = postura.lombarPostura;
                    txtQuadril.Texts = postura.quadrilPostura;
                    txtJoelhos.Texts = postura.joelhoPostura;
                    txtPes.Texts = postura.pesPostura;
                    txtCodAluno.Texts = postura.idAluno.ToString();
                    txtDataCadastro.Texts = postura.dataCadastro.ToString();
                    txtDataUltAlt.Texts = postura.dataUltAlt.ToString();
                    txtOutros.Texts = postura.Outros;
                    rbAtivo.Checked = postura.Ativo;
                    rbInativo.Checked = !postura.Ativo;
                    txtUsuarioUltAlt.Texts = postura.usuarioUltAlt;

                    string nomeAluno = controllerPostura.GetNomeAlunoByPosturaId(postura.idPostura);

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
            if (!Validacoes.CampoObrigatorio(txtCabeca.Texts))
            {
                MessageBox.Show("Campo cabeça é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCabeca.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtOmbro.Texts))
            {
                MessageBox.Show("Campo ombro é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOmbro.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtEscapula.Texts))
            {
                MessageBox.Show("Campo escapula é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEscapula.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtMaos.Texts))
            {
                MessageBox.Show("Campo mãos é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaos.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtCervical.Texts))
            {
                MessageBox.Show("Campo cervical é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCervical.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtToracica.Texts))
            {
                MessageBox.Show("Campo toracica é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtToracica.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtLombar.Texts))
            {
                MessageBox.Show("Campo lombar é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLombar.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtQuadril.Texts))
            {
                MessageBox.Show("Campo quadril é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuadril.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtJoelhos.Texts))
            {
                MessageBox.Show("Campo joelhos é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtJoelhos.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtPes.Texts))
            {
                MessageBox.Show("Campo pés País é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPes.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtCodAluno.Texts))
            {
                MessageBox.Show("Campo código aluno é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodAluno.Focus();
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
                        string titulo = txtTitulo.Texts;
                        string cabeca = txtCabeca.Texts;
                        string ombro = txtOmbro.Texts;
                        string escapula = txtEscapula.Texts;
                        string maos = txtMaos.Texts;
                        string cervical = txtCervical.Texts;
                        string toracica = txtToracica.Texts;
                        string lombar = txtLombar.Texts;
                        string quadril = txtQuadril.Texts;
                        string joelhos = txtJoelhos.Texts;
                        string pes = txtPes.Texts;
                        string Outros = txtOutros.Texts;
                        int idAluno = int.Parse(txtCodAluno.Texts);
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
                            usuarioUltAlt =usuario,
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

        private void CadastroPostura_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((CadastroAluno)this.Owner).AtualizarConsultaPostura();
        }
    }
     

    }

