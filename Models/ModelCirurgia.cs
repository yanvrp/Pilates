using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Models
{
    public class ModelCirurgia
    {
        public int idCirurgia { get; set; }
        public string cirurgia { get; set; }
        public string descricao { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataUltAlt { get; set; }
        public string usuarioUltAlt { get; set; }
        public bool Ativo { get; set; }
    }
}
