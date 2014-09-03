using System.Collections.Generic;
using System.Linq;
using ControleFinanceiro.Domain;

namespace ControleFinanceiro.Repository
{
    public class CategoriaRepository
    {
        public Categoria ObterPorID(short categoriaId)
        {
            return GetAll().FirstOrDefault(x => x.CategoriaID == categoriaId);
        }

        private IEnumerable<Categoria> GetAll()
        {
            var lista = new List<Categoria>
            {
                new Categoria() {CategoriaID = 1, Descricao = "Poupanca"},
                new Categoria() {CategoriaID = 2, Descricao = "Lazer"}
            };
            return lista;
        }
    }
}