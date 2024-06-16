namespace BookMyShow.Models
{
    public class Ticket : Auditable
    {
        public Show Show { get; set; }
        public List<ShowSeat> Seats { get; set; }
        public User User { get; set; }
        public float Price { get; set; }
        public List<Payments> Payments { get; set; }
        public TicketStatus Status { get; set; }
    }
}
