using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{

    class Program
    {
        WeatherStation weatherStation = new WeatherStation();
        int wybor;

        static void Main(string[] args)
        {
            Program a = new Program();
           
            
                a.printInstruction();
                Console.WriteLine("Podaj Liczbe");
                Int32.TryParse(Console.ReadLine(), out a.wybor);
       
                switch (a.wybor)
                {
                    case 1:
                        a.addMenu();
                        break;
                    case 2:
                        a.readMenu();
                        break;
                    case 3:
                        a.searchMenu();
                        break;
                    case 4:
                        a.saveAll;
                        break;
         
                }
  

        private void printInstruction()
        {
            Console.Clear();
            Console.WriteLine("1:   Dodawanie");
            Console.WriteLine("2:   Odczyt");
            Console.WriteLine("3:   Wyszukaj");
            Console.WriteLine("4:   Zapisz");
            Console.WriteLine("5:   Wyjdz");
        }
    }
}

