using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.DAL.Entities;

namespace Task.DAL.EF
{
    public class AvtoContext : DbContext
    {
        public AvtoContext(DbContextOptions<AvtoContext> options)
          : base(options)
        {
        }

       
        DbSet<CarEntity> Cars { get; set; }
        DbSet<UserEntity> Users { get; set; }
        DbSet<UserOrderEntity> UserOrders { get; set; }
        DbSet<FirmEntity> Firms { get; set; }
        DbSet<CartEntity> Carts { get; set; }
        DbSet<OrdersEntity> Orders { get; set; }
        DbSet<StatucOrderEntity> StatucOrders { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<OrdersEntity>()
                .HasKey(c => new { c.CarID, c.UsersOrderID });
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CartEntity>()
                .HasKey(c => new { c.Id, c.CarID, c.UsersOrderID });
            base.OnModelCreating(modelBuilder);
        }
    }
}
