using System;

namespace Nivel3
{
    class Ex27
    {
        static void Main(string[] args)
        {
            int numQuant;

            do
            {
                Console.WriteLine("Digite quantos, números quer saber o Fatorial \n *Obs: tem que ser no mínimo 1!");
                numQuant = int.Parse(Console.ReadLine());
            } while (numQuant < 1);
              
           
        }
    }
}
