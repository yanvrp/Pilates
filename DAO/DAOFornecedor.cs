﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilates.DAO
{
    public class DAOFornecedor<T> : DAO<T>
    {
        public DAOFornecedor() : base() { }

        public int GetUltimoCodigo()
        {
            int ultimoCodigo = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(idFornecedor) FROM fornecedor";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                var result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    ultimoCodigo = Convert.ToInt32(result);
                }
            }
            return ultimoCodigo;
        }

        public override void Alterar(T obj)
        {
            dynamic fornecedor = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE fornecedor SET tipo_pessoa = @tipo_pessoa, fornecedor_razao_social = @fornecedor_razao_social, apelido_nome_fantasia = @apelido_nome_fantasia, " +
                               "endereco = @endereco, bairro = @bairro, numero = @numero, cep = @cep, complemento = @complemento, sexo = @sexo, email = @email, " +
                               "telefone = @telefone, celular = @celular, nome_contato = @nome_contato, data_nasc = @data_nasc, cpf_cnpj = @cpf_cnpj, rg_ie = @rg_ie, ativo = @ativo, " +
                               "dataUltAlt = @dataUltAlt, idCidade = @idCidade, idCondPagamento = @idCondPagamento WHERE idFornecedor = @id";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id", fornecedor.idFornecedor);
                command.Parameters.AddWithValue("@tipo_pessoa", fornecedor.tipo_pessoa);
                command.Parameters.AddWithValue("@fornecedor_razao_social", fornecedor.fornecedor_razao_social);
                command.Parameters.AddWithValue("@apelido_nome_fantasia", fornecedor.apelido_nome_fantasia);
                command.Parameters.AddWithValue("@endereco", fornecedor.endereco);
                command.Parameters.AddWithValue("@bairro", fornecedor.bairro);
                command.Parameters.AddWithValue("@numero", fornecedor.numero);
                command.Parameters.AddWithValue("@cep", fornecedor.cep);
                command.Parameters.AddWithValue("@complemento", fornecedor.complemento);
                command.Parameters.AddWithValue("@sexo", fornecedor.sexo);
                command.Parameters.AddWithValue("@email", fornecedor.email);
                command.Parameters.AddWithValue("@telefone", fornecedor.telefone);
                command.Parameters.AddWithValue("@celular", fornecedor.celular);
                command.Parameters.AddWithValue("@nome_contato", fornecedor.nome_contato);
                command.Parameters.AddWithValue("@data_nasc", fornecedor.data_nasc);
                command.Parameters.AddWithValue("@cpf_cnpj", fornecedor.cpf_cnpj);
                command.Parameters.AddWithValue("@rg_ie", fornecedor.rg_ie);
                command.Parameters.AddWithValue("@ativo", fornecedor.Ativo);
                command.Parameters.AddWithValue("@dataUltAlt", fornecedor.dataUltAlt);
                command.Parameters.AddWithValue("@idCidade", fornecedor.idCidade);
                command.Parameters.AddWithValue("@idCondPagamento", fornecedor.idCondPagamento);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao alterar fornecedor: " + ex.Message);
                    throw;
                }
            }
        }

        public override T BuscarPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM fornecedor WHERE idFornecedor = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idFornecedor = Convert.ToInt32(reader["idFornecedor"]);
                        obj.tipo_pessoa = Convert.ToBoolean(reader["tipo_pessoa"]);
                        obj.fornecedor_razao_social = reader["fornecedor_razao_social"].ToString();
                        obj.apelido_nome_fantasia = reader["apelido_nome_fantasia"].ToString();
                        obj.endereco = reader["endereco"].ToString();
                        obj.bairro = reader["bairro"].ToString();
                        obj.numero = reader["numero"].ToString();
                        obj.cep = reader["cep"].ToString();
                        obj.complemento = reader["complemento"].ToString();
                        obj.sexo = reader["sexo"].ToString();
                        obj.email = reader["email"].ToString();
                        obj.telefone = reader["telefone"].ToString();
                        obj.celular = reader["celular"].ToString();
                        obj.nome_contato = reader["nome_contato"].ToString();
                        obj.data_nasc = DateTime.Parse(reader["data_nasc"].ToString());
                        obj.cpf_cnpj = reader["cpf_cnpj"].ToString();
                        obj.rg_ie = reader["rg_ie"].ToString();
                        obj.Ativo = Convert.ToBoolean(reader["Ativo"]);
                        obj.dataCadastro = DateTime.Parse(reader["dataCadastro"].ToString());
                        obj.dataUltAlt = DateTime.Parse(reader["dataUltAlt"].ToString());
                        obj.idCidade = Convert.ToInt32(reader["idCidade"]);
                        obj.idCondPagamento = Convert.ToInt32(reader["idCondPagamento"]);
                        return obj;
                    }
                    else
                    {
                        return default(T);
                    }
                }
            }
        }

        public override List<T> BuscarTodos(bool BuscarInativos = false)
        {
            List<T> fornecedores = new List<T>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = BuscarInativos ? "SELECT * FROM fornecedor" : "SELECT * FROM fornecedor WHERE ativo = 1";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idFornecedor = Convert.ToInt32(reader["idFornecedor"]);
                        obj.fornecedor_razao_social = reader["fornecedor_razao_social"].ToString();
                        obj.tipo_pessoa = Convert.ToBoolean(reader["tipo_pessoa"]);
                        obj.celular = reader["celular"].ToString();
                        obj.cpf_cnpj = reader["cpf_cnpj"].ToString();
                        fornecedores.Add(obj);
                    }
                }
            }
            return fornecedores;
        }

        public override void Deletar(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM fornecedor WHERE idFornecedor = @id";

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
                        MessageBox.Show("Não é possível excluir o Fornecedor, pois ele está sendo utilizado em um cadastro.", "Erro ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao deletar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public List<string> GetCEPByIdCidade(int idCidade)
        {
            List<string> cidadeInfos = new List<string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
          SELECT 
              cidade.cidade AS cidade,
              estado.UF AS UF,
              pais.pais AS pais
          FROM 
              cidade
          JOIN 
              estado ON cidade.idEstado = estado.idEstado
          JOIN 
              pais ON estado.idPais = pais.idPais
          WHERE 
              cidade.idCidade = @idCidade";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idCidade", idCidade);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string cidadeInfo = string.Format("{0}, {1}, {2}",
                            reader["cidade"],
                            reader["UF"],
                            reader["pais"]);
                        cidadeInfos.Add(cidadeInfo);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro ao obter informações da cidade: " + ex.Message);
                }
            }
            return cidadeInfos;
        }
        public override void Salvar(T obj)
        {
            dynamic fornecedor = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO fornecedor (tipo_pessoa, fornecedor_razao_social, apelido_nome_fantasia, endereco, bairro, numero, cep, complemento, sexo, email, telefone, celular, nome_contato, data_nasc, cpf_cnpj, rg_ie, ativo, dataCadastro, dataUltAlt, idCidade, idCondPagamento) " +
                               "VALUES (@tipo_pessoa, @fornecedor_razao_social, @apelido_nome_fantasia, @endereco, @bairro, @numero, @cep, @complemento, @sexo, @email, @telefone, @celular, @nome_contato, @data_nasc, @cpf_cnpj, @rg_ie, @ativo, @dataCadastro, @dataUltAlt, @idCidade, @idCondPagamento)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@tipo_pessoa", fornecedor.tipo_pessoa);
                command.Parameters.AddWithValue("@fornecedor_razao_social", fornecedor.fornecedor_razao_social);
                command.Parameters.AddWithValue("@apelido_nome_fantasia", fornecedor.apelido_nome_fantasia);
                command.Parameters.AddWithValue("@endereco", fornecedor.endereco);
                command.Parameters.AddWithValue("@bairro", fornecedor.bairro);
                command.Parameters.AddWithValue("@numero", fornecedor.numero);
                command.Parameters.AddWithValue("@cep", fornecedor.cep);
                command.Parameters.AddWithValue("@complemento", fornecedor.complemento);
                command.Parameters.AddWithValue("@sexo", fornecedor.sexo);
                command.Parameters.AddWithValue("@email", fornecedor.email);
                command.Parameters.AddWithValue("@telefone", fornecedor.telefone);
                command.Parameters.AddWithValue("@celular", fornecedor.celular);
                command.Parameters.AddWithValue("@nome_contato", fornecedor.nome_contato);
                command.Parameters.AddWithValue("@data_nasc", fornecedor.data_nasc);
                command.Parameters.AddWithValue("@cpf_cnpj", fornecedor.cpf_cnpj);
                command.Parameters.AddWithValue("@rg_ie", fornecedor.rg_ie);
                command.Parameters.AddWithValue("@ativo", fornecedor.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", fornecedor.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", fornecedor.dataUltAlt);
                command.Parameters.AddWithValue("@idCidade", fornecedor.idCidade);
                command.Parameters.AddWithValue("@idCondPagamento", fornecedor.idCondPagamento);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao salvar fornecedor: " + ex.Message);
                    throw;
                }
            }
        }
    }
}
