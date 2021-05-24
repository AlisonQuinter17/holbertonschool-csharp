using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix1 = { { 2, 3 }, { -1, 0 } };
        double[,] matrix2 = { { 1, 7 }, { -8, -2 } };
        int i = 0;

        foreach (int x in MatrixMath.Multiply(matrix1, matrix2))
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