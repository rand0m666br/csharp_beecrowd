using System;

class URI
{

    static void Main(string[] args)
    {
        int val = 0;
        double total = 0;
        for (int i = 0; i < 5; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                val++;
                total += num;
            }
        }
        total = total / val;
        Console.WriteLine(val + " valores pares");
    }

}