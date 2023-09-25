using System;
using System.Collections.Generic;

namespace PirateCoves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Golfer> golfers = CreateGolfers();
            List<Bus> busses = CreateBusses();
            List<PirateCove> pirateCoves = CreateCoves();
            


            busses[0].DriveToNextDestination();

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

        static List<Golfer> CreateGolfers()
        {
            return new List<Golfer>()
            {
                new Golfer("Süle", "Germany", "Italy"),
                new Golfer("Ferhat", "Italy", "UK"),
                new Golfer("Naeem", "Italy", "Belgium"),
                new Golfer("Mathias", "Italy", "Belgium"),
                new Golfer("Max", "Ireland", "Belgium"),
                new Golfer("Steve1", "Ireland", "Italy"),
                new Golfer("Steve2", "Belgium", "Italy"),
                new Golfer("Steve3", "UK", "Germany"),
                new Golfer("Steve4", "Germany", "Ireland"),
                new Golfer("Steve5", "Germany", "UK"),
            };
        }

        static List<PirateCove> CreateCoves()
        {
            return new List<PirateCove>
            {
                new PirateCove("UK", "pirateCoveUK"),
                new PirateCove("Belgium", "pirateCoveBelgium"),
                new PirateCove("Ireland", "pirateCoveIreland"),
                new PirateCove("Germany", "pirateCoveGermany"),
                new PirateCove("Italy", "pirateCoveItaly"),
            };
        }

        static List<Bus> CreateBusses()
        {
            return new List<Bus>
            {
                new Bus("Bus1", "Italy"),
                new Bus("Bus2", "Germany"),
                new Bus("Bus3", "Ireland"),
                new Bus("Bus4", "Belgium"),
            };
        }
    }
}
