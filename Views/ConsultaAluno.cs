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
    public partial class ConsultaAluno : Pilates.ConsultaPAI
    {
        private ControllerAluno<ModelAluno> alunoController;
        
        public ConsultaAluno()
        {
            InitializeComponent();
            alunoController = new ControllerAluno<ModelAluno>();
        }
        public override void Incluir()
        {
            CadastroAluno cadastroAlunos = new CadastroAluno();
            cadastroAlunos.Owner = this;
            cadastroAlunos.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewAlunos.SelectedRows.Count > 0)
            {
                int idAluno = (int)dataGridViewAlunos.SelectedRows[0].Cells["Código"].Value;
                CadastroAluno cadastroAlunos = new CadastroAluno(idAluno);
                cadastroAlunos.Owner = this;
                cadastroAlunos.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um(a) aluno(a) para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public override void Excluir()
        {
            if (dataGridViewAlunos.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir este(a) aluno(a)?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idAluno = (int)dataGridViewAlunos.SelectedRows[0].Cells["Código"].Value;
                    alunoController.Deletar(idAluno);
                    dataGridViewAlunos.DataSource = alunoController.BuscarTodos(cbInativos.Checked);
                }
            }
            else
            {
                MessageBox.Show("Selecione um(a) aluno(a) para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    //filtra os dados
                    List<ModelAluno> resultadosPesquisa = alunoController.BuscarTodos(cbInativos.Checked).Where(p => p.Aluno.ToLower().Contains(pesquisa.ToLower())).ToList();
                    dataGridViewAlunos.DataSource = resultadosPesquisa; //atualiza o DataSource do DataGridView com os resultados da pesquisa
                    txtPesquisar.Text = string.Empty; //limpa o txt pesquisa
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar alunos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //se não houver nada no txt, atualiza a consulta de alunos normalmente
                AtualizarConsultaAlunos(cbInativos.Checked);
            }
        }
        public void AtualizarConsultaAlunos(bool incluirInativos)
        {
            try
            {
                //recarrega os dados das alunos na consulta 
                dataGridViewAlunos.DataSource = alunoController.BuscarTodos(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de alunos: " + ex.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaAluno_Load(object sender, EventArgs e)
        {
            try
            {
                CadastroAluno cadastroAlunos = new CadastroAluno();
                cadastroAlunos.FormClosed += (s, args) => AtualizarConsultaAlunos(cbInativos.Checked); //quando aciona o Form Closed chama o AtualizarConsult
                dataGridViewAlunos.AutoGenerateColumns = false;
                dataGridViewAlunos.Columns["Código"].DataPropertyName = "idAluno";
                dataGridViewAlunos.Columns["Aluno"].DataPropertyName = "Aluno";
                dataGridViewAlunos.Columns["Celular"].DataPropertyName = "celular";
                dataGridViewAlunos.Columns["CPF"].DataPropertyName = "cpf";
                AtualizarConsultaAlunos(cbInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os alunos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbInativos_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbInativos.Checked;
            AtualizarConsultaAlunos(incluirInativos);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (btnSair.Text == "Selecionar")
            {
                if (dataGridViewAlunos.SelectedRows.Count > 0)
                {
                    int idAluno = Convert.ToInt32(dataGridViewAlunos.SelectedRows[0].Cells["Código"].Value);
                    string nomeAluno = dataGridViewAlunos.SelectedRows[0].Cells["Aluno"].Value.ToString();
                    this.Tag = new Tuple<int, string>(idAluno, nomeAluno);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um(a) aluno(a).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Close();
            }
        }

        private void dataGridViewAlunos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idAluno = (int)dataGridViewAlunos.Rows[e.RowIndex].Cells["Código"].Value;
                CadastroAluno cadastroAlunos = new CadastroAluno(idAluno);
                cadastroAlunos.Owner = this;
                cadastroAlunos.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um(a) aluno(a) para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
