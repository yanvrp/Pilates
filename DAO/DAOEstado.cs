﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilates.DAO
{
    public class DAOEstado<T> : DAO<T>
    {
        public override void Alterar(T obj)
        {
            dynamic estado = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE estado SET Estado = @estado, UF = @UF, idPais = @idPais, ativo = @ativo, dataCadastro = @dataCadastro, dataUltAlt = @dataUltAlt WHERE idEstado = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", estado.idEstado);
                command.Parameters.AddWithValue("@estado", estado.Estado);
                command.Parameters.AddWithValue("@UF", estado.UF);
                command.Parameters.AddWithValue("@idPais", estado.idPais);
                command.Parameters.AddWithValue("@ativo", estado.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", estado.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", estado.dataUltAlt);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public override T BuscarPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM estado WHERE idEstado = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idEstado = Convert.ToInt32(reader["idEstado"]);
                        obj.Estado = reader["Estado"].ToString();
                        obj.UF = reader["UF"].ToString();
                        obj.idPais = Convert.ToInt32(reader["idPais"]);
                        obj.Ativo = Convert.ToBoolean(reader["Ativo"]);
                        obj.dataCadastro = DateTime.Parse(reader["dataCadastro"].ToString());
                        obj.dataUltAlt = DateTime.Parse(reader["dataUltAlt"].ToString());
                        return obj;
                    }
                    else
                    {
                        return default(T); // retorna default se o estado não for encontrado
                    }
                }
            }
        }

        public override List<T> BuscarTodos(bool BuscarInativos = false)
        {
            List<T> estados = new List<T>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = BuscarInativos ? "SELECT * FROM estado" : "SELECT * FROM estado WHERE ativo = 1";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idEstado = Convert.ToInt32(reader["idEstado"]);
                        obj.Estado = reader["Estado"].ToString();
                        obj.UF = reader["UF"].ToString();
                        estados.Add(obj);
                    }
                }
            }

            return estados;
        }

        public override void Deletar(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM estado WHERE idEstado = @id";

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
                        MessageBox.Show("Não é possível excluir o estado, pois ele está sendo utilizado em um cadastro.", "Erro ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao deletar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public string GetNomePaisByEstadoId(int idEstado)
        {
            string nomePais = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT pais.pais FROM estado INNER JOIN pais ON estado.idPais = pais.idPais WHERE estado.idEstado = @idEstado";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idEstado", idEstado);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        nomePais = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro ao obter o nome do país: " + ex.Message);
                }
            }
            return nomePais;
        }
        public override void Salvar(T obj)
        {
            dynamic estado = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO estado (estado, UF, idPais, ativo, dataCadastro, dataUltAlt) VALUES (@estado, @UF, @idPais, @ativo, @dataCadastro, @dataUltAlt)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@estado", estado.Estado);
                command.Parameters.AddWithValue("@UF", estado.UF);
                command.Parameters.AddWithValue("@idPais", estado.idPais);
                command.Parameters.AddWithValue("@ativo", estado.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", estado.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", estado.dataUltAlt);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
