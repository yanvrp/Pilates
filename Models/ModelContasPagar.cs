﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Models
{
    public class ModelContasPagar
    {
        public int numero { get; set; }
        public DateTime dataEmissao { get; set; }
        public int parcela { get; set; }
        public int idFornecedor { get; set; }
        public decimal valorParcela { get; set; }
        public DateTime dataVencimento { get; set; }
        public DateTime? dataPagamento { get; set; }
        public decimal? valorPago { get; set; }
        public decimal? juros { get; set; }
        public decimal? multa { get; set; }
        public decimal? desconto { get; set; }
        public int idFormaPagamento { get; set; }
        public string observacao { get; set; }
        public DateTime? dataCancelamento { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataUltAlt { get; set; }
    }
}
