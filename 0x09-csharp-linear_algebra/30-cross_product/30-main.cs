using System;

class Program
{
    static void Main(string[] args)
    {
        double[] vector1 = { 2, -2, 1 }, vector2 = { -8, 8, -4 };
        double[] vector3 = { -3, -2, 5 }, vector4 = { 6, -10, -1 };
        double[] answer1, answer2;

        answer1 = VectorMath.CrossProduct(vector1, vector2);
        Console.WriteLine("({0}, {1}, {2})", answer1[0], answer1[1], answer1[2]);

        answer2 = VectorMath.CrossProduct(vector3, vector4);
        Console.WriteLine("({0}, {1}, {2})", answer2[0], answer2[1], answer2[2]);
    }
}