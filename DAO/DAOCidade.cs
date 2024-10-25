﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilates.DAO
{
    public class DAOCidade<T> : DAO<T>
    {
        public int BuscarUltimoCodigo()
        {
            int proximoCodigo = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(idCidade) FROM cidade";
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
            dynamic cidade = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE cidade SET cidade = @cidade, DDD = @DDD, idEstado = @idEstado, ativo = @ativo, dataUltAlt = @dataUltAlt WHERE idCidade = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", cidade.idCidade);
                command.Parameters.AddWithValue("@cidade", cidade.Cidade);
                command.Parameters.AddWithValue("@DDD", cidade.DDD);
                command.Parameters.AddWithValue("@idEstado", cidade.idEstado);
                command.Parameters.AddWithValue("@ativo", cidade.Ativo);
                command.Parameters.AddWithValue("@dataUltAlt", cidade.dataUltAlt);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public override T BuscarPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM cidade WHERE idCidade = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idCidade = Convert.ToInt32(reader["idCidade"]);
                        obj.Cidade = reader["cidade"].ToString();
                        obj.DDD = Convert.ToInt32(reader["DDD"]);
                        obj.idEstado = Convert.ToInt32(reader["idEstado"]);
                        obj.Ativo = Convert.ToBoolean(reader["Ativo"]);
                        obj.dataCadastro = DateTime.Parse(reader["dataCadastro"].ToString());
                        obj.dataUltAlt = DateTime.Parse(reader["dataUltAlt"].ToString());
                        return obj;
                    }
                    else
                    {
                        return default(T); // retorna default se o cidade não for encontrada
                    }
                }
            }
            }

        public override List<T> BuscarTodos(bool BuscarInativos = false)
        {
            List<T> cidades = new List<T>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = BuscarInativos ? "SELECT * FROM cidade" : "SELECT * FROM cidade WHERE ativo = 1";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idCidade = Convert.ToInt32(reader["idCidade"]);
                        obj.Cidade = reader["cidade"].ToString();
                        obj.DDD = Convert.ToInt32(reader["DDD"]);
                        obj.idEstado = Convert.ToInt32(reader["idEstado"]);
                        cidades.Add(obj);
                    }
                }
            }

            return cidades;
        }

        public override void Deletar(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM cidade WHERE idCidade = @id";

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
                        MessageBox.Show("Não é possível excluir a cidade, pois ele está sendo utilizado em um cadastro.", "Erro ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao deletar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public string GetNomeEstadoByCidadeId(int idCidade)
        {
            string nomeEstado = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT estado.estado FROM cidade INNER JOIN estado ON cidade.idEstado = estado.idEstado WHERE cidade.idCidade = @idCidade";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idCidade", idCidade);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        nomeEstado = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro ao obter o nome do estado: " + ex.Message);
                }
            }
            return nomeEstado;
        }
        public override void Salvar(T obj)
        {
            dynamic cidade = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO cidade (cidade, DDD, idEstado, ativo, dataCadastro, dataUltAlt) VALUES (@cidade, @DDD, @idEstado, @ativo, @dataCadastro, @dataUltAlt)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Cidade", cidade.Cidade);
                command.Parameters.AddWithValue("@DDD", cidade.DDD);
                command.Parameters.AddWithValue("@idEstado", cidade.idEstado);
                command.Parameters.AddWithValue("@ativo", cidade.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", cidade.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", cidade.dataUltAlt);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
