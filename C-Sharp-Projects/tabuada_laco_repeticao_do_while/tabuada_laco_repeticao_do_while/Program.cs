using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada_laco_repeticao_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i = 0;
            Console.Write("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine(num + " x " + i + " = " + (num * i));
                i++;
            } while (i < 11);

                Console.ReadKey();
        }
    }
}
