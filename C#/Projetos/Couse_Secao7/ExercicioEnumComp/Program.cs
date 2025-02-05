using ExercicioEnumComp.Entities;
using ExercicioEnumComp.Entities.Enums;

namespace ExercicioEnumComp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Nome:");
            string nome = Console.ReadLine();

            Console.Write("Email:");
            string email = Console.ReadLine();

            Console.Write(" Birthdate (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());


            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(nome, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.WriteLine("How many items to this order?");
            int itemQuantity = int.Parse(Console.ReadLine());

            for(int i = 0; i < itemQuantity; i++)
            {
                Console.WriteLine($"Enter #{itemQuantity} data");

                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(productPrice, productQuantity, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY");
            Console.WriteLine(order);

        }

    }
}