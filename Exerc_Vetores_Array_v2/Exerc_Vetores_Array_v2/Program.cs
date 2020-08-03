using System;

namespace Exerc_Vetores_Array_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Quantos estudantes irao alugar? ");
            int n = int.Parse(Console.ReadLine());
            Estudante[] estudante = new Estudante[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Digite o quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                estudante[quarto] = new Estudante(nome, email);
                
            }

            for(int i = 1; i <= 9; i++)
            {
                if (estudante[i] != null)
                {
                    Console.WriteLine(estudante[i].ToString() + "Numero: " + i);
                }
            }
            
        }
    }
}
