namespace Exercise2;

public class Railcar
{
    private string _railcarId;
    private double _oldWeight;

    public Railcar(string railcarId, double oldWeight)
    {
        _railcarId = railcarId;
        _oldWeight = oldWeight;
    }

    public Railcar()
    {
        _railcarId = "id";
    }
    public string RailcarId
    {
        get => _railcarId;
        set => _railcarId = value;
    }

    public double OldWeight
    {
        get => _oldWeight;
        set => _oldWeight = value;
    }

    public virtual double SumWeight()
    {
        return OldWeight;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Type: Railcar \t \t \t ID: {RailcarId} \t Weight: {OldWeight}");
    }
}