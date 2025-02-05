using System;
using System.Collections.Generic;
using ExercicioResolvido.Entities;

namespace ExercicioResolvido
{
 class MyClass
 {
  static void Main(string[] args)
  {
   List<Employee> employees = new List<Employee>();
   
   Console.Write("Enter a number of employees: ");
   int n = int.Parse(Console.ReadLine());

   for (int i = 1; i <= n; i++)
   {
    Console.WriteLine("Employee #" + i + " data:");
    
    Console.WriteLine("Outsorced (y/n)?");
    char ch = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();
    
    Console.Write("Hours: ");
    int hours = int.Parse(Console.ReadLine());
    
    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine());
    
    
    
    if (ch != 'n')
    {
     Console.WriteLine("Additional charge: ");
     double additionCharge = double.Parse(Console.ReadLine());
     
     employees.Add(new OutsorcedEmployee(name, hours, valuePerHour, additionCharge));
    }
    else
    {
     employees.Add(new Employee(name, hours, valuePerHour));
    }
   }

   Console.WriteLine("PAYMENTS: ");
   foreach (Employee employee in employees)
   {
    Console.WriteLine(employee.ToString());
   }
   
  }
 }
}