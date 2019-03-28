using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Zadanie1
{
    class WeatherStation
    {
        Random rand = new Random();

        public List<Sensor> sensory = new List<Sensor>();

        public void addPressureSensor()
        {
            PressureSensor sensor = new PressureSensor();
            sensor.Pressure = rand.Next(950, 1050);
            sensory.Add(sensor);

        }
        public void addTemperatureSensor()
        {
            TemperatureSensor sensor = new TemperatureSensor();
            sensor.Unit = "C";
            sensor.Temperature = rand.Next(-30,30);
            sensory.Add(sensor);

        }
        public void addHumaditySensor()
        {
            HumiditySensor sensor = new HumiditySensor();
            sensor.Humidity = rand.Next(1000, 1100);
            sensory.Add(sensor);

        }
        public void addHumadityTemperatureSensor()
        {
            HumidityTemperatureSensor sensor = new HumidityTemperatureSensor();
            sensor.Humidity = rand.Next(950, 1050);
            sensor.Temperature = rand.Next(-30, 30);
            sensor.Unit = "C";
            sensory.Add(sensor);

        }




    }
}