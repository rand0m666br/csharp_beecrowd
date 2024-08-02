using System;

class URI {

    static void Main(string[] args) {
        while(true) {
            string linha = Console.ReadLine();
            string[] l = linha.Split(' ');

            int num1 = int.Parse(l[0]);
            int num2 = int.Parse(l[1]);

            if(num1 == 0 || num2 == 0) {
                Environment.Exit(0);
            } else if(num1 > 0 && num2 > 0) {
                Console.WriteLine("primeiro");
            } else if(num1 > 0 && num2 < 0) {
                Console.WriteLine("quarto");
            } else if(num1 < 0 && num2 < 0) {
                Console.WriteLine("terceiro");
            } else if(num1 < 0 && num2 > 0) {
                Console.WriteLine("segundo");
            }
        }
    }

}