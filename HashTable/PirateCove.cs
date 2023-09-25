using System;
using System.Collections.Generic;

namespace PirateCoves
{
    public class PirateCove
    {
        string Name { get; set; }
        public string Location { get; set; }
        List<Bus> BussesAtCove { get; set; } = new List<Bus>();
        public List<Golfer> Visitors { get; set; } = new List<Golfer>();
        public PirateCove(string location, string name) 
        {
            this.Name = name;
            this.Location = location;
        }
        public void AddBus(Bus bus) => BussesAtCove.Add(bus);

        public void RemoveBus(Bus bus)
        {
            if (BussesAtCove.Contains(bus))
            {
                BussesAtCove.Remove(bus);
            }
        }
        public void AddGolfer(Golfer golfer) => Visitors.Add(golfer);

        public void PrintGolfer()
        {
            if (Visitors.Count > 0)
            {
                Console.WriteLine($"{Name} has the following Golfers: ");
                foreach (Golfer golfer in  Visitors)
                {
                    Console.Write(golfer.Name);
                }
            }
            else 
            {
                Console.WriteLine($"No Golfer at {Name}");
            }
            
        }
        public void PrintBusses()
        {
            if (BussesAtCove.Count > 0)
            {   
                Console.WriteLine($"{BussesAtCove.Count} Vehicle/s are currently at PirateCove {Name}. Names: ");
                foreach (var bus in BussesAtCove) 
                {
                    Console.Write(bus.Name);
                }
            }
            else 
            {
                Console.WriteLine($"No Vehicles at PirateCove {Name}");
            }         
        }
    }
}
