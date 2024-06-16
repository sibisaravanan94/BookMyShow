namespace BookMyShow.Models
{
    public class Seat : Auditable
    {
        public SeatType SeatType { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }
        public string SeatNumber { get; set; }
    }
}