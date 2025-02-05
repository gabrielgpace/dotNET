using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Secao6.Params
{
    internal class Calculator
    {
        //maneira ruim - tem a funcao sum com 2 sobrecarga
        /*
        public static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }
        public static int Sum(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }
        public static int Sum(int n1, int n2, int n3, int n4)
        {
            return n1 + n2 + n3 + n4;
        }
        */

        //melhor forma é utilizar vetor
        //a definicao params facilita para colocar parametros
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
