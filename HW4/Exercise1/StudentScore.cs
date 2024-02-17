namespace Exercise1;

public class StudentScore
{
    private string? _surnAndMiddleName;
    private string? _name;
    private string? _id;
    private double _processScore;
    private double _examFinalScore;
    //
    public string SurnAndMiddleName
    {
        get => _surnAndMiddleName;
        set => _surnAndMiddleName = value;
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public string Id
    {
        get => _id;
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

    public char GetMark(double processScoreCoefficient)
    {
        LetterGrade letterGrade;
        double finalScoreCoefficient = 100 - processScoreCoefficient;
        double overalSocre = (ProcessScore * processScoreCoefficient + finalScoreCoefficient * ExamFinalScore) / 100;
        if (overalSocre < 4)
        {
            letterGrade = LetterGrade.F;
        } else if (overalSocre < 5.5)
        {
            letterGrade = LetterGrade.D;
        } else if (overalSocre < 7)
        {
            letterGrade = LetterGrade.C;
        } else if (overalSocre < 8.5)
        {
            letterGrade = LetterGrade.B;
        }
        else
        {
            letterGrade = LetterGrade.A;
        }
        return Convert.ToChar(letterGrade);
    }

    public string GetMarkLine(double coeffiecient)
    {
        if (SurnAndMiddleName.Length < 20)
        {
            SurnAndMiddleName = SurnAndMiddleName.PadRight(20);
        }

        if (Name.Length < 10)
        {
            Name = Name.PadRight(10);
        }
        return $"S|{Id}|{SurnAndMiddleName}|{Name}|{ProcessScore}|{ExamFinalScore}|{GetMark(coeffiecient)}|";
    }
}