using System;
using System.Globalization;

namespace Exercicio_Classe_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a cotação do dolar: ");
            var cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) ;

            Console.Write("Quantos dolares voce quer comprar? ");
            var quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double valor = ConversorDeMoeda.Converter(cotacao, quantia);

            Console.WriteLine("Valor a ser pago em reais:  " + valor.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
