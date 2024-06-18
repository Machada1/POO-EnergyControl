namespace SuperShock
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            //GerenciadorDeContas gerenciador = new GerenciadorDeContas();
        }

        private void btnCadastrarConsumidor_Click(object sender, EventArgs e)
        {
            FrmCadastrarConsumidor frmCadastrarConsumidor = new FrmCadastrarConsumidor();
            frmCadastrarConsumidor.ShowDialog();
        }

        private void btnCadastrarConta_Click(object sender, EventArgs e)
        {
            FrmCadastrarConta frmCadastrarConta = new FrmCadastrarConta();
            frmCadastrarConta.ShowDialog();
        }

        private void btnConsultarConsumo_Click(object sender, EventArgs e)
        {
            FrmConsultarConsumo frmConsultConsumo = new FrmConsultarConsumo();
            frmConsultConsumo.ShowDialog();
        }

        private void btnConsultarValorTotal_Click(object sender, EventArgs e)
        {
            FrmConsultarValorTotal frmConsultarValorTotal = new FrmConsultarValorTotal();
            frmConsultarValorTotal.ShowDialog();
        }

        private void btnConsultarValorSemImposto_Click(object sender, EventArgs e)
        {
            FrmConsultarValorSemImposto frmConsultarValorSemImposto = new FrmConsultarValorSemImposto();
            frmConsultarValorSemImposto.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvarDados_Click(object sender, EventArgs e)
        {
            FrmSalvarDados frmSalvarDados = new FrmSalvarDados();
            frmSalvarDados.ShowDialog();
            //GerenciadorDeContas gerenciador;
        }

        private void btnCarregarDados_Click(object sender, EventArgs e)
        {
            FrmCarregarDados frmCarregarDados = new FrmCarregarDados();
            frmCarregarDados.ShowDialog();
        }
    }
}
