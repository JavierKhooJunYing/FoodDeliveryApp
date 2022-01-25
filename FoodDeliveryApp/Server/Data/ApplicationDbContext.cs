using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Server.Models;
using FoodDeliveryApp.Server.Seeding;
using FoodDeliveryApp.Shared;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace FoodDeliveryApp.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Branch> Branches { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Staff> Staffs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new BranchSeedConfiguration());
            builder.ApplyConfiguration(new CustomerSeedConfiguration());
            builder.ApplyConfiguration(new DeliverySeedConfiguration());
            builder.ApplyConfiguration(new MenuItemSeedConfiguration());
            builder.ApplyConfiguration(new OrderItemSeedConfiguration());
            builder.ApplyConfiguration(new OrderSeedConfiguration());
            builder.ApplyConfiguration(new PaymentSeedConfiguration());
            builder.ApplyConfiguration(new StaffSeedConfiguration());
        }
    }
}
