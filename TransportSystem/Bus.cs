namespace TransportSystem
{
    public abstract class Bus
    {

        protected Bus(string name , int code)
        {
            this.name = name;
            this.code = code;
        }

        protected string name;
        protected int capacity;
        protected double increasePriceCoheficient;
        protected int code;

        public double GetCoheitient()
        {
            return increasePriceCoheficient;
        }
    }




    public class VipBus : Bus
    {
        public VipBus(string name, int code) : base(name , code)
        {
            capacity = 25;
            increasePriceCoheficient = 1.4;
        }
    }

    public class NormalBus : Bus
    {
        public NormalBus(string name, int code) : base(name, code)
        {
            capacity = 44;
            increasePriceCoheficient = 1;
        }
    }
}