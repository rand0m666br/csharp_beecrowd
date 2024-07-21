using System; 

class URI {

    static void Main(string[] args)
    {

        int num = int.Parse(Console.ReadLine());
        int horas = int.Parse(Console.ReadLine());
        double val = double.Parse(Console.ReadLine());
        double total = val * horas;

        Console.WriteLine("NUMBER = " + num);
        Console.WriteLine("SALARY = " + total.ToString("U$ 0.00"));

    }

}