using BookMyShow.Enum;

namespace BookMyShow.Models
{
    public class Hall : Auditable
    {
        public string Name { get; set; }
        public List<Seat> Seats { get; set; }
        //public List<Feature> Features { get; set; }
        public int TheaterId { get; set; } // Foreign key
        public Theater Theater { get; set; }
    }
}