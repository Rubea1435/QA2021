namespace task4epam
{
    public class TruckBuilder
    {
        /// <summary>
        /// This builder is needed just to avoid passing plenty of parameters to Truck constructor
        /// </summary>
        /// <returns></returns>
        public Truck Create()
        {
            Engine engine = new Engine(560, 10.5, EngineType.Diesel, 33);
            Chassis chassis = new Chassis(6, 33, 40000);
            Transmission transmission = new Transmission(TransmissionType.Automatic, 7, "Peterbilt");
            return new Truck(engine, chassis, transmission, 50000);
        }
    }
}
