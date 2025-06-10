using System;
using System.Linq;
using System.Windows.Forms;
using ControleFinanceiro.Repository;
using ControleFinanceiro.Domain;

namespace ControleFinanceiro
{
    public partial class FrmLancamento : Form
    {
        private readonly EventoRepository _eventoRepository = new EventoRepository();

        public FrmLancamento()
        {
            InitializeComponent();
            CarregarCategorias();
            AtualizarGrid();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            decimal valor;
            if (!decimal.TryParse(txtValor.Text, out valor))
            {
                MessageBox.Show("Valor inválido");
                return;
            }

            var novoEvento = new Evento
            {
                CompetenciaPagamento = dtpData.Value,
                Descricao = txtDescricao.Text,
                Categoria = _eventoRepository.CategoriaRepository.ObterPorID((short)cmbCategoria.SelectedValue),
                Parcela = 1,
                TotalParcela = 1,
                Valor = valor,
                PagamentoConfirmado = true,
                Banco = _eventoRepository.BancoRepository.ObterPorID(1)
            };

            _eventoRepository.Adicionar(novoEvento);
            AtualizarGrid();

            dtpData.Value = DateTime.Now;
            txtDescricao.Text = string.Empty;
            txtValor.Text = string.Empty;
        }

        private void CarregarCategorias()
        {
            cmbCategoria.DataSource = _eventoRepository.CategoriaRepository.ObterTodasCategorias().ToList();
            cmbCategoria.DisplayMember = "Descricao";
            cmbCategoria.ValueMember = "CategoriaID";
        }

        private void AtualizarGrid()
        {
            var eventos = _eventoRepository.ObterTodosEventos()
                .Select(x => new { x.EventoID, x.CompetenciaPagamento, x.Descricao, Categoria = x.Categoria.Descricao, x.Valor })
                .ToList();
            dataGridView1.DataSource = eventos;
        }
    }
}
