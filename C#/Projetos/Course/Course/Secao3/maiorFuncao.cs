using System;


namespace Course.Secao3
{
    class maiorFuncao
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite tres numeros: ");
            int n1 = int.Parse(Console.ReadLine() ?? "0");
            int n2 = int.Parse(Console.ReadLine() ?? "0");
            int n3 = int.Parse(Console.ReadLine() ?? "0");

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine(resultado);
        }
        static int Maior(int x, int y, int z)
        {
            int maior;
            if (x > y && x > z)
                maior = x;
            if (y > z)
                maior = y;
            else
                maior = z;
            return maior;
        }
    }
}
