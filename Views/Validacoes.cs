using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilates.Views
{
    public class Validacoes
    {
        public static bool VerificaLetras(string texto)
        {
            //se o campo estiver vazio, considera-se válido
            if (string.IsNullOrWhiteSpace(texto))
                return true;

            //verificar se a string contém somente letras, espaços, acentos e ç
            Regex regex = new Regex(@"^[a-zA-ZÀ-ü\sçÇ]+$");

            return regex.IsMatch(texto);
        }

        public static bool VerificaLetrasSemEspaco(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return true;

            //verificar se a string contém somente letras (sem espaços)
            Regex regex = new Regex("^[a-zA-Z]+$");

            return regex.IsMatch(texto);
        }

        public static bool VerificaNumeros(string texto)
        {
            //se o campo estiver vazio, considera-se válido
            if (string.IsNullOrWhiteSpace(texto))
                return true;

            //verificar se a string contém somente números (sem espaços entre eles)
            Regex regex = new Regex("^[0-9]+$");

            return regex.IsMatch(texto);
        }

        public static bool CampoObrigatorio(string texto)
        {
            //verifica se o texto está vazio ou contém apenas espaços em branco
            return !string.IsNullOrWhiteSpace(texto);
        }
        public static bool ValidaCPF(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
            {
                return true;
            }
            else
            {
                // Remove caracteres não numéricos
                cpf = cpf.Replace(".", "").Replace("-", "");

                // Verifica se a string tem 11 caracteres (tamanho de um CPF)
                if (cpf.Length != 11)
                    return false;

                // Verifica se todos os dígitos são iguais
                bool todosIguais = true;
                for (int i = 1; i < cpf.Length; i++)
                {
                    if (cpf[i] != cpf[0])
                    {
                        todosIguais = false;
                        break;
                    }
                }
                if (todosIguais)
                    return false;

                // Calcula o primeiro dígito verificador
                int soma = 0;
                for (int i = 0; i < 9; i++)
                {
                    soma += int.Parse(cpf[i].ToString()) * (10 - i);
                }
                int resto = soma % 11;
                int dv1 = resto < 2 ? 0 : 11 - resto;

                // Calcula o segundo dígito verificador
                soma = 0;
                for (int i = 0; i < 10; i++)
                {
                    soma += int.Parse(cpf[i].ToString()) * (11 - i);
                }
                resto = soma % 11;
                int dv2 = resto < 2 ? 0 : 11 - resto;

                // Verifica se os dígitos verificadores calculados são iguais aos informados
                return dv1 == int.Parse(cpf[9].ToString()) && dv2 == int.Parse(cpf[10].ToString());
            }
        }
        public static bool VerificarDataMenorOuIgualHoje(string dataStr, string campoNome)
        {

            //verificar se o texto no campo é uma data válida
            if (!DateTime.TryParseExact(dataStr, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data))
            {
                MessageBox.Show($"A data de {campoNome} inserida é inválida. Por favor, insira uma data no formato dd/MM/yyyy.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //verificar se a data não é maior que a data de hoje
            if (data > DateTime.Today)
            {
                MessageBox.Show($"A data de {campoNome} não pode ser maior que a data de hoje.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static bool ValidaEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return true;
            else
            {
                string padrao = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                Regex regex = new Regex(padrao);
                return regex.IsMatch(email);
            }
        }
        public static bool DataValida(string data, string formato = "dd/MM/yyyy")
        {
            //tenta converter a string para DateTime usando o formato especificado
            DateTime dataConvertida;
            bool dataValida = DateTime.TryParseExact(data, formato, null, System.Globalization.DateTimeStyles.None, out dataConvertida);

            return dataValida;
        }
        public static string FormataPreco(string texto)
        {
            texto = texto.Replace(".", "").Replace(" ", "");

            if (string.IsNullOrWhiteSpace(texto))
            {
                return string.Empty;
            }
            if (decimal.TryParse(texto, out decimal value))
            {
                return value.ToString("N2");
            }
            else
            {
                throw new FormatException("Valor inválido.");
            }
        }
    }
}
