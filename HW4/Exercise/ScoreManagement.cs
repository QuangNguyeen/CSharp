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

    public List<ScoreBoard> ListScoreBoards = new List<ScoreBoard>();
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

    public Subject AddNewSubject()
    {
        string? id;
        do
        {
            Console.WriteLine("Enter Subject ID: ");
            id = Console.ReadLine() ?? "";
        } while (id.Length == 0);
        Console.WriteLine("Enter Subject Name: ");
        string? name = Console.ReadLine();
        Console.WriteLine("Enter Process Coefficient: ");
        double processCoefficient = Convert.ToDouble(Console.ReadLine());
        Subject subject = new Subject();
        subject.IdSubject = id;
        subject.SubjectName = name ?? "subjectName";
        subject.ProcessCoefficient = processCoefficient;
        subject.ExamCoefficient = 100 - processCoefficient;
        return subject;
    }
    public void AddNewScoreBoard()
    {
        Subject subject = AddNewSubject();
        Console.WriteLine("Enter Semester: ");
        string semester = Console.ReadLine() ?? "semesterID";
        Console.WriteLine("Enter Quantity Student: ");
        int quantity = Convert.ToInt32(Console.ReadLine());
        ScoreBoard scoreBoard = new ScoreBoard(subject, semester, quantity);
        ListScoreBoards.Add(scoreBoard);
    }
    /*
     * Case 2: Add new score student and about information student
     * Update score file
     */
    public int GetIndexScoreBoard(string subjectId, string semester)
    {
        for (int i = 0; i < ListScoreBoards.Count; i++)
        {
            if (subjectId.Equals(ListScoreBoards[i].Course.IdSubject) && semester.Equals(ListScoreBoards[i].Semester))
            {
                return i;
            }
        }

        return -1;
    }
    public void AddNewScoreStudent()
    {
        Console.WriteLine("Enter Subject ID: ");
        string? subjectId = Console.ReadLine();
        Console.WriteLine("Enter Semester ID: ");
        string? semesterId = Console.ReadLine();
        if (subjectId != null && semesterId != null)
        {
            int index = GetIndexScoreBoard(subjectId, semesterId);
            if (index < 0)
            {
                Console.WriteLine($"The Database don't have {subjectId} on semester: {semesterId}");
            }
            else
            {
                ListScoreBoards[index].AddScoreStudent();
                ListScoreBoards[index].UpdateFile();
                
            }
        }
    }
    /*
     * Case 3: Remove student score
     * Update data score file
     */
    public void RemoveScoreStudent()
    {
        Console.WriteLine("Enter Subject ID: ");
        string? subjectId = Console.ReadLine();
        Console.WriteLine("Enter Semester ID: ");
        string? semesterId = Console.ReadLine();
        if (subjectId != null && semesterId != null)
        {
            int index = GetIndexScoreBoard(subjectId, semesterId);
            if (index < 0)
            {
                Console.WriteLine($"The Database don't have {subjectId} on semester: {semesterId}");
            }
            else
            {
                Console.WriteLine("Enter Student ID: ");
                string? studentId = Console.ReadLine();
                if (studentId != null)
                {
                    ListScoreBoards[index].EraseStudentScore(studentId);
                    ListScoreBoards[index].UpdateFile();
                }
            }
        } 
    }
    /*
     * Case 4: Search student score information
     */
    public void SearchStudentScore()
    {
        Console.WriteLine("Enter Subject ID: ");
        string? subjectId = Console.ReadLine();
        Console.WriteLine("Enter Semester ID: ");
        string? semesterId = Console.ReadLine();
        if (subjectId != null && semesterId != null)
        {
            int index = GetIndexScoreBoard(subjectId, semesterId);
            if (index < 0)
            {
                Console.WriteLine($"The Database don't have {subjectId} on semester: {semesterId}");
            }
            else
            {
                Console.WriteLine("Enter Student ID: ");
                string? studentId = Console.ReadLine();
                if (studentId != null)
                {
                    Console.WriteLine(ListScoreBoards[index].GetStudentScore(studentId));
                }
            }
        }
    }
    /*
     * Case 5: Display information about score board: Score And Score Report
     * Update all File
     */
    public void DisplayScoreBoard()
    {
        Console.WriteLine("Enter Subject ID: ");
        string? subjectId = Console.ReadLine();
        Console.WriteLine("Enter Semester ID: ");
        string? semesterId = Console.ReadLine();
        if (subjectId != null && semesterId != null)
        {
            int index = GetIndexScoreBoard(subjectId, semesterId);
            if (index < 0)
            {
                Console.WriteLine($"The Database don't have {subjectId} on semester: {semesterId}");
            }
            else
            {
                if (ListScoreBoards[index].CurrentStudent == 0)
                {
                    Console.WriteLine("Please enter student score information before use this function.");
                }
                else
                {
                    ListScoreBoards[index].UpdateFile();
                    ListScoreBoards[index].DisplayScore();
                    ListScoreBoards[index].CreateFileData();
                    
                }
            }
        }
    }
    public void System()
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
                    AddNewScoreStudent();
                    break;
                }
                case Option.RemoveScore:
                {
                    RemoveScoreStudent();
                    break;
                }
                case Option.SearchScore:
                {
                    SearchStudentScore();
                    break;
                }
                case Option.DisplayScore:
                {
                    DisplayScoreBoard();
                    break;
                }
            }
        } while (choice >= 1 && choice <= 5);
    }
}
