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
    public partial class ConsultaEvolucao : Pilates.ConsultaPAI
    {
        private ControllerEvolucao<ModelEvolucao> controllerEvolucao;
        public int idBusca;
        public ConsultaEvolucao(int BuscaID)
        {
            idBusca = BuscaID;
            InitializeComponent();
            controllerEvolucao = new ControllerEvolucao<ModelEvolucao>();
        }
        public override void Incluir()
        {
            CadastroEvolucao cadastroEvolucao = new CadastroEvolucao(-7, idBusca);
            cadastroEvolucao.Owner = this;
            cadastroEvolucao.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewEvolucao.SelectedRows.Count > 0)
            {
                int idEvolucao = (int)dataGridViewEvolucao.SelectedRows[0].Cells["Código"].Value;
                CadastroEvolucao cadastroEvolucao = new CadastroEvolucao(idEvolucao, idBusca);
                cadastroEvolucao.Owner = this;
                cadastroEvolucao.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma evolução para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public override void Excluir()
        {
            if (dataGridViewEvolucao.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir esta evolução?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idEvolucao = (int)dataGridViewEvolucao.SelectedRows[0].Cells["Código"].Value;
                    controllerEvolucao.Deletar(idEvolucao);
                    dataGridViewEvolucao.DataSource = controllerEvolucao.BuscarTodos(cbInativos.Checked);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma evolução para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    List<ModelEvolucao> resultadosPesquisa = controllerEvolucao.BuscarTodos(cbInativos.Checked).Where(p => p.titulo.ToLower().Contains(pesquisa.ToLower())).ToList();
                    dataGridViewEvolucao.DataSource = resultadosPesquisa; //atualiza o DataSource do DataGridView com os resultados da pesquisa
                    txtPesquisar.Texts = string.Empty; //limpa o txt pesquisa
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar evolução: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaEvolucao(cbInativos.Checked);
            }
        }
        public void AtualizarConsultaEvolucao(bool incluirInativos)
        {
            try
            {
                //recarrega os dados dos evolução na consulta de evoluçoes
                dataGridViewEvolucao.DataSource = controllerEvolucao.BuscarTodos(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de evolução: " + ex.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaEvolucao_Load(object sender, EventArgs e)
        {
            try
            {
                CadastroEvolucao cadastroEvolucao = new CadastroEvolucao(-7, idBusca);
                cadastroEvolucao.FormClosed += (s, args) => AtualizarConsultaEvolucao(cbInativos.Checked); //quando aciona o Form Closed chama o AtualizarConsulta

                dataGridViewEvolucao.AutoGenerateColumns = false;
                dataGridViewEvolucao.Columns["Código"].DataPropertyName = "idEvolucao";
                dataGridViewEvolucao.Columns["Título"].DataPropertyName = "titulo";
                dataGridViewEvolucao.Columns["DataCadastro"].DataPropertyName = "DataCadastro";
                AtualizarConsultaEvolucao(cbInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as evoluções: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbInativos_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbInativos.Checked;
            AtualizarConsultaEvolucao(incluirInativos);
        }

        private void dataGridViewEvolucao_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }
    }
}
