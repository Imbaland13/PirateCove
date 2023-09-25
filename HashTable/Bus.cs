using System;
using System.Collections.Generic;
using System.Linq;

namespace PirateCoves
{
    internal class Bus
    {
        private readonly int CAPACITY = 20;
        List<Golfer> Passengers { get; set; } = new List<Golfer>();
        List<PirateCove> Schedule { get; set; } = new List<PirateCove>();
        PirateCove CurrentCove { get; set; }
        PirateCove NextCove { get; set; }
        public string Name { get; set; }
        public string StartLocation { get; set; }
        
        public Bus(string name, string startLocation) 
        {
            this.Name = name;
            this.StartLocation = startLocation;
        }

        bool HasSpace() => this.Passengers.Count < CAPACITY;
        
        PirateCove GetNextStation()
        {
            int currentStationIdx = 0;
            
            for (int i = 0; i < Schedule.Count ; i++)
            {
                if (CurrentCove.Location == Schedule[i].Location)
                {
                    currentStationIdx = i;
                }
            }
            
            if (currentStationIdx == Schedule.Count - 1)
                return Schedule[0];
            else
                return Schedule[currentStationIdx+1];
        }


        public void DriveToNextDestination()
        {
            CurrentCove.RemoveBus(this);
            
            PirateCove destination = GetNextStation();
            CurrentCove = destination;
            destination.AddBus(this);
            
            foreach (var golfer in Passengers)    
            {
                if (golfer.EndLocation == CurrentCove.Location)
                {
                    destination.GolferAtCove.Add(golfer);
                    Passengers.Remove(golfer);
                }
            }
            
            NextCove = GetNextStation();

            foreach (var golfer in destination.GolferAtCove)
            {
                if (HasSpace() && golfer.EndLocation == NextCove.Location)
                {
                    Passengers.Add(golfer);
                    NextCove.GolferAtCove.Remove(golfer);
                }
            }
        }
        
        public void AddStations(PirateCove location) => Schedule.Add(location);
        public void AddGolfer(Golfer golfer)
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
        public Golfer RemoveGolfer() => Passengers.FirstOrDefault();

        public void PrintPassengers()
        {
            foreach (Golfer golfer in Passengers)
            {
                Console.WriteLine(golfer.Name);
            }
        }
    }
}
