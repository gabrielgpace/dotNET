using System;


namespace Course.Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.Write("Nome: ");
            f1.nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionario: ");
            Console.Write("Nome: ");
            f2.nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.salario = double.Parse(Console.ReadLine());

            double mediaSalarios;
            mediaSalarios = (f1.salario + f2.salario) / 2;

            Console.WriteLine("Salario medio = " + mediaSalarios);
        }
    }
}
