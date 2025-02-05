namespace Course.Secao3
{
    class TrianguloConta
    {
        static void Main(string[] args)
        {
            problemaComPoo x, y;

            x = new problemaComPoo();
            y = new problemaComPoo();

            Console.WriteLine("Entre com as medidas do triangulo X");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triangulo Y");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double p = (x.A + x.B + x.C) / 2;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Area de X = " + areaX.ToString("F4"));
            Console.WriteLine("Area de Y = " + areaY.ToString("F4"));

            if (areaX > areaY)
                Console.WriteLine("Maior área: X");
            else
                Console.WriteLine("Maior área: Y");
        }
    }
}
