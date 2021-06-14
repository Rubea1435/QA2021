namespace task4epam
{
    class TruckBuilder
    {
        public Truck Create()
        {
            Engine engine = new Engine(560, 10.5, EngineType.diesel, 33);
            Chassis chassis = new Chassis(6, 33, 40000);
            Transmission transmission = new Transmission(TransmissionType.automatic, 7, "Peterbilt");
            return new Truck(engine, chassis, transmission, 50000);
        }
    }
}
