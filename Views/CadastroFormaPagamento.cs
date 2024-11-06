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
    public partial class CadastroFormaPagamento : Pilates.Views.CadastroPAI
    {
        private ControllerFormaPagamento<ModelFormaPagamento> controllerFormaPagamento;
        public CadastroFormaPagamento()
        {
            controllerFormaPagamento = new ControllerFormaPagamento<ModelFormaPagamento>();
            InitializeComponent();
        }
        public CadastroFormaPagamento(int idFormaPagamento) : this()
        {
            Alterar = idFormaPagamento;
            Carrega();
        }
        public override void Carrega()
        {
            base.Carrega();
            if (Alterar != -7)
            {
                ModelFormaPagamento formaPag = controllerFormaPagamento.BuscarPorId(Alterar);
                if (formaPag != null)
                {
                    txtCodigo.Texts = formaPag.idFormaPagamento.ToString();
                    txtFormaPagamento.Texts = formaPag.formaPagamento;
                    txtDataCadastro.Texts = formaPag.dataCadastro.ToString();
                    txtDataUltAlt.Texts = formaPag.dataUltAlt.ToString();
                    rbAtivo.Checked = formaPag.Ativo;
                    rbInativo.Checked = !formaPag.Ativo;
                    txtUsuarioUltAlt.Texts = formaPag.usuarioUltAlt;
                }
                else
                {
                    MessageBox.Show("Forma de Pagamento não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public override void Salvar()
        {
            if (!Validacoes.CampoObrigatorio(txtFormaPagamento.Texts))
            {
                MessageBox.Show("Campo Forma de Pagamento é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFormaPagamento.Focus();
            }
            else
            {
                int idAtual = Alterar != -7 ? Alterar : -7;

                if (controllerFormaPagamento.JaCadastrado(txtFormaPagamento.Texts, idAtual))
                {
                    MessageBox.Show("Forma de Pagamento já cadastrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFormaPagamento.Focus();
                }
                else
                {
                    try
                    {
                        string formaPagamento = txtFormaPagamento.Texts;
                        DateTime.TryParse(txtDataCadastro.Texts, out DateTime dataCadastro);
                        DateTime dataUltAlt = Alterar != -7 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Texts, out DateTime result) ? result : DateTime.MinValue;
                        string usuario = Program.usuarioLogado;

                        ModelFormaPagamento novaFormaPag = new ModelFormaPagamento
                        {
                            formaPagamento = formaPagamento,
                            dataCadastro = dataCadastro,
                            dataUltAlt = dataUltAlt,
                            Ativo = Ativo,
                            usuarioUltAlt = usuario,
                        };

                        if (Alterar == -7)
                        {
                            controllerFormaPagamento.Salvar(novaFormaPag);
                        }
                        else
                        {
                            novaFormaPag.idFormaPagamento = Alterar;
                            controllerFormaPagamento.Alterar(novaFormaPag);
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

        private void CadastroFormaPagamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaFormaPagamento)this.Owner).AtualizarConsultaFormasPag(false);
        }

        private void CadastroFormaPagamento_Load(object sender, EventArgs e)
        {
            if (Alterar == -7)
            {
                int novoCodigo = controllerFormaPagamento.BuscarUltimoCodigo() + 1;
                txtCodigo.Texts = novoCodigo.ToString();
            }
        }

        private void txtFormaPagamento_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.VerificaLetras(txtFormaPagamento.Texts))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFormaPagamento.Focus();
            }
        }
    }
}
