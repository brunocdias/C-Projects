using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadores_relacionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Digite o valor de A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());

            if (a > b)
                Console.WriteLine("O " + a + " é o maior ");
            if (a == b)
                Console.WriteLine("Os dois são iguais");
            else if (a != b)
                Console.WriteLine("Os dois são diferentes");

               
            Console.ReadKey();
        }
    }
}
