using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodDeliveryApp.Server.Seeding
{
    public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
                new Staff
                {
                    Id = 1,
                    FirstName = "Lisa",
                    LastName = "Lim",
                    EmailAddress = "lisalim@geemail.com",
                    ContactNumber = "98765432",
                    BranchId = 1
                },
                new Staff
                {
                    Id = 2,
                    FirstName = "Jacob",
                    LastName = "Tan",
                    EmailAddress = "tanjacob@geemail.com",
                    ContactNumber = "99765433",
                    BranchId = 2
                },
                new Staff
                {
                    Id = 3,
                    FirstName = "Jonas",
                    LastName = "Lim",
                    EmailAddress = "jonaslim@geemail.com",
                    ContactNumber = "98744434",
                    BranchId = 3
                },
                new Staff
                {
                    Id = 4,
                    FirstName = "Matthew",
                    LastName = "Phua",
                    EmailAddress = "phuamatthew@geemail.com",
                    ContactNumber = "98762222",
                    BranchId = 4
                },
                new Staff
                {
                    Id = 5,
                    FirstName = "Owen",
                    LastName = "Kwok",
                    EmailAddress = "kwokowen@geemail.com",
                    ContactNumber = "98768882",
                    BranchId = 5
                }
            );
        }
    }
}
