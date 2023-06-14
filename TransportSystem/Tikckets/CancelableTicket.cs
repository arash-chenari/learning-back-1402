namespace TransportSystem.Tickets
{
    public abstract class CancelableTicket : Ticket
    {
         public abstract CanceledTicket Cancel();
    }

    

    public class BoughtTicket : CancelableTicket
    {
        public override BoughtCanceledTicket Cancel()
        {
            return new BoughtCanceledTicket
            {
                PassengerFullName = PassengerFullName,
                Trip = Trip,
                Code = Code
            };
        }

        public override double Price()
        {
            return Trip.GetPrice();
        }
    }

    public class ReservedTicket : CancelableTicket
    {
        public override ReservedCanceledTicket Cancel()
        {
            return new ReservedCanceledTicket
            {
                PassengerFullName = PassengerFullName,
                Trip = Trip,
                Code = Code
            };
            
        }

        public override double Price()
        {
            return Trip.GetPrice() * .3;
        }
    }
} 