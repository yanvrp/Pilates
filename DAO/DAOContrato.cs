using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Pilates.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using iText.IO.Image;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iText.Layout.Borders;
using iText.Layout.Properties;

namespace Pilates.DAO
{
    public class DAOContrato : DAO<ModelContrato>
    {
        public DAOContrato() : base() { }

        public override void Alterar(ModelContrato obj)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE contrato 
                         SET usuarioUltAlt = @usuarioUltAlt, 
                             idAluno = @idAluno, 
                             idCondPagamento = @idCondPagamento, 
                             idPrograma = @idPrograma, 
                             periodo = @periodo, 
                             horario = @horario, 
                             valorTotal = @valorTotal, 
                             diaAcordado = @diaAcordado, 
                             diasSemana = @diasSemana, 
                             dataInicioPrograma = @dataInicioPrograma, 
                             dataCancelamento = @dataCancelamento, 
                             dataFinalContrato = @dataFinalContrato, 
                             ativo = @ativo, 
                             dataUltAlt = @dataUltAlt 
                         WHERE idContrato = @idContrato";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@usuarioUltAlt", obj.usuarioUltAlt ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@idAluno", obj.idAluno);
                command.Parameters.AddWithValue("@idCondPagamento", obj.idCondPag);
                command.Parameters.AddWithValue("@idPrograma", obj.idPrograma);
                command.Parameters.AddWithValue("@periodo", obj.periodo);
                command.Parameters.AddWithValue("@horario", obj.horario);
                command.Parameters.AddWithValue("@valorTotal", obj.ValorTotal);
                command.Parameters.AddWithValue("@diaAcordado", obj.diaAcordado);
                command.Parameters.AddWithValue("@diasSemana", obj.diasSemana);
                command.Parameters.AddWithValue("@dataInicioPrograma", obj.dataInicioPrograma);
                command.Parameters.AddWithValue("@dataCancelamento", obj.dataCancelamento ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@dataFinalContrato", obj.dataFinalContrato ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ativo", obj.Ativo);
                command.Parameters.AddWithValue("@dataUltAlt", DateTime.Now);
                command.Parameters.AddWithValue("@idContrato", obj.idContrato);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void GerarContratoPdf(int idContrato, string caminhoArquivo)
        {

            // Consultar os dados do contrato no banco de dados
            string query = @"
        SELECT c.dataInicioPrograma, c.periodo, c.diasSemana, c.horario, c.diaAcordado, 
               c.valorTotal, a.Aluno, a.cpf, p.titulo, p.numeroAulas, p.tipoPrograma
        FROM contrato c
        JOIN aluno a ON c.idAluno = a.idAluno
        JOIN programa p ON c.idPrograma = p.idPrograma
        WHERE c.idContrato = @idContrato";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@idContrato", idContrato);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Extrair os dados do contrato
                        var dataInicioPrograma = reader.GetDateTime(0).ToString("dd/MM/yyyy");
                        var periodo = reader.GetString(1);
                        //var diasSemana = reader.GetString(2);
                        var horario = reader.GetTimeSpan(3).ToString(@"hh\:mm");
                        var diaAcordado = reader.GetInt32(4);
                        var valorTotal = reader.GetDecimal(5).ToString("C2");
                        var aluno = reader.GetString(6);
                        var cpf = reader.GetString(7);
                        var titulo = reader.GetString(8);
                        var numeroAulas = reader.GetInt32(9);
                        var tipoPrograma = reader.GetString(10);
                        //cria o PDF
                        using (PdfWriter writer = new PdfWriter(caminhoArquivo))
                        using (PdfDocument pdf = new PdfDocument(writer))
                        using (Document document = new Document(pdf))
                        {
                            var caminhoLogo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagens", "logo.jpeg");
                            try
                            {
                                var imagem = new Image(ImageDataFactory.Create(caminhoLogo)).SetWidth(120).SetHeight(100);

                                // Cria uma tabela com duas colunas
                                Table table = new Table(2);
                                table.SetWidth(UnitValue.CreatePercentValue(100)); // Define a largura para preencher a página

                                // Adiciona a imagem na primeira célula
                                Cell cellImagem = new Cell().Add(imagem);
                                cellImagem.SetBorder(Border.NO_BORDER);
                                cellImagem.SetVerticalAlignment(iText.Layout.Properties.VerticalAlignment.MIDDLE);
                                table.AddCell(cellImagem);

                                // Adiciona os textos na segunda célula
                                Cell cellTexto = new Cell();
                                cellTexto.Add(new Paragraph("EQUILÍBRIO SAÚDE E BEM ESTAR")
                                              .SetBold()
                                              .SetFontSize(16)
                                              .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT) // Alinha o texto à esquerda
                                              .SetMarginLeft(-20)); // Ajusta a margem para mover o texto para a esquerda
                                cellTexto.Add(new Paragraph("PILATES")
                                              .SetBold()
                                              .SetFontSize(14)
                                              .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT) // Alinha o texto à esquerda
                                              .SetMarginLeft(80)); // Ajusta a margem para mover o texto para a esquerda
                                cellTexto.SetVerticalAlignment(iText.Layout.Properties.VerticalAlignment.MIDDLE);
                                cellTexto.SetBorder(Border.NO_BORDER);
                                table.AddCell(cellTexto);

