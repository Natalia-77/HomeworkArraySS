﻿using System;
using System.Linq;

namespace ArrayTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array
            //int[] array1 = new int[5];
            //int max =0;//max element first array.
            //int max_mas = 0;//max element second array.         

            //int sum = 0;//sum of first array.
            //int sum1= 0;//sum second array.
            //int sum_even = 0;


            //int row = 4;
            //int col = 3;

            //Console.WriteLine("Enter numbers for array: ");
            //for (int i = 0; i < 5; i++)
            //{
            //    array1[i] = int.Parse(Console.ReadLine());
            //}


            //Console.WriteLine("One-dimensional array:");
            //foreach (var item in array1)
            //{
            //    Console.Write($"{item}  ");
            //}
            //Console.WriteLine();

            //Random r = new();

            //int[,] mas = new int[row, col];

            //Console.WriteLine("Two-dimensional array:");
            //int sum_evencol = 0;
            //for (int i = 0; i < row; i++) // row
            //{
            //    for (int j = 0; j < col; j++)//col
            //    {
            //        mas[i, j] = r.Next(0, 10); 
            //        Console.Write($"{mas[i, j]} ");
            //        if (j % 2 == 0)//if column number is even.
            //        {
            //            sum_evencol += mas[i, j];//sum elements of this column.
            //        }
            //    }
            //    Console.WriteLine();

            //}
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    if (max < array1[i])
            //    {
            //        max = array1[i];
            //    }
            //    sum1 += array1[i];

            //    if(array1[i]%2==0)
            //    {
            //        sum_even += array1[i];
            //    }

            //}
            //Console.WriteLine($"Max element of first array is: {max}");

            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < col; j++)
            //    {
            //        if (max_mas < mas[i, j])
            //        {
            //            max_mas = mas[i, j];
            //        }
            //        sum += mas[i, j];

            //    }
            //}
            //Console.WriteLine($"Max element of second array is: {max_mas}");

            //int[] temp = new int[mas.Length];
            //int p = 0;
            //for (int i = 0; i < row; i++) // row
            //{
            //    for (int j = 0; j < col; j++)//col
            //    {

            //        for (int k = 0; k < array1.Length; k++)//one-dimensional
            //        {                      
            //            if (mas[i, j] == array1[k])
            //            {
            //                p++;
            //                temp[p] = mas[i, j];                          

            //            }                    

            //        }

            //    }

            //}

            //temp = temp.Where(a => a != 0).ToArray();
            //int res_min =temp[0];//minimum common element.
            //int res_max = temp[0];//maximum common element.
            //for (int i = 1; i < temp.Length-1; i++)
            //{
            //    if (res_max < temp[i])
            //    {
            //        res_max = temp[i];

            //    }
            //    if (temp[i] < res_min)
            //    {
            //        res_min = temp[i];

            //    }
            //}
            //foreach (var item in temp)
            //{
            //    Console.Write(item + "  ");
            //}
            //Console.WriteLine();
            //Console.WriteLine($"Max common element is:{res_max}");
            //Console.WriteLine($"Min common element is:{res_min}");
            //Console.WriteLine($"Sum {sum+sum1}\n");
            //Console.WriteLine($"Sum even elements is:{sum_even}");
            //Console.WriteLine($"Qwe {sum_evencol}");

            #endregion

            //Існує два масиви розміром M і N відповідно.
            //Загальні не повторювані елементи перших двох масивів повинні
            //бути записані в третьому масиві.

            #region Task1

            int row = 5;
            int col = 6;
            int[,] arr = new int[row,col];
            int[,] arr1 = new int[row, col];
            Random rand = new Random();

            //first array
            for (int i = 0; i < row; i++) // row
            {
                for (int j = 0; j < col; j++)//col
                {
                    arr[i, j] = rand.Next(0, 10);
                    Console.Write($"{arr[i, j]} ");                   
                }
                Console.WriteLine();
            }
            Console.WriteLine("======================\n");

            //second array
            for (int i = 0; i < row; i++) // row
            {
                for (int j = 0; j < col; j++)//col
                {
                    arr1[i, j] = rand.Next(0, 10);
                    Console.Write($"{arr1[i, j]} ");
                }
                Console.WriteLine();
            }







            #endregion































        }
    }
}
