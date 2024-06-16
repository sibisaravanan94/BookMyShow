using Microsoft.EntityFrameworkCore;

namespace BookMyShow.Data
{
    public class BookMyShowContext : DbContext
    {
        public BookMyShowContext(DbContextOptions<BookMyShowContext> options) : base(options)
        {
                
        }
    }
}
