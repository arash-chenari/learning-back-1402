namespace CarExhibition
{
    public abstract class GearBox
    {
        protected int Current=0;   

        public GearBox(int gearCount)
        {
            this.gearCount = gearCount;
        }
        
        protected readonly int gearCount;
    }


    public class AutomaticGearBox : GearBox
    {
        public AutomaticGearBox(int gearCount) : base (gearCount)
        {
            
        }

        private void Up()
        {
          Current ++;
          
        }

        private void Down()
        {
          Current --;
        }

        private void neutral()
        {
           Current = 0;
        }

        private void Reverse()
        {
            Current = -1;
        }
    }

    public class ManualGearBox : GearBox
    {

        public ManualGearBox(int gearCount) : base(gearCount)
        {
        }

        public void Up()
        {
          Current ++;
        }

        public void Down()
        {
          Current --;
        }

        public void neutral()
        {
           Current = 0;
        }

        public void Reverse()
        {
            
        }
    }
}