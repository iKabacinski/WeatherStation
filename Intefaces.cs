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
        float MeasureTemperature
        {
            set;
            get;
        }

    }
    interface IHumidity
    {
        int MeasureHumidity
        {
            set;
            get;
        }
    }
    interface IPressure
    {
        int MeasurePressure
        {
            set;
            get;
        }
    }
}
