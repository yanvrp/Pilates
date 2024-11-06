using Pilates.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.DAO
{
    public class DAOPrograma<T> : DAO<T>
    {
        public int BuscarUltimoCodigo()
        {
            int proximoCodigo = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(idPrograma) FROM programa";
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
        public override void Alterar(T obj)
        {
            dynamic programa = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE programa SET numeroAulas = @numeroAulas, usuarioUltAlt = @usuarioUltAlt, Valor = @valor, tipoPrograma = @tipoPrograma, Ativo = @ativo, dataCadastro = @dataCadastro, dataUltAlt = @dataUltAlt, titulo = @titulo WHERE idPrograma = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", programa.idPrograma);
                command.Parameters.AddWithValue("@titulo", programa.titulo);
                command.Parameters.AddWithValue("@usuarioUltAlt", programa.usuarioUltAlt);
                command.Parameters.AddWithValue("@numeroAulas", programa.numeroAulas);
                command.Parameters.AddWithValue("@valor", programa.Valor);
                command.Parameters.AddWithValue("@tipoPrograma", programa.tipoPrograma);
                command.Parameters.AddWithValue("@ativo", programa.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", programa.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", programa.dataUltAlt);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public ModelPrograma getPrograma(int id)
        {
            ModelPrograma programa = null;

            string query = "SELECT * FROM programa WHERE idPrograma = @idPrograma AND ativo = 1";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@idPrograma", id);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        programa = new ModelPrograma
                        {
                            idPrograma = reader.GetInt32(reader.GetOrdinal("idPrograma")),
                            titulo = reader.GetString(reader.GetOrdinal("titulo")),
                            numeroAulas = reader.GetInt32(reader.GetOrdinal("numeroAulas")),
                            tipoPrograma = reader.GetString(reader.GetOrdinal("tipoPrograma")),
                            Valor = reader.GetDecimal(reader.GetOrdinal("Valor"))
                        };
                    }
                }
            }
            return programa;
        }

        public override T BuscarPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM programa WHERE idPrograma = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idPrograma = Convert.ToInt32(reader["idPrograma"]);
                        obj.titulo = reader["titulo"].ToString();
                        obj.usuarioUltAlt = reader["usuarioUltAlt"].ToString();
                        obj.numeroAulas = Convert.ToInt32(reader["numeroAulas"]);
                        obj.tipoPrograma = reader["tipoPrograma"].ToString();
                        obj.Valor = Convert.ToDecimal(reader["Valor"]);
                        obj.Ativo = Convert.ToBoolean(reader["Ativo"]);
                        obj.dataCadastro = DateTime.Parse(reader["dataCadastro"].ToString());
                        obj.dataUltAlt = DateTime.Parse(reader["dataUltAlt"].ToString());
                        return obj;
                    }
                    else
                    {
                        return default(T); // retorna default se a evolucao não for encontrado
                    }
                }
            }
        }

        public override List<T> BuscarTodos(bool BuscarInativos = false)
        {
            List<T> programa = new List<T>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = BuscarInativos ? "SELECT * FROM programa" : "SELECT * FROM programa WHERE ativo = 1";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idPrograma = Convert.ToInt32(reader["idPrograma"]);
                        obj.titulo = reader["titulo"].ToString();
                        obj.Valor = Convert.ToDecimal(reader["valor"]);
                        programa.Add(obj);
                    }
                }
            }
            return programa;
        }

        public override void Deletar(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM programa WHERE idPrograma = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public override void Salvar(T obj)
        {
            {
                dynamic programa = obj;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO programa (usuarioUltAlt, titulo, numeroAulas, Valor, tipoPrograma, Ativo, dataCadastro, dataUltAlt) VALUES (@usuarioUltAlt, @titulo, @numeroAulas, @valor, @tipoPrograma, @ativo, @dataCadastro, @dataUltAlt)";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@id", programa.idPrograma);
                    command.Parameters.AddWithValue("@titulo", programa.titulo);
                    command.Parameters.AddWithValue("@usuarioUltAlt", programa.usuarioUltAlt);
                    command.Parameters.AddWithValue("@numeroAulas", programa.numeroAulas);
                    command.Parameters.AddWithValue("@valor", programa.Valor);
                    command.Parameters.AddWithValue("@tipoPrograma", programa.tipoPrograma);
                    command.Parameters.AddWithValue("@ativo", programa.Ativo);
                    command.Parameters.AddWithValue("@dataCadastro", programa.dataCadastro);
                    command.Parameters.AddWithValue("@dataUltAlt", programa.dataUltAlt);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
