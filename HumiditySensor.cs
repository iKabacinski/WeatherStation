using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie1
{
    class HumiditySensor : Sensor, IHumidity
    {
        public int Humidity { get => Humidity; set => Humidity=value; }


    }
}
