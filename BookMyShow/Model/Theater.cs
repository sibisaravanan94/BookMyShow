namespace BookMyShow.Model
{
    public class Theater : Auditable
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public List<Hall> Halls { get; set; } = new List<Hall>();
        public int CityId { get; set; } // Foreign key
        public City City { get; set; }
    }
}