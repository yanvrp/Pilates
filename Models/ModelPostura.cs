using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Models
{
    public class ModelPostura
    {
        public int idPostura { get; set; }
        public string cabecaPostura { get; set; }
        public string ombroPostura { get; set; }
        public string escapuloPostura { get; set; }
        public string maosPostura { get; set; }
        public string cervicalPostura { get; set; }
        public string toracicaPostura { get; set; }
        public string lombarPostura { get; set; }
        public string usuarioUltAlt { get; set; }
        public string quadrilPostura { get; set; }
        public string joelhoPostura { get; set; }
        public string pesPostura { get; set; }
        public string titulo { get; set; }
        public string Outros {  get; set; }
        public int idAluno { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataUltAlt { get; set; }
        public bool Ativo { get; set; }
    }
}
