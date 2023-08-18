﻿using Microsoft.EntityFrameworkCore;

namespace UniversityHousing.Models
{
    public class HousingContext:DbContext
    {
        public HousingContext()
        {

        }
        public HousingContext(DbContextOptions<HousingContext> options):base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Room> Rooms { get; set; }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Payment> Payments { get; set; }




    }
}
