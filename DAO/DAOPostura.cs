using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.DAO
{
    public class DAOPostura<T> : DAO<T>
    {
  
        public DAOPostura()
        {
            
        }
        public override void Alterar(T obj)
        {
            dynamic postura = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE postura SET cabecaPostura = @cabecaPostura, usuarioUltAlt = @usuarioUltAlt, ombroPostura = @ombroPostura, escapuloPostura = @escapuloPostura, maosPostura = @maosPostura, cervicalPostura = @cervicalPostura, toracicaPostura = @toracicaPostura, lombarPostura = @lombarPostura, quadrilPostura = @quadrilPostura, joelhoPostura = @joelhoPostura, pesPostura = @pesPostura, outros = @outros, idAluno = @idAluno, dataCadastro = @dataCadastro, dataUltAlt = @dataUltAlt, ativo = @ativo, titulo = @titulo WHERE idPostura = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", postura.idPostura);
                command.Parameters.AddWithValue("@titulo", postura.titulo);
                command.Parameters.AddWithValue("@usuarioUltAlt", postura.usuarioUltAlt);
                command.Parameters.AddWithValue("@cabecaPostura", postura.cabecaPostura);
                command.Parameters.AddWithValue("@ombroPostura", postura.ombroPostura);
                command.Parameters.AddWithValue("@escapuloPostura", postura.escapuloPostura);
                command.Parameters.AddWithValue("@maosPostura", postura.maosPostura);
                command.Parameters.AddWithValue("@cervicalPostura", postura.cervicalPostura);
                command.Parameters.AddWithValue("@toracicaPostura", postura.toracicaPostura);
                command.Parameters.AddWithValue("@lombarPostura", postura.lombarPostura);
                command.Parameters.AddWithValue("@quadrilPostura", postura.quadrilPostura);
                command.Parameters.AddWithValue("@joelhoPostura", postura.joelhoPostura);
                command.Parameters.AddWithValue("@pesPostura", postura.pesPostura);
                command.Parameters.AddWithValue("@outros", postura.Outros);
                command.Parameters.AddWithValue("@idAluno", postura.idAluno);
                command.Parameters.AddWithValue("@dataCadastro", postura.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", postura.dataUltAlt);
                command.Parameters.AddWithValue("@ativo", postura.Ativo);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public override T BuscarPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM postura WHERE idPostura = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idPostura = Convert.ToInt32(reader["idPostura"]);
                        obj.cabecaPostura = reader["cabecaPostura"].ToString();
                        obj.titulo = reader["titulo"].ToString();
                        obj.usuarioUltAlt = reader["usuarioUltAlt"].ToString();
                        obj.ombroPostura = reader["ombroPostura"].ToString();
                        obj.escapuloPostura = reader["escapuloPostura"].ToString();
                        obj.maosPostura = reader["maosPostura"].ToString();
                        obj.cervicalPostura = reader["cervicalPostura"].ToString();
                        obj.toracicaPostura = reader["toracicaPostura"].ToString();
                        obj.lombarPostura = reader["lombarPostura"].ToString();
                        obj.quadrilPostura = reader["quadrilPostura"].ToString();
                        obj.joelhoPostura = reader["joelhoPostura"].ToString();
                        obj.pesPostura = reader["pesPostura"].ToString();
                        obj.Outros = reader["outros"].ToString();
                        obj.dataCadastro = DateTime.Parse(reader["dataCadastro"].ToString());
                        obj.dataUltAlt = DateTime.Parse(reader["dataUltAlt"].ToString());
                        obj.idAluno = Convert.ToInt32(reader["idAluno"]);
                        obj.Ativo = Convert.ToBoolean(reader["Ativo"]);
                        return obj;
                    }
                    else
                    {
                        return default(T); // retorna default se a postura não foi encontrada
                    }
                }
            }
        }
        public string GetNomeAlunoByPosturaId(int idPostura)
        {
            string nomeAluno = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT aluno.Aluno FROM postura INNER JOIN aluno ON postura.idAluno = aluno.idAluno WHERE postura.idPostura = @idPostura";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idPostura", idPostura);

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
            List<T> postura = new List<T>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = BuscarInativos ? "SELECT * FROM postura" : "SELECT * FROM postura WHERE ativo = 1";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idPostura = Convert.ToInt32(reader["idPostura"]);
                        obj.titulo = reader["Titulo"].ToString();
                        postura.Add(obj);
                    }
                }
            }

            return postura;
        }

        public override void Deletar(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM postura WHERE idPostura = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public override void Salvar(T obj)
        {
            dynamic postura = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO postura (usuarioUltAlt, cabecaPostura, ombroPostura, escapuloPostura, maosPostura, cervicalPostura, toracicaPostura, lombarPostura, quadrilPostura, joelhoPostura, pesPostura, idAluno, dataCadastro, dataUltAlt, ativo, titulo, outros) VALUES (@usuarioUltAlt, @cabecaPostura, @ombroPostura, @escapuloPostura, @maosPostura, @cervicalPostura, @toracicaPostura, @lombarPostura, @quadrilPostura, @joelhoPostura, @pesPostura, @idAluno, @dataCadastro, @dataUltAlt, @ativo, @titulo, @outros)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", postura.idPostura);
                command.Parameters.AddWithValue("@usuarioUltAlt", postura.usuarioUltAlt);
                command.Parameters.AddWithValue("@cabecaPostura", postura.cabecaPostura);
                command.Parameters.AddWithValue("@ombroPostura", postura.ombroPostura);
                command.Parameters.AddWithValue("@escapuloPostura", postura.escapuloPostura);
                command.Parameters.AddWithValue("@maosPostura", postura.maosPostura);
                command.Parameters.AddWithValue("@cervicalPostura", postura.cervicalPostura);
                command.Parameters.AddWithValue("@toracicaPostura", postura.toracicaPostura);
                command.Parameters.AddWithValue("@lombarPostura", postura.lombarPostura);
                command.Parameters.AddWithValue("@quadrilPostura", postura.quadrilPostura);
                command.Parameters.AddWithValue("@joelhoPostura", postura.joelhoPostura);
                command.Parameters.AddWithValue("@pesPostura", postura.pesPostura);
                command.Parameters.AddWithValue("@outros", postura.Outros);
                command.Parameters.AddWithValue("@idAluno", postura.idAluno);
                command.Parameters.AddWithValue("@dataCadastro", postura.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", postura.dataUltAlt);
                command.Parameters.AddWithValue("@ativo", postura.Ativo);
                command.Parameters.AddWithValue("@titulo", postura.titulo);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
