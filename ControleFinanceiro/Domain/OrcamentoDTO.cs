using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Domain
{
    public class OrcamentoDTO
    {
        public decimal ValorOrcamento { get; set; }
        public string DescricaoOrcamento { get; set; }
        public DateTime Competencia { get; set; }
    }
}
