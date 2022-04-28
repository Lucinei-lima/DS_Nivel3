using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel3
{
    class Ex34
    {
        static void Main(string[] args)
        {
            List<Int32> Num;
            Num = new List<Int32>();
            int temp, max = 0, min = 0;

            do
            {
                
                Console.WriteLine("Digite um número positivo para adicionar na a lista!" +
                    "ou um numero negativo para sair");
                temp = int.Parse(Console.ReadLine());

                if (temp >= 0)
                {
                    Num.Add(temp);
                }
            }
            while (temp > 0);

            if(Num == null)
            {
                Console.WriteLine("Voce nao adicionou nenhum numero!");
            }
            else
            {
                max = Num.Max();
                min = Num.Min();
            }

            Console.WriteLine($"O maior numero da lista é: {max}, e o menor numero é: {min}");

        }
    }
}
