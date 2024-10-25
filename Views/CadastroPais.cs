using Pilates.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Pilates.Models;

namespace Pilates.Views
{
    public partial class CadastroPais : Pilates.Views.CadastroPAI
    {
        private ControllerPais<ModelPais> PaisController;
        public CadastroPais()
        {
            InitializeComponent();
            PaisController = new ControllerPais<ModelPais>();
        }
        public CadastroPais(int idPais) : this()
        {
            Alterar = idPais;
            Carrega();
        }
        public override void Carrega()
        {
            if (Alterar != -7)
            {
                ModelPais pais = PaisController.BuscarPorId(Alterar);
                if (pais != null)
                {//carrega os dados do país
                    txtCodigo.Texts = pais.idPais.ToString();
                    txtPais.Texts = pais.Pais;
                    txtSigla.Texts = pais.Sigla;
                    txtDDI.Texts = pais.DDI;
                    txtDataCadastro.Texts = pais.dataCadastro.ToString();
                    txtDataUltAlt.Texts = pais.dataUltAlt.ToString();
                    rbAtivo.Checked = pais.Ativo;
                    rbInativo.Checked = !pais.Ativo;
                }
                else
                {
                    MessageBox.Show("País não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public override void Salvar()
        {
            if (!Validacoes.CampoObrigatorio(txtPais.Texts))
            {
                MessageBox.Show("Campo País é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPais.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtSigla.Texts))
            {
                MessageBox.Show("Campo Sigla é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSigla.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtDDI.Texts))
            {
                MessageBox.Show("Campo DDI é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDDI.Focus();
            }
            else
            {
                int idAtual = Alterar != -7 ? Alterar : -7;

                if (PaisController.JaCadastrado(txtPais.Texts, idAtual))
                {
                    MessageBox.Show("País já cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPais.Focus();
                }
                else
                {
                    try
                    {
                        string pais = txtPais.Texts;
                        string sigla = txtSigla.Texts;
                        string ddi = txtDDI.Texts;
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

                        ModelPais novoPais = new ModelPais
                        {
                            Pais = pais,
                            Sigla = sigla,
                            DDI = ddi,
                            dataCadastro = dataCadastro,
                            dataUltAlt = dataUltAlt,
                            Ativo = Ativo
                        };

                        if (Alterar == -7)
                        {
                            PaisController.Salvar(novoPais);
                        }
                        else
                        {
                            novoPais.idPais = Alterar; // ID do país alterado
                            PaisController.Alterar(novoPais);
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

        private void CadastroPais_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaPais)this.Owner).AtualizarConsultaPaises(false);
        }

        private void CadastroPais_Load(object sender, EventArgs e)
        {
            if (Alterar == -7)
            {
                int novoCodigo = PaisController.BuscarUltimoCodigo() + 1;
                txtCodigo.Texts = novoCodigo.ToString();
            }
        }

        private void txtPais_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.VerificaLetras(txtPais.Texts))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPais.Focus();
            }
        }

        private void txtSigla_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.VerificaLetrasSemEspaco(txtSigla.Texts))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSigla.Focus();
            }
        }

        private void txtDDI_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.VerificaNumeros(txtDDI.Texts))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDDI.Focus();
            }
        }
    }
}
