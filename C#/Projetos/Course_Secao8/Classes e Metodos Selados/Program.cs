﻿using System;
using System.Threading.Channels;
using Sobreposicao.Properties;

namespace MetodosSelados
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Alex", 500);
            Account acc2 = new SavingAccount(1002, "Ana", 500, 0.01);
            
            acc1.Withdraw(10);
            acc2.Withdraw(10);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}

