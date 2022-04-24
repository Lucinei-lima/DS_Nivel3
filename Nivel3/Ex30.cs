using System;

namespace Nivel3
{
    class Ex30
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Tabuada do {i} \n");
                for (int e = 1; e <= 10; e++)
                {
                    int n = i * e;
                    Console.WriteLine($"{i}X{e}={n}");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
