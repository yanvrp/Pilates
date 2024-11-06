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
    public partial class ConsultaUsuarios : Pilates.ConsultaPAI
    {
        private ControllerUsuario<ModelUsuario> controllerUsuario;
        public ConsultaUsuarios()
        {
            InitializeComponent();
            controllerUsuario = new ControllerUsuario<ModelUsuario>();
        }
        public override void Incluir()
        {
            CadastroUsuario cadastroUsuario = new CadastroUsuario();
            cadastroUsuario.Owner = this;
            cadastroUsuario.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                int id = (int)dataGridViewUsuarios.SelectedRows[0].Cells["Código"].Value;
                CadastroUsuario cadastroUsuario = new CadastroUsuario(id);
                cadastroUsuario.Owner = this;
                cadastroUsuario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um usuário para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public override void Excluir()
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir este usuário?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idPais = (int)dataGridViewUsuarios.SelectedRows[0].Cells["Código"].Value;
                    controllerUsuario.Deletar(idPais);
                    dataGridViewUsuarios.DataSource = controllerUsuario.BuscarTodos(cbInativos.Checked);
                }
            }
            else
            {
                MessageBox.Show("Selecione um usuário para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    //filtra os dados dos países
                    List<ModelUsuario> resultadosPesquisa = controllerUsuario.BuscarTodos(cbInativos.Checked).Where(p => p.usuario.ToLower().Contains(pesquisa.ToLower())).ToList();
                    dataGridViewUsuarios.DataSource = resultadosPesquisa; //atualiza o DataSource do DataGridView com os resultados da pesquisa
                    txtPesquisar.Texts = string.Empty; //limpa o txt pesquisa
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar usuários: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaUsuarios(cbInativos.Checked);
            }
        }
        public void AtualizarConsultaUsuarios(bool incluirInativos)
        {
            try
            {
                dataGridViewUsuarios.DataSource = controllerUsuario.BuscarTodos(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de usuários: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                CadastroUsuario cadastroUsuario = new CadastroUsuario();
                cadastroUsuario.FormClosed += (s, args) => AtualizarConsultaUsuarios(cbInativos.Checked); //quando aciona o Form Closed chama o AtualizarConsulta

                dataGridViewUsuarios.AutoGenerateColumns = false;
                dataGridViewUsuarios.Columns["Código"].DataPropertyName = "idUsuario";
                dataGridViewUsuarios.Columns["usuario"].DataPropertyName = "usuario";

                AtualizarConsultaUsuarios(cbInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os usuários: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbInativos_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbInativos.Checked;
            AtualizarConsultaUsuarios(incluirInativos);
        }

        private void dataGridViewUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int id = (int)dataGridViewUsuarios.Rows[e.RowIndex].Cells["Código"].Value;
                CadastroUsuario cadastroUsuario = new CadastroUsuario(id);
                cadastroUsuario.Owner = this;
                cadastroUsuario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um usuário para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
