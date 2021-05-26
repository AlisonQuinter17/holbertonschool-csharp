using System;

class Program
{
    static void Main(string[] args)
    {
        double[] vector1 = { 2, -2, 1 };
        double[] vector2 = { -8, 8, -4 };
        double[] answer;

        answer = VectorMath.CrossProduct(vector1, vector2);
        Console.WriteLine("( {0}, {1}, {2} )", answer[0], answer[1], answer[2]);
    }
}