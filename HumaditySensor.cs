using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie1
{
    class HumaditySensor : Sensor, IHumidity
    {
        public int MeasureHumidity { get => MeasureHumidity; set => MeasureHumidity=value; }
    }
}
