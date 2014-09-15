using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Domain
{
    public class Orcamento
    {
        public int OrcamentoID { get; set; }
        public DateTime Competencia { get; set; }
        public decimal ValorOrcamento { get; set; }
        public string DescricaoOrcamento { get; set; }

    }
}
