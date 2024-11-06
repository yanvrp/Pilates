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
    public partial class CadastroPrograma : Pilates.Views.CadastroPAI
    {
        private ControllerPrograma<ModelPrograma> programaController;
        public CadastroPrograma()
        {
            InitializeComponent();
            programaController = new ControllerPrograma<ModelPrograma>();
        }
        public CadastroPrograma(int idPrograma) : this()
        {
            Alterar = idPrograma;
            Carrega();
        }
        public override void Carrega()
        {
            if (Alterar != -7)
            {
                ModelPrograma programa = programaController.BuscarPorId(Alterar);
                if (programa != null)
                {//carrega os dados da gestacao
                    txtCodigo.Texts = programa.idPrograma.ToString();
                    txtTitulo.Texts = programa.titulo;
                    txtNumAula.Text = programa.numeroAulas.ToString();
                    txtValor.Texts = programa.Valor.ToString();
                    txtTipoPrograma.Text = programa.tipoPrograma;
                    txtDataCadastro.Texts = programa.dataCadastro.ToString();
                    txtDataUltAlt.Texts = programa.dataUltAlt.ToString();
                    rbAtivo.Checked = programa.Ativo;
                    rbInativo.Checked = !programa.Ativo;
                    txtUsuarioUltAlt.Texts = programa.usuarioUltAlt;
                }
                else
                {
                    MessageBox.Show("Programa não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public override void Salvar()
        {
            if (!Validacoes.CampoObrigatorio(txtTitulo.Texts))
            {
                MessageBox.Show("Campo titulo é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitulo.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtNumAula.Text))
            {
                MessageBox.Show("Campo numero de aulas é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumAula.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtValor.Texts))
            {
                MessageBox.Show("Campo valors é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValor.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtTipoPrograma.Text))
            {
                MessageBox.Show("Campo tipo programa é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValor.Focus();
            }
            else
            {
                try
                {
                    string titulo = txtTitulo.Texts;
                    string tipoPrograma = txtTipoPrograma.Text;
                    decimal valor = Convert.ToDecimal(txtValor.Texts);
                    int numeroAulas = Convert.ToInt32(txtNumAula.Text);
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

                    ModelPrograma novoPrograma = new ModelPrograma
                    {
                        titulo = titulo,
                        Valor = valor,
                        tipoPrograma = tipoPrograma,
                        numeroAulas = numeroAulas,
                        dataCadastro = dataCadastro,
                        dataUltAlt = dataUltAlt,
                        Ativo = Ativo,
                        usuarioUltAlt = usuario
                    };

                    if (Alterar == -7)
                    {
                        programaController.Salvar(novoPrograma);
                    }
                    else
                    {
                        novoPrograma.idPrograma = Alterar; // ID da dor alterado
                        programaController.Alterar(novoPrograma);
                    }

                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CadastroPrograma_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaPrograma)this.Owner).AtualizarConsultaProgramas(false);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtValor.Texts))
            {
                try
                {
                    txtValor.Texts = Validacoes.FormataPreco(txtValor.Texts);

                    //verifica se o valor é maior que zero
                    if (decimal.TryParse(txtValor.Texts, out decimal preco) && preco > 0)
                    {
                        //valor é válido e maior que zero
                    }
                    else
                    {
                        MessageBox.Show("O valor deve ser maior que zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtValor.Focus();
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtValor.Focus();
                }
            }
        }

        private void CadastroPrograma_Load(object sender, EventArgs e)
        {
            if (Alterar == -7)
            {
                int novoCodigo = programaController.BuscarUltimoCodigo() + 1;
                txtCodigo.Texts = novoCodigo.ToString();
            }
        }
    }
}
