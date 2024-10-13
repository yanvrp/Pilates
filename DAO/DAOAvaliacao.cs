using Pilates.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.DAO
{
    public class DAOAvaliacao : DAO<ModelAvaliacao>
    {
        public int GetUltimoCodigo()
        {
            int ultimoCodigo = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(idAvaliacao) FROM avaliacao";
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
        public override void Alterar(ModelAvaliacao obj)
        {
            throw new NotImplementedException();
        }

        public override ModelAvaliacao BuscarPorId(int id)
        {
            ModelAvaliacao avaliacao = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM avaliacao WHERE idAvaliacao = @idAvaliacao";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idAvaliacao", id);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        avaliacao = new ModelAvaliacao();
                        avaliacao.idAvaliacao = Convert.ToInt32(reader["idAvaliacao"]);
                        avaliacao.idAluno = Convert.ToInt32(reader["idAluno"]);
                        avaliacao.data = Convert.ToDateTime(reader["data"]);
                        avaliacao.Ativo = Convert.ToBoolean(reader["ativo"]);
                        avaliacao.dataCadastro = Convert.ToDateTime(reader["dataCadastro"]);
                        avaliacao.dataUltAlt = Convert.ToDateTime(reader["dataUltAlt"]);

                        // Carregar Complicações
                        avaliacao.Dores = BuscarDoresPorAvaliacaoId(avaliacao.idAvaliacao);
                        avaliacao.Doenca = BuscarDoencaPorAvaliacaoId(avaliacao.idAvaliacao);
                        avaliacao.Medicamento = BuscarMedicamentoPorAvaliacaoId(avaliacao.idAvaliacao);
                        avaliacao.Gestacao = BuscarGestacaoPorAvaliacaoId(avaliacao.idAvaliacao);
                        avaliacao.Cirurgia = BuscarCirurgiaPorAvaliacaoId(avaliacao.idAvaliacao);
                    }
                }
            }
            return avaliacao;
        }
        public List<ModelAvaliacaoDores> BuscarDoresPorAvaliacaoId(int idAvaliacao)
        {
            List<ModelAvaliacaoDores> dores = new List<ModelAvaliacaoDores>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM avaliacao_Dores 
                 WHERE idAvaliacao = @idAvaliacao";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idAvaliacao", idAvaliacao);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ModelAvaliacaoDores dor = new ModelAvaliacaoDores();
                        dor.idDores = Convert.ToInt32(reader["idDores"]);
                        dor.observacao = reader["observacao"].ToString();

                        dores.Add(dor);
                    }
                }
            }
            return dores;
        }
        public List<ModelAvaliacaoDoenca> BuscarDoencaPorAvaliacaoId(int idAvaliacao)
        {
            List<ModelAvaliacaoDoenca> doencas = new List<ModelAvaliacaoDoenca>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM avaliacao_Doenca  
                 WHERE idAvaliacao = @idAvaliacao";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idAvaliacao", idAvaliacao);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ModelAvaliacaoDoenca doenca = new ModelAvaliacaoDoenca();
                        doenca.idDoenca = Convert.ToInt32(reader["idDoenca"]);
                        doenca.observacao = reader["observacao"].ToString();

                        doencas.Add(doenca);
                    }
                }
            }
            return doencas;
        }
        public List<ModelAvaliacaoCirurgia> BuscarCirurgiaPorAvaliacaoId(int idAvaliacao)
        {
            List<ModelAvaliacaoCirurgia> cirurgias = new List<ModelAvaliacaoCirurgia>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM avaliacao_Cirurgia  
                 WHERE idAvaliacao = @idAvaliacao";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idAvaliacao", idAvaliacao);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ModelAvaliacaoCirurgia cirurgia = new ModelAvaliacaoCirurgia();
                        cirurgia.idCirurgia = Convert.ToInt32(reader["idCirurgia"]);
                        cirurgia.dataCirurgia = Convert.ToDateTime(reader["dataCirurgia"]);
                        cirurgia.observacao = reader["observacao"].ToString();

                        cirurgias.Add(cirurgia);
                    }
                }
            }
            return cirurgias;
        }
        public List<ModelAvaliacaoGestacao> BuscarGestacaoPorAvaliacaoId(int idAvaliacao)
        {
            List<ModelAvaliacaoGestacao> gestacoes = new List<ModelAvaliacaoGestacao>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM avaliacao_Gestacao  
                 WHERE idAvaliacao = @idAvaliacao";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idAvaliacao", idAvaliacao);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ModelAvaliacaoGestacao gestacao = new ModelAvaliacaoGestacao();
                        gestacao.idGestacao = Convert.ToInt32(reader["idGestacao"]);
                        gestacao.dataParto = Convert.ToDateTime(reader["dataParto"]);
                        gestacao.observacao = reader["observacao"].ToString();

                        gestacoes.Add(gestacao);
                    }
                }
            }
            return gestacoes;
        }
        public List<ModelAvaliacaoMedicamento> BuscarMedicamentoPorAvaliacaoId(int idAvaliacao)
        {
            List<ModelAvaliacaoMedicamento> medicamentos = new List<ModelAvaliacaoMedicamento>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM avaliacao_Medicamento  
                 WHERE idAvaliacao = @idAvaliacao";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idAvaliacao", idAvaliacao);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ModelAvaliacaoMedicamento medicamento = new ModelAvaliacaoMedicamento();
                        medicamento.idMedicamento = Convert.ToInt32(reader["idMedicamento"]);
                        medicamento.observacao = reader["observacao"].ToString();
                        medicamento.dosagem = reader["dosagem"].ToString();
                        medicamento.frequencia = reader["frequencia"].ToString();

                        medicamentos.Add(medicamento);
                    }
                }
            }
            return medicamentos;
        }
        public override List<ModelAvaliacao> BuscarTodos(bool BuscarInativos = false)
        {
            List<ModelAvaliacao> avaliacoes = new List<ModelAvaliacao>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = BuscarInativos ? "SELECT * FROM avaliacao" : "SELECT * FROM avaliacao WHERE ativo = 1";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ModelAvaliacao avaliacao = new ModelAvaliacao();
                        avaliacao.idAvaliacao = Convert.ToInt32(reader["idAvaliacao"]);
                        avaliacao.idAluno = Convert.ToInt32(reader["idAluno"]);
                        avaliacao.data = Convert.ToDateTime(reader["data"]);
                        avaliacoes.Add(avaliacao);
                    }
                }
            }
            return avaliacoes;
        }
        public override void Deletar(int id)
        {
            throw new NotImplementedException();
        }
        public ModelCirurgia BuscarCirurgiaPorId(int idCirurgia)
        {
            ModelCirurgia cirurgia = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT cirurgia, descricao FROM cirurgia WHERE idCirurgia = @idCirurgia";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idCirurgia", idCirurgia);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cirurgia = new ModelCirurgia
                        {
                            idCirurgia = idCirurgia,
                            cirurgia = reader["cirurgia"].ToString(),
                            descricao = reader["descricao"].ToString(),
                        };
                    }
                }
            }
            return cirurgia;
        }

        public ModelDoenca BuscarDoencaPorId(int idDoenca)
        {
            ModelDoenca doenca = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT doenca, descricao FROM doenca WHERE idDoenca = @idDoenca";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idDoenca", idDoenca);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        doenca = new ModelDoenca
                        {
                            idDoenca = idDoenca,
                            doenca = reader["doenca"].ToString(),
                            descricao = reader["descricao"].ToString(),
                        };
                    }
                }
            }
            return doenca;
        }

        public ModelDores BuscarDoresPorId(int idDores)
        {
            ModelDores dor = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT dores, descricao FROM dores WHERE idDores = @idDores";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idDores", idDores);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dor = new ModelDores
                        {
                            idDores = idDores,
                            dores = reader["dores"].ToString(),
                            descricao = reader["descricao"].ToString(),
                        };
                    }
                }
            }
            return dor;
        }

        public ModelMedicamento BuscarMedicamentoPorId(int idMedicamento)
        {
            ModelMedicamento medicamento = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT medicamento, descricao FROM medicamento WHERE idMedicamento = @idMedicamento";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idMedicamento", idMedicamento);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        medicamento = new ModelMedicamento
                        {
                            idMedicamento = idMedicamento,
                            medicamento = reader["medicamento"].ToString(),
                            descricao = reader["descricao"].ToString(),
                        };
                    }
                }
            }
            return medicamento;
        }

        public ModelGestacao BuscarGestacaoPorId(int idGestacao)
        {
            ModelGestacao gestacao = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT gestacao, descricao FROM gestacao WHERE idGestacao = @idGestacao";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idMedicamento", idGestacao);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        gestacao = new ModelGestacao
                        {
                            idGestacao = idGestacao,
                            gestacao = reader["gestacao"].ToString(),
                            descricao = reader["descricao"].ToString(),
                        };
                    }
                }
            }
            return gestacao;
        }
        public override void Salvar(ModelAvaliacao obj)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string queryAvaliacao = @"INSERT INTO avaliacao 
                        (data, idAluno, dataCadastro, dataUltAlt, ativo) 
                        VALUES (@data, @idAluno, @dataCadastro, @dataUltAlt, @ativo);
                        SELECT SCOPE_IDENTITY();";
                    SqlCommand cmdAvaliacao = new SqlCommand(queryAvaliacao, conn, transaction);

                    cmdAvaliacao.Parameters.AddWithValue("@data", obj.data);
                    cmdAvaliacao.Parameters.AddWithValue("@idAluno", obj.idAluno);
                    cmdAvaliacao.Parameters.AddWithValue("@dataCadastro", obj.dataCadastro);
                    cmdAvaliacao.Parameters.AddWithValue("@dataUltAlt", obj.dataUltAlt);
                    cmdAvaliacao.Parameters.AddWithValue("@ativo", obj.Ativo);
                    int idAvaliacao = Convert.ToInt32(cmdAvaliacao.ExecuteScalar());

                    foreach (var dor in obj.Dores)
                    {
                        string queryDores = @"INSERT INTO avaliacao_Dores 
                             (idAvaliacao, observacao, idDores) 
                             VALUES (@idAvaliacao, @observacao, @idDores)";
                        SqlCommand cmdDores = new SqlCommand(queryDores, conn, transaction);

                        cmdDores.Parameters.AddWithValue("@idAvaliacao", idAvaliacao);
                        cmdDores.Parameters.AddWithValue("@observacao", dor.observacao);
                        cmdDores.Parameters.AddWithValue("@idDores", dor.idDores);


                        cmdAvaliacao.ExecuteNonQuery();
                    }

                    foreach (var doenca in obj.Doenca)
                    {
                        string queryDores = @"INSERT INTO avaliacao_Doenca 
                             (idAvaliacao, observacao, idDoenca) 
                             VALUES (@idAvaliacao, @observacao, @idDoenca)";
                        SqlCommand cmdDores = new SqlCommand(queryDores, conn, transaction);

                        cmdDores.Parameters.AddWithValue("@idAvaliacao", idAvaliacao);
                        cmdDores.Parameters.AddWithValue("@observacao", doenca.observacao);
                        cmdDores.Parameters.AddWithValue("@idDoenca", doenca.idDoenca);


                        cmdAvaliacao.ExecuteNonQuery();
                    }

                    foreach (var gestacao in obj.Gestacao)
                    {
                        string queryDores = @"INSERT INTO avaliacao_Gestacao 
                             (idAvaliacao, observacao, idGestacao, dataParto) 
                             VALUES (@idAvaliacao, @observacao, @idGestacao, @dataParto)";
                        SqlCommand cmdDores = new SqlCommand(queryDores, conn, transaction);

                        cmdDores.Parameters.AddWithValue("@idAvaliacao", idAvaliacao);
                        cmdDores.Parameters.AddWithValue("@observacao", gestacao.observacao);
                        cmdDores.Parameters.AddWithValue("@idDoenca", gestacao.idGestacao);
                        cmdDores.Parameters.AddWithValue("@dataParto", gestacao.dataParto);


                        cmdAvaliacao.ExecuteNonQuery();
                    }

                    foreach (var cirugia in obj.Cirurgia)
                    {
                        string queryDores = @"INSERT INTO avaliacao_Cirurgia 
                             (idAvaliacao, observacao, idCirurgia, dataCirurgia) 
                             VALUES (@idAvaliacao, @observacao, @idCirurgia, @dataCirurgia)";
                        SqlCommand cmdDores = new SqlCommand(queryDores, conn, transaction);

                        cmdDores.Parameters.AddWithValue("@idAvaliacao", idAvaliacao);
                        cmdDores.Parameters.AddWithValue("@observacao", cirugia.observacao);
                        cmdDores.Parameters.AddWithValue("@idCirurgia", cirugia.idCirurgia);
                        cmdDores.Parameters.AddWithValue("@dataCirurgia", cirugia.dataCirurgia);


                        cmdAvaliacao.ExecuteNonQuery();
                    }

                    foreach (var medicamento in obj.Medicamento)
                    {
                        string queryDores = @"INSERT INTO avaliacao_Medicamento 
                             (idAvaliacao, observacao, idMedicamento, dosagem, frequencia) 
                             VALUES (@idAvaliacao, @observacao, @idMedicamento, @dosagem, @frequencia)";
                        SqlCommand cmdDores = new SqlCommand(queryDores, conn, transaction);

                        cmdDores.Parameters.AddWithValue("@idAvaliacao", idAvaliacao);
                        cmdDores.Parameters.AddWithValue("@observacao", medicamento.observacao);
                        cmdDores.Parameters.AddWithValue("@idCirurgia", medicamento.idMedicamento);
                        cmdDores.Parameters.AddWithValue("@dosagem", medicamento.dosagem);
                        cmdDores.Parameters.AddWithValue("@frequencia", medicamento.frequencia);


                        cmdAvaliacao.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Erro no banco ao salvar a Avaliação: " + ex.Message);
                }
            }
        }
    }
}
