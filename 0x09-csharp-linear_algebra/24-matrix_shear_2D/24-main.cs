using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix = { { 1, 2 }, { 3, 4 } };
        char directionX = 'x', directionY = 'y';;
        double factor = 2;
        int i = 0;

        foreach (int x in MatrixMath.Shear2D(matrix, directionX, factor))
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
        foreach (int x in MatrixMath.Shear2D(matrix, directionY, factor))
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
