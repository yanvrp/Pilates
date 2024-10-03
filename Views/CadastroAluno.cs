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
    public partial class CadastroAluno : Pilates.Views.CadastroPAI
    {
        private ControllerAluno<ModelAluno> alunoController;
        private ConsultaCidade consultaCidade;
        private ControllerPostura<ModelPostura> posturaController;
        private CadastroPostura cadastroPostura;
        private ControllerEvolucao<ModelEvolucao> evolucaoController;
        private CadastroEvolucao cadastroEvolucao;
        public int idBusca;
        public CadastroAluno()
        {
            InitializeComponent();
            posturaController = new ControllerPostura<ModelPostura>();
            alunoController = new ControllerAluno<ModelAluno>();
            consultaCidade = new ConsultaCidade();
            evolucaoController = new ControllerEvolucao<ModelEvolucao>();
            idBusca = int.Parse(txtCodigo.Text);
        }
        public CadastroAluno(int idAluno) : this()
        {
            Alterar = idAluno;
            Carrega();
        }
        public override void Carrega()
        {
            if (Alterar != -7)
            {
                ModelAluno aluno = alunoController.BuscarPorId(Alterar);
                if (aluno != null)
                {
                    txtCodigo.Text = aluno.idAluno.ToString();
                    txtNome.Text = aluno.Aluno;
                    txtApelido.Text = aluno.Apelido;
                    txtEndereco.Text = aluno.endereco;
                    txtBairro.Text = aluno.bairro;
                    txtNumero.Text = aluno.numero.ToString();
                    txtCEP.Text = aluno.cep;
                    txtComplemento.Text = aluno.complemento;
                    txtCodCidade.Text = aluno.idCidade.ToString();
                    txtSexo.Text = aluno.sexo;
                    txtEmail.Text = aluno.email;
                    txtCelular.Text = aluno.celular;
                    txtCPF.Text = aluno.cpf;
                    txtDataNasc.Text = aluno.dataNasc.ToString();
                    txtDataCadastro.Text = aluno.dataCadastro.ToString();
                    txtDataUltAlt.Text = aluno.dataUltAlt.ToString();
                    rbAtivo.Checked = aluno.Ativo;
                    rbInativo.Checked = !aluno.Ativo;
                    List<string> cep = alunoController.GetCEPByCidadeId(aluno.idCidade);
                    if (cep.Count > 0)
                    {
                        string[] info = cep[0].Split(',');
                        if (info.Length >= 3)
                        {
                            txtCidade.Text = info[0].Trim();
                            txtUF.Text = info[1].Trim();
                            txtPais.Text = info[2].Trim();
                        }
                    }
                    exibirPosturasDGV(aluno.Posturas);
                    exibirEvolucoesDGV(aluno.Evolucoes);
                }
                else
                {
                    MessageBox.Show("Aluno(a) não encontrado(a).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                idBusca = int.Parse(txtCodigo.Text);
            }
        }
        protected bool VerificaCamposObrigatorios()
        {
            string cpf = new string(txtCPF.Text.Where(char.IsDigit).ToArray());
            string pais = txtPais.Text.ToLower();
            if (pais == "brasil")
            {
                if (!Validacoes.CampoObrigatorio(cpf))
                {
                    MessageBox.Show("CPF obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCPF.Focus();
                    return false;
                }
            }
            if (!Validacoes.CampoObrigatorio(txtNome.Text))
            {
                MessageBox.Show("Campo Nome é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return false;
            }
            string celular = new string(txtCelular.Text.Where(char.IsDigit).ToArray());
            if (!Validacoes.CampoObrigatorio(celular))
            {
                MessageBox.Show("Campo Celular é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCelular.Focus();
                return false;
            }
            if (!Validacoes.CampoObrigatorio(txtEmail.Text))
            {
                MessageBox.Show("Campo Email é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }
            string cep = new string(txtCEP.Text.Where(char.IsDigit).ToArray());
            if (!Validacoes.CampoObrigatorio(cep))
            {
                MessageBox.Show("Campo CEP é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCEP.Focus();
                return false;
            }
            if (!Validacoes.CampoObrigatorio(txtEndereco.Text))
            {
                MessageBox.Show("Campo Endereço é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEndereco.Focus();
                return false;
            }
            if (!Validacoes.CampoObrigatorio(txtNumero.Text))
            {
                MessageBox.Show("Campo Número é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Focus();
                return false;
            }
            if (!Validacoes.CampoObrigatorio(txtBairro.Text))
            {
                MessageBox.Show("Campo Bairro é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBairro.Focus();
                return false;
            }
            if (!Validacoes.CampoObrigatorio(txtCodCidade.Text))
            {
                MessageBox.Show("Campo Código Cidade é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodCidade.Focus();
                return false;
            }
            string DataNasc = new string(txtDataNasc.Text.Where(char.IsDigit).ToArray());
            if (!Validacoes.CampoObrigatorio(DataNasc))
            {
                MessageBox.Show("Campo Data Nasc. é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDataNasc.Focus();
                return false;
            }
            if (!Validacoes.CampoObrigatorio(txtSexo.Text))
            {
                MessageBox.Show("Campo Sexo é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSexo.Focus();
                return false;
            }
            return true;
        }
        public override void Salvar()
        {
            if (!VerificaCamposObrigatorios())
            {
                return;
            }
            int idAtual = Alterar != -7 ? Alterar : -7;
            string cpf = new string(txtCPF.Text.Where(char.IsDigit).ToArray());

            if (!Validacoes.VerificarDataMenorOuIgualHoje(txtDataNasc.Text, "nascimento"))
            {
                txtDataNasc.Focus();
                return;
            }
            if (alunoController.JaCadastrado(cpf, idAtual))
            {
                MessageBox.Show("Aluno(a) já cadastrado(a).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCPF.Focus();
            }
            else
            {
                try
                {
                    string Aluno = txtNome.Text;
                    string apelido = txtApelido.Text;
                    string endereco = txtEndereco.Text;
                    string bairro = txtBairro.Text;
                    int numero = Convert.ToInt32(txtNumero.Text);
                    string cep = new string(txtCEP.Text.Where(char.IsDigit).ToArray());
                    string complemento = txtComplemento.Text;
                    string email = txtEmail.Text;
                    string celular = new string(txtCelular.Text.Where(char.IsDigit).ToArray());
                    int idCidade = int.Parse(txtCodCidade.Text);
                    string sexo = txtSexo.SelectedItem.ToString();
                    DateTime.TryParse(txtDataCadastro.Text, out DateTime dataCadastro);
                    DateTime.TryParse(txtDataNasc.Text, out DateTime dataNasc);

                    DateTime dataUltAlt = Alterar != -1 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Text, out DateTime result) ? result : DateTime.MinValue;

                    ModelAluno novoAluno = new ModelAluno
                    {
                        Aluno = Aluno,
                        Apelido = apelido,
                        endereco = endereco,
                        bairro = bairro,
                        numero = numero,
                        cep = cep,
                        complemento = complemento,
                        sexo = sexo,
                        email = email,
                        dataNasc = dataNasc,
                        cpf = cpf,
                        celular = celular,
                        Ativo = Ativo,
                        dataCadastro = dataCadastro,
                        dataUltAlt = dataUltAlt,
                        idCidade = idCidade
                    };

                    if (Alterar == -7)
                    {
                        alunoController.Salvar(novoAluno);
                    }
                    else
                    {
                        novoAluno.idAluno = Alterar;
                        alunoController.Alterar(novoAluno);
                    }

                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            string cpf = new string(txtCPF.Text.Where(char.IsDigit).ToArray());
            if (!Validacoes.ValidaCPF(cpf))
            {
                MessageBox.Show("CPF inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCPF.Focus();
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.ValidaEmail(txtEmail.Text))
            {
                MessageBox.Show("Email inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.VerificaLetras(txtNome.Text))
            {
                MessageBox.Show("Nome inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
            }
        }

        private void txtApelido_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.VerificaLetras(txtApelido.Text))
            {
                MessageBox.Show("Apelido inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApelido.Focus();
            }
        }


        private void txtNumero_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.VerificaNumeros(txtNumero.Text))
            {
                MessageBox.Show("Numero inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Focus();
            }
        }

        private void txtCodCidade_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodCidade.Text))
            {
                if (!Validacoes.VerificaNumeros(txtCodCidade.Text))
                {
                    MessageBox.Show("Cód. Cidade inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodCidade.Focus();
                }
                else
                {
                    List<string> cidadeEstadoPais = alunoController.GetCEPByCidadeId(int.Parse(txtCodCidade.Text));

                    if (cidadeEstadoPais.Count > 0)
                    {
                        string[] info = cidadeEstadoPais[0].Split(',');
                        if (info.Length >= 3)
                        {
                            txtCidade.Text = info[0].Trim();
                            txtUF.Text = info[1].Trim();
                            txtPais.Text = info[2].Trim();
                        }
                    }
                    else
                    {
                        txtCodCidade.Clear();
                        txtCidade.Clear();
                        txtUF.Clear();
                        txtPais.Clear();
                        txtCodCidade.Focus();
                        MessageBox.Show("Código Cidade não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consultaCidade.btnSair.Text = "Selecionar";

            if (consultaCidade.ShowDialog() == DialogResult.OK)
            {
                var cidadeDetalhes = consultaCidade.Tag as Tuple<int, string>;

                if (cidadeDetalhes != null)
                {
                    int cidadeID = cidadeDetalhes.Item1;
                    string cidadeNome = cidadeDetalhes.Item2;

                    txtCodCidade.Text = cidadeID.ToString();
                    txtCidade.Text = cidadeNome;

                    List<string> cidadeEstadoPais = alunoController.GetCEPByCidadeId(cidadeID);

                    if (cidadeEstadoPais.Count > 0)
                    {
                        string[] info = cidadeEstadoPais[0].Split(',');
                        if (info.Length >= 3)
                        {
                            txtUF.Text = info[1].Trim();
                            txtPais.Text = info[2].Trim();
                        }
                    }
                }
            }
        }

        private void CadastroAluno_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaAluno)this.Owner).AtualizarConsultaAlunos(false);
        }

        private void btnConsultaEvolucao_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "0")
            {
                MessageBox.Show("Aluno ainda não cadastrado, salve o cadastro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ConsultaEvolucao consultaEvolucao = new ConsultaEvolucao(int.Parse(txtCodigo.Text));
                consultaEvolucao.ShowDialog();
            }
        }

        private void btnConsultaPostura_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "0")
            {
                MessageBox.Show("Aluno ainda não cadastrado, salve o cadastro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ConsultaPostura consultaPostura = new ConsultaPostura(int.Parse(txtCodigo.Text));
                consultaPostura.ShowDialog();
            }
        }

        private void txtDataNasc_Leave(object sender, EventArgs e)
        {

        }

        private void txtCelular_Leave(object sender, EventArgs e)
        {

        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIncluirPostura_Click(object sender, EventArgs e)
        {
            CadastroPostura cadastroPostura = new CadastroPostura(-7, idBusca);
            cadastroPostura.Owner = this;
            cadastroPostura.ShowDialog();
        }

        private void btnAlterarPostura_Click(object sender, EventArgs e)
        {
            if (dataGridViewPostura.SelectedRows.Count > 0)
            {
                int idPostura = (int)dataGridViewPostura.SelectedRows[0].Cells["CodigoPostura"].Value;
                CadastroPostura cadastroPosturas = new CadastroPostura(idPostura, idBusca);
                cadastroPosturas.Owner = this;
                cadastroPosturas.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma postura para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluirPostura_Click(object sender, EventArgs e)
        {
            if (dataGridViewPostura.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir esta postura?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idPostura = (int)dataGridViewPostura.SelectedRows[0].Cells["CodigoPostura"].Value;
                    posturaController.Deletar(idPostura);
                    AtualizarConsultaPostura();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma postura para postura.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnIncluirEvolucao_Click(object sender, EventArgs e)
        {
            CadastroEvolucao cadastroEvolucao = new CadastroEvolucao(-7, idBusca);
            cadastroEvolucao.Owner = this;
            cadastroEvolucao.ShowDialog();
        }
        public void AtualizarConsultaPostura()
        {
            try
            {
                //recarrega os dados dos posturas na consulta de posturas
                ModelAluno aluno = alunoController.BuscarPorId(Alterar);
                exibirPosturasDGV(aluno.Posturas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de postura: " + ex.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AtualizarConsultaEvolucao()
        {
            try
            {
                //dataGridViewPostura.AutoGenerateColumns = false;
                //recarrega os dados dos posturas na consulta de posturas
                ModelAluno aluno = alunoController.BuscarPorId(Alterar);
                exibirEvolucoesDGV(aluno.Evolucoes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de evolucao: " + ex.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void exibirPosturasDGV(List<ModelPostura> posturas)
        {
            dataGridViewPostura.Rows.Clear(); //limpa as linhas do dgv

            foreach (var postura in posturas) //vai adicionando as posturas
            {
                dataGridViewPostura.Rows.Add(
                    postura.idPostura,
                    postura.titulo
                );
            }
        }
        private void exibirEvolucoesDGV(List<ModelEvolucao> evolucoes)
        {
            dataGridViewEvolucao.Rows.Clear(); //limpa as linhas do dgv

            foreach (var evolucao in evolucoes) //vai adicionando as posturas
            {
                dataGridViewEvolucao.Rows.Add(
                    evolucao.idEvolucao,
                    evolucao.titulo
                );
            }
        }
        private void CadastroAluno_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExcluirEvolucao_Click(object sender, EventArgs e)
        {
            if (dataGridViewEvolucao.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir esta evolução?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idEvolucao = (int)dataGridViewEvolucao.SelectedRows[0].Cells["CodigoEvolucao"].Value;
                    evolucaoController.Deletar(idEvolucao);
                    AtualizarConsultaEvolucao();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma evolução para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAlterarEvolucao_Click(object sender, EventArgs e)
        {
            if (dataGridViewEvolucao.SelectedRows.Count > 0)
            {
                int idEvolucao = (int)dataGridViewEvolucao.SelectedRows[0].Cells["CodigoEvolucao"].Value;
                CadastroEvolucao cadastroEvolucao = new CadastroEvolucao(idEvolucao, idBusca);
                cadastroEvolucao.Owner = this;
                cadastroEvolucao.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma evolução para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewEvolucao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewPostura_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idPostura = (int)dataGridViewPostura.Rows[e.RowIndex].Cells["CodigoPostura"].Value;
                CadastroPostura cadastroPosturas = new CadastroPostura(idPostura, idBusca);
                cadastroPosturas.Owner = this;
                cadastroPosturas.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma postura para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewEvolucao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idEvolucao = (int)dataGridViewEvolucao.Rows[e.RowIndex].Cells["CodigoEvolucao"].Value;
                CadastroEvolucao cadastroEvolucao = new CadastroEvolucao(idEvolucao, idBusca);
                cadastroEvolucao.Owner = this;
                cadastroEvolucao.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma evolução para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
