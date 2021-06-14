﻿namespace task4epam
{
    class BusBuilder
    {
        public Bus Create()
        {
            Engine engine = new Engine(480, 8.9, EngineType.diesel, 1435);
            Chassis chassis = new Chassis(4, 3514, 5000);
            Transmission transmission = new Transmission(TransmissionType.manual, 6, "Scania");
            return new Bus(engine, chassis, transmission, 33);
        }
    }
}
