namespace Exercise2;

public class Program
{
    public enum Type
    {
        Railcar = 1,
        GoodsCarriage = 2,
        PassengerCarriage = 3
    }
    public enum Choice
    {
        AppendNewRailcar = 1,
        DisplayInformation = 2,
        PassengerGetsOf = 3,
        PassengerTakeTrain = 4
    }

    public static void DisplayMenu()
    {
         Console.WriteLine("Railcar Management System");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("1. Append new railcar");
         Console.WriteLine("2. Display the information of train");
         Console.WriteLine("3. Passenger gets off the train");
         Console.WriteLine("4. Passenger takes the train");
         Console.WriteLine("Your choice (1-4, other to quit):");
    }

    public static void DisplayInformationAllRailcar(List<Railcar> ListRailcar)
    {
        foreach (var railcar in ListRailcar)
        {
            railcar.DisplayInfo();
        }
    }
    public static List<Railcar> ListRailcar = new List<Railcar>();
    public static void Main(string[] args)
    {
        do
        {
            DisplayMenu();
            int choice = Convert.ToInt32(Console.ReadLine());
            switch ((Choice)choice)
            {
                case Choice.AppendNewRailcar:
                {
                    Console.WriteLine("Enter Type of New Railcar: ");
                    int type = Convert.ToInt32(Console.ReadLine());
                    switch ((Type)type)
                    {
                        case Type.Railcar:
                        {
                            Railcar newRailcar = new Railcar("id", 0);
                            Console.WriteLine("Enter ID of New RailCar: ");
                            newRailcar.RailcarId = Console.ReadLine();
                            Console.WriteLine("Enter Original Weight of Railcar: ");
                            newRailcar.OldWeight = Convert.ToDouble(Console.ReadLine());
                            ListRailcar.Add(newRailcar);
                            break;
                        }
                        case Type.GoodsCarriage:
                        {
                            GoodsCarriage newRailcar = new GoodsCarriage();
                            Console.WriteLine("Enter ID of New GoodsRailcar: ");
                            newRailcar.RailcarId = Console.ReadLine();
                            Console.WriteLine("Enter Original Weight of Railcar: ");
                            newRailcar.OldWeight = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter Weight of Goods: ");
                            newRailcar.GoodsWeight = Convert.ToDouble(Console.ReadLine());
                            ListRailcar.Add(newRailcar);
                            break;
                        }
                        case Type.PassengerCarriage:
                        {
                            PassengerCarriage newRailcar = new PassengerCarriage();
                            Console.WriteLine("Enter ID of New PassengerCarriage: ");
                            newRailcar.RailcarId = Console.ReadLine();
                            Console.WriteLine("Enter Original Weight of Railcar: ");
                            newRailcar.OldWeight = Convert.ToDouble(Console.ReadLine());
                            newRailcar.InputInformationPassenger();
                            ListRailcar.Add(newRailcar);
                            break;
                        }
                    }
                    break;
                }
                case Choice.DisplayInformation:
                {
                    DisplayInformationAllRailcar(ListRailcar);
                    break;
                }
            }
        } while (true);
    }
}