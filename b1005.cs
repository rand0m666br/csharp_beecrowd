using System; 

class URI {

    static void Main(string[] args)
    {

        double num1 = double.Parse(Console.ReadLine()) * 3.5;
        double num2 = double.Parse(Console.ReadLine()) * 7.5;
        double media = (num1 + num2) / 11;

        Console.WriteLine("MEDIA = " + media.ToString("0.00000"));

    }

}