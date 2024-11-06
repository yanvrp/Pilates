﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilates.DAO
{
    public class DAOFormaPagamento<T> : DAO<T>
    {
        public DAOFormaPagamento() : base()
        { 
        }
        public int BuscarUltimoCodigo()
        {
            int proximoCodigo = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(idFormaPagamento) FROM formaPagamento";
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
            dynamic formaPagamento = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE formaPagamento SET formaPagamento = @formaPagamento, usuarioUltAlt = @usuarioUltAlt, ativo = @ativo, dataCadastro = @dataCadastro, dataUltAlt = @dataUltAlt WHERE idFormaPagamento = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", formaPagamento.idFormaPagamento);
                command.Parameters.AddWithValue("@formaPagamento", formaPagamento.formaPagamento);
                command.Parameters.AddWithValue("@usuarioUltAlt", formaPagamento.usuarioUltAlt);
                command.Parameters.AddWithValue("@ativo", formaPagamento.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", formaPagamento.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", formaPagamento.dataUltAlt);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public override void Deletar(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM formaPagamento WHERE idFormaPagamento = @id";

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
                        MessageBox.Show("Não é possível excluir a Forma de Pagamento, pois ela está sendo utilizada em um cadastro.", "Erro ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao deletar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public override List<T> BuscarTodos(bool incluiInativos = false)
        {
            List<T> formaPagamento = new List<T>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = incluiInativos ? "SELECT * FROM formaPagamento" : "SELECT * FROM formaPagamento WHERE ativo = 1";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idFormaPagamento = Convert.ToInt32(reader["idFormaPagamento"]);
                        obj.formaPagamento = reader["formaPagamento"].ToString();
                        formaPagamento.Add(obj);
                    }
                }
            }
            return formaPagamento;
        }

        public override T BuscarPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM formaPagamento WHERE idFormaPagamento = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idFormaPagamento = Convert.ToInt32(reader["idFormaPagamento"]);
                        obj.formaPagamento = reader["formaPagamento"].ToString();
                        obj.usuarioUltAlt = reader["usuarioUltAlt"].ToString();
                        obj.Ativo = Convert.ToBoolean(reader["Ativo"]);
                        obj.dataCadastro = DateTime.Parse(reader["dataCadastro"].ToString());
                        obj.dataUltAlt = DateTime.Parse(reader["dataUltAlt"].ToString());
                        return obj;
                    }
                    else
                    {
                        return default(T);
                    }
                }
            }
        }

        public override void Salvar(T obj)
        {
            dynamic formaPagamento = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO formaPagamento (formaPagamento, usuarioUltAlt, ativo, dataCadastro, dataUltAlt) VALUES (@formaPagamento, @usuarioUltAlt, @ativo, @dataCadastro, @dataUltAlt)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@formaPagamento", formaPagamento.formaPagamento);
                command.Parameters.AddWithValue("@usuarioUltAlt", formaPagamento.usuarioUltAlt);
                command.Parameters.AddWithValue("@ativo", formaPagamento.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", formaPagamento.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", formaPagamento.dataUltAlt);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
