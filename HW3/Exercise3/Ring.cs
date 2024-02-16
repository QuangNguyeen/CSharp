namespace Exercise3;

public class Ring : Item
{
    public override void SetRetailPrice()
    {
        RetailPrice = WholesalePrice * 1.2;
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