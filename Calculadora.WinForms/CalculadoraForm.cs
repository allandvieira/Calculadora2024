namespace Calculadora.WinForms
{
    public partial class CalculadoraForm : Form
    {
        public CalculadoraForm()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal primeiroNumero = Convert.ToDecimal(txtPrimeiroNumero.Text);
            decimal segundoNumero = Convert.ToDecimal(txtSegundoNumero.Text);
            decimal resultado = 0;
            string descricaoOperacao = "";

            if (rdbAdicao.Checked == false && rdbSubtracao.Checked == false && rdbMultiplicacao.Checked == false && rdbDivisao.Checked == false)
            {
                MessageBox.Show("Selecione uma operação");
                return;
            }

            if (rdbAdicao.Checked)
            {
                resultado = primeiroNumero + segundoNumero;
                descricaoOperacao = primeiroNumero + " + " + segundoNumero + " = " + resultado;
            }

            else if (rdbSubtracao.Checked)
            {
                resultado = primeiroNumero - segundoNumero;
                descricaoOperacao = primeiroNumero + " - " + segundoNumero + " = " + resultado;
            }

            else if (rdbMultiplicacao.Checked)
            {
                resultado = primeiroNumero * segundoNumero;
                descricaoOperacao = primeiroNumero + " * " + segundoNumero + " = " + resultado;
            }

            else if (rdbDivisao.Checked)
            {
                resultado = primeiroNumero / segundoNumero;
                descricaoOperacao = primeiroNumero + " / " + segundoNumero + " = " + resultado;
            }

            lblResultado.Text = resultado.ToString();
            listHistoricoOperacoes.Items.Add(descricaoOperacao);
        }
    }
}
