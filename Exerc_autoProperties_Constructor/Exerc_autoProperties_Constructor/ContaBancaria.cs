using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_autoProperties_Constructor
{
    class ContaBancaria
    {
        public int Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }


        public ContaBancaria(int conta, string titular)
        {
            Conta = conta;
            Titular = titular;
        }

        public ContaBancaria(int conta, string titular, double deposito): this(conta, titular)
        {
            Depositar(deposito);
        }

        public override string ToString()
        {
            return "Conta " + Conta + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString();
        }

        public void Depositar(double deposito)
        {
            Saldo += deposito;
        }


        public void Sacar(double saque)
        {
            Saldo -= saque + 5.00;
        }
    }
}
