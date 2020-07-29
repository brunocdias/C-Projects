using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicional_if_mes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Digite o mês de 1 a 12: ");
            a = int.Parse(Console.ReadLine());
            if (a == 1)
                Console.WriteLine("Janeiro");
            else if (a == 2)
                Console.WriteLine("Fevereiro");
            else if (a == 3)
                Console.WriteLine("Março");
            else if (a == 4)
                Console.WriteLine("Abril");
            else if (a == 5)
                Console.WriteLine("Maio");
            else if (a == 6)
                Console.WriteLine("Junho");
            else if (a == 7)
                Console.WriteLine("Julho");
            else if (a == 8)
                Console.WriteLine("Agosto");
            else if (a == 9)
                Console.WriteLine("Setembro");
            else if (a == 10)
                Console.WriteLine("Outubro");
            else if (a == 11)
                Console.WriteLine("Novembro");
            else if (a == 12)
                Console.WriteLine("Dezembro");
            else
                Console.WriteLine("O mes nao existe");

            Console.ReadKey();

        }
    }
}
