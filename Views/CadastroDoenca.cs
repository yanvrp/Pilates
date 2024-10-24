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
                    txtCodigo.Text = doenca.idDoenca.ToString();
                    txtDoenca.Text = doenca.doenca;
                    txtCID.Text = doenca.CID;
                    txtDescricao.Text = doenca.descricao;
                    txtDataCadastro.Text = doenca.dataCadastro.ToString();
                    txtDataUltAlt.Text = doenca.dataUltAlt.ToString();
                    rbAtivo.Checked = doenca.Ativo;
                    rbInativo.Checked = !doenca.Ativo;
                }
                else
                {
                    MessageBox.Show("Doença não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public override void Salvar()
        {
            if (!Validacoes.CampoObrigatorio(txtDoenca.Text))
            {
                MessageBox.Show("Campo doença é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDoenca.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtDescricao.Text))
            {
                MessageBox.Show("Campo descrição é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescricao.Focus();
            }
            else
            {
                int idAtual = Alterar != -7 ? Alterar : -7;

                if (DoencaController.JaCadastrado(txtDoenca.Text, idAtual))
                {
                    MessageBox.Show("Doenca já cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDoenca.Focus();
                }
                else
                {
                    try
                    {
                        string doenca = txtDoenca.Text;
                        string CID = txtCID.Text;
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

                        ModelDoenca novaDoenca = new ModelDoenca
                        {
                            doenca = doenca,
                            CID = CID,
                            descricao = descricao,
                            dataCadastro = dataCadastro,
                            dataUltAlt = dataUltAlt,
                            Ativo = Ativo
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
    }
}
