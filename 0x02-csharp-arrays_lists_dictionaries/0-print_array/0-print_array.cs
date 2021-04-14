using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        int[] array_completed = new int[size];
        int i = 0;

        if (size == 0)
        {
            Console.WriteLine(" ");
            return (array_completed);
        }
        else if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }

        while (i < size)
        {
            array_completed[i] = i;
            Console.Write("{0}{1}", i, i == size - 1 ? "\n" : " ");
            i++;
        }
        return (array_completed);
    }
}
