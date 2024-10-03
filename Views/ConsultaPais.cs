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
    public partial class ConsultaPais : Pilates.ConsultaPAI
    {
        private ControllerPais<ModelPais> PaisController;
        public ConsultaPais()
        {
            InitializeComponent();
            PaisController = new ControllerPais<ModelPais>();
        }

        private void ConsultaPais_Load(object sender, EventArgs e)
        {
            try
            {
                CadastroPais cadastroPaises = new CadastroPais();
                cadastroPaises.FormClosed += (s, args) => AtualizarConsultaPaises(cbInativos.Checked); //quando aciona o Form Closed chama o AtualizarConsulta

                dataGridViewPais.AutoGenerateColumns = false;
                dataGridViewPais.Columns["Código"].DataPropertyName = "idPais";
                dataGridViewPais.Columns["País"].DataPropertyName = "Pais";
                dataGridViewPais.Columns["Sigla"].DataPropertyName = "Sigla";
                dataGridViewPais.Columns["DDI"].DataPropertyName = "DDI";

                AtualizarConsultaPaises(cbInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os países: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public override void Incluir()
        {
            CadastroPais CadastroPais = new CadastroPais();
            CadastroPais.Owner = this;
            CadastroPais.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewPais.SelectedRows.Count > 0)
            {
                int idPais = (int)dataGridViewPais.SelectedRows[0].Cells["Código"].Value;
                CadastroPais CadastroPais = new CadastroPais(idPais);
                CadastroPais.Owner = this;
                CadastroPais.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um país para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public override void Excluir()
        {
            if (dataGridViewPais.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir este país?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idPais = (int)dataGridViewPais.SelectedRows[0].Cells["Código"].Value;
                    PaisController.Deletar(idPais);
                    dataGridViewPais.DataSource = PaisController.BuscarTodos(cbInativos.Checked);
                }
            }
            else
            {
                MessageBox.Show("Selecione um país para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    List<ModelPais> resultadosPesquisa = PaisController.BuscarTodos(cbInativos.Checked).Where(p => p.Pais.ToLower().Contains(pesquisa.ToLower())).ToList();
                    dataGridViewPais.DataSource = resultadosPesquisa; //atualiza o DataSource do DataGridView com os resultados da pesquisa
                    txtPesquisar.Text = string.Empty; //limpa o txt pesquisa
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar países: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaPaises(cbInativos.Checked);
            }
        }
        public void AtualizarConsultaPaises(bool incluirInativos)
        {
            try
            {
                //recarrega os dados dos países na consulta de países
                dataGridViewPais.DataSource = PaisController.BuscarTodos(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de países: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbInativos_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbInativos.Checked;
            AtualizarConsultaPaises(incluirInativos);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (btnSair.Text == "Selecionar")
            {
                if (dataGridViewPais.SelectedRows.Count > 0)
                {
                    // Capturar o ID e o nome do país selecionado
                    int paisID = Convert.ToInt32(dataGridViewPais.SelectedRows[0].Cells["Código"].Value);
                    string paisNome = dataGridViewPais.SelectedRows[0].Cells["País"].Value.ToString();

                    // Passar os detalhes do país selecionado de volta para a tela principal
                    this.Tag = new Tuple<int, string>(paisID, paisNome);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um país.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Close();
            }
        }

        private void dataGridViewPais_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idPais = (int)dataGridViewPais.Rows[e.RowIndex].Cells["Código"].Value;
                CadastroPais CadastroPais = new CadastroPais(idPais);
                CadastroPais.Owner = this;
                CadastroPais.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um país para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
