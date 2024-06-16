using System.ComponentModel.DataAnnotations;

namespace BookMyShow.Models
{
    public abstract class Auditable
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
