
using System;

namespace Exercicio_Classe_Static
{
    class ConversorDeMoeda
    {
        public static double iof = 6.0;
        public static double Converter(double cotacao, double qtd)
        {
            double valor =  cotacao * qtd;
            double aux = valor * iof / 100;
            return valor + aux;
        }
    }
}
