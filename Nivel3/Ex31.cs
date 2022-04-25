using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel3
{
    class Ex31
    {
        static void Main31(string[] args)
        {
            int positivo = 0, negativo = 0, num = 0;
            while (num >= 0)
            {
                Console.WriteLine("Digite um número positivo para saber se é par ou impar e sabera ao final a soma dos numeros pares e impares!");
                num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    break;
                }
                else if (num % 2 == 0)
                {
                    Console.WriteLine($"{num} é um número positivo!");
                    positivo += num;
                }
                else
                {
                    Console.WriteLine($"{num} é um número negativo!");
                    negativo += num;
                }
            }
            Console.WriteLine($"A soma dos numeros positivos é: {positivo}");
            Console.WriteLine($"A soma dos numeros negativos é: {negativo}");
        }
    }
}
