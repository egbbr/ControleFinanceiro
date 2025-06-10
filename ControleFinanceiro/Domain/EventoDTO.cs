using System;

namespace ControleFinanceiro.Domain
{
    public class EventoDTO
    {
        public DateTime CompetenciaPagamento { get; set; }
        public string Descricao { get; set; }
        public short CategoriaID { get; set; }
        public decimal Valor { get; set; }
        public short BancoID { get; set; }
    }
}
