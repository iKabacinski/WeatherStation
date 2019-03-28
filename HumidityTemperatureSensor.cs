using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie1
{
    class HumidityTemperatureSensor : Sensor, ITemperature,IHumidity
    {
        public string Unit { get => Unit; set => value=Unit; }
        public float Temperature { get => Temperature; set => value=Temperature; }
        public int Humidity { get => Humidity; set => value=Humidity; }


    }
}
