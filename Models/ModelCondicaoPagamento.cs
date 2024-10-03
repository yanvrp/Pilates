using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Models
{
    public class ModelCondicaoPagamento
    {
        public int idCondPagamento { get; set; }
        public string condicaoPagamento { get; set; }
        public decimal desconto { get; set; }
        public decimal juros { get; set; }
        public decimal multa { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataUltAlt { get; set; }
        public bool Ativo { get; set; }
        public List<ModelParcela> Parcelas { get; set; }
    }
}
