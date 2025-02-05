using System;


namespace Course.Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();
            Console.WriteLine("Entre com a largura e altura do retangulo: ");
            Console.Write("Altura: ");
            ret.Altura = double.Parse(Console.ReadLine());
            Console.Write("Largura: ");
            ret.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine($"Area: {ret.Area()} \nPerimetro: {ret.Perimetro()} \nDiagonal: {ret.Diagonal()}");
        }
    }
}
