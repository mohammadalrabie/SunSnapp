using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SunSnap.Models;

namespace SunSnap.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Photo> Photos { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Photo>().HasData(
            new Photo
            {
                Id = 1,
                FileName = "sunrise.png",
                FilePath = "/photos/sunrise.png",
                UploadDate = DateTime.UtcNow,
                PeriodStart = TimeSpan.Parse("06:45:00"),
                PeriodEnd = TimeSpan.Parse("08:07:00")
            },
            new Photo
            {
                Id = 2,
                FileName = "morning.png",
                FilePath = "/photos/morning.png",
                UploadDate = DateTime.UtcNow,
                PeriodStart = TimeSpan.Parse("08:07:00"),
                PeriodEnd = TimeSpan.Parse("11:59:59")
            },
            new Photo
            {
                Id = 3,
                FileName = "noon.png",
                FilePath = "/photos/noon.png",
                UploadDate = DateTime.UtcNow,
                PeriodStart = TimeSpan.Parse("12:00:00"),
                PeriodEnd = TimeSpan.Parse("14:59:59")
            },
            new Photo
            {
                Id = 4,
                FileName = "evening.png",
                FilePath = "/photos/evening.png",
                UploadDate = DateTime.UtcNow,
                PeriodStart = TimeSpan.Parse("15:00:00"),
                PeriodEnd = TimeSpan.Parse("18:44:59")
            },
            new Photo
            {
                Id = 5,
                FileName = "sunset.png",
                FilePath = "/photos/sunset.png",
                UploadDate = DateTime.UtcNow,
                PeriodStart = TimeSpan.Parse("18:45:00"),
                PeriodEnd = TimeSpan.Parse("19:27:00")
            },
            new Photo
            {
                Id = 6,
                FileName = "night.png",
                FilePath = "/photos/night.png",
                UploadDate = DateTime.UtcNow,
                PeriodStart = TimeSpan.Parse("19:27:01"),
                PeriodEnd = TimeSpan.Parse("06:44:59")
            }
        );
    }
}
