﻿using Pilates.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilates.DAO
{
    public class DAOCondicaoPagamento : DAO<ModelCondicaoPagamento>
    {
        public DAOCondicaoPagamento() : base() { }
        public int BuscarUltimoCodigo()
        {
            int proximoCodigo = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(idCondPagamento) FROM condicaoPagamento";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                var result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    proximoCodigo = Convert.ToInt32(result);
                }
            }
            return proximoCodigo;
        }
        public string getCondicaoPag(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT condicaoPagamento FROM condicaoPagamento WHERE idCondPagamento = @id AND Ativo = 1";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader["condicaoPagamento"].ToString();
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
        public override void Alterar(ModelCondicaoPagamento obj)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction(); //inicia a transação

                try
                {
                    //comando p/ atualizar a condição de pagamento
                    string queryCondicaoPagamento = @"UPDATE condicaoPagamento 
                                       SET condicaoPagamento = @condicaoPagamento,usuarioUltAlt = @usuarioUltAlt, desconto = @desconto, juros = @juros, multa = @multa, ativo = @ativo, dataUltAlt = @dataUltAlt 
                                       WHERE idCondPagamento = @idCondPagamento";
                    SqlCommand cmdCondicaoPagamento = new SqlCommand(queryCondicaoPagamento, conn, transaction);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@condicaoPagamento", obj.condicaoPagamento);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@usuarioUltAlt", obj.usuarioUltAlt);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@desconto", obj.desconto);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@juros", obj.juros);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@multa", obj.multa);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@ativo", obj.Ativo);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@dataUltAlt", obj.dataUltAlt);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@idCondPagamento", obj.idCondPagamento);

                    cmdCondicaoPagamento.ExecuteNonQuery(); //atualiza condição de pagamento

                    //obtem as parcelas que existem no banco referente ao id da cond. pagamento atual
                    string querySelectParcelas = "SELECT * FROM parcela WHERE idCondPagamento = @idCondPagamento";
                    SqlCommand cmdSelectParcelas = new SqlCommand(querySelectParcelas, conn, transaction);
                    cmdSelectParcelas.Parameters.AddWithValue("@idCondPagamento", obj.idCondPagamento);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmdSelectParcelas);
                    DataTable parcelasExistentes = new DataTable();
                    adapter.Fill(parcelasExistentes); //preenche um datatable com as parcelas

                    //percorre as parcelas
                    foreach (var parcela in obj.Parcelas)
                    {
                        bool existe = false; //verificar se parcela existe ou nao

                        foreach (DataRow row in parcelasExistentes.Rows) //percorre as parcelas no banco
                        {
                            if ((int)row["numeroParcela"] == parcela.numeroParcela) //vê se aquele nro de parcela já existe
                            {
                                //atualiza a parcela existente
                                string queryUpdateParcela = @"UPDATE parcela 
                                              SET porcentagem = @porcentagem, idFormaPagamento = @idFormaPagamento 
                                              WHERE idCondPagamento = @idCondPagamento AND numeroParcela = @numeroParcela";
                                SqlCommand cmdUpdateParcela = new SqlCommand(queryUpdateParcela, conn, transaction);
                                cmdUpdateParcela.Parameters.AddWithValue("@porcentagem", parcela.porcentagem);
                                cmdUpdateParcela.Parameters.AddWithValue("@idFormaPagamento", parcela.idFormaPagamento);
                                cmdUpdateParcela.Parameters.AddWithValue("@idCondPagamento", obj.idCondPagamento);
                                cmdUpdateParcela.Parameters.AddWithValue("@numeroParcela", parcela.numeroParcela);

                                cmdUpdateParcela.ExecuteNonQuery();
                                existe = true; //marca que a parcela existe
                                break;
                            }
                        }
                        if (!existe) //se não existir a parcela
                        {
                            //insere nova parcela
                            string queryInsertParcela = @"INSERT INTO parcela 
                                          (numeroParcela, porcentagem, idCondPagamento, idFormaPagamento) 
                                          VALUES (@numeroParcela, @porcentagem, @idCondPagamento, @idFormaPagamento)";
                            SqlCommand cmdInsertParcela = new SqlCommand(queryInsertParcela, conn, transaction);
                            cmdInsertParcela.Parameters.AddWithValue("@numeroParcela", parcela.numeroParcela);
                            cmdInsertParcela.Parameters.AddWithValue("@porcentagem", parcela.porcentagem);
                            cmdInsertParcela.Parameters.AddWithValue("@idCondPagamento", obj.idCondPagamento);
                            cmdInsertParcela.Parameters.AddWithValue("@idFormaPagamento", parcela.idFormaPagamento);

                            cmdInsertParcela.ExecuteNonQuery();
                        }
                    }
                    foreach (DataRow row in parcelasExistentes.Rows) //percorre dnv as parcelas
                    {
                        bool existe = false;
                        foreach (var parcela in obj.Parcelas) //vê se a parcela ainda existe
                        {
                            if ((int)row["numeroParcela"] == parcela.numeroParcela)
                            {
                                existe = true;
                                break;
                            }
                        }
                        if (!existe) //se nao existe mais
                        {   //apaga a parcela q nao foi encontrada
                            string queryDeleteParcela = "DELETE FROM parcela WHERE idCondPagamento = @idCondPagamento AND numeroParcela = @numeroParcela";
                            SqlCommand cmdDeleteParcela = new SqlCommand(queryDeleteParcela, conn, transaction);
                            cmdDeleteParcela.Parameters.AddWithValue("@idCondPagamento", obj.idCondPagamento);
                            cmdDeleteParcela.Parameters.AddWithValue("@numeroParcela", (int)row["numeroParcela"]);

                            cmdDeleteParcela.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit(); //confirma a transação
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); //se der erro, volta
                    throw new Exception("Erro ao alterar condição de pagamento: " + ex.Message);
                }
            }
        }
        public override void Deletar(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    //deleta as parcelas com o id da condicao de pagamento
                    string deleteParcelas = "DELETE FROM parcela WHERE idCondPagamento = @idCondPagamento";
                    SqlCommand cmdDeleteParcelas = new SqlCommand(deleteParcelas, conn, transaction);
                    cmdDeleteParcelas.Parameters.AddWithValue("@idCondPagamento", id);
                    cmdDeleteParcelas.ExecuteNonQuery();

                    //deleta condicao de pagamento
                    string deleteCondicaoPagamento = "DELETE FROM condicaoPagamento WHERE idCondPagamento = @idCondPagamento";
                    SqlCommand cmdDeleteCondicaoPagamento = new SqlCommand(deleteCondicaoPagamento, conn, transaction);
                    cmdDeleteCondicaoPagamento.Parameters.AddWithValue("@idCondPagamento", id);
                    cmdDeleteCondicaoPagamento.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch (SqlException ex)
                {
                    transaction.Rollback();

                    if (ex.Number == 547)
                    {
                        MessageBox.Show("Não é possível excluir a Condição de Pagamento, pois ela está sendo utilizada em um cadastro.", "Erro ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao deletar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Erro ao deletar a condição de pagamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public override List<ModelCondicaoPagamento> BuscarTodos(bool incluiInativos = false)
        {
            List<ModelCondicaoPagamento> condicoesPagamento = new List<ModelCondicaoPagamento>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = incluiInativos ? "SELECT * FROM condicaoPagamento" : "SELECT * FROM condicaoPagamento WHERE ativo = 1";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ModelCondicaoPagamento condicaoPagamento = new ModelCondicaoPagamento();
                        condicaoPagamento.idCondPagamento = Convert.ToInt32(reader["idCondPagamento"]);
                        condicaoPagamento.condicaoPagamento = reader["condicaoPagamento"].ToString();

                        condicoesPagamento.Add(condicaoPagamento);
                    }
                }
            }

            return condicoesPagamento;
        }
        public string GetFormaPagByParcelaId(int idParcela)
        {
            string formaPag = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT formaPagamento.formaPagamento FROM parcela INNER JOIN formaPagamento ON parcela.idFormaPagamento = formaPagamento.idFormaPagamento WHERE parcela.idParcela = @idParcela";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idParcela", idParcela);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        formaPag = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro ao obter a forma de pagamento: " + ex.Message);
                }
            }
            return formaPag;
        }
        public override ModelCondicaoPagamento BuscarPorId(int id)
        {
            ModelCondicaoPagamento condicaoPagamento = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM condicaoPagamento WHERE idCondPagamento = @idCondPagamento";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idCondPagamento", id);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        condicaoPagamento = new ModelCondicaoPagamento();
                        condicaoPagamento.idCondPagamento = Convert.ToInt32(reader["idCondPagamento"]);
                        condicaoPagamento.condicaoPagamento = reader["condicaoPagamento"].ToString();
                        condicaoPagamento.usuarioUltAlt = reader["usuarioUltAlt"].ToString();
                        condicaoPagamento.desconto = Convert.ToDecimal(reader["desconto"]);
                        condicaoPagamento.juros = Convert.ToDecimal(reader["juros"]);
                        condicaoPagamento.multa = Convert.ToDecimal(reader["multa"]);
                        condicaoPagamento.Ativo = Convert.ToBoolean(reader["ativo"]);
                        condicaoPagamento.dataCadastro = Convert.ToDateTime(reader["dataCadastro"]);
                        condicaoPagamento.dataUltAlt = Convert.ToDateTime(reader["dataUltAlt"]);

                        // Carregar Parcelas
                        condicaoPagamento.Parcelas = GetParcelasByCondicaoPagamentoId(condicaoPagamento.idCondPagamento);
                    }
                }
            }

            return condicaoPagamento;
        }
        private List<ModelParcela> GetParcelasByCondicaoPagamentoId(int idCondPagamento)
        {
            List<ModelParcela> parcelas = new List<ModelParcela>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM parcela WHERE idCondPagamento = @idCondPagamento";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idCondPagamento", idCondPagamento);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ModelParcela parcela = new ModelParcela();
                        parcela.idParcela = Convert.ToInt32(reader["idParcela"]);
                        parcela.numeroParcela = Convert.ToInt32(reader["numeroParcela"]);
                        parcela.porcentagem = Convert.ToDecimal(reader["porcentagem"]);
                        parcela.idCondPagamento = Convert.ToInt32(reader["idCondPagamento"]);
                        parcela.idFormaPagamento = Convert.ToInt32(reader["idFormaPagamento"]);

                        parcelas.Add(parcela);
                    }
                }
            }

            return parcelas;
        }
        public override void Salvar(ModelCondicaoPagamento obj)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    //insere uma nova condicao de pagamento
                    string queryCondicaoPagamento = @"INSERT INTO condicaoPagamento 
                                               (condicaoPagamento, desconto, juros, multa, ativo, dataCadastro, dataUltAlt, usuarioUltAlt) 
                                               VALUES (@condicaoPagamento, @desconto, @juros, @multa, @ativo, @dataCadastro, @dataUltAlt, @usuarioUltAlt);
                                               SELECT SCOPE_IDENTITY();";
                    SqlCommand cmdCondicaoPagamento = new SqlCommand(queryCondicaoPagamento, conn, transaction); //novo comando para transacao e conexao
                    cmdCondicaoPagamento.Parameters.AddWithValue("@condicaoPagamento", obj.condicaoPagamento);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@usuarioUltAlt", obj.usuarioUltAlt);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@desconto", obj.desconto);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@juros", obj.juros);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@multa", obj.multa);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@ativo", obj.Ativo);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@dataCadastro", obj.dataCadastro);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@dataUltAlt", obj.dataUltAlt);

                    int idCondPagamento = Convert.ToInt32(cmdCondicaoPagamento.ExecuteScalar()); //retorna o último valor da identidade gerada(SCOPE_IDENTITY)

                    //insere as parcelas da condição de pagamento
                    foreach (var parcela in obj.Parcelas)
                    {
                        string queryParcela = @"INSERT INTO parcela 
                                        (numeroParcela, porcentagem, idCondPagamento, idFormaPagamento) 
                                        VALUES (@numeroParcela, @porcentagem, @idCondPagamento, @idFormaPagamento)";
                        SqlCommand cmdParcela = new SqlCommand(queryParcela, conn, transaction); //novo comando para inserir as parcelas e o id da condicao de pagamento
                        cmdParcela.Parameters.AddWithValue("@numeroParcela", parcela.numeroParcela);
                        cmdParcela.Parameters.AddWithValue("@porcentagem", parcela.porcentagem);
                        cmdParcela.Parameters.AddWithValue("@idCondPagamento", idCondPagamento);
                        cmdParcela.Parameters.AddWithValue("@idFormaPagamento", parcela.idFormaPagamento);

                        cmdParcela.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Erro ao salvar condição de pagamento: " + ex.Message);
                }
            }
        }
    }
}
