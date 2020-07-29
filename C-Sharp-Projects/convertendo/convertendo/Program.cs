using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convertendo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string nomeh, idadeh, salarioh, nomem, idadem, salariom;

            Console.Write("Digite o nome dele: ");
            nomeh = Console.ReadLine();
            Console.Write("Quanto o " +nomeh + " ganha?");
            salarioh = Console.ReadLine();
            Console.Write("Qual a idade do " + nomeh +" ?");
            idadeh = Console.ReadLine();

            Console.Write("Digite o nome dela: ");
            nomem = Console.ReadLine();
            Console.Write("Quanto a " + nomem + " ganha?");
            salariom = Console.ReadLine();
            Console.Write("Qual a idade da " + nomem + " ?");
            idadem = Console.ReadLine();

            double somasalario = Convert.ToDouble(salarioh) + Convert.ToDouble(salariom);
            int somaidade = Convert.ToInt16(idadeh) + Convert.ToInt16(idadem);

            Console.WriteLine("A soma dos 2 salarios é: " + somasalario.ToString());
            Console.WriteLine("A soma das idades é: " + somaidade.ToString());
            


            Console.ReadKey();
        }
    }
}
