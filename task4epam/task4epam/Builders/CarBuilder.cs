namespace task4epam
{
    class CarBuilder
    {
        /// <summary>
        /// This builder is needed just to avoid passing plenty of parameters to Car constructor
        /// </summary>
        /// <returns></returns>
        public Car Create()
        {
            Engine engine = new Engine(120, 1.3, EngineType.Petrol, 100500);
            Chassis chassis = new Chassis(4, 104937, 1500);
            Transmission transmission = new Transmission(TransmissionType.Automatic, 8, "VW");
            return new Car(engine, chassis, transmission, 220);
        }
    }
}
