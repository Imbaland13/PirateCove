using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

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
            
            int rounds = 0;
            while (rounds < 5)
            {
                foreach (Bus bus in busses)
                {
                    bus.HandleTrip();
                }
                rounds++;
                Console.WriteLine($"Round {rounds} is over.");
                Console.WriteLine();
            }
            
            Console.ReadLine();
        }

        static List<Golfer> CreateGolfers()
        {
            return new List<Golfer>()
            {
                new Golfer("Siuuuu", "Germany", "Italy"),
                new Golfer("Ferhat", "Italy", "UK"),
                new Golfer("Naeem", "Italy", "Belgium"),
                new Golfer("Mathias", "Italy", "Belgium"),
                new Golfer("Max", "Ireland", "Belgium"),
                new Golfer("Tesch", "Ireland", "Italy"),
                new Golfer("Basti", "Belgium", "Italy"),
                new Golfer("Nico", "UK", "Germany"),
                new Golfer("Fred", "Germany", "Ireland"),
                new Golfer("Paavo", "Germany", "UK"),
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
            string text = File.ReadAllText("Busses.json");
            return JsonSerializer.Deserialize<List<Bus>>(text);
        }
    }
}
