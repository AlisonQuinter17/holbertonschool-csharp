using System;

class Program
{
    static void Main(string[] args)
    {
        double[] vector1 = {1, 3};
        double[] vector2 = {-2, 5};
        double[] vector3 = {-4, 0, 10};
        double[] vector4 = {3, 7, -9};

        Console.WriteLine("{0}", VectorMath.DotProduct(vector1, vector2));
        Console.WriteLine("{0}", VectorMath.DotProduct(vector3, vector4));
    }
}