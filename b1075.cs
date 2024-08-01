using System;

class URI
{

    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i < 10000; i++)
        {
            if (i % num == 2)
            {
                Console.WriteLine(i);
            }
        }
    }

}