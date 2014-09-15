using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ControleFinanceiro.Domain;

namespace ControleFinanceiro.Repository
{
    public class EventoRepository
    {
        #region Propriedades

        private CategoriaRepository _categoriaRepository;
        public CategoriaRepository CategoriaRepository
        {
            private get { return _categoriaRepository ?? (_categoriaRepository = new CategoriaRepository()); }
            set { _categoriaRepository = value; }
        }

        private BancoRepository _bancoRepository;
        public BancoRepository BancoRepository
        {
            private get { return _bancoRepository ?? (_bancoRepository = new BancoRepository()); }
            set { _bancoRepository = value; }
        }

        private const string CaminhoArquivo = @"C:\Users\esouza.ESOUZANOTE-PC\Documents\GitHub\ControleFinanceiro\ControleFinanceiro\Repository\EventoBase.txt";

        #endregion

        public IEnumerable<Evento> ObterTodosEventos()
        {
            return GetAll();
        }


        private IEnumerable<Evento> GetAll()
        {
            var ListaEventos = new List<Evento>();
            var leitor = new StreamReader(CaminhoArquivo);
            var linha = leitor.ReadLine();
            while (linha != null)
            {
               
                var dadosObtidos = Regex.Split(linha, ";");
                ListaEventos.Add(new Evento()
                {
                    EventoID = Convert.ToInt32(dadosObtidos[0]),
                    CompetenciaPagamento = Convert.ToDateTime(dadosObtidos[1]),
                    Descricao = dadosObtidos[2],
                    Categoria = CategoriaRepository.ObterPorID(Convert.ToInt16(dadosObtidos[3])),
                    Parcela = Convert.ToInt16(dadosObtidos[4]),
                    TotalParcela = Convert.ToInt16(dadosObtidos[5]),
                    Valor = Convert.ToDecimal(dadosObtidos[6]),
                    Banco = BancoRepository.ObterPorID(Convert.ToInt16(dadosObtidos[8]))
                });
                    
                linha = leitor.ReadLine();
            }

            return ListaEventos;
        }

}   

}
