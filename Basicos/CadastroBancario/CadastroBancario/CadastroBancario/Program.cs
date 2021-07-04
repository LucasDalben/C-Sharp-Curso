 using System;

namespace CadastroBancario {
    class Program {
        static void Main(string[] args) {

            ContaBancaria conta;

            Console.Write("Digite o número da Conta: ");
            int numeroconta = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá um depósito inicial (s/n)?");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S') {
                Console.Write("Digite o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numeroconta, titular, depositoInicial);
            }
            else {
                conta = new ContaBancaria(numeroconta, titular);
            }

            Console.WriteLine($"\n Dados da Conta: \n {conta}");
            Console.Write("\n Qual o valor que deseja depositar?");
            double quantia = double.Parse(Console.ReadLine())
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.Write("\n Qual o valor deseja sacar?");
            double saque = double.Parse(Console.ReadLine());
            conta.Saque(saque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}
