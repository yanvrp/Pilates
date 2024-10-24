using Pilates.Controller;
using Pilates.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pilates.Views
{
    public partial class CadastroAvaliacao : Pilates.Views.CadastroPAI
    {
        private ConsultaDores consultaDores;
        private ConsultaDoenca consultaDoenca;
        private ConsultaGestacao consultaGestacao;
        private ConsultaCirurgia consultaCirurgia;
        private ConsultaMedicamento consultaMedicamento;
        private ConsultaAluno consultaAluno;
        private ControllerDores<ModelDores> controllerDores;
        private ControllerDoenca<ModelDoenca> controllerDoenca;
        private ControllerGestacao<ModelGestacao> controllerGestacao;
        private ControllerCirurgia<ModelCirurgia> controllerCirurgia;
        private ControllerMedicamento<ModelMedicamento> controllerMedicamento;
        private ControllerAluno<ModelAluno> controllerAluno;
        private ControllerAvaliacao<ModelAvaliacao> controllerAvaliacao;
        public CadastroAvaliacao()
        {
            InitializeComponent();
            consultaDores = new ConsultaDores();
            consultaDoenca = new ConsultaDoenca();
            consultaGestacao = new ConsultaGestacao();
            consultaCirurgia = new ConsultaCirurgia();
            consultaMedicamento = new ConsultaMedicamento();
            controllerDores = new ControllerDores<ModelDores>();
            controllerDoenca = new ControllerDoenca<ModelDoenca>();
            controllerGestacao = new ControllerGestacao<ModelGestacao>();
            controllerCirurgia = new ControllerCirurgia<ModelCirurgia>();
            controllerMedicamento = new ControllerMedicamento<ModelMedicamento>();
            consultaAluno = new ConsultaAluno();
            controllerAluno = new ControllerAluno<ModelAluno>();
            controllerAvaliacao = new ControllerAvaliacao<ModelAvaliacao>();
            txtCodAluno.Focus();
        }
        public CadastroAvaliacao(int idAvaliacao) : this()
        {
            Alterar = idAvaliacao;
            Carrega();
        }
        public override void Carrega()
        {
            base.Carrega();
            if (Alterar != -7)
            {
                var avaliacao = controllerAvaliacao.BuscarPorId(Alterar);
                if (avaliacao != null)
                {
                    txtCodigo.Text = avaliacao.idAvaliacao.ToString();
                    txtDataAvaliacao.Text = avaliacao.data.ToString();
                    rbAtivo.Checked = avaliacao.Ativo;
                    rbInativo.Checked = !avaliacao.Ativo;
                    txtDataCadastro.Text = avaliacao.dataCadastro.ToString();
                    txtDataUltAlt.Text = avaliacao.dataUltAlt.ToString();
                    txtCodAluno.Text = avaliacao.idAluno.ToString();

                    ModelAluno aluno = controllerAluno.BuscarPorId(int.Parse(txtCodAluno.Text));
                    if (aluno != null)
                    {
                        txtAluno.Text = aluno.Aluno.ToString();
                    }
                    exibirCirurgiaDGV(avaliacao.Cirurgia);
                    exibirDoencaDGV(avaliacao.Doenca);
                    exibirDoresDGV(avaliacao.Dores);
                    exibirGestacaoDGV(avaliacao.Gestacao);
                    exibirMedicamentoDGV(avaliacao.Medicamento);
                }
            }
        }

        public override void Salvar()
        {
            if (!Validacoes.CampoObrigatorio(txtCodAluno.Text))
            {
                MessageBox.Show("Campo Código aluno obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodAluno.Focus();
            }
            else
            {
                try
                {
                    DateTime.TryParse(txtDataAvaliacao.Text, out DateTime dataavaliacao);
                    int idAluno = Convert.ToInt32(txtCodAluno.Text);
                    DateTime.TryParse(txtDataCadastro.Text, out DateTime datacadastro);
                    DateTime dataUltAlt = Alterar != -7 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Text, out DateTime result) ? result : DateTime.MinValue;

                    ModelAvaliacao avaliacao = new ModelAvaliacao
                    {
                        data = dataavaliacao,
                        idAluno = idAluno,
                        dataCadastro = datacadastro,
                        dataUltAlt = dataUltAlt,
                        Ativo = Ativo,
                        Cirurgia = obtemCirurgia(),
                        Doenca = obtemDoenca(),
                        Dores = obtemDores(),
                        Gestacao = obtemGestacao(),
                        Medicamento = obtemMedicamento(),
                    };
                    if (Alterar == -7)
                    {
                        controllerAvaliacao.Salvar(avaliacao);
                    }
                    else 
                    {
                        avaliacao.idAvaliacao = Alterar;
                        controllerAvaliacao.Alterar(avaliacao);
                    }
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private List<ModelAvaliacaoDores> obtemDores()
        {
            List<ModelAvaliacaoDores> dores = new List<ModelAvaliacaoDores>();

            foreach (DataGridViewRow row in dataGridViewDores.Rows)
            {
                string observacao = row.Cells["ObservaçãoDores"].Value.ToString();

                ModelAvaliacaoDores dor = new ModelAvaliacaoDores
                {
                    observacao = observacao,
                    idDores = Convert.ToInt32(row.Cells["CódigoDores"].Value),
                };

                dores.Add(dor);
            }

            return dores;
        }
        private List<ModelAvaliacaoMedicamento> obtemMedicamento()
        {
            List<ModelAvaliacaoMedicamento> medicamentos = new List<ModelAvaliacaoMedicamento>();

            foreach (DataGridViewRow row in dataGridViewMedicamento.Rows)
            {
                string observacao = row.Cells["ObservaçãoMedicamento"].Value.ToString();
                string frequencia = row.Cells["Frequencia"].Value.ToString();
                string dosagem = row.Cells["Dosagem"].Value.ToString();

                ModelAvaliacaoMedicamento medicamento = new ModelAvaliacaoMedicamento
                {
                    observacao = observacao,
                    frequencia=frequencia,
                    dosagem = dosagem,
                    idMedicamento = Convert.ToInt32(row.Cells["CódigoMedicamento"].Value),
                };

                medicamentos.Add(medicamento);
            }

            return medicamentos;
        }
        private List<ModelAvaliacaoDoenca> obtemDoenca()
        {
            List<ModelAvaliacaoDoenca> doencas = new List<ModelAvaliacaoDoenca>();

            foreach (DataGridViewRow row in dataGridViewDoenca.Rows)
            {
                string observacao = row.Cells["ObservaçãoDoença"].Value.ToString();

                ModelAvaliacaoDoenca doenca = new ModelAvaliacaoDoenca
                {
                    observacao = observacao,
                    idDoenca = Convert.ToInt32(row.Cells["CódigoDoença"].Value),
                };

                doencas.Add(doenca);
            }

            return doencas;
        }
        private List<ModelAvaliacaoCirurgia> obtemCirurgia()
        {
            List<ModelAvaliacaoCirurgia> cirurgias = new List<ModelAvaliacaoCirurgia>();

            foreach (DataGridViewRow row in dataGridViewCirurgia.Rows)
            {
                string observacao = row.Cells["ObservaçãoCirurgia"].Value.ToString();
                DateTime dataCirurgia = Convert.ToDateTime(row.Cells["DataCirurgia"].Value);

                ModelAvaliacaoCirurgia cirurgia = new ModelAvaliacaoCirurgia
                {
                    observacao = observacao,
                    dataCirurgia = dataCirurgia,
                    idCirurgia = Convert.ToInt32(row.Cells["CódigoCirurgia"].Value),
                };

                cirurgias.Add(cirurgia);
            }

            return cirurgias;
        }
        private List<ModelAvaliacaoGestacao> obtemGestacao()
        {
            List<ModelAvaliacaoGestacao> gestacaos = new List<ModelAvaliacaoGestacao>();

            foreach (DataGridViewRow row in dataGridViewGestacao.Rows)
            {
                string observacao = row.Cells["ObservaçãoGestação"].Value?.ToString();
                DateTime? dataParto = null;

                if (row.Cells["DataParto"].Value != null)
                {
                    dataParto = Convert.ToDateTime(row.Cells["DataParto"].Value);
                }

                ModelAvaliacaoGestacao gestacao = new ModelAvaliacaoGestacao
                {
                    observacao = observacao,
                    dataParto = dataParto,
                    idGestacao = Convert.ToInt32(row.Cells["CódigoGestação"].Value),
                };

                gestacaos.Add(gestacao);
            }

            return gestacaos;
        }

        private void exibirDoresDGV(List<ModelAvaliacaoDores> dores)
        {
            dataGridViewDores.Rows.Clear();

            // Verifica se a lista de dores está vazia
            if (dores == null || !dores.Any())
                return;

            foreach (var dor in dores)
            {
                ModelDores doresDetalhes = controllerAvaliacao.BuscarDoresPorId(dor.idDores);

                if (doresDetalhes != null)
                {
                    dataGridViewDores.Rows.Add(
                        dor.idDores,      
                        doresDetalhes.dores,
                        doresDetalhes.descricao,
                        dor.observacao
                    );
                }
            }

            if (dataGridViewDores.Columns.Contains("CódigoDores"))
            {
                dataGridViewDores.Sort(dataGridViewDores.Columns["CódigoDores"], ListSortDirection.Ascending);
            }
        }

        private void exibirDoencaDGV(List<ModelAvaliacaoDoenca> doencas)
        {
            dataGridViewDoenca.Rows.Clear();

            if (doencas == null || !doencas.Any())
                return;

            foreach (var doenca in doencas)
            {
                ModelDoenca doencaDetalhes = controllerAvaliacao.BuscarDoencaPorId(doenca.idDoenca);

                if (doencaDetalhes != null)
                {
                    dataGridViewDoenca.Rows.Add(
                        doenca.idDoenca,
                        doencaDetalhes.doenca,
                        doencaDetalhes.descricao,
                        doencaDetalhes.CID,
                        doenca.observacao
                    );
                }
            }

            if (dataGridViewDoenca.Columns.Contains("CódigoDoença"))
            {
                dataGridViewDoenca.Sort(dataGridViewDoenca.Columns["CódigoDoença"], ListSortDirection.Ascending);
            }
        }

        private void exibirCirurgiaDGV(List<ModelAvaliacaoCirurgia> cirurgias)
        {
            dataGridViewCirurgia.Rows.Clear();

            if (cirurgias == null || !cirurgias.Any())
                return;

            foreach (var cirurgia in cirurgias)
            {
                ModelCirurgia cirurgiaDetalhes = controllerAvaliacao.BuscarCirurgiaPorId(cirurgia.idCirurgia);

                if (cirurgiaDetalhes != null)
                {
                    dataGridViewCirurgia.Rows.Add(
                        cirurgia.idCirurgia,
                        cirurgiaDetalhes.cirurgia,
                        cirurgiaDetalhes.descricao,
                        cirurgia.dataCirurgia,
                        cirurgia.observacao
                    );
                }
            }

            if (dataGridViewCirurgia.Columns.Contains("CódigoCirurgia"))
            {
                dataGridViewCirurgia.Sort(dataGridViewCirurgia.Columns["CódigoCirurgia"], ListSortDirection.Ascending);
            }
        }

        private void exibirGestacaoDGV(List<ModelAvaliacaoGestacao> gestacoes)
        {
            dataGridViewGestacao.Rows.Clear();

            if (gestacoes == null || !gestacoes.Any())
                return;

            foreach (var gestacao in gestacoes)
            {
                ModelGestacao gestacaoDetalhes = controllerAvaliacao.BuscarGestacaoPorId(gestacao.idGestacao);

                if (gestacaoDetalhes != null)
                {
                    dataGridViewGestacao.Rows.Add(
                        gestacao.idGestacao,
                        gestacaoDetalhes.gestacao,
                        gestacaoDetalhes.descricao,
                        gestacao.dataParto,
                        gestacao.observacao
                    );
                }
            }

            if (dataGridViewGestacao.Columns.Contains("CódigoGestação"))
            {
                dataGridViewGestacao.Sort(dataGridViewGestacao.Columns["CódigoGestação"], ListSortDirection.Ascending);
            }
        }

        private void exibirMedicamentoDGV(List<ModelAvaliacaoMedicamento> medicamentos)
        {
            dataGridViewMedicamento.Rows.Clear();

            if (medicamentos == null || !medicamentos.Any())
                return;

            foreach (var medicamento in medicamentos)
            {
                ModelMedicamento medicamentoDetalhes = controllerAvaliacao.BuscarMedicamentoPorId(medicamento.idMedicamento);

                if (medicamentoDetalhes != null)
                {
                    dataGridViewMedicamento.Rows.Add(
                        medicamento.idMedicamento,
                        medicamentoDetalhes.medicamento,
                        medicamentoDetalhes.descricao,
                        medicamento.dosagem,
                        medicamento.frequencia,
                        medicamento.observacao
                    );
                }
            }

            if (dataGridViewMedicamento.Columns.Contains("CódigoMedicamento"))
            {
                dataGridViewMedicamento.Sort(dataGridViewMedicamento.Columns["CódigoMedicamento"], ListSortDirection.Ascending);
            }
        }

        private void CadastroAvaliacao_Load(object sender, EventArgs e)
        {
            if(Alterar == -7)
            {
                txtDataAvaliacao.Text = DateTime.Now.ToString();
                int novoCodigo = controllerAvaliacao.GetUltimoCodigo() + 1;
                txtCodigo.Text = novoCodigo.ToString();
            }
        }

        private void limpaCamposDores()
        {
            txtCodDores.Clear();
            txtDores.Clear();
            txtDescricaoDores.Clear();
            txtObservacoesDores.Clear();
        }
        private void limpaCamposDoenca()
        {
            txtCodDoenca.Clear();
            txtDoenca.Clear();
            txtDescricaoDoenca.Clear();
            txtObservacoesDoenca.Clear();
        }
        private void limpaCamposMedicamento()
        {
            txtCodMedicamento.Clear();
            txtMedicamento.Clear();
            txtFrequencia.Clear();
            txtDosagem.Clear();
            txtDescricaoMedicamento.Clear();
            txtObservacoesMedicamento.Clear();
        }
        private void limpaCamposGestacao()
        {
            txtCodGestacao.Clear();
            txtGestacao.Clear();
            txtDataDoParto.Clear();
            txtDescricaoGestacao.Clear();
            txtObservacoesGestacao.Clear();
        }
        private void limpaCamposCirurgia()
        {
            txtCodCirurgia.Clear();
            txtCirurgia.Clear();
            txtDataDaCirurgia.Clear();
            txtDescricaoCirurgia.Clear();
            txtObservacoesCirurgia.Clear();
        }
        private void btnAdicionarDores_Click(object sender, EventArgs e)
        {
            if (!Validacoes.CampoObrigatorio(txtCodDores.Text))
            {
                MessageBox.Show("Campo Cód. Dores é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodDores.Focus();
            }
            else
            {
                try
                {
                    int codigoDores = Convert.ToInt32(txtCodDores.Text);
                    string dores = txtDores.Text;
                    string descricao = txtDescricaoDores.Text;

                    //observação pode ser nula, então usa string vazia se for o caso
                    string observacao = string.IsNullOrEmpty(txtObservacoesDores.Text) ? "" : txtObservacoesDores.Text;

                    bool doresExistente = false;

                    foreach (DataGridViewRow row in dataGridViewDores.Rows)
                    {
                        if (row.Cells["CódigoDores"].Value != null && Convert.ToInt32(row.Cells["CódigoDores"].Value) == codigoDores)
                        {
                            doresExistente = true;
                            MessageBox.Show("Dor já adicionada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }

                    if (!doresExistente)
                    {
                        dataGridViewDores.Rows.Add(codigoDores, dores, descricao, observacao);
                    }

                    dataGridViewDores.Sort(dataGridViewDores.Columns["CódigoDores"], ListSortDirection.Ascending);
                    limpaCamposDores();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar Dores: " + ex.Message);
                }
            }
        }

        private void btnAdicionarDoenca_Click(object sender, EventArgs e)
        {
            if (!Validacoes.CampoObrigatorio(txtCodDoenca.Text))
            {
                MessageBox.Show("Campo Cód. Doença é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodDoenca.Focus();
            }
            else
            {
                try
                {
                    int codigoDoenca = Convert.ToInt32(txtCodDoenca.Text);
                    string doenca = txtDoenca.Text;
                    string cid = txtCID.Text;
                    string descricao = txtDescricaoDoenca.Text;

                    //observação pode ser nula, então usa string vazia se for o caso
                    string observacao = string.IsNullOrEmpty(txtObservacoesDoenca.Text) ? "" : txtObservacoesDoenca.Text;

                    bool doencaExistente = false;

                    foreach (DataGridViewRow row in dataGridViewDoenca.Rows)
                    {
                        if (row.Cells["CódigoDoença"].Value != null && Convert.ToInt32(row.Cells["CódigoDoença"].Value) == codigoDoenca)
                        {
                            doencaExistente = true;
                            MessageBox.Show("Doença já adicionada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }

                    if (!doencaExistente)
                    {
                        dataGridViewDoenca.Rows.Add(codigoDoenca, doenca, descricao, cid, observacao);
                    }

                    dataGridViewDoenca.Sort(dataGridViewDoenca.Columns["CódigoDoença"], ListSortDirection.Ascending);
                    limpaCamposDoenca();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar Doença: " + ex.Message);
                }
            }
        }

        private void btnAdicionarMedicamento_Click(object sender, EventArgs e)
        {
            if (!Validacoes.CampoObrigatorio(txtCodMedicamento.Text))
            {
                MessageBox.Show("Campo Cód. Medicamento é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodMedicamento.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtFrequencia.Text))
            {
                MessageBox.Show("Campo Frequência é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFrequencia.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtDosagem.Text))
            {
                MessageBox.Show("Campo Dosagem é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDosagem.Focus();
            }
            else
            {
                try
                {
                    int codigoMedicamento = Convert.ToInt32(txtCodMedicamento.Text);
                    string medicamento = txtMedicamento.Text;
                    string descricao = txtDescricaoMedicamento.Text;
                    string frequencia = txtFrequencia.Text;
                    string dosagem = txtDosagem.Text;

                    //observação pode ser nula, então usa string vazia se for o caso
                    string observacao = string.IsNullOrEmpty(txtObservacoesMedicamento.Text) ? "" : txtObservacoesMedicamento.Text;

                    bool medicamentoExistente = false;

                    foreach (DataGridViewRow row in dataGridViewMedicamento.Rows)
                    {
                        if (row.Cells["CódigoMedicamento"].Value != null && Convert.ToInt32(row.Cells["CódigoMedicamento"].Value) == codigoMedicamento)
                        {
                            medicamentoExistente = true;
                            MessageBox.Show("Medicamento já adicionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }

                    if (!medicamentoExistente)
                    {
                        dataGridViewMedicamento.Rows.Add(codigoMedicamento, medicamento, descricao, dosagem, frequencia, observacao);
                    }

                    dataGridViewMedicamento.Sort(dataGridViewMedicamento.Columns["CódigoMedicamento"], ListSortDirection.Ascending);
                    limpaCamposMedicamento();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar Medicamento: " + ex.Message);
                }
            }
        }

        private void btnAdicionarCirurgia_Click(object sender, EventArgs e)
        {
            if (!Validacoes.CampoObrigatorio(txtCodCirurgia.Text))
            {
                MessageBox.Show("Campo Cód. Cirurgia é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodCirurgia.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtDataDaCirurgia.Text))
            {
                MessageBox.Show("Campo Data Cirurgia é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDataDaCirurgia.Focus();
            }
            else
            {
                try
                {
                    int codigoCirurgia = Convert.ToInt32(txtCodCirurgia.Text);
                    string cirurgia = txtCirurgia.Text;
                    string descricao = txtDescricaoCirurgia.Text;

                    //tentar converter o valor do MaskedTextBox para DateTime
                    if (!DateTime.TryParseExact(txtDataDaCirurgia.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataCirurgia))
                    {
                        MessageBox.Show("Data da cirurgia inválida. Por favor, insira no formato DD/MM/AAAA.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDataDaCirurgia.Focus();
                        return;
                    }

                    //observação pode ser nula, então usa string vazia se for o caso
                    string observacao = string.IsNullOrEmpty(txtObservacoesCirurgia.Text) ? "" : txtObservacoesCirurgia.Text;

                    bool cirurgiaExistente = false;

                    //verifica se já existe uma cirurgia com os mesmos dados (não apenas o código)
                    foreach (DataGridViewRow row in dataGridViewCirurgia.Rows)
                    {
                        if (row.Cells["CódigoCirurgia"].Value != null &&
                            Convert.ToInt32(row.Cells["CódigoCirurgia"].Value) == codigoCirurgia &&
                            row.Cells["Cirurgia"].Value.ToString() == cirurgia &&
                            row.Cells["DescriçãoCirurgia"].Value.ToString() == descricao &&
                            row.Cells["DataCirurgia"].Value.ToString() == dataCirurgia.ToString("dd/MM/yyyy") &&
                            row.Cells["Observacao"].Value.ToString() == observacao)
                        {
                            cirurgiaExistente = true;
                            MessageBox.Show("Cirurgia com os mesmos detalhes já adicionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }

                    if (!cirurgiaExistente)
                    {
                        dataGridViewCirurgia.Rows.Add(codigoCirurgia, cirurgia, descricao, dataCirurgia.ToString("dd/MM/yyyy"), observacao);
                    }

                    dataGridViewCirurgia.Sort(dataGridViewCirurgia.Columns["CódigoCirurgia"], ListSortDirection.Ascending);
                    limpaCamposCirurgia();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar Cirurgia: " + ex.Message);
                }
            }
        }

        private void btnAdicionarGestacao_Click(object sender, EventArgs e)
        {
            if (!Validacoes.CampoObrigatorio(txtCodGestacao.Text))
            {
                MessageBox.Show("Campo Cód. Gestação é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodGestacao.Focus();
            }
            else
            {
                try
                {
                    int codigoGestacao = Convert.ToInt32(txtCodGestacao.Text);
                    string gestacao = txtGestacao.Text;
                    string descricao = txtDescricaoGestacao.Text;

                    //variável para armazenar a data do parto, que pode ser nula
                    DateTime? dataParto = null;

                    //verifica se o campo de data não está vazio ou preenchido parcialmente
                    if (!string.IsNullOrWhiteSpace(txtDataDoParto.Text) && txtDataDoParto.Text != "  /  /")
                    {
                        //tenta converter a data de parto, se preenchida
                        if (!DateTime.TryParseExact(txtDataDoParto.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDataParto))
                        {
                            MessageBox.Show("Data do Parto inválida. Por favor, insira no formato DD/MM/AAAA.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtDataDoParto.Focus();
                            return;
                        }
                        dataParto = parsedDataParto; //atribui a data convertida
                    }

                    //observação pode ser nula, então usa string vazia se for o caso
                    string observacao = string.IsNullOrEmpty(txtObservacoesGestacao.Text) ? "" : txtObservacoesGestacao.Text;

                    bool dadosExistentes = false;

                    //verifica se já existe um registro com o mesmo código, data de parto e descrição
                    foreach (DataGridViewRow row in dataGridViewGestacao.Rows)
                    {
                        if (row.Cells["CódigoGestação"].Value != null &&
                            Convert.ToInt32(row.Cells["CódigoGestação"].Value) == codigoGestacao &&
                            row.Cells["Gestação"].Value.ToString() == gestacao &&
                            row.Cells["DescriçãoGestação"].Value.ToString() == descricao &&
                            row.Cells["DataParto"].Value?.ToString() == (dataParto.HasValue ? dataParto.Value.ToString("dd/MM/yyyy") : ""))
                        {
                            dadosExistentes = true;
                            MessageBox.Show("Gestação já adicionada com os mesmos detalhes.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }

                    if (!dadosExistentes)
                    {
                        string dataPartoFormatted = dataParto.HasValue ? dataParto.Value.ToString("dd/MM/yyyy") : null;
                        dataGridViewGestacao.Rows.Add(codigoGestacao, gestacao, descricao, dataPartoFormatted, observacao);
                    }

                    dataGridViewGestacao.Sort(dataGridViewGestacao.Columns["CódigoGestação"], ListSortDirection.Ascending);
                    limpaCamposGestacao();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar Gestação: " + ex.Message);
                }
            }
        }

        private void txtCodAluno_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodAluno.Text))
            {
                ModelAluno aluno = controllerAluno.BuscarPorId(int.Parse(txtCodAluno.Text));
                if (aluno != null)
                {
                    txtAluno.Text = aluno.Aluno;
                }
                else
                {
                    MessageBox.Show("Aluno não encontrado(a).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodAluno.Focus();
                    txtCodAluno.Clear();
                    txtCodAluno.Clear();
                }
            }
        }

        private void txtCodDores_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodDores.Text))
            {
                ModelDores dor = controllerDores.BuscarPorId(int.Parse(txtCodDores.Text));
                if (dor != null)
                {
                    txtDores.Text = dor.dores;
                    txtDescricaoDores.Text = dor.descricao;
                }
                else
                {
                    MessageBox.Show("Dor não encontrado(a).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodDores.Focus();
                    txtCodDores.Clear();
                    txtDores.Clear();
                    txtDescricaoDores.Clear();
                }
            }
        }

        private void txtCodDoenca_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodDoenca.Text))
            {
                ModelDoenca doenca = controllerDoenca.BuscarPorId(int.Parse(txtCodDoenca.Text));
                if (doenca != null)
                {
                    txtDoenca.Text = doenca.doenca;
                    txtDescricaoDoenca.Text = doenca.descricao;
                    txtCID.Text = doenca.CID;
                }
                else
                {
                    MessageBox.Show("Doença não encontrado(a).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodDoenca.Focus();
                    txtCodDoenca.Clear();
                    txtDoenca.Clear();
                    txtDescricaoDoenca.Clear();
                    txtCID.Clear();
                }
            }
        }

        private void txtCodMedicamento_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodMedicamento.Text))
            {
                ModelMedicamento medicamento = controllerMedicamento.BuscarPorId(int.Parse(txtCodMedicamento.Text));
                if (medicamento != null)
                {
                    txtMedicamento.Text = medicamento.medicamento;
                    txtDescricaoMedicamento.Text = medicamento.descricao;
                }
                else
                {
                    MessageBox.Show("Medicamento não encontrado(a).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodMedicamento.Focus();
                    txtCodMedicamento.Clear();
                    txtMedicamento.Clear();
                    txtDescricaoMedicamento.Clear();
                }
            }
        }

        private void txtCodCirurgia_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodCirurgia.Text))
            {
                ModelCirurgia cirurgia = controllerCirurgia.BuscarPorId(int.Parse(txtCodCirurgia.Text));
                if (cirurgia != null)
                {
                    txtCirurgia.Text = cirurgia.cirurgia;
                    txtDescricaoCirurgia.Text = cirurgia.descricao;
                }
                else
                {
                    MessageBox.Show("Cirurgia não encontrado(a).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodCirurgia.Focus();
                    txtCodCirurgia.Clear();
                    txtCirurgia.Clear();
                    txtDescricaoCirurgia.Clear();
                }
            }
        }

        private void txtCodGestacao_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodGestacao.Text))
            {
                ModelGestacao gestacao = controllerGestacao.BuscarPorId(int.Parse(txtCodGestacao.Text));
                if (gestacao != null)
                {
                    txtGestacao.Text = gestacao.gestacao;
                    txtDescricaoGestacao.Text = gestacao.descricao;
                }
                else
                {
                    MessageBox.Show("Gestação não encontrado(a).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodGestacao.Focus();
                    txtCodGestacao.Clear();
                    txtGestacao.Clear();
                    txtDescricaoGestacao.Clear();
                }
            }
        }

        private void CadastroAvaliacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaAvaliacao)this.Owner).AtualizarConsultaAvaliacoes(false);
        }
    }
}
