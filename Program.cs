using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{

    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                Sensor s = new Sensor();
                System.Console.WriteLine(s.name);

                Sensor s1 = new Sensor();
                System.Console.WriteLine(s1.name);

                Sensor s2 = new Sensor();
                System.Console.WriteLine(s2.name);
            }catch(Exception NameLengthException)
            {
                Console.WriteLine(NameLengthException.ToString());

            }

        }
    }
}

