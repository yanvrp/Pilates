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
    public partial class ConsultaProfissao : Pilates.ConsultaPAI
    {
        private ControllerProfissao<ModelProfissao> ProfissaoController;
        public ConsultaProfissao()
        {
            InitializeComponent();
            ProfissaoController = new ControllerProfissao<ModelProfissao>();
        }

        private void ConsultaProfissao_Load(object sender, EventArgs e)
        {
            try
            {
                CadastroProfissao cadastroProfissoes = new CadastroProfissao();
                cadastroProfissoes.FormClosed += (s, args) => AtualizarConsultaProfissoes(cbInativos.Checked); //quando aciona o Form Closed chama o AtualizarConsulta

                dataGridViewProfissao.AutoGenerateColumns = false;
                dataGridViewProfissao.Columns["Código"].DataPropertyName = "idProfissao";
                dataGridViewProfissao.Columns["Profissão"].DataPropertyName = "profissao";
                dataGridViewProfissao.Columns["Descrição"].DataPropertyName = "descricao";

                AtualizarConsultaProfissoes(cbInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as profissões: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public override void Incluir()
        {
            CadastroProfissao CadastroProfissao = new CadastroProfissao();
            CadastroProfissao.Owner = this;
            CadastroProfissao.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewProfissao.SelectedRows.Count > 0)
            {
                int idProfissao = (int)dataGridViewProfissao.SelectedRows[0].Cells["Código"].Value;
                CadastroProfissao CadastroProfissao = new CadastroProfissao(idProfissao);
                CadastroProfissao.Owner = this;
                CadastroProfissao.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma profissão para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public override void Excluir()
        {
            if (dataGridViewProfissao.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir esta profissão?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idProfissao = (int)dataGridViewProfissao.SelectedRows[0].Cells["Código"].Value;
                    ProfissaoController.Deletar(idProfissao);
                    dataGridViewProfissao.DataSource = ProfissaoController.BuscarTodos(cbInativos.Checked);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma profissão para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    //filtra os dados dos profissões
                    List<ModelProfissao> resultadosPesquisa = ProfissaoController.BuscarTodos(cbInativos.Checked).Where(p => p.profissao.ToLower().Contains(pesquisa.ToLower())).ToList();
                    dataGridViewProfissao.DataSource = resultadosPesquisa; //atualiza o DataSource do DataGridView com os resultados da pesquisa
                    txtPesquisar.Texts = string.Empty; //limpa o txt pesquisa
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar profissões: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaProfissoes(cbInativos.Checked);
            }
        }
        public void AtualizarConsultaProfissoes(bool incluirInativos)
        {
            try
            {
                //recarrega os dados das profissões na consulta de profissões
                dataGridViewProfissao.DataSource = ProfissaoController.BuscarTodos(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de profissões: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbInativos_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbInativos.Checked;
            AtualizarConsultaProfissoes(incluirInativos);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (btnSair.Text == "Selecionar")
            {
                if (dataGridViewProfissao.SelectedRows.Count > 0)
                {
                    // Capturar o ID e o nome da profissão selecionado
                    int profissaoID = Convert.ToInt32(dataGridViewProfissao.SelectedRows[0].Cells["Código"].Value);
                    string profissaoNome = dataGridViewProfissao.SelectedRows[0].Cells["Profissão"].Value.ToString();

                    // Passar os detalhes da profissão selecionada de volta para a tela principal
                    this.Tag = new Tuple<int, string>(profissaoID, profissaoNome);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma profissão.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Close();
            }
        }

        private void dataGridViewProfissao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idProfissao = (int)dataGridViewProfissao.Rows[e.RowIndex].Cells["Código"].Value;
                CadastroProfissao CadastroProfissao = new CadastroProfissao(idProfissao);
                CadastroProfissao.Owner = this;
                CadastroProfissao.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma profissão para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
