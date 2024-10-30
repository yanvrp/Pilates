using Pilates.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            throw new NotImplementedException();
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
                        agenda.idAluno = Convert.ToInt32(reader["idAluno"]);
                        agenda.idContrato = reader["idContrato"] != DBNull.Value ? Convert.ToInt32(reader["idContrato"]) : (int?)null;
                        agenda.situacao = reader["situacao"] != DBNull.Value ? reader["situacao"].ToString() : (string?)null;
                        agenda.horario = (TimeSpan)reader["horario"];
                        agenda.data = DateTime.Parse(reader["data"].ToString());
                        agenda.Ativo = Convert.ToBoolean(reader["Ativo"]);
                        agenda.dataCadastro = DateTime.Parse(reader["dataCadastro"].ToString());
                        agenda.dataUltAlt = DateTime.Parse(reader["dataUltAlt"].ToString());
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
                string query = "SELECT * FROM agenda ORDER BY data, horario";
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
                string query = @"INSERT INTO agenda (idAluno, idContrato, horario, data, situacao, ativo, dataCadastro, dataUltAlt) 
                                 VALUES (@idAluno, @idContrato, @horario, @data, @situacao, @ativo, @dataCadastro, @dataUltAlt)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@idAluno", agenda.idAluno);
                command.Parameters.AddWithValue("@idContrato", agenda.idContrato ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@horario", agenda.horario);
                command.Parameters.AddWithValue("@situacao", agenda.situacao ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@data", agenda.data);
                command.Parameters.AddWithValue("@ativo", agenda.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", agenda.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", agenda.dataUltAlt);

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
    }
}
