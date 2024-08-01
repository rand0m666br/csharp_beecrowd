using System;

class URI
{

    static void Main(string[] args)
    {
        double num = double.Parse(Console.ReadLine());

        if (num >= 0 && num <= 400.00)
        {
            Console.WriteLine("Novo salario: " + (num * 0.15 + num).ToString("0.00") + "\nReajuste ganho: " + (num * 0.15).ToString("0.00") + "\nEm percentual: 15 %");
        }
        else if (num >= 400.01 && num <= 800.00)
        {
            Console.WriteLine("Novo salario: " + (num * 0.12 + num).ToString("0.00") + "\nReajuste ganho: " + (num * 0.12).ToString("0.00") + "\nEm percentual: 12 %");
        }
        else if (num >= 800.01 && num <= 1200.00)
        {
            Console.WriteLine("Novo salario: " + (num * 0.10 + num).ToString("0.00") + "\nReajuste ganho: " + (num * 0.10).ToString("0.00") + "\nEm percentual: 10 %");
        }
        else if (num >= 1200.01 && num <= 2000.00)
        {
            Console.WriteLine("Novo salario: " + (num * 0.07 + num).ToString("0.00") + "\nReajuste ganho: " + (num * 0.07).ToString("0.00") + "\nEm percentual: 7 %");
        }
        else if (num > 2000.00)
        {
            Console.WriteLine("Novo salario: " + (num * 0.04 + num).ToString("0.00") + "\nReajuste ganho: " + (num * 0.04).ToString("0.00") + "\nEm percentual: 4 %");
        }
    }

}