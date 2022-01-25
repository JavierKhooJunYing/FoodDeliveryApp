using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodDeliveryApp.Server.Seeding
{
    public class OrderItemSeedConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasData(
                new OrderItem
                {
                    Id = 1,
                    Quantity = 2,
                    OrderId = 1,
                    MenuItemId = 1
                },
                new OrderItem
                {
                    Id = 2,
                    Quantity = 1,
                    OrderId = 1,
                    MenuItemId = 5
                },
                new OrderItem
                {
                    Id = 3,
                    Quantity = 1,
                    OrderId = 2,
                    MenuItemId = 1
                },
                new OrderItem
                {
                    Id = 4,
                    Quantity = 1,
                    OrderId = 2,
                    MenuItemId = 10
                },
                new OrderItem
                {
                    Id = 5,
                    Quantity = 5,
                    OrderId = 3,
                    MenuItemId = 3
                },
                new OrderItem
                {
                    Id = 6,
                    Quantity = 5,
                    OrderId = 4,
                    MenuItemId = 3
                },
                new OrderItem
                {
                    Id = 7,
                    Quantity = 5,
                    OrderId = 5,
                    MenuItemId = 3
                }
            );
        }
    }
}
