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
    public partial class ConsultaDoenca : Pilates.ConsultaPAI
    {
        private ControllerDoenca<ModelDoenca> DoencaController;
        public ConsultaDoenca()
        {
            InitializeComponent();
            DoencaController = new ControllerDoenca<ModelDoenca>();
        }

        private void ConsultaDoenca_Load(object sender, EventArgs e)
        {
            try
            {
                CadastroDoenca cadastroDoenca = new CadastroDoenca();
                cadastroDoenca.FormClosed += (s, args) => AtualizarConsultaDoencas(cbInativos.Checked); //quando aciona o Form Closed chama o AtualizarConsulta

                dataGridViewDoenca.AutoGenerateColumns = false;
                dataGridViewDoenca.Columns["Código"].DataPropertyName = "idDoenca";
                dataGridViewDoenca.Columns["Doença"].DataPropertyName = "doenca";
                dataGridViewDoenca.Columns["Descrição"].DataPropertyName = "descricao";

                AtualizarConsultaDoencas(cbInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as doenças: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public override void Incluir()
        {
            CadastroDoenca CadastroDoenca = new CadastroDoenca();
            CadastroDoenca.Owner = this;
            CadastroDoenca.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewDoenca.SelectedRows.Count > 0)
            {
                int idDoenca = (int)dataGridViewDoenca.SelectedRows[0].Cells["Código"].Value;
                CadastroDoenca CadastroDoenca = new CadastroDoenca(idDoenca);
                CadastroDoenca.Owner = this;
                CadastroDoenca.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma doença para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public override void Excluir()
        {
            if (dataGridViewDoenca.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir esta doença?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idDoenca = (int)dataGridViewDoenca.SelectedRows[0].Cells["Código"].Value;
                    DoencaController.Deletar(idDoenca);
                    dataGridViewDoenca.DataSource = DoencaController.BuscarTodos(cbInativos.Checked);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma doença para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    //filtra os dados das doenças
                    List<ModelDoenca> resultadosPesquisa = DoencaController.BuscarTodos(cbInativos.Checked).Where(p => p.doenca.ToLower().Contains(pesquisa.ToLower())).ToList();
                    dataGridViewDoenca.DataSource = resultadosPesquisa; //atualiza o DataSource do DataGridView com os resultados da pesquisa
                    txtPesquisar.Text = string.Empty; //limpa o txt pesquisa
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar doenças: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaDoencas(cbInativos.Checked);
            }
        }
        public void AtualizarConsultaDoencas(bool incluirInativos)
        {
            try
            {
                //recarrega os dados das doença na consulta de doençass
                dataGridViewDoenca.DataSource = DoencaController.BuscarTodos(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de doenças: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbInativos_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbInativos.Checked;
            AtualizarConsultaDoencas(incluirInativos);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (btnSair.Text == "Selecionar")
            {
                if (dataGridViewDoenca.SelectedRows.Count > 0)
                {
                    // Capturar o ID e o nome da doença selecionado
                    int doencaID = Convert.ToInt32(dataGridViewDoenca.SelectedRows[0].Cells["Código"].Value);
                    string doencaNome = dataGridViewDoenca.SelectedRows[0].Cells["Doença"].Value.ToString();

                    // Passar os detalhes da doença selecionada de volta para a tela principal
                    this.Tag = new Tuple<int, string>(doencaID, doencaNome);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma doença.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Close();
            }
        }

        private void dataGridViewDoenca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idDoenca = (int)dataGridViewDoenca.Rows[e.RowIndex].Cells["Código"].Value;
                CadastroDoenca CadastroDoenca = new CadastroDoenca(idDoenca);
                CadastroDoenca.Owner = this;
                CadastroDoenca.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma doença para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
