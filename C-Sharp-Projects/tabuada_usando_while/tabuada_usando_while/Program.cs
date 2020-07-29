using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada_usando_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i=0;
            Console.Write("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            while(i < 11)
            {
                Console.WriteLine(num + " x " + i + " = " + (num * i));
                i++;
            } 

            Console.ReadKey();
        }
    }
}
