using ExercicioHerancaPolimorfismo.Entities;

namespace ExercicioHerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> produtos = new List<Product>();
            
            Console.Write("Enter the number of products");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter the product " + i + ": ");
                Console.WriteLine("Common, used or imported (c/u/i)");
                char p = char.Parse(Console.ReadLine());
                
                Console.Write("Name: ");
                string name = Console.ReadLine();
                
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                
                if (p == 'c')
                {
                    produtos.Add(new Product(name, price));
                }
                else if (p == 'u')
                {
                    Console.Write("Manufacture date (dd/MM/yyyy): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    produtos.Add(new UsedProduct(name, price, date));
                }
                else if (p == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customFee = double.Parse(Console.ReadLine());
                    produtos.Add(new ImportedProduct(name, price, customFee));
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }

            Console.WriteLine("PRICE TAGS");
            foreach (Product p in produtos)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}