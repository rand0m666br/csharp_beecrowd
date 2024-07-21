using System; 

class URI {

    static void Main(string[] args)
    {
        string linha = Console.ReadLine();
        string[] linhacont = linha.Split(' ');
        
        int a = int.Parse(linhacont[0]);
        int b = int.Parse(linhacont[1]);
        int c = int.Parse(linhacont[2]);

        int maiorAB = (a + b + Math.Abs(a - b )) / 2;
        int maiorABC = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;
        
        Console.WriteLine(maiorABC + " eh o maior");
    }

}