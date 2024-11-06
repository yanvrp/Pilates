using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Models
{
    public class ModelContasReceber
    {
        public int numero { get; set; }
        public int idAluno { get; set; }
        public DateTime dataEmissao { get; set; }
        public int parcela { get; set; }
        public decimal valorParcela { get; set; }
        public DateTime dataVencimento { get; set; }
        public DateTime? dataRecebimento { get; set; }
        public decimal? valorRecebido { get; set; }
        public string usuarioUltAlt { get; set; }
        public decimal? juros { get; set; }
        public decimal? multa { get; set; }
        public decimal? desconto { get; set; }
        public int idFormaPagamento { get; set; }
        public string observacao { get; set; }
        public DateTime? dataCancelamento { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataUltAlt { get; set; }
    }
}
