using System.Globalization;
namespace Course.Secao5.SobreCarga
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //CONSTRUTOR COM PARAMETROS
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //
        public Produto(string nome, double preco) 
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0; //Por padrao o valor é zero, se nao colocar algum valor
        }


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}