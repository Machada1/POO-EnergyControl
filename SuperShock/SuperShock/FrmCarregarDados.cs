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
    public partial class FrmCarregarDados : Form
    {
        public FrmCarregarDados()
        {
            InitializeComponent();
        }

        private void btnCarregarDados_Click(object sender, EventArgs e)
        {
            GerenciadorDeContas gerenciador = new GerenciadorDeContas();
            
            string arquivoCarregar = txtNomeArquivo.Text;
            gerenciador.CarregarDados(arquivoCarregar);

            MessageBox.Show("Dados carregados com sucesso.");

        }
    }
}
