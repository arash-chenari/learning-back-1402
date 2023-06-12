namespace CarExhibition
{
    public class Program
    {
        public static void Main()
        {
            Engin engin = new DiselEngin();
            ManualGearBox gearBox = new ManualGearBox(5);
            var car = new Car(engin,gearBox);
            var a = car.GearBox;
        }
    }
}