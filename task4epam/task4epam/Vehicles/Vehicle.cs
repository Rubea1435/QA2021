namespace task4epam
{
    abstract class Vehicle
    {
        public Engine Engine { get; }
        public Chassis Chassis { get; }
        public Transmission Transmission { get; }

        public Vehicle(Engine engine, Chassis chassis, Transmission transmission)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
        }

        public abstract string GetFullInfo();
    }
}
