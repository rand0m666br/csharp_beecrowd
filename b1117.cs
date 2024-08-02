using System;

class URI {

    static void Main(string[] args) {

        double nota1 = 0;
        double nota2 = 0;

        while(true) {
            double num1 = double.Parse(Console.ReadLine());
            if(num1 < 0 || num1 > 10) {
                Console.WriteLine("nota invalida");
            } else {
                nota1 = num1;
                break;
            }
        }

        while(true) {
            double num2 = double.Parse(Console.ReadLine());
            if(num2 < 0 || num2 > 10) {
                Console.WriteLine("nota invalida");
            } else {
                nota2 = num2;
                break;
            }
        }

        double media = (nota1 + nota2) / 2;
        Console.WriteLine(media.ToString("media = 0.00"));

    }

}