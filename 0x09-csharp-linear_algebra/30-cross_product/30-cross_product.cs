using System;

/// <summary> Class for VectorMath. </summary>
class VectorMath
{
    /// <summary> Calculates the cross product of two 3D vectors and returns the resulting vector. </summary>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        double[,] matrix_i = { { vector1[1], vector1[2] }, { vector2[1], vector2[2] } };
        double[,] matrix_j = { { vector1[0], vector1[2] }, { vector2[0], vector2[2] } };
        double[,] matrix_k = { { vector1[0], vector1[1] }, { vector2[0], vector2[1] } };
        double[] answer = { 0, 0, 0 };

        if (vector1.Length == 3 && vector2.Length == 3)
        {
            answer[0] = Math.Round((matrix_i[0, 0] * matrix_i[1, 1]) - (matrix_i[0, 1] * matrix_i[1, 0]), 2);
            answer[1] = Math.Round((matrix_j[0, 0] * matrix_j[1, 1]) - (matrix_j[0, 1] * matrix_j[1, 0]), 2);
            answer[2] = Math.Round((matrix_k[0, 0] * matrix_k[1, 1]) - (matrix_k[0, 1] * matrix_k[1, 0]), 2);
            return (answer);
        }
        else
            return (new double[] { -1 });
    }
}