using System.Globalization;

namespace Exercicio_04
{
     class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }

        public Double Saldo { get; private set; }


        //declaração do medoto consrutor
        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        // Declaração do metodo de sobrecarga
        public ContaBancaria( int numero, string titular, double saldo): this (numero, titular)  
        {
            Saldo = saldo;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta: "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
