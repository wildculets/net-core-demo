using System;

namespace oop_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Dacia(new Engine(EngineType.Diesel),
                "dark gray",
                CarModelType.Logan);

            Car secondCar = new Dacia(new Engine(EngineType.Electric),
                "light blue",
                CarModelType.Duster);

            Console.WriteLine(car.GetDescription());
            Console.WriteLine(car.GetPrice());
            Console.WriteLine(car.GetPrice(1000));

            Console.WriteLine(secondCar.GetDescription());
            Console.WriteLine(secondCar.GetPrice());
            Console.WriteLine(secondCar.GetPrice(1000));

        }
    }
}
