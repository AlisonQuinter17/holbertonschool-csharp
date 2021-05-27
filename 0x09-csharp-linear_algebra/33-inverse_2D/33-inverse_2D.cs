using System;

/// <summary> Class for MatrixMath. </summary>
class MatrixMath
{
    /// <summary> Calculates the inverse of a 2D matrix and returns the resulting matrix. </summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        double[,] answer = new double[2, 2], trans = new double[2, 2], error = new double[,] { { -1 } };
        double determinat = Math.Round((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]), 2);

        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2 && determinat != 0)
        {
            trans[0, 0] = matrix[1, 1];
            trans[0, 1] = -1 * matrix[0, 1];
            trans[1, 0] = -1 * matrix[1, 0];
            trans[1, 1] = matrix[0, 0];

            double divDet = 1 / determinat;

            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    answer[i, j] = Math.Round(divDet * trans[i, j], 2);
                }
            }
            return (answer);
        }
        else
            return (error);
    }
}