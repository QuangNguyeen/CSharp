
namespace Exercise4;

public class Subject : ISubject
{
    private string? _id;
    private string? _name;
    private int _creditHours;
    private int _creditPractice;
    private int _creditTuition;
    private double _tuition;
    //
    public string Id
    {
        get => _id;
        set
        {
            if (value.Length == 6)
            {
                _id = value;
            }
            else
            {
                Console.WriteLine("Invalid Subject ID.");
            }
        }
    }

    public string Name
    {
        get => _name;
        set
        {
            if (value.Length <= 40)
            {
                _name = value;
            }
            else
            {
                Console.WriteLine("Invalid Subject Name");
            }
        }
    }

    public int CreditHours
    {
        get => _creditHours;
        set
        {
            if (value > 0)
            {
                _creditHours = value;
            }
            else
            {
                Console.WriteLine("Invalid Subject Credit Hours. ");
            }
        }
    }

    public int CreditPractice
    {
        get => _creditPractice;
        set
        {
            if (value > 0)
            {
                _creditPractice = value;
            }
            else
            {
                Console.WriteLine("Invalid Subject Credit Practice. ");
            }
        }
    }

    public int CreditTuition
    {
        get => _creditTuition;
        set => _creditTuition = _creditPractice + _creditHours;
    }

    public double Tuition
    {
        get => _tuition;
        set => _tuition = value;
    }

    public double GetFee()
    {
        return Tuition;
    }

    public string GetEnrolmentLine()
    {
        if (Name.Length > 20)
        {
            Name = Name.Substring(0, 20);
        }
        return $"{Id}  {Name}  {CreditTuition}  {Tuition}";
    }

    public virtual void Input()
    {
        Console.WriteLine("Enter Subject ID: ");
        Id = Console.ReadLine();
        Console.WriteLine("Enter Subjject Name: ");
        Name = Console.ReadLine();
        Console.WriteLine("Enter The Number of Credit Hours of The Subject: ");
        CreditHours = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter The Number of Credit Practice of The Subject: ");
        CreditPractice = Convert.ToInt32(Console.ReadLine());
        CreditTuition = CreditHours + CreditPractice;
        Tuition = CreditTuition * 500000;
    }
}