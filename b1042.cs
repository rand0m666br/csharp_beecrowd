using System;

class URI
{

    static void Main(string[] args)
    {
        string linha = Console.ReadLine();
        string[] linhacount = linha.Split(' ');

        int n1 = int.Parse(linhacount[0]);
        int n2 = int.Parse(linhacount[1]);
        int n3 = int.Parse(linhacount[2]);

        int[] numeros = { n1, n2, n3 };

        Array.Sort(numeros);
        foreach (int n in numeros)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine();

        int[] numeros2 = { n1, n2, n3 };
        foreach (int n in numeros2) {
            Console.WriteLine(n);
        }
    }

}