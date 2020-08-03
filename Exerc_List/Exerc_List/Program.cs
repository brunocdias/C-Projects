using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exerc_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> employee = new List<Funcionario>();

            Console.Write("How many employees will be registered? ");
            int size = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= size; i++)
            {
                Console.WriteLine("Employee #{0}: ", i);
                Console.Write("Id: ");
                int id = Int32.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employee.Add(new Funcionario(id, name, salary));
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = Int32.Parse(Console.ReadLine());

            Funcionario fun = employee.Find(x => x.Id == searchId);
            if (fun != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                fun.IncreaseSalary(percentage);
            }
            else
                Console.WriteLine("Id does not exist!");

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Funcionario func in employee)
            {
                Console.WriteLine(func);
            }



        }
    }
}
