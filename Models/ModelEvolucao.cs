using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Models
{
    public class ModelEvolucao
    {
        public int idEvolucao { get; set; }
        public int idAluno { get; set; }
        public string titulo { get; set; }
        public string observacao { get; set; }
        public DateTime dataCadastro { get; set; }
        public string usuarioUltAlt { get; set; }
        public DateTime dataUltAlt { get; set; }
        public bool Ativo { get; set; }
    }
}
