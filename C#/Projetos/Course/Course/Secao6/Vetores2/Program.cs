using System;


namespace Course.Secao6.Vetores2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                vect[i] = new Product { Name = name, Price = price };
            }

            double soma = 0;
            for (int i = 0; i < n; i++)
            {
                soma += vect[i].Price;
            }

            double avg = soma / n;
            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2"));
        }
    }
}
