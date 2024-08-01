using System;

class URI
{

    static void Main(string[] args)
    {
        int val = 0;
        double total = 0;
        for (int i = 0; i < 6; i++)
        {
            double num = double.Parse(Console.ReadLine());
            if (num > 0)
            {
                val++;
                total += num;
            }
        }
        total = total / val;
        Console.WriteLine(val + " valores positivos\n" + total.ToString("0.0"));
    }

}