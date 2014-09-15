using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleFinanceiro.Domain;

namespace ControleFinanceiro.Repository
{
    public class BancoRepository
    {
        public Banco ObterPorID(short bancoId)
        {
            return GetAll().FirstOrDefault(x => x.BancoID== bancoId);
        }

        private IEnumerable<Banco> GetAll()
        {
            var lista = new List<Banco>
            {
                new Banco() {BancoID = 1, Descricao = "Itau"},
                new Banco() {BancoID = 2, Descricao = "CitiBank"}
            };
            return lista;
        }
    }

 }

