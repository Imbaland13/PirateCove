using System;
using System.Collections.Generic;
using System.Linq;

namespace PirateCoves
{
    public class Bus
    {
        private readonly int CAPACITY = 20;
        List<Golfer> Passengers { get; set; } = new List<Golfer>();
        List<string> Schedule { get; set; }
        PirateCove CurrentCove { get; set; }
        PirateCove NextCove { get; set; }
        public string Name { get; set; }
        public string StartLocation { get; set; }
        
        public Bus(string name, string startLocation, List<string> schedule) 
        {
            Name = name;
            StartLocation = startLocation;
            Schedule = schedule;
            
            CurrentCove = CoveIndex.PirateCoves.Find(cove => cove.Location == startLocation);
            CurrentCove.AddBus(this);
        }

        bool HasSpace() => this.Passengers.Count < CAPACITY;
        
        PirateCove GetNextStation()
        {
            int currentStationIdx = 0;
            
            for (int i = 0; i < Schedule.Count ; i++)
            {
                if (CurrentCove.Location == Schedule[i])
                {
                    currentStationIdx = i;
                }
            }

            if (currentStationIdx == Schedule.Count - 1)
                return CoveIndex.PirateCoves.Find(cove => cove.Location == Schedule[0]);
            else
                return CoveIndex.PirateCoves.Find(cove => cove.Location == Schedule[currentStationIdx + 1]);
        }
        
        public void HandleTrip()
        {
            DisembarkPassengers();
            NextCove = GetNextStation();
            
            BoardPassengers();
            CurrentCove.RemoveBus(this);
            
            // Travel to next station
            
            CurrentCove = NextCove;
            CurrentCove.AddBus(this);
        }
        
        void DisembarkPassengers()
        {
            foreach (var golfer in Passengers)    
            {
                if (golfer.EndLocation == CurrentCove.Location)
                {
                    CurrentCove.Visitors.Add(golfer);
                    Passengers.Remove(golfer);
                }
            }
        }
        void BoardPassengers()
        {
            foreach (var golfer in CurrentCove.Visitors)
            {
                if (HasSpace() && golfer.EndLocation == NextCove.Location)
                {
                    Passengers.Add(golfer);
                    NextCove.Visitors.Remove(golfer);
                }
            }
        }
        
        void AddGolfer(Golfer golfer)
        {
            if (Passengers.Count < CAPACITY)
            {
                Passengers.Add(golfer);
            }
            else
            {
                Console.WriteLine($"Der Bus {this} ist voll!");
            }
        }
        Golfer RemoveGolfer() => Passengers.FirstOrDefault();

        public void PrintPassengers()
        {
            foreach (Golfer golfer in Passengers)
            {
                Console.WriteLine(golfer.Name);
            }
        }
    }
}
