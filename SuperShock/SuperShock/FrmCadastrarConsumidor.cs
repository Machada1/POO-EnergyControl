using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SuperShock
{
    public partial class FrmCadastrarConsumidor : Form
    {
        public FrmCadastrarConsumidor()
        {
            InitializeComponent();

        }

        private void btnCadastrarConsumidor_Click(object sender, EventArgs e)
        {

            GerenciadorDeContas gerenciador = new GerenciadorDeContas();

            string nome = txtNomeConsumidor.Text;
            string identificador = txtCPFCNPJ.Text;
            string tipo = txtTipoConsumidor.Text;
            Pessoa consumidor = tipo == "1" ? new PessoaFisica(nome, identificador) : new PessoaJuridica(nome, identificador);
            gerenciador.CadastrarConsumidor(consumidor);

            try
            {
                if (string.IsNullOrEmpty(txtNomeConsumidor.Text))
                {
                    MessageBox.Show("Nome do Cliente não pode ser vazio. Por favor, preencha o campo para prosseguir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNomeConsumidor.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtCPFCNPJ.Text))
                {
                    MessageBox.Show("CPF não pode ser vazio. Por favor, preencha o campo para prosseguir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCPFCNPJ.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtTipoConsumidor.Text))
                {
                    MessageBox.Show("Tipo de consumidor não pode ser vazio. Por favor, preencha o campo para prosseguir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTipoConsumidor.Focus();
                    return;
                }

                else
                {
                    // Continuação do processo de cadastro
                    MessageBox.Show("Cadastro finalizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //MessageBox.Show("Cadastro realizado com sucesso!");

            txtNomeConsumidor.Text = string.Empty;
            txtCPFCNPJ.Text = string.Empty;
            txtTipoConsumidor.Text = string.Empty;

        }

        private void FrmCadastrarConsumidor_Load(object sender, EventArgs e)
        {

        }

        private void lblTipo_Click(object sender, EventArgs e)
        {

        }
    }
}
