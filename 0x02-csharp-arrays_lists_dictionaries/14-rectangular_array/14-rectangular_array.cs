﻿using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] multidimensional_array = new int[5,5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == 2 && j == 2)
                    {
                        Console.Write("1 ");
                    }
                    else if (j > 4)
                    {
                        Console.Write("{0}\n", multidimensional_array[i, j]);
                    }
                    else
                    {
                        Console.Write("{0} ", multidimensional_array[i, j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
