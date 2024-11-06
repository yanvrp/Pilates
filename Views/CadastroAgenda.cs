
using Pilates.Controller;
using Pilates.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pilates.Views
{
    public partial class CadastroAgenda : Pilates.Views.CadastroPAI
    {
        private ConsultaAluno consultaAluno;
        private ControllerAluno<ModelAluno> controllerAluno;
        private ControllerAgenda<ModelAgenda> controllerAgenda;
        private ControllerContrato<ModelContrato> controllerContrato;
        private ConsultaContrato consultaContrato;
        public CadastroAgenda()
        {
            InitializeComponent();
            consultaAluno = new ConsultaAluno();
            controllerAgenda = new ControllerAgenda<ModelAgenda>();
            controllerAluno = new ControllerAluno<ModelAluno>();
            consultaContrato = new ConsultaContrato();
            controllerContrato = new ControllerContrato<ModelContrato>();
            PreencherDropDownList();
        }
        public CadastroAgenda(int idAgenda) : this()
        {
            Alterar = idAgenda;
            Carrega();
        }
        public void BloqueiaTudo() 
        {
            txtCodAluno.Enabled = false;
            btnPesquisarAluno.Enabled = false;
            cbSituacao.Enabled = false;
            cbHoras.Enabled = false;
            cbMinutos.Enabled = false;
            txtData.Enabled = false;
        }
        public override void Bloqueia()
        {
            txtCodAluno.Enabled = false;
            btnPesquisarAluno.Enabled=false;
            txtCodContrato.Enabled = false;
        }
        private void PreencherDropDownList()
        {
            cbHoras.Items.Clear();
            for (int i = 6; i <= 22; i++)
            {
                cbHoras.Items.Add(i.ToString("D2"));
            }

            cbMinutos.Items.Clear();
            cbMinutos.Items.Add("00");
            cbMinutos.Items.Add("30");
        }

        private void CadastroAgenda_Load(object sender, EventArgs e)
        {
            if (Alterar == -7)
            {
                int novoCodigo = controllerAgenda.GetUltimoNumero() + 1;
                txtCodigo.Texts = novoCodigo.ToString();
            }
        }
        public override void Carrega()
        {
            var agenda = controllerAgenda.BuscarPorId(Alterar);
            if (agenda != null)
            {
                txtCodigo.Texts = agenda.idAgenda.ToString();
                txtCodAluno.Texts = agenda.idAluno.ToString();
                txtData.Texts = agenda.data.ToString();
                txtCodContrato.Texts = agenda.idContrato.ToString();
                txtDataCadastro.Texts = agenda.dataCadastro.ToString();
                txtDataUltAlt.Texts = agenda.dataUltAlt.ToString();
                rbAtivo.Checked = agenda.Ativo;
                rbInativo.Checked = !agenda.Ativo;
                txtDataCancelamento.Texts = agenda.dataCancelamento.ToString();
                txtUsuarioUltAlt.Texts = agenda.usuarioUltAlt;

                if (!string.IsNullOrEmpty(txtCodContrato.Texts))
                {
                    txtCodContrato.Visible = true;
                    lblCodContrato.Visible = true;
                    Bloqueia();
                } else
                {
                    btnCancelar.Visible = true;
                }

                if (agenda.dataCancelamento != null)
                {
                    txtDataCancelamento.Visible = true;
                    lblDataCancelamento.Visible=true;
                    cbSituacao.Items.Add("CANCELADO");
                    cbSituacao.Text = "CANCELADO";

                    BloqueiaTudo();
                }

                ModelAluno aluno = controllerAluno.BuscarPorId(int.Parse(txtCodAluno.Texts));

                txtAluno.Texts = aluno.Aluno.ToString();

                TimeSpan horario = agenda.horario;
                cbHoras.SelectedItem = horario.Hours.ToString("D2");
                cbMinutos.SelectedItem = horario.Minutes.ToString("D2");

                if (agenda.situacao != null)
                {
                    cbSituacao.Text = agenda.situacao;
                }
                else
                {
                    cbSituacao.SelectedIndex = -1;
                }

            }
        }
        public override void Salvar()
        {
            string data = new string(txtData.Texts.Where(char.IsDigit).ToArray());
            if (!Validacoes.CampoObrigatorio(txtCodAluno.Texts))
            {
                MessageBox.Show("Campo Código Aluno é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodAluno.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(cbHoras.Text))
            {
                MessageBox.Show("Campo Horas é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbHoras.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(cbMinutos.Text))
            {
                MessageBox.Show("Campo Minutos é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbMinutos.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(data))
            {
                MessageBox.Show("Campo Data é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtData.Focus();
            }
            else
            {
                try
                {
                    
                    int idAluno = Convert.ToInt32(txtCodAluno.Texts);
                    int? idContrato = null;
                    if (!string.IsNullOrEmpty(txtCodContrato.Texts))
                    {
                        idContrato = Convert.ToInt32(txtCodContrato.Texts);
                    }

                    string horas = cbHoras.Text;
                    string minutos = cbMinutos.Text;
                    string horarioString = $"{horas}:{minutos}";
                    TimeSpan horario = TimeSpan.Parse(horarioString);
                    DateTime.TryParse(txtData.Texts, out DateTime dataAgendamento);
                    string situacao = cbSituacao.Text.ToString();
                    string usuario = Program.usuarioLogado;

                    DateTime.TryParse(txtDataCadastro.Texts, out DateTime dataCadastro);
                    DateTime dataUltAlt = Alterar != -7 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Texts, out DateTime result) ? result : DateTime.MinValue;
                    
                    string dCancelamento = new string(txtDataCancelamento.Texts.Where(char.IsDigit).ToArray());
                    DateTime? dataCancelamento = string.IsNullOrEmpty(dCancelamento) || dCancelamento.Length != 8 ? (DateTime?)null : DateTime.ParseExact(txtDataCancelamento.Texts, "dd/MM/yyyy", null);

                    ModelAgenda novoAgendamento = new ModelAgenda
                    {
                        idAluno = idAluno,
                        idContrato = idContrato,
                        horario = horario,
                        data = dataAgendamento,
                        situacao = situacao,
                        dataCadastro = dataCadastro,
                        dataUltAlt = dataUltAlt,
                        dataCancelamento = dataCancelamento,
                        usuarioUltAlt = usuario,
                        Ativo = Ativo,
                    };
                    if (Alterar == -7)
                    {
                        controllerAgenda.Salvar(novoAgendamento);
                    }
                    else
                    {
                        novoAgendamento.idAgenda = Alterar;
                        controllerAgenda.Alterar(novoAgendamento);
                    }
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtCodAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodAluno_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodAluno.Texts))
            {
                string aluno = controllerAluno.getAluno(int.Parse(txtCodAluno.Texts));
                if (aluno != null)
                {
                    txtAluno.Texts = aluno;
                }
                else
                {
                    MessageBox.Show("Aluno não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodAluno.Focus();
                    txtCodAluno.Clear();
                    txtAluno.Clear();
                }
            }
        }

        private void btnPesquisarAluno_Click(object sender, EventArgs e)
        {
            consultaAluno.btnSair.Text = "Selecionar";
            consultaAluno.cbInativos.Visible = false;

            if (consultaAluno.ShowDialog() == DialogResult.OK)
            {
                var infosAluno = consultaAluno.Tag as Tuple<int, string>;
                if (infosAluno != null)
                {
                    int idAluno = infosAluno.Item1;
                    string Aluno = infosAluno.Item2;

                    txtCodAluno.Texts = idAluno.ToString();
                    txtAluno.Texts = Aluno;
                }
            }
        }

        private void CadastroAgenda_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaAgenda)this.Owner).AtualizarConsultaAgenda(false, false);
        }

        private void txtCodContrato_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodContrato.Texts))
            {
                ModelContrato contrato = controllerContrato.BuscarPorId(int.Parse(txtCodContrato.Texts));
                if (contrato == null)
                {
                    MessageBox.Show("Contrato não encontrado(a).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodContrato.Focus();
                    txtCodContrato.Clear();
                }
            }
        }

        private void btnPesquisarContrato_Click(object sender, EventArgs e)
        {
            consultaContrato.btnSair.Text = "Selecionar";

            if (consultaContrato.ShowDialog() == DialogResult.OK)
            {
                var infosContrato = consultaContrato.Tag as Tuple<int>;
                if (infosContrato != null)
                {
                    int idContrato = infosContrato.Item1;

                    txtCodContrato.Texts = idContrato.ToString();
                }
            }
        }

        private void txtData_Leave(object sender, EventArgs e)
        {
            DateTime data;
            string dataA = new string(txtData.Texts.Where(char.IsDigit).ToArray());
            bool dataValida = DateTime.TryParse(txtData.Texts, out data);

            if (!string.IsNullOrEmpty(dataA))
            {
                if (!dataValida)
                {
                    MessageBox.Show("Data de Agendamento inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtData.Focus();
                    return;
                }
                if (!Validacoes.VerificarDataMaiorOuIgualHoje(data.ToString("dd/MM/yyyy"), "de Agendamento"))
                {
                    txtData.Focus();
                    return;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string dCancelamento = new string(txtDataCancelamento.Texts.Where(char.IsDigit).ToArray());
            if (dCancelamento == "")
            {
                DialogResult result = MessageBox.Show("Você tem certeza que deseja cancelar o agendamento?",
                                          "Confirmação de Cancelamento",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int idAgenda = Convert.ToInt32(txtCodigo.Texts);
                    controllerAgenda.CancelarAgendamento(idAgenda);

                    cbSituacao.SelectedItem = "CANCELADO";
                    MessageBox.Show("Agendamento cancelado com sucesso!");
                    this.Close();
                }
            } else
            {
                MessageBox.Show("O agendamento já foi cancelado anteriormente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }
    }
}
