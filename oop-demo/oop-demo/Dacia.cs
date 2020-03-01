namespace oop_demo
{
    public sealed class Dacia : Car
    {
        public CarModelType Model { get; }

        public Dacia(Engine engine, string color, CarModelType model) : base(engine, color)
        {
            Model = model;
        }

        public override double GetPrice() =>
             (Model, engine.Type) switch
             {
                 (CarModelType.Duster, EngineType.Diesel) => 12000,
                 (CarModelType.Logan, EngineType.Diesel) => 9000,
                 (CarModelType.Logan, EngineType.Electric) => 16000,
                 (CarModelType.Duster, EngineType.Electric) => 20000,
                 _ => 0.0
             };

        public new string GetDescription() =>
            "This is a dacia car";
    }
}
