using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Models
{
    public class ModelDores
    {
        public int idDores { get; set; }
        public string dores { get; set; }
        public string descricao { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataUltAlt { get; set; }
        public bool Ativo { get; set; }
    }
}
