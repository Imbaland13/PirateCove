using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateCove
{
    internal class Program
    {
      
        static void Main(string[] args)
        {   
            Bus bus = new Bus();
            bus
            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToShortTimeString());
            Golfer golfer = new Golfer() 
            { 
                Name = "Süle" , StartLocation = Location.Germany, EndLocation = Location.Italy
            };
            Golfer golfer1 = new Golfer() 
            { 
                Name = "Süle",StartLocation = Location.Germany, EndLocation =Location.Italy 
            };
            Golfer golfer2 = new Golfer()
            {
                Name = "Ferhat", StartLocation = Location.Italy, EndLocation = Location.UK
            };
            Golfer golfer3 = new Golfer() 
            { 
                Name = "Naeem", StartLocation = Location.Italy, EndLocation = Location.Belgium
            };
            Golfer golfer4 = new Golfer() 
            { 
                Name = "Mathias", StartLocation =Location.Italy, EndLocation = Location.Belgium
            };
            Golfer golfer5 = new Golfer() 
            { 
                Name = "Max", StartLocation = Location.Ireland, EndLocation =Location.Belgium
            };
            Golfer golfer6 = new Golfer() 
            { 
                Name = "Steve1", StartLocation =Location.Ireland, EndLocation =Location.Italy
            };
            Golfer golfer7 = new Golfer() 
            { 
                Name = "Steve2", StartLocation = Location.Belgium, EndLocation =Location.Italy
            };
            Golfer golfer8 = new Golfer() 
            { 
                Name = "Steve3", StartLocation = Location.UK, EndLocation =Location.Germany
            };
            Golfer golfer9 = new Golfer() 
            { 
                Name = "Steve4", StartLocation=Location.Germany, EndLocation =Location.Ireland
            };
            Golfer golfer10 = new Golfer() 
            { 
                Name = "Steve5", StartLocation = Location.Germany, EndLocation = Location.UK
            };
            bus.SetGolfer(golfer1);
            bus.SetGolfer(golfer2);
            bus.SetGolfer(golfer3);
            bus.SetGolfer(golfer4);
            bus.SetGolfer(golfer5);
            bus.SetGolfer(golfer6);
            bus.SetGolfer(golfer7);
            bus.SetGolfer(golfer8);
            bus.SetGolfer(golfer9);
            bus.SetGolfer(golfer10);
            bus.PrintQueue();
        }
    }
}
