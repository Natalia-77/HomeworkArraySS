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
            int max_mas = 0;
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
                for (int j = 0; j <col; j++)//col
                {
                    mas[i, j] = r.Next(10,50); // 10-50
                    Console.Write($"{mas[i, j]} ");
                }
                Console.WriteLine();
               
            }
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    if (max < array1[i])
            //    {
            //        max = array1[i];
            //    }
            //}
            //Console.WriteLine(max);

            //for (int i = 0; i < row; i++)                
            //{
            //    for (int j = 0; j < col; j++)
            //    {
            //        if(max_mas<mas[i,j])
            //        {
            //            max_mas = mas[i, j];
            //        }
            //    }
            //}
            //Console.WriteLine(max_mas);          


            int[][] arr3 = new int[row+1][];
          
            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;

            for (int i = 0; i < arr3.Length; i++)
          
                arr3[i] = new int[columns-2];
          
           
            for (int i = 0; i < arr3.Length; i++)
             {

                    for (int y = 0; y < arr3[i].Length; y++)
                    {
                   

                    if (i == 0)
                    {
                        //for (int s = 0; s < array1.Length; s++)
                        //{

                        //    arr3[i][y] = 222;


                        //    Console.Write(arr3[i][y] + " ");
                        //}

                       
                    }
                    else
                    {
                        for (int q = 0; q < 3; q++)
                        {
                            arr3[i][y] = mas[i - 1, q];

                            Console.Write(arr3[i][y] + " ");
                        }

                    }
                    Console.WriteLine();

                }

                }






            //int[][] array = new int[4][];
            //for (int i = 0; i < array.Length; i++)
            //    array[i] = new int[i + 3];
            //Random rnd = new Random();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = 0; j < array[i].Length; j++)
            //        Console.Write("{0, 4}", array[i][j] = rnd.Next(0, 20));
            //    Console.WriteLine();
            //}





            Console.WriteLine("=======================\n");

            foreach (int[] arrItem in arr3)
            {
                foreach (var i in arrItem)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }













        }
    }
}
