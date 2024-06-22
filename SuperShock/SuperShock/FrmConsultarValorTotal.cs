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
    public partial class FrmConsultarValorTotal : Form
    {
        public FrmConsultarValorTotal()
        {
            InitializeComponent();
        }

        private void btnValorTotal_Click(object sender, EventArgs e)
        {
            GerenciadorDeContas gerenciador = new GerenciadorDeContas();

            string identificadorConsultaValorTotal = txtCPFCNPJ.Text;

            double? valorTotal = gerenciador.ConsultarValorTotal(identificadorConsultaValorTotal);
            
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

            if (valorTotal.HasValue)
            {
                txtValorTotal.Text = ($"Valor total da conta: R$ {valorTotal:F2}.");
            }
            else
            {
                txtValorTotal.Text = ("Não há valores para este CPF/CNPJ");
            }

            txtValorTotal.Visible = true;
        }
    }
}
