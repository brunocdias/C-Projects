using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_simples_uma_dimensao
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[3];
            nome[0] = "Bruno ";
            nome[1] = "Cesar ";
            nome[2] = "Dias";

            Console.WriteLine(nome[0] + nome[1] + nome[2]);
            Console.WriteLine(String.Concat(nome));
            Console.WriteLine("Tamanho da array: " + nome.Length.ToString());
            Console.ReadKey();

        }
    }
}
