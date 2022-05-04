using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel3
{
    class Ex35
    {
        static void Main35(string[] args)
        {            
            for (int e = 10, i = 1; i <= 100 ; i++)
            {               
                if(i == e)
                {
                    Console.WriteLine($"{i} Múltiplo de 10");
                    e += 10;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
