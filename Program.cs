using System;

namespace Exercicio_Quatro
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            for (int i = 0; i < 100; i++)
            {
                soma = soma + i;
            }
            Console.WriteLine(soma);
            Console.ReadKey();
        }
    }
}
