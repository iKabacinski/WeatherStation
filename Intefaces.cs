using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie1
{
    interface ITemperature
    {
        string Unit
        {
            set;
            get;
        }
        float Temperature
        {
            set;
            get;
        }

    }
    interface IHumidity
    {
        int Humidity
        {
            set;
            get;
        }

    }
    interface IPressure
    {
        int Pressure
        {
            set;
            get;
        }
    }
}
