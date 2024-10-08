﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.DAO
{
    public class DAODores<T> : DAO<T>
    {
        public DAODores() : base() { }
        public override void Alterar(T obj)
        {
            dynamic dores = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE dores SET dores = @dores, descricao = @descricao, ativo = @ativo, dataCadastro = @dataCadastro, dataUltAlt = @dataUltAlt WHERE idDores = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", dores.idDores);
                command.Parameters.AddWithValue("@dores", dores.dores);
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

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public override void Salvar(T obj)
        {
            dynamic dores = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO dores (dores, descricao, ativo, dataCadastro, dataUltAlt) VALUES (@dores, @descricao, @ativo, @dataCadastro, @dataUltAlt)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@dores", dores.dores);
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
