using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateCove
{
    internal class PiratesCoves
    {
        public Location Location { get; set; }
        public List<Bus> Busse { get; set; }
        public List<Golfer> GolferAtCove { get; set; } = new List<Golfer>();
        public void SetBus(Bus bus)
        {
            Busse.Add(bus);
        }
        public void PrintBusses()
        {
            foreach (var bus in Busse) 
            {
                Console.WriteLine(bus);
            }
        }
    }
}
