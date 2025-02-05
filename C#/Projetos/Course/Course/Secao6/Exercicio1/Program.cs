using System;

namespace Course.Secao6.Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[10];

            Console.Write("Quantos quartos vao ser reservados?");
            int quantidadeQuartos = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidadeQuartos; i++)
            {
                Console.WriteLine($"Reserva{i}");
                Console.Write("Quarto ");
                int quarto = int.Parse(Console.ReadLine());

                Console.Write("Email ");
                string nome = Console.ReadLine();

                Console.Write("Email ");
                string email = Console.ReadLine();

                alunos[quarto] = new Aluno{Nome = nome, Email = email, NumeroQuarto = quarto };
            }
            if (alunos.Length > 0)
            {
                Console.WriteLine("RESERVAS JA FEITAS");
                
                for (int i = 0;i < alunos.Length;i++)
                {
                    if (alunos[i] != null)
                    {
                        alunos.ToString();
                    }
                }
            }
            else
            {
                Console.WriteLine("Não há reservas feitas!");
            }

        }

    }
}
