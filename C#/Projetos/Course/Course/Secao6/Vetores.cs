using System;

namespace Course.Secao6
{
    class Vetores
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine());
            }

            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum =+ vect[i];
            }
        }
    }
}
