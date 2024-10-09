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
    public partial class CadastroFornecedor : Pilates.Views.CadastroPAI
    {
        public bool Fisico = true;
        private ControllerFornecedor<ModelFornecedor> controllerFornecedor;
        private ConsultaCidade consultaCidade;
        private ConsultaCondicaoPagamento consultaCondicaoPagamento;
        private ControllerCondicaoPagamento<ModelCondicaoPagamento> controllerCondicaoPagamento;
        public int idBusca;
        public CadastroFornecedor()
        {
            InitializeComponent();
            controllerFornecedor = new ControllerFornecedor<ModelFornecedor>();
            consultaCidade = new ConsultaCidade();
            consultaCondicaoPagamento = new ConsultaCondicaoPagamento();
            controllerCondicaoPagamento = new ControllerCondicaoPagamento<ModelCondicaoPagamento>();
        }
        public CadastroFornecedor(int idFornecedor) : this()
        {
            Alterar = idFornecedor;
            Carrega();
        }
        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            Fisico = rbFisica.Checked;
            lblFornecedor.Text = "Fornecedor *";
            lblApelido.Text = "Apelido";
            lblCPF_CNPJ.Text = "CPF *";
            txtCPF_CNPJ.Mask = "000.000.000-00";
            lblRG_IE.Text = "RG";
            txtSexo.Visible = true;
            lblSexo.Visible = true;
            lblNomeContato.Visible = false;
            txtNomeContato.Visible = false;
            lblDataNasc.Text = "Data Nasc.";
            txtCPF_CNPJ.Clear();
        }

        private void rbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            Fisico = !rbJuridica.Checked;
            lblFornecedor.Text = "Razão Social *";
            lblApelido.Text = "Nome Fantasia";
            lblCPF_CNPJ.Text = "CNPJ *";
            txtCPF_CNPJ.Mask = "00.000.000/0000-00";
            lblRG_IE.Text = "Inscrição Estadual";
            txtSexo.Visible = false;
            lblSexo.Visible = false;
            lblNomeContato.Visible = true;
            txtNomeContato.Visible = true;
            lblDataNasc.Text = "Data Fund.";
            txtCPF_CNPJ.Clear();
        }
        public override void Salvar()
        {
            if (txtPais.Text != "BRASIL")
            {
                MessageBox.Show("Só é permitido o cadastro de fornecedores brasileiros!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodCidade.Focus();
                return;
            }
            if (!VerificaCamposObrigatorios())
            {
                return;
            }
            int idAtual = Alterar != -7 ? Alterar : -7;
            string cpf_cnpj = new string(txtCPF_CNPJ.Text.Where(char.IsDigit).ToArray());

            if (controllerFornecedor.JaCadastrado(cpf_cnpj, idAtual))
            {
                MessageBox.Show("Fornecedor já cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCPF_CNPJ.Focus();
            }
            else
            {
                try
                {
                    string cliente_razao_social = txtFornecedor.Text;
                    string apelido_nome_fantasia = txtApelido.Text;
                    string endereco = txtEndereco.Text;
                    string bairro = txtBairro.Text;
                    string numero = txtNumero.Text;
                    string cep = new string(txtCEP.Text.Where(char.IsDigit).ToArray());
                    string complemento = txtComplemento.Text;
                    string email = txtEmail.Text;
                    string telefone = new string(txtTelefone.Text.Where(char.IsDigit).ToArray());
                    string celular = new string(txtCelular.Text.Where(char.IsDigit).ToArray());
                    string nome_contato = txtNomeContato.Text;
                    string rg_ie = new string(txtRG_IE.Text.Where(char.IsDigit).ToArray());
                    int idCidade = Convert.ToInt32(txtCodCidade.Text);
                    int idCondPagamento = Convert.ToInt32(txtCodCondPag.Text);

                    Validacoes.AtualizarCampoComDataPadrao(txtDataNasc, out DateTime data_nasc);

                    DateTime.TryParse(txtDataCadastro.Text, out DateTime dataCadastro);
                    DateTime dataUltAlt = Alterar != -7 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Text, out DateTime result) ? result : DateTime.MinValue;

                    string sexo;
                    if (Fisico)
                    {
                        sexo = txtSexo.SelectedItem.ToString();
                    }
                    else
                    {
                        sexo = "Outro"; //quando for jurídico não tem
                    }

                    ModelFornecedor novoFornecedor = new ModelFornecedor
                    {
                        tipo_pessoa = Fisico,
                        fornecedor_razao_social = cliente_razao_social,
                        apelido_nome_fantasia = apelido_nome_fantasia,
                        endereco = endereco,
                        bairro = bairro,
                        numero = numero,
                        cep = cep,
                        complemento = complemento,
                        sexo = sexo,
                        email = email,
                        telefone = telefone,
                        celular = celular,
                        nome_contato = nome_contato,
                        data_nasc = data_nasc,
                        cpf_cnpj = cpf_cnpj,
                        rg_ie = rg_ie,
                        Ativo = Ativo,
                        dataCadastro = dataCadastro,
                        dataUltAlt = dataUltAlt,
                        idCidade = idCidade,
                        idCondPagamento = idCondPagamento,
                    };

                    if (Alterar == -7)
                    {
                        controllerFornecedor.Salvar(novoFornecedor);
                    }
                    else
                    {
                        novoFornecedor.idFornecedor = Alterar;
                        controllerFornecedor.Alterar(novoFornecedor);
                    }

                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        protected bool VerificaCamposObrigatorios()
        {
            string cpf_cnpj = new string(txtCPF_CNPJ.Text.Where(char.IsDigit).ToArray());
            string pais = txtPais.Text;
            if (pais == "BRASIL")
            {
                if (!Validacoes.CampoObrigatorio(cpf_cnpj))
                {
                    MessageBox.Show("CPF / CNPJ obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCPF_CNPJ.Focus();
                    return false;
                }
            }
            if (!Validacoes.CampoObrigatorio(txtFornecedor.Text))
            {
                MessageBox.Show("Campo obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFornecedor.Focus();
                return false;
            }
            if (rbFisica.Checked)
            {
                if (!Validacoes.CampoObrigatorio(txtSexo.Text))
                {
                    MessageBox.Show("Campo Sexo é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSexo.Focus();
                    return false;
                }
            }
            if (rbJuridica.Checked)
            {
                if (!Validacoes.CampoObrigatorio(txtNomeContato.Text))
                {
                    MessageBox.Show("Campo Nome Contato é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNomeContato.Focus();
                    return false;
                }
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
            if (pais == "BRASIL")
            {
                if (!Validacoes.CampoObrigatorio(cep))
                {
                    MessageBox.Show("Campo CEP é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCEP.Focus();
                    return false;
                }
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
            if (!Validacoes.CampoObrigatorio(txtCodCondPag.Text))
            {
                MessageBox.Show("Campo Código Condição de Pagamento é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodCondPag.Focus();
                return false;
            }

            return true;
        }
        public override void Carrega()
        {
            base.Carrega();
            rbFisica.Enabled = false;
            rbJuridica.Enabled = false;
            if (Alterar != -7)
            {
                ModelFornecedor fornecedor = controllerFornecedor.BuscarPorId(Alterar);
                if (fornecedor != null)
                {
                    txtCodigo.Text = fornecedor.idFornecedor.ToString();
                    rbFisica.Checked = fornecedor.tipo_pessoa;
                    rbJuridica.Checked = !fornecedor.tipo_pessoa;
                    txtFornecedor.Text = fornecedor.fornecedor_razao_social;
                    txtApelido.Text = fornecedor.apelido_nome_fantasia;
                    txtEndereco.Text = fornecedor.endereco;
                    txtBairro.Text = fornecedor.bairro;
                    txtNumero.Text = fornecedor.numero;
                    txtCEP.Text = fornecedor.cep;
                    txtComplemento.Text = fornecedor.complemento;
                    txtCodCidade.Text = fornecedor.idCidade.ToString();
                    txtEmail.Text = fornecedor.email;
                    txtTelefone.Text = fornecedor.telefone;
                    txtCelular.Text = fornecedor.celular;
                    txtNomeContato.Text = fornecedor.nome_contato;
                    txtCPF_CNPJ.Text = fornecedor.cpf_cnpj;
                    txtRG_IE.Text = fornecedor.rg_ie;
                    txtDataCadastro.Text = fornecedor.dataCadastro.ToString();
                    txtDataUltAlt.Text = fornecedor.dataUltAlt.ToString();
                    rbAtivo.Checked = fornecedor.Ativo;
                    rbInativo.Checked = !fornecedor.Ativo;
                    txtCodCondPag.Text = fornecedor.idCondPagamento.ToString();
          
                    if (!txtSexo.Items.Contains(fornecedor.sexo))
                    {
                        txtSexo.Items.Add(fornecedor.sexo);
                    }
                    txtSexo.Text = fornecedor.sexo;

                    ModelCondicaoPagamento condPagamento = controllerCondicaoPagamento.BuscarPorId(int.Parse(txtCodCondPag.Text));

                    if (condPagamento != null)
                    {
                        txtCondPag.Text = condPagamento.condicaoPagamento;
                    }

                    Validacoes.AtualizarCampoData(fornecedor.data_nasc, txtDataNasc);

                    List<string> cidadeEstadoPais = controllerFornecedor.GetCEPByIdCidade(fornecedor.idCidade);

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
                }
                else
                {
                    MessageBox.Show("Fornecedor não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CadastroFornecedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaFornecedor)this.Owner).AtualizarConsultaFornecedores(false);
        }

        private void CadastroFornecedor_Load(object sender, EventArgs e)
        {
            if (Alterar == -7)
            {
                int novoCodigo = controllerFornecedor.GetUltimoCodigo() + 1;
                txtCodigo.Text = novoCodigo.ToString();
                txtDataCadastro.Text = DateTime.Now.ToString();
                txtDataUltAlt.Text = DateTime.Now.ToString();
            }
        }

        private void txtFornecedor_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.VerificaLetras(txtFornecedor.Text))
            {
                MessageBox.Show("Fornecedor inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFornecedor.Focus();
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

                    List<string> cidadeEstadoPais = controllerFornecedor.GetCEPByIdCidade(cidadeID);

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
                    List<string> cidadeEstadoPais = controllerFornecedor.GetCEPByIdCidade(int.Parse(txtCodCidade.Text));

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

        private void btnBuscarCondPag_Click(object sender, EventArgs e)
        {
            consultaCondicaoPagamento.btnSair.Text = "Selecionar";
            if (consultaCondicaoPagamento.ShowDialog() == DialogResult.OK)
            {
                var condPagamento = consultaCondicaoPagamento.Tag as Tuple<int, string>;
                if (condPagamento != null)
                {
                    int idCondPag = condPagamento.Item1;
                    string condicaoPagamento = condPagamento.Item2;

                    txtCodCondPag.Text = idCondPag.ToString();
                    txtCondPag.Text = condicaoPagamento;
                }
            }
        }

        private void txtCodCondPag_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodCondPag.Text))
            {
                ModelCondicaoPagamento condPagamento = controllerCondicaoPagamento.BuscarPorId(int.Parse(txtCodCondPag.Text));
                if (condPagamento != null)
                {
                    txtCondPag.Text = condPagamento.condicaoPagamento;
                }
                else
                {
                    MessageBox.Show("Condição de Pagamento não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodCondPag.Focus();
                    txtCodCondPag.Clear();
                    txtCondPag.Clear();
                }
            }
        }

        private void txtCPF_CNPJ_Leave(object sender, EventArgs e)
        {
            string cpf_cnpj = new string(txtCPF_CNPJ.Text.Where(char.IsDigit).ToArray());
            if (!rbFisica.Checked)
            {
                if (!Validacoes.ValidaCNPJ(cpf_cnpj))
                {
                    MessageBox.Show("CNPJ inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCPF_CNPJ.Focus();
                }
            }
            else
            {
                if (!Validacoes.ValidaCPF(cpf_cnpj))
                {
                    MessageBox.Show("CPF inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCPF_CNPJ.Focus();
                }
            }
        }

        private void txtNomeContato_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.VerificaLetras(txtNomeContato.Text))
            {
                MessageBox.Show("Nome do Contato inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomeContato.Focus();
            }
        }

        private void txtRG_IE_Leave(object sender, EventArgs e)
        {
            string RG_IE = new string(txtRG_IE.Text.Where(char.IsDigit).ToArray());

            if (!string.IsNullOrEmpty(txtRG_IE.Text) && !rbFisica.Checked)
            {
                if (!Validacoes.ValidaIE(txtUF.Text, RG_IE))
                {
                    MessageBox.Show("IE inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRG_IE.Focus();
                }

            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.ValidaEmail(txtEmail.Text))
            {
                MessageBox.Show("Email inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }
        }

        private void txtDataNasc_Leave(object sender, EventArgs e)
        {
            DateTime dataNasc;
            string dataN = new string(txtDataNasc.Text.Where(char.IsDigit).ToArray());
            bool dataValida = DateTime.TryParse(txtDataNasc.Text, out dataNasc);

            if (!string.IsNullOrEmpty(dataN))
            {
                if (!dataValida)
                {
                    if (rbFisica.Checked)
                    {
                        MessageBox.Show("Data de Nascimento inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDataNasc.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Data de Fundação inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDataNasc.Focus();
                        return;
                    }
                }
                if (rbFisica.Checked)
                {
                    if (!Validacoes.VerificarDataMenorOuIgualHoje(txtDataNasc.Text, "nascimento"))
                    {
                        txtDataNasc.Focus();
                        return;
                    }
                }
                else
                {
                    if (!Validacoes.VerificarDataMenorOuIgualHoje(txtDataNasc.Text, "fundação"))
                    {
                        txtDataNasc.Focus();
                        return;
                    }
                }
            }
        }

        private void txtCodCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir apenas números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodCondPag_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir apenas números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRG_IE_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir apenas números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir apenas números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir apenas números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
