using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Models
{
    public class ModelUsuario
    {
        public int idUsuario { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataUltAlt { get; set; }
        public string usuarioUltAlt { get; set; }
        public bool Ativo { get; set; }
    }
}
