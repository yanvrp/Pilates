using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.DAO
{
    public class DAOMedicamento<T> : DAO<T>
    {
        public DAOMedicamento() : base() { }
        public override void Alterar(T obj)
        {
            dynamic medicamento = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE medicamento SET medicamento = @medicamento, descricao = @descricao, ativo = @ativo, dataCadastro = @dataCadastro, dataUltAlt = @dataUltAlt WHERE idMedicamento = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", medicamento.idMedicamento);
                command.Parameters.AddWithValue("@medicamento", medicamento.medicamento);
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

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public override void Salvar(T obj)
        {
            dynamic medicamento = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO medicamento (medicamento, descricao, ativo, dataCadastro, dataUltAlt) VALUES (@medicamento, @descricao, @ativo, @dataCadastro, @dataUltAlt)";

                SqlCommand command = new SqlCommand(query, connection);

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
