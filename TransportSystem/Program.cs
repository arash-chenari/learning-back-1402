namespace TransportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var vipBus = new NormalBus("VipBus", 1);
            var shzteh = new Trip(vipBus, 1000, "Shiraz", "Tehran");

            var myticket = shzteh.BoughtTicket("arash-chenari");
            shzteh.ReserveTicket("sina-shahin");
            
            shzteh.CancelTicket(myticket);

            System.Console.WriteLine(shzteh.Income());  
        }
    }



}