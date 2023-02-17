using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива:");
            int razmer = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[razmer];
            Console.WriteLine("Введите целые числа массива:");
            for (int i = 0; i < razmer; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 1; i < array.Length; i++)
            {
                int sravnenie = array[i]; 
                int j = i - 1;

                while (j >= 0 && array[j] > sravnenie)
                {
                    array[j + 1] = array[j];
                    array[j] = sravnenie;
                    j--;
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Результат:");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < array.Length; i++)
            {
                    Console.Write(array[i] + "  ");
            }
        }
    }
}
