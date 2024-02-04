using System;

class Exercise10
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter The Number Of Ships: ");
        int n = Convert.ToInt32(Console.ReadLine());
        // Array 1: Type Ship
        double[] ArrayType = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter Type of Ship ( 1 is VN, -1 is China ): ");
            int type = Convert.ToInt32(Console.ReadLine());
            if (type == 1)
            {
                ArrayType[i] = 1;
            } else if (type == -1)
            {
                ArrayType[i] = -1;
            }
        }
        // Array 2: Value of X
        double[] ArrayX = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter value of x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            ArrayX[i] = x;
        }
        
        // Array 3: Value of Y
        double[] ArrayY = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter value of Y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            ArrayY[i] = y;
        }
        // Show coordinates
        // The degree to which
        // ships violating sovereignty are within the range of this missile
        for (int i = 0; i < n; i++)
        {
            double d = Math.Sqrt(Math.Pow(Math.Abs(ArrayX[i]), 2) + Math.Pow(Math.Abs(ArrayY[i]), 2));
            if (ArrayType[i] == -1 && d <= 150)
            {
                Console.Write("X = " + ArrayX[i] + " ");
                Console.Write("Y = " + ArrayY[i]);
                Console.WriteLine();
            }
        }
    }
}