using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Models
{
    public class ModelAvaliacaoGestacao
    {
        public int idGestacao { get; set; }
        public int idAvaliacao { get; set; }
        public DateTime dataParto { get; set; }
        public string observacao { get; set; }
    }
}
