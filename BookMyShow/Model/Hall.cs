using BookMyShow.Enum;

namespace BookMyShow.Models
{
    public class Hall : Auditable
    {
        public string Name { get; set; }
        public List<Seat> Seats { get; set; }
        public List<Feature> Features { get; set; }
    }
}