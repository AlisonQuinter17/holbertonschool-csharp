using System;

class Program
{
    static void Main(string[] args)
    {
        double[] vector1 = {98, 972};
        double[] vector2 = {0, -16, 31};
        double scalar1 = 0.5;
        double scalar2 = 4;

        foreach (double x in VectorMath.Multiply(vector1, scalar1))
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();
        foreach (double y in VectorMath.Multiply(vector2, scalar2))
        {
            Console.Write(y + " ");
        }
    }
}