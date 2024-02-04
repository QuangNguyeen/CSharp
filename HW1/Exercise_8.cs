using System;
using System.Text.RegularExpressions;
internal class Exercise8
{   
    // using regular expression
    public static int CountWordUsingRegular(string inputString)
    {
        var wordCount = Regex.Matches(inputString, @"\b\w+\b").Count;
        return wordCount;
    }
    // using Algorithm;
    public static int CountWordUsingAlgorithm(string inputString)
    {
        int wordCount = 0;
        bool isPreviousCharSpace = true;
        foreach (var character in inputString)
        {
            if (character == ' ')
            {
                isPreviousCharSpace = true;
            } else if (isPreviousCharSpace)
            {
                wordCount++;
                isPreviousCharSpace = false;
            }
        }
        return wordCount;
    }

    public static void CountCharacter(string inputString)
    {
        string S = inputString.Replace(" ", String.Empty);
        while (S.Length > 0)
        {
            Console.Write($"{S[0]} : " );
            int count = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (S[0] == S[i])
                {
                    count++;
                }
            }
            Console.WriteLine(count + " time");
            S = S.Replace(S[0].ToString(), String.Empty);
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the string: ");
        string inputString = Console.ReadLine();
        Console.WriteLine("Number words count by Regular: " + CountWordUsingRegular(inputString));
        Console.WriteLine("Number words count by Algorithm: " + CountWordUsingAlgorithm(inputString));
        CountCharacter(inputString);
    }
}