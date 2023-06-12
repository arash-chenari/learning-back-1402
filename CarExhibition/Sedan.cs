namespace CarExhibition
{
    public class Sedan : Car
    {
        
        public Sedan(Engin engin, GearBox gearBox) : base(engin, gearBox)
        {
        }
        
        public Tier FrontLeft { get; set; }
        public Tier FrontRight { get; set; }
        public Tier BackLeft { get; set; }
        public Tier BackRight { get; set; }
        public int PassengerCount { get; set; }
        public int TrunkCapacity { get; set; }


    }
}