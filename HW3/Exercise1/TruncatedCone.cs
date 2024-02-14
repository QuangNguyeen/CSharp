namespace HW3;

public class TruncatedCone
{
    private readonly Cone _upperCone;
    private readonly Cone _lowerCone;
    private readonly double _slantHeight;

    private double height;
    public TruncatedCone(double smallR,double bigR ,double h)
    {
        height = h;
        _slantHeight = Math.Sqrt(Math.Pow(h, 2) + Math.Pow(bigR - smallR, 2));
        _upperCone = new Cone(smallR, h * smallR / (bigR - smallR));
        _lowerCone = new Cone(bigR, h * smallR / (bigR - smallR) + h);

    }
    public double LateralSurfaceArea()
    {
        return Math.PI * (_upperCone.Radius + _lowerCone.Radius) * _slantHeight;
    }

    public double SurfaceArea()
    {
        return LateralSurfaceArea() + _upperCone.AreaRound() + _lowerCone.AreaRound();
    }

    public double Volume()
    {
        return Math.Abs(_lowerCone.Volume() - _upperCone.Volume());
    }
}