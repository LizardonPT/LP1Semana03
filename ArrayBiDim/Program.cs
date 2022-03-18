using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nIntroduz um número de linhas: ");
            int linhas = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nIntroduz um número de colunas: ");
            int colunas = Convert.ToInt32(Console.ReadLine());

            int[,] tabela = new int[linhas, colunas];
            
            for (int i = 0; i < tabela.GetLength(0); i++)
            {
                for (int j = 0; j < tabela.GetLength(1); i++)
                {
                    Console.Write($"Escreva um numero para a posição {i},{j}: ");
                    int valor = Convert.ToInt32(Console.ReadLine());
                    tabela [i, j] = valor;
                }
                Console.WriteLine();
            }
        }
    }
}
