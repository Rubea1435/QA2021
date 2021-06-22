namespace task4epam
{
    class BusBuilder
    {
        /// <summary>
        /// This builder is needed just to avoid passing plenty of parameters to Bus constructor 
        /// </summary>
        /// <returns></returns>
        public Bus Create()
        {
            Engine engine = new Engine(480, 8.9, EngineType.Diesel, 1435);
            Chassis chassis = new Chassis(4, 3514, 5000);
            Transmission transmission = new Transmission(TransmissionType.Manual, 6, "Scania");
            return new Bus(engine, chassis, transmission, 33);
        }
    }
}
