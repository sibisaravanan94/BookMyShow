using BookMyShow.Enum;
using BookMyShow.Model;
using Microsoft.EntityFrameworkCore;

namespace BookMyShow.Data
{
    public class BookMyShowContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<SeatType> SeatTypes { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<ShowSeat> ShowSeats { get; set; }
        public DbSet<ShowSeatTickets> showSeatTickets { get; set; }
        public DbSet<ShowSeatType> ShowSeatTypes { get; set; }
        public DbSet<Theater> Theaters { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }
        public BookMyShowContext(DbContextOptions<BookMyShowContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShowSeatTickets>()
                .HasKey(obj => new { obj.ShowSeatId, obj.TicketId });

            modelBuilder.Entity<ShowSeatTickets>()
                .HasOne(obj => obj.Ticket)
                .WithMany(obj => obj.Seats)
                .HasForeignKey(obj => obj.TicketId);

            modelBuilder.Entity<ShowSeatTickets>()
                .HasOne(obj => obj.ShowSeat)
                .WithMany(obj => obj.Tickets)
                .HasForeignKey(obj => obj.ShowSeatId);
        }
    }
}
