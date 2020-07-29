using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_bidimencional
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] aluno_nota = new double[3,3];
            aluno_nota[0, 0] = 8;
            aluno_nota[0, 1] = 6;
            aluno_nota[0, 2] = 4;
            aluno_nota[1, 0] = 4;
            aluno_nota[1, 1] = 7;
            aluno_nota[1, 2] = 9;
            aluno_nota[2, 0] = 3;
            aluno_nota[2, 1] = 8;
            aluno_nota[2, 2] = 1;
            for(int i = 0; i < 3; i++) { 
                for(int j=0; j < 3; j++) {
                   Console.Write(aluno_nota[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
