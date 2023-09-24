using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiratesCoves
{
    internal class Golfer
    {
        public string Name { get; set; }
        public string StartLocation {  get; set; }
        public string EndLocation { get; set; }
        public Golfer(string name, string startlocation, string endlocation) 
        {
            this.Name = name;
            this.StartLocation = startlocation;
            this.EndLocation = endlocation;
        }
    }
}
