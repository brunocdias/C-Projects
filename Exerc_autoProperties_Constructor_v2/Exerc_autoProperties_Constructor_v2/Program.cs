using System;
using System.Globalization;

namespace Exerc_autoProperties_Constructor_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int numero = Int32.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char aux = char.Parse(Console.ReadLine());
            if (aux == 's' || aux == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, nome, depositoInicial);
            }
            else
                conta = new ContaBancaria(numero, nome);
            
            Console.WriteLine();

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(deposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();

            Console.WriteLine("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Sacar(saque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);


        }
    }
}
