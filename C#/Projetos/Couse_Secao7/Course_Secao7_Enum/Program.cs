using Course_Secao7_Enum.Entities;
using Course_Secao7_Enum.Entities.Enums;
using System;

namespace Course_Secao7_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //CONVERSAO DE ENUMERADO PARA STRING
            string txt = OrderStatus.PendingPayment.ToString();

            //CONVERSAO DE STRING PARA ENUMERADO
            OrderStatus os = Enum.Parse<OrderStatus> ("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}