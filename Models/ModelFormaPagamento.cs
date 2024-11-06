using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Models
{
    public class ModelFormaPagamento
    {
        public int idFormaPagamento { get; set; }
        public string formaPagamento { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataUltAlt { get; set; }
        public bool Ativo { get; set; }
        public string usuarioUltAlt { get; set; }
    }
}
