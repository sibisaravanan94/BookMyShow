namespace BookMyShow.Models
{
    public class Seat : Auditable
    {
        public SeatType SeatType { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }
        public string SeatNumber { get; set; }
        public Hall Hall { get; set; }
        public int HallId { get; set; } // Foreign key
        public int SeatTypeId { get; set; } // Foreign key
    }
}