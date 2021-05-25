using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix = { { 1, 2 }, { 3, 4 } };
        double radians = -1.57;
        int i = 0;

        foreach (int x in MatrixMath.Rotate2D(matrix, radians))
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