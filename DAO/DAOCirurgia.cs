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
    public class DAOCirurgia<T> : DAO<T>
    {
        public DAOCirurgia() : base() { }
        public int BuscarUltimoCodigo()
        {
            int proximoCodigo = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(idCirurgia) FROM cirurgia";
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
        public ModelCirurgia getCirurgia(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT cirurgia, descricao FROM cirurgia WHERE idCirurgia = @id AND Ativo = 1";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ModelCirurgia
                        {
                            cirurgia = reader["cirurgia"].ToString(),
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
            dynamic cirurgia = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE cirurgia SET cirurgia = @cirurgia, descricao = @descricao, ativo = @ativo, dataCadastro = @dataCadastro, dataUltAlt = @dataUltAlt WHERE idCirurgia = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", cirurgia.idCirurgia);
                command.Parameters.AddWithValue("@cirurgia", cirurgia.cirurgia);
                command.Parameters.AddWithValue("@descricao", cirurgia.descricao);
                command.Parameters.AddWithValue("@ativo", cirurgia.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", cirurgia.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", cirurgia.dataUltAlt);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public override T BuscarPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM cirurgia WHERE idCirurgia = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idCirurgia = Convert.ToInt32(reader["idCirurgia"]);
                        obj.cirurgia = reader["cirurgia"].ToString();
                        obj.descricao = reader["descricao"].ToString();
                        obj.Ativo = Convert.ToBoolean(reader["Ativo"]);
                        obj.dataCadastro = DateTime.Parse(reader["dataCadastro"].ToString());
                        obj.dataUltAlt = DateTime.Parse(reader["dataUltAlt"].ToString());
                        return obj;
                    }
                    else
                    {
                        return default(T); // retorna default se a cirurgia não for encontrado
                    }
                }
            }
        }

        public override List<T> BuscarTodos(bool BuscarInativos = false)
        {
            List<T> cirurgia = new List<T>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = BuscarInativos ? "SELECT * FROM cirurgia" : "SELECT * FROM cirurgia WHERE ativo = 1";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idCirurgia = Convert.ToInt32(reader["idCirurgia"]);
                        obj.cirurgia = reader["cirurgia"].ToString();
                        obj.descricao = reader["descricao"].ToString();
                        cirurgia.Add(obj);
                    }
                }
            }
            return cirurgia;
        }

        public override void Deletar(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM cirurgia WHERE idCirurgia = @id";

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
                        MessageBox.Show("Não é possível excluir a cirurgia, pois ela está sendo utilizado em um cadastro.", "Erro ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            dynamic cirurgia = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO cirurgia (cirurgia, descricao, ativo, dataCadastro, dataUltAlt) VALUES (@cirurgia, @descricao, @ativo, @dataCadastro, @dataUltAlt)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@cirurgia", cirurgia.cirurgia);
                command.Parameters.AddWithValue("@descricao", cirurgia.descricao);
                command.Parameters.AddWithValue("@ativo", cirurgia.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", cirurgia.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", cirurgia.dataUltAlt);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
