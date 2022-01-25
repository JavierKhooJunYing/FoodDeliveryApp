using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodDeliveryApp.Server.Seeding
{
    public class CustomerSeedConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer
                {
                    Id = 1,
                    FirstName = "Desmond",
                    LastName = "Wong",
                    Gender = "Male",
                    DateOfBirth = new DateTime(1980, 07, 17),
                    DeliveryAddress = "509 Tampines Central 1, #20-2011",
                    ContactNumber = "98760962",
                    EmailAddress = "thedesmondwong@geemail.com"
                },
                new Customer
                {
                    Id = 2,
                    FirstName = "Lawrence",
                    LastName = "Pang",
                    Gender = "Male",
                    DateOfBirth = new DateTime(1970, 08, 05),
                    DeliveryAddress = "510 Tampines Central 1, #15-7099",
                    ContactNumber = "99761562",
                    EmailAddress = "panglawrence@geemail.com"
                },
                new Customer
                {
                    Id = 3,
                    FirstName = "Carrie",
                    LastName = "Lim",
                    Gender = "Female",
                    DateOfBirth = new DateTime(1984, 01, 01),
                    DeliveryAddress = "815 Tampines Avenue 4, #05-6077",
                    ContactNumber = "88880962",
                    EmailAddress = "carrielim@hooya.com"
                },
                new Customer
                {
                    Id = 4,
                    FirstName = "Cheryl",
                    LastName = "Tan",
                    Gender = "Female",
                    DateOfBirth = new DateTime(1977, 07, 07),
                    DeliveryAddress = "Hougang Avenue 7, #07-7777",
                    ContactNumber = "98767777",
                    EmailAddress = "cheryltann@mailhot.com"
                },
                new Customer
                {
                    Id = 5,
                    FirstName = "Thomas",
                    LastName = "Tan",
                    Gender = "Male",
                    DateOfBirth = new DateTime(1996, 03, 12),
                    DeliveryAddress = "266 Serangoon Central Drive, #03-1111",
                    ContactNumber = "99990962",
                    EmailAddress = "thomastan@inlook.com"
                }
            );
        }
    }
}
