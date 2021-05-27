using System;

/// <summary> Class for MatrixMath. </summary>
class MatrixMath
{
    /// <summary> Calculates the inverse of a 2D matrix and returns the resulting matrix. </summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        double determinat, div_det;
        double [,] error = new double[,] { { -1 } };
        double [,] answer = new double[2, 2], inverse;
        
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return (error);

        inverse = new double[,]{{matrix[1, 1], -1 * matrix[0, 1]}, {-1 * matrix[1, 0], matrix[0, 0]}};
        determinat = Math.Round((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]), 2);

        if (determinat == 0)
            return (error);

        div_det = 1 / determinat;
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                answer[i, j] = Math.Round(div_det * inverse[i, j], 2);
            }
        }
        return (answer);
    }
}