namespace CarExhibition
{
    public class Tier
    {
        public Tier(int size)
        {
            Size = size;
        }
        public string Brand { get; set; }
        public int Size { get; private set;}
    }
}