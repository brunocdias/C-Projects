using System;
using System.Globalization;

namespace Exerc_autoProperties_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria cb;
            double deposito2, saque;

            Console.Write("Entre com o numero da conta: ");
            int numero = Int32.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n) ? ");
            char dep = char.Parse(Console.ReadLine());
            if (dep == 's' || dep == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cb = new ContaBancaria(numero, titular, deposito);
            }
            else
                cb = new ContaBancaria(numero, titular);

            Console.WriteLine("Dados da conta: {0} ", cb);

            Console.WriteLine();

            Console.WriteLine("Entre um valor para depósito: ");
            deposito2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb.Depositar(deposito2);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cb);

            Console.WriteLine("Entre um valor para saque: ");
            saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb.Sacar(saque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cb);
        }
    }
}
