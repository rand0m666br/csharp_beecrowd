using System;

class URI
{

    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        for (int i = num; i <= num + 11; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }

}