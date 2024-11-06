using Pilates.Controller;
using Pilates.DAO;
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
    public partial class ConsultaPostura : Pilates.ConsultaPAI
    {
        private ControllerPostura<ModelPostura> controllerPostura;
        public int idBusca;
        public ConsultaPostura(int BuscaID)
        {
            idBusca = BuscaID;
            InitializeComponent();
            controllerPostura = new ControllerPostura<ModelPostura>();
        }
        public override void Incluir()
        {
            CadastroPostura cadastroPostura = new CadastroPostura(-7, idBusca);
            cadastroPostura.Owner = this;
            cadastroPostura.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewPostura.SelectedRows.Count > 0)
            {
                int idPostura = (int)dataGridViewPostura.SelectedRows[0].Cells["Código"].Value;
                CadastroPostura cadastroPosturas = new CadastroPostura(idPostura, idBusca);
                cadastroPosturas.Owner = this;
                cadastroPosturas.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma postura para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public override void Excluir()
        {
            if (dataGridViewPostura.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir esta postura?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idPostura = (int)dataGridViewPostura.SelectedRows[0].Cells["Código"].Value;
                    controllerPostura.Deletar(idPostura);
                    dataGridViewPostura.DataSource = controllerPostura.BuscarTodos(cbInativos.Checked);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma postura para postura.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    List<ModelPostura> resultadosPesquisa = controllerPostura.BuscarTodos(cbInativos.Checked).Where(p => p.titulo.ToLower().Contains(pesquisa.ToLower())).ToList();
                    dataGridViewPostura.DataSource = resultadosPesquisa; //atualiza o DataSource do DataGridView com os resultados da pesquisa
                    txtPesquisar.Texts = string.Empty; //limpa o txt pesquisa
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar postura: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaPostura(cbInativos.Checked);
            }
        }

        public void AtualizarConsultaPostura(bool incluirInativos)
        {
            try
            {
                //recarrega os dados dos posturas na consulta de posturas
                dataGridViewPostura.DataSource = controllerPostura.BuscarTodos(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de postura: " + ex.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaPostura_Load(object sender, EventArgs e)
        {
            try
            {
                CadastroPostura cadastroPostura = new CadastroPostura();
                cadastroPostura.FormClosed += (s, args) => AtualizarConsultaPostura(cbInativos.Checked); //quando aciona o Form Closed chama o AtualizarConsulta

                dataGridViewPostura.AutoGenerateColumns = false;
                dataGridViewPostura.Columns["Código"].DataPropertyName = "idPostura";
                dataGridViewPostura.Columns["Título"].DataPropertyName = "titulo";
                dataGridViewPostura.Columns["DataCadastro"].DataPropertyName = "DataCadastro";

                dataGridViewPostura.CellFormatting += dataGridViewPostura_CellFormatting;
                AtualizarConsultaPostura(cbInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as posturas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbInativos_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbInativos.Checked;
            AtualizarConsultaPostura(incluirInativos);
        }

        private void dataGridViewPostura_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

        }
    }
}
