using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix_2D = { { 2, 2 }, { -9, 4 } };
        double[,] matrix_3D = { { -4, 9, 0 }, { 1, -2, 1 }, { 3, -4, 2 } };

        Console.WriteLine(MatrixMath.Determinant(matrix_2D));
        Console.WriteLine("---");
        Console.WriteLine(MatrixMath.Determinant(matrix_3D));        
    }
}