using System;

namespace Exercise_2;

internal class Program
{
    public static void Main(string[] args)
    {
        SubjectController controller = new SubjectController();
        while (true)
        {
            controller.View.DisplayMenu();
            controller.ProcessChoice();
        }
    }
}