                                // Adiciona a tabela ao documento
                                document.Add(table);
                            }
                            catch (FileNotFoundException ex)
                            {
                                Console.WriteLine($"Erro ao carregar a imagem: {ex.Message}");
                            }

                            document.Add(new Paragraph());

                            //detalhes do contrato
                            document.Add(new Paragraph().Add(new Text("CONTRATO").SetBold()));
                            document.Add(new Paragraph().Add(new Text("- Início do Programa: ").SetBold()).Add(new Text(dataInicioPrograma)));
                            document.Add(new Paragraph().Add(new Text("- Período: ").SetBold()).Add(new Text(periodo)));

                            document.Add(new Paragraph());
                            //document.Add(new Paragraph());

                            //informações do contratante
                            document.Add(new Paragraph("CONTRATANTE").SetBold());
                            document.Add(new Paragraph().Add(new Text("- Nome: ").SetBold()).Add(new Text(aluno)));
                            document.Add(new Paragraph().Add(new Text("- CPF: ").SetBold()).Add(new Text(cpf)));

                            document.Add(new Paragraph());

                            string diasSemana = reader.GetString(2);
                            string[] dias = diasSemana.Split(';');
                            string diasFormatados = string.Join(" - ", dias);

                            //informações do programa
                            document.Add(new Paragraph("TIPO DE PROGRAMA").SetBold());
                            document.Add(new Paragraph().Add(new Text("- Tipo de Programa: ").SetBold()).Add(new Text(tipoPrograma)));
                            document.Add(new Paragraph().Add(new Text("- Plano: ").SetBold()).Add(new Text(numeroAulas.ToString())).Add(new Text(" VEZ(ES) NA SEMANA")));
                            document.Add(new Paragraph().Add(new Text("- Dias da Semana: ").SetBold()).Add(new Text(diasFormatados)));
                            document.Add(new Paragraph().Add(new Text("- Horário: ").SetBold()).Add(new Text(horario)));

                            document.Add(new Paragraph());
                            document.Add(new Paragraph());

                            //regras do contrato
                            document.Add(new Paragraph("REGRAS").SetBold());
                            document.Add(new Paragraph("1- O atendimento das aulas de Pilates acontecerão na Clínica Equilíbrio Saúde & Bem Estar, localizada na Rua Manoel Moreira Andrion, 1386 - Jardim Panorama.").SetTextAlignment(iText.Layout.Properties.TextAlignment.JUSTIFIED));
                            document.Add(new Paragraph("a) Nos dias e horários neste contrato relatados.").SetTextAlignment(iText.Layout.Properties.TextAlignment.JUSTIFIED));

                            document.Add(new Paragraph());

                            document.Add(new Paragraph($"2- O serviço contratado tem o valor mensal de {valorTotal}, tendo que ser pago de forma adiantada e sempre na mesma data;\r\n").SetTextAlignment(iText.Layout.Properties.TextAlignment.JUSTIFIED));
                            document.Add(new Paragraph($"a) Data acordada para o pagamento mensal: {diaAcordado};").SetTextAlignment(iText.Layout.Properties.TextAlignment.JUSTIFIED));
                            document.Add(new Paragraph($"b) Para planos de 1x na semana são 4 aulas ao mês, para planos de 2x na semana serão realizadas 8 aulas ao mês e para planos de 3x na semana serão realizadas 12 aulas ao mês.").SetTextAlignment(iText.Layout.Properties.TextAlignment.JUSTIFIED));

