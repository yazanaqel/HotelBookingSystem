using HotelBookingSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingSystem.Data;
public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<RoomTypeAmenity>().HasKey(x => new { x.AmenityId, x.RoomTypeId });
    }

    public DbSet<Room> Rooms { get; set; }
    public DbSet<RoomType> RoomTypes { get; set; }
    public DbSet<Amenity> Amenites { get; set; }
    public DbSet<RoomTypeAmenity> RoomTypeAmenites { get; set; }
    public DbSet<Booking> Bookings { get; set; }
}
