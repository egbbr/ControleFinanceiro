namespace ControleFinanceiro.Domain
{
    public class Categoria
    {
        public short CategoriaID { get; set; }
        public string Descricao { get; set; }
    }

    public enum CategoriaEnum
    {
        Lazer = 1,
        Poupanca = 2
    }
}