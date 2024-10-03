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
                    txtCodigo.Text = dores.idDores.ToString();
                    txtDores.Text = dores.dores;
                    txtDescricao.Text = dores.descricao;
                    txtDataCadastro.Text = dores.dataCadastro.ToString();
                    txtDataUltAlt.Text = dores.dataUltAlt.ToString();
                    rbAtivo.Checked = dores.Ativo;
                    rbInativo.Checked = !dores.Ativo;
                }
                else
                {
                    MessageBox.Show("Dor não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public override void Salvar()
        {
            if (!Validacoes.CampoObrigatorio(txtDores.Text))
            {
                MessageBox.Show("Campo dores é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDores.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtDescricao.Text))
            {
                MessageBox.Show("Campo descrição é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescricao.Focus();
            }
            else
            {
                int idAtual = Alterar != -7 ? Alterar : -7;

                if (DoresController.JaCadastrado(txtDores.Text, idAtual))
                {
                    MessageBox.Show("Dor já cadastrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDores.Focus();
                }
                else
                {
                    try
                    {
                        string dores = txtDores.Text;
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

                        ModelDores novaDor = new ModelDores
                        {
                            dores = dores,
                            descricao = descricao,
                            dataCadastro = dataCadastro,
                            dataUltAlt = dataUltAlt,
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
    }
}
