namespace Exercise2;

public class PassengerCarriage : Railcar
{
    private List<Passenger>? _listPassenger;
    private double _weightPassenger;
    public double WeightPassenger
    {
        get
        {
            if (_listPassenger == null)
                return OldWeight;
            foreach (var passenger in _listPassenger)
            {
                _weightPassenger += (passenger.Weight + passenger.Luggage);
            }

            return _weightPassenger;
        }
        set => _weightPassenger = value;
    }
    public PassengerCarriage()
    {
        _weightPassenger = 0;
        _listPassenger = new List<Passenger>();
    }
    public void AddPassenger()
    {
        var newPassenger = new Passenger();
        Console.WriteLine("Enter New Passenger ID: ");
        newPassenger.Id = Console.ReadLine();
        newPassenger.Luggage = Convert.ToDouble(Console.ReadLine());
        newPassenger.Weight = Convert.ToDouble(Console.ReadLine());
        
        // checkExist
        Boolean checkExist = false;
        if (_listPassenger != null)
        {
            foreach (var passenger in _listPassenger)
            {
                if (passenger.Id.Equals(newPassenger.Id))
                {
                    checkExist = true;
                }
            }
        }
        if (checkExist == false && _listPassenger != null)
        {
            _listPassenger.Add(newPassenger);
        }
    }

    public void RemovePassenger()
    {
        Console.WriteLine("Enter the passenger id who got off the Railcar: ");
        try
        {
            string id = Console.ReadLine();
            if (_listPassenger != null)
            {

                for (int i = 0; i < _listPassenger.Count; i++)
                {
                    // Assuming there is a property named PassengerId in the Passenger class
                    if (id != null)
                    {
                        if (id.Equals(_listPassenger[i].Id))
                        {
                            _listPassenger.RemoveAt(i);
                            Console.WriteLine($"Passenger with ID {id} has been removed.");
                            return; // Exit the method after removal
                        }
                    }
                }
            }

            Console.WriteLine($"Passenger with ID {id} not found in the Railcar.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    public void InputInformationPassenger()
    {
        Console.WriteLine("Enter the number of passengers currently on the carriage: ");
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < number; i++)
        {
            Passenger passenger = new Passenger();
            Console.WriteLine($"Passenger {i + 1}: ");
            Console.WriteLine("Enter ID of Passenger: ");
            passenger.Id = Console.ReadLine();
            Console.WriteLine("Enter Luggage of Passenger: ");
            passenger.Luggage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Weight of Passenger: ");
            passenger.Weight = Convert.ToDouble(Console.ReadLine());
            _listPassenger?.Add(passenger);
        }
    }
    public override double SumWeight()
    {
        return WeightPassenger + OldWeight;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Type: PassengerCarriage \t ID: {RailcarId} \t PassengerWeight: {WeightPassenger} \t SumWeight: {SumWeight()}");
    }
}