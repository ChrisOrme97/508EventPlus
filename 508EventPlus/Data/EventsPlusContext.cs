using _508EventPlus.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace _508EventPlus.Data
{
    public class EventsPlusContext : IdentityDbContext
    {
        public EventsPlusContext(DbContextOptions<EventsPlusContext> options)
            : base(options)
        {
        }
        // GET: Retrieves Database tables
        public DbSet<Event> Events { get; set; }
            public DbSet<Organiser> Organisers { get; set; }
            public DbSet<Customer> Customers { get; set; }
            public DbSet<Bookings> Bookings { get; set; }
            public DbSet<Role> Role { get; set; }

        // GET: Displays the databases in table format
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Event>().ToTable("Events");
            modelBuilder.Entity<Organiser>().ToTable("Organisers");
            modelBuilder.Entity<Customer>().ToTable("Customers");
            modelBuilder.Entity<Bookings>().ToTable("Booking");
            modelBuilder.Entity<Role>().ToTable("Role");
        }

    }
    }

