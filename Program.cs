using System;

namespace ConsoleApp1_C_sharp_HomeWork_1_
{
    class Program
    {
        static void Main(string[] args)
        {

            ///// задание №1 (вывести количество ступеней)
            ///

            //Console.Write("Введите количество ступеней: ");
            //int step = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //for (int i = 0; i < step; i++)
            //{
            //    for (int j = 0; j < count; j++)
            //    {
            //        Console.Write("  ");
            //    }
            //    Console.WriteLine("***");
            //    for (int j = 0; j < count; j++)
            //    {
            //        Console.Write("  ");
            //    }
            //    Console.WriteLine("  *");
            //    count++;
            //    if (i==step-1)
            //    {
            //        for (int k = 0; k < step; k++)
            //        {
            //            Console.Write("  ");
            //        }
            //        Console.WriteLine("***");
            //    }
            //}


            // Задание №2 (заполнить массив M*N по спирали

            Console.Write("Введите занчение M: ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите занчение N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[,] myArr = new int[M, N];
            int number = M * N;

            int x = 0;
            int y = 0;

            while (true)
            {
                for (int j = x; j < N - x; j++)  // движение вправо
                {
                    myArr[y, j] = number;
                    number--;
                }
                if (number == 0)
                {
                    break;
                }
                for (int i = y + 1; i < M - y; i++) // движение вниз
                {
                    myArr[i, N - x - 1] = number;
                    number--;
                }
                if (number == 0)
                {
                    break;
                }
                for (int j = N - x - 2; j >= 0 + x; j--) // движение влево
                {
                    myArr[M - y - 1, j] = number;
                    number--;
                }
                if (number == 0)
                {
                    break;
                }
                for (int i = M - y - 2; i >= 0 + y + 1; i--) // движение вверх
                {
                    myArr[i, x] = number;
                    number--;
                }
                if (number == 0)
                {
                    break;
                }
                x++;
                y++;
            }
            // вывод массива
            for (int i  = 0; i < M ;i ++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (myArr[i,j]>=10)
                    {
                        Console.Write(myArr[i,j]+" ");
                    }
                    else
                    {
                        Console.Write(myArr[i, j] + "  ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
