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
    public class DAOContrato : DAO<ModelContrato>
    {
        public DAOContrato() : base() { }

        public override void Alterar(ModelContrato obj)
        {
            throw new NotImplementedException();
        }
        public int GetUltimoNumero()
        {
            int ultimoCodigo = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ISNULL(MAX(idContrato), 0) FROM contrato";
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

        public override ModelContrato BuscarPorId(int id)
        {
            ModelContrato contrato = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM contrato WHERE idContrato = @idContrato";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idContrato", id);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        contrato = new ModelContrato();
                        contrato.idContrato = Convert.ToInt32(reader["idContrato"]);
                        contrato.idAluno = Convert.ToInt32(reader["idAluno"]);
                        contrato.idCondPag = Convert.ToInt32(reader["idCondPagamento"]);
                        contrato.idPrograma = Convert.ToInt32(reader["idPrograma"]);
                        contrato.periodo = reader["periodo"].ToString();
                        contrato.diasSemana = reader["diasSemana"].ToString();
                        contrato.horario = (TimeSpan)reader["horario"];
                        contrato.ValorTotal = Convert.ToDecimal(reader["valorTotal"]);
                        contrato.diaAcordado = Convert.ToInt32(reader["diaAcordado"]);
                        contrato.Ativo = Convert.ToBoolean(reader["Ativo"]);
                        contrato.dataCancelamento = reader["dataCancelamento"] != DBNull.Value ? Convert.ToDateTime(reader["dataCancelamento"]) : (DateTime?)null;
                        contrato.dataInicioPrograma = DateTime.Parse(reader["dataInicioPrograma"].ToString());
                        contrato.dataCadastro = DateTime.Parse(reader["dataCadastro"].ToString());
                        contrato.dataUltAlt = DateTime.Parse(reader["dataUltAlt"].ToString());
                    }
                }
            }

            return contrato;
        }

        public override List<ModelContrato> BuscarTodos(bool BuscarInativos = false)
        {
            List<ModelContrato> contratos = new List<ModelContrato>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM contrato";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ModelContrato contrato = new ModelContrato();
                        contrato.idContrato = Convert.ToInt32(reader["idContrato"]);
                        contrato.idAluno = Convert.ToInt32(reader["idAluno"]);
                        contrato.idPrograma = Convert.ToInt32(reader["idPrograma"]);
                        contrato.dataInicioPrograma = Convert.ToDateTime(reader["dataInicioPrograma"]);
                        contrato.dataCancelamento = reader["dataCancelamento"] != DBNull.Value ? Convert.ToDateTime(reader["dataCancelamento"]) : (DateTime?)null;

                        contratos.Add(contrato);
                    }
                }
            }
            return contratos;
        }

        public override void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public override void Salvar(ModelContrato obj)
        {
            dynamic contrato = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO contrato (idAluno, idCondPagamento, idPrograma, periodo, horario, valorTotal, diaAcordado, diasSemana, dataInicioPrograma, dataCancelamento, ativo, dataCadastro, dataUltAlt) 
        VALUES (@idAluno, @idCondPagamento, @idPrograma, @periodo, @horario, @valorTotal, @diaAcordado, @diasSemana, @dataInicioPrograma, @dataCancelamento,@ativo, @dataCadastro, @dataUltAlt)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@idAluno", contrato.idAluno);
                command.Parameters.AddWithValue("@idCondPagamento", contrato.idCondPag);
                command.Parameters.AddWithValue("@idPrograma", contrato.idPrograma);
                command.Parameters.AddWithValue("@periodo", contrato.periodo);
                command.Parameters.AddWithValue("@horario", contrato.horario);
                command.Parameters.AddWithValue("@valorTotal", contrato.ValorTotal);
                command.Parameters.AddWithValue("@diaAcordado", contrato.diaAcordado);
                command.Parameters.AddWithValue("@diasSemana", contrato.diasSemana);
                command.Parameters.AddWithValue("@dataInicioPrograma", contrato.dataInicioPrograma);
                command.Parameters.AddWithValue("@dataCancelamento", contrato.dataCancelamento ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ativo", contrato.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", contrato.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", contrato.dataUltAlt);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao salvar o contrato: " + ex.Message);
                    throw;
                }
            }
        }
    }
}
