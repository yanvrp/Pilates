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
                    txtCodigo.Text = programa.idPrograma.ToString();
                    txtTitulo.Text = programa.titulo;
                    txtNumAula.Text = programa.numeroAulas.ToString();
                    txtValor.Text = programa.Valor.ToString();
                    txtTipoPrograma.Text = programa.tipoPrograma;
                    txtDataCadastro.Text = programa.dataCadastro.ToString();
                    txtDataUltAlt.Text = programa.dataUltAlt.ToString();
                    rbAtivo.Checked = programa.Ativo;
                    rbInativo.Checked = !programa.Ativo;
                }
                else
                {
                    MessageBox.Show("Programa não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public override void Salvar()
        {
            if (!Validacoes.CampoObrigatorio(txtTitulo.Text))
            {
                MessageBox.Show("Campo titulo é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitulo.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtNumAula.Text))
            {
                MessageBox.Show("Campo numero de aulas é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumAula.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtValor.Text))
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
                    string titulo = txtTitulo.Text;
                    string tipoPrograma = txtTipoPrograma.Text;
                    decimal valor = Convert.ToDecimal(txtValor.Text);
                    int numeroAulas = Convert.ToInt32(txtNumAula.Text);
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

                    ModelPrograma novoPrograma = new ModelPrograma
                    {
                        titulo = titulo,
                        Valor = valor,
                        tipoPrograma = tipoPrograma,
                        numeroAulas = numeroAulas,
                        dataCadastro = dataCadastro,
                        dataUltAlt = dataUltAlt,
                        Ativo = Ativo
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
    }
}
