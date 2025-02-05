

namespace Course.Secao6.Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //sintaxe foreach
            string[] vect = new string[] { "Maria", "Bob", "Alex" };

            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }
        } 
    }
}
