using System;
using System.Security.Cryptography.X509Certificates;

namespace desafio1
{
    class Ejercicio
    {
        abstract public class cuentaBancaria
        {
            private double saldo;
            private List<string> historial = new List<string>();

            public double Saldo
            {
                get { return saldo; }
                set { saldo = value; }
            }

            public List<string> Historial
            {
                get { return historial; }
                set { historial = value; }
            }

            public cuentaBancaria(double saldoInicial)
            {
                if (saldoInicial < 0)
                {
                    Console.WriteLine("El saldo inicial no puede ser negativo");
                    Saldo = 0;
                }
                else
                {
                    Saldo = saldoInicial;
                }
                Historial.Add("Cuenta bancaria con: $" + Saldo);
            }

            public void depositar(double monto)
            {
                if (monto > 0)
                {
                    saldo += monto;
                    Historial.Add("Deposito: " + monto + " Saldo: " + Saldo);
                    Console.WriteLine("Depositaste: " + monto);
                }
            }

            public void retirar(double monto)
            {
                if (monto > 0 && Saldo >= monto)
                {
                    Saldo -= monto;
                    Historial.Add("Retiro: " + monto + "Saldo total: " + Saldo);
                    Console.WriteLine("Retiraste: " + monto);
                }
                else
                {
                    Console.WriteLine("Supera el saldo de la cuenta");
                }
            }

            public abstract void interesMensual();

            public class cuentaAhorro : cuentaBancaria
            {
                public cuentaAhorro(double saldoInicial) : base(saldoInicial) { }
                public override void interesMensual()
                {
                    double interes = saldo * 0.03;
                    depositar(interes);
                    Console.WriteLine("Se aplico el interes");
                }
            }

            public class cuentaCorriente : cuentaBancaria
            {
                public cuentaCorriente(double saldoInicial) : base(saldoInicial) { }

                public override void interesMensual()
                {
                    Console.WriteLine("Sin intereses este mes");
                }
            }
        }

        static void Main(string[] args)
        {
        }
    }
}