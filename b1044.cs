using System;

class URI
{

    static void Main(string[] args)
    {
        string linha = Console.ReadLine();
        string[] l = linha.Split(' ');

        int num1 = int.Parse(l[0]);
        int num2 = int.Parse(l[1]);

        if(num2 % num1 == 0 || num1 % num2 == 0)
        {
            Console.WriteLine("Sao Multiplos");
        }else
        {
            Console.WriteLine("Nao sao Multiplos");
        }
    }

}