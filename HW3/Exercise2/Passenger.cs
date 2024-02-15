namespace Exercise2;

public class Passenger
{
    private string _id = string.Empty;
    private double _luggage;
    private double _weight;

    public string Id
    {
        get => _id;
        set => _id = value;
    }

    public double Luggage
    {
        get => _luggage;
        set => _luggage = value;
    }

    public double Weight
    {
        get => _weight;
        set => _weight = value;
    }

    public void Input()
    {
        Console.WriteLine("Enter ID of Passenger: ");
        Id = Console.ReadLine();
        Console.WriteLine("Enter Luggage of Passenger: ");
        Luggage = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Weight of Passenger: ");
        Weight = Convert.ToDouble(Console.ReadLine());
    }
}