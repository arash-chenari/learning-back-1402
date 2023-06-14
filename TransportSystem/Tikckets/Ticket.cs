namespace TransportSystem.Tickets
{
    public abstract class Ticket
    {
        public Trip Trip { get; set; }
        public int Code { get; set; }
        public string PassengerFullName { get; set; }

        public abstract double Price();
    }





    


} 