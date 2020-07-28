using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_Membros_Estaticos_v2
{
    class ConversonDeMoeda
    {
        static double iof = 6.0;
        
        public static double Calcular(double valor, double cotacao)
        {
            double aux  = cotacao * valor * iof / 100;
            return cotacao * valor + aux;
        }
    }
}
