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
            int maior = 0;
            int menor = 0;
            int total = 0;

            if (num1 <= 0 || num2 <= 0)
            {
                Environment.Exit(0);
            }

            if (num1 > num2)
            {
                maior = num1;
                menor = num2;
            }
            else if (num1 < num2)
            {
                maior = num2;
                menor = num1;
            }

            for (int i = menor; i <= maior; i++)
            {
                Console.Write(i + " ");
                total += i;
            }
            Console.Write("Sum=" + total + "\n");
        }
    }

}