using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix1 = { { 14, -3, 0 }, { -11, -5, 3 }, { 2, -9, 13 } };
        double[,] matrix2 = { { 6, 16, 21 }, { 5, 2, 0 }, { 1, 3, 7 } };
        int i = 0;

        foreach (int x in MatrixMath.Add(matrix1, matrix2))
        {
            if (i == 2)
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