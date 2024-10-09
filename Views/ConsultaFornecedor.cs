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
    public partial class ConsultaFornecedor : Pilates.ConsultaPAI
    {
        private ControllerFornecedor<ModelFornecedor> controllerFornecedor;
        public ConsultaFornecedor()
        {
            InitializeComponent();
            controllerFornecedor = new ControllerFornecedor<ModelFornecedor>();
        }
        public override void Incluir()
        {
            CadastroFornecedor cadastroFornecedor = new CadastroFornecedor();
            cadastroFornecedor.Owner = this;
            cadastroFornecedor.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewFornecedor.SelectedRows.Count > 0)
            {
                int idFornecedor = (int)dataGridViewFornecedor.SelectedRows[0].Cells["Código"].Value;
                CadastroFornecedor cadastroFornecedor = new CadastroFornecedor(idFornecedor);
                cadastroFornecedor.Owner = this;
                cadastroFornecedor.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um Fornecedor para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public override void Excluir()
        {
            if (dataGridViewFornecedor.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir este Fornecedor?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idFornecedor = (int)dataGridViewFornecedor.SelectedRows[0].Cells["Código"].Value;
                    controllerFornecedor.Deletar(idFornecedor);
                    dataGridViewFornecedor.DataSource = controllerFornecedor.BuscarTodos(cbInativos.Checked);
                }
            }
            else
            {
                MessageBox.Show("Selecione um Fornecedor para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    List<ModelFornecedor> resultadosPesquisa = controllerFornecedor.BuscarTodos(cbInativos.Checked).Where(p => p.fornecedor_razao_social.ToLower().Contains(pesquisa.ToLower())).ToList();
                    dataGridViewFornecedor.DataSource = resultadosPesquisa; //atualiza o DataSource do DataGridView com os resultados da pesquisa
                    txtPesquisar.Text = string.Empty; //limpa o txt pesquisa
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar programa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaFornecedores(cbInativos.Checked);
            }
        }
        public void AtualizarConsultaFornecedores(bool incluirInativos)
        {
            try
            {
                //recarrega os dados dos evolução na consulta de evoluçoes
                dataGridViewFornecedor.DataSource = controllerFornecedor.BuscarTodos(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de programa: " + ex.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaFornecedor_Load(object sender, EventArgs e)
        {
            try
            {
                CadastroFornecedor cadastroFornecedor = new CadastroFornecedor();
                cadastroFornecedor.FormClosed += (s, args) => AtualizarConsultaFornecedores(cbInativos.Checked);
                dataGridViewFornecedor.Columns["Código"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewFornecedor.AutoGenerateColumns = false;
                dataGridViewFornecedor.Columns["Código"].DataPropertyName = "idFornecedor";
                dataGridViewFornecedor.Columns["Fornecedor"].DataPropertyName = "fornecedor_razao_social";
                dataGridViewFornecedor.Columns["Tipo"].DataPropertyName = "tipo_pessoa";
                dataGridViewFornecedor.Columns["Celular"].DataPropertyName = "celular";

                AtualizarConsultaFornecedores(cbInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar fornecedores: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewFornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idFornecedor = (int)dataGridViewFornecedor.Rows[e.RowIndex].Cells["Código"].Value;
                CadastroFornecedor cadastroFornecedor = new CadastroFornecedor(idFornecedor);
                cadastroFornecedor.Owner = this;
                cadastroFornecedor.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbInativos_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbInativos.Checked;
            AtualizarConsultaFornecedores(incluirInativos);
        }

        private void dataGridViewFornecedor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewFornecedor.Columns["Celular"].Index && e.Value != null)
            {
                //formata o número de celular
                string celular = e.Value.ToString();
                if (celular.Length == 11)
                {
                    e.Value = string.Format("({0}) {1}-{2}", celular.Substring(0, 2), celular.Substring(2, 5), celular.Substring(7));
                    e.FormattingApplied = true;
                }
            }
            else if (e.ColumnIndex == dataGridViewFornecedor.Columns["Tipo"].Index && e.Value != null)
            {
                //converte o valor bool em uma string "Físico" ou "Jurídico"
                bool tipoPessoa = (bool)e.Value;
                e.Value = tipoPessoa ? "FÍSICO" : "JURÍDICO";
                e.FormattingApplied = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (btnSair.Text == "Selecionar")
            {
                btnSair.Focus();
                if (dataGridViewFornecedor.SelectedRows.Count > 0)
                {
                    int idFornecedor = Convert.ToInt32(dataGridViewFornecedor.SelectedRows[0].Cells["Código"].Value);
                    string nomeFornecedor = dataGridViewFornecedor.SelectedRows[0].Cells["Fornecedor"].Value.ToString();

                    this.Tag = new Tuple<int, string>(idFornecedor, nomeFornecedor);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um fornecedor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Close();
            }
        }
    }
}
