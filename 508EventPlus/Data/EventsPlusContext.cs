using _508EventPlus.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace _508EventPlus.Data
{
    public class EventsPlusContext : DbContext
    {
        public EventsPlusContext(DbContextOptions<EventsPlusContext> options)
            : base(options)
        {
        }
            public DbSet<Event> Events { get; set; }
            public DbSet<Organiser> Organisers { get; set; }
            public DbSet<Customer> Customers { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().ToTable("Events");
            modelBuilder.Entity<Organiser>().ToTable("Organisers");
            modelBuilder.Entity<Customer>().ToTable("Customers");
        }

    }
    }

