namespace task4epam
{
    public class ScooterBuilder
    {
        /// <summary>
        /// This builder is needed just to avoid passing plenty of parameters to Scooter constructor
        /// </summary>
        /// <returns></returns>
        public Scooter Create()
        {
            Engine engine = new Engine(5, 0.05, EngineType.Petrol, 1);
            Chassis chassis = new Chassis(2, 2, 200);
            Transmission transmission = new Transmission(TransmissionType.Variator, 1, "Honda");
            return new Scooter(engine, chassis, transmission, 400);
        }
    }
}
