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

        public void BloqueiaTudo()
        {
            //bloqueia todos os campos de texto
            txtCodigo.Enabled = false;
            txtDataAvaliacao.Enabled = false;
            txtDataCadastro.Enabled = false;
            txtDataUltAlt.Enabled = false;
            txtCodAluno.Enabled = false;
            txtAluno.Enabled = false;
            btnPesquisarAluno.Enabled = false;

            //bloqueia campos dores
            txtCodDores.Enabled = false;
            txtDores.Enabled = false;
            txtDescricaoDores.Enabled = false;
            txtObservacoesDores.Enabled = false;
            btnPesquisarDores.Enabled = false;
            btnAdicionarDores.Enabled = false;

            //bloqueia campos doença
            txtCodDoenca.Enabled = false;
            txtDoenca.Enabled = false;
            txtCID.Enabled = false;
            txtDescricaoDoenca.Enabled = false;
            txtObservacoesDoenca.Enabled = false;
            btnPesquisarDoenca.Enabled = false;
             btnAdiconarDoenca.Enabled = false;

            //bloqueia campos medicamento
            txtCodMedicamento.Enabled = false;
            txtMedicamento.Enabled = false;
            txtFrequencia.Enabled = false;
            txtDosagem.Enabled = false;
            txtDescricaoMedicamento.Enabled = false;
            txtObservacoesMedicamento.Enabled = false;
            btnPesquisarMedicamento.Enabled = false;
            btnAdicionarMedicamento.Enabled = false;

            //bloqueia campos cirurgia
            txtCodCirurgia.Enabled = false;
            txtCirurgia.Enabled = false;
            txtDataDaCirurgia.Enabled = false;
            txtDescricaoCirurgia.Enabled = false;
            txtObservacoesCirurgia.Enabled = false;
            btnPesquisarCirurgia.Enabled = false;
            btnAdicionarCirurgia.Enabled = false;

            //bloqueia campos gestação
            txtCodGestacao.Enabled = false;
            txtGestacao.Enabled = false;
            txtDataDoParto.Enabled = false;
            txtDescricaoGestacao.Enabled = false;
            txtObservacoesGestacao.Enabled = false;
            btnPesquisarGestacao.Enabled = false;
            btnAdicionarGestacao.Enabled = false;

            //bloqueia os dgv
            dataGridViewDores.Enabled = false;
            dataGridViewCirurgia.Enabled = false;
            dataGridViewMedicamento.Enabled = false;
            dataGridViewDoenca.Enabled = false;
            dataGridViewGestacao.Enabled = false;

        }
        public override void Carrega()
        {
            BloqueiaTudo();
            base.Carrega();
            if (Alterar != -7)
            {
                var avaliacao = controllerAvaliacao.BuscarPorId(Alterar);
                if (avaliacao != null)
                {
                    txtCodigo.Texts = avaliacao.idAvaliacao.ToString();
                    txtDataAvaliacao.Texts = avaliacao.data.ToString();
                    rbAtivo.Checked = avaliacao.Ativo;
                    rbInativo.Checked = !avaliacao.Ativo;
                    txtDataCadastro.Texts = avaliacao.dataCadastro.ToString();
                    txtDataUltAlt.Texts = avaliacao.dataUltAlt.ToString();
                    txtCodAluno.Texts = avaliacao.idAluno.ToString();

                    ModelAluno aluno = controllerAluno.BuscarPorId(int.Parse(txtCodAluno.Texts));
                    if (aluno != null)
                    {
                        txtAluno.Texts = aluno.Aluno.ToString();
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
            if (dataGridViewDores.Rows.Count == 0 && dataGridViewCirurgia.Rows.Count == 0 &&
                dataGridViewMedicamento.Rows.Count == 0 && dataGridViewDoenca.Rows.Count == 0 &&
                dataGridViewGestacao.Rows.Count == 0)
            {
                MessageBox.Show("É necessário preencher pelo menos uma das listas antes de salvar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Validacoes.CampoObrigatorio(txtCodAluno.Texts))
            {
                MessageBox.Show("Campo Código aluno obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodAluno.Focus();
                return; 
            }
            try
            {
                DateTime.TryParse(txtDataAvaliacao.Texts, out DateTime dataavaliacao);
                int idAluno = Convert.ToInt32(txtCodAluno.Texts);
                DateTime.TryParse(txtDataCadastro.Texts, out DateTime datacadastro);
                DateTime dataUltAlt = Alterar != -7 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Texts, out DateTime result) ? result : DateTime.MinValue;

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
                txtDataAvaliacao.Texts = DateTime.Now.ToString();
                int novoCodigo = controllerAvaliacao.GetUltimoCodigo() + 1;
                txtCodigo.Texts = novoCodigo.ToString();
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

        private void CadastroAvaliacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaAvaliacao)this.Owner).AtualizarConsultaAvaliacoes(false);
        }

        private void btnAdicionarDores_Click(object sender, EventArgs e)
        {
            if (!Validacoes.CampoObrigatorio(txtCodDores.Texts))
            {
                MessageBox.Show("Campo Cód. Dores é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodDores.Focus();
            }
            else
            {
                try
                {
                    int codigoDores = Convert.ToInt32(txtCodDores.Texts);
                    string dores = txtDores.Texts;
                    string descricao = txtDescricaoDores.Texts;

                    //observação pode ser nula, então usa string vazia se for o caso
                    string observacao = string.IsNullOrEmpty(txtObservacoesDores.Texts) ? "" : txtObservacoesDores.Texts;

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

        private void btnAdiconarDoenca_Click(object sender, EventArgs e)
        {
            if (!Validacoes.CampoObrigatorio(txtCodDoenca.Texts))
            {
                MessageBox.Show("Campo Cód. Doença é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodDoenca.Focus();
            }
            else
            {
                try
                {
                    int codigoDoenca = Convert.ToInt32(txtCodDoenca.Texts);
                    string doenca = txtDoenca.Texts;
                    string cid = txtCID.Texts;
                    string descricao = txtDescricaoDoenca.Texts;

                    //observação pode ser nula, então usa string vazia se for o caso
                    string observacao = string.IsNullOrEmpty(txtObservacoesDoenca.Texts) ? "" : txtObservacoesDoenca.Texts;

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
            if (!Validacoes.CampoObrigatorio(txtCodMedicamento.Texts))
            {
                MessageBox.Show("Campo Cód. Medicamento é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodMedicamento.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtFrequencia.Texts))
            {
                MessageBox.Show("Campo Frequência é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFrequencia.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtDosagem.Texts))
            {
                MessageBox.Show("Campo Dosagem é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDosagem.Focus();
            }
            else
            {
                try
                {
                    int codigoMedicamento = Convert.ToInt32(txtCodMedicamento.Texts);
                    string medicamento = txtMedicamento.Texts;
                    string descricao = txtDescricaoMedicamento.Texts;
                    string frequencia = txtFrequencia.Texts;
                    string dosagem = txtDosagem.Texts;

                    //observação pode ser nula, então usa string vazia se for o caso
                    string observacao = string.IsNullOrEmpty(txtObservacoesMedicamento.Texts) ? "" : txtObservacoesMedicamento.Texts;

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
            if (!Validacoes.CampoObrigatorio(txtCodCirurgia.Texts))
            {
                MessageBox.Show("Campo Cód. Cirurgia é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodCirurgia.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtDataDaCirurgia.Texts))
            {
                MessageBox.Show("Campo Data Cirurgia é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDataDaCirurgia.Focus();
            }
            else
            {
                try
                {
                    int codigoCirurgia = Convert.ToInt32(txtCodCirurgia.Texts);
                    string cirurgia = txtCodCirurgia.Texts;
                    string descricao = txtDescricaoCirurgia.Texts;

                    //tentar converter o valor do MaskedTextBox para DateTime
                    if (!DateTime.TryParseExact(txtDataDaCirurgia.Texts, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataCirurgia))
                    {
                        MessageBox.Show("Data da cirurgia inválida. Por favor, insira no formato DD/MM/AAAA.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDataDaCirurgia.Focus();
                        return;
                    }

                    //observação pode ser nula, então usa string vazia se for o caso
                    string observacao = string.IsNullOrEmpty(txtObservacoesCirurgia.Texts) ? "" : txtObservacoesCirurgia.Texts;

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
            if (!Validacoes.CampoObrigatorio(txtCodGestacao.Texts))
            {
                MessageBox.Show("Campo Cód. Gestação é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodGestacao.Focus();
            }
            else
            {
                try
                {
                    int codigoGestacao = Convert.ToInt32(txtCodGestacao.Texts);
                    string gestacao = txtGestacao.Texts;
                    string descricao = txtDescricaoGestacao.Texts;

                    //variável para armazenar a data do parto, que pode ser nula
                    DateTime? dataParto = null;

                    //verifica se o campo de data não está vazio ou preenchido parcialmente
                    if (!string.IsNullOrWhiteSpace(txtDataDoParto.Texts) && txtDataDoParto.Texts != "  /  /")
                    {
                        //tenta converter a data de parto, se preenchida
                        if (!DateTime.TryParseExact(txtDataDoParto.Texts, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDataParto))
                        {
                            MessageBox.Show("Data do Parto inválida. Por favor, insira no formato DD/MM/AAAA.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtDataDoParto.Focus();
                            return;
                        }
                        dataParto = parsedDataParto; //atribui a data convertida
                    }

                    //observação pode ser nula, então usa string vazia se for o caso
                    string observacao = string.IsNullOrEmpty(txtObservacoesGestacao.Texts) ? "" : txtObservacoesGestacao.Texts;

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
            if (!string.IsNullOrEmpty(txtCodAluno.Texts))
            {
                ModelAluno aluno = controllerAluno.BuscarPorId(int.Parse(txtCodAluno.Texts));
                if (aluno != null)
                {
                    txtAluno.Texts = aluno.Aluno;
                }
                else
                {
                    MessageBox.Show("Aluno não encontrado(a).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodAluno.Focus();
                    txtCodAluno.Clear();
                    txtAluno.Clear();
                }
            }
        }

        private void txtCodDores_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodDores.Texts))
            {
                ModelDores dor = controllerDores.BuscarPorId(int.Parse(txtCodDores.Texts));
                if (dor != null)
                {
                    txtDores.Texts = dor.dores;
                    txtDescricaoDores.Texts = dor.descricao;
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
            if (!string.IsNullOrEmpty(txtCodDoenca.Texts))
            {
                ModelDoenca doenca = controllerDoenca.BuscarPorId(int.Parse(txtCodDoenca.Texts));
                if (doenca != null)
                {
                    txtDoenca.Texts = doenca.doenca;
                    txtDescricaoDoenca.Texts = doenca.descricao;
                    txtCID.Texts = doenca.CID;
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
            if (!string.IsNullOrEmpty(txtCodMedicamento.Texts))
            {
                ModelMedicamento medicamento = controllerMedicamento.BuscarPorId(int.Parse(txtCodMedicamento.Texts));
                if (medicamento != null)
                {
                    txtMedicamento.Texts = medicamento.medicamento;
                    txtDescricaoMedicamento.Texts = medicamento.descricao;
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
            if (!string.IsNullOrEmpty(txtCodCirurgia.Texts))
            {
                ModelCirurgia cirurgia = controllerCirurgia.BuscarPorId(int.Parse(txtCodCirurgia.Texts));
                if (cirurgia != null)
                {
                    txtCirurgia.Texts = cirurgia.cirurgia;
                    txtDescricaoCirurgia.Texts = cirurgia.descricao;
                }
                else
                {
                    MessageBox.Show("Cirurgia não encontrado(a).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodCirurgia.Focus();
                    txtCodCirurgia.Clear();
                    txtCodCirurgia.Clear();
                    txtDescricaoCirurgia.Clear();
                }
            }
        }

        private void txtCodGestacao_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodGestacao.Texts))
            {
                ModelGestacao gestacao = controllerGestacao.BuscarPorId(int.Parse(txtCodGestacao.Texts));
                if (gestacao != null)
                {
                    txtGestacao.Texts = gestacao.gestacao;
                    txtDescricaoGestacao.Texts = gestacao.descricao;
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

        private void btnPesquisarAluno_Click(object sender, EventArgs e)
        {
            consultaAluno.btnSair.Text = "Selecionar";

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

        private void txtCodDores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnPesquisarDores_Click(object sender, EventArgs e)
        {
            consultaDores.btnSair.Text = "Selecionar";
            consultaDores.cbInativos.Visible = false;

            if (consultaDores.ShowDialog() == DialogResult.OK)
            {
                var infosDores = consultaDores.Tag as Tuple<int, string, string>;
                if (infosDores != null)
                {
                    int idDores = infosDores.Item1;
                    string Dores = infosDores.Item2;
                    string Descricao = infosDores.Item3;

                    txtCodDores.Texts = idDores.ToString();
                    txtDores.Texts = Dores;
                    txtDescricaoDores.Texts = Descricao;

                }
            }
        }

        private void btnPesquisarDoenca_Click(object sender, EventArgs e)
        {
            consultaDoenca.btnSair.Text = "Selecionar";
            consultaDoenca.cbInativos.Visible = false;

            if (consultaDoenca.ShowDialog() == DialogResult.OK)
            {
                var infosDoenca = consultaDoenca.Tag as Tuple<int, string, string, string>;
                if (infosDoenca != null)
                {
                    int idDoenca = infosDoenca.Item1;
                    string Doenca = infosDoenca.Item2;
                    string Descricao = infosDoenca.Item3;
                    string CID = infosDoenca.Item4;

                    txtCodDoenca.Texts = idDoenca.ToString();
                    txtDoenca.Texts = Doenca;
                    txtDescricaoDoenca.Texts = Descricao;
                    txtCID.Texts = CID;
                }
            }
        }

        private void btnPesquisarMedicamento_Click(object sender, EventArgs e)
        {
            consultaMedicamento.btnSair.Text = "Selecionar";
            consultaMedicamento.cbInativos.Visible = false;

            if (consultaMedicamento.ShowDialog() == DialogResult.OK)
            {
                var infosMed = consultaMedicamento.Tag as Tuple<int, string, string>;
                if (infosMed != null)
                {
                    int idMed = infosMed.Item1;
                    string med = infosMed.Item2;
                    string Descricao = infosMed.Item3;

                    txtCodMedicamento.Texts = idMed.ToString();
                    txtMedicamento.Texts = med;
                    txtDescricaoMedicamento.Texts = Descricao;

                }
            }
        }

        private void btnPesquisarCirurgia_Click(object sender, EventArgs e)
        {
            consultaCirurgia.btnSair.Text = "Selecionar";
            consultaCirurgia.cbInativos.Visible = false;

            if (consultaCirurgia.ShowDialog() == DialogResult.OK)
            {
                var infosCirurgia = consultaCirurgia.Tag as Tuple<int, string, string>;
                if (infosCirurgia != null)
                {
                    int idCirurgia = infosCirurgia.Item1;
                    string cirurgia = infosCirurgia.Item2;
                    string Descricao = infosCirurgia.Item3;

                    txtCodCirurgia.Texts = idCirurgia.ToString();
                    txtCirurgia.Texts = cirurgia;
                    txtDescricaoCirurgia.Texts = Descricao;

                }
            }
        }

        private void btnPesquisarGestacao_Click(object sender, EventArgs e)
        {
            consultaGestacao.btnSair.Text = "Selecionar";
            consultaGestacao.cbInativos.Visible = false;

            if (consultaGestacao.ShowDialog() == DialogResult.OK)
            {
                var infosGestacao = consultaGestacao.Tag as Tuple<int, string, string>;
                if (infosGestacao != null)
                {
                    int idGestacao = infosGestacao.Item1;
                    string gestacao = infosGestacao.Item2;
                    string Descricao = infosGestacao.Item3;

                    txtCodGestacao.Texts = idGestacao.ToString();
                    txtGestacao.Texts = gestacao;
                    txtDescricaoGestacao.Texts = Descricao;

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

        private void txtDataDaCirurgia_Leave(object sender, EventArgs e)
        {
            DateTime dataCirurgia;
            string dataC = new string(txtDataDaCirurgia.Texts.Where(char.IsDigit).ToArray());
            bool dataValida = DateTime.TryParse(txtDataDaCirurgia.Texts, out dataCirurgia);

            if (!string.IsNullOrEmpty(dataC))
            {
                if (!dataValida)
                {
                    MessageBox.Show("Data de Cirurgia inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDataDaCirurgia.Focus();
                    return;
                }
                if (!Validacoes.VerificarDataMenorOuIgualHoje(dataCirurgia.ToString("dd/MM/yyyy"), "Cirurgia"))
                {
                    txtDataDaCirurgia.Focus();
                    return;
                }
            }
        }

        private void txtDataDoParto_Leave(object sender, EventArgs e)
        {
            DateTime dataParto;
            string dataP = new string(txtDataDoParto.Texts.Where(char.IsDigit).ToArray());
            bool dataValida = DateTime.TryParse(txtDataDoParto.Texts, out dataParto);

            if (!string.IsNullOrEmpty(dataP))
            {
                if (!dataValida)
                {
                    MessageBox.Show("Data do Parto inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDataDoParto.Focus();
                    return;
                }
                if (!Validacoes.VerificarDataMenorOuIgualHoje(dataParto.ToString("dd/MM/yyyy"), "Parto"))
                {
                    txtDataDoParto.Focus();
                    return;
                }
            }
        }

        private void txtFrequencia_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFrequencia.Texts))
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(txtFrequencia.Texts.TrimStart('0')))
            {
                MessageBox.Show("A frequência não pode ser 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFrequencia.Focus();
            }
        }

        private void txtDosagem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDosagem.Texts))
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDosagem.Texts.TrimStart('0')))
            {
                MessageBox.Show("A dosagem não pode ser 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDosagem.Focus();
            }
        }

        private void btnExcluirDores_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewDores.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridViewDores.SelectedRows)
                    {
                        dataGridViewDores.Rows.Remove(row);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione uma Dor para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir Dor: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluirMedicamento_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMedicamento.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridViewMedicamento.SelectedRows)
                    {
                        dataGridViewMedicamento.Rows.Remove(row);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um Medicamento para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir Medicamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluirDoenca_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewDoenca.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridViewDoenca.SelectedRows)
                    {
                        dataGridViewDoenca.Rows.Remove(row);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione uma Doença para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir Doença: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluirCirurgia_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewCirurgia.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridViewCirurgia.SelectedRows)
                    {
                        dataGridViewCirurgia.Rows.Remove(row);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione uma Cirurgia para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir Cirurgia: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluirGestacao_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewGestacao.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridViewGestacao.SelectedRows)
                    {
                        dataGridViewGestacao.Rows.Remove(row);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione uma Gestação para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir Gestação: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
