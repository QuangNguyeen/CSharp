namespace Exercise3;

public class Necklace : Item
{
    public override void SetRetailPrice()
    {
        RetailPrice = WholesalePrice * 1.5;
    }

    public override void Input()
    {
        base.Input();
        SetRetailPrice();
    }
    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Retail Price: {RetailPrice}");
    }
}