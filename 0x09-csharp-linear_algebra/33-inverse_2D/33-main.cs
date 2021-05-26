using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix_2D = { { 1, 2 }, { 3, 4 } };
        int i = 0;

        foreach (int x in MatrixMath.Inverse2D(matrix_2D))
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