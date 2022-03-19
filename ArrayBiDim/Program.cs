using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks for number os lines and columns
            Console.Write("\nIntroduz um número de linhas: ");
            int linhas = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nIntroduz um número de colunas: ");
            int colunas = Convert.ToInt32(Console.ReadLine());

            int[,] tabela = new int[linhas, colunas];
            
            //User types the numbers to put in the array
            for (int i = 0; i < tabela.GetLength(0); i++)
            {
                for (int j = 0; j < tabela.GetLength(1); j++)
                {
                    Console.Write($"Escreva um numero para a posição {i},{j}: ");
                    int valor = Convert.ToInt32(Console.ReadLine());
                    tabela [i, j] = valor;
                }
                Console.WriteLine();
            }

            
            float somaMedia = 0f;
            //Average per line
            for (int i = 0; i < tabela.GetLength(0); i++)
            {
                int somaL = 0;
                for (int j = 0; j < tabela.GetLength(1); j++)
                {
                    somaL += tabela[i, j];
                }
                float mediaL = somaL/tabela.GetLength(0);
                Console.WriteLine($"A média dos valores na linha {i} é = {mediaL}");

                somaMedia += mediaL;
            }

            Console.WriteLine($"A soma das médias é de {somaMedia}");
        }
    }
}
