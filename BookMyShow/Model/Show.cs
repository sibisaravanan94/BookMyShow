using BookMyShow.Enum;

namespace BookMyShow.Model
{
    public class Show : Auditable
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Hall Hall { get; set; }
        public Movie Movie { get; set; }
        public Language Language { get; set; }
        //public List<Feature> Features { get; set; }
        public List<ShowSeat> ShowSeats { get; set; }
        public int HallId { get; set; }
        public int MovieId { get; set; }
        public int LanguageId { get; set; }
    }
}
