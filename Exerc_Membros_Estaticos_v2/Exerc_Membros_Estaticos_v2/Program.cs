using System;
using System.Globalization;

namespace Exerc_Membros_Estaticos_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a cotacao do dolar: ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos dolares voce vai comprar? ");
            double valor = double.Parse(Console.ReadLine());

            double resultado = ConversonDeMoeda.Calcular(valor, cotacao);

            Console.WriteLine(resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
