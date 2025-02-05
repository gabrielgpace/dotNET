using System.Globalization;
using System;

namespace Course.Secao5.AutoProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Tv", 500, 10);

            p.Nome = "T";
            Console.WriteLine(p.ToString());
            
        }
    }
}

