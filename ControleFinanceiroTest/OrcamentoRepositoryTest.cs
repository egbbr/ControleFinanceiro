using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleFinanceiro.Repository;
using NUnit.Framework;

namespace ControleFinanceiroTest
{
    [TestFixture]
    public class OrcamentoRepositoryTest
    {
        [Test]
        public void Testar_O_Get_All()
        {
            var repo = new OrcamentoRepository();
            var resultado = repo.ObterTodosOrcamentos();
            Assert.IsTrue(resultado.Any());

        }
    }
}
