using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleFinanceiro.Controler;
using ControleFinanceiro.Domain;
using ControleFinanceiro.Repository;

namespace ControleFinanceiro
{
    public partial class FrmOrcamento : Form
    {
        private FrmOrcamentoControler _controler;
        public FrmOrcamentoControler Controler
        {
            private get { return _controler ?? (_controler = new FrmOrcamentoControler()); }
            set { _controler = value; }
        }
        
        public FrmOrcamento()
        {
            InitializeComponent();
            AtualizarGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var valorOrcamento = txtValor.Text;
            if (valorOrcamento == string.Empty)
            {
                valorOrcamento = Convert.ToString(0);
            }

            var novoOrcamento = new OrcamentoDTO
            {
                Competencia = dtpData.Value,
                ValorOrcamento = Convert.ToDecimal(valorOrcamento),
                DescricaoOrcamento = txtDescricao.Text
            };


            if (ValidarNovoOrcamento(novoOrcamento))
            {
               Controler.AdicionarOrcamento(novoOrcamento);
               AtualizarGrid();
            }
            

            dtpData.Value = DateTime.Now;
            txtDescricao.Text = null;
            txtValor.Text = null;

        }

        private bool ValidarNovoOrcamento(OrcamentoDTO orcamento)
        {
            if (Convert.ToString(orcamento.ValorOrcamento) == string.Empty) return true;
            MessageBox.Show("valor Informado não aceito");
            return false;
        }

        private void AtualizarGrid()
        {
            dataGridView1.DataSource = Controler.ObterOrcamentosParaExibir();
        }


    }
}
