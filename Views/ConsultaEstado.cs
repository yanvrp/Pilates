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
    public partial class ConsultaEstado : Pilates.ConsultaPAI
    {
        private ControllerEstado<ModelEstado> controllerEstado; 
        public ConsultaEstado()
        {
            InitializeComponent();
            controllerEstado = new ControllerEstado<ModelEstado>();
        }
        public override void Incluir()
        {
            CadastroEstado cadastroEstados = new CadastroEstado();
            cadastroEstados.Owner = this;
            cadastroEstados.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewEstado.SelectedRows.Count > 0)
            {
                int idEstado = (int)dataGridViewEstado.SelectedRows[0].Cells["Código"].Value;
                CadastroEstado cadastroEstados = new CadastroEstado(idEstado);
                cadastroEstados.Owner = this;
                cadastroEstados.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um estado para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public override void Excluir()
        {
            if (dataGridViewEstado.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir este estado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idEstado = (int)dataGridViewEstado.SelectedRows[0].Cells["Código"].Value;
                    controllerEstado.Deletar(idEstado);
                    dataGridViewEstado.DataSource = controllerEstado.BuscarTodos(cbInativos.Checked);
                }
            }
            else
            {
                MessageBox.Show("Selecione um estado para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public override void Pesquisar()
        {
            string pesquisa = txtPesquisar.Texts.Trim(); //obtem a pesquisa do txt

            //verifica se há um termo de pesquisa
            if (!string.IsNullOrEmpty(pesquisa))
            {
                try
                {
                    //filtra os dados
                    List<ModelEstado> resultadosPesquisa = controllerEstado.BuscarTodos(cbInativos.Checked).Where(p => p.Estado.ToLower().Contains(pesquisa.ToLower())).ToList();
                    dataGridViewEstado.DataSource = resultadosPesquisa; //atualiza o DataSource do DataGridView com os resultados da pesquisa
                    txtPesquisar.Texts = string.Empty; //limpa o txt pesquisa
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar estados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //se não houver nada no txt, atualiza a consulta de estados normalmente
                AtualizarConsultaEstados(cbInativos.Checked);
            }
        }

        //atualizar a consulta de estados
        public void AtualizarConsultaEstados(bool incluirInativos)
        {
            try
            {
                //recarrega os dados dos estados na consulta de estados
                dataGridViewEstado.DataSource = controllerEstado.BuscarTodos(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de estados: " + ex.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaEstado_Load(object sender, EventArgs e)
        {
            try
            {
                CadastroEstado cadastroEstados = new CadastroEstado();
                cadastroEstados.FormClosed += (s, args) => AtualizarConsultaEstados(cbInativos.Checked); //quando aciona o Form Closed chama o AtualizarConsulta

                dataGridViewEstado.AutoGenerateColumns = false;
                dataGridViewEstado.Columns["Código"].DataPropertyName = "idEstado";
                dataGridViewEstado.Columns["Estado"].DataPropertyName = "Estado";
                dataGridViewEstado.Columns["UF"].DataPropertyName = "UF";

                AtualizarConsultaEstados(cbInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os estados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (btnSair.Text == "Selecionar")
            {
                if (dataGridViewEstado.SelectedRows.Count > 0)
                {
                    // Capturar o ID e o nome do estado selecionado
                    int idEstado = Convert.ToInt32(dataGridViewEstado.SelectedRows[0].Cells["Código"].Value);
                    string nomeEstado = dataGridViewEstado.SelectedRows[0].Cells["Estado"].Value.ToString();

                    // Passar os detalhes do estado selecionado de volta para a tela de cadastro cidades
                    this.Tag = new Tuple<int, string>(idEstado, nomeEstado);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um estado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Close();
            }
        }

        private void cbInativos_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbInativos.Checked;
            AtualizarConsultaEstados(incluirInativos);
        }

        private void dataGridViewEstado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idEstado = (int)dataGridViewEstado.Rows[e.RowIndex].Cells["Código"].Value;
                CadastroEstado cadastroEstados = new CadastroEstado(idEstado);
                cadastroEstados.Owner = this;
                cadastroEstados.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um estado para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
