using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada_com_laco_repeticao_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            for(int i=0; i<11; i++)
            {
                Console.WriteLine(num + " x " +i + " = " + (num * i));
            }

            Console.ReadKey();
            
        }
    }
}
