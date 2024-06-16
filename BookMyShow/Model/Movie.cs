using BookMyShow.Enum;

namespace BookMyShow.Model
{
    public class Movie : Auditable
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        //public List<Feature> Features { get; set; }
        //public List<Language> Languages { get; set; }
        //public List<Genre> Genres { get; set; }
        public float Rating { get; set; }
    }
}