                            document.Add(new Paragraph());

                            document.Add(new Paragraph($"3- Reposições: Será realizado 2 aulas de reposições ao mês com justificativa e aviso prévio de pelo menos 1 hora de antecedência da aula, para avisos no horário ou passados do horário não será realizada reposição;\r\n").SetTextAlignment(iText.Layout.Properties.TextAlignment.JUSTIFIED));
                            document.Add(new Paragraph($"a) As aulas perdidas em relação a viagens serão realizadas reposições referentes a 15 dias do plano mensal;").SetTextAlignment(iText.Layout.Properties.TextAlignment.JUSTIFIED));
                            document.Add(new Paragraph($"b) Não é realizado reposições de aulas referentes a feriados.").SetTextAlignment(iText.Layout.Properties.TextAlignment.JUSTIFIED));
                            document.Add(new Paragraph($"c) As reposições tem um prazo máximo de 30 dias para serem agendadas de comum acordo para serem realizadas caso ultrapasse esse período perderá o direito a reposição.\r\n").SetTextAlignment(iText.Layout.Properties.TextAlignment.JUSTIFIED));

                            document.Add(new Paragraph());

                            document.Add(new Paragraph($"4- O Contratante poderá trancar o plano por um período de 2 meses caso seja necessário realizar alguma cirurgia;\r\n").SetTextAlignment(iText.Layout.Properties.TextAlignment.JUSTIFIED));
                            document.Add(new Paragraph($"a) Esta pausa no contrato deverá ser avisada com antecedência de 30 dias, caso não avise com antecedência terá que pagar a mensalidade do próximo mês;\r\n").SetTextAlignment(iText.Layout.Properties.TextAlignment.JUSTIFIED));
                            document.Add(new Paragraph($"b) Só será reservado horário mediante pagamento da mensalidade integralmente, nos meses parado.\r\n").SetTextAlignment(iText.Layout.Properties.TextAlignment.JUSTIFIED));

                            document.Add(new Paragraph());

                            document.Add(new Paragraph($"5- CANCELAMENTO: Para o cancelamento do plano antes do prazo final do contrato o contratante fica ciente de ter que pagar uma multa referente a uma mensalidade do plano que o mesmo contratou.\r\n").SetTextAlignment(iText.Layout.Properties.TextAlignment.JUSTIFIED));

                            document.Add(new Paragraph());

                            document.Add(new Paragraph($"6- Mensalidades de Dezembro e Janeiro devem ser pagas integralmente e na mesma data de comum acordo.\r\n").SetTextAlignment(iText.Layout.Properties.TextAlignment.JUSTIFIED));

                            document.Add(new Paragraph());

                            document.Add(new Paragraph($"7- RECESSO de Fim de Ano: será realizado recesso e férias da fisioterapeuta referente a 15 dias, caso ultrapasse quinze dias será realizado reposições das aulas referentes ao que ultrapassou.\r\n").SetTextAlignment(iText.Layout.Properties.TextAlignment.JUSTIFIED));

                            document.Add(new Paragraph());

                            document.Add(new Paragraph($"8- As mensalidades sofreram um reajuste de 5% a cada período de um ano sobre a mensalidade já paga.\r\n").SetTextAlignment(iText.Layout.Properties.TextAlignment.JUSTIFIED));

                            document.Add(new Paragraph());
                            // Data e assinatura
                            var dataAtual = DateTime.Now;
                            document.Add(new Paragraph($"\nFoz do Iguaçu, {dataAtual:dd} de {dataAtual:MMMM} de {dataAtual:yyyy}."));

                            document.Add(new Paragraph());
                            document.Add(new Paragraph());

