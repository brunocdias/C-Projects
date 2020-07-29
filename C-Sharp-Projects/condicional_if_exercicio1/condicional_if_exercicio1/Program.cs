using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicional_if_exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crie duas variaveis (A e B) e leia um valor para cada uma. Disponibilize de forma crescente
            int a, b;

            Console.Write("Digite o valor de A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());

            if (a < b)
                Console.WriteLine(a + " " + b);
            else
                Console.WriteLine(b + " " + a);

            Console.ReadKey();

        }
    }
}
