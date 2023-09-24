
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// TODO: TEST COMMENT FOR PR
namespace PiratesCoves
{
    internal class Manager
    {
        public void BusToDestination(Bus bus, PirateCove pirateCoveStart, PirateCove pirateCoveDest)
        {
            foreach (Golfer golfer in pirateCoveStart.GolferAtCove)
            {
                if (bus.hasSpace() && golfer.EndLocation == pirateCoveDest.Location)
                {
                    bus.Passengers.Add(golfer);
                    pirateCoveStart.GolferAtCove.Remove(golfer);
                }
            }
            for (int i = 0; i < bus.Passengers.Count; i++)
            {
                if (bus.Passengers[i].EndLocation == pirateCoveDest.GetLocation())
                {
                    pirateCoveDest.GolferAtCove.Add(bus.Passengers[i]);
                    bus.Passengers.Remove(bus.Passengers[i]);
                }
            }
            bus.CurrentLocation = pirateCoveDest.Location;
            pirateCoveStart.BusLeave(bus);
            pirateCoveDest.BusAdd(bus);
        }      
        public void BusNextStopInSchedule(Bus bus)
        {
            PirateCove piratecovecurrent = null;
            PirateCove piratecovenext = null;
            if(bus.Schedule.FindLast == bus.CurrentLocation)
            {
                piratecovecurrent = bus.Schedule.First();
                piratecovenext = bus.Schedule[1];
            }
            else
            {
                for(int i = 0; i < bus.Schedule.Count; i++)
                {
                    if (bus.Schedule[i].Location == bus.CurrentLocation)
                    {
                        piratecovecurrent = bus.Schedule[i];
                        piratecovenext = bus.Schedule[i + 1];
                    }
                }
            }
            BusToDestination(bus, piratecovecurrent, piratecovenext);
        }
    }
}
