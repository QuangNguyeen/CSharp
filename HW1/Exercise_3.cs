using System;

class Exercise3
{
    static double Bill(in double x)
    {
        if (x <= 0)
        {
            return 0;
        } else if (x <= 25)
        {
            return x * 1000;
        } else if (x <= 75)
        {
            return 25 * 1000 + (x - 25) * 1250;
        } else if (x <= 150)
        {
            return 25 * 1000 + 50 * 1250 + (x - 75) * 1800;
        }
        else
            return 25 * 1000 + 50 * 1250 + 75 * 1800 + (x - 150) * 2500;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter value of Consumption: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Bill: " + Bill(in x) + "VND");
        
    }
}