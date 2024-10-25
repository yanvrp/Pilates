using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.DAO
{
    public class DAOGestacao<T> : DAO<T>
    {
        public DAOGestacao() : base() { }
        public int BuscarUltimoCodigo()
        {
            int proximoCodigo = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(idGestacao) FROM gestacao";
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
            dynamic gestacao = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE gestacao SET gestacao = @gestacao, descricao = @descricao, ativo = @ativo, dataCadastro = @dataCadastro, dataUltAlt = @dataUltAlt WHERE idGestacao = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", gestacao.idGestacao);
                command.Parameters.AddWithValue("@gestacao", gestacao.gestacao);
                command.Parameters.AddWithValue("@descricao", gestacao.descricao);
                command.Parameters.AddWithValue("@ativo", gestacao.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", gestacao.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", gestacao.dataUltAlt);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public override T BuscarPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM gestacao WHERE idGestacao = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idGestacao = Convert.ToInt32(reader["idGestacao"]);
                        obj.gestacao = reader["gestacao"].ToString();
                        obj.descricao = reader["descricao"].ToString();
                        obj.Ativo = Convert.ToBoolean(reader["Ativo"]);
                        obj.dataCadastro = DateTime.Parse(reader["dataCadastro"].ToString());
                        obj.dataUltAlt = DateTime.Parse(reader["dataUltAlt"].ToString());
                        return obj;
                    }
                    else
                    {
                        return default(T); // retorna default se a gestacao não for encontrado
                    }
                }
            }
        }

        public override List<T> BuscarTodos(bool BuscarInativos = false)
        {
            List<T> gestacao = new List<T>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = BuscarInativos ? "SELECT * FROM gestacao" : "SELECT * FROM gestacao WHERE ativo = 1";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idGestacao = Convert.ToInt32(reader["idGestacao"]);
                        obj.gestacao = reader["gestacao"].ToString();
                        obj.descricao = reader["descricao"].ToString();
                        gestacao.Add(obj);
                    }
                }
            }
            return gestacao;
        }

        public override void Deletar(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM gestacao WHERE idGestacao = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public override void Salvar(T obj)
        {
            dynamic gestacao = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO gestacao (gestacao, descricao, ativo, dataCadastro, dataUltAlt) VALUES (@gestacao, @descricao, @ativo, @dataCadastro, @dataUltAlt)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@gestacao", gestacao.gestacao);
                command.Parameters.AddWithValue("@descricao", gestacao.descricao);
                command.Parameters.AddWithValue("@ativo", gestacao.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", gestacao.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", gestacao.dataUltAlt);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
