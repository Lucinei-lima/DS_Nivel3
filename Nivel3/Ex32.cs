using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel3
{
    class Ex32
    {
        static void Main32(string[] args)
        {
            bool teste;
            Double num, somaQuad = 0;
            do
            {   
                Console.WriteLine("Digite um número maior que zero e menor que dez" +
                    " para saber a soma dos quadrados dos 20 primeiros números " +
                    "inteiros positivos ímpares  a patir do numero informado.");
                num = int.Parse(Console.ReadLine());
                
                if (num > 0 && num < 10)
                {
                    teste = false;
                }
                else
                {
                    teste = true;
                }
                
            }
            while (teste);

            int i = 1;
            while (i <= 5)
            {
                if (num % 2 != 0)
                {
                    somaQuad += Math.Sqrt(num);
                    i++;
                    num++;
                }
                else
                {
                    num++;
                }
            }
            Console.WriteLine($"A soma das raizes quadrada é: {somaQuad}");
        }
    }
}
