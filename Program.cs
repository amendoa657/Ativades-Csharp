using System.Globalization;
using System;
using System.ComponentModel;

namespace Name {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o numero do exercicio: ");
            int exercicio = int.Parse(Console.ReadLine());
            switch(exercicio) {
                case 10:
                    Exercicio10();
                break;
                case 11:
                    Exercicio11();
                break;
            }

        }

        static void Exercicio10() {
            CultureInfo ci = CultureInfo.InvariantCulture;


            Console.Write("Digite o raio: ");

            int raio = int.Parse(Console.ReadLine());

            double volume = (4.0 / 3.0) * 3.14* Math.Pow(raio, 3);

            System.Console.WriteLine("O volume da esfera eh igual a " + volume.ToString("F2", CultureInfo.InvariantCulture));


        }

        static void Exercicio11() {
            System.Console.Write("Digite uma temperatura em Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (9.0/5.0)*celsius+32;

            System.Console.WriteLine("A sua temperatura convertida para fahrenheit eh igual a " + fahrenheit.ToString("F2"));
        }
    }
    
}



