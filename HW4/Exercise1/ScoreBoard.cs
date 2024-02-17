namespace Exercise1;

public class ScoreBoard
{
    private Subject? _subject;
    private List<StudentScore>?_listStudent;
    private string? _semester;
    private int _quantityStudent;
    // 
    public Subject Cousre
    {
        get => _subject;
        set => _subject = value;
    }
    public List<StudentScore>? ListStudent
    {
        get => _listStudent;
        set => _listStudent = value;
    }

    public string Semester
    {
        get => _semester;
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
            Input(filePath);
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
            string Line = File.ReadLines(filePath).First();
            string[] parts = Line.Split('|');
            Cousre.IdSubject = parts[1];
            
            Line = File.ReadLines(filePath).Skip(1).First();
            parts = Line.Split('|');
            Cousre.NameSubject = parts[1];

            Line = File.ReadLines(filePath).Skip(2).First();
            parts = Line.Split('|');
            Cousre.ProcessCoefficient = Convert.ToDouble(parts[1]);

            Cousre.ExamCoefficient = 100 - Cousre.ProcessCoefficient;

            Line = File.ReadLines(filePath).Skip(3).First();
            parts = Line.Split('|');
            Semester = parts[1];

            Line = File.ReadLines(filePath).Skip(4).First();
            parts = Line.Split('|');
            QuantityStudent = Convert.ToInt32(parts[1]);

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }
    }

    public void Input(string filePath)
    {
        Cousre.Input(filePath);
        Console.WriteLine("Enter Semester: ");
        Semester = Console.ReadLine();
        Console.WriteLine("Enter Quantity Students: ");
        QuantityStudent = Convert.ToInt32(Console.ReadLine());
        FileStream stream = new FileStream(filePath, FileMode.Open);
        using (StreamWriter writer = new StreamWriter(stream))
        {
            writer.WriteLine($"Semester|{Semester}");
            writer.WriteLine($"StudentCount|{QuantityStudent}");
        }
        
    }
}