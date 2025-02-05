using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Secao6.Matriz
{
    class Matriz
    {
        static void Main(string[] args)
        {
            //DECLARACAO DE MATRIZ
            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length); //6 -> quantidade de elementos totais que a matriz tem

            Console.WriteLine(mat.Rank); //2 -> quantidade de linhas que a matriz tem

            Console.WriteLine(mat.GetLength(0)); // 2 -> quantidade de linhas que a matriz tem porque o argumento é 0

            Console.WriteLine(mat.GetLength(1)); // 3 -> quantidade de colunas que a matriz tem porque o arguemento é 1
        }
    }
}
