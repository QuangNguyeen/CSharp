namespace HW3;

public class Cone: Round
{
    private double _height;

    public double Height
    {
        get => _height;
        set => _height = value;
    }

    public Cone (double radius, double height) : base(radius)
    {
        Height = height;
    }

    public double Volume()
    {
        return (1.0 / 3) * AreaRound() * Height;
    }
    
}