using System;

class URI
{

    static void Main(string[] args)
    {
        int qtd = int.Parse(Console.ReadLine());
        string valor = null;

        for (int i = 0; i < qtd; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine("NULL");
            }
            else if (num < 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
            }
            else if (num > 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else
                {
                    Console.WriteLine("ODD POSITIVE");
                }
            }
        }

    }
}