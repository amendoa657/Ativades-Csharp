using System.Globalization;
using System;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace Name {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o numero do exercicio: ");
            int exercicio = int.Parse(Console.ReadLine());
            switch (exercicio) {
                case 1:
                    Exercicio1();
                    break;
                case 2:
                    Exercicio2();
                    break;
                case 3:
                    Exercicio3();
                    break;
                case 4:
                    Exercicio4();
                    break;
                case 5:
                    Exercicio5();
                    break;
                case 6:
                    Exercicio6();
                    break;
                case 7:
                    Exercicio7();
                    break;
                case 8:
                    Exercicio8();
                    break;
                case 9:
                    Exercicio9();
                    break;
                case 10:
                    Exercicio10();
                    break;
                case 11:
                    Exercicio11();
                    break;
                case 12:
                    Exercicio12();
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


        static void Exercicio1() {
            double somaNotas=0,media=0, maiorNota = 0;

            Console.WriteLine("Digite 4 notas");

            for (int i = 0; i < 4; i++) {
                double nota = double.Parse(Console.ReadLine());
                somaNotas += nota;
                media += nota;
                if(nota > maiorNota) {
                    maiorNota = nota;
                }
            }
            media /= 4;

            Console.WriteLine("A media das notas é igual a " + media.ToString("F2"));
            Console.WriteLine("A soma das notas é igual a " + somaNotas);
            Console.WriteLine("A maior nota é " + maiorNota);

        }

        static void Exercicio2() {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int quantidadeLitros;

            Console.Write("Digite o preço da gasolina: ");

            double precoGasolina = double.Parse(Console.ReadLine(),ci);

            Console.Write("Digite o valor do pagamento: ");
            double valorPagamento = double.Parse(Console.ReadLine());

            quantidadeLitros = Convert.ToInt32(valorPagamento/precoGasolina);

            Console.WriteLine(quantidadeLitros);
        }

        static void Exercicio3() {
            CultureInfo ci = CultureInfo.InvariantCulture;

            double precoDoKg = 58.0;

            Console.Write("Digite o peso de seu prato: ");

            double pesoPrato = double.Parse(Console.ReadLine(),ci);

            double precoDoPrato = pesoPrato*precoDoKg;

            Console.WriteLine("O preco total do prato é "+precoDoPrato.ToString("F2"));


        }

        static void Exercicio4() {

            Console.Write("Digite a largura da lateral do quadrado: ");

            double larguraQuadrado = double.Parse(Console.ReadLine());

            double areaQuadrado = Math.Pow(larguraQuadrado, 2);

            Console.WriteLine("A area do quadrado é igual a "+areaQuadrado);

        }

        static void Exercicio5() {
            Console.Write("Digite a altura do retangulo: ");

            double altura = double.Parse(Console.ReadLine());

            Console.Write("Digite a largura do retangulo: ");

            double largura = double.Parse(Console.ReadLine());


            double area = largura * altura;

            double perimetro = largura * 2 + altura * 2;

            Console.WriteLine("A area do retangulo é igual a "+area);

            Console.WriteLine("O perimetro do retangulo é igual a "+perimetro);
        }

        static void Exercicio6() {
            Console.Write("Digite um numero: ");

            double numero = double.Parse(Console.ReadLine());

            double quadradoNumero = Math.Pow(numero, 2);

            Console.WriteLine("O quadrado do numero é "+ quadradoNumero);
        }

        static void Exercicio7() {
            //A ordem dos preços é pequena ; media ; grande
            int[] precoCamiseta = [12, 16, 22];

            var quantCamiseta = new int[3];

            int valorTotal = 0;
            

            Console.Write("Digite a quantidade de camisetas pequenas: ");

            quantCamiseta[0] = int.Parse(Console.ReadLine());


            Console.Write("Digite a quantidade de camisetas medias: ");

            quantCamiseta[1] = int.Parse(Console.ReadLine());


            Console.Write("Digite a quantidade de camisetas grandes: ");

            quantCamiseta[2] = int.Parse(Console.ReadLine());


            for(int i=0;i<3;i++) {
                valorTotal += precoCamiseta[i] * quantCamiseta[i];
            }

            Console.WriteLine("O valor total é igual a "+valorTotal);

        }

        static void Exercicio8() {
            double[] valorMoedas = [1, 5, 10, 25, 50, 100];

            var quantMoedas = new double[6];

            double valorTotal = 0;


            Console.Write("Digite a quantidade de moedas de 1 centavo: ");

            quantMoedas[0] = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de moedas de 5 centavo: ");

            quantMoedas[1] = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de moedas de 10 centavo: ");

            quantMoedas[2] = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de moedas de 25 centavo: ");

            quantMoedas[3] = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de moedas de 50 centavo: ");

            quantMoedas[4] = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de moedas de 100 centavo: ");

            quantMoedas[5] = double.Parse(Console.ReadLine());

            for(int i = 0;i<6;i++) {
                valorTotal += quantMoedas[i] * valorMoedas[i];
            }

            valorTotal /= 100;

            Console.WriteLine("O valor total é "+valorTotal);
            
        }
        static void Exercicio9() {
            int idade;

            Console.Write("Digite o seu ano de nascimento: ");

            int anoNascimento = int.Parse(Console.ReadLine());



            idade = 2025 - anoNascimento;

            Console.WriteLine("A sua idade em anos é "+idade);

            Console.WriteLine("A sua idade em meses é "+idade*12);

            Console.WriteLine("A sua idade em dias é " + idade * 365);

            Console.WriteLine("A sua idade em semanas é "+ (idade * 365)/7);



        }
        static void Exercicio10() {


            Console.Write("Digite o raio: ");

            int raio = int.Parse(Console.ReadLine());

            double volume = (4.0 / 3.0) * 3.14 * Math.Pow(raio, 3);

            System.Console.WriteLine("O volume da esfera eh igual a " + volume.ToString("F2", CultureInfo.InvariantCulture));


        }

        static void Exercicio11() {
            System.Console.Write("Digite uma temperatura em Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (9.0 / 5.0) * celsius + 32;

            System.Console.WriteLine("A sua temperatura convertida para fahrenheit eh igual a " + fahrenheit.ToString("F2"));
        }

        static void Exercicio12() {
            int quantErros,porcenAcertos,porcenErros;

            Console.WriteLine("Digite a quantidade de questoes: ");

            int quantQuestoes = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de acertos: ");

            int quantAcertos = int.Parse(Console.ReadLine());


            quantErros = quantQuestoes - quantAcertos;

            porcenAcertos = quantAcertos * 100 / quantQuestoes;

            porcenErros = quantErros * 100 / quantQuestoes;


            Console.WriteLine("Voce errou "+quantErros+" questoes");

            Console.WriteLine("A porcentagem de acertos é "+porcenAcertos);

            Console.WriteLine("A porcentagem de erros é "+porcenErros);
        }


        static void Exercicio13() {
            double valorTotal;

            System.Console.WriteLine("Digite o valor unitario do produto: ");
            double valorUnitario = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a quantidade do produto: ");
            int quantidadeProduto = int.Parse(Console.ReadLine());

            valorTotal = valorUnitario * quantidadeProduto;

            System.Console.WriteLine("O valor total eh igual a " + valorTotal);



        }

        static void Exercicio14() {
            double valorTotal;

            System.Console.WriteLine("Digite o valor unitario do produto: ");
            double valorUnitario = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a quantidade do produto: ");
            int quantidadeProduto = int.Parse(Console.ReadLine());

            valorTotal = valorUnitario * quantidadeProduto;

            if (valorTotal > 200) {
                valorTotal *= 0.85;
            }

            System.Console.WriteLine("O valor total eh igual a " + valorTotal);
        }

        static void Exercicio15() {
            int quant200, quant100, quant50, quant20, quant10, quant5, quant2,resto;


            System.Console.WriteLine("Digite o valor em dinheiro: ");
            int valor = int.Parse(Console.ReadLine());


            quant200 = valor / 200;
            resto = valor % 200;
            quant100 = resto / 100;
            resto %= 100;
            quant50 = resto / 50;
            resto %= 50;
            quant20 = resto / 20;
            resto %= 20;
            quant10 = resto / 10;
            resto %= 10;
            quant5 = resto / 5;
            resto %= 5;
            quant2 = resto / 2;




            System.Console.WriteLine(quant200 + " nota de R$200,00");
            System.Console.WriteLine(quant100 + " nota de R$100,00");
            System.Console.WriteLine(quant50 + " nota de R$50,00");
            System.Console.WriteLine(quant20 + " nota de R$20,00");
            System.Console.WriteLine(quant10 + " nota de R$10,00");
            System.Console.WriteLine(quant5 + " nota de R$5,00");
            System.Console.WriteLine(quant2 + " nota de R$2,00");
        }

    }

}



