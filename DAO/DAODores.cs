using Pilates.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilates.DAO
{
    public class DAODores<T> : DAO<T>
    {
        public DAODores() : base() { }
        public int BuscarUltimoCodigo()
        {
            int proximoCodigo = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(idDores) FROM dores";
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
        public ModelDores getDores(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT dores, descricao FROM dores WHERE idDores = @id AND Ativo = 1";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ModelDores
                        {
                            dores = reader["dores"].ToString(),
                            descricao = reader["descricao"].ToString()
                        };
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public override void Alterar(T obj)
        {
            dynamic dores = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE dores SET dores = @dores, usuarioUltAlt = @usuarioUltAlt, descricao = @descricao, ativo = @ativo, dataCadastro = @dataCadastro, dataUltAlt = @dataUltAlt WHERE idDores = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", dores.idDores);
                command.Parameters.AddWithValue("@dores", dores.dores);
                command.Parameters.AddWithValue("@usuarioUltAlt", dores.usuarioUltAlt);
                command.Parameters.AddWithValue("@descricao", dores.descricao);
                command.Parameters.AddWithValue("@ativo", dores.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", dores.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", dores.dataUltAlt);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public override T BuscarPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM dores WHERE idDores = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idDores = Convert.ToInt32(reader["idDores"]);
                        obj.dores = reader["dores"].ToString();
                        obj.usuarioUltAlt = reader["usuarioUltAlt"].ToString();
                        obj.descricao = reader["descricao"].ToString();
                        obj.Ativo = Convert.ToBoolean(reader["Ativo"]);
                        obj.dataCadastro = DateTime.Parse(reader["dataCadastro"].ToString());
                        obj.dataUltAlt = DateTime.Parse(reader["dataUltAlt"].ToString());
                        return obj;
                    }
                    else
                    {
                        return default(T); // retorna default se as dores não for encontrado
                    }
                }
            }
        }

        public override List<T> BuscarTodos(bool BuscarInativos = false)
        {
            List<T> dores = new List<T>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = BuscarInativos ? "SELECT * FROM dores" : "SELECT * FROM dores WHERE ativo = 1";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idDores = Convert.ToInt32(reader["idDores"]);
                        obj.dores = reader["dores"].ToString();
                        obj.descricao = reader["descricao"].ToString();
                        dores.Add(obj);
                    }
                }
            }
            return dores;
        }

        public override void Deletar(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM dores WHERE idDores = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    //verifica se a exceção está relacionada a uma restrição de chave estrangeira (uso em algum cadastro)
                    if (ex.Number == 547) //código de erro para conflito de chave estrangeira
                    {
                        MessageBox.Show("Não é possível excluir a Dor, pois ela está sendo utilizado em um cadastro.", "Erro ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao deletar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public override void Salvar(T obj)
        {
            dynamic dores = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO dores (dores, usuarioUltAlt, descricao, ativo, dataCadastro, dataUltAlt) VALUES (@dores, @usuarioUltAlt, @descricao, @ativo, @dataCadastro, @dataUltAlt)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@dores", dores.dores);
                command.Parameters.AddWithValue("@usuarioUltAlt", dores.usuarioUltAlt);
                command.Parameters.AddWithValue("@descricao", dores.descricao);
                command.Parameters.AddWithValue("@ativo", dores.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", dores.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", dores.dataUltAlt);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
