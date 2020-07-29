using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interacao_conversao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string nome;

            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("O nome digitado foi: " +nome);
            */

            double num1, num2;
            Console.Write("Digite o primeiro valor: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            num2 = double.Parse(Console.ReadLine());

            double soma = num1 + num2;
            double multiplicacao = num1 * num2;
            double divisao = num1 / num2;
            double subtracao = num1 - num2;
            double media = soma / 2;

            Console.WriteLine("A soma de " + num1 + " e " + num2 + " = " + soma);
            Console.WriteLine("A multiplicação de " + num1 + " e " + num2 + " = " + multiplicacao);
            Console.WriteLine("A divisão de " + num1 + " e " + num2 + " = " + divisao);
            Console.WriteLine("A subtração de " + num1 + " e " + num2 + " = " + subtracao);
            Console.WriteLine("A media de " + num1 + " e " + num2 + " = " + media);

            Console.ReadKey();
        }
    }
}
