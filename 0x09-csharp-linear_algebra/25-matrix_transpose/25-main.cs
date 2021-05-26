using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix = { { 1, 2 }, { 3, 4 } };
        double[,] matrix1 = { { 1, 4, 6 }, { 8, 5, -1 } };
        int i = 0;

        foreach (int x in MatrixMath.Transpose(matrix))
        {
            if (i == 1)
            {
                Console.WriteLine("{0}", x);
                i = 0;
            }
            else
            {
                Console.Write("{0}, ", x);
                i++;
            }
        }
        Console.WriteLine("-------");
        foreach (int x in MatrixMath.Transpose(matrix1))
        {
            if (i == 1)
            {
                Console.WriteLine("{0}", x);
                i = 0;
            }
            else
            {
                Console.Write("{0}, ", x);
                i++;
            }
        }
    }
}
