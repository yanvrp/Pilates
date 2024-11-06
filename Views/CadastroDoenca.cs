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
    public partial class CadastroDoenca : Pilates.Views.CadastroPAI
    {
        private ControllerDoenca<ModelDoenca> DoencaController;
        public CadastroDoenca()
        {
            InitializeComponent();
            DoencaController = new ControllerDoenca<ModelDoenca>();
        }
        public CadastroDoenca(int idDoenca) : this()
        {
            Alterar = idDoenca;
            Carrega();
        }
        public override void Carrega()
        {
            if (Alterar != -7)
            {
                ModelDoenca doenca = DoencaController.BuscarPorId(Alterar);
                if (doenca != null)
                {//carrega os dados da doença
                    txtCodigo.Texts = doenca.idDoenca.ToString();
                    txtDoenca.Texts = doenca.doenca;
                    txtCID.Texts = doenca.CID;
                    txtDescricao.Texts = doenca.descricao;
                    txtDataCadastro.Texts = doenca.dataCadastro.ToString();
                    txtDataUltAlt.Texts = doenca.dataUltAlt.ToString();
                    rbAtivo.Checked = doenca.Ativo;
                    rbInativo.Checked = !doenca.Ativo;
                    txtUsuarioUltAlt.Texts = doenca.usuarioUltAlt;
                }
                else
                {
                    MessageBox.Show("Doença não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public override void Salvar()
        {
            if (!Validacoes.CampoObrigatorio(txtDoenca.Texts))
            {
                MessageBox.Show("Campo doença é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDoenca.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtDescricao.Texts))
            {
                MessageBox.Show("Campo descrição é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescricao.Focus();
            }
            else
            {
                int idAtual = Alterar != -7 ? Alterar : -7;

                if (DoencaController.JaCadastrado(txtDoenca.Texts, idAtual))
                {
                    MessageBox.Show("Doenca já cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDoenca.Focus();
                }
                else
                {
                    try
                    {
                        string doenca = txtDoenca.Texts;
                        string CID = txtCID.Texts;
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

                        ModelDoenca novaDoenca = new ModelDoenca
                        {
                            doenca = doenca,
                            CID = CID,
                            descricao = descricao,
                            dataCadastro = dataCadastro,
                            dataUltAlt = dataUltAlt,
                            Ativo = Ativo,
                            usuarioUltAlt = usuario,
                        };

                        if (Alterar == -7)
                        {
                            DoencaController.Salvar(novaDoenca);
                        }
                        else
                        {
                            novaDoenca.idDoenca = Alterar; // ID da doenca alterado
                            DoencaController.Alterar(novaDoenca);
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

        private void CadastroDoenca_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaDoenca)this.Owner).AtualizarConsultaDoencas(false);
        }

        private void CadastroDoenca_Load(object sender, EventArgs e)
        {
            if (Alterar == -7)
            {
                int novoCodigo = DoencaController.BuscarUltimoCodigo() + 1;
                txtCodigo.Texts = novoCodigo.ToString();
            }
        }
    }
}

