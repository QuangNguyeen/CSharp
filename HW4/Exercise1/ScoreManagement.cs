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

    public static void AddNewScoreBoard()
    {
        try
        {
            Console.WriteLine("Enter New Subject ID: ");
            string? idSubject = Console.ReadLine();
            Console.WriteLine("Enter New Semester: ");
            string? semester = Console.ReadLine();
            StringBuilder partialName = new StringBuilder(idSubject + "_" + semester + "_rp");
            partialName.Append(".txt");
            DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(@"/Users/macbook/Documents/C#/HW4/Exercise1/DataScore");
            FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles("*" + partialName + "*.*");
            
            bool check = false;
            foreach (FileInfo foundFile in filesInDir)
            {
                if (partialName.Equals(foundFile.Name))
                {
                    check = true;
                    Console.WriteLine("Enter Another ID Subject and Semester. The File Already Exists.");
                    break;
                }
            }

            if (check == false)
            {
                string fullPath = Path.Combine(hdDirectoryInWhichToSearch.FullName, partialName.ToString());

                if (!File.Exists(fullPath))
                {
                    using (File.Create(fullPath)) { }

                    Console.WriteLine($"New Score Board for class '{idSubject} - {semester}' has been created successfully.");
                    ScoreBoard scoreBoard = new ScoreBoard(fullPath);
                    scoreBoard.Input(fullPath);
                }
                else
                {
                    Console.WriteLine($"Score Board for class '{idSubject}' already exists.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error Creating New Score Board: {ex.Message}");
        }
    }

public static void AddScore()
{
    Console.WriteLine("Enter ID Subject: ");
    string? idSubject = Console.ReadLine();
    Console.WriteLine("Enter Semester: ");
    string? semester = Console.ReadLine();
    StringBuilder partialName = new StringBuilder(idSubject + "_" + semester + "_rp");
    partialName.Append(".txt");
    DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(@"/Users/macbook/Documents/C#/HW4/Exercise1/DataScore");
    FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles("*" + partialName + "*.*");
    string filePath = Path.Combine(hdDirectoryInWhichToSearch.FullName, partialName.ToString());
    bool check = false;

    static int CountLinesFromLine(string filePath, int startLine)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException("File not found.", filePath);
        }

        int count = File.ReadLines(filePath).Skip(startLine - 1).Count();
        return count;
    }

    foreach (FileInfo foundFile in filesInDir)
    {
        if (partialName.ToString().Equals(foundFile.Name))
        {
            check = true;
            int numberOfLines = CountLinesFromLine(filePath, 6);
            // Kiểm tra nếu có đủ dòng
            if (File.ReadLines(filePath).Skip(4).Any())
            {
                string line = File.ReadLines(filePath).Skip(4).First();
                string[] parts = line.Split('|');
                int quantity = Convert.ToInt32(parts[1]);
                line = File.ReadLines(filePath).Skip(2).First();
                parts = line.Split('|');
                double processCoefficient = Convert.ToDouble(parts[1]);
                Console.WriteLine("Enter the number student to add Score: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (numberOfLines == 0 && number < quantity || numberOfLines != 0 && number < quantity - numberOfLines)
                {
                    // Mở tệp tin ở ngoài vòng lặp
                    using (var stream = new FileStream(filePath, FileMode.Append))
                    using (var writer = new StreamWriter(stream))
                    {
                        for (int i = 0; i < number; i++)
                        {
                            StudentScore student = new StudentScore();
                            student.Input();
                            writer.WriteLine(student.GetMarkLine(processCoefficient));
                        }
                    } // Đóng tệp tin khi hoàn thành ghi
                }
                else
                {
                    Console.WriteLine("Class is Full.");
                }
            }
            else
            {
                Console.WriteLine("File does not have enough lines.");
            }
        }
    }

    if (check == false)
    {
        Console.WriteLine("File Not Exist.");
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
                    AddScore();
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
