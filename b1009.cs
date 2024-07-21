using System; 

class URI {

    static void Main(string[] args)
    {

        string nome = Console.ReadLine();
        double salario = double.Parse(Console.ReadLine());
        double vendas = double.Parse(Console.ReadLine()) * 0.15;
        double total = vendas + salario;

        Console.WriteLine(total.ToString("TOTAL = R$ 0.00"));

    }

}