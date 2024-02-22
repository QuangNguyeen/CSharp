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

   public static void UpdateDataToFile(ScoreBoard scoreBoard,string filePath)
    {
        try
        {
            string line = File.ReadLines(filePath).Skip(2).First();
            string[] parts = line.Split('|');
            double coefficient = Convert.ToDouble(parts[1]);
            using (FileStream stream = new FileStream(filePath, FileMode.Append))
            using (StreamWriter writer = new StreamWriter(stream))
            {
                if (scoreBoard.ListStudent != null)
                {
                    foreach (var score in scoreBoard.ListStudent)
                    {
                        writer.WriteLine(score.GetMarkLine(coefficient));
                    }                    
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error in update date: {ex.Message}");
        }
    }

    static string SearchScoreBoard(string id, string semester)
    {
        string directoryPath = "/Users/macbook/Documents/C#/HW4/Exercise1/DataScore/";
        string partialName = $"{id}_{semester}_rp.txt";
        DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(directoryPath);
        FileInfo[] listFiles = hdDirectoryInWhichToSearch.GetFiles("*" + partialName + "*.*");
        string filePath = Path.Combine(hdDirectoryInWhichToSearch.FullName, partialName.ToString());
        foreach (var file in listFiles)
        {
            if (partialName.Equals(file.Name))
            {
                return filePath;
            }
        }

        return string.Empty;
    }

    public static void AddNewScoreBoard()
    {
        try
        {
            Console.WriteLine("Enter New Subject ID: ");
            string? newid = Console.ReadLine() ?? "defaultID";
            Console.WriteLine("Enter New Semester: ");
            string? newSemester = Console.ReadLine() ?? "defaultSemester";
            // check exist
            string filePath = SearchScoreBoard(newid, newSemester);
            if (filePath == string.Empty)
            {
                filePath = $"/Users/macbook/Documents/C#/HW4/Exercise1/DataScore/{newid}_{newSemester}_rp.txt";
            }
            ScoreBoard scoreBoard = new ScoreBoard(filePath);
            scoreBoard.Input(filePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error in create new Score Board: {ex.Message}");
        }
    } 
    static int CountLinesFromLine(string filePath, int startLine)
    {
        if (filePath == string.Empty)
        {
            throw new FileNotFoundException("File not found.", filePath);
        }

        int count = File.ReadLines(filePath).Skip(startLine - 1).Count();
        return count;
    }
 public static void AddStudentScore()
 {
     try
     {
         Console.WriteLine("Enter Subject ID: ");
         string idSubject = Console.ReadLine() ?? "defaultID";
         Console.WriteLine("Enter Semester: ");
         string semester = Console.ReadLine() ?? "defaultSemester";
         string filePath = SearchScoreBoard(idSubject, semester);
         if (!string.IsNullOrEmpty(filePath))
         {
             ScoreBoard scoreBoard = new ScoreBoard(filePath);
             scoreBoard.ListStudent = new List<StudentScore>();
             int numberOfLines = CountLinesFromLine(filePath, 6);
             int quantity = scoreBoard.QuantityStudent;
             Console.WriteLine($"Can add {quantity - numberOfLines} Student Score.");
             Console.WriteLine("Enter the number student to add Score: ");
             int number = Convert.ToInt32(Console.ReadLine());
             
             // check quantity student in file
             if (numberOfLines == 0 && number < quantity || numberOfLines != 0 && number < quantity - numberOfLines)
             {
                 {
                     for (var i = 0; i < number; i++)
                     {
                         StudentScore student = new StudentScore();
                         student.Input();
                         if (scoreBoard.ListStudent != null)
                         {
                             scoreBoard.ListStudent.Add(student);
                         }
                     }
                     UpdateDataToFile(scoreBoard,filePath);
                 }
             }
             else
             {
                 Console.WriteLine("The class is full or there are not enough seats.");
             }
         }
         else
         {
             Console.WriteLine("File not found. Unable to add scores.");
         }
     }
     catch (Exception ex)
     {
         Console.WriteLine($"Error in Add Score Student: {ex.Message}");
     }
}

 public static void RemoveStudentScore()
 {
     try
     {
         Console.WriteLine("Enter Subject ID: ");
         string idSubject = Console.ReadLine() ?? "defaultID";
         Console.WriteLine("Enter Semester: ");
         string semester = Console.ReadLine() ?? "defaultSemester";
         string filePath = SearchScoreBoard(idSubject, semester);
         if (filePath != string.Empty)
         {
             ScoreBoard scoreBoard = new ScoreBoard(filePath);
             Console.WriteLine("Enter Student ID: ");
             string? id = Console.ReadLine();
             if (scoreBoard.ListStudent != null)
             {
                 int quantity = scoreBoard.ListStudent.Count;
                 for (int i = 0; i < quantity; i++)
                 {
                     if (id != null && id.Equals(scoreBoard.ListStudent[i].Id))
                     {
                         scoreBoard.ListStudent.RemoveAt(i);
                     }
                 }
             }
             UpdateDataToFile(scoreBoard,filePath);
         }
     }
     catch (Exception ex)
     {
         Console.WriteLine($"Error in remove Student Score: {ex.Message}");
     }
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
                    AddStudentScore();
                    break;
                }
                case Option.RemoveScore:
                {
                    RemoveStudentScore();
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
