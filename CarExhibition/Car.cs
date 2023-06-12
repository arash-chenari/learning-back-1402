namespace CarExhibition
{
    public class Car
    {
        public Car (Engin engin, GearBox gearBox)
        {
            this.engin = engin;
            this.GearBox = gearBox;
        }

        public string Brand{get; set;}
        public string Model{get; set;}
        public string Color{get; set;}
        public DateTime ConstructionYear{get; set;}

        private readonly Engin engin;
        public  GearBox GearBox {set;get;}

        public void Accelerate()
        {
            engin.Accelerate();
        }

        public void Break()
        {
           
        }

        public void ONOFF()
        {
           engin.Start();
        }
    }
}