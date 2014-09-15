using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleFinanceiro.Domain;
using ControleFinanceiro.Repository;

namespace ControleFinanceiro.Controler
{
    public class FrmOrcamentoControler
    {

        private OrcamentoRepository _orcamentoRepository;
        public OrcamentoRepository OrcamentoRepository
        {
            private get { return _orcamentoRepository ?? (_orcamentoRepository = new OrcamentoRepository()); }
            set { _orcamentoRepository = value; }
        }
        public IEnumerable<Orcamento> ObterOrcamentosParaExibir()
        {
            return OrcamentoRepository.ObterTodosOrcamentos();
        }

        public void AdicionarOrcamento(string valor, string descricao, DateTime competencia)
        {
            var orcamento = new Orcamento
            {
                ValorOrcamento = novoOrcamento.ValorOrcamento,
                Competencia = novoOrcamento.Competencia,
                DescricaoOrcamento = novoOrcamento.DescricaoOrcamento
            };

            OrcamentoRepository.Adicionar(orcamento);
        }

    }
}
