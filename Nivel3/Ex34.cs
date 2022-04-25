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
            int temp;

            do
            {
                
                Console.WriteLine("Digite um número para adicionar na a lista!");
                temp = int.Parse(Console.ReadLine());
                if (temp >= 0)
                {
                    Num.Add(temp);
                }
            }
            while (temp < 0);


        }
    }
}
