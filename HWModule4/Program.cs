using HWModule4;

class Program
{
    static void Main()
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            Console.WriteLine("Select transport type:");
            Console.WriteLine("1 Car");
            Console.WriteLine("2 Motorcycle");
            Console.WriteLine("3 Truck");
            Console.WriteLine("4 Bus");
            Console.WriteLine("0 Exit");
            Console.Write("\nYour choice: ");

            string choice = Console.ReadLine();

            VehicleCreator creator = null;

            switch (choice)
            {
                case "1":
                    creator = CreateCar();
                    break;
                case "2":
                    creator = CreateMotorcycle();
                    break;
                case "3":
                    creator = CreateTruck();
                    break;
                case "4":
                    creator = CreateBus();
                    break;
                case "0":
                    continueProgram = false;
                    Console.WriteLine("Goodbye!");
                    continue;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }

            if (creator != null)
            {
                creator.Start();
            }
        }
    }

    static CarCreator CreateCar()
    {
        Console.Write("Enter car brand: ");
        string mark = Console.ReadLine();

        Console.Write("Enter model: ");
        string model = Console.ReadLine();

        Console.Write("Enter fuel type: ");
        string oilType = Console.ReadLine();

        return new CarCreator(mark, model, oilType);
    }

    static MotorcycleCreator CreateMotorcycle()
    {
        Console.Write("Enter motorcycle type: ");
        string type = Console.ReadLine();

        Console.Write("Enter the volume: ");
        string volume = Console.ReadLine();

        return new MotorcycleCreator(type, volume);
    }

    static TruckCreator CreateTruck()
    {
        Console.Write("Enter load capacity: ");
        int liftCapacity = int.Parse(Console.ReadLine());

        Console.Write("Enter number of axles: ");
        int axes = int.Parse(Console.ReadLine());

        return new TruckCreator(liftCapacity, axes);
    }

    static BusCreator CreateBus()
    {
        Console.Write("Enter passenger capacity: ");
        int capacity = int.Parse(Console.ReadLine());

        Console.Write("Enter body color: ");
        string color = Console.ReadLine();

        return new BusCreator(capacity, color);
    }
}