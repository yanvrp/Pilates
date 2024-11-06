using Pilates.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
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
        public void CancelarAvaliacao(int idAvaliacao)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE avaliacao 
                         SET dataCancelamento = @dataCancelamento, 
                             dataUltAlt = @dataUltAlt 
                         WHERE idAvaliacao = @idAvaliacao";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@dataCancelamento", DateTime.Now);
                command.Parameters.AddWithValue("@dataUltAlt", DateTime.Now);
                command.Parameters.AddWithValue("@idAvaliacao", idAvaliacao);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao cancelar a avaliação: " + ex.Message);
                    throw;
                }
            }
        }
        public override void Alterar(ModelAvaliacao obj)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Atualizar a avaliação principal
                    string queryAvaliacao = @"UPDATE avaliacao 
                                  SET data = @data, 
                                      idAluno = @idAluno, 
                                      dataUltAlt = @dataUltAlt, 
                                      ativo = @ativo,
                                      observacao = @observacao
                                      dataCancelamento = @dataCancelamento
                                  WHERE idAvaliacao = @idAvaliacao";
                    SqlCommand cmdAvaliacao = new SqlCommand(queryAvaliacao, conn, transaction);

                    cmdAvaliacao.Parameters.AddWithValue("@data", obj.data);
                    cmdAvaliacao.Parameters.AddWithValue("@idAluno", obj.idAluno);
                    cmdAvaliacao.Parameters.AddWithValue("@dataUltAlt", obj.dataUltAlt);
                    cmdAvaliacao.Parameters.AddWithValue("@ativo", obj.Ativo);
                    cmdAvaliacao.Parameters.AddWithValue("@idAvaliacao", obj.idAvaliacao);
                    cmdAvaliacao.Parameters.AddWithValue("@observacao", obj.observacao ?? (object)DBNull.Value);
                    cmdAvaliacao.Parameters.AddWithValue("@dataCancelamento", obj.dataCancelamento ?? (object)DBNull.Value);

                    cmdAvaliacao.ExecuteNonQuery();

                    AtualizarDores(obj.idAvaliacao, obj.Dores, conn, transaction);
                    AtualizarDoencas(obj.idAvaliacao, obj.Doenca, conn, transaction);
                    AtualizarCirurgias(obj.idAvaliacao, obj.Cirurgia, conn, transaction);
                    AtualizarGestacoes(obj.idAvaliacao, obj.Gestacao, conn, transaction);
                    AtualizarMedicamentos(obj.idAvaliacao, obj.Medicamento, conn, transaction);

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Erro ao alterar a Avaliação: " + ex.Message);
                }
            }
        }
        private void AtualizarDores(int idAvaliacao, List<ModelAvaliacaoDores> dores, SqlConnection conn, SqlTransaction transaction)
        {
            string deleteQuery = "DELETE FROM avaliacao_Dores WHERE idAvaliacao = @idAvaliacao";
            SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn, transaction);
            deleteCmd.Parameters.AddWithValue("@idAvaliacao", idAvaliacao);
            deleteCmd.ExecuteNonQuery();

            foreach (var dor in dores)
            {
                string insertQuery = @"INSERT INTO avaliacao_Dores (idAvaliacao, observacao, idDores) 
                               VALUES (@idAvaliacao, @observacao, @idDores)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn, transaction);
                insertCmd.Parameters.AddWithValue("@idAvaliacao", idAvaliacao);
                insertCmd.Parameters.AddWithValue("@observacao", dor.observacao);
                insertCmd.Parameters.AddWithValue("@idDores", dor.idDores);
                insertCmd.ExecuteNonQuery();
            }
        }
        private void AtualizarDoencas(int idAvaliacao, List<ModelAvaliacaoDoenca> doencas, SqlConnection conn, SqlTransaction transaction)
        {
            string deleteQuery = "DELETE FROM avaliacao_Doenca WHERE idAvaliacao = @idAvaliacao";
            SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn, transaction);
            deleteCmd.Parameters.AddWithValue("@idAvaliacao", idAvaliacao);
            deleteCmd.ExecuteNonQuery();

            foreach (var doenca in doencas)
            {
                string insertQuery = @"INSERT INTO avaliacao_Doenca (idAvaliacao, observacao, idDoenca) 
                               VALUES (@idAvaliacao, @observacao, @idDoenca)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn, transaction);
                insertCmd.Parameters.AddWithValue("@idAvaliacao", idAvaliacao);
                insertCmd.Parameters.AddWithValue("@observacao", doenca.observacao);
                insertCmd.Parameters.AddWithValue("@idDoenca", doenca.idDoenca);
                insertCmd.ExecuteNonQuery();
            }
        }
        private void AtualizarCirurgias(int idAvaliacao, List<ModelAvaliacaoCirurgia> cirurgias, SqlConnection conn, SqlTransaction transaction)
        {
            string deleteQuery = "DELETE FROM avaliacao_Cirurgia WHERE idAvaliacao = @idAvaliacao";
            SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn, transaction);
            deleteCmd.Parameters.AddWithValue("@idAvaliacao", idAvaliacao);
            deleteCmd.ExecuteNonQuery();

            foreach (var cirurgia in cirurgias)
            {
                string insertQuery = @"INSERT INTO avaliacao_Cirurgia (idAvaliacao, observacao, idCirurgia, dataCirurgia) 
                       VALUES (@idAvaliacao, @observacao, @idCirurgia, @dataCirurgia)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn, transaction);
                insertCmd.Parameters.AddWithValue("@idAvaliacao", idAvaliacao);
                insertCmd.Parameters.AddWithValue("@observacao", cirurgia.observacao);
                insertCmd.Parameters.AddWithValue("@idCirurgia", cirurgia.idCirurgia);
                insertCmd.Parameters.AddWithValue("@dataCirurgia", cirurgia.dataCirurgia);
                insertCmd.ExecuteNonQuery();
            }
        }

        private void AtualizarGestacoes(int idAvaliacao, List<ModelAvaliacaoGestacao> gestacoes, SqlConnection conn, SqlTransaction transaction)
        {
            string deleteQuery = "DELETE FROM avaliacao_Gestacao WHERE idAvaliacao = @idAvaliacao";
            SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn, transaction);
            deleteCmd.Parameters.AddWithValue("@idAvaliacao", idAvaliacao);
            deleteCmd.ExecuteNonQuery();

            foreach (var gestacao in gestacoes)
            {
                string insertQuery = @"INSERT INTO avaliacao_Gestacao (idAvaliacao, observacao, idGestacao, dataParto) 
                               VALUES (@idAvaliacao, @observacao, @idGestacao, @dataParto)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn, transaction);
                insertCmd.Parameters.AddWithValue("@idAvaliacao", idAvaliacao);
                insertCmd.Parameters.AddWithValue("@observacao", gestacao.observacao);
                insertCmd.Parameters.AddWithValue("@idGestacao", gestacao.idGestacao);
                insertCmd.Parameters.AddWithValue("@dataParto", gestacao.dataParto ?? (object)DBNull.Value);
                insertCmd.ExecuteNonQuery();
            }
        }

        private void AtualizarMedicamentos(int idAvaliacao, List<ModelAvaliacaoMedicamento> medicamentos, SqlConnection conn, SqlTransaction transaction)
        {
            string deleteQuery = "DELETE FROM avaliacao_Medicamento WHERE idAvaliacao = @idAvaliacao";
            SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn, transaction);
            deleteCmd.Parameters.AddWithValue("@idAvaliacao", idAvaliacao);
            deleteCmd.ExecuteNonQuery();

            foreach (var medicamento in medicamentos)
            {
                string insertQuery = @"INSERT INTO avaliacao_Medicamento (idAvaliacao, observacao, idMedicamento, dosagem, frequencia) 
                       VALUES (@idAvaliacao, @observacao, @idMedicamento, @dosagem, @frequencia)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn, transaction);
                insertCmd.Parameters.AddWithValue("@idAvaliacao", idAvaliacao);
                insertCmd.Parameters.AddWithValue("@observacao", medicamento.observacao);
                insertCmd.Parameters.AddWithValue("@idMedicamento", medicamento.idMedicamento);
                insertCmd.Parameters.AddWithValue("@dosagem", medicamento.dosagem);
                insertCmd.Parameters.AddWithValue("@frequencia", medicamento.frequencia);
                insertCmd.ExecuteNonQuery();
            }
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
                        avaliacao.observacao = reader.IsDBNull(reader.GetOrdinal("observacao")) ? (string?)null : reader["observacao"].ToString();
                        avaliacao.dataCancelamento = reader.IsDBNull(reader.GetOrdinal("dataCancelamento")) ? (DateTime?)null : Convert.ToDateTime(reader["dataCancelamento"]);

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
                        ModelAvaliacaoGestacao gestacao = new ModelAvaliacaoGestacao
                        {
                            idGestacao = Convert.ToInt32(reader["idGestacao"]),
                            dataParto = reader.IsDBNull(reader.GetOrdinal("dataParto")) ? (DateTime?)null : Convert.ToDateTime(reader["dataParto"]),
                            observacao = reader["observacao"].ToString()
                        };

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
                        avaliacao.dataCancelamento = reader["dataCancelamento"] != DBNull.Value ? Convert.ToDateTime(reader["dataCancelamento"]) : (DateTime?)null;
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
                string query = "SELECT doenca, descricao, cid FROM doenca WHERE idDoenca = @idDoenca";
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
                            CID = reader["cid"].ToString(),
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
                cmd.Parameters.AddWithValue("@idGestacao", idGestacao);

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
                    // Inserir a avaliação principal
                    string queryAvaliacao = @"INSERT INTO avaliacao 
                       (data, idAluno, dataCadastro, dataUltAlt, ativo, observacao, dataCancelamento) 
                       VALUES (@data, @idAluno, @dataCadastro, @dataUltAlt, @ativo, @observacao, @dataCancelamento);
                       SELECT SCOPE_IDENTITY();";
                    SqlCommand cmdAvaliacao = new SqlCommand(queryAvaliacao, conn, transaction);

                    cmdAvaliacao.Parameters.AddWithValue("@data", obj.data);
                    cmdAvaliacao.Parameters.AddWithValue("@idAluno", obj.idAluno);
                    cmdAvaliacao.Parameters.AddWithValue("@dataCadastro", obj.dataCadastro);
                    cmdAvaliacao.Parameters.AddWithValue("@dataUltAlt", obj.dataUltAlt);
                    cmdAvaliacao.Parameters.AddWithValue("@ativo", obj.Ativo);
                    cmdAvaliacao.Parameters.AddWithValue("@observacao", obj.observacao ?? (object)DBNull.Value);
                    cmdAvaliacao.Parameters.AddWithValue("@dataCancelamento", obj.dataCancelamento ?? (object)DBNull.Value);
                    int idAvaliacao = Convert.ToInt32(cmdAvaliacao.ExecuteScalar());

                    // Inserir as dores
                    foreach (var dor in obj.Dores)
                    {
                        string queryDores = @"INSERT INTO avaliacao_Dores 
                            (idAvaliacao, observacao, idDores) 
                            VALUES (@idAvaliacao, @observacao, @idDores)";
                        SqlCommand cmdDores = new SqlCommand(queryDores, conn, transaction);

                        cmdDores.Parameters.AddWithValue("@idAvaliacao", idAvaliacao);
                        cmdDores.Parameters.AddWithValue("@observacao", dor.observacao);
                        cmdDores.Parameters.AddWithValue("@idDores", dor.idDores);

                        cmdDores.ExecuteNonQuery();
                    }

                    // Inserir as doenças
                    foreach (var doenca in obj.Doenca)
                    {
                        string queryDoenca = @"INSERT INTO avaliacao_Doenca 
                            (idAvaliacao, observacao, idDoenca) 
                            VALUES (@idAvaliacao, @observacao, @idDoenca)";
                        SqlCommand cmdDoenca = new SqlCommand(queryDoenca, conn, transaction);

                        cmdDoenca.Parameters.AddWithValue("@idAvaliacao", idAvaliacao);
                        cmdDoenca.Parameters.AddWithValue("@observacao", doenca.observacao);
                        cmdDoenca.Parameters.AddWithValue("@idDoenca", doenca.idDoenca);

                        cmdDoenca.ExecuteNonQuery();
                    }

                    // Inserir as gestações
                    foreach (var gestacao in obj.Gestacao)
                    {
                        string queryGestacao = @"INSERT INTO avaliacao_Gestacao 
        (idAvaliacao, observacao, idGestacao, dataParto) 
        VALUES (@idAvaliacao, @observacao, @idGestacao, @dataParto)";
                        SqlCommand cmdGestacao = new SqlCommand(queryGestacao, conn, transaction);

                        cmdGestacao.Parameters.AddWithValue("@idAvaliacao", idAvaliacao);
                        cmdGestacao.Parameters.AddWithValue("@observacao", gestacao.observacao);
                        cmdGestacao.Parameters.AddWithValue("@idGestacao", gestacao.idGestacao);

                        // Verificar se dataParto é null e adicionar DBNull.Value se for
                        if (gestacao.dataParto.HasValue)
                        {
                            cmdGestacao.Parameters.AddWithValue("@dataParto", gestacao.dataParto.Value);
                        }
                        else
                        {
                            cmdGestacao.Parameters.AddWithValue("@dataParto", DBNull.Value);
                        }

                        cmdGestacao.ExecuteNonQuery();
                    }

                    // Inserir as cirurgias
                    foreach (var cirurgia in obj.Cirurgia)
                    {
                        string queryCirurgia = @"INSERT INTO avaliacao_Cirurgia 
                            (idAvaliacao, observacao, idCirurgia, dataCirurgia) 
                            VALUES (@idAvaliacao, @observacao, @idCirurgia, @dataCirurgia)";
                        SqlCommand cmdCirurgia = new SqlCommand(queryCirurgia, conn, transaction);

                        cmdCirurgia.Parameters.AddWithValue("@idAvaliacao", idAvaliacao);
                        cmdCirurgia.Parameters.AddWithValue("@observacao", cirurgia.observacao);
                        cmdCirurgia.Parameters.AddWithValue("@idCirurgia", cirurgia.idCirurgia);
                        cmdCirurgia.Parameters.AddWithValue("@dataCirurgia", cirurgia.dataCirurgia);

                        cmdCirurgia.ExecuteNonQuery();
                    }

                    // Inserir os medicamentos
                    foreach (var medicamento in obj.Medicamento)
                    {
                        string queryMedicamento = @"INSERT INTO avaliacao_Medicamento 
                            (idAvaliacao, observacao, idMedicamento, dosagem, frequencia) 
                            VALUES (@idAvaliacao, @observacao, @idMedicamento, @dosagem, @frequencia)";
                        SqlCommand cmdMedicamento = new SqlCommand(queryMedicamento, conn, transaction);

                        cmdMedicamento.Parameters.AddWithValue("@idAvaliacao", idAvaliacao);
                        cmdMedicamento.Parameters.AddWithValue("@observacao", medicamento.observacao);
                        cmdMedicamento.Parameters.AddWithValue("@idMedicamento", medicamento.idMedicamento);
                        cmdMedicamento.Parameters.AddWithValue("@dosagem", medicamento.dosagem);
                        cmdMedicamento.Parameters.AddWithValue("@frequencia", medicamento.frequencia);

                        cmdMedicamento.ExecuteNonQuery();
                    }

                    // Commit da transação
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // Rollback em caso de erro
                    transaction.Rollback();
                    throw new Exception("Erro no banco ao salvar a Avaliação: " + ex.Message);
                }
            }
        }
    }
}
