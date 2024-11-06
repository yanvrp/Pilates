using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Models
{
    public class ModelAvaliacao
    {
        public int idAvaliacao { get; set; }
        public int idAluno { get; set; }
        public DateTime data { get; set; }      
        public DateTime dataCadastro { get; set; }
        public DateTime dataUltAlt { get; set; }
        public bool Ativo { get; set; }
        public string? observacao { get; set; }
        public DateTime? dataCancelamento { get; set; }
        public string usuarioUltAlt { get; set; }
        public List<ModelAvaliacaoDores> Dores { get; set; }
        public List<ModelAvaliacaoDoenca> Doenca { get; set; }
        public List<ModelAvaliacaoCirurgia> Cirurgia { get; set; }
        public List<ModelAvaliacaoGestacao> Gestacao { get; set; }
        public List<ModelAvaliacaoMedicamento> Medicamento { get; set; }
    }
}

