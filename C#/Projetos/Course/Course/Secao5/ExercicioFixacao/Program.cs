using System;


namespace Course.Secao5.ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroConta;
            string nome;
            char depositoInicial;


            Console.Write("Entre com o Numero da conta: ");
            numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o Nome do responsavel da conta: ");
            nome = Console.ReadLine();

            Console.Write("Havera deposito inicial? (s/n)");
            depositoInicial = char.Parse(Console.ReadLine());

            Conta conta = new Conta(numeroConta, nome);

            if (depositoInicial == 'n')
            {
                Console.WriteLine("Dados da conta: \n" + conta.ToString());

                Console.Write("Entre um valor para deposito: ");
                double valor = double.Parse(Console.ReadLine());
                conta.Depositar(valor);

                Console.WriteLine("Dados da conta: \n" + conta.ToString());

                Console.Write("Entre um valor para saque: ");
                valor = double.Parse(Console.ReadLine());
                conta.Depositar(valor);

                Console.WriteLine("Dados da conta: \n" + conta.ToString());
            }
            else
            {
                Console.Write("Entre um valor para deposito: ");
                double valor = double.Parse(Console.ReadLine());
                conta.Depositar(valor);

                Console.WriteLine("Dados da conta: \n" + conta.ToString());

                Console.Write("Entre um valor para saque: ");
                valor = double.Parse(Console.ReadLine());
                conta.Depositar(valor);

                Console.WriteLine("Dados da conta: \n" + conta.ToString());
            }

            

            

            
        }
    }
}
