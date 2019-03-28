﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public class Sensor
    {
        private static int number = 0;
        public static string sensor = "Sensor";
        Exception NameLengthException = new Exception("Za długa nazwa sensora");
        public string name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length > 16)
                {
                    throw NameLengthException;
                }
                else
                name = value;
            }
        }
        
        public Sensor()
        {

            this.name = sensor + number.ToString();
            number = number + 1;
        }

        
    }
}
