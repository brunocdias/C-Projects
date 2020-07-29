using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            //uso de variáveis
            int idade = 23;
            String nome = "Bruno";
            bool alto = true;
            double altura = 1.83;

            Console.WriteLine("Nome " + nome);
            Console.WriteLine("Idade " + idade);
            Console.WriteLine("Alto " + alto);
            Console.WriteLine("Altura " + altura);

            Console.ReadKey();

        }
    }
}
