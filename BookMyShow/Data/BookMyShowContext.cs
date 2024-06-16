using BookMyShow.Models;
using Microsoft.EntityFrameworkCore;

namespace BookMyShow.Data
{
    public class BookMyShowContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Theater> Theaters { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<SeatType> SeatTypes { get; set; }
        public BookMyShowContext(DbContextOptions<BookMyShowContext> options) : base(options) { }
    }
}
