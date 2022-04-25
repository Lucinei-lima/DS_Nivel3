using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel3
{
    class Ex33
    {
        static void Main(string[] args)
        {
            int media, cont = 0, soma = 0;
            List<Int32> MatrAlunos;
            MatrAlunos = new List<Int32>();

            List<Int32> NotAlunos;
            NotAlunos = new List<Int32>();
                        
            bool test = true;
            while(test)
            {
                Console.WriteLine("Digite o número de matricula deste aluno! \n");
                MatrAlunos.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Digite a nota deste aluno! \n");
                NotAlunos.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Digite 'S' para sair ou pressione 'Enter' para continuar!\n");
                string n = Console.ReadLine();
                if(n == "S" || n == "s")
                {
                    test = false;
                }
                else
                {
                    test = true;
                }
            }

            foreach (int x in MatrAlunos)
            {
                Console.WriteLine($"os alunos avaliados são: {x}");
            }

            foreach (int item in NotAlunos)
            {
                soma += item;
                cont += 1;
            }

            media = soma / cont;

            Console.WriteLine($"A media desta turma é: {media}");
        }
    }
}
