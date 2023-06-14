using TransportSystem.Tickets;

namespace TransportSystem
{
    public class Trip
    {
        public Trip(Bus bus,
           double basePrice,
           string origin,
           string destination)
        {
            Bus = bus;
            BasePrice = basePrice;    
            Destination = destination;
            Origin = origin;
        }

        public string Origin { get; set; }        
        public string Destination { get; set; }
        public double BasePrice { get; set; }
        public Bus Bus { get; set; }
        public DateTime LeavingTime { get; set; }
        
        public List<Ticket> tickets = new List<Ticket>();
        public List<CanceledTicket> canceledTickets = new List<CanceledTicket>();
        public List<ReservedTicket> reservedTickets = new List<ReservedTicket>();
        public List<BoughtTicket> BoughtTickets = new List<BoughtTicket>();

        public double GetPrice()
        {
            return BasePrice * Bus.GetCoheitient();
        }
        

        public double Income()
        {
            double income = 0;
            foreach (var ticket in tickets)
            {
                income += ticket.Price();
            }

            return income;
        }


        public ReservedTicket ReserveTicket(string passengerFullName)
        {
            var ticket = new ReservedTicket();
            ticket.PassengerFullName = passengerFullName;
            ticket.Trip = this;
            ticket.Code = tickets.Count + 1;
            tickets.Add(ticket);
            reservedTickets.Add(ticket);
            return ticket;
        }
        

        public BoughtTicket BoughtTicket(string passengerFullName)
        {
            var ticket = new BoughtTicket();
            ticket.PassengerFullName = passengerFullName;
            ticket.Trip = this;
            ticket.Code = tickets.Count + 1;
            tickets.Add(ticket);
            BoughtTickets.Add(ticket);
            return ticket;
        }


        public BoughtTicket FinishingReservation(ReservedTicket ticket)
        {
            tickets.Remove(ticket);
            reservedTickets.Remove(ticket);

            var bouthTicket = new BoughtTicket();
            bouthTicket.PassengerFullName = ticket.PassengerFullName;
            bouthTicket.Trip = this;
            bouthTicket.Code = ticket.Code;
            BoughtTickets.Add(bouthTicket);
            tickets.Add(bouthTicket);
            return bouthTicket;
        }


        public ReservedCanceledTicket CancelTicket(ReservedTicket ticket)
        {
            reservedTickets.Remove(ticket);
            tickets.Remove(ticket);
            var canceled = ticket.Cancel();
            tickets.Add(canceled);
            canceledTickets.Add(canceled);
            return canceled;
        }

        public BoughtCanceledTicket CancelTicket(BoughtTicket ticket)
        {
            BoughtTickets.Remove(ticket);
            tickets.Remove(ticket);
            var canceled = ticket.Cancel();
            tickets.Add(canceled);
            canceledTickets.Add(canceled);
            return canceled;
        }
    }
}