using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Fazer um programa para ler um numero inteiro N e uma matriz de ordem N contendo numeros inteiros. Em sequida mostrar a diagonal principal e a quantidade de valores negativos da matriz

namespace Course.Secao6.Matriz.Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int negativeNumbers = 0;
            int N = int.Parse(Console.ReadLine());
            
            int[,] mat = new int[N, N];

            for(int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    mat[i,j] = int.Parse(Console.ReadLine());
                    if(mat[i,j] < 0)
                    {
                        negativeNumbers++;
                    }
                }
            }
            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < N; i++) 
            {
                Console.WriteLine(mat[i,i] + "");

                Console.WriteLine("\n Number of negative numbers " + negativeNumbers);
            }
        }
    }
}
