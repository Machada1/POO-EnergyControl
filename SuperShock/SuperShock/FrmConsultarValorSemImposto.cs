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
    public partial class FrmConsultarValorSemImposto : Form
    {
        public FrmConsultarValorSemImposto()
        {
            InitializeComponent();
        }

        private void btnSemImposto_Click(object sender, EventArgs e)
        {
            GerenciadorDeContas gerenciador = new GerenciadorDeContas();

            string identificadorConsultaValorSemImposto = txtCPFCNPJ.Text;

            double? valorSemImposto = gerenciador.ConsultarValorSemImposto(identificadorConsultaValorSemImposto);

            try
            {
                if (string.IsNullOrEmpty(txtCPFCNPJ.Text))
                {
                    MessageBox.Show("CPF/CNPJ não pode ser vazio. Por favor, preencha o campo para prosseguir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCPFCNPJ.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (valorSemImposto.HasValue)
            {
                txtSemImposto.Text = ($"Valor total da conta sem imposto: R$ {txtSemImposto:F2}.");
            }
            else
            {
                txtSemImposto.Text = ("Não há valores para este CPF/CNPJ");
            }

            txtSemImposto.Visible = true;
        }
    }
}
