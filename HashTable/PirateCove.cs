﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiratesCoves
{
    internal class PirateCove
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Bus> Busse { get; set; } = new List<Bus>();
        public Bus Bus { get; set; }
        public List<Golfer> GolferAtCove { get; set; } = new List<Golfer>();
        public PirateCove(string location, string name) 
        {
            this.Name = name;
            this.Location = location;
        }
        public string GetLocation()
        {
            return this.Location;
        }
        public void BusAdd(Bus bus)
        {
            Busse.Add(bus);
        }
        public void BusLeave(Bus bus)
        {
            if (Busse.Contains(bus))
            {
                Busse.Remove(bus);
            }
        }
        public void SetGolfer(Golfer golfer)
        {
            this.GolferAtCove.Add(golfer);
        }
        public void PrintGolfer()
        {
            if(this.GolferAtCove.Count > 0)
            {
                Console.WriteLine(this.Name + " has the following Golfers:");
                foreach (Golfer golfer in  GolferAtCove)
                {
                    Console.WriteLine(golfer.Name);
                }
            }
            else 
            {
                Console.WriteLine($"No Golfer at {this.Name}");
            }
            
        }
        public void PrintBusses()
        {
            if(this.Busse.Count > 0)
            {   Console.WriteLine(this.Busse.Count + " Vehicle/s at PirateCove " + this.Name);
                foreach (var bus in Busse) 
                {
                    Console.WriteLine(bus.Name);
                }
            }
            else 
            {
                Console.WriteLine("No Vehicles at PirateCove " + this.Name);
            }         
        }
    }
}