                            document.Add(new Paragraph("\n-------------------------------").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
                            document.Add(new Paragraph("Fisioterapeuta").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
                            document.Add(new Paragraph("Dheyme Conte").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
                            document.Add(new Paragraph("CPF: 067.820.039-45").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));

                            document.Add(new Paragraph());
                            document.Add(new Paragraph());

                            string cpfFormatado = !string.IsNullOrEmpty(cpf) && long.TryParse(cpf.Replace(".", "").Replace("-", ""), out long cpfNumerico) ? cpfNumerico.ToString(@"000\.000\.000\-00") : "";


                            document.Add(new Paragraph("\n-------------------------------").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
                            document.Add(new Paragraph("Contratante").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
                            document.Add(new Paragraph("Nome: " + aluno).SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
                            document.Add(new Paragraph("CPF: " + cpfFormatado).SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
                        }
                    }
                }
            }
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
        public void CancelarContrato(int idContrato)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //atualizar o contrato e adicionar a data de cancelamento
                string queryContrato = @"UPDATE contrato 
                                 SET dataCancelamento = @dataCancelamento, 
                                     dataUltAlt = @dataUltAlt 
                                 WHERE idContrato = @idContrato";

                //obter as parcelas em aberto
                string queryParcelasEmAberto = @"SELECT parcela, dataVencimento 
                                         FROM contasReceber 
                                         WHERE numero = @idContrato 
                                         AND dataRecebimento IS NULL 
                                         AND dataCancelamento IS NULL 
                                         ORDER BY dataVencimento";

                //cancelar aulas futuras na agenda associadas ao contrato
                string queryCancelarAulasFuturas = @"UPDATE agenda 
                                             SET dataCancelamento = @dataCancelamento, 
                                                 situacao = 'CANCELADO' 
                                             WHERE idContrato = @idContrato 
                                             AND data > @dataHoje 
                                             AND ativo = 1";

                SqlCommand commandContrato = new SqlCommand(queryContrato, connection);
                commandContrato.Parameters.AddWithValue("@dataCancelamento", DateTime.Now);
                commandContrato.Parameters.AddWithValue("@dataUltAlt", DateTime.Now);
                commandContrato.Parameters.AddWithValue("@idContrato", idContrato);

                SqlCommand commandParcelasEmAberto = new SqlCommand(queryParcelasEmAberto, connection);
                commandParcelasEmAberto.Parameters.AddWithValue("@idContrato", idContrato);

                SqlCommand commandCancelarAulasFuturas = new SqlCommand(queryCancelarAulasFuturas, connection);
                commandCancelarAulasFuturas.Parameters.AddWithValue("@dataCancelamento", DateTime.Now);
                commandCancelarAulasFuturas.Parameters.AddWithValue("@idContrato", idContrato);
                commandCancelarAulasFuturas.Parameters.AddWithValue("@dataHoje", DateTime.Today);

                try
                {
                    connection.Open();
                    commandContrato.ExecuteNonQuery();

                    //puxa as parcelas em aberto
                    List<int> parcelasACancelar = new List<int>();
                    using (SqlDataReader reader = commandParcelasEmAberto.ExecuteReader())
                    {
                        List<(int parcela, DateTime dataVencimento)> parcelasEmAberto = new List<(int, DateTime)>();

                        while (reader.Read())
                        {
                            int parcela = reader.GetInt32(0);
                            DateTime dataVencimento = reader.GetDateTime(1);
                            parcelasEmAberto.Add((parcela, dataVencimento));
                        }

                        //qtde de parcelas em aberto
                        if (parcelasEmAberto.Count > 1)
                        {
                            //ordena as parcelas por data de vencimento e exclui a próxima a vencer
                            parcelasEmAberto = parcelasEmAberto.OrderBy(p => p.dataVencimento).ToList();
                            parcelasACancelar = parcelasEmAberto.Skip(1).Select(p => p.parcela).ToList();
                        }
                    }

                    //se tem parcelas para cancelar, atualiza as parcelas correspondentes
                    if (parcelasACancelar.Any())
                    {
                        string queryCancelarParcelas = @"UPDATE contasReceber 
                                                 SET dataCancelamento = @dataCancelamento 
                                                 WHERE numero = @idContrato 
                                                 AND parcela IN (" + string.Join(",", parcelasACancelar) + ")";

                        SqlCommand commandCancelarParcelas = new SqlCommand(queryCancelarParcelas, connection);
                        commandCancelarParcelas.Parameters.AddWithValue("@dataCancelamento", DateTime.Now);
                        commandCancelarParcelas.Parameters.AddWithValue("@idContrato", idContrato);

                        int rowsAffected = commandCancelarParcelas.ExecuteNonQuery();
                        Console.WriteLine($"{rowsAffected} contas a receber canceladas.");
                    }
                    else
                    {
                        Console.WriteLine("Nenhuma parcela foi cancelada, pois há apenas uma parcela restante.");
                    }
                    int aulasCanceladas = commandCancelarAulasFuturas.ExecuteNonQuery();
                    Console.WriteLine($"{aulasCanceladas} aulas futuras canceladas.");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao cancelar o contrato, contas a receber e agenda: " + ex.Message);
                    throw;
                }
            }
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
                        contrato.usuarioUltAlt = reader["usuarioUltAlt"].ToString();
                        contrato.diasSemana = reader["diasSemana"].ToString();
                        contrato.horario = (TimeSpan)reader["horario"];
                        contrato.ValorTotal = Convert.ToDecimal(reader["valorTotal"]);
                        contrato.diaAcordado = Convert.ToInt32(reader["diaAcordado"]);
                        contrato.Ativo = Convert.ToBoolean(reader["Ativo"]);
                        contrato.dataCancelamento = reader["dataCancelamento"] != DBNull.Value ? Convert.ToDateTime(reader["dataCancelamento"]) : (DateTime?)null;
                        contrato.dataFinalContrato = reader["dataFinalContrato"] != DBNull.Value ? Convert.ToDateTime(reader["dataFinalContrato"]) : (DateTime?)null;
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
                string query = BuscarInativos ? "SELECT * FROM contrato" : "SELECT * FROM contrato WHERE ativo = 1";
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
                        contrato.dataFinalContrato = reader["dataFinalContrato"] != DBNull.Value ? Convert.ToDateTime(reader["dataFinalContrato"]) : (DateTime?)null;

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
        public int SalvarC(ModelContrato obj)
        {
            dynamic contrato = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO contrato (usuarioUltAlt, idAluno, idCondPagamento, idPrograma, periodo, horario, valorTotal, diaAcordado, diasSemana, dataInicioPrograma, dataCancelamento, dataFinalContrato, ativo, dataCadastro, dataUltAlt) 
                         VALUES (@usuarioUltAlt, @idAluno, @idCondPagamento, @idPrograma, @periodo, @horario, @valorTotal, @diaAcordado, @diasSemana, @dataInicioPrograma, @dataCancelamento, @dataFinalContrato, @ativo, @dataCadastro, @dataUltAlt);
                         SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@idAluno", contrato.idAluno);
                command.Parameters.AddWithValue("@usuarioUltAlt", contrato.usuarioUltAlt);
                command.Parameters.AddWithValue("@idCondPagamento", contrato.idCondPag);
                command.Parameters.AddWithValue("@idPrograma", contrato.idPrograma);
                command.Parameters.AddWithValue("@periodo", contrato.periodo);
                command.Parameters.AddWithValue("@horario", contrato.horario);
                command.Parameters.AddWithValue("@valorTotal", contrato.ValorTotal);
                command.Parameters.AddWithValue("@diaAcordado", contrato.diaAcordado);
                command.Parameters.AddWithValue("@diasSemana", contrato.diasSemana);
                command.Parameters.AddWithValue("@dataInicioPrograma", contrato.dataInicioPrograma);
                command.Parameters.AddWithValue("@dataCancelamento", contrato.dataCancelamento ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@dataFinalContrato", contrato.dataFinalContrato ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ativo", contrato.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", contrato.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", contrato.dataUltAlt);

                try
                {
                    connection.Open();
                    return Convert.ToInt32(command.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao salvar o contrato: " + ex.Message);
                    throw;
                }
            }
        }
        public bool VerificarContratoAtivo(int idAluno)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT COUNT(1)
                         FROM contrato
                         WHERE idAluno = @idAluno
                         AND ativo = 1
                         AND (dataInicioPrograma <= @dataHoje AND (dataFinalContrato IS NULL OR dataFinalContrato >= @dataHoje)
                         AND dataCancelamento IS NULL)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idAluno", idAluno);
                command.Parameters.AddWithValue("@dataHoje", DateTime.Today);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                return count > 0; // Retorna true se existir pelo menos um contrato ativo
            }
        }


        public override void Salvar(ModelContrato obj)
        {
            
        }
    }
}
