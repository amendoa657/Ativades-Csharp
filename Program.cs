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
                case 13:
                    Exercicio13();
                    break;
                case 14:
                    Exercicio14();
                    break;
                case 15:
                    Exercicio15();
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

        static void Exercicio13() {
            double valorTotal;

            System.Console.WriteLine("Digite o valor unitario do produto: ");
            double valorUnitario = double.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Digite a quantidade do produto: ");
            int quantidadeProduto = int.Parse(Console.ReadLine());

            valorTotal = valorUnitario*quantidadeProduto;

            System.Console.WriteLine("O valor total eh igual a "+ valorTotal);



        }

        static void Exercicio14() {
            double valorTotal;

            System.Console.WriteLine("Digite o valor unitario do produto: ");
            double valorUnitario = double.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Digite a quantidade do produto: ");
            int quantidadeProduto = int.Parse(Console.ReadLine());

            valorTotal = valorUnitario*quantidadeProduto;

            if(valorTotal>200) {
                valorTotal*=0.85;
            }

            System.Console.WriteLine("O valor total eh igual a "+ valorTotal);
        }

        static void Exercicio15() {
            int quant200,quant100,quant50,quant20,quant10,quant5,quant2;


            System.Console.WriteLine("Digite o valor em dinheiro: ");
            int valor = int.Parse(Console.ReadLine());

            
            quant200=valor/200;
            quant100=(valor%200)/100;
            quant50=(valor%100)/50;
            quant20=(valor%50)/20;
            quant10 =(valor%20)/10;
            quant5 = (valor%10)/5;
            quant2 = (valor%5)/2;




            System.Console.WriteLine(quant200+" nota de R$200,00");
            System.Console.WriteLine(quant100+" nota de R$100,00");
            System.Console.WriteLine(quant50+" nota de R$50,00");
            System.Console.WriteLine(quant20+" nota de R$20,00");
            System.Console.WriteLine(quant10+" nota de R$10,00");
            System.Console.WriteLine(quant5+" nota de R$5,00");
            System.Console.WriteLine(quant2+" nota de R$2,00");
        }
    }
    
}



