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
            if (txtPais.Texts != "BRASIL")
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
            string cpf_cnpj = new string(txtCPF_CNPJ.Texts.Where(char.IsDigit).ToArray());

            if (controllerFornecedor.JaCadastrado(cpf_cnpj, idAtual))
            {
                MessageBox.Show("Fornecedor já cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCPF_CNPJ.Focus();
            }
            else
            {
                try
                {
                    string cliente_razao_social = txtFornecedor.Texts;
                    string apelido_nome_fantasia = txtApelido.Texts;
                    string endereco = txtEndereco.Texts;
                    string bairro = txtBairro.Texts;
                    string numero = txtNumero.Texts;
                    string cep = new string(txtCEP.Texts.Where(char.IsDigit).ToArray());
                    string complemento = txtComplemento.Texts;
                    string email = txtEmail.Texts;
                    string telefone = new string(txtTelefone.Texts.Where(char.IsDigit).ToArray());
                    string celular = new string(txtCelular.Texts.Where(char.IsDigit).ToArray());
                    string nome_contato = txtNomeContato.Texts;
                    string rg_ie = new string(txtRG_IE.Texts.Where(char.IsDigit).ToArray());
                    int idCidade = Convert.ToInt32(txtCodCidade.Texts);
                    int idCondPagamento = Convert.ToInt32(txtCodCondPag.Texts);

                    Validacoes.AtualizarCampoComDataPadrao(txtDataNasc, out DateTime data_nasc);

                    DateTime.TryParse(txtDataCadastro.Texts, out DateTime dataCadastro);
                    DateTime dataUltAlt = Alterar != -7 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Texts, out DateTime result) ? result : DateTime.MinValue;

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
            string cpf_cnpj = new string(txtCPF_CNPJ.Texts.Where(char.IsDigit).ToArray());
            string pais = txtPais.Texts;
            if (pais == "BRASIL")
            {
                if (!Validacoes.CampoObrigatorio(cpf_cnpj))
                {
                    MessageBox.Show("CPF / CNPJ obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCPF_CNPJ.Focus();
                    return false;
                }
            }
            if (!Validacoes.CampoObrigatorio(txtFornecedor.Texts))
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
                if (!Validacoes.CampoObrigatorio(txtNomeContato.Texts))
                {
                    MessageBox.Show("Campo Nome Contato é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNomeContato.Focus();
                    return false;
                }
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
            if (pais == "BRASIL")
            {
                if (!Validacoes.CampoObrigatorio(cep))
                {
                    MessageBox.Show("Campo CEP é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCEP.Focus();
                    return false;
                }
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
            if (!Validacoes.CampoObrigatorio(txtCodCondPag.Texts))
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
                    txtCodigo.Texts = fornecedor.idFornecedor.ToString();
                    rbFisica.Checked = fornecedor.tipo_pessoa;
                    rbJuridica.Checked = !fornecedor.tipo_pessoa;
                    txtFornecedor.Texts = fornecedor.fornecedor_razao_social;
                    txtApelido.Texts = fornecedor.apelido_nome_fantasia;
                    txtEndereco.Texts = fornecedor.endereco;
                    txtBairro.Texts = fornecedor.bairro;
                    txtNumero.Texts = fornecedor.numero;
                    txtCEP.Texts = fornecedor.cep;
                    txtComplemento.Texts = fornecedor.complemento;
                    txtCodCidade.Texts = fornecedor.idCidade.ToString();
                    txtEmail.Texts = fornecedor.email;
                    txtTelefone.Texts = fornecedor.telefone;
                    txtCelular.Texts = fornecedor.celular;
                    txtNomeContato.Texts = fornecedor.nome_contato;
                    txtCPF_CNPJ.Texts = fornecedor.cpf_cnpj;
                    txtRG_IE.Texts = fornecedor.rg_ie;
                    txtDataCadastro.Texts = fornecedor.dataCadastro.ToString();
                    txtDataUltAlt.Texts = fornecedor.dataUltAlt.ToString();
                    rbAtivo.Checked = fornecedor.Ativo;
                    rbInativo.Checked = !fornecedor.Ativo;
                    txtCodCondPag.Texts = fornecedor.idCondPagamento.ToString();
          
                    if (!txtSexo.Items.Contains(fornecedor.sexo))
                    {
                        txtSexo.Items.Add(fornecedor.sexo);
                    }
                    txtSexo.Text = fornecedor.sexo;

                    ModelCondicaoPagamento condPagamento = controllerCondicaoPagamento.BuscarPorId(int.Parse(txtCodCondPag.Texts));

                    if (condPagamento != null)
                    {
                        txtCondPag.Texts = condPagamento.condicaoPagamento;
                    }

                    Validacoes.AtualizarCampoData(fornecedor.data_nasc, txtDataNasc);

                    List<string> cidadeEstadoPais = controllerFornecedor.GetCEPByIdCidade(fornecedor.idCidade);

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
                txtCodigo.Texts = novoCodigo.ToString();
                txtDataCadastro.Texts = DateTime.Now.ToString();
                txtDataUltAlt.Texts = DateTime.Now.ToString();
            }
        }

        private void txtFornecedor_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.VerificaLetras(txtFornecedor.Texts))
            {
                MessageBox.Show("Fornecedor inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFornecedor.Focus();
            }
        }

        private void btnBuscarCidade_Click(object sender, EventArgs e)
        {
            consultaCidade.btnSair.Text = "Selecionar";

            if (consultaCidade.ShowDialog() == DialogResult.OK)
            {
                var cidadeDetalhes = consultaCidade.Tag as Tuple<int, string>;

                if (cidadeDetalhes != null)
                {
                    int cidadeID = cidadeDetalhes.Item1;
                    string cidadeNome = cidadeDetalhes.Item2;

                    txtCodCidade.Texts = cidadeID.ToString();
                    txtCidade.Texts = cidadeNome;

                    List<string> cidadeEstadoPais = controllerFornecedor.GetCEPByIdCidade(cidadeID);

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

        private void txtCodCidade_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodCidade.Texts))
            {
                if (!Validacoes.VerificaNumeros(txtCodCidade.Texts))
                {
                    MessageBox.Show("Cód. Cidade inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodCidade.Focus();
                }
                else
                {
                    List<string> cidadeEstadoPais = controllerFornecedor.GetCEPByIdCidade(int.Parse(txtCodCidade.Texts));

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

        private void btnBuscarCond_Click(object sender, EventArgs e)
        {
            consultaCondicaoPagamento.btnSair.Text = "Selecionar";
            if (consultaCondicaoPagamento.ShowDialog() == DialogResult.OK)
            {
                var condPagamento = consultaCondicaoPagamento.Tag as Tuple<int, string>;
                if (condPagamento != null)
                {
                    int idCondPag = condPagamento.Item1;
                    string condicaoPagamento = condPagamento.Item2;

                    txtCodCondPag.Texts = idCondPag.ToString();
                    txtCondPag.Texts = condicaoPagamento;
                }
            }
        }

        private void txtCodCondPag_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodCondPag.Texts))
            {
                ModelCondicaoPagamento condPagamento = controllerCondicaoPagamento.BuscarPorId(int.Parse(txtCodCondPag.Texts));
                if (condPagamento != null)
                {
                    txtCondPag.Texts = condPagamento.condicaoPagamento;
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
            string cpf_cnpj = new string(txtCPF_CNPJ.Texts.Where(char.IsDigit).ToArray());
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
            int idAtual = Alterar != -7 ? Alterar : -7;
            if (controllerFornecedor.JaCadastrado(cpf_cnpj, idAtual))
            {
                MessageBox.Show("Fornecedor já cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCPF_CNPJ.Focus();
            }
        }

        private void txtNomeContato_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.VerificaLetras(txtNomeContato.Texts))
            {
                MessageBox.Show("Nome do Contato inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomeContato.Focus();
            }
        }

        private void txtRG_IE_Leave(object sender, EventArgs e)
        {
            string RG_IE = new string(txtRG_IE.Texts.Where(char.IsDigit).ToArray());

            if (!string.IsNullOrEmpty(txtRG_IE.Texts) && !rbFisica.Checked)
            {
                if (!Validacoes.ValidaIE(txtUF.Texts, RG_IE))
                {
                    MessageBox.Show("IE inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRG_IE.Focus();
                }

            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.ValidaEmail(txtEmail.Texts))
            {
                MessageBox.Show("Email inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
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
                    if (!Validacoes.VerificarDataMenorOuIgualHoje(txtDataNasc.Texts, "nascimento"))
                    {
                        txtDataNasc.Focus();
                        return;
                    }
                }
                else
                {
                    if (!Validacoes.VerificarDataMenorOuIgualHoje(txtDataNasc.Texts, "fundação"))
                    {
                        txtDataNasc.Focus();
                        return;
                    }
                }
            }
        }

        private void CadastroFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir apenas números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gbEndereco_Enter(object sender, EventArgs e)
        {

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

        private void txtRG_IE_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir apenas números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir apenas números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
