using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie1
{
    class PressureSensor : Sensor, IPressure
    {
        public int Pressure { get => Pressure; set => Pressure=value; }
    }
}
