using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateCove
{
    internal class Bus
    {
        //Queue<Golfer> BusQueue { get; set; } = new Queue<Golfer>();
        List<Golfer> BusList { get; set; } = new List<Golfer>();
        Location[] locations = new Location[5] { Location.UK, Location.Germany, 
            Location.Belgium, Location.Italy, Location.Ireland };
        public Location Location { get; set; }
        private readonly int limit = 20;
        public void SetGolfer(Golfer golfer)
        {
            if (BusList.Count < limit)
            {
                BusList.Add(golfer);
            }
            else
            {
                Console.WriteLine($"Der Bus {this} ist voll!");
            }
        }
        public Golfer GetGolfer()
        {
            return BusList.FirstOrDefault();
        }
        public List<Golfer> BusToDestination(Location location, Pirate)
        {
            foreach (Golfer g in BusList) 
            { 
                if (g.StartLocation == location)
                {
                    BusList.Add(g);
                }
                if(g.EndLocation == location)
                {
                    BusList.Remove(g);
                    
                }
            }
            return BusList;
        }
        public void PrintQueue()
        {
            foreach (Golfer golfer in BusList)
            {
                Console.WriteLine(golfer.Name);
            }
        }
    }
}
