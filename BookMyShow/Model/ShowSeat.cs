namespace BookMyShow.Models
{
    public class ShowSeat : Auditable
    {
        public Show Show { get; set; }
        public Seat Seat { get; set; }
        public SeatStatus Status { get; set; }
    }
}
