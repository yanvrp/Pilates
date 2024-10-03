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
    public partial class ConsultaMedicamento : Pilates.ConsultaPAI
    {
        private ControllerMedicamento<ModelMedicamento> MedicamentoController;
        public ConsultaMedicamento()
        {
            InitializeComponent();
            MedicamentoController = new ControllerMedicamento<ModelMedicamento>();
        }

        private void ConsultaMedicamento_Load(object sender, EventArgs e)
        {
            try
            {
                CadastroMedicamento cadastroMedicamento = new CadastroMedicamento();
                cadastroMedicamento.FormClosed += (s, args) => AtualizarConsultaMedicamentos(cbInativos.Checked); //quando aciona o Form Closed chama o AtualizarConsulta

                dataGridViewMedicamento.AutoGenerateColumns = false;
                dataGridViewMedicamento.Columns["Código"].DataPropertyName = "idMedicamento";
                dataGridViewMedicamento.Columns["Medicamento"].DataPropertyName = "medicamento";
                dataGridViewMedicamento.Columns["Descrição"].DataPropertyName = "descricao";

                AtualizarConsultaMedicamentos(cbInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os medicamentos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public override void Incluir()
        {
            CadastroMedicamento CadastroMedicamento = new CadastroMedicamento();
            CadastroMedicamento.Owner = this;
            CadastroMedicamento.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewMedicamento.SelectedRows.Count > 0)
            {
                int idMedicamento = (int)dataGridViewMedicamento.SelectedRows[0].Cells["Código"].Value;
                CadastroMedicamento CadastroMedicamento = new CadastroMedicamento(idMedicamento);
                CadastroMedicamento.Owner = this;
                CadastroMedicamento.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um medicamento para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public override void Excluir()
        {
            if (dataGridViewMedicamento.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir este medicamento?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idMedicamento = (int)dataGridViewMedicamento.SelectedRows[0].Cells["Código"].Value;
                    MedicamentoController.Deletar(idMedicamento);
                    dataGridViewMedicamento.DataSource = MedicamentoController.BuscarTodos(cbInativos.Checked);
                }
            }
            else
            {
                MessageBox.Show("Selecione um medicamento para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    List<ModelMedicamento> resultadosPesquisa = MedicamentoController.BuscarTodos(cbInativos.Checked).Where(p => p.medicamento.ToLower().Contains(pesquisa.ToLower())).ToList();
                    dataGridViewMedicamento.DataSource = resultadosPesquisa; //atualiza o DataSource do DataGridView com os resultados da pesquisa
                    txtPesquisar.Text = string.Empty; //limpa o txt pesquisa
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar medicamentos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaMedicamentos(cbInativos.Checked);
            }
        }
        public void AtualizarConsultaMedicamentos(bool incluirInativos)
        {
            try
            {
                //recarrega os dados das doença na consulta de medicamentos
                dataGridViewMedicamento.DataSource = MedicamentoController.BuscarTodos(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de medicamentos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbInativos_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbInativos.Checked;
            AtualizarConsultaMedicamentos(incluirInativos);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (btnSair.Text == "Selecionar")
            {
                if (dataGridViewMedicamento.SelectedRows.Count > 0)
                {
                    // Capturar o ID e o nome do medicamento selecionado
                    int medicamentoID = Convert.ToInt32(dataGridViewMedicamento.SelectedRows[0].Cells["Código"].Value);
                    string medicamentoNome = dataGridViewMedicamento.SelectedRows[0].Cells["Medicamento"].Value.ToString();

                    // Passar os detalhes do medicamento selecionada de volta para a tela principal
                    this.Tag = new Tuple<int, string>(medicamentoID, medicamentoNome);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um medicamento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Close();
            }
        }

        private void dataGridViewMedicamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idMedicamento = (int)dataGridViewMedicamento.Rows[e.RowIndex].Cells["Código"].Value;
                CadastroMedicamento CadastroMedicamento = new CadastroMedicamento(idMedicamento);
                CadastroMedicamento.Owner = this;
                CadastroMedicamento.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um medicamento para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
