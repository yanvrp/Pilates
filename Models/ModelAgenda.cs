using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Models
{
    public class ModelAgenda
    {
        public int idAgenda {  get; set; }
        public TimeSpan horario { get; set; }
        public int? idContrato { get; set; }
        public string? situacao { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataUltAlt { get; set; }
        public DateTime data { get; set; }
        public bool Ativo { get; set; }
    }
}
