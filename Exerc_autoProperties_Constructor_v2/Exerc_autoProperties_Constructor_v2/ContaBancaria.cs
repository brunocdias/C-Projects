using System.Globalization;


namespace Exerc_autoProperties_Constructor_v2
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }

        public double Saldo { get; private set; }

        public ContaBancaria() { }
        public ContaBancaria(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public ContaBancaria(int numero, string nome, double saldo) : this(numero, nome)
        {
            Saldo = saldo;
        }

        public void Depositar(double deposito)
        {
            Saldo += deposito;
        }

        public void Sacar(double saque)
        {
            Saldo -= saque + 5.00;
        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Nome
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture) ;
        }
    }
}
