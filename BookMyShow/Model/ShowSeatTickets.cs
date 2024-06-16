
namespace BookMyShow.Model
{
    public class ShowSeatTickets
    {
        public Ticket Ticket { get; set; }
        public int TicketId { get; set; }
        public ShowSeat ShowSeat { get; set; }
        public int ShowSeatId { get; set; }
    }
}
