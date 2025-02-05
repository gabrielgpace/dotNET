using System;


namespace Course.Secao3
{
    class problemaSemPoo
    {
        static void Main(string[] args)
        {
            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triangulo X");
            xA = double.Parse(Console.ReadLine());
            xB = double.Parse(Console.ReadLine());
            xC = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triangulo Y");
            yA = double.Parse(Console.ReadLine());
            yB = double.Parse(Console.ReadLine());
            yC = double.Parse(Console.ReadLine());

            double p = (xA + xB + xC) / 2;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("Area de X = " + areaX.ToString("F4"));
            Console.WriteLine("Area de Y = " + areaY.ToString("F4"));

            if (areaX > areaY)
                Console.WriteLine("Maior área: X");
            else
                Console.WriteLine("Maior área: Y");
        }
    }
}
