using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Models
{
    public class ModelParcela
    {
        public int idParcela { get; set; }
        public int numeroParcela { get; set; }
        public decimal porcentagem { get; set; }
        public int idCondPagamento { get; set; }
        public int idFormaPagamento { get; set; }
    }
}
