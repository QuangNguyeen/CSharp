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
        get => _idSubject ?? throw new InvalidOperationException("Subject ID is invalid.");
        set => _idSubject = value;
    }

    public string NameSubject
    {
        get => _nameSubject ?? throw new InvalidOperationException("Subject Name is invalid.");
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
                Console.WriteLine("Enter Subject ID: ");
                string? id  = Console.ReadLine();
                IdSubject = id ?? "000000";          // default is 000000
                Console.WriteLine("Enter Subject Name: ");
                string? name = Console.ReadLine();
                NameSubject = name ?? "defaultName"; // default is defaultName
                Console.WriteLine("Enter Process Coefficient: ");
                ProcessCoefficient = Convert.ToDouble(Console.ReadLine());
                ExamCoefficient = 100 - ProcessCoefficient;
                UpdateFileData(this,filePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        
    }

    public static void UpdateFileData(Subject newSubject, string filePath)
    {
        try
        {
            var stream = new FileStream(filePath, FileMode.OpenOrCreate);
            using (var writer = new StreamWriter(stream))
            {
                writer.WriteLine($"SubjectID|{newSubject.IdSubject}");
                writer.WriteLine($"Subject|{newSubject.NameSubject}");
                writer.WriteLine($"F|{newSubject.ProcessCoefficient}|{newSubject.ExamCoefficient}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error updating data in file: {ex.Message}");
        }
    }
}
