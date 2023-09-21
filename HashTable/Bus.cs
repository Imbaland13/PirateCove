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
        public string Name { get; set; }
        public Location Location { get; set; }
        private readonly int limit = 20;
        public bool hasSpace() 
        {
            return this.BusList.Count < 20;
        } 
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
        public void BusToDestination(PiratesCoves pirateCoveStart, PiratesCoves pirateCoveDest)
        {
            foreach (Golfer golfer in pirateCoveStart.GolferAtCove)
            {
                if (this.hasSpace())
                {
                    this.BusList.Add(golfer);
                    pirateCoveStart.GolferAtCove.Remove(golfer);                  
                }
            }
            for (int i = 0; i < pirateCoveStart.GolferAtCove.Count; i++)
            {
                if (pirateCoveStart.GolferAtCove[i].EndLocation == pirateCoveDest.GetLocation())
                {
                    BusList.Add(pirateCoveStart.GolferAtCove[i]);
                }
            }
            for(int i= 0;i <BusList.Count;i++)
            {
                if (BusList[i].EndLocation == pirateCoveDest.GetLocation())
                {
                    BusList.Remove(BusList[i]);
                }
            }
            pirateCoveStart.BusLeave(this);
            pirateCoveDest.BusAdd(this);
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
