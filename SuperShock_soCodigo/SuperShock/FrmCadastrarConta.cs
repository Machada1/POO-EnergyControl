using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShock
{
    public partial class FrmCadastrarConta : Form
    {
        public FrmCadastrarConta()
        {
            InitializeComponent();
        }

        private void btnCadastrarConta_Click(object sender, EventArgs e)
        {
            GerenciadorDeContas gerenciador = new GerenciadorDeContas();

            string tipoConta = txtTipoConta.Text;
            double leituraMesAtual = Convert.ToDouble(txtLeitura.Text);
            double leituraMesAnterior = Convert.ToDouble(txtLeituraAnterior.Text);
            string identificadorConsumidor = txtCPFCNPJ.Text;

            ContaDeEnergia conta = new ContaDeEnergia(tipoConta, leituraMesAtual, leituraMesAnterior, identificadorConsumidor);
            gerenciador.CadastrarConta(conta);

            MessageBox.Show("Cadastro realizado com sucesso!");

            txtTipoConta.Text = string.Empty;
            txtLeitura.Text = string.Empty;
            txtLeituraAnterior.Text = string.Empty;
            txtCPFCNPJ.Text = string.Empty;

        }
    }
}
