using System;

class URI {

    static void Main(string[] args) {

        int qtd = int.Parse(Console.ReadLine());

        for(int i = 0; i < qtd; i++) {
            string linha = Console.ReadLine();
            string[] l = linha.Split(' ');

            double num1 = double.Parse(l[0]);
            double num2 = double.Parse(l[1]);

            if(num2 == 0) {
                Console.WriteLine("divisao impossivel");
            }else {
                double media = num1 / num2;
                Console.WriteLine(media.ToString("0.0"));
            }
        }

    }

}