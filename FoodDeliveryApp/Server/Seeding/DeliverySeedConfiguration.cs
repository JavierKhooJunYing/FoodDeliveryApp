using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodDeliveryApp.Server.Seeding
{
    public class DeliverySeedConfiguration : IEntityTypeConfiguration<Delivery>
    {
        public void Configure(EntityTypeBuilder<Delivery> builder)
        {
            builder.HasData(
                new Delivery
                {
                    Id = 1,
                    DeliveryDateTime = new DateTime(2022, 01, 24),
                    DeliveryAddress = "509 Tampines Central 1, #20-2011",
                    OrderId = 1
                },
                new Delivery
                {
                    Id = 2,
                    DeliveryDateTime = new DateTime(2022, 01, 23),
                    DeliveryAddress = "510 Tampines Central 1, #15-7099",
                    OrderId = 2
                },
                new Delivery
                {
                    Id = 3,
                    DeliveryDateTime = new DateTime(2022, 01, 23),
                    DeliveryAddress = "815 Tampines Avenue 4, #05-6077",
                    OrderId = 3
                },
                new Delivery
                {
                    Id = 4,
                    DeliveryDateTime = new DateTime(2022, 01, 24),
                    DeliveryAddress = "Hougang Avenue 7, #07-7777",
                    OrderId = 4
                },
                new Delivery
                {
                    Id = 5,
                    DeliveryDateTime = new DateTime(2022, 01, 24),
                    DeliveryAddress = "266 Serangoon Central Drive, #03-1111",
                    OrderId = 5
                }
            );
        }
    }
}
