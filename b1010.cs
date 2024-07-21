using System; 

class URI {

    static void Main(string[] args)
    {
        string line1 = Console.ReadLine();
        string[] line1split = line1.Split(' ');
        int cod1 = int.Parse(line1split[0]);
        int num1 = int.Parse(line1split[1]);
        double val1 = double.Parse(line1split[2]);
        
        string line2 = Console.ReadLine();
        string[] line2split = line2.Split(' ');
        int cod2 = int.Parse(line2split[0]);
        int num2 = int.Parse(line2split[1]);
        double val2 = double.Parse(line2split[2]);

        double total = (num1 * val1) + (num2 * val2);

        Console.WriteLine("VALOR A PAGAR: " + total.ToString("R$ 0.00"));

    }

}