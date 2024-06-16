namespace BookMyShow.Model
{
    public class ShowSeatType :Auditable
    {
        public Show Show { get; set; }
        public SeatType SeatType { get; set; }
        public float Price { get; set; }
        public int ShowId { get; set; }
        public int SeatTypeId { get; set; }
    }
}