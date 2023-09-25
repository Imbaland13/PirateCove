namespace PirateCoves
{
    public class Golfer
    {
        public string Name { get; set; }
        public string StartLocation {  get; set; }
        public string EndLocation { get; set; }
        public Golfer(string name, string startLocation, string endLocation) 
        {
            this.Name = name;
            this.StartLocation = startLocation;
            this.EndLocation = endLocation;
        }
    }
}
