using System;

class Program
{
    static void Main(string[] args)
    {
        double[] vector1 = {26};
        double[] vector2 = {3, 9};
        double[] vector3 = {7, -3, -9};
        double[] vector4 = {8, 4, 1, 5};

        Console.WriteLine("{0}", VectorMath.Magnitude(vector1));
        Console.WriteLine("{0}", VectorMath.Magnitude(vector2));
        Console.WriteLine("{0}", VectorMath.Magnitude(vector3));
        Console.WriteLine("{0}", VectorMath.Magnitude(vector4));
    }
}