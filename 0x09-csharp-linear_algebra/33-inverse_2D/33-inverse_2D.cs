using System;

/// <summary> Class for MatrixMath. </summary>
class MatrixMath
{
    /// <summary> Calculates the inverse of a 2D matrix and returns the resulting matrix. </summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        double[,] answer = {{matrix[1, 1], -1 * matrix[0, 1]}, {-1 * matrix[1, 0], matrix[0, 0]}}, error = { { -1 } };
        double determinat;

        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            determinat = Math.Round((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]), 2);

            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    answer[i, j] = Math.Round((answer[i, j] / determinat), 2);
                }
            }
            return (answer);
        }
        else
            return (error);
    }
}