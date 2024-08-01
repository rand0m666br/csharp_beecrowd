using System;

class URI
{

    static void Main(string[] args)
    {
        string linha = Console.ReadLine();
        string[] linhacount = linha.Split(' ');

        int cod = int.Parse(linhacount[0]);
        int qtd = int.Parse(linhacount[1]);
        
        double preco = 0;

        switch (cod)
        {
            case 1:
                preco = qtd * 4;
                break;

            case 2:
                preco = qtd * 4.5;
                break;

            case 3:
                preco = qtd * 5;
                break;

            case 4:
                preco = qtd * 2;
                break;

            case 5:
                preco = qtd * 1.5;
                break;
        }

        Console.WriteLine(preco.ToString("Total: R$ 0.00"));
    }

}