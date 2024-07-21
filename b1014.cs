using System; 

class URI {

    static void Main(string[] args)
    {

        int dis = int.Parse(Console.ReadLine());
        double com = double.Parse(Console.ReadLine());
        double cons = dis / com;

        Console.WriteLine(cons.ToString("0.000 km/l"));

    }

}