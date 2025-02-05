using System;


namespace Course.Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Salario Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            funcionario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionario: " + funcionario.Nome + "R$" + funcionario.SalarioLiquido());

            Console.WriteLine("Digite a porcentagem para aumentar o salario");
            double porcentagem = double.Parse(Console.ReadLine());
            funcionario.AumentarSalario(porcentagem);

            

        }
    }
}
