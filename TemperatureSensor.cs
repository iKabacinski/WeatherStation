using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie1
{
    class TemperatureSensor : Sensor, ITemperature
    {
        private Exception BadUnitException = new Exception("ZŁa wartość pomiarowa");

        public float MeasureTemperature { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Unit { get => Unit; set => value=Unit; }
    }
}
