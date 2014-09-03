using System;
using ControleFinanceiro.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace ControleFinanceiroTest
{
    [TestFixture]
    public class EventoRepositoryTest
    {    
        [Test]
        public void Testar_O_Get_All()
        {
            var repo = new EventoRepository();
            repo.ObterTodosEventos();

        }
    }
}
