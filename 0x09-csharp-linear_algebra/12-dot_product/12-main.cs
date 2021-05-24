using System;

class Program
{
    static void Main(string[] args)
    {
        double[] vector1 = {98, 972};
        double[] vector2 = {0, -16};
        double[] vector3 = {98, 972, 4};
        double[] vector4 = {0, -16, 31};

        Console.WriteLine("{0}", VectorMath.DotProduct(vector1, scalar2));
        Console.WriteLine("{0}", VectorMath.DotProduct(vector3, vector4));
    }
}