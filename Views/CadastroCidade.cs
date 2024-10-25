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
    public partial class CadastroCidade : Pilates.Views.CadastroPAI
    {
        private ControllerCidade<ModelCidade> cidadeController;
        private ConsultaEstado consultaEstado;
        private ControllerEstado<ModelEstado> estadoController;
        public CadastroCidade()
        {
            InitializeComponent();
            cidadeController = new ControllerCidade<ModelCidade>();
            consultaEstado = new ConsultaEstado();
            estadoController = new ControllerEstado<ModelEstado>();

        }
        public CadastroCidade(int idCidade) : this()
        {
            Alterar = idCidade;
            Carrega();
        }

        public override void Carrega()
        {
            if (Alterar != -7)
            {
                ModelCidade cidade = cidadeController.BuscarPorId(Alterar);
                if (cidade != null)
                {
                    txtCodigo.Texts = cidade.idCidade.ToString();
                    txtCidade.Texts = cidade.Cidade;
                    txtDDD.Texts = cidade.DDD.ToString();
                    txtCodigoEstado.Texts = cidade.idEstado.ToString();
                    txtDataCadastro.Texts = cidade.dataCadastro.ToString();
                    txtDataUltAlt.Texts = cidade.dataUltAlt.ToString();
                    rbAtivo.Checked = cidade.Ativo;
                    rbInativo.Checked = !cidade.Ativo;

                    string nomeEstado = cidadeController.GetNomeEstadoByCidadeId(cidade.idCidade);

                    if (!string.IsNullOrEmpty(nomeEstado))
                    {
                        txtEstado.Texts = nomeEstado;
                    }
                }
                else
                {
                    MessageBox.Show("Cidade não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public override void Salvar()
        {
            if (!Validacoes.CampoObrigatorio(txtCidade.Texts))
            {
                MessageBox.Show("Campo Cidade é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCidade.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtDDD.Texts))
            {
                MessageBox.Show("Campo DDD é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDDD.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtCodigoEstado.Texts))
            {
                MessageBox.Show("Campo Código Estado é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigoEstado.Focus();
            }
            else
            {
                int idAtual = Alterar != -7 ? Alterar : -7;
                if (cidadeController.JaCadastrado(txtCidade.Texts, int.Parse(txtCodigoEstado.Texts), idAtual))
                {
                    MessageBox.Show("Cidade já cadastrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCidade.Focus();
                }
                else
                {

                    try
                    {
                        string cidade = txtCidade.Texts;
                        int DDD = int.Parse(txtDDD.Texts);
                        int idEstado = int.Parse(txtCodigoEstado.Texts);
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

                        ModelCidade novaCidade = new ModelCidade
                        {
                            Cidade = cidade,
                            DDD = DDD,
                            idEstado = idEstado,
                            dataCadastro = dataCadastro,
                            dataUltAlt = dataUltAlt,
                            Ativo = Ativo
                        };

                        if (Alterar == -7)
                        {
                            cidadeController.Salvar(novaCidade);
                        }
                        else
                        {
                            novaCidade.idCidade = Alterar;
                            cidadeController.Alterar(novaCidade);
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

        private void CadastroCidade_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaCidade)this.Owner).AtualizarConsultaCidades(false);
        }

        private void CadastroCidade_Load(object sender, EventArgs e)
        {
            if (Alterar == -7)
            {
                int novoCodigo = cidadeController.BuscarUltimoCodigo() + 1;
                txtCodigo.Texts = novoCodigo.ToString();
            }
        }

        private void btnBuscarEstado_Click(object sender, EventArgs e)
        {
            consultaEstado.btnSair.Text = "Selecionar";

            if (consultaEstado.ShowDialog() == DialogResult.OK)
            {
                // Receber os detalhes do estado selecionado
                var estadoDetalhes = consultaEstado.Tag as Tuple<int, string>;

                if (estadoDetalhes != null)
                {
                    int estadoID = estadoDetalhes.Item1;
                    string estadoNome = estadoDetalhes.Item2;

                    txtCodigoEstado.Texts = estadoID.ToString();
                    txtEstado.Texts = estadoNome;
                }
            }
        }

        private void txtCidade_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.VerificaLetras(txtCidade.Texts))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCidade.Focus();
            }
        }

        private void txtDDD_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.VerificaNumeros(txtDDD.Texts))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDDD.Focus();
            }
        }

        private void txtCodigoEstado_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.VerificaNumeros(txtCodigoEstado.Texts))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigoEstado.Focus();
            }
            else
            {
                if (!string.IsNullOrEmpty(txtCodigoEstado.Texts))
                {
                    ModelEstado estado = estadoController.BuscarPorId(int.Parse(txtCodigoEstado.Texts));
                    if (estado != null)
                    {
                        txtEstado.Texts = estado.Estado;
                    }
                    else
                    {
                        MessageBox.Show("Estado não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCodigoEstado.Focus();
                    }
                }
            }
        }

        private void txtCodigoEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir apenas números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }

}
