using System;

namespace Course.Secao3
{
    class entradaDeDados
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na suia casa?");
            int quantidadeQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double precoProduto = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre seu último nome, idade e altura na mesma linha:");
            string[] vetorDados = Console.ReadLine().Split(' ');

            string ultimoNome = vetorDados[0];
            int idade = int.Parse(vetorDados[1]);
            double altura = double.Parse(vetorDados[2]);
            Console.WriteLine($"{ultimoNome}, {idade}, {altura}");
        }
    }
}
