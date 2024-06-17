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
    public partial class FrmConsultarConsumo : Form
    {
        public FrmConsultarConsumo()
        {
            InitializeComponent();
        }

        private void btnConsultarConsumo_Click(object sender, EventArgs e)
        {
            GerenciadorDeContas gerenciador = new GerenciadorDeContas();

            string identificadorConsultaConsumo = txtCPFCNPJConsumo.Text;

            double? consumo = gerenciador.ConsultarConsumo(identificadorConsultaConsumo);


            try
            {
                if (string.IsNullOrEmpty(txtCPFCNPJConsumo.Text))
                {
                    MessageBox.Show("CPF/CNPJ não pode ser vazio. Por favor, preencha o campo para prosseguir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCPFCNPJConsumo.Focus();
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (consumo.HasValue)
            {
                txtConsumo.Text = ($"Consumo no último mês: {consumo} kW/h");
            }
            else
            {
                txtConsumo.Text = ("Não há consumo para este CPF/CNPJ");
            }

            txtConsumo.Visible = true;
        }

        private void FrmConsultarConsumo_Load(object sender, EventArgs e)
        {

        }

        private void lblCPFCNPJ_Click(object sender, EventArgs e)
        {

        }
    }
}
