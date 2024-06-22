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
            double leituraMesAtual = double.Parse(txtLeitura.Text);
            double leituraMesAnterior = double.Parse(txtLeituraAnterior.Text);
            string identificadorConsumidor = txtCPFCNPJ.Text;

            ContaDeEnergia conta = new ContaDeEnergia(tipoConta, leituraMesAtual, leituraMesAnterior, identificadorConsumidor);
            gerenciador.CadastrarConta(conta);

           //MessageBox.Show("Cadastro realizado com sucesso!");

            try
            {
                if (string.IsNullOrEmpty(txtTipoConta.Text))
                {
                    MessageBox.Show("Tipo de Conta não pode ser vazio. Por favor, preencha o campo para prosseguir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTipoConta.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtLeitura.Text))
                {
                    MessageBox.Show("Leitura do Mês Atual não pode ser vazio.Por favor, preencha o campo para prosseguir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLeitura.Focus();
                    return;
                }

                //verifica se a leitura é double
                if (!double.TryParse(txtLeitura.Text, out double leitura))
                {
                    MessageBox.Show("Leitura atual deve conter um valor válido. Por favor, preencha o campo para prosseguir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLeitura.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtLeituraAnterior.Text))
                {
                    MessageBox.Show("Leitura do mês anterior não pode ser vazio. Por favor, preencha o campo para prosseguir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLeituraAnterior.Focus();
                    return;
                }

                if (!double.TryParse(txtLeituraAnterior.Text, out double leituraAnt))
                {
                    MessageBox.Show("Leitura do mês anterior deve conter um valor válido. Por favor, preencha o campo para prosseguir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLeituraAnterior.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtCPFCNPJ.Text))
                {
                    MessageBox.Show("CPF/CNPJ não pode ser vazio. Por favor, preencha o campo para prosseguir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCPFCNPJ.Focus();
                    return;
                }

                else
                {
                    MessageBox.Show("Todos os campos foram preenchidos corretamente!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtTipoConta.Text = string.Empty;
            txtLeitura.Text = "";
            txtLeituraAnterior.Text = "";
            txtCPFCNPJ.Text = string.Empty;

        }
    }
}
