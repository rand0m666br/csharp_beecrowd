using System;

class URI
{

    static void Main(string[] args)
    {
        int qtd = int.Parse(Console.ReadLine());

        for (int i = 0; i < qtd; i++)
        {
            string linha = Console.ReadLine();
            string[] l = linha.Split(' ');
            
            double n1 = double.Parse(l[0]) * 2;
            double n2 = double.Parse(l[1]) * 3;
            double n3 = double.Parse(l[2]) * 5;

            double media = (n1 + n2 + n3) / 10;

            Console.WriteLine(media.ToString("0.0"));
        }
    }

}