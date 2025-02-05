
namespace Course.Secao6.ref_e_out
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);//30, se nao tivesse ref a, o resultado seria 10
        }

    }
}
