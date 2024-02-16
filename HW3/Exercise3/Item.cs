using Console = System.Console;

namespace Exercise3;

public class Item
{
    private string? _id;
    private string? _description;
    private string? _material;
    private double _wholesalePrice;
    private double _retailPrice;
    //
    public string ID
    {
        get => _id;
        set => _id = value;
    }

    public string Description
    {
        get => _description;
        set => _description = value;
    }

    public string Material
    {
        get => _material;
        set => _material = value;
    }

    public double WholesalePrice
    {
        get => _wholesalePrice;
        set => _wholesalePrice = value;
    }

    public double RetailPrice
    {
        get => _retailPrice;
        set => _retailPrice = value;
    }

    public virtual void SetRetailPrice(){}

    public virtual void Input()
    {
        Console.WriteLine("Enter ID Item: ");
        ID = Console.ReadLine();
        Console.WriteLine("Enter Description: ");
        Description = Console.ReadLine();
        Console.WriteLine("Enter The Material Of Item: ");
        Material = Console.ReadLine();
        Console.WriteLine("Enter Wholesale Price: ");
        WholesalePrice = Convert.ToDouble(Console.ReadLine());
    }

    public virtual void Display()
    {
        Console.WriteLine($"ID: {ID} \t Description: {Description} \t Material: {Material} \t Wholsale Price: {WholesalePrice}");
    }
}