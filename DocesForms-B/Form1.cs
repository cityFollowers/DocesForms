namespace DocesForms_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // INSTÂNCIA OBJETO DA CLASSE PEDIDO
                Pedido pedido = new Pedido();

                pedido.NomeDoce = txtNome.Text;
                pedido.PrecoUnitario = Convert.ToDouble(txtPrecoUnitario.Text);
                pedido.Quantidade = int.Parse(txtQuantidade.Text);
                pedido.IdadeCliente = int.Parse(txtIdadeCliente.Text);

                // CHAMANDO OS MÉTODOS
                double desconto = pedido.CalcularDesconto();

                // EXIBIR NA TELA
                lblDesconto.Text = $"R$ {desconto:N2}";
                lblDesconto.ForeColor = Color.Blue;
            }
            catch(FormatException)
            {
                MessageBox.Show("Favor, preencher os campos", "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
