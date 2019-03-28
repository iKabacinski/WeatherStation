using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie1
{
    class TemperatureSensor : Sensor, ITemperature
    {
        private Exception BadUnitException = new Exception("ZŁa wartość pomiarowa");

        public float Temperature { get => Temperature; set => value=Temperature; }
        public string Unit { get => Unit; set => Unit=value; }

    }
}
