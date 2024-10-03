using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Models
{
    public class ModelAluno
    {
        public int idAluno { get; set; }
        public string Aluno { get; set; }
        public string Apelido { get; set; }
        public string endereco {  get; set; }
        public string bairro { get; set; }
        public int numero { get; set; }
        public string cep { get; set; }
        public string complemento { get; set; }
        public string sexo { get; set; }
        public string email { get; set; }
        public string celular { get; set; }
        public string cpf { get; set; }
        public int idCidade { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataUltAlt { get; set; }
        public DateTime dataNasc { get; set; }
        public bool Ativo { get; set; }
        public List<ModelEvolucao> Evolucoes { get; set; }
        public List<ModelPostura> Posturas { get; set; }
    }
}
