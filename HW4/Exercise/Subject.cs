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
    
}