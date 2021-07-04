using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroBancario {
    class ContaBancaria {
        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }
        
        public ContaBancaria(int numeroconta, string titular) {
            NumeroConta = numeroconta;
            Titular = titular;
        }

        public ContaBancaria(int numeroconta, string titular, double depositoInicial) : this(numeroconta, titular) {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public void Saque(double saque) {
            Saldo -= saque + 5.0;
        }

        public override string ToString() {
            return $"Conta: {NumeroConta}, Titular: {Titular}, Saldo: ${Saldo.ToString("F2")}";
        }
    }
}
