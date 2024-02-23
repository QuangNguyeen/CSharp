using System.Text;
namespace Exercise1;

public class ScoreManagement
{
    enum Option
    {
        AddNewScoreBoard = 1,
        AddScore = 2,
        RemoveScore = 3,
        SearchScore = 4,
        DisplayScore = 5
    }

    private List<ScoreBoard> listScoreBoards = new List<ScoreBoard>();
    public static void DisplayMenu()
    {
        Console.WriteLine("Learning Management System");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("1. Add a new score board. ");
        Console.WriteLine("2. Add score. ");
        Console.WriteLine("3. Remove score. ");
        Console.WriteLine("4. Search score. ");
        Console.WriteLine("5. Display score board and score report. ");
        Console.WriteLine("Your choice (1-5, other number to quit):");
    }

    public static Subject AddNewSubject()
    {
        string? id;
        do
        {
            Console.WriteLine("Enter Subject ID: ");
            id = Console.ReadLine();
        } while (id.Length == 0);
        Console.WriteLine("Enter Subject Name: ");
        string? name = Console.ReadLine();
        Console.WriteLine("Enter Process Coefficient: ");
        double processCoefficient = Convert.ToDouble(Console.ReadLine());
        Subject subject = new Subject();
        subject.IdSubject = id;
        subject.NameSubject = name;
        subject.ProcessCoefficient = processCoefficient;
        subject.ExamCoefficient = 100 - processCoefficient;
        return subject;
    }
    public static void AddNewScoreBoard()
    {
        Subject subject = AddNewSubject();
        Console.WriteLine("Enter Semester: ");
        string? semester = Console.ReadLine();
        Console.WriteLine("Enter Quantity Student: ");
        int quantity = Convert.ToInt32(Console.ReadLine());
        ScoreBoard scoreBoard = new ScoreBoard(subject, semester, quantity);

    }
public static void Main(string[] args)
    {
        int choice;
        do
        {
            DisplayMenu();
            choice = Convert.ToInt32(Console.ReadLine());
            switch ((Option)choice)
            {
                case Option.AddNewScoreBoard:
                {
                    AddNewScoreBoard();
                    break;
                }
                case Option.AddScore:
                {
                   
                    break;
                }
                case Option.RemoveScore:
                {
                    
                    break;
                }
                case Option.SearchScore:
                {
                    break;
                }
                case Option.DisplayScore:
                {
                    break;
                }
            }
        } while (choice >= 1 && choice <= 5);
    }
}