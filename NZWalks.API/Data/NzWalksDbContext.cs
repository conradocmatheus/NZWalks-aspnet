using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data;

public class NzWalksDbContext : DbContext
{
    public NzWalksDbContext(DbContextOptions dbContextOptions) :  base(dbContextOptions)
    {
    }

    public DbSet<Difficulty> Difficulties { get; set; }
    public DbSet<Region> Regions { get; set; }
    public DbSet<Walk> Walks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed data for Difficulties
        // Easy, Medium, Hard
        var difficulties = new List<Difficulty>()
        {
            new Difficulty()
            {
                Id = Guid.Parse("cf46cf69-e0fa-4c03-9c31-7418618fb203"),
                Name = "Easy"
            },
            new Difficulty()
            {
                Id = Guid.Parse("19f369b0-2d0d-4aa1-956a-6d26f713f3bb"),
                Name = "Medium"
            },
            new Difficulty()
            {
                Id = Guid.Parse("5298b2f7-0ff4-4e0b-8b9f-cc82ca635f89"),
                Name = "Hard"
            }
        };

        // Seed difficulties to the database
        modelBuilder.Entity<Difficulty>().HasData(difficulties);

        // Seed data for Regions
        var regions = new List<Region>
        {
            new Region
            {
                Id = Guid.Parse("c2f1f0da-34a8-4b5d-b8ff-fb00e1a332d4"),
                Name = "Auckland",
                Code = "AKL",
                RegionImageUrl = "https://picsum.photos/200"
            },
            new Region
            {
                Id = Guid.Parse("7bded420-749a-426f-9d18-99e3b9b7ff87"),
                Name = "Wellington",
                Code = "WLG",
                RegionImageUrl = "https://picsum.photos/201"
            },
            new Region
            {
                Id = Guid.Parse("fbec72b6-b80a-44b1-bbaa-3ab21f4ffcd7"),
                Name = "Christchurch",
                Code = "CHC",
                RegionImageUrl = "https://picsum.photos/202"
            },
            new Region
            {
                Id = Guid.Parse("8c1b0f4b-5470-4fa6-98f1-25c4321dc64e"),
                Name = "Hamilton",
                Code = "HAM",
                RegionImageUrl = "https://picsum.photos/203"
            },
            new Region
            {
                Id = Guid.Parse("05bbedfd-7509-4c81-b495-9c3f3b6c6360"),
                Name = "Tauranga",
                Code = "TRG",
                RegionImageUrl = "https://picsum.photos/204"
            }
        };

        // Seed regions to the database
        modelBuilder.Entity<Region>().HasData(regions);
    }
}