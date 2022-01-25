using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodDeliveryApp.Server.Seeding
{
    public class OrderSeedConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(
                new Order
                {
                    Id = 1,
                    OrderDateTime = new DateTime(2022, 01, 24),
                    CustomerId = 1,
                    BranchId = 1
                },
                new Order
                {
                    Id = 2,
                    OrderDateTime = new DateTime(2022, 01, 23),
                    CustomerId = 2,
                    BranchId = 1
                },
                new Order
                {
                    Id = 3,
                    OrderDateTime = new DateTime(2022, 01, 23),
                    CustomerId = 3,
                    BranchId = 1
                },
                new Order
                {
                    Id = 4,
                    OrderDateTime = new DateTime(2022, 01, 24),
                    CustomerId = 4,
                    BranchId = 1
                },
                new Order
                {
                    Id = 5,
                    OrderDateTime = new DateTime(2022, 01, 24),
                    CustomerId = 5,
                    BranchId = 1
                }
            );
        }
    }
}
