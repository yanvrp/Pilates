using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Models
{
    public class ModelCidade
    {
        public int idCidade { get; set; }
        public string Cidade { get; set; }
        public int DDD { get; set; }
        public int idEstado { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataUltAlt { get; set; }
        public bool Ativo { get; set; }
    }
}
