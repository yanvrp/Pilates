﻿using Pilates.Controller;
using Pilates.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pilates.Views
{
    public partial class CadastroCondicaoDePagamento : Pilates.Views.CadastroPAI
    {
        private ControllerCondicaoPagamento<ModelCondicaoPagamento> controllerCondicaoPagamento;
        private ConsultaFormaPagamento consultaFormaPagamento;
        private ControllerFormaPagamento<ModelFormaPagamento> controllerFormaPagamento;
        public CadastroCondicaoDePagamento()
        {
            InitializeComponent();
            controllerFormaPagamento = new ControllerFormaPagamento<ModelFormaPagamento>();
            controllerCondicaoPagamento = new ControllerCondicaoPagamento<ModelCondicaoPagamento>();
            consultaFormaPagamento = new ConsultaFormaPagamento();
        }
        public CadastroCondicaoDePagamento(int idCondicaoPagamento) : this()
        {
            Alterar = idCondicaoPagamento;
            Carrega();
        }
        public void limpaCamposParcelas()
        {
            txtNumParcelas.Clear();
            txtPorcentagem.Clear();
            txtCodigoPagamento.Clear();
            txtFormaPagamento.Clear();
        }
        public override void Salvar()
        {
            if (!string.IsNullOrEmpty(txtPorcentagemTotal.Text))
            {
                decimal porcentagem = Convert.ToDecimal(txtPorcentagemTotal.Text);
                if (porcentagem != 100)
                {
                    MessageBox.Show("A porcentagem total deve ser igual a 100%.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (!Validacoes.CampoObrigatorio(txtCondicaoPagamento.Text))
            {
                MessageBox.Show("Campo Condição de Pagamento é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCondicaoPagamento.Focus();
            }
            else if (dataGridViewParcelas.Rows.Count == 0) //verifica se tem pelo menos uma parcela
            {
                MessageBox.Show("É necessário adicionar pelo menos uma parcela.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string condPagamento = txtCondicaoPagamento.Text;
                    decimal desconto = Convert.ToDecimal(txtDesconto.Text);
                    decimal juros = Convert.ToDecimal(txtJuros.Text);
                    decimal multa = Convert.ToDecimal(txtMulta.Text);
                    DateTime.TryParse(txtDataCadastro.Text, out DateTime dataCadastro);
                    DateTime dataUltAlt = Alterar != -7 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Text, out DateTime result) ? result : DateTime.MinValue;

                    ModelCondicaoPagamento NovaCondPagamento = new ModelCondicaoPagamento
                    {
                        condicaoPagamento = condPagamento,
                        desconto = desconto,
                        juros = juros,
                        multa = multa,
                        Ativo = Ativo,
                        dataCadastro = dataCadastro,
                        dataUltAlt = dataUltAlt,
                        Parcelas = obtemParcelas()
                    };
                    if (Alterar == -7)
                    {
                        controllerCondicaoPagamento.Salvar(NovaCondPagamento);
                    }
                    else
                    {
                        NovaCondPagamento.idCondPagamento = Alterar;
                        controllerCondicaoPagamento.Alterar(NovaCondPagamento);
                    }
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public override void Carrega()
        {
            base.Carrega();
            var condicaoPagamento = controllerCondicaoPagamento.BuscarPorId(Alterar);
            if (condicaoPagamento != null)
            {
                txtCodigo.Text = condicaoPagamento.idCondPagamento.ToString();
                txtCondicaoPagamento.Text = condicaoPagamento.condicaoPagamento;
                txtJuros.Text = condicaoPagamento.juros.ToString();
                txtMulta.Text = condicaoPagamento.multa.ToString();
                txtDesconto.Text = condicaoPagamento.desconto.ToString();
                txtDataCadastro.Text = condicaoPagamento.dataCadastro.ToString();
                txtDataUltAlt.Text = condicaoPagamento.dataUltAlt.ToString();
                rbAtivo.Checked = condicaoPagamento.Ativo;
                exibirParcelasDGV(condicaoPagamento.Parcelas);
                atualizaPorcentagemTotal();
            }
        }
        private List<ModelParcela> obtemParcelas()
        {
            List<ModelParcela> parcelas = new List<ModelParcela>(); //lista para armazenar as parcelas

            foreach (DataGridViewRow row in dataGridViewParcelas.Rows) //percorrendo o dgv de parcelas
            {
                ModelParcela parcela = new ModelParcela //armazena os valores das linhas
                {
                    numeroParcela = Convert.ToInt32(row.Cells["numeroParcela"].Value),
                    porcentagem = Convert.ToDecimal(row.Cells["porcentagem"].Value),
                    idFormaPagamento = Convert.ToInt32(row.Cells["CódFormaPag"].Value)
                };
                parcelas.Add(parcela);
            }

            return parcelas;
        }
        private void exibirParcelasDGV(List<ModelParcela> parcelas)
        {
            dataGridViewParcelas.Rows.Clear(); //limpa as linhas do dgv

            foreach (var parcela in parcelas) //vai adicionando as parcelas
            {
                string formaPagamento = controllerCondicaoPagamento.GetFormaPagByParcelaId(parcela.idParcela);

                dataGridViewParcelas.Rows.Add(
                    parcela.numeroParcela,
                    parcela.porcentagem,
                    parcela.idFormaPagamento,
                    formaPagamento
                );
            }
            dataGridViewParcelas.Sort(dataGridViewParcelas.Columns["numeroParcela"], ListSortDirection.Ascending);
        }
        private bool verificaNumeroParcela(int numeroParcela)
        {
            foreach (DataGridViewRow row in dataGridViewParcelas.Rows)
            {
                if (Convert.ToInt32(row.Cells["numeroParcela"].Value) == numeroParcela)
                {
                    return true;
                }
            }
            return false;
        }
        private void atualizaPorcentagemTotal()
        {
            decimal porcentagemTotal = 0;

            foreach (DataGridViewRow row in dataGridViewParcelas.Rows) //percorre as linhas do dgv
            {
                porcentagemTotal += Convert.ToDecimal(row.Cells["porcentagem"].Value); //add os valores da coluna porcentagem a variavel
            }
            txtPorcentagemTotal.Text = porcentagemTotal.ToString("F2"); //att o campo com 2 casas decimais
        }

        private void CadastroCondicaoDePagamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaCondicaoPagamento)this.Owner).AtualizarConsultaCondPag(false);
        }

        private void CadastroCondicaoDePagamento_Load(object sender, EventArgs e)
        {
            if (Alterar == -7)
            {
                txtCodigo.Text = "0";
                txtNumParcelas.Text = "1";
                txtJuros.Text = "0";
                txtMulta.Text = "0";
                txtDesconto.Text = "0";
            }
        }

        private void btnPesquisarPagamento_Click(object sender, EventArgs e)
        {
            consultaFormaPagamento.btnSair.Text = "Selecionar";

            if (consultaFormaPagamento.ShowDialog() == DialogResult.OK)
            {
                var infosFormaPag = consultaFormaPagamento.Tag as Tuple<int, string>;
                if (infosFormaPag != null)
                {
                    int idFormaPag = infosFormaPag.Item1;
                    string formaPag = infosFormaPag.Item2;

                    txtCodigoPagamento.Text = idFormaPag.ToString();
                    txtFormaPagamento.Text = formaPag;
                }
            }
        }

        private void txtPorcentagem_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPorcentagem.Text) && decimal.Parse(txtPorcentagem.Text) == 0)
            {
                MessageBox.Show("A porcentagem deve ser maior que zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPorcentagem.Focus();
            }
        }

        private void txtCodigoPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!Validacoes.CampoObrigatorio(txtNumParcelas.Text))
            {
                MessageBox.Show("Campo Nº Parcela é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumParcelas.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtPorcentagem.Text))
            {
                MessageBox.Show("Campo % é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPorcentagem.Focus();
            }
            else if (!Validacoes.CampoObrigatorio(txtCodigoPagamento.Text))
            {
                MessageBox.Show("Campo Código Forma Pagamento é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigoPagamento.Focus();
            }
            else
            {
                try
                {
                    int numeroParcela = Convert.ToInt32(txtNumParcelas.Text);
                    if (verificaNumeroParcela(numeroParcela))
                    {
                        MessageBox.Show("Número de parcela já existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNumParcelas.Focus();
                        return;
                    }

                    decimal porcentagem = Convert.ToDecimal(txtPorcentagem.Text);
                    int idFormaPag = Convert.ToInt32(txtCodigoPagamento.Text);
                    string formaPagamento = txtFormaPagamento.Text;

                    dataGridViewParcelas.Rows.Add(numeroParcela, porcentagem, idFormaPag, formaPagamento); //add nova linha com os valores 

                    atualizaPorcentagemTotal();
                    dataGridViewParcelas.Sort(dataGridViewParcelas.Columns["numeroParcela"], ListSortDirection.Ascending);
                    limpaCamposParcelas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar parcela: " + ex.Message);
                }
            }
        }

        private void btnExcluirParcela_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewParcelas.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridViewParcelas.SelectedRows)
                    {
                        dataGridViewParcelas.Rows.Remove(row);
                    }
                    atualizaPorcentagemTotal();
                }
                else
                {
                    MessageBox.Show("Selecione uma parcela para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir parcela: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtJuros_Leave(object sender, EventArgs e)
        {

        }

        private void txtJuros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtMulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtNumParcelas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPorcentagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtCodigoPagamento_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigoPagamento.Text))
            {
                ModelFormaPagamento formaPag = controllerFormaPagamento.BuscarPorId(int.Parse(txtCodigoPagamento.Text));
                if (formaPag != null)
                {
                    txtFormaPagamento.Text = formaPag.formaPagamento;
                }
                else
                {
                    MessageBox.Show("Forma de Pagamento não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodigoPagamento.Focus();
                    txtCodigoPagamento.Clear();
                    txtCodigoPagamento.Clear();
                }
            }
        }
    }
}