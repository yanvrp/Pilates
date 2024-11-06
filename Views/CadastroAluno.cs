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
        private ConsultaProfissao consultaProfissao;
        private ControllerProfissao<ModelProfissao> controllerProfissao;
        public int idBusca;
        int idAtual;
        public CadastroAluno()
        {
            InitializeComponent();
            posturaController = new ControllerPostura<ModelPostura>();
            alunoController = new ControllerAluno<ModelAluno>();
            consultaCidade = new ConsultaCidade();
            evolucaoController = new ControllerEvolucao<ModelEvolucao>();
            consultaProfissao = new ConsultaProfissao();
            controllerProfissao = new ControllerProfissao<ModelProfissao>();
            idBusca = int.Parse(txtCodigo.Texts);
        }
        public CadastroAluno(int idAluno) : this()
        {
            Alterar = idAluno;
            Carrega();
        }
        public override void Carrega()
        {
            btnAlterarEvolucao.Enabled = true;
            btnIncluirEvolucao.Enabled = true;
            btnExcluirEvolucao.Enabled = true;
            btnAlterarPostura.Enabled = true;
            btnIncluirPostura.Enabled = true;
            btnExcluirPostura.Enabled = true;
            if (Alterar != -7)
            {
                ModelAluno aluno = alunoController.BuscarPorId(Alterar);
                if (aluno != null)
                {
                    txtCodigo.Texts = aluno.idAluno.ToString();
                    txtNome.Texts = aluno.Aluno;
                    txtApelido.Texts = aluno.Apelido;
                    txtEndereco.Texts = aluno.endereco;
                    txtBairro.Texts = aluno.bairro;
                    txtNumero.Texts = aluno.numero.ToString();
                    txtCEP.Texts = aluno.cep;
                    txtComplemento.Texts = aluno.complemento;
                    txtCodCidade.Texts = aluno.idCidade.ToString();
                    txtCodProfissao.Texts = aluno.idProfissao.ToString();
                    if (aluno.idProfissao != null)
                    { 
                        ModelProfissao profissao = controllerProfissao.BuscarPorId(int.Parse(txtCodProfissao.Texts));               
                        txtProfissão.Texts = profissao.profissao.ToString();
                    }
                    txtSexo.Text = aluno.sexo;
                    txtEmail.Texts = aluno.email;
                    txtCelular.Texts = aluno.celular;
                    txtCPF.Texts = aluno.cpf;
                    txtDataNasc.Texts = aluno.dataNasc.ToString();
                    txtDataCadastro.Texts = aluno.dataCadastro.ToString();
                    txtDataUltAlt.Texts = aluno.dataUltAlt.ToString();
                    rbAtivo.Checked = aluno.Ativo;
                    rbInativo.Checked = !aluno.Ativo;

                    List<string> cidadeEstadoPais = alunoController.CarregaCEP(aluno.idCidade);

                    if (cidadeEstadoPais.Count > 0)
                    {
                        string[] info = cidadeEstadoPais[0].Split(',');
                        if (info.Length >= 3)
                        {
                            txtCidade.Texts = info[0].Trim();
                            txtUF.Texts = info[1].Trim();
                            txtPais.Texts = info[2].Trim();
                        }
                    }
                    exibirPosturasDGV(aluno.Posturas);
                    exibirEvolucoesDGV(aluno.Evolucoes);
                }
                else
                {
                    MessageBox.Show("Aluno(a) não encontrado(a).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                idBusca = int.Parse(txtCodigo.Texts);
            }
        }
        protected bool VerificaCamposObrigatorios()
        {
            string cpf = new string(txtCPF.Texts.Where(char.IsDigit).ToArray());
            string pais = txtPais.Texts;
            if (pais == "BRASIL")
            {
                if (!Validacoes.CampoObrigatorio(cpf))
                {
                    MessageBox.Show("CPF obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCPF.Focus();
                    return false;
                }
            }
            if (!Validacoes.CampoObrigatorio(txtNome.Texts))
            {
                MessageBox.Show("Campo Nome é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return false;
            }
            string celular = new string(txtCelular.Texts.Where(char.IsDigit).ToArray());
            if (!Validacoes.CampoObrigatorio(celular))
            {
                MessageBox.Show("Campo Celular é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCelular.Focus();
                return false;
            }
            if (!Validacoes.CampoObrigatorio(txtEmail.Texts))
            {
                MessageBox.Show("Campo Email é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }
            string cep = new string(txtCEP.Texts.Where(char.IsDigit).ToArray());
            if (!Validacoes.CampoObrigatorio(cep))
            {
                MessageBox.Show("Campo CEP é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCEP.Focus();
                return false;
            }
            if (!Validacoes.CampoObrigatorio(txtEndereco.Texts))
            {
                MessageBox.Show("Campo Endereço é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEndereco.Focus();
                return false;
            }
            if (!Validacoes.CampoObrigatorio(txtNumero.Texts))
            {
                MessageBox.Show("Campo Número é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Focus();
                return false;
            }
            if (!Validacoes.CampoObrigatorio(txtBairro.Texts))
            {
                MessageBox.Show("Campo Bairro é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBairro.Focus();
                return false;
            }
            if (!Validacoes.CampoObrigatorio(txtCodCidade.Texts))
            {
                MessageBox.Show("Campo Código Cidade é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodCidade.Focus();
                return false;
            }
            string DataNasc = new string(txtDataNasc.Texts.Where(char.IsDigit).ToArray());
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
            if (!Validacoes.CampoObrigatorio(txtCodProfissao.Texts)) 
            {
                MessageBox.Show("Campo Código Profissão é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodProfissao.Focus();
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
            idAtual = Alterar != -7 ? Alterar : -7;
            string cpf = new string(txtCPF.Texts.Where(char.IsDigit).ToArray());

            if (!Validacoes.VerificarDataMenorOuIgualHoje(txtDataNasc.Texts, "nascimento"))
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
                    string Aluno = txtNome.Texts;
                    string apelido = txtApelido.Texts;
                    string endereco = txtEndereco.Texts;
                    string bairro = txtBairro.Texts;
                    string numero = txtNumero.Texts;
                    string cep = new string(txtCEP.Texts.Where(char.IsDigit).ToArray());
                    string complemento = txtComplemento.Texts;
                    string email = txtEmail.Texts;
                    string celular = new string(txtCelular.Texts.Where(char.IsDigit).ToArray());
                    int idCidade = int.Parse(txtCodCidade.Texts);
                    int idProfissao = int.Parse(txtCodProfissao.Texts);
                    string sexo = txtSexo.SelectedItem.ToString();
                    DateTime.TryParse(txtDataCadastro.Texts, out DateTime dataCadastro);
                    DateTime.TryParse(txtDataNasc.Texts, out DateTime dataNasc);

                    DateTime dataUltAlt = Alterar != -1 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Texts, out DateTime result) ? result : DateTime.MinValue;

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
                        idCidade = idCidade,
                        idProfissao = idProfissao
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


        private void CadastroAluno_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaAluno)this.Owner).AtualizarConsultaAlunos(false);
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            if (Alterar == -7)
            {
                int novoCodigo = alunoController.BuscarUltimoCodigo() + 1;
                txtCodigo.Texts = novoCodigo.ToString();
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

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            string cpf = new string(txtCPF.Texts.Where(char.IsDigit).ToArray());
            if (!Validacoes.ValidaCPF(cpf))
            {
                MessageBox.Show("CPF inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCPF.Focus();
            } else
            {
                idAtual = Alterar != -7 ? Alterar : -7;
                if (alunoController.JaCadastrado(cpf, idAtual))
                {
                    MessageBox.Show("Aluno(a) já cadastrado(a).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCPF.Focus();
                }
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.ValidaEmail(txtEmail.Texts))
            {
                MessageBox.Show("Email inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.VerificaLetras(txtNome.Texts))
            {
                MessageBox.Show("Nome inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
            }
        }

        private void txtApelido_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.VerificaLetras(txtApelido.Texts))
            {
                MessageBox.Show("Apelido inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApelido.Focus();
            }
        }

        private void txtCodCidade_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodCidade.Texts))
            {
                List<string> cidadeEstadoPais = alunoController.GetCEPByIdCidade(int.Parse(txtCodCidade.Texts));

                if (cidadeEstadoPais.Count > 0)
                {
                    string[] info = cidadeEstadoPais[0].Split(',');
                    if (info.Length >= 3)
                    {
                        txtCidade.Texts = info[0].Trim();
                        txtUF.Texts = info[1].Trim();
                        txtPais.Texts = info[2].Trim();
                    }
                }
                else
                {
                    MessageBox.Show("Código Cidade não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodCidade.Focus();
                    txtCodCidade.Clear();
                    txtCidade.Clear();
                    txtUF.Clear();
                    txtPais.Clear();
                }
            }
        }

        private void btnBuscarCidade_Click(object sender, EventArgs e)
        {
            consultaCidade.btnSair.Text = "Selecionar";
            consultaCidade.cbInativos.Visible = false;

            if (consultaCidade.ShowDialog() == DialogResult.OK)
            {
                var cidadeDetalhes = consultaCidade.Tag as Tuple<int, string>;

                if (cidadeDetalhes != null)
                {
                    int cidadeID = cidadeDetalhes.Item1;
                    string cidadeNome = cidadeDetalhes.Item2;

                    txtCodCidade.Texts = cidadeID.ToString();
                    txtCidade.Texts = cidadeNome;

                    List<string> cidadeEstadoPais = alunoController.GetCEPByCidadeId(cidadeID);

                    if (cidadeEstadoPais.Count > 0)
                    {
                        string[] info = cidadeEstadoPais[0].Split(',');
                        if (info.Length >= 3)
                        {
                            txtUF.Texts = info[1].Trim();
                            txtPais.Texts = info[2].Trim();
                        }
                    }
                }
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private void btnBuscarProfissao_Click(object sender, EventArgs e)
        {
            consultaProfissao.btnSair.Text = "Selecionar";
            consultaProfissao.cbInativos.Visible = false;

            if (consultaProfissao.ShowDialog() == DialogResult.OK)
            {
                var infosProfissao = consultaProfissao.Tag as Tuple<int, string>;
                if (infosProfissao != null)
                {
                    int idProfissao = infosProfissao.Item1;
                    string Profissao = infosProfissao.Item2;

                    txtCodProfissao.Texts = idProfissao.ToString();
                    txtProfissão.Texts = Profissao;
                }
            }
        }

        private void txtCodProfissao_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodProfissao.Texts))
            {
                string profissao = controllerProfissao.getProfissao(int.Parse(txtCodProfissao.Texts));
                if (profissao != null)
                {
                    txtProfissão.Texts = profissao;
                }
                else
                {
                    MessageBox.Show("Profissão não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodProfissao.Focus();
                    txtCodProfissao.Clear();
                    txtProfissão.Clear();
                }
            }
        }

        private void txtCodProfissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDataNasc_Leave(object sender, EventArgs e)
        {
            DateTime dataNasc;
            string dataN = new string(txtDataNasc.Texts.Where(char.IsDigit).ToArray());
            bool dataValida = DateTime.TryParse(txtDataNasc.Texts, out dataNasc);

            if (!string.IsNullOrEmpty(dataN))
            {
                if (!dataValida)
                {
                    MessageBox.Show("Data de Nascimento inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDataNasc.Focus();
                    return;
                }
                if (!Validacoes.VerificarDataMenorOuIgualHoje(dataNasc.ToString("dd/MM/yyyy"), "nascimento"))
                {
                    txtDataNasc.Focus();
                    return;
                }
            }
        }
    }
}
