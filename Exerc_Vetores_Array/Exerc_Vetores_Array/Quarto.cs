using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_Vetores_Array
{
    class Quarto
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public Quarto()
        {
        }

        public Quarto(string nome, string email, int numero)
        {
            Numero = numero;
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Numero
                + ": "
                + Nome
                + ", "
                + Email;
        }
    }
}
