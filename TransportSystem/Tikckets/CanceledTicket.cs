namespace TransportSystem.Tickets
{
    public abstract class CanceledTicket : Ticket
    {
        protected double CancelSubtractCoheificent;

        public override double Price()
        {
             return Trip.GetPrice() * CancelSubtractCoheificent;
             
        }
    }


    public class ReservedCanceledTicket : CanceledTicket
    {
        public ReservedCanceledTicket()
        {
            base.CancelSubtractCoheificent = 0.2;
        }
     
    }

    public class BoughtCanceledTicket : CanceledTicket
    {
        public BoughtCanceledTicket()
        {
            base.CancelSubtractCoheificent = 0.1;
        }
    }
} 