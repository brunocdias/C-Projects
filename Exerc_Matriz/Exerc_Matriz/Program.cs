using System;

namespace Exerc_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho de linhas: ");
            int m = Int32.Parse(Console.ReadLine());

            Console.Write("Digite o tamanho de colunas: ");
            int n = Int32.Parse(Console.ReadLine());

            int[,] numeros = new int[m,n];

            Console.WriteLine();

            Console.WriteLine("Digite os valores: ");
            

            for(int i = 0; i< m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j =0; j < n; j++)
                {
                    numeros[i,j] = Int32.Parse(values[j]);
                }
                Console.WriteLine();
            }

            Console.Write("Digite um número que pertence a matriz: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (numeros[i, j] == x)
                    {
                        Console.WriteLine("Posicao: " + i + "," + j);
                        if(j > 0)
                        {
                            Console.WriteLine("Esquerda: {0}", numeros[i, j - 1]);
                        }
                        if(j < n - 1)
                        {
                            Console.WriteLine("Direita: {0}", numeros[i, j + 1]);
                        }
                        if( i < m - 1)
                        {
                            Console.WriteLine("Abaixo: {0}", numeros[i + 1, j]);
                        }
                        
                    }
                }
            }
        }
    }
}
