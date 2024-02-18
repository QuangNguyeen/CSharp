namespace Exercise1;

public class ScoreBoard
{
    private Subject? _subject;
    private List<StudentScore>?_listStudent;
    private string? _semester;
    private int _quantityStudent;
    // 
    public Subject Course
    {
        get => _subject ?? throw new InvalidOperationException("Subject is not initialized."); 
        set => _subject = value;
    }
    
    public List<StudentScore>? ListStudent
    {
        get => _listStudent;
        set => _listStudent = value;
    }
    
    public string Semester
    {
        get => _semester ?? throw new InvalidOperationException("Semester is not initialized.");
        set => _semester = value;
    }

    public int QuantityStudent
    {
        get => _quantityStudent;
        set => _quantityStudent = value;
    }
    // Constructor
    public ScoreBoard(string filePath)
    {
        Course = new Subject();
        if (File.Exists(filePath))
        {
            ReadFormFile(filePath);
        }
        else
        {
            CreatFile(filePath);
        }
    }

    private void CreatFile(string filePath)
    {
        try
        {
            using (var newFile = new FileStream(filePath, FileMode.CreateNew));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error creating file: {ex.Message}");
        }
    }
    private void ReadFormFile(string filePath)
    {
        try
        {
            FileInfo info = new FileInfo(filePath);
            if (info.Length != 0)
            {
                string line = File.ReadLines(filePath).First();
                string[] parts = line.Split('|');
                Course.IdSubject = parts[1];
            
                line = File.ReadLines(filePath).Skip(1).First();
                parts = line.Split('|');
                Course.NameSubject = parts[1];

                line = File.ReadLines(filePath).Skip(2).First();
                parts = line.Split('|');
                Course.ProcessCoefficient = Convert.ToDouble(parts[1]);

                Course.ExamCoefficient = 100 - Course.ProcessCoefficient;

                line = File.ReadLines(filePath).Skip(3).First();
                parts = line.Split('|');
                Semester = parts[1];

                line = File.ReadLines(filePath).Skip(4).First();
                parts = line.Split('|');
                QuantityStudent = Convert.ToInt32(parts[1]);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }
    }

    public void Input(string filePath)
    {
        Course.Input(filePath);
        Console.WriteLine("Enter Semester: ");
        string? semester = Console.ReadLine();
        Semester = semester ?? "000000";                // default is 000000
        Console.WriteLine("Enter Quantity Students: ");
        QuantityStudent = Convert.ToInt32(Console.ReadLine());
        ScoreBoard.UpdateFileData(this,filePath);
    }
    public static void UpdateFileData(ScoreBoard newScoreBoard, string filePath)
    {
        Subject.UpdateFileData(newScoreBoard.Course,filePath);
        var stream = new FileStream(filePath, FileMode.Append);
        using (var writer = new StreamWriter(stream))
        {
            writer.WriteLine($"Semester|{newScoreBoard.Semester}");
            writer.WriteLine($"StudentCount|{newScoreBoard.QuantityStudent}");
        }
    }
}
