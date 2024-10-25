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
    public partial class CadastroCirurgia : Pilates.Views.CadastroPAI
    {
        private ControllerCirurgia<ModelCirurgia> CirurgiaController;
        public CadastroCirurgia()
        {
            InitializeComponent();
            CirurgiaController = new ControllerCirurgia<ModelCirurgia>();
        }
        public CadastroCirurgia(int idCirurgia) : this()
        {
            Alterar = idCirurgia;
            Carrega();
        }
        public override void Carrega()
        {
            if (Alterar != -7)
            {
                ModelCirurgia cirurgia = CirurgiaController.BuscarPorId(Alterar);
                if (cirurgia != null)
                {//carrega os dados da cirurgia
                    txtCodigo.Texts = cirurgia.idCirurgia.ToString();
                    txtCirurgia.Texts = cirurgia.cirurgia;
                    txtDescricao.Texts = cirurgia.descricao;
                    txtDataCadastro.Texts = cirurgia.dataCadastro.ToString();
                    txtDataUltAlt.Texts = cirurgia.dataUltAlt.ToString();
                    rbAtivo.Checked = cirurgia.Ativo;
                    rbInativo.Checked = !cirurgia.Ativo;
                }
                else
                {
                    MessageBox.Show("Cirurgia não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public override void Salvar()
        {
            if (!Validacoes.CampoObrigatorio(txtCirurgia.Texts))
            {
                MessageBox.Show("Campo cirurgia é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCirurgia.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtDescricao.Texts))
            {
                MessageBox.Show("Campo descrição é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescricao.Focus();
            }
            else
            {
                int idAtual = Alterar != -7 ? Alterar : -7;

                if (CirurgiaController.JaCadastrado(txtCirurgia.Texts, idAtual))
                {
                    MessageBox.Show("País já cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCirurgia.Focus();
                }
                else
                {
                    try
                    {
                        string cirurgia = txtCirurgia.Texts;
                        string descricao = txtDescricao.Texts;
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

                        ModelCirurgia novaCirurgia = new ModelCirurgia
                        {
                            cirurgia = cirurgia,
                            descricao = descricao,
                            dataCadastro = dataCadastro,
                            dataUltAlt = dataUltAlt,
                            Ativo = Ativo
                        };

                        if (Alterar == -7)
                        {
                            CirurgiaController.Salvar(novaCirurgia);
                        }
                        else
                        {
                            novaCirurgia.idCirurgia = Alterar; // ID da cirurgia alterado
                            CirurgiaController.Alterar(novaCirurgia);
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

        private void CadastroCirurgia_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaCirurgia)this.Owner).AtualizarConsultaCirurgias(false);
        }

        private void CadastroCirurgia_Load(object sender, EventArgs e)
        {
            if (Alterar == -7)
            {
                int novoCodigo = CirurgiaController.BuscarUltimoCodigo() + 1;
                txtCodigo.Texts = novoCodigo.ToString();
            }
        }

        private void txtCirurgia_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.VerificaLetras(txtCirurgia.Texts))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCirurgia.Focus();
            }
        }
    }
}
