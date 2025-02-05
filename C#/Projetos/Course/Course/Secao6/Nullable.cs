using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Course.Secao6
{
    class Nullable
    {
        static void Main(string[] args)
        {

            //DECLARACAO PADRAO
            Nullable<double> value = null;

            //? -> significa opcional
            double? value2 = null;
            double? value3 = 10;

            Console.WriteLine(value2.GetValueOrDefault()); //0
            Console.WriteLine(value3.GetValueOrDefault()); //10

            Console.WriteLine(value2.HasValue); //False
            Console.WriteLine(value3.HasValue); //True

            Console.WriteLine(value2.Value); // erro com tratamento de excecao
            Console.WriteLine(value3.Value); // 10

            if (value2.HasValue) 
                Console.WriteLine(value2.Value);
            else 
                Console.WriteLine("Is null");

            if (value3.HasValue)
                Console.WriteLine(value3.Value);
            else
                Console.WriteLine("Is null");


            //OPERADOR DE COALESCENCIA NULA ??

            double? x = null;
            double? y = 10;

            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a); // 5, porque o valor é nulo
            Console.WriteLine(b); // 10, porque o valor nao é nulo

        }


        
    }
}
