namespace BookMyShow.Model
{
    public class City : Auditable
    {
        public string Name { get; set; }
        public List<Theater> Theaters { get; set; } = new List<Theater>();
    }
}
