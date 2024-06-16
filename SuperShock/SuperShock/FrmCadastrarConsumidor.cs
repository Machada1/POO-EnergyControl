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
            string identificador = txtCPF.Text;
            string tipo = txtTipoConsumidor.Text;
            Pessoa consumidor = tipo == "1" ? new PessoaFisica(nome, identificador) : new PessoaJuridica(nome, identificador);
            gerenciador.CadastrarConsumidor(consumidor);

            
            MessageBox.Show("Cadastro realizado com sucesso!");

            txtNomeConsumidor.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtTipoConsumidor.Text = string.Empty;

        }

        private void FrmCadastrarConsumidor_Load(object sender, EventArgs e)
        {

        }
    }
}
