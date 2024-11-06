using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilates.DAO
{
    public class DAOEvolucao<T> : DAO<T>
    {
        public DAOEvolucao() 
        {
            
        }
        public override void Alterar(T obj)
        {
            dynamic evolucao = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE evolucao SET idAluno = @idAluno, usuarioUltAlt = @usuarioUltAlt, observacao = @observacao, ativo = @ativo, dataCadastro = @dataCadastro, dataUltAlt = @dataUltAlt, titulo = @titulo WHERE idEvolucao = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", evolucao.idEvolucao);
                command.Parameters.AddWithValue("@titulo", evolucao.titulo);
                command.Parameters.AddWithValue("@usuarioUltAlt", evolucao.usuarioUltAlt);
                command.Parameters.AddWithValue("@idAluno", evolucao.idAluno);
                command.Parameters.AddWithValue("@observacao", evolucao.observacao);
                command.Parameters.AddWithValue("@ativo", evolucao.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", evolucao.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", evolucao.dataUltAlt);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public override T BuscarPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM evolucao WHERE idEvolucao = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idEvolucao = Convert.ToInt32(reader["idEvolucao"]);
                        obj.titulo = reader["titulo"].ToString();
                        obj.usuarioUltAlt = reader["usuarioUltAlt"].ToString();
                        obj.idAluno = Convert.ToInt32(reader["idAluno"]);
                        obj.observacao = reader["observacao"].ToString();
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
        public string GetNomeAlunoByEvolucaoId(int idEvolucao)
        {
            string nomeAluno = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT aluno.Aluno FROM evolucao INNER JOIN aluno ON evolucao.idAluno = aluno.idAluno WHERE evolucao.idEvolucao = @idEvolucao";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idEvolucao", idEvolucao);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        nomeAluno = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro ao obter o nome do Aluno: " + ex.Message);
                }
            }
            return nomeAluno;
        }
        public string GetNomeAlunoByAlunoId(int idAluno)
        {
            string nomeAluno = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT aluno.Aluno FROM aluno WHERE aluno.idAluno = @idAluno";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idAluno", idAluno);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        nomeAluno = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro ao obter o nome do Aluno: " + ex.Message);
                }
            }
            return nomeAluno;
        }
        public override List<T> BuscarTodos(bool BuscarInativos = false)
        {
            List<T> evolucao = new List<T>();
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = BuscarInativos ? "SELECT * FROM evolucao" : "SELECT * FROM evolucao WHERE ativo = 1";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idEvolucao = Convert.ToInt32(reader["idEvolucao"]);
                        obj.titulo = reader["Titulo"].ToString();
                        evolucao.Add(obj);
                    }
                }
            }

            return evolucao;
        }

        public override void Deletar(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM evolucao WHERE idEvolucao = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public override void Salvar(T obj)
        {
            dynamic evolucao = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO evolucao (usuarioUltAlt, idAluno, observacao, ativo, dataCadastro, dataUltAlt, titulo) VALUES (@usuarioUltAlt, @idAluno, @observacao, @ativo, @dataCadastro, @dataUltAlt, @titulo)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@idAluno", evolucao.idAluno);
                command.Parameters.AddWithValue("@titulo", evolucao.titulo);
                command.Parameters.AddWithValue("@usuarioUltAlt", evolucao.usuarioUltAlt);
                command.Parameters.AddWithValue("@observacao", evolucao.observacao);
                command.Parameters.AddWithValue("@ativo", evolucao.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", evolucao.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", evolucao.dataUltAlt);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
