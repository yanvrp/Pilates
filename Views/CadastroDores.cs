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
    public partial class CadastroDores : Pilates.Views.CadastroPAI
    {
        private ControllerDores<ModelDores> DoresController;
        public CadastroDores()
        {
            InitializeComponent();
            DoresController = new ControllerDores<ModelDores>();
        }
        public CadastroDores(int idDores) : this()
        {
            Alterar = idDores;
            Carrega();
        }
        public override void Carrega()
        {
            if (Alterar != -7)
            {
                ModelDores dores = DoresController.BuscarPorId(Alterar);
                if (dores != null)
                {//carrega os dados da dor
                    txtCodigo.Texts = dores.idDores.ToString();
                    txtDores.Texts = dores.dores;
                    txtDescricao.Texts = dores.descricao;
                    txtDataCadastro.Texts = dores.dataCadastro.ToString();
                    txtDataUltAlt.Texts = dores.dataUltAlt.ToString();
                    rbAtivo.Checked = dores.Ativo;
                    rbInativo.Checked = !dores.Ativo;
                    txtUsuarioUltAlt.Texts = dores.usuarioUltAlt;
                }
                else
                {
                    MessageBox.Show("Dor não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public override void Salvar()
        {
            if (!Validacoes.CampoObrigatorio(txtDores.Texts))
            {
                MessageBox.Show("Campo dores é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDores.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtDescricao.Texts))
            {
                MessageBox.Show("Campo descrição é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescricao.Focus();
            }
            else
            {
                int idAtual = Alterar != -7 ? Alterar : -7;

                if (DoresController.JaCadastrado(txtDores.Texts, idAtual))
                {
                    MessageBox.Show("Dor já cadastrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDores.Focus();
                }
                else
                {
                    try
                    {
                        string dores = txtDores.Texts;
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

                        ModelDores novaDor = new ModelDores
                        {
                            dores = dores,
                            descricao = descricao,
                            dataCadastro = dataCadastro,
                            dataUltAlt = dataUltAlt,
                            usuarioUltAlt = usuario,
                            Ativo = Ativo
                        };

                        if (Alterar == -7)
                        {
                            DoresController.Salvar(novaDor);
                        }
                        else
                        {
                            novaDor.idDores = Alterar; // ID da dor alterado
                            DoresController.Alterar(novaDor);
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

        private void CadastroDores_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaDores)this.Owner).AtualizarConsultaDores(false);
        }

        private void CadastroDores_Load(object sender, EventArgs e)
        {
            if (Alterar == -7)
            {
                int novoCodigo = DoresController.BuscarUltimoCodigo() + 1;
                txtCodigo.Texts = novoCodigo.ToString();
            }
        }
    }
}
