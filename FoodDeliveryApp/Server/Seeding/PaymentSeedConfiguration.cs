using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodDeliveryApp.Server.Seeding
{
    public class PaymentSeedConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasData(
                new Payment
                {
                    Id = 1,
                    PaymentDateTime = new DateTime(2022, 01, 24),
                    Amount = 22.70M,
                    PaymentMethod = "Credit Card",
                    OrderId = 1
                },
                new Payment
                {
                    Id = 2,
                    PaymentDateTime = new DateTime(2022, 01, 23),
                    Amount = 18.80M,
                    PaymentMethod = "Debit Card",
                    OrderId = 2
                },
                new Payment
                {
                    Id = 3,
                    PaymentDateTime = new DateTime(2022, 01, 23),
                    Amount = 49.50M,
                    PaymentMethod = "Debit Card",
                    OrderId = 3
                },
                new Payment
                {
                    Id = 4,
                    PaymentDateTime = new DateTime(2022, 01, 24),
                    Amount = 49.50M,
                    PaymentMethod = "Credit Card",
                    OrderId = 4
                },
                new Payment
                {
                    Id = 5,
                    PaymentDateTime = new DateTime(2022, 01, 24),
                    Amount = 49.50M,
                    PaymentMethod = "Credit Card",
                    OrderId = 5
                }
            );
        }
    }
}
