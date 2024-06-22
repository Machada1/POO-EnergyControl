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
    public partial class FrmSalvarDados : Form
    {
        //private GerenciadorDeContas gerenciador;

        public FrmSalvarDados()
        {
            InitializeComponent();
            //this.gerenciador = gerenciador;
        }

        private void btnSalvarDados_Click(object sender, EventArgs e)
        {
            GerenciadorDeContas gerenciador = new GerenciadorDeContas();
            string arquivoSalvar = txtNomeArquivo.Text;
            gerenciador.SalvarDados(arquivoSalvar);

            MessageBox.Show("Dados salvos com sucesso");
        }

        private void lblNomeArquivo_Click(object sender, EventArgs e)
        {

        }
    }
}
