using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Models
{
    public class ModelPrograma
    {
        public int idPrograma { get; set; }
        public string titulo { get; set; }
        public int numeroAulas { get; set; }
        public decimal Valor { get; set; }
        public string tipoPrograma { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataUltAlt { get; set; }
        public bool Ativo { get; set; }
        public string usuarioUltAlt { get; set; }
    }
}
