using System;

/// <summary> Class for MatrixMath. </summary>
class MatrixMath
{
    /// <summary> Transpose a matrix and return the resulting matrix. </summary>
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] error = { {} }, result = new double[matrix.GetLength(1), matrix.GetLength(0)];

        if (matrix.Length != 0)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[j, i] = matrix[i, j];
                }
            }
            return (result);
        }
        else
            return (error);
    }
}