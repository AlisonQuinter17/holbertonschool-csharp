using System;

/// <summary> Class for MatrixMath. </summary>
class MatrixMath
{
    /// <summary> Calculates the inverse of a 2D matrix and returns the resulting matrix. </summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        double determinat;
        double [,] error = new double[,] { { -1 } };
        double [,] answer = new double[2, 2];
        double [,] inverse = {{matrix[1, 1], -1 * matrix[0, 1]}, {-1 * matrix[1, 0], matrix[0, 0]}};
        
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return (error);

        determinat = Math.Round((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]), 2);

        if (determinat == 0)
            return (error);

        double divDet = 1 / determinat;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                answer[i, j] = Math.Round(divDet * inverse[i, j], 2);
            }
        }
        return (answer);
    }
}