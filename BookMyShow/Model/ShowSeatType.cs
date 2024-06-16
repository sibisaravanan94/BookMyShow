namespace BookMyShow.Models
{
    public class ShowSeatType :Auditable
    {
        public Show Show { get; set; }
        public SeatType SeatType { get; set; }
        public float Price { get; set; }
    }
}