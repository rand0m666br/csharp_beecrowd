using System;

class URI
{

    static void Main(string[] args)
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int total = 0;
        int menor = 0;
        int maior = 0;

        if (num1 > num2)
        {
            maior = num1;
            menor = num2;
        }else
        {
            maior = num2;
            menor = num1;
        }
        for (int i = menor + 1; i < maior; i++)
        {
            if (i % 2 != 0)
            {
                total += i;
            }
        }
        Console.WriteLine(total);
    }

}