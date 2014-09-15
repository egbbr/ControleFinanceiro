using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ControleFinanceiro.Domain;

namespace ControleFinanceiro.Repository
{
    public class OrcamentoRepository
    {


        private const string CaminhoArquivo = @"C:\Users\esouza.ESOUZANOTE-PC\Documents\GitHub\ControleFinanceiro\ControleFinanceiro\Repository\Orcamento.txt";

        public IEnumerable<Orcamento> ObterTodosOrcamentos()
        {
            return GetAll();        
        }

        private List<Orcamento> GetAll()
        {
            var listaOrcamentos = new List<Orcamento>();
            var leitor = new StreamReader(CaminhoArquivo);
            var linha = leitor.ReadLine();
            while (linha != null)
            {
                var dadosObtidos = Regex.Split(linha, ";");
                if (!dadosObtidos.Any() || dadosObtidos[0] != "")
                {
                    listaOrcamentos.Add(new Orcamento()
                {
                    OrcamentoID = Convert.ToInt32(dadosObtidos[0]),
                    Competencia = Convert.ToDateTime(dadosObtidos[1]),
                    ValorOrcamento = Convert.ToDecimal(dadosObtidos[2]),
                    DescricaoOrcamento = dadosObtidos[3]                          
                });
                }

                linha = leitor.ReadLine();
            }
            leitor.Dispose();
            return listaOrcamentos;
        }

        public void Adicionar(Orcamento novOrcamento)
        {
            var todos = GetAll();
            novOrcamento.OrcamentoID = todos.Select(orcamento => orcamento.OrcamentoID).Concat(new[] { 0 }).Max() + 1;
            todos.Add(novOrcamento);
            SalveAll(todos);
        }

        private void SalveAll(IEnumerable<Orcamento> orcamentos)
        {
            var escritor = new StreamWriter(CaminhoArquivo);
            foreach (var orcamento in orcamentos)
            {
                escritor.WriteLine(orcamento.OrcamentoID + ";" + orcamento.Competencia + ";" + orcamento.ValorOrcamento + ";" + orcamento.DescricaoOrcamento);
            }
            escritor.Dispose();
            
        }
 
    }
}
