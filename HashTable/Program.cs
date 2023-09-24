using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashTable;

namespace PiratesCoves
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Bus bus1 = new Bus("Bus1", "Italy");
            Bus bus2 = new Bus("Bus2", "Germany");
            Bus bus3 = new Bus("Bus3", "Ireland");
            Bus bus4 = new Bus("Bus4", "Belgium");
            List<Bus> busList = new List<Bus>
            {
                bus1,
                bus2,
                bus3,
                bus4
            };
            PirateCove piratesCoveUK = new PirateCove("UK", "pirateCoveUK");
            PirateCove piratesCoveBelgium = new PirateCove("Belgium", "pirateCoveBelgium");
            PirateCove piratesCoveIreland = new PirateCove("Ireland", "pirateCoveIreland");
            PirateCove piratesCoveGermany = new PirateCove("Germany", "pirateCoveGermany");
            PirateCove piratesCoveItaly = new PirateCove("Italy", "pirateCoveItaly");           
            List<PirateCove>pirateCoves = new List<PirateCove>
            {
                piratesCoveUK,
                piratesCoveBelgium,
                piratesCoveGermany,
                piratesCoveIreland,
                piratesCoveItaly
            };
            //Helper helper = new Helper() { CoveList = pirateCoves};
            Golfer golfer1 = new Golfer("Süle", "Germany", "Italy");
            Golfer golfer2 = new Golfer("Ferhat", "Italy", "UK");
            Golfer golfer3 = new Golfer("Naeem", "Italy", "Belgium");
            Golfer golfer4 = new Golfer("Mathias", "Italy", "Belgium");
            Golfer golfer5 = new Golfer("Max", "Ireland", "Belgium");
            Golfer golfer6 = new Golfer("Steve1", "Ireland", "Italy");
            Golfer golfer7 = new Golfer("Steve2", "Belgium", "Italy");
            Golfer golfer8 = new Golfer("Steve3", "UK", "Germany");
            Golfer golfer9 = new Golfer("Steve4", "Germany", "Ireland");
            Golfer golfer10 = new Golfer("Steve5", "Germany", "UK");
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
                bus.AddStations(piratesCoveUK.GetLocation());
                bus.AddStations(piratesCoveGermany.GetLocation());
                bus.AddStations(piratesCoveItaly.GetLocation());
                bus.AddStations(piratesCoveIreland.GetLocation());
                bus.AddStations(piratesCoveBelgium.GetLocation());
            }
            //foreach (var piratecove in pirateCoves) 
            //{
            //    piratecove.GolferAtCove.Add(golfer);
            //}
            Manager manager = new Manager() ;
            //manager.BusToDestination(bus1, piratesCoveItaly, piratesCoveGermany);
            manager.BusToDestination(bus2, piratesCoveItaly, piratesCoveBelgium);
            //manager.BusToDestination(bus3, piratesCoveIreland, piratesCoveGermany);
            piratesCoveBelgium.PrintBusses();
            piratesCoveBelgium.PrintGolfer();
            piratesCoveGermany.PrintBusses();
            piratesCoveGermany.PrintGolfer();
            //piratesCoveIreland.PrintBusses();
            //piratesCoveIreland.PrintGolfer();
            //piratesCoveUK.PrintBusses();
            //piratesCoveUK.PrintGolfer();
            //piratesCoveGermany.PrintBusses();
            //piratesCoveGermany.PrintGolfer();
            //piratesCovesItaly.PrintBusses();
            //piratesCovesItaly.PrintGolfer();
            Console.ReadLine();
        }
    }
}
