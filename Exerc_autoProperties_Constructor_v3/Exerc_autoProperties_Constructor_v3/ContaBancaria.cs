using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exerc_autoProperties_Constructor_v3
{
    class ContaBancaria
    {
        public string Nome { get; set; }
        public int Conta { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria()
        {
        }

        public ContaBancaria(string nome, int conta)
        {
            Nome = nome;
            Conta = conta;
        }

        public ContaBancaria(string nome, int conta, double deposito) : this (nome, conta)
        {
            Saldo = deposito;
        }

        public void Depositar(double deposito)
        {
            Saldo += deposito;
        }

        public void Sacar(double saque)
        {
            Saldo -= saque + 5.0;
        }

        public override string ToString()
        {
            return Nome
                + ", "
                + Conta 
                + ", "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture) ;
        }
    }
}
