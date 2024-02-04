using System;
internal class Exercise9
{
    public static void Main(string[] args)
    {
        List<string> listStudent = new List<string>();
        Console.WriteLine("Enter the number students: ");
        int n = Convert.ToInt32(Console.ReadLine());
        // input
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter name students: ");
            string name = Console.ReadLine();
            listStudent.Add(name);
        }
        // output
        foreach (var name in listStudent)
        {
            Console.WriteLine(name);
        }
        
        // find name student;
        Console.WriteLine("Enter name student to find: ");
        string findName = Console.ReadLine();
        foreach (var name in listStudent)
        {
            if (name.Equals(findName))
            {
                Console.WriteLine("Name student is exist");
                break;
            }
        }
    }
}
    


