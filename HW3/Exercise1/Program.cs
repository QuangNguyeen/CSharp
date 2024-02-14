namespace HW3;

public class Program
{
    public static void Main(string[] args)
    {
        TruncatedCone temp = new TruncatedCone(2,6,9);
        Console.WriteLine(temp.Volume());
    }
}