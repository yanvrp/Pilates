using Pilates.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.DAO
{
    public class DAOContasPagar : DAO<ModelContasPagar>
    {
        public override void Alterar(ModelContasPagar obj)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
UPDATE contasPagar SET dataPagamento = @dataPagamento,usuarioUltAlt = @usuarioUltAlt, dataEmissao = dataEmissao, idFormaPagamento = @idFormaPagamento, idFornecedor = @idFornecedor, dataVencimento = @dataVencimento, valorParcela = @valorParcela, juros = @juros, multa = @multa, desconto = @desconto, valorPago = @valorPago, dataCancelamento = @dataCancelamento, observacao = @observacao, dataUltAlt = @dataUltAlt
WHERE numero = @numero AND parcela = @parcela";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@numero", obj.numero);
                command.Parameters.AddWithValue("@dataEmissao", obj.dataEmissao);
                command.Parameters.AddWithValue("@usuarioUltAlt", obj.usuarioUltAlt);
                command.Parameters.AddWithValue("@idFormaPagamento", obj.idFormaPagamento);
                command.Parameters.AddWithValue("@idFornecedor", obj.idFornecedor);
                command.Parameters.AddWithValue("@parcela", obj.parcela);
                command.Parameters.AddWithValue("@dataVencimento", obj.dataVencimento);
                command.Parameters.AddWithValue("@valorParcela", obj.valorParcela);
                command.Parameters.AddWithValue("@dataPagamento", (object)obj.dataPagamento ?? DBNull.Value);
                command.Parameters.AddWithValue("@juros", (object)obj.juros ?? DBNull.Value);
                command.Parameters.AddWithValue("@multa", (object)obj.multa ?? DBNull.Value);
                command.Parameters.AddWithValue("@desconto", (object)obj.desconto ?? DBNull.Value);
                command.Parameters.AddWithValue("@valorPago", (object)obj.valorPago ?? DBNull.Value);
                command.Parameters.AddWithValue("@dataCancelamento", (object)obj.dataCancelamento ?? DBNull.Value);
                command.Parameters.AddWithValue("@observacao", obj.observacao ?? string.Empty);
                command.Parameters.AddWithValue("@dataUltAlt", obj.dataUltAlt);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public override ModelContasPagar BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public override List<ModelContasPagar> BuscarTodos(bool BuscarInativos = false)
        {
            List<ModelContasPagar> contasPagar = new List<ModelContasPagar>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM contasPagar";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ModelContasPagar contaPagar = new ModelContasPagar();
                        contaPagar.numero = Convert.ToInt32(reader["numero"]);
                        contaPagar.dataVencimento = Convert.ToDateTime(reader["dataVencimento"]);
                        contaPagar.parcela = Convert.ToInt32(reader["parcela"]);
                        contaPagar.idFornecedor = Convert.ToInt32(reader["idFornecedor"]);
                        contaPagar.valorParcela = Convert.ToDecimal(reader["valorParcela"]);
                        contaPagar.dataPagamento = reader["dataPagamento"] != DBNull.Value ? Convert.ToDateTime(reader["dataPagamento"]) : (DateTime?)null;
                        contaPagar.dataCancelamento = reader["dataCancelamento"] != DBNull.Value ? Convert.ToDateTime(reader["dataCancelamento"]) : (DateTime?)null;

                        contasPagar.Add(contaPagar);
                    }
                }
            }
            return contasPagar;
        }

        public override void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public override void Salvar(ModelContasPagar obj)
        {
            dynamic contaPagar = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO contasPagar (usuarioUltAlt, numero, dataEmissao, idFormaPagamento, idFornecedor, parcela, valorParcela, dataVencimento, dataPagamento, juros, multa, desconto, valorPago, dataCancelamento, observacao, dataCadastro, dataUltAlt) 
    VALUES (@usuarioUltAlt, @numero, @dataEmissao, @idFormaPagamento, @idFornecedor, @parcela, @valorParcela, @dataVencimento, @dataPagamento, @juros, @multa, @desconto, @valorPago, @dataCancelamento,@observacao, @dataCadastro, @dataUltAlt)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@numero", contaPagar.numero);
                command.Parameters.AddWithValue("@dataEmissao", contaPagar.dataEmissao);
                command.Parameters.AddWithValue("@usuarioUltAlt", contaPagar.usuarioUltAlt);
                command.Parameters.AddWithValue("@idFormaPagamento", contaPagar.idFormaPagamento);
                command.Parameters.AddWithValue("@idFornecedor", contaPagar.idFornecedor);
                command.Parameters.AddWithValue("@parcela", contaPagar.parcela);
                command.Parameters.AddWithValue("@valorParcela", contaPagar.valorParcela);
                command.Parameters.AddWithValue("@dataVencimento", contaPagar.dataVencimento);
                command.Parameters.AddWithValue("@dataPagamento", contaPagar.dataPagamento ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@juros", contaPagar.juros ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@multa", contaPagar.multa ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@desconto", contaPagar.desconto ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@valorPago", contaPagar.valorPago ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@dataCancelamento", contaPagar.dataCancelamento ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@observacao", contaPagar.observacao ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@dataCadastro", contaPagar.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", contaPagar.dataUltAlt);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao salvar conta a pagar: " + ex.Message);
                    throw;
                }
            }
        }
        public ModelContasPagar GetContaById(int numero, int parcela)
        {
            ModelContasPagar contaPagar = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM contasPagar WHERE numero = @numero AND parcela = @parcela";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@numero", numero);
                cmd.Parameters.AddWithValue("@parcela", parcela);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        contaPagar = new ModelContasPagar
                        {
                            numero = Convert.ToInt32(reader["numero"]),
                            dataEmissao = Convert.ToDateTime(reader["dataEmissao"]),
                            idFormaPagamento = Convert.ToInt32(reader["idFormaPagamento"]),
                            idFornecedor = Convert.ToInt32(reader["idFornecedor"]),
                            parcela = Convert.ToInt32(reader["parcela"]),
                            valorParcela = Convert.ToDecimal(reader["valorParcela"]),
                            dataVencimento = Convert.ToDateTime(reader["dataVencimento"]),

                            dataPagamento = reader["dataPagamento"] != DBNull.Value ? Convert.ToDateTime(reader["dataPagamento"]) : (DateTime?)null,
                            juros = reader["juros"] != DBNull.Value ? Convert.ToDecimal(reader["juros"]) : (decimal?)null,
                            multa = reader["multa"] != DBNull.Value ? Convert.ToDecimal(reader["multa"]) : (decimal?)null,
                            desconto = reader["desconto"] != DBNull.Value ? Convert.ToDecimal(reader["desconto"]) : (decimal?)null,
                            valorPago = reader["valorPago"] != DBNull.Value ? Convert.ToDecimal(reader["valorPago"]) : (decimal?)null,

                            observacao = reader["observacao"].ToString(),
                            usuarioUltAlt = reader["usuarioUltAlt"].ToString(),
                            dataCancelamento = reader["dataCancelamento"] != DBNull.Value ? Convert.ToDateTime(reader["dataCancelamento"]) : (DateTime?)null,
                            dataCadastro = Convert.ToDateTime(reader["dataCadastro"]),
                            dataUltAlt = Convert.ToDateTime(reader["dataUltAlt"]),
                        };
                    }
                }
            }
            return contaPagar;
        }
        public bool CancelarConta(ModelContasPagar obj)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string cancelarQuery = @"
        UPDATE contasPagar
        SET dataCancelamento = @dataCancelamento
        WHERE numero = @numero AND parcela = @parcela";

                    SqlCommand cancelarCommand = new SqlCommand(cancelarQuery, connection, transaction);
                    cancelarCommand.Parameters.AddWithValue("@numero", obj.numero);
                    cancelarCommand.Parameters.AddWithValue("@parcela", obj.parcela);
                    cancelarCommand.Parameters.AddWithValue("@dataCancelamento", obj.dataCancelamento ?? (object)DBNull.Value);

                    cancelarCommand.ExecuteNonQuery();
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Erro ao cancelar conta a pagar: " + ex.Message);
                    throw;
                }
            }
        }
        public bool VerificarParcelasNaoPagas(string numero, int parcelaAtual)
        {
            string query = @"
SELECT COUNT(*)
FROM contasPagar
WHERE numero = @numero
  AND parcela < @parcelaAtual
  AND dataPagamento IS NULL";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@numero", numero);
                command.Parameters.AddWithValue("@parcelaAtual", parcelaAtual);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }
    }
}
