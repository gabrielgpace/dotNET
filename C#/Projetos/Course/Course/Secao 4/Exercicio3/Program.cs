using System;

namespace Course.Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto x = new Produto();

            int qtde;

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome");
            x.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            x.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            x.Quantidade = int.Parse(Console.ReadLine());


            Console.WriteLine("Dados do produto: " + x);

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            qtde = int.Parse(Console.ReadLine());

            x.AdicionarProdutos(qtde);

            Console.WriteLine("Digite o número de produtos a ser removidos do estoque: ");
            qtde = int.Parse(Console.ReadLine());

            x.RemoverProdutos(qtde);
        }
    }
}
