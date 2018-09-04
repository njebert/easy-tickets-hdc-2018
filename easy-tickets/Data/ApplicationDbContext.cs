using System;
using System.Collections.Generic;
using System.Text;
using easy_tickets.DataModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace easy_tickets.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Show> Shows { get; set; }
        public DbSet<Act> Acts { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<ShowAct> ShowActs { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ShowAct>()
                    .HasKey(sa => new { sa.ShowID, sa.ActID });
            modelBuilder.Entity<ShowAct>()
                .HasOne(sa => sa.Show)
                .WithMany(s => s.ShowActs)
                .HasForeignKey(sa => sa.ShowID);
            modelBuilder.Entity<ShowAct>()
                .HasOne(sa => sa.Act)
                .WithMany(s => s.ShowActs)
                .HasForeignKey(sa => sa.ActID);


            //Seeding Data

            modelBuilder.Entity<Location>().HasData(
                new { LocationID = 1, Name = "Pinnacle Bank Arena", Capacity = 14620 },
                new { LocationID = 2, Name = "Pinewood Bowl Theater", Capacity = 5500 },
                new { LocationID = 3, Name = "CHI Health Center Omaha", Capacity = 18100 },
                new { LocationID = 4, Name = "Orpheum Theater", Capacity = 2596 },
                new { LocationID = 5, Name = "Slowdown", Capacity = 470 }
            );

            modelBuilder.Entity<Act>().HasData(
                new { ActID = 1, Name = "Metallica", Details = "Metal Royalty" },
                new { ActID = 2, Name = "PAW Patrol", Details = "Live adaptation of popular kid's cartoon" },
                new { ActID = 3, Name = "Fallout Boy", Details = "Mainstream pop-punk rock" },
                new { ActID = 4, Name = "Machine Gun Kelley", Details = "Radio rapper" },
                new { ActID = 5, Name = "Beck", Details = "Jam band pioneer" },
                new { ActID = 6, Name = "Alan Jackson", Details = "Country legend" },
                new { ActID = 7, Name = "Justin Timberlake", Details = "Power pop" },
                new { ActID = 8, Name = "Panic! At the Disco", Details = "Pop Rock revival" },
                new { ActID = 9, Name = "Two Feet", Details = "Hardcore rock" },
                new { ActID = 10, Name = "Elton John", Details = "Pop royalty" },
                new { ActID = 11, Name = "The Play That Goes Wrong", Details = "Modern broadway" },
                new { ActID = 12, Name = "Lake Street Dive", Details = "Modern Bluegrass" },
                new { ActID = 13, Name = "Kalbells", Details = "Alternative" },
                new { ActID = 14, Name = "Here Come the Mummies!", Details = "Funk Rock" }
            );

            modelBuilder.Entity<Show>().HasData(
                new { ShowID = 1, LocationID = 1, Date = new DateTime(2018, 9, 6, 16, 0, 0), Name = "Metallica at PBA!" },
                new { ShowID = 2, LocationID = 1, Date = new DateTime(2018, 9, 22, 14, 0, 0), Name = "PAW Patrol LIVE! Race to the Rescue" },
                new { ShowID = 3, LocationID = 1, Date = new DateTime(2018, 9, 23, 14, 0, 0), Name = "PAW Patrol LIVE! Race to the Rescue" },
                new { ShowID = 4, LocationID = 1, Date = new DateTime(2018, 9, 6, 16, 0, 0), Name = "Fallout Boy Mania Tour" },
                new { ShowID = 5, LocationID = 2, Date = new DateTime(2018, 9, 6, 19, 0, 0), Name = "The Beck Live Experience" },
                new { ShowID = 6, LocationID = 3, Date = new DateTime(2018, 9, 21, 21, 0, 0), Name = "Alan Jackson: Honky Tonk Highway Tour" },
                new { ShowID = 7, LocationID = 3, Date = new DateTime(2018, 12, 8, 21, 0, 0), Name = "Justin Timberlake - The Man Of The Woods Tour" },
                new { ShowID = 8, LocationID = 3, Date = new DateTime(2019, 2, 1, 21, 0, 0), Name = "Panic! At the Disco: Pray for the Wicked Tour" },
                new { ShowID = 9, LocationID = 3, Date = new DateTime(2019, 2, 12, 20, 0, 0), Name = "Elton John: Farewell Yellow Brick Road" },
                new { ShowID = 10, LocationID = 4, Date = new DateTime(2018, 11, 1, 19, 30, 0), Name = "The Play That Goes Wrong" },
                new { ShowID = 11, LocationID = 4, Date = new DateTime(2018, 11, 2, 19, 30, 0), Name = "The Play That Goes Wrong" },
                new { ShowID = 12, LocationID = 4, Date = new DateTime(2018, 11, 3, 14, 0, 0), Name = "The Play That Goes Wrong" },
                new { ShowID = 13, LocationID = 4, Date = new DateTime(2018, 11, 3, 19, 30, 0), Name = "The Play That Goes Wrong" },
                new { ShowID = 14, LocationID = 4, Date = new DateTime(2018, 11, 4, 14, 0, 0), Name = "The Play That Goes Wrong" },
                new { ShowID = 15, LocationID = 4, Date = new DateTime(2018, 11, 4, 19, 30, 0), Name = "The Play That Goes Wrong" },
                new { ShowID = 16, LocationID = 5, Date = new DateTime(2018, 9, 4, 19, 0, 0), Name = "All Ages Tuesday" },
                new { ShowID = 17, LocationID = 5, Date = new DateTime(2018, 9, 13, 19, 0, 0), Name = "Here Come the Mummies Spooktacular" }
            );

            modelBuilder.Entity<ShowAct>().HasData(
                new { ShowID = 1, ActID = 1 },
                new { ShowID = 2, ActID = 2 },
                new { ShowID = 3, ActID = 2 },
                new { ShowID = 4, ActID = 3 },
                new { ShowID = 4, ActID = 4 },
                new { ShowID = 5, ActID = 5 },
                new { ShowID = 6, ActID = 6 },
                new { ShowID = 7, ActID = 7 },
                new { ShowID = 8, ActID = 8 },
                new { ShowID = 8, ActID = 9 },
                new { ShowID = 9, ActID = 10 },
                new { ShowID = 10, ActID = 11 },
                new { ShowID = 11, ActID = 11 },
                new { ShowID = 12, ActID = 11 },
                new { ShowID = 13, ActID = 11 },
                new { ShowID = 14, ActID = 11 },
                new { ShowID = 15, ActID = 11 },
                new { ShowID = 16, ActID = 12 },
                new { ShowID = 16, ActID = 13 },
                new { ShowID = 17, ActID = 14 }
            );
        }
    }
}
