namespace DocesForms_B
{
    class Pedido
    {

        //PROPRIEDADES (ATRIBUTOS)

        public string NomeDoce { get; set; }
        public double PrecoUnitario { get; set; }

        public int Quantidade { get; set; }

        public int IdadeCliente { get; set; }

        //MÉTODOS (AÇÕES)

        public double CalcularDesconto()
        {
            double valorTotal = PrecoUnitario * Quantidade;
            if(Quantidade >= 10)
            {
                return valorTotal * 0.10; // 10% de desconto
            }
            return 0.0; // sem desconto
        }
    }
}
