
namespace Course.Secao5.ExercicioFixacao
{
    class Conta
    {
        ///ATRIBUTOS
        public int NumeroConta { get; private set; }
        private string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        //CONSTRUTOR
        public Conta(int numeroConta, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
        }

        public Conta(int numeroConta, string nomeTitular, double saldo) : this(numeroConta, nomeTitular)
        {
            Saldo = saldo;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor + 5;
        }

        public void Depositar(double valor)
        {
            Saldo = + valor;
        }

        public override string ToString()
        {
            return "Conta: "
                + NumeroConta
                + ", Titular: "
                + NomeTitular
                + ", Saldo: "
                + Saldo;
        }
    }
}
