using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Models
{
    public class ModelAvaliacaoMedicamento
    {
        public int idMedicamento { get; set; }
        public int idAvaliacao { get; set; }
        public string dosagem { get; set; }
        public string frequencia { get; set; }
        public string observacao { get; set; }
    }
}
