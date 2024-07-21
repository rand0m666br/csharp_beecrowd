using System; 

class URI {

    static void Main(string[] args)
    {

        double A = double.Parse(Console.ReadLine()) * 2;
        double B = double.Parse(Console.ReadLine()) * 3;
        double C = double.Parse(Console.ReadLine()) * 5;
        double media = (A + B + C) / 10;

        Console.WriteLine("MEDIA = " + media.ToString("0.0"));

    }

}