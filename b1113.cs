using System;

class URI
{

    static void Main(string[] args)
    {
        while (true)
        {
            string linha = Console.ReadLine();
            string[] l = linha.Split(' ');

            int num1 = int.Parse(l[0]);
            int num2 = int.Parse(l[1]);

            if (num1 > num2)
            {
                Console.WriteLine("Decrescente");
            }else if (num1 < num2)
            {
                Console.WriteLine("Crescente");
            }else
            {
                Environment.Exit(0);
            }
        }
    }

}