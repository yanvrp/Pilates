using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Models
{
    public class ModelEstado
    {
        public int idEstado { get; set; }
        public string Estado { get; set; }
        public string UF { get; set; }
        public int idPais { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataUltAlt { get; set; }
        public bool Ativo { get; set; }
        public string usuarioUltAlt { get; set; }
    }
}
