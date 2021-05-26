using System;

class Program
{
    static void Main(string[] args)
    {
        double[] vector1 = { 2, -2, 1 };
        double[] vector2 = { -8, 8, -4 };

        foreach (double x in VectorMath.CrossProduct(vector1, vector2))
        {
            Console.Write(x + " ");
        }
    }
}