using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colecao_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> notas = new List<double>();
            notas.Add(8.5);
            notas.Add(7.2);
            notas.Add(6.8);
            notas.Add(9.2);
            Console.WriteLine(notas.Average());

            List<string> nomes = new List<string>();
            nomes.Add("Bruno");
            nomes.Add("Joao");
            nomes.Add("Maria");
            nomes.Add("Lais");
            Console.WriteLine(nomes.Count());

            Console.ReadKey();
        }
    }
}
