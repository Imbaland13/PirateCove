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
            Bus bus1 = new Bus() { Location = Location.Italy , Name = "Bus1"};
            Bus bus2 = new Bus() { Location = Location.Germany, Name = "Bus2"};
            Bus bus3 = new Bus() { Location = Location.Ireland, Name = "Bus3"};
            Bus bus4 = new Bus() { Location = Location.Belgium, Name = "Bus4"};
            List<Bus> busList = new List<Bus>
            {
                bus1,
                bus2,
                bus3,
                bus4
            };
            PiratesCoveUK piratesCoveUK = new PiratesCoveUK() 
            { 
                Location = Location.UK, Name= "pirateCoveUK" 
            };
            PiratesCoveBelgium piratesCoveBelgium = new PiratesCoveBelgium() 
            { 
                Location = Location.Belgium, 
                Name = "pirateCoveBelgium" 
            };
            PiratesCoveIreland piratesCoveIreland = new PiratesCoveIreland() 
            { 
                Location = Location.Ireland,
                Name = "pirateCoveIreland"
            };
            PiratesCovesGermany piratesCovesGermany = new PiratesCovesGermany() 
            { 
                Location = Location.Germany,
                Name = "pirateCoveGermany"
            };
            PiratesCovesItaly piratesCovesItaly = new PiratesCovesItaly() 
            { 
                Location = Location.Italy,
                Name = "pirateCoveItaly"
            };
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
            foreach (var bus in busList)
            {
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
            }
            bus1.BusToDestination(piratesCovesItaly, piratesCoveUK);
            bus2.BusToDestination(piratesCovesGermany, piratesCoveBelgium);
            bus3.BusToDestination(piratesCoveIreland, piratesCovesGermany);
            piratesCoveBelgium.PrintBusses();
            piratesCoveBelgium.PrintGolfer();
            piratesCoveIreland.PrintBusses();
            piratesCoveIreland.PrintGolfer();
            piratesCoveUK.PrintBusses();
            piratesCoveUK.PrintGolfer();
            piratesCovesGermany.PrintBusses();
            piratesCovesGermany.PrintGolfer();
            piratesCovesItaly.PrintBusses();
            piratesCovesItaly.PrintGolfer();
        }
    }
}
