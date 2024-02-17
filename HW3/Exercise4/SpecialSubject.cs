namespace Exercise4;

public class SpecialSubject : Subject, ISpecialSubject, ISubject
{
    private double _surchargeTuition;
    private Program _program;
    public enum Program
    {
        SIE = 1,
        HEDSPI = 2,
        ICT = 3
    }

    public Program TypeProgram
    {
        get => _program;
        set => _program = value;
    }
    public double SurchargeTuition
    {
        get => _surchargeTuition;
        set
        {
            switch (_program)
            {
                case Program.SIE:
                {
                    _surchargeTuition = 50000 * CreditHours;
                    break;
                }
                case Program.HEDSPI:
                {
                    _surchargeTuition = 30000 * CreditHours;
                    break;
                }
                case Program.ICT:
                {
                    _surchargeTuition = 20000 * CreditHours;
                    break;
                }
            }
        }
    }

    public double GetSpecialFee()
    {
        return SurchargeTuition;
    }

    double ISubject.GetFee()
    {
        return Tuition + SurchargeTuition;
    }

    string ISubject.GetEnrolmentLine()
    {
        return $"{Id}  {Name.Substring(0, 20)}  {TypeProgram.ToString().Substring(0, 6)}  " +
               $"{CreditTuition}  {Tuition}  {SurchargeTuition}";
    }

    public override void Input()
    {
        base.Input();
        Console.WriteLine("Enter Type Of Education Program: ");
        // copy on stackoverflow
        if (int.TryParse(Console.ReadLine(), out int typeProgram))
        {
            if (Enum.IsDefined(typeof(Program), typeProgram))
            {
                TypeProgram = (Program)typeProgram;
            }
        }
    }
}