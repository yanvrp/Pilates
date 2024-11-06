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
    public partial class CadastroEstado : Pilates.Views.CadastroPAI
    {
        private ControllerEstado<ModelEstado> controllerEstado; 
        private ConsultaPais consultaPais;
        private ControllerPais<ModelPais> controllerPais; 
        public CadastroEstado()
        {
            InitializeComponent();
            controllerEstado = new ControllerEstado<ModelEstado>();
            consultaPais = new ConsultaPais();
            controllerPais = new ControllerPais<ModelPais>();
        }
        public CadastroEstado(int idEstado) : this()
        {
            Alterar = idEstado;
            Carrega();
        }
        public override void Carrega()
        {
            if (Alterar != -7)
            {
                ModelEstado estado = controllerEstado.BuscarPorId(Alterar);
                if (estado != null)
                {
                    txtCodigo.Texts = estado.idEstado.ToString();
                    txtEstado.Texts = estado.Estado;
                    txtUF.Texts = estado.UF;
                    txtCodigoPais.Texts = estado.idPais.ToString();
                    txtDataCadastro.Texts = estado.dataCadastro.ToString();
                    txtDataUltAlt.Texts = estado.dataUltAlt.ToString();
                    rbAtivo.Checked = estado.Ativo;
                    rbInativo.Checked = !estado.Ativo;
                    txtUsuarioUltAlt.Texts = estado.usuarioUltAlt;

                    string nomePais = controllerEstado.GetNomePaisByEstadoId(estado.idEstado);

                    if (!string.IsNullOrEmpty(nomePais))
                    {
                        txtPais.Texts = nomePais;
                    }
                }
                else
                {
                    MessageBox.Show("Estado não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public override void Salvar()
        {
            if (!Validacoes.CampoObrigatorio(txtEstado.Texts))
            {
                MessageBox.Show("Campo Estado é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEstado.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtUF.Texts))
            {
                MessageBox.Show("Campo UF é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUF.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtCodigoPais.Texts))
            {
                MessageBox.Show("Campo Código País é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigoPais.Focus();
            }
            else
            {
                int idAtual = Alterar != -7 ? Alterar : -7;

                if (controllerEstado.JaCadastrado(txtEstado.Texts, idAtual))
                {
                    MessageBox.Show("Estado já cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEstado.Focus();
                }
                else
                {
                    try
                    {
                        string estado = txtEstado.Texts;
                        string UF = txtUF.Texts;
                        int idPais = int.Parse(txtCodigoPais.Texts);
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

                        ModelEstado novoEstado = new ModelEstado
                        {
                            Estado = estado,
                            UF = UF,
                            idPais = idPais,
                            dataCadastro = dataCadastro,
                            dataUltAlt = dataUltAlt,
                            Ativo = Ativo,
                            usuarioUltAlt = usuario,
                        };

                        if (Alterar == -7)
                        {
                            controllerEstado.Salvar(novoEstado);
                        }
                        else
                        {
                            novoEstado.idEstado = Alterar;
                            controllerEstado.Alterar(novoEstado);
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
        private void CadastroEstado_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaEstado)this.Owner).AtualizarConsultaEstados(false);
        }

        private void rbAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CadastroEstado_Load(object sender, EventArgs e)
        {
            if (Alterar == -7)
            {
                int novoCodigo = controllerEstado.BuscarUltimoCodigo() + 1;
                txtCodigo.Texts = novoCodigo.ToString();
            }
        }

        private void btnBuscarPais_Click(object sender, EventArgs e)
        {
            consultaPais.btnSair.Text = "Selecionar";
            consultaPais.cbInativos.Visible = false;

            if (consultaPais.ShowDialog() == DialogResult.OK)
            {
                // Receber os detalhes do país selecionado
                var paisDetalhes = consultaPais.Tag as Tuple<int, string>;
                if (paisDetalhes != null)
                {
                    int paisID = paisDetalhes.Item1;
                    string paisNome = paisDetalhes.Item2;

                    // Atualizar o campo txtPais com o nome do país selecionado
                    txtCodigoPais.Texts = paisID.ToString();
                    txtPais.Texts = paisNome;
                }
            }
        }

        private void txtEstado_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.VerificaLetras(txtEstado.Texts))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEstado.Focus();
            }
        }

        private void txtUF_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.VerificaLetrasSemEspaco(txtUF.Texts))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUF.Focus();
            }
        }

        private void txtCodigoPais_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigoPais.Texts))
            {
                string pais = controllerPais.getPais(int.Parse(txtCodigoPais.Texts));
                if (pais != null)
                {
                    txtPais.Texts = pais;
                }
                else
                {
                    MessageBox.Show("País não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodigoPais.Focus();
                    txtCodigoPais.Clear();
                    txtPais.Clear();
                }
            }
        }

        private void txtCodigoPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir apenas números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
