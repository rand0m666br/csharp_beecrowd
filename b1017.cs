using System; 

class URI {

    static void Main(string[] args)
    {

        int tempo = int.Parse(Console.ReadLine());
        int vel = int.Parse(Console.ReadLine());
        double total = (tempo * vel) / 12.0;

        Console.WriteLine(total.ToString("0.000"));

    }

}