using System;

namespace Exercise_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your year of birth: ");
            // Use int.Parse or int.TryParse to convert the input to an integer
            if (int.TryParse(Console.ReadLine(), out int year))
            {
                // Now 'year' contains the user's input as an integer
                // You can use 'name' and 'year' in your program as needed
                Console.WriteLine($"Hello, {name}! You were born in {year}.");
            }
            else
            {
                Console.WriteLine("Invalid input for the year of birth. Please enter a valid number.");
            }
        }
    }
}