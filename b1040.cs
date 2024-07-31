using System;

class URI
{

    static void Main(string[] args)
    {
        string linha = Console.ReadLine();
        string[] linhacont = linha.Split(' ');

        double n1 = double.Parse(linhacont[0]) * 2;
        double n2 = double.Parse(linhacont[1]) * 3;
        double n3 = double.Parse(linhacont[2]) * 4;
        double n4 = double.Parse(linhacont[3]) * 1;

        double resultado = (n1 + n2 + n3 + n4) / 10;
        double media = Math.Floor(resultado * 10) / 10;


        Console.WriteLine(media.ToString("Media: 0.0"));

        if(media >= 7.0)
        {
            Console.WriteLine("Aluno aprovado.");
        }else if(media >= 5.0 && media <= 6.9)
        {
            Console.WriteLine("Aluno em exame.");
            double nExame = double.Parse(Console.ReadLine());

            Console.WriteLine(nExame.ToString("Nota do exame: 0.0"));

            double newMedia = (media + nExame) / 2;
            if(newMedia >= 5)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }
            Console.WriteLine(newMedia.ToString("Media final: 0.0"));

        }
        else
        {
            Console.WriteLine("Aluno reprovado.");
        }
    }

}