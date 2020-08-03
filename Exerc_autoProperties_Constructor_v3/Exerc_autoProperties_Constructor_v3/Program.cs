using System;

namespace Exerc_autoProperties_Constructor_v3
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria cb ;
            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Havera deposito inicial (s/n); ");
            char dep = char.Parse(Console.ReadLine());
            if (dep == 's' || dep == 'S')
            {
                Console.Write("Entre o valor de deposito inicial: ");
                double deposito1 = double.Parse(Console.ReadLine());
                cb = new ContaBancaria(nome, numero, deposito1);
            }
            else
            {
                cb = new ContaBancaria(nome, numero);
            }

            Console.WriteLine();

            Console.WriteLine("Dados da conta bancaria:");
            Console.WriteLine(cb.ToString());

            Console.WriteLine();
            Console.Write("Entre um valor para deposito: ");
            double deposito = double.Parse(Console.ReadLine());
            cb.Depositar(deposito);
            Console.WriteLine(cb.ToString());

            Console.WriteLine();
            Console.WriteLine("Entre um valor para saque");
            double saque = double.Parse(Console.ReadLine());
            cb.Sacar(saque);
            Console.WriteLine(cb.ToString());




        }
    }
}
