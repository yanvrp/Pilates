﻿using Pilates.Controller;
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
    public partial class CadastroMedicamento : Pilates.Views.CadastroPAI
    {
        private ControllerMedicamento<ModelMedicamento> MedicamentoController;
        public CadastroMedicamento()
        {
            InitializeComponent();
            MedicamentoController = new ControllerMedicamento<ModelMedicamento>();
        }
        public CadastroMedicamento(int idMedicamento) : this()
        {
            Alterar = idMedicamento;
            Carrega();
        }
        public override void Carrega()
        {
            if (Alterar != -7)
            {
                ModelMedicamento medicamento = MedicamentoController.BuscarPorId(Alterar);
                if (medicamento != null)
                {//carrega os dados do medicamento
                    txtCodigo.Texts = medicamento.idMedicamento.ToString();
                    txtMedicamento.Texts = medicamento.medicamento;
                    txtDescricao.Texts = medicamento.descricao;
                    txtDataCadastro.Texts = medicamento.dataCadastro.ToString();
                    txtDataUltAlt.Texts = medicamento.dataUltAlt.ToString();
                    rbAtivo.Checked = medicamento.Ativo;
                    rbInativo.Checked = !medicamento.Ativo;
                    txtUsuarioUltAlt.Texts = medicamento.usuarioUltAlt;
                }
                else
                {
                    MessageBox.Show("Medicamento não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public override void Salvar()
        {
            if (!Validacoes.CampoObrigatorio(txtMedicamento.Texts))
            {
                MessageBox.Show("Campo medicamento é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMedicamento.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtDescricao.Texts))
            {
                MessageBox.Show("Campo descrição é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescricao.Focus();
            }
            else
            {
                int idAtual = Alterar != -7 ? Alterar : -7;

                if (MedicamentoController.JaCadastrado(txtMedicamento.Texts, idAtual))
                {
                    MessageBox.Show("Medicamento já cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMedicamento.Focus();
                }
                else
                {
                    try
                    {
                        string medicamento = txtMedicamento.Texts;
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

                        ModelMedicamento novoMedicamento = new ModelMedicamento
                        {
                            medicamento = medicamento,
                            descricao = descricao,
                            dataCadastro = dataCadastro,
                            dataUltAlt = dataUltAlt,
                            Ativo = Ativo,
                            usuarioUltAlt = usuario
                        };

                        if (Alterar == -7)
                        {
                            MedicamentoController.Salvar(novoMedicamento);
                        }
                        else
                        {
                            novoMedicamento.idMedicamento = Alterar; // ID da doenca alterado
                            MedicamentoController.Alterar(novoMedicamento);
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

        private void CadastroMedicamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaMedicamento)this.Owner).AtualizarConsultaMedicamentos(false);
        }

        private void CadastroMedicamento_Load(object sender, EventArgs e)
        {
            if (Alterar == -7)
            {
                int novoCodigo = MedicamentoController.BuscarUltimoCodigo() + 1;
                txtCodigo.Texts = novoCodigo.ToString();
            }
        }
    }
}
