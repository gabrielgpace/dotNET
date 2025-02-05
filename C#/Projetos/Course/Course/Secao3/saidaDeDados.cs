using System;
using System.Globalization;

namespace Course.Secao3
{
    class saidaDeDados
    {

        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Computador";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.34567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preco é {preco1}");
            Console.WriteLine($"{produto2}, cujo preco é {preco2}");

            Console.WriteLine($"\nRegistro: {idade} anos de idade, código {codigo} e gênero: {genero}\n");

            Console.WriteLine($"Medida com oito casas decimais: {medida.ToString("F8")}");
            Console.WriteLine($"Medida com duas casas decimais: {medida.ToString("F2")}");
            Console.WriteLine($"Medida com duas casas decimais, separado por virgula: {medida.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}