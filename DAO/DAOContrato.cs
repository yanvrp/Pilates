using Pilates.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.DAO
{
    public class DAOContrato : DAO<ModelContrato>
    {
        public DAOContrato() : base() { }

        public override void Alterar(ModelContrato obj)
        {
            throw new NotImplementedException();
        }
        public int GetUltimoNumero()
        {
            int ultimoCodigo = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ISNULL(MAX(idContrato), 0) FROM contrato";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                var result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    ultimoCodigo = Convert.ToInt32(result);
                }
            }
            return ultimoCodigo;
        }
        public void CancelarContrato(int idContrato)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //atualizar o contrato e adicionar a data de cancelamento
                string queryContrato = @"UPDATE contrato 
                                 SET dataCancelamento = @dataCancelamento, 
                                     dataUltAlt = @dataUltAlt 
                                 WHERE idContrato = @idContrato";

                //obter as parcelas em aberto
                string queryParcelasEmAberto = @"SELECT parcela, dataVencimento 
                                         FROM contasReceber 
                                         WHERE numero = @idContrato 
                                         AND dataRecebimento IS NULL 
                                         AND dataCancelamento IS NULL 
                                         ORDER BY dataVencimento";

                //cancelar aulas futuras na agenda associadas ao contrato
                string queryCancelarAulasFuturas = @"UPDATE agenda 
                                             SET dataCancelamento = @dataCancelamento, 
                                                 situacao = 'CANCELADO' 
                                             WHERE idContrato = @idContrato 
                                             AND data > @dataHoje 
                                             AND ativo = 1";

                SqlCommand commandContrato = new SqlCommand(queryContrato, connection);
                commandContrato.Parameters.AddWithValue("@dataCancelamento", DateTime.Now);
                commandContrato.Parameters.AddWithValue("@dataUltAlt", DateTime.Now);
                commandContrato.Parameters.AddWithValue("@idContrato", idContrato);

                SqlCommand commandParcelasEmAberto = new SqlCommand(queryParcelasEmAberto, connection);
                commandParcelasEmAberto.Parameters.AddWithValue("@idContrato", idContrato);

                SqlCommand commandCancelarAulasFuturas = new SqlCommand(queryCancelarAulasFuturas, connection);
                commandCancelarAulasFuturas.Parameters.AddWithValue("@dataCancelamento", DateTime.Now);
                commandCancelarAulasFuturas.Parameters.AddWithValue("@idContrato", idContrato);
                commandCancelarAulasFuturas.Parameters.AddWithValue("@dataHoje", DateTime.Today);

                try
                {
                    connection.Open();
                    commandContrato.ExecuteNonQuery();

                    //puxa as parcelas em aberto
                    List<int> parcelasACancelar = new List<int>();
                    using (SqlDataReader reader = commandParcelasEmAberto.ExecuteReader())
                    {
                        List<(int parcela, DateTime dataVencimento)> parcelasEmAberto = new List<(int, DateTime)>();

                        while (reader.Read())
                        {
                            int parcela = reader.GetInt32(0);
                            DateTime dataVencimento = reader.GetDateTime(1);
                            parcelasEmAberto.Add((parcela, dataVencimento));
                        }

                        //qtde de parcelas em aberto
                        if (parcelasEmAberto.Count > 1)
                        {
                            //ordena as parcelas por data de vencimento e exclui a próxima a vencer
                            parcelasEmAberto = parcelasEmAberto.OrderBy(p => p.dataVencimento).ToList();
                            parcelasACancelar = parcelasEmAberto.Skip(1).Select(p => p.parcela).ToList();
                        }
                    }

                    //se tem parcelas para cancelar, atualiza as parcelas correspondentes
                    if (parcelasACancelar.Any())
                    {
                        string queryCancelarParcelas = @"UPDATE contasReceber 
                                                 SET dataCancelamento = @dataCancelamento 
                                                 WHERE numero = @idContrato 
                                                 AND parcela IN (" + string.Join(",", parcelasACancelar) + ")";

                        SqlCommand commandCancelarParcelas = new SqlCommand(queryCancelarParcelas, connection);
                        commandCancelarParcelas.Parameters.AddWithValue("@dataCancelamento", DateTime.Now);
                        commandCancelarParcelas.Parameters.AddWithValue("@idContrato", idContrato);

                        int rowsAffected = commandCancelarParcelas.ExecuteNonQuery();
                        Console.WriteLine($"{rowsAffected} contas a receber canceladas.");
                    }
                    else
                    {
                        Console.WriteLine("Nenhuma parcela foi cancelada, pois há apenas uma parcela restante.");
                    }
                    int aulasCanceladas = commandCancelarAulasFuturas.ExecuteNonQuery();
                    Console.WriteLine($"{aulasCanceladas} aulas futuras canceladas.");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao cancelar o contrato, contas a receber e agenda: " + ex.Message);
                    throw;
                }
            }
        }

        public override ModelContrato BuscarPorId(int id)
        {
            ModelContrato contrato = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM contrato WHERE idContrato = @idContrato";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idContrato", id);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        contrato = new ModelContrato();
                        contrato.idContrato = Convert.ToInt32(reader["idContrato"]);
                        contrato.idAluno = Convert.ToInt32(reader["idAluno"]);
                        contrato.idCondPag = Convert.ToInt32(reader["idCondPagamento"]);
                        contrato.idPrograma = Convert.ToInt32(reader["idPrograma"]);
                        contrato.periodo = reader["periodo"].ToString();
                        contrato.diasSemana = reader["diasSemana"].ToString();
                        contrato.horario = (TimeSpan)reader["horario"];
                        contrato.ValorTotal = Convert.ToDecimal(reader["valorTotal"]);
                        contrato.diaAcordado = Convert.ToInt32(reader["diaAcordado"]);
                        contrato.Ativo = Convert.ToBoolean(reader["Ativo"]);
                        contrato.dataCancelamento = reader["dataCancelamento"] != DBNull.Value ? Convert.ToDateTime(reader["dataCancelamento"]) : (DateTime?)null;
                        contrato.dataFinalContrato = reader["dataFinalContrato"] != DBNull.Value ? Convert.ToDateTime(reader["dataFinalContrato"]) : (DateTime?)null;
                        contrato.dataInicioPrograma = DateTime.Parse(reader["dataInicioPrograma"].ToString());
                        contrato.dataCadastro = DateTime.Parse(reader["dataCadastro"].ToString());
                        contrato.dataUltAlt = DateTime.Parse(reader["dataUltAlt"].ToString());
                    }
                }
            }

            return contrato;
        }

        public override List<ModelContrato> BuscarTodos(bool BuscarInativos = false)
        {
            List<ModelContrato> contratos = new List<ModelContrato>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM contrato";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ModelContrato contrato = new ModelContrato();
                        contrato.idContrato = Convert.ToInt32(reader["idContrato"]);
                        contrato.idAluno = Convert.ToInt32(reader["idAluno"]);
                        contrato.idPrograma = Convert.ToInt32(reader["idPrograma"]);
                        contrato.dataInicioPrograma = Convert.ToDateTime(reader["dataInicioPrograma"]);
                        contrato.dataCancelamento = reader["dataCancelamento"] != DBNull.Value ? Convert.ToDateTime(reader["dataCancelamento"]) : (DateTime?)null;
                        contrato.dataFinalContrato = reader["dataFinalContrato"] != DBNull.Value ? Convert.ToDateTime(reader["dataFinalContrato"]) : (DateTime?)null;

                        contratos.Add(contrato);
                    }
                }
            }
            return contratos;
        }

        public override void Deletar(int id)
        {
            throw new NotImplementedException();
        }
        public int SalvarC(ModelContrato obj)
        {
            dynamic contrato = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO contrato (idAluno, idCondPagamento, idPrograma, periodo, horario, valorTotal, diaAcordado, diasSemana, dataInicioPrograma, dataCancelamento, dataFinalContrato, ativo, dataCadastro, dataUltAlt) 
                         VALUES (@idAluno, @idCondPagamento, @idPrograma, @periodo, @horario, @valorTotal, @diaAcordado, @diasSemana, @dataInicioPrograma, @dataCancelamento, @dataFinalContrato, @ativo, @dataCadastro, @dataUltAlt);
                         SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@idAluno", contrato.idAluno);
                command.Parameters.AddWithValue("@idCondPagamento", contrato.idCondPag);
                command.Parameters.AddWithValue("@idPrograma", contrato.idPrograma);
                command.Parameters.AddWithValue("@periodo", contrato.periodo);
                command.Parameters.AddWithValue("@horario", contrato.horario);
                command.Parameters.AddWithValue("@valorTotal", contrato.ValorTotal);
                command.Parameters.AddWithValue("@diaAcordado", contrato.diaAcordado);
                command.Parameters.AddWithValue("@diasSemana", contrato.diasSemana);
                command.Parameters.AddWithValue("@dataInicioPrograma", contrato.dataInicioPrograma);
                command.Parameters.AddWithValue("@dataCancelamento", contrato.dataCancelamento ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@dataFinalContrato", contrato.dataFinalContrato ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ativo", contrato.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", contrato.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", contrato.dataUltAlt);

                try
                {
                    connection.Open();
                    return Convert.ToInt32(command.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao salvar o contrato: " + ex.Message);
                    throw;
                }
            }
        }

        public override void Salvar(ModelContrato obj)
        {
            
        }
    }
}
