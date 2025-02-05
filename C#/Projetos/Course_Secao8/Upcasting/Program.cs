using System.Diagnostics;
using Upcasting.Properties;

namespace Upcasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0);
            BusinesAccount bacc = new BusinesAccount(1002, "Maria", 0, 500);
            
            //UPCASTING
            
            Account acc1 = bacc;
            Account acc2 = new BusinesAccount(1003, "Julio", 10, 400);
            Account acc3 = new SavingsAccount(1004, "Anna", 0, 0.01);
            
            //DOWNCASTING

            BusinesAccount acc4 = (BusinesAccount)acc2;
            acc4.Loan(400);

            //acc2.Loan(100); -> vai dar erro porque a variavel acc2 é do tipo account
            
            BusinesAccount acc5 = (BusinesAccount)acc3;
            

        }
    }
}

