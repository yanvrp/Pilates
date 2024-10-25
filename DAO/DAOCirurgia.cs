using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                connection.Open();
                command.ExecuteNonQuery();
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
