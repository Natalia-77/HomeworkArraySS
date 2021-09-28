using System;
using System.Linq;

namespace ArrayTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[5];
            int max =0;//max element first array.
            int max_mas = 0;//max element second array.         
            int result = 0;

            int row = 4;
            int col = 3;
            Console.WriteLine("Enter numbers for array: ");
            for (int i = 0; i < 5; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("One-dimensional array:");

            foreach (var item in array1)
            {
                Console.Write($"{item}  ");
            }
            Console.WriteLine();

            Random r = new();

            int[,] mas = new int[row, col];

            Console.WriteLine("Two-dimensional array:");

            for (int i = 0; i < row; i++) // row
            {
                for (int j = 0; j < col; j++)//col
                {
                    mas[i, j] = r.Next(0, 15); 
                    Console.Write($"{mas[i, j]} ");
                }
                Console.WriteLine();

            }
            for (int i = 0; i < array1.Length; i++)
            {
                if (max < array1[i])
                {
                    max = array1[i];
                }
            }
            Console.WriteLine($"Max element of first array is: {max}");

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (max_mas < mas[i, j])
                    {
                        max_mas = mas[i, j];
                    }
                }
            }
            Console.WriteLine($"Max element of second array is: {max_mas}");

            int[] temp = new int[mas.Length];
            int p = 0;
            for (int i = 0; i < row; i++) // row
            {
                for (int j = 0; j < col; j++)//col
                {
                    for (int k = 0; k < array1.Length; k++)//one-dimensional
                    {

                        if (mas[i, j] == array1[k])
                        {
                            p++;
                            temp[p] = mas[i, j];

                        }


                    }

                }

            }


              
            temp = temp.Where(a => a != 0).ToArray();
            int res_min = temp[0];          
            for (int i = 1; i < temp.Length-1; i++)
            {
                if (result < temp[i])
                {
                    result = temp[i];

                }
                if (temp[i]<res_min)
                {
                    res_min = temp[i];


                }
            }
            foreach (var item in temp)
            {
                Console.Write(item+"  ");
            }
            Console.WriteLine($"Max common element is:{result}");
            Console.WriteLine($"Min common element is:{res_min}");

            
































        }
    }
}
