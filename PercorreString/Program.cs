using System;

namespace PercorreString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nEscreva uma palavra ou frase: ");
            string input = Console.ReadLine();

            Console.Write("\nAgora escreva uma letra usada na palavra ou frase" 
            + " que escreveu acima: ");
            char letra = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == letra)
                {
                    continue;
                }

                else
                {
                    Console.Write(input[i]);
                }
            }
        }
    }
}
