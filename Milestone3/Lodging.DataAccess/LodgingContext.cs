using Lodging.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Lodging.DataAccess
{
    public class LodgingContext : DbContext
    {
        public DbSet<LodgingModel> Lodging { get; set; }
        public DbSet<RentalModel> Rentals { get; set; }
        public DbSet<ReviewModel> Reviews { get; set; }

        public LodgingContext(DbContextOptions<LodgingContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddressModel>().HasKey(e => e.Id);
            modelBuilder.Entity<LocationModel>().HasKey(e => e.Id);
            modelBuilder.Entity<LodgingModel>().HasKey(e => e.Id);
            modelBuilder.Entity<RentalModel>().HasKey(e => e.Id);
            modelBuilder.Entity<ReviewModel>().HasKey(e => e.Id);

            modelBuilder.Entity<AddressModel>().HasData(
                new AddressModel
                {
                    Id = 1,
                    Street = "77 Woodsgate Sq",
                    City = "Baguio",
                    Country = "Philippines",
                    StateProvince = "Benguet",
                    PostalCode = "2600",
                    LocationId = 1
                }
               );
            modelBuilder.Entity<LocationModel>().HasData(
                new LocationModel
                {
                    Id = 1,
                    Latitude = "16.4023° N",
                    Longitude = "120.5960° E",
                    Locale = "en",
                }
               );
            modelBuilder.Entity<RentalModel>().HasData(
                 new RentalModel
                 {
                     Id = 1,
                     Status = "available",
                     Name = "Baguio House",
                     Occupancy = 6,
                     Price = 100.00,
                     Type = "home",
                     LodgingId = 1
                 }
                );
            modelBuilder.Entity<ReviewModel>().HasData(
                new ReviewModel
                {
                    Id = 1,
                    AccountId = 1,
                    Comment = "I love it here",
                    Rating = 10,
                    DateCreated = DateTime.Now,
                    LodgingId = 1
                }
               );
            modelBuilder.Entity<LodgingModel>().HasData(
                new LodgingModel
                {
                    Id = 1,
                    Bathrooms = 3,
                    Name = "Camp 7"
                }
               );
        }
    }
}