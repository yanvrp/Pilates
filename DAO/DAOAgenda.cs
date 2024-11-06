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
    public class DAOAgenda : DAO<ModelAgenda>
    {
        public DAOAgenda() : base() { }
        public int GetUltimoCodigo()
        {
            int ultimoCodigo = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(idAgenda) FROM agenda";
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
        public override void Alterar(ModelAgenda obj)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE agenda SET idAluno = @idAluno, usuarioUltAlt = @usuarioUltAlt, idContrato = @idContrato, horario = @horario, data = @data, situacao = @situacao, ativo = @ativo,  dataUltAlt = @dataUltAlt, dataCancelamento = @dataCancelamento WHERE idAgenda = @idAgenda";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@idAluno", obj.idAluno);
                command.Parameters.AddWithValue("@usuarioUltAlt", obj.usuarioUltAlt);
                command.Parameters.AddWithValue("@idContrato", obj.idContrato ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@horario", obj.horario);
                command.Parameters.AddWithValue("@situacao", obj.situacao ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@data", obj.data);
                command.Parameters.AddWithValue("@ativo", obj.Ativo);
                command.Parameters.AddWithValue("@dataUltAlt", DateTime.Now); 
                command.Parameters.AddWithValue("@idAgenda", obj.idAgenda);
                command.Parameters.AddWithValue("@dataCancelamento", obj.dataCancelamento ?? (object)DBNull.Value);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao alterar o agendamento: " + ex.Message);
                    throw;
                }
            }
        }

        public override ModelAgenda BuscarPorId(int id)
        {
            ModelAgenda agenda = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM agenda WHERE idAgenda = @idAgenda";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idAgenda", id);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        agenda = new ModelAgenda();
                        agenda.idAgenda = Convert.ToInt32(reader["idAgenda"]);
                        agenda.usuarioUltAlt = reader["usuarioUltAlt"].ToString();
                        agenda.idAluno = Convert.ToInt32(reader["idAluno"]);
                        agenda.idContrato = reader["idContrato"] != DBNull.Value ? Convert.ToInt32(reader["idContrato"]) : (int?)null;
                        agenda.situacao = reader["situacao"] != DBNull.Value ? reader["situacao"].ToString() : (string?)null;
                        agenda.horario = (TimeSpan)reader["horario"];
                        agenda.data = DateTime.Parse(reader["data"].ToString());
                        agenda.Ativo = Convert.ToBoolean(reader["Ativo"]);
                        agenda.dataCadastro = DateTime.Parse(reader["dataCadastro"].ToString());
                        agenda.dataUltAlt = DateTime.Parse(reader["dataUltAlt"].ToString());
                        agenda.dataCancelamento = reader["dataCancelamento"] != DBNull.Value ? Convert.ToDateTime(reader["dataCancelamento"]) : (DateTime?)null;
                    }
                }
            }

            return agenda;
        }

        public override List<ModelAgenda> BuscarTodos(bool buscarInativos = false)
        {
            List<ModelAgenda> agendamentos = new List<ModelAgenda>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = buscarInativos ? "SELECT * FROM agenda ORDER BY data, horario" : "SELECT * FROM agenda WHERE ativo = 1 ORDER BY data, horario";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ModelAgenda agenda = new ModelAgenda();
                        agenda.idAgenda = Convert.ToInt32(reader["idAgenda"]);
                        agenda.idAluno = Convert.ToInt32(reader["idAluno"]);
                        agenda.horario = (TimeSpan)reader["horario"];
                        agenda.data = Convert.ToDateTime(reader["data"]);
                        agenda.situacao = reader["situacao"] != DBNull.Value ? reader["situacao"].ToString() : (string?)null;

                        agendamentos.Add(agenda);
                    }
                }
            }
            return agendamentos;
        }

        public override void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public override void Salvar(ModelAgenda obj)
        {
            dynamic agenda = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO agenda (usuarioUltAlt, idAluno, idContrato, horario, data, situacao, ativo, dataCadastro, dataUltAlt, dataCancelamento) 
                                 VALUES (@usuarioUltAlt, @idAluno, @idContrato, @horario, @data, @situacao, @ativo, @dataCadastro, @dataUltAlt, @dataCancelamento)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@idAluno", agenda.idAluno);
                command.Parameters.AddWithValue("@usuarioUltAlt", agenda.usuarioUltAlt);
                command.Parameters.AddWithValue("@idContrato", agenda.idContrato ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@horario", agenda.horario);
                command.Parameters.AddWithValue("@situacao", agenda.situacao ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@data", agenda.data);
                command.Parameters.AddWithValue("@ativo", agenda.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", agenda.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", agenda.dataUltAlt);
                command.Parameters.AddWithValue("@dataCancelamento", agenda.dataCancelamento ?? (object)DBNull.Value);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao salvar o agendamento: " + ex.Message);
                    throw;
                }
            }
        }
        public void CancelarAgendamento(int idAgenda)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE agenda 
                         SET situacao = @situacao, 
                             dataCancelamento = @dataCancelamento, 
                             dataUltAlt = @dataUltAlt 
                         WHERE idAgenda = @idAgenda";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@situacao", "CANCELADO");
                command.Parameters.AddWithValue("@dataCancelamento", DateTime.Now);
                command.Parameters.AddWithValue("@dataUltAlt", DateTime.Now);
                command.Parameters.AddWithValue("@idAgenda", idAgenda);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao cancelar o agendamento: " + ex.Message);
                    throw;
                }
            }
        }
        public int ContarAlunosPorHorarioEDia(TimeSpan horario, string diaSemana)
        {
            int totalAlunos = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT COUNT(*) FROM agenda 
                         WHERE horario = @horario AND 
                               DATENAME(WEEKDAY, data) = @diaSemana AND 
                               ativo = 1";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@horario", horario);
                command.Parameters.AddWithValue("@diaSemana", diaSemana);

                try
                {
                    connection.Open();
                    totalAlunos = (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao contar alunos agendados: " + ex.Message);
                    throw;
                }
            }
            return totalAlunos;
        }

    }
}
