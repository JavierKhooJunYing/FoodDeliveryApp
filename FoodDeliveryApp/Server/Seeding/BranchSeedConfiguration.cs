using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodDeliveryApp.Server.Seeding
{
    public class BranchSeedConfiguration : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.HasData(
                new Branch
                {
                    Id = 1,
                    Name = "Pezzo SG | Bedok Mall",
                    Address = "311 New Upper Changi Road, #B2-K1, Bedok Mall",
                    ContactNumber = "85699938"
                },
                new Branch
                {
                    Id = 2,
                    Name = "Pezzo SG | AMK",
                    Address = "53 Ang Mo Kio Ave 3, #B2-38, AMK Hub",
                    ContactNumber = "94673609"
                },
                new Branch
                {
                    Id = 3,
                    Name = "Pezzo SG | Jem",
                    Address = "50 Jurong Gateway Road, #B1-K07, Jem",
                    ContactNumber = "86085498"
                },
                new Branch
                {
                    Id = 4,
                    Name = "Pezzo SG | NEX",
                    Address = "23 Serangoon Central, #B2-67, NEX",
                    ContactNumber = "95560839"
                },
                new Branch
                {
                    Id = 5,
                    Name = "Pezzo SG | VivoCity",
                    Address = "1 Harbourfront Walk, #B2-K15, VivoCity",
                    ContactNumber = "80985858"
                }
            );
        }
    }
}
