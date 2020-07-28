using System;

namespace Exerc_Vetores_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Quarto[] quartos = new Quarto[10];

            Console.Write("Quantos quartos serão alugados? ");
            int qtd = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Aluguel #{0}: ", i + 1);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = Int32.Parse(Console.ReadLine());

                quartos[quarto] = new Quarto(nome, email, quarto);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if(quartos[i] != null)
                {
                    Console.WriteLine(quartos[i].ToString());
                }
            }
        }
    }
}
