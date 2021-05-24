﻿using System;

/// <summary> Class for MatrixMath. </summary>
class MatrixMath
{
    /// <summary> Multiplies two matrices and returns the resulting matrix. </summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] empty_matrix = { { -1 } };

        if ((matrix1.GetLength(0) == 2 && matrix1.GetLength(1) == 2) || (matrix2.GetLength(0) == 2 && matrix2.GetLength(1) == 2))
        {
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        matrix1[i, j] = matrix1[i, j] * matrix2[0, j] + matrix1[i, j + 1] * matrix2[1, j];
                    }
                    if (j == 1)
                    {
                        matrix1[i, j] = matrix1[i, j] * matrix2[1, j] + matrix1[i, j - 1] * matrix2[0, j];
                    }
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