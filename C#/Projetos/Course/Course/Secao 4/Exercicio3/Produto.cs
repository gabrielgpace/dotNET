namespace Course.Exercicio3
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return Nome 
                + ", $ " 
                + Preco.ToString("F2") 
                + ", "
                + Quantidade
                + " unidades, Total: " 
                + ValorTotalEmEstoque();
        }

        public void AdicionarProdutos(int quantity)
        {
            Quantidade += quantity;
            Console.WriteLine($"Dados atualizados: {Nome}, $ {Preco}, {Quantidade}, Total: ${Preco * Quantidade}");
        }

        public void RemoverProdutos(int quantity)
        {
            
            Quantidade -= quantity;
            Console.WriteLine($"Dados atualizados: {Nome}, $ {Preco}, {Quantidade}, Total: ${Preco * Quantidade}");
            
        }
    }
}
