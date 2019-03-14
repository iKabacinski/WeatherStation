using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie1
{
    class PressureSensor : Sensor, IPressure
    {
        public int MeasurePressure { get => MeasurePressure; set => value=MeasurePressure; }
    }
}
