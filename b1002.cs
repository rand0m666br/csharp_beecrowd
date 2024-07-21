using System; 

class URI {

    static void Main(string[] args)
    {

        double n = 3.14159;
        double num = double.Parse(Console.ReadLine());
        double result = n * Math.Pow(num, 2);

        Console.WriteLine("A=" + result.ToString("0.0000"));

    }

}