using System;

class Program
{
    static void Main(string[] args)
    {
        double[] vector1 = {8, -11};
        double[] vector2 = {-4, 9};
        double[] vector3 = {14, -2, 0};
        double[] vector4 = {-3, 23, 50};

        foreach (double x in VectorMath.Add(vector1, vector2))
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();
        foreach (double y in VectorMath.Add(vector3, vector4))
        {
            Console.Write(y + " ");
        }
    }
}