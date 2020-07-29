using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada_simples
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine(num + " x 1 = " + (num * 1));
            Console.WriteLine(num + " x 2 = " + (num * 2));
            Console.WriteLine(num + " x 3 = " + (num * 3));
            Console.WriteLine(num + " x 4 = " + (num * 4));
            Console.WriteLine(num + " x 5 = " + (num * 5));
            Console.WriteLine(num + " x 6 = " + (num * 6));
            Console.WriteLine(num + " x 7 = " + (num * 7));
            Console.WriteLine(num + " x 8 = " + (num * 8));
            Console.WriteLine(num + " x 9 = " + (num * 9));
            Console.WriteLine(num + " x 10 = " + (num * 10));

            Console.ReadKey();
        }
    }
}
