using BookMyShow.Enum;

namespace BookMyShow.Model
{
    public class Ticket : Auditable
    {
        public Show Show { get; set; }
        public List<ShowSeatTickets> Seats { get; set; } = new List<ShowSeatTickets>();
        public User User { get; set; }
        public float Price { get; set; }
        public List<Payments> Payments { get; set; } = new List<Payments>();
        public TicketStatus Status { get; set; }
        public int TicketStatusId { get; set; }
    }
}
