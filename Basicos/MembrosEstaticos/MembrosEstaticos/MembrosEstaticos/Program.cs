using System;

namespace MembrosEstaticos {
    class Program {

        static double Pi = 3.1415; 
        static void Main(string[] args) {

            Console.WriteLine("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Cincunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine($"Circunferência: {circ.ToString("F2")}");
            Console.WriteLine($"Volume: {volume.ToString("F2")}");
            Console.WriteLine($"Valor de Pi: {Pi}");
        }

         static double Cincunferencia(double r) {
            return 2.0 * Pi * r;
        }

        static double Volume(double r) {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
}
