using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix = { { -13, 10, 8 }, { 2, 0, 14 }, { -4, -5, 2 } };
        double scalar = 4;
        int i = 0;

        foreach (int x in MatrixMath.MultiplyScalar(matrix, scalar))
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