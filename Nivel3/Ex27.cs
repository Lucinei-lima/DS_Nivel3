using System;

namespace Nivel3
{
    class Ex27
    {
        static void Main(string[] args)
        {
            int numQuant, numDig;
            
            //para saber quantos de quantos numeros sera calculado o fatorial.
            //Do While para ter serteza que sera pelo menos uma vez.
            do
            {
                Console.WriteLine("Digite quantos, números quer saber o Fatorial \n *Obs: tem que ser no mínimo 1!");
                numQuant = int.Parse(Console.ReadLine());
            } while (numQuant < 1);
            int[] fat = new int[numQuant];

            //for para repetir  de acordo com a quantidade de numeros que o usuario quer saber o fatorial.
            for (int i = 0; i < numQuant; i++)
            {
                fat[i] = 1;
                //Do While para saber se o numero é positivo.
                do
                {
                    Console.WriteLine("Digite o número que quer saber o Fatorial \n *Obs: tem que ser positivo!");
                    numDig = int.Parse(Console.ReadLine());
                } while (numDig < 0);
                
                //criação de um for para o recebimento e calculo dos fatoriais.
                for(int e = numDig; e > 0; e--)
                {
                    fat[i] *= e; 
                }
            }
            foreach (int n in fat)
            {
                Console.WriteLine(n);
            }
        }
    }
}
