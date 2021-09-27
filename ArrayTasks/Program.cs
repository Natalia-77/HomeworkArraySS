using System;

namespace ArrayTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Console.WriteLine("Enter numbers for array: ");
            for (int i = 0; i < 5; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("One-dimensional array:");
            foreach (var item in array)
            {
                Console.Write($"{item}  ");
            }
            Console.WriteLine();

            Random r = new Random();
            int[,] mas = new int[4, 3];
            Console.WriteLine("Two-dimensional array:");
            for (int i = 0; i < 4; i++) // row
            {
                for (int j = 0; j <3; j++)//col
                {
                    mas[i, j] = r.Next(10,50); // 10-50
                    Console.Write($"{mas[i, j]} ");
                }
                Console.WriteLine();
               
            }

            

        }
    }
}
