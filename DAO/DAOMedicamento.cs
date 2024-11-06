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
    public class DAOMedicamento<T> : DAO<T>
    {
        public DAOMedicamento() : base() { }
        public int BuscarUltimoCodigo()
        {
            int proximoCodigo = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(idMedicamento) FROM medicamento";
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
        public ModelMedicamento getMedicamento(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT medicamento, descricao FROM medicamento WHERE idMedicamento = @id AND Ativo = 1";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ModelMedicamento
                        {
                            medicamento = reader["medicamento"].ToString(),
                            descricao = reader["descricao"].ToString(),
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
            dynamic medicamento = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE medicamento SET medicamento = @medicamento, usuarioUltAlt = @usuarioUltAlt, descricao = @descricao, ativo = @ativo, dataCadastro = @dataCadastro, dataUltAlt = @dataUltAlt WHERE idMedicamento = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", medicamento.idMedicamento);
                command.Parameters.AddWithValue("@medicamento", medicamento.medicamento);
                command.Parameters.AddWithValue("@usuarioUltAlt", medicamento.usuarioUltAlt);
                command.Parameters.AddWithValue("@descricao", medicamento.descricao);
                command.Parameters.AddWithValue("@ativo", medicamento.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", medicamento.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", medicamento.dataUltAlt);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public override T BuscarPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM medicamento WHERE idMedicamento = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idMedicamento = Convert.ToInt32(reader["idMedicamento"]);
                        obj.medicamento = reader["medicamento"].ToString();
                        obj.usuarioUltAlt = reader["usuarioUltAlt"].ToString();
                        obj.descricao = reader["descricao"].ToString();
                        obj.Ativo = Convert.ToBoolean(reader["Ativo"]);
                        obj.dataCadastro = DateTime.Parse(reader["dataCadastro"].ToString());
                        obj.dataUltAlt = DateTime.Parse(reader["dataUltAlt"].ToString());
                        return obj;
                    }
                    else
                    {
                        return default(T); // retorna default se o medicamento não for encontrado
                    }
                }
            }
        }

        public override List<T> BuscarTodos(bool BuscarInativos = false)
        {
            List<T> medicamento = new List<T>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = BuscarInativos ? "SELECT * FROM medicamento" : "SELECT * FROM medicamento WHERE ativo = 1";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idMedicamento = Convert.ToInt32(reader["idMedicamento"]);
                        obj.medicamento = reader["medicamento"].ToString();
                        obj.descricao = reader["descricao"].ToString();
                        medicamento.Add(obj);
                    }
                }
            }
            return medicamento;
        }

        public override void Deletar(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM medicamento WHERE idMedicamento = @id";

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
                        MessageBox.Show("Não é possível excluiro medicamento, pois ele está sendo utilizado em um cadastro.", "Erro ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            dynamic medicamento = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO medicamento (usuarioUltAlt, medicamento, descricao, ativo, dataCadastro, dataUltAlt) VALUES (@usuarioUltAlt, @medicamento, @descricao, @ativo, @dataCadastro, @dataUltAlt)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@usuarioUltAlt", medicamento.usuarioUltAlt);
                command.Parameters.AddWithValue("@medicamento", medicamento.medicamento);
                command.Parameters.AddWithValue("@descricao", medicamento.descricao);
                command.Parameters.AddWithValue("@ativo", medicamento.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", medicamento.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", medicamento.dataUltAlt);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
