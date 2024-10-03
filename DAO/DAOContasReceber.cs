using Pilates.Models;
using SixLabors.ImageSharp;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.DAO
{
    public class DAOContasReceber : DAO<ModelContasReceber>
    {
        public override void Alterar(ModelContasReceber obj)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
UPDATE contasReceber SET dataRecebimento = @dataRecebimento, dataEmissao = dataEmissao, idFormaPagamento = @idFormaPagamento, dataVencimento = @dataVencimento, valorParcela = @valorParcela, juros = @juros, multa = @multa, desconto = @desconto, valorRecebido = @valorRecebido, dataCancelamento = @dataCancelamento, observacao = @observacao, dataUltAlt = @dataUltAlt
WHERE numero = @numero AND idAluno = @idAluno AND parcela = @parcela";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@numero", obj.numero);
                command.Parameters.AddWithValue("@idAluno", obj.idAluno);
                command.Parameters.AddWithValue("@dataEmissao", obj.dataEmissao);
                command.Parameters.AddWithValue("@idFormaPagamento", obj.idFormaPagamento);
                command.Parameters.AddWithValue("@parcela", obj.parcela);
                command.Parameters.AddWithValue("@dataVencimento", obj.dataVencimento);
                command.Parameters.AddWithValue("@valorParcela", obj.valorParcela);
                command.Parameters.AddWithValue("@dataRecebimento", (object)obj.dataRecebimento ?? DBNull.Value);
                command.Parameters.AddWithValue("@juros", (object)obj.juros ?? DBNull.Value);
                command.Parameters.AddWithValue("@multa", (object)obj.multa ?? DBNull.Value);
                command.Parameters.AddWithValue("@desconto", (object)obj.desconto ?? DBNull.Value);
                command.Parameters.AddWithValue("@valorRecebido", (object)obj.valorRecebido ?? DBNull.Value);
                command.Parameters.AddWithValue("@dataCancelamento", (object)obj.dataCancelamento ?? DBNull.Value);
                command.Parameters.AddWithValue("@observacao", obj.observacao ?? string.Empty);
                command.Parameters.AddWithValue("@dataUltAlt", obj.dataUltAlt);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public override ModelContasReceber BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public override List<ModelContasReceber> BuscarTodos(bool BuscarInativos = false)
        {
            List<ModelContasReceber> contasReceber = new List<ModelContasReceber>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM contasReceber";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ModelContasReceber contaReceber = new ModelContasReceber();
                        contaReceber.numero = Convert.ToInt32(reader["numero"]);
                        contaReceber.idAluno = Convert.ToInt32(reader["idAluno"]);
                        contaReceber.dataVencimento = Convert.ToDateTime(reader["dataVencimento"]);
                        contaReceber.parcela = Convert.ToInt32(reader["parcela"]);
                        contaReceber.valorParcela = Convert.ToDecimal(reader["valorParcela"]);
                        contaReceber.dataRecebimento = reader["dataRecebimento"] != DBNull.Value ? Convert.ToDateTime(reader["dataRecebimento"]) : (DateTime?)null;
                        contaReceber.dataCancelamento = reader["dataCancelamento"] != DBNull.Value ? Convert.ToDateTime(reader["dataCancelamento"]) : (DateTime?)null;

                        contasReceber.Add(contaReceber);
                    }
                }
            }
            return contasReceber;
        }

        public override void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public override void Salvar(ModelContasReceber obj)
        {
            dynamic contaReceber = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO contasReceber (numero, idAluno, dataEmissao, idFormaPagamento, parcela, valorParcela, dataVencimento, dataRecebimento, juros, multa, desconto, valorRecebido, dataCancelamento, observacao, dataCadastro, dataUltAlt) 
    VALUES (@numero, @idAluno, @dataEmissao, @idFormaPagamento, @parcela, @valorParcela, @dataVencimento, @dataRecebimento, @juros, @multa, @desconto, @valorRecebido, @dataCancelamento,@observacao, @dataCadastro, @dataUltAlt)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@numero", contaReceber.numero);
                command.Parameters.AddWithValue("@idAluno", contaReceber.idAluno);
                command.Parameters.AddWithValue("@dataEmissao", contaReceber.dataEmissao);
                command.Parameters.AddWithValue("@idFormaPagamento", contaReceber.idFormaPagamento);
                command.Parameters.AddWithValue("@parcela", contaReceber.parcela);
                command.Parameters.AddWithValue("@valorParcela", contaReceber.valorParcela);
                command.Parameters.AddWithValue("@dataVencimento", contaReceber.dataVencimento);
                command.Parameters.AddWithValue("@dataRecebimento", contaReceber.dataRecebimento ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@juros", contaReceber.juros ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@multa", contaReceber.multa ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@desconto", contaReceber.desconto ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@valorRecebido", contaReceber.valorRecebido ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@dataCancelamento", contaReceber.dataCancelamento ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@observacao", contaReceber.observacao ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@dataCadastro", contaReceber.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", contaReceber.dataUltAlt);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao salvar conta a receber: " + ex.Message);
                    throw;
                }
            }
        }
        public ModelContasReceber GetContaById(int numero, int idAluno, int parcela)
        {
            ModelContasReceber contaReceber = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM contasReceber WHERE numero = @numero AND idAluno = @idAluno AND parcela = @parcela";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@numero", numero);
                cmd.Parameters.AddWithValue("@idAluno", idAluno);
                cmd.Parameters.AddWithValue("@parcela", parcela);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        contaReceber = new ModelContasReceber
                        {
                            numero = Convert.ToInt32(reader["numero"]),
                            dataEmissao = Convert.ToDateTime(reader["dataEmissao"]),
                            idAluno = Convert.ToInt32(reader["idAluno"]),
                            idFormaPagamento = Convert.ToInt32(reader["idFormaPagamento"]),
                            parcela = Convert.ToInt32(reader["parcela"]),
                            valorParcela = Convert.ToDecimal(reader["valorParcela"]),
                            dataVencimento = Convert.ToDateTime(reader["dataVencimento"]),

                            dataRecebimento = reader["dataRecebimento"] != DBNull.Value ? Convert.ToDateTime(reader["dataRecebimento"]) : (DateTime?)null,
                            juros = reader["juros"] != DBNull.Value ? Convert.ToDecimal(reader["juros"]) : (decimal?)null,
                            multa = reader["multa"] != DBNull.Value ? Convert.ToDecimal(reader["multa"]) : (decimal?)null,
                            desconto = reader["desconto"] != DBNull.Value ? Convert.ToDecimal(reader["desconto"]) : (decimal?)null,
                            valorRecebido = reader["valorRecebido"] != DBNull.Value ? Convert.ToDecimal(reader["valorRecebido"]) : (decimal?)null,

                            observacao = reader["observacao"].ToString(),
                            dataCancelamento = reader["dataCancelamento"] != DBNull.Value ? Convert.ToDateTime(reader["dataCancelamento"]) : (DateTime?)null,
                            dataCadastro = Convert.ToDateTime(reader["dataCadastro"]),
                            dataUltAlt = Convert.ToDateTime(reader["dataUltAlt"]),
                        };
                    }
                }
            }
            return contaReceber;
        }
        public bool CancelarConta(ModelContasReceber obj)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    //verifica se a conta a receber está associada a algum contrato
                    string verificaQuery = @"
        SELECT COUNT(*) FROM contrato
        WHERE idContrato = @numero AND idAluno= @idAluno";

                    SqlCommand verificaCommand = new SqlCommand(verificaQuery, connection, transaction);
                    verificaCommand.Parameters.AddWithValue("@numero", obj.numero);
                    verificaCommand.Parameters.AddWithValue("@idAluno", obj.idAluno);

                    int count = (int)verificaCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        //se existe uma nota associada, não cancelar
                        return false;
                    }

                    //se nao existe, atualizar a data de cancelamento
                    string cancelarQuery = @"
        UPDATE contasReceber
        SET dataCancelamento = @dataCancelamento
        WHERE numero = @numero AND idAluno= @idAluno AND parcela = @parcela";

                    SqlCommand cancelarCommand = new SqlCommand(cancelarQuery, connection, transaction);
                    cancelarCommand.Parameters.AddWithValue("@numero", obj.numero);
                    cancelarCommand.Parameters.AddWithValue("@idAluno", obj.idAluno);
                    cancelarCommand.Parameters.AddWithValue("@parcela", obj.parcela);
                    cancelarCommand.Parameters.AddWithValue("@dataCancelamento", obj.dataCancelamento ?? (object)DBNull.Value);

                    cancelarCommand.ExecuteNonQuery();
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Erro ao cancelar conta a receber: " + ex.Message);
                    throw;
                }
            }
        }
            public bool VerificarParcelasNaoPagas(string numero, int idAluno, int parcelaAtual)
        {
            string query = @"
SELECT COUNT(*)
FROM contasReceber
WHERE numero = @numero
  AND idAluno = @idAluno
  AND parcela < @parcelaAtual
  AND dataRecebimento IS NULL";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@numero", numero);
                command.Parameters.AddWithValue("@idAluno", idAluno);
                command.Parameters.AddWithValue("@parcelaAtual", parcelaAtual);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }
    }
}
