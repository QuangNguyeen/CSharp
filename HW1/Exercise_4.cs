using System.Security.Claims;

namespace HW1
{
    class Exercise4
    {
        public static double Fx(in double x)
        {
            return Math.Sin(2 * x) + Math.Pow(x, 2);
        }

        public static double Derivative(in double x)
        {
            double delta = Math.Pow(10, -6);
            double xx = x + delta;
            return (Fx(in x) - Fx(xx)) / delta;
        }

        public static void SolveEquation(in double x,in double a, in double b)
        {
            // Dung do thi
            // a  < b
            double x1 = -0.966877;
            double x2 = 0;
            if (a > x1)
            {
                Console.WriteLine("No Solution.");
            } else if (b < x2)
            {
                Console.WriteLine("x = " + (x1));
            }
            else
            {
                Console.WriteLine("x1 = " + (x1));
                Console.WriteLine("x2 = " + x2);
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter value of x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value of a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value of b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            do
            {
                Console.WriteLine("Function: f(x) = sin(2x) + x^2");
                Console.WriteLine("1. Calculate f(x) at x");
                Console.WriteLine("2. Calculate f’(x) at x");
                Console.WriteLine("3. Solve equation f(x) = 0 at [a,b]");
                Console.WriteLine("Press another number to quit.");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice != 1 && choice != 2 && choice != 3)
                {
                    break;
                }
                switch (choice)
                {
                    case 1:
                    {
                        Console.WriteLine($"F({x} = ) {Fx(in x)}");
                        break;
                    }
                    case 2:
                    {   Console.WriteLine($"Derivative F(x) at {x} = {Derivative(in x)}");
                        break;
                    }
                    case 3:
                    {
                        SolveEquation(in x, in a, in b);
                        break;
                    }
                }
            } while (true);
        }
    }
}
