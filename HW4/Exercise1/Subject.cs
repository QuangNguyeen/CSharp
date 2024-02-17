namespace Exercise1;

public class Subject
{
    private string? _idSubject;
    private string? _nameSubject;
    private double _processCoefficient;
    private double _examCoefficient;
    //
    public string IdSubject
    {
        get => _idSubject;
        set => _idSubject = value;
    }

    public string NameSubject
    {
        get => _nameSubject;
        set => _nameSubject = value;
    }

    public double ProcessCoefficient
    {
        get => _processCoefficient;
        set => _processCoefficient = value;
    }

    public double ExamCoefficient
    {
        get => _examCoefficient;
        set => _examCoefficient = value;
    }

    public void Input(string filePath)
    {
        try
        {
            if (File.Exists(filePath))
            {
                Subject newSubject = new Subject();
                Console.WriteLine("Enter Subject ID: ");
                newSubject.IdSubject = Console.ReadLine();
                Console.WriteLine("Enter Subject Name: ");
                newSubject.NameSubject = Console.ReadLine();
                Console.WriteLine("Enter Process Coefficient: ");
                newSubject.ProcessCoefficient = Convert.ToDouble(Console.ReadLine());
                newSubject.ExamCoefficient = 100 - newSubject.ProcessCoefficient;
                FileStream stream = new FileStream(filePath, FileMode.Open);
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.WriteLine($"SubjectID|{newSubject.IdSubject}");
                    writer.WriteLine($"Subject|{newSubject.NameSubject}");
                    writer.WriteLine($"F|{newSubject.ProcessCoefficient}|{newSubject.ExamCoefficient}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

}