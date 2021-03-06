using System;

/// <summary> Class for VectorMath. </summary>
class MatrixMath
{
    /// <summary> Adds two matrices and returns the resulting matrix. </summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] empty_matrix = { { -1 } };

        if ((matrix1.GetLength(0) == 2 && matrix2.GetLength(0) == 2 && matrix1.GetLength(1) == 2 && matrix2.GetLength(1) == 2) || (matrix1.GetLength(0) == 3 && matrix2.GetLength(0) == 3 && matrix1.GetLength(1) == 3 && matrix2.GetLength(1) == 3))
        {
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix1[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return (matrix1);
        }
        else
        {
            return (empty_matrix);
        }
    }
}
