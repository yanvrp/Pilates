using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilates.DAO
{
    public class DAOProfissao<T> : DAO<T>
    {
        public DAOProfissao() : base() { }
        public int BuscarUltimoCodigo()
        {
            int proximoCodigo = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(idProfissao) FROM profissao";
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
        public string getProfissao(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT profissao FROM profissao WHERE idProfissao = @id AND Ativo = 1";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader["profissao"].ToString();
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
            dynamic profissao = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE profissao SET profissao = @profissao, descricao = @descricao, ativo = @ativo, dataCadastro = @dataCadastro, dataUltAlt = @dataUltAlt WHERE idProfissao = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", profissao.idProfissao);
                command.Parameters.AddWithValue("@profissao", profissao.profissao);
                command.Parameters.AddWithValue("@descricao", profissao.descricao);
                command.Parameters.AddWithValue("@ativo", profissao.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", profissao.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", profissao.dataUltAlt);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public override T BuscarPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM profissao WHERE idProfissao = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idProfissao = Convert.ToInt32(reader["idProfissao"]);
                        obj.profissao = reader["profissao"].ToString();
                        obj.descricao = reader["descricao"].ToString();
                        obj.Ativo = Convert.ToBoolean(reader["Ativo"]);
                        obj.dataCadastro = DateTime.Parse(reader["dataCadastro"].ToString());
                        obj.dataUltAlt = DateTime.Parse(reader["dataUltAlt"].ToString());
                        return obj;
                    }
                    else
                    {
                        return default(T); // retorna default se a profissao não for encontrado
                    }
                }
            }
        }

        public override List<T> BuscarTodos(bool BuscarInativos = false)
        {
            List<T> profissao = new List<T>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = BuscarInativos ? "SELECT * FROM profissao" : "SELECT * FROM profissao WHERE ativo = 1";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idProfissao = Convert.ToInt32(reader["idProfissao"]);
                        obj.profissao = reader["profissao"].ToString();
                        obj.descricao = reader["descricao"].ToString();
                        profissao.Add(obj);
                    }
                }
            }
            return profissao;
        }

        public override void Deletar(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM profissao WHERE idProfissao = @id";

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
                        MessageBox.Show("Não é possível excluir a profissão, pois ele está sendo utilizado em um cadastro.", "Erro ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            dynamic profissao = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO profissao (profissao, descricao, ativo, dataCadastro, dataUltAlt) VALUES (@profissao, @descricao, @ativo, @dataCadastro, @dataUltAlt)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@profissao", profissao.profissao);
                command.Parameters.AddWithValue("@descricao", profissao.descricao);
                command.Parameters.AddWithValue("@ativo", profissao.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", profissao.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", profissao.dataUltAlt);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
