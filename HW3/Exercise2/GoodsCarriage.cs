namespace Exercise2;

public class GoodsCarriage : Railcar
{
    private double _goodsWeight;

    public double GoodsWeight
    {
        get => _goodsWeight;
        set => _goodsWeight = value;
    }
    public override double SumWeight()
    {
        return OldWeight + GoodsWeight;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Type: GoodsCar \t \t \t ID: {RailcarId} \t GoodsWeight: {GoodsWeight} \t SumWeight: {SumWeight()}");
    }
}