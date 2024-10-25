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
    public class DAOAluno<T> : DAO<T>
    {
        public int BuscarUltimoCodigo()
        {
            int proximoCodigo = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(idAluno) FROM aluno";
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
            dynamic aluno = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE aluno SET Aluno = @aluno, apelido = @apelido, endereco = @endereco, bairro = @bairro, numero = @numero, cep = @cep, complemento = @complemento, sexo = @sexo, email = @email, celular = @celular, cpf = @cpf, dataNasc = @dataNasc, dataCadastro = @dataCadastro, dataUltAlt = @dataUltAlt, idCidade = @idCidade, idProfissao = @idProfissao, ativo = @ativo WHERE idAluno = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", aluno.idAluno);
                command.Parameters.AddWithValue("@aluno", aluno.Aluno);
                command.Parameters.AddWithValue("@apelido", aluno.Apelido);
                command.Parameters.AddWithValue("@endereco", aluno.endereco);
                command.Parameters.AddWithValue("@bairro", aluno.bairro);
                command.Parameters.AddWithValue("@numero", aluno.numero);
                command.Parameters.AddWithValue("@cep", aluno.cep);
                command.Parameters.AddWithValue("@complemento", aluno.complemento);
                command.Parameters.AddWithValue("@sexo", aluno.sexo);
                command.Parameters.AddWithValue("@email", aluno.email);
                command.Parameters.AddWithValue("@celular", aluno.celular);
                command.Parameters.AddWithValue("@cpf", aluno.cpf);
                command.Parameters.AddWithValue("@dataNasc", aluno.dataNasc);
                command.Parameters.AddWithValue("@dataCadastro", aluno.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", aluno.dataUltAlt);
                command.Parameters.AddWithValue("@idCidade", aluno.idCidade);
                command.Parameters.AddWithValue("@idProfissao", aluno.idProfissao ?? DBNull.Value);
                command.Parameters.AddWithValue("@ativo", aluno.Ativo);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public override T BuscarPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM aluno WHERE idAluno = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idAluno = Convert.ToInt32(reader["idAluno"]);
                        obj.Aluno = reader["Aluno"].ToString();
                        obj.Apelido = reader["apelido"].ToString();
                        obj.endereco = reader["endereco"].ToString();
                        obj.bairro = reader["bairro"].ToString();
                        obj.numero = Convert.ToInt32(reader["numero"]);
                        obj.cep = reader["cep"].ToString();
                        obj.complemento = reader["complemento"].ToString();
                        obj.sexo = reader["sexo"].ToString();
                        obj.email = reader["email"].ToString();
                        obj.celular = reader["celular"].ToString();
                        obj.cpf = reader["cpf"].ToString();
                        obj.dataNasc = DateTime.Parse(reader["dataNasc"].ToString());
                        obj.dataCadastro = DateTime.Parse(reader["dataCadastro"].ToString());
                        obj.dataUltAlt = DateTime.Parse(reader["dataUltAlt"].ToString());
                        obj.idCidade = Convert.ToInt32(reader["idCidade"]);
                        obj.idProfissao = reader["idProfissao"] != DBNull.Value ? Convert.ToInt32(reader["idProfissao"]) : (int?)null;
                        obj.Ativo = Convert.ToBoolean(reader["Ativo"]);
                        obj.Posturas = GetPosturasPorAlunoID(obj.idAluno);
                        obj.Evolucoes = GetEvolucaoPorAlunoID(obj.idAluno);
                        return obj;
                    }
                    else
                    {
                        return default(T); // retorna default se o aluno(a) não for encontrado(a)
                    }
                }
            }
        }
        public List<ModelPostura> GetPosturasPorAlunoID(int idAluno)
        {
            List<ModelPostura> posturas = new List<ModelPostura>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM postura WHERE idAluno = @idAluno";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idAluno", idAluno);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ModelPostura postura = new ModelPostura();
                        postura.idPostura = Convert.ToInt32(reader["idPostura"]);
                        postura.titulo = Convert.ToString(reader["titulo"]);
           
                        posturas.Add(postura);
                    }
                }
            }

            return posturas;
        }

        public List<ModelEvolucao> GetEvolucaoPorAlunoID(int idAluno)
        {
            List<ModelEvolucao> evolucoes = new List<ModelEvolucao>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM evolucao WHERE idAluno = @idAluno";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idAluno", idAluno);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ModelEvolucao evolucao = new ModelEvolucao();
                        evolucao.idEvolucao = Convert.ToInt32(reader["idEvolucao"]);
                        evolucao.titulo = Convert.ToString(reader["titulo"]);

                        evolucoes.Add(evolucao);
                    }
                }
            }

            return evolucoes;
        }

        public override List<T> BuscarTodos(bool BuscarInativos = false)
        {
            List<T> alunos = new List<T>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = BuscarInativos ? "SELECT * FROM aluno" : "SELECT * FROM aluno WHERE ativo = 1";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idAluno = Convert.ToInt32(reader["idAluno"]);
                        obj.Aluno = reader["Aluno"].ToString();
                        obj.celular = reader["celular"].ToString();
                        obj.cpf = reader["cpf"].ToString();
                        alunos.Add(obj);
                    }
                }
            }

            return alunos;
        }

        public override void Deletar(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM aluno WHERE idAluno = @id";

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
                        MessageBox.Show("Não é possível excluir o aluno, pois ele está sendo utilizado em um cadastro.", "Erro ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao deletar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public List<string> GetCEPByCidadeId(int cidadeId)
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
            cidade.idCidade = @cidadeId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@cidadeId", cidadeId);

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
            dynamic aluno = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO aluno (Aluno, apelido, endereco, bairro, numero, cep, complemento, sexo, email, celular, cpf, dataNasc, dataCadastro, dataUltAlt, idCidade, idProfissao, ativo) VALUES (@aluno, @apelido, @endereco, @bairro, @numero, @cep, @complemento, @sexo, @email, @celular, @cpf, @dataNasc, @dataCadastro, @dataUltAlt, @idCidade, @idProfissao, @ativo)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", aluno.idAluno);
                command.Parameters.AddWithValue("@aluno", aluno.Aluno);
                command.Parameters.AddWithValue("@apelido", aluno.Apelido);
                command.Parameters.AddWithValue("@endereco", aluno.endereco);
                command.Parameters.AddWithValue("@bairro", aluno.bairro);
                command.Parameters.AddWithValue("@numero", aluno.numero);
                command.Parameters.AddWithValue("@cep", aluno.cep);
                command.Parameters.AddWithValue("@complemento", aluno.complemento);
                command.Parameters.AddWithValue("@sexo", aluno.sexo);
                command.Parameters.AddWithValue("@email", aluno.email);
                command.Parameters.AddWithValue("@celular", aluno.celular);
                command.Parameters.AddWithValue("@cpf", aluno.cpf);
                command.Parameters.AddWithValue("@dataNasc", aluno.dataNasc);
                command.Parameters.AddWithValue("@dataCadastro", aluno.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", aluno.dataUltAlt);
                command.Parameters.AddWithValue("@idCidade", aluno.idCidade);
                command.Parameters.AddWithValue("@idProfissao", aluno.idProfissao ?? DBNull.Value);
                command.Parameters.AddWithValue("@ativo", aluno.Ativo);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
