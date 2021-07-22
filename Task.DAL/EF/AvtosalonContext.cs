using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Task.DAL.Entities;

namespace Task.DAL.EF
{
    public class AvtosalonContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<StatusOrd> Statuses { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<TypePay> TypePays { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Specifications> Specifications { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<TypeBody> TypeBodies { get; set; }
        public DbSet<TypeEngine> TypeEngines { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
