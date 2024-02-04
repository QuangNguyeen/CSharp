using System;

class Exercise_5
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of rows: ");
        int noRow = Convert.ToInt32(Console.ReadLine());
        int c = 1, blk, i, j;
        for (i = 0; i < noRow; i++)
        {
            for (blk = 1; blk <= noRow - i; blk++)
                Console.Write("  ");  // Adding spaces for formatting the triangle

            for (j = 0; j <= i; j++)
            {
                if (j == 0 || i == 0)
                    c = 1;  // First and last elements in a row of Pascal's triangle are always 1
                else
                    c = c * (i - j + 1) / j;  // Calculating binomial coefficient

                Console.Write("{0}   ", c);  // Displaying the current value of c in the triangle
            }
            Console.Write("\n");  // Moving to the next line for the new row
        }
    }
}