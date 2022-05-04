using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel3
{
    class Ex36
    {
        static void Main(string[] args)
        {
            List<Int32> NumPosit;
            NumPosit = new List<Int32>();

            int max, min, media, i = 1, total = 0;
            while (i <= 10)
            {
                Console.WriteLine($"Digite o {i}º número para adicionar a lista!");
                int num = int.Parse(Console.ReadLine());
                if (num >= 0)
                {
                    NumPosit.Add(num);
                    i += 1;
                    total += num;
                }
                else
                {
                    Console.WriteLine("O número tem que ser um inteiro positivo!");
                }
                
            }

            if (NumPosit == null)
            {
                Console.WriteLine("Voce não adicionou nenhum número!");
            }
            else
            {
                max = NumPosit.Max();
                min = NumPosit.Min();
                media = total / i;

                Console.WriteLine($"O maior numero da lista é: {max}, o menor numero é: {min} e a media é: {media}!");
            }

            
        }
    }
}
