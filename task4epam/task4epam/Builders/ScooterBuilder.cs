namespace task4epam
{
    class ScooterBuilder
    {
        public Scooter Create()
        {
            Engine engine = new Engine(5, 0.05, EngineType.petrol, 1);
            Chassis chassis = new Chassis(2, 2, 200);
            Transmission transmission = new Transmission(TransmissionType.variator, 1, "Honda");
            return new Scooter(engine, chassis, transmission, 400);
        }
    }
}
