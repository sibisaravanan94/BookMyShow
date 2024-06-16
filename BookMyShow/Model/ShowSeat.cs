using BookMyShow.Enum;

namespace BookMyShow.Model
{
    public class ShowSeat : Auditable
    {
        public Show Show { get; set; }
        public Seat Seat { get; set; }
        public SeatStatus Status { get; set; }
        public int ShowId { get; set; }
        public int SeatId { get; set;}
        public int SeatStatusId { get; set; }
        public List<ShowSeatTickets> Tickets { get; set; } = new List<ShowSeatTickets>();
    }
}
