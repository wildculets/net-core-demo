namespace oop_demo
{
    public abstract class Car
    {
        protected readonly Engine engine;

        public string Color { get; }

        public Car(Engine engine, string color) =>
            (this.engine, Color) = (engine, Color);

        public abstract double GetPrice();

        public double GetPrice(double startingPrice) =>
            startingPrice + GetPrice();

        public string GetDescription() =>
            "This is a basic car.";
    }
}
