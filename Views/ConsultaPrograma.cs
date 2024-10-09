using Pilates.Controller;
using Pilates.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pilates.Views
{
    public partial class ConsultaPrograma : Pilates.ConsultaPAI
    {
        private ControllerPrograma<ModelPrograma> controllerPrograma;
        public ConsultaPrograma()
        {
            InitializeComponent();
            controllerPrograma = new ControllerPrograma<ModelPrograma>();
        }
        public override void Incluir()
        {
            CadastroPrograma cadastroPrograma = new CadastroPrograma();
            cadastroPrograma.Owner = this;
            cadastroPrograma.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewPrograma.SelectedRows.Count > 0)
            {
                int idPrograma = (int)dataGridViewPrograma.SelectedRows[0].Cells["Código"].Value;
                CadastroPrograma CadastroPrograma = new CadastroPrograma(idPrograma);
                CadastroPrograma.Owner = this;
                CadastroPrograma.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um programa para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public override void Excluir()
        {
            if (dataGridViewPrograma.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir este programa?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idPrograma = (int)dataGridViewPrograma.SelectedRows[0].Cells["Código"].Value;
                    controllerPrograma.Deletar(idPrograma);
                    dataGridViewPrograma.DataSource = controllerPrograma.BuscarTodos(cbInativos.Checked);
                }
            }
            else
            {
                MessageBox.Show("Selecione um programa para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public override void Pesquisar()
        {
            string pesquisa = txtPesquisar.Text.Trim(); //obtem a pesquisa do txt

            //verifica se há um termo de pesquisa
            if (!string.IsNullOrEmpty(pesquisa))
            {
                try
                {
                    //filtra os dados dos países
                    List<ModelPrograma> resultadosPesquisa = controllerPrograma.BuscarTodos(cbInativos.Checked).Where(p => p.titulo.ToLower().Contains(pesquisa.ToLower())).ToList();
                    dataGridViewPrograma.DataSource = resultadosPesquisa; //atualiza o DataSource do DataGridView com os resultados da pesquisa
                    txtPesquisar.Text = string.Empty; //limpa o txt pesquisa
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar programa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaProgramas(cbInativos.Checked);
            }
        }
        public void AtualizarConsultaProgramas(bool incluirInativos)
        {
            try
            {
                //recarrega os dados dos evolução na consulta de evoluçoes
                dataGridViewPrograma.DataSource = controllerPrograma.BuscarTodos(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de programa: " + ex.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaPrograma_Load(object sender, EventArgs e)
        {
            try
            {
                CadastroPrograma CadastroPrograma = new CadastroPrograma();
                CadastroPrograma.FormClosed += (s, args) => AtualizarConsultaProgramas(cbInativos.Checked); //quando aciona o Form Closed chama o AtualizarConsulta

                dataGridViewPrograma.AutoGenerateColumns = false;
                dataGridViewPrograma.Columns["Código"].DataPropertyName = "idPrograma";
                dataGridViewPrograma.Columns["Título"].DataPropertyName = "titulo";
                dataGridViewPrograma.Columns["valor"].DataPropertyName = "Valor";
                AtualizarConsultaProgramas(cbInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os programas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbInativos_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbInativos.Checked;
            AtualizarConsultaProgramas(incluirInativos);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (btnSair.Text == "Selecionar")
            {
                if (dataGridViewPrograma.SelectedRows.Count > 0)
                {
                    int idPrograma = Convert.ToInt32(dataGridViewPrograma.SelectedRows[0].Cells["Código"].Value);
                    string Programa = dataGridViewPrograma.SelectedRows[0].Cells["Título"].Value.ToString();
                    decimal valor = Convert.ToDecimal(dataGridViewPrograma.SelectedRows[0].Cells["valor"].Value);
                    ModelPrograma programa = controllerPrograma.BuscarPorId(idPrograma);
                    string tipoPrograma = programa.tipoPrograma;
                    int aulas = programa.numeroAulas;
                    this.Tag = new Tuple<int, string, decimal, string, int>(idPrograma, Programa, valor, tipoPrograma, aulas);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um Programa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Close();
            }
        }

        private void dataGridViewPrograma_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idPrograma = (int)dataGridViewPrograma.Rows[e.RowIndex].Cells["Código"].Value;
                CadastroPrograma cadastroPrograma = new CadastroPrograma(idPrograma);
                cadastroPrograma.Owner = this;
                cadastroPrograma.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um programa para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
