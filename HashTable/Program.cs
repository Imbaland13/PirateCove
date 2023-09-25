using System;
using System.Collections.Generic;

namespace PirateCoves
{
    static class CoveIndex
    {
        public static List<PirateCove> PirateCoves { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CoveIndex.PirateCoves = CreateCoves();
            List<Bus> busses = CreateBusses();
            List<Golfer> golfers = CreateGolfers();
            
            

            foreach (Bus bus in busses)
            {
                bus.HandleTrip();
                bus.PrintPassengers();
            }
            // CoveIndex.PirateCoves.ForEach(x => x.PrintBusses());
            // CoveIndex.PirateCoves.ForEach(x => x.PrintGolfer());
            
            foreach (Bus bus in busses)
            {
                bus.HandleTrip();
                bus.PrintPassengers();
            }

            
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
                new PirateCove("UK", "UK Lads"),
                new PirateCove("Belgium", "Brussels Bitches"),
                new PirateCove("Ireland", "Dublin Cove"),
                new PirateCove("Germany", "Hansa Hamburg "),
                new PirateCove("Italy", "Roma Ferrari"),
            };
        }

        static List<Bus> CreateBusses()
        {
            return new List<Bus>
            {
                new Bus("Ferrari Bus", "Italy", new List<string> {"Italy", "Belgium", "Germany", "Ireland", "UK"} ),
                new Bus("Mercedes Bus", "Germany", new List<string> {"Italy", "Germany", "Belgium", "Ireland", "UK"} ),
                new Bus("Iren Bus", "Ireland", new List<string> {"Italy", "Germany", "Belgium", "Ireland", "UK"} ),
                new Bus("BB", "Belgium", new List<string> {"Italy", "Germany", "Belgium", "Ireland", "UK"} ),
            };
        }
    }
}
