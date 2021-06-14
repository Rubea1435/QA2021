namespace task4epam
{
    class CarBuilder
    {
        public Car Create()
        {
            Engine engine = new Engine(120, 1.3, EngineType.petrol, 100500);
            Chassis chassis = new Chassis(4, 104937, 1500);
            Transmission transmission = new Transmission(TransmissionType.automatic, 8, "VW");
            return new Car(engine, chassis, transmission, 220);
        }
    }
}
