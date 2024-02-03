using System;

class Exercise_2
{
    public static double Fx(in double x)
    {
        return Math.Tan(2 * x) - x + 1;
    }

    public static double Derivative(in double x)
    {
        double delta = Math.Pow(10, -6);
        double xx = x + delta;
        return (Fx(in x) - Fx(in xx)) / (x - xx);
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter value of x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Derivative F(x) : " + Derivative(in x));
    }
}