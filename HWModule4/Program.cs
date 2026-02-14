using HWModule4;

class Program
{
    static void Main()
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            Console.WriteLine("Выберите тип транспорта:");
            Console.WriteLine("1. Автомобиль");
            Console.WriteLine("2. Мотоцикл");
            Console.WriteLine("3. Грузовик");
            Console.WriteLine("0. Выход");
            Console.Write("\nВаш выбор: ");

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
                case "0":
                    continueProgram = false;
                    Console.WriteLine("До свидания!");
                    continue;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
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
        Console.Write("Введите марку автомобиля: ");
        string mark = Console.ReadLine();

        Console.Write("Введите модель: ");
        string model = Console.ReadLine();

        Console.Write("Введите тип топлива: ");
        string oilType = Console.ReadLine();

        return new CarCreator(mark, model, oilType);
    }

    static MotorcycleCreator CreateMotorcycle()
    {
        Console.Write("Введите тип мотоцикла: ");
        string type = Console.ReadLine();

        Console.Write("Введите объём двигателя: ");
        string volume = Console.ReadLine();

        return new MotorcycleCreator(type, volume);
    }

    static TruckCreator CreateTruck()
    {
        Console.Write("Введите грузоподъёмность: ");
        int liftCapacity = int.Parse(Console.ReadLine());

        Console.Write("Введите количество осей: ");
        int axes = int.Parse(Console.ReadLine());

        return new TruckCreator(liftCapacity, axes);
    }
}