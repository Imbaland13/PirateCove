namespace PirateCoves
{
    public class Golfer
    {
        public string Name { get; set; }
        public string StartLocation {  get; set; }
        public string EndLocation { get; set; }
        public Golfer(string name, string startLocation, string endLocation) 
        {
            Name = name;
            StartLocation = startLocation;
            CoveIndex.PirateCoves.Find(cove => cove.Location == startLocation).Visitors.Add(this);
            EndLocation = endLocation;
            
        }
    }
}
