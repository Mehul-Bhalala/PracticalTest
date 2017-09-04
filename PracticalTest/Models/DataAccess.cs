using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PracticalTest.Models
{
    public class DataAccess : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Service> Service { get; set; }

        public DataAccess(DbContextOptions<DataAccess> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity => {
                entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()");
            });
            modelBuilder.Entity<Service>(entity => {
                entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()");
            });
            modelBuilder.Entity<UserService>()
                .HasKey(bc => new { bc.UserId, bc.ServiceId });

            modelBuilder.Entity<UserService>()
                .HasOne(bc => bc.User)
                .WithMany(b => b.UserServices)
                .HasForeignKey(bc => bc.UserId);

            modelBuilder.Entity<UserService>()
                .HasOne(bc => bc.Service)
                .WithMany(c => c.UserServices)
                .HasForeignKey(bc => bc.ServiceId);
        }
    }
}
