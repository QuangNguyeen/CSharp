using System;

class Exercse6
{
    public static void Fibonacci(in int n)
    {
        Console.WriteLine($"List {n} number Fibonacci: ");
        int n1 = 0, n2 = 1;
        Console.Write(n1 + " " + n2 + " ");
        int n3;
        for (int i = 2; i < n; i++)
        {
            n3 = n1 + n2;
            Console.Write(n3 + " ");
            n1 = n2;
            n2 = n3;
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter value of n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Fibonacci(in n);
    }
}