using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Models
{
    public class ModelAvaliacaoCirurgia
    {
        public int idCirurgia { get; set; }
        public int idAvaliacao { get; set; }
        public DateTime dataCirurgia { get; set; }
        public string observacao { get; set; }
    }
}
