using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Domain
{
    public class FormaCobranca
    {
        public short FormaCobrancaID { get; set; }
        public string Descricao { get; set; }
        public Banco Banco { get; set; }
    }
}
