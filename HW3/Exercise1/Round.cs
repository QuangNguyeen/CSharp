namespace HW3;

public class Round
{
    private double _radius;

    public double Radius
    {
        get => _radius;
        set => _radius = value;
    }
    public Round(){}

    public Round(double banKinh)
    {
        Radius = banKinh;
    }

    public double Perimeter()
    {
        return 2 * Math.PI * Radius;
    }

    public double AreaRound()
    {
        return Radius * Radius * Math.PI;
    }
}