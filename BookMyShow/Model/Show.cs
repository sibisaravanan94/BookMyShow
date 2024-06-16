using BookMyShow.Enum;

namespace BookMyShow.Models
{
    public class Show : Auditable
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Hall Hall { get; set; }
        public Movie Movie { get; set; }
        public Language Language { get; set; }
        public Feature Feature { get; set; }
        public List<ShowSeat> ShowSeats { get; set; }
        public List<ShowSeatType> ShowSeatTypes { get; set; }
    }
}
