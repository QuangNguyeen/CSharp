namespace Exercise1;

public class StudentScore
{
    private string? _surnAndMiddleName;
    private string? _name;
    private string? _id;
    private double _processScore;
    private double _examFinalScore;

    private double _overallScore;
    //
    public string SurAndMiddleName
    {
        get => _surnAndMiddleName ?? throw new InvalidOperationException("Surname and MiddleName is invalid.");
        set => _surnAndMiddleName = value;
    }

    public string Name
    {
        get => _name ?? throw new InvalidOperationException("Student Name is invalid.");
        set => _name = value;
    }

    public string Id
    {
        get => _id ?? throw new InvalidOperationException("Student ID is invalid. ");
        set => _id = value;
    }

    public double ProcessScore
    {
        get => _processScore;
        set => _processScore = value;
    }

    public double ExamFinalScore
    {
        get => _examFinalScore;
        set => _examFinalScore = value;
    }
    public enum LetterGrade
    {
        A,B,C,D,F
    }

    public double GetOverallScore(double processScoreCoefficient)
    {
        double finalScoreCoefficient = 100 - processScoreCoefficient;
        double overallScore = (ProcessScore * processScoreCoefficient + finalScoreCoefficient * ExamFinalScore) / 100;
        return overallScore;
    }
    public LetterGrade GetMark(double processScoreCoefficient)
    {
        LetterGrade letterGrade;
        double finalScoreCoefficient = 100 - processScoreCoefficient;
        double overallScore = (ProcessScore * processScoreCoefficient + finalScoreCoefficient * ExamFinalScore) / 100;
        if (overallScore < 4)
        {
            letterGrade = LetterGrade.F;
            return letterGrade;
        } else if (overallScore < 5.5)
        {
            letterGrade = LetterGrade.D;
            return letterGrade;
        } else if (overallScore < 7)
        {
            letterGrade = LetterGrade.C;
            return letterGrade;
        } else if (overallScore < 8.5)
        {
            letterGrade = LetterGrade.B;
            return letterGrade;
        }
        else
        {
            letterGrade = LetterGrade.A;
            return letterGrade;
        }
    }

    public string GetMarkLine(double coefficient)
    {
        if (SurAndMiddleName.Length < 20)
        {
            SurAndMiddleName = SurAndMiddleName.PadRight(20);
        }

        if (Name.Length < 10)
        {
            Name = Name.PadRight(10);
        }
        return $"S|{Id}|{SurAndMiddleName}|{Name}|{ProcessScore.ToString().PadRight(3)}|" +
               $"{ExamFinalScore.ToString().PadRight(3)}|{GetMark(coefficient)}|";
    }
    
}