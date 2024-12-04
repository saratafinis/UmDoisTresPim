using System;
 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o número máximo para o jogo 'Um Dois Três Pim':");
        int maxNumber;
 
        // Verifica se a entrada é um número válido
        if (int.TryParse(Console.ReadLine(), out maxNumber))
        {
            for (int i = 1; i <= maxNumber; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Pim");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine("Por favor, insira um número válido.");
        }
    }
}