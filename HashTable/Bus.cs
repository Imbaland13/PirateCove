using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiratesCoves
{
    internal class Bus
    {
        public List<Golfer> Passengers { get; set; } = new List<Golfer>();
        public List<PirateCove> Schedule { get; set; } = new List<PirateCove>();

        public string StartLocation { get; set; }
        public string CurrentLocation { get; set; }
        public string Name { get; set; }
        private readonly int limit = 20;
        public Bus(string Name, string startlocation) 
        {
            this.Name = Name;
            this.StartLocation = startlocation;
        }
        public bool hasSpace() 
        {
            return this.Passengers.Count < limit;
        } 
        public void AddStations(PirateCove location)
        {
            Schedule.Add(location);
        }
        public PirateCove GetNextStation()
        {
            int currentstationindex = 0;
            for(int i = 0; i < Schedule.Count ; i++)
            {
                if(this.CurrentLocation == Schedule[i].Location)
                {
                    currentstationindex = i;  
                }              
            }
            return Schedule[currentstationindex+1];
        }
        public void SetGolfer(Golfer golfer)
        {
            if (Passengers.Count < limit)
            {
                Passengers.Add(golfer);
            }
            else
            {
                Console.WriteLine($"Der Bus {this} ist voll!");
            }
        }
        public Golfer GetGolfer()
        {
            return Passengers.FirstOrDefault();
        }      
        public void PrintPassengers()
        {
            foreach (Golfer golfer in Passengers)
            {
                Console.WriteLine(golfer.Name);
            }
        }
    }
}
