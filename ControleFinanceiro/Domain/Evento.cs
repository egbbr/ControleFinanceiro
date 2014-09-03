﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Domain
{
    public class Evento
    {
        public int EventoID { get; set; }
        public DateTime CompetenciaPagamento { get; set; }
        public string Descricao { get; set; }
        public Categoria Categoria { get; set; }
        public short Parcela { get; set; }
        public short TotalParcela { get; set; }
        public decimal Valor { get; set; }
        public bool PagamentoConfirmado { get; set; }

    }
}
