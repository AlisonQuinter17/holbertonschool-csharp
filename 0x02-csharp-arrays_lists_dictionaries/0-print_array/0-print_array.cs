﻿using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        int[] array_completed = new int[size];
        int i = 0;

        if (size == 0)
        {
            Console.WriteLine(" ");
        }
        else if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }

        while (i < size)
        {
            array_completed[i] = i;
            if (i == size - 1)
            {
                Console.Write("{0}\n", i);
            }
            else
            {
                Console.Write("{0} ", i);
            }
            i++;
        }
        return (array_completed);
    }
}
