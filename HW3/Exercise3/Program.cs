namespace Exercise3;

public class Program
{
    public enum Choice
    {
        AddItem = 1,
        DisplayInformationItem = 2,
        SaleOff = 3
    }
    public enum TypeItem
    {
        Ring = 1,
        Necklace = 2,
        Other = 3
    }
    
    public static void DisplayMenu()
    {
        Console.WriteLine("Store Management System");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("1. Append new item");
        Console.WriteLine("2. Display the information of item");
        Console.WriteLine("3. Sale off");
        Console.WriteLine("Your choice (1-3, other to quit): ");
    }
    public static List<dynamic> ListItem = new List<dynamic>();

    public static void DisplayInformationItem(List<dynamic> ListItem)
    {
        foreach (var item in ListItem)
        {
            item.Display();
        }
    }
    public static void Main(string[] args)
    {
        do
        {
            DisplayMenu();
            int choice = Convert.ToInt32(Console.ReadLine());
            switch ((Choice)choice)
            {
                case Choice.AddItem:
                {
                    Console.WriteLine("Enter Type Of Item: ");
                    int type = Convert.ToInt32(Console.ReadLine());
                    switch ((TypeItem)type)
                    {
                        case TypeItem.Ring:
                        {
                            Ring newItem = new Ring();
                            newItem.Input();
                            ListItem.Add(newItem);
                            break;
                        }
                        case TypeItem.Necklace:
                        {
                            Necklace newItem = new Necklace();
                            newItem.Input();
                            ListItem.Add(newItem);
                            break;
                        }
                        case TypeItem.Other:
                        {
                            Other newItem = new Other();
                            newItem.Input();
                            ListItem.Add(newItem);
                            break;
                        }
                    }
                    break;
                }
                case Choice.DisplayInformationItem:
                {
                    DisplayInformationItem(ListItem);
                    break;
                }
                case Choice.SaleOff:
                {
                    double level;
                    Console.WriteLine("Enter the ID of the discounted item: ");
                    string id = Console.ReadLine();
                    Boolean checkExist = false;
                    foreach (var item in ListItem)
                    {
                        if (id != null)
                        {
                            if (id.Equals(item.ID))
                            {
                                checkExist = true;
                                do
                                {
                                    Console.WriteLine("Enter the discount level: ");
                                    level = Convert.ToDouble(Console.ReadLine()) / 100 ;
                                } while (level <= 0 || level >= 100);
                                Console.WriteLine($"NewPrice: {item.RetailPrice * (1-level)}");
                                break;
                            }
                        }
                    }

                    if (checkExist == false)
                    {
                        Console.WriteLine("Not Found Item.");
                    }
                    break;
                }
            }
        } while (true);
    }
}
