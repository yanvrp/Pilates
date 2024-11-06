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
    public class DAODoenca<T> : DAO<T>
    {
        public DAODoenca() : base() { }
        public int BuscarUltimoCodigo()
        {
            int proximoCodigo = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(idDoenca) FROM doenca";
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
        public ModelDoenca getDoenca(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT doenca, descricao, cid FROM doenca WHERE idDoenca = @id AND Ativo = 1";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ModelDoenca
                        {
                            doenca = reader["doenca"].ToString(),
                            descricao = reader["descricao"].ToString(),
                            CID = reader["cid"].ToString()
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
            dynamic doenca = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE doenca SET doenca = @doenca, CID = @CID, descricao = @descricao, ativo = @ativo, dataCadastro = @dataCadastro, dataUltAlt = @dataUltAlt WHERE idDoenca = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", doenca.idDoenca);
                command.Parameters.AddWithValue("@doenca", doenca.doenca);
                command.Parameters.AddWithValue("@CID", doenca.CID);
                command.Parameters.AddWithValue("@descricao", doenca.descricao);
                command.Parameters.AddWithValue("@ativo", doenca.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", doenca.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", doenca.dataUltAlt);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public override T BuscarPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM doenca WHERE idDoenca = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idDoenca = Convert.ToInt32(reader["idDoenca"]);
                        obj.doenca = reader["doenca"].ToString();
                        obj.descricao = reader["descricao"].ToString();
                        obj.CID = reader["CID"].ToString();
                        obj.Ativo = Convert.ToBoolean(reader["Ativo"]);
                        obj.dataCadastro = DateTime.Parse(reader["dataCadastro"].ToString());
                        obj.dataUltAlt = DateTime.Parse(reader["dataUltAlt"].ToString());
                        return obj;
                    }
                    else
                    {
                        return default(T); // retorna default se a doença não for encontrado
                    }
                }
            }
        }

        public override List<T> BuscarTodos(bool BuscarInativos = false)
        {
            List<T> doenca = new List<T>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = BuscarInativos ? "SELECT * FROM doenca" : "SELECT * FROM doenca WHERE ativo = 1";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idDoenca = Convert.ToInt32(reader["idDoenca"]);
                        obj.doenca = reader["doenca"].ToString();
                        obj.CID = reader["CID"].ToString();
                        obj.descricao = reader["descricao"].ToString();
                        doenca.Add(obj);
                    }
                }
            }
            return doenca;
        }

        public override void Deletar(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM doenca WHERE idDoenca = @id";

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
                        MessageBox.Show("Não é possível excluir a doença, pois ela está sendo utilizado em um cadastro.", "Erro ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            dynamic doenca = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO doenca (doenca, CID, descricao, ativo, dataCadastro, dataUltAlt) VALUES (@doenca, @CID, @descricao, @ativo, @dataCadastro, @dataUltAlt)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@doenca", doenca.doenca);
                command.Parameters.AddWithValue("@CID", doenca.CID);
                command.Parameters.AddWithValue("@descricao", doenca.descricao);
                command.Parameters.AddWithValue("@ativo", doenca.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", doenca.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", doenca.dataUltAlt);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
