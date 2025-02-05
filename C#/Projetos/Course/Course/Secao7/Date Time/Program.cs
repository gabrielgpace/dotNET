using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Secao7.Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONSTRUTORES
            DateTime d1 = new DateTime(2000, 8, 15);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            //PARSE
            DateTime d4 = DateTime.Parse("2000-08-15");
            DateTime d5 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d6 = DateTime.Parse("15/08/2000");
            DateTime d7 = DateTime.Parse("15/08/2000 13:05:58");
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);

        }
    }
}
