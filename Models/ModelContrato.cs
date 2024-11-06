using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Models
{
    public class ModelContrato
    {
        public int idContrato { get; set; }
        public int idAluno { get; set; }
        public int idPrograma { get; set; }
        public int idCondPag { get; set; }
        public int diaAcordado { get; set; }
        public TimeSpan horario { get; set; }
        public string periodo { get; set; }
        public decimal ValorTotal { get; set; }
        public string usuarioUltAlt { get; set; }
        public string diasSemana { get; set; }
        public DateTime dataInicioPrograma { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime? dataCancelamento { get; set; }
        public DateTime? dataFinalContrato { get; set; }
        public DateTime dataUltAlt { get; set; }
        public bool Ativo { get; set; }
    }
}
