namespace BookMyShow.Model
{
    public class User : Auditable
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailId { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
    }
}