using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodDeliveryApp.Server.Seeding
{
    public class MenuItemSeedConfiguration : IEntityTypeConfiguration<MenuItem>
    {
        public void Configure(EntityTypeBuilder<MenuItem> builder)
        {
            builder.HasData(
                new MenuItem
                {
                    Id = 1,
                    Name = "Aloha",
                    Cost = 9.90M,
                    Type = "Pizza",
                    ImageUrl = "images/aloha.jpg"
                },
                new MenuItem
                {
                    Id = 2,
                    Name = "Pepperoni",
                    Cost = 9.90M,
                    Type = "Pizza",
                    ImageUrl = "images/pepperoni.jpg"
                },
                new MenuItem
                {
                    Id = 3,
                    Name = "San Remo",
                    Cost = 9.90M,
                    Type = "Pizza",
                    ImageUrl = "images/sanRemo.jpg"
                },
                new MenuItem
                {
                    Id = 4,
                    Name = "Teriyaki Chicken",
                    Cost = 9.90M,
                    Type = "Pizza",
                    ImageUrl = "images/teriyakiChicken.jpg"
                },
                new MenuItem
                {
                    Id = 5,
                    Name = "Coca-Cola",
                    Cost = 2.90M,
                    Type = "Beverage",
                    ImageUrl = "images/cocaCola.png"
                },
                new MenuItem
                {
                    Id = 6,
                    Name = "Green Tea",
                    Cost = 2.90M,
                    Type = "Beverage",
                    ImageUrl = "images/greenTea.jpg"
                },
                new MenuItem
                {
                    Id = 7,
                    Name = "Hot Tea",
                    Cost = 2.90M,
                    Type = "Beverage",
                    ImageUrl = "images/tea.jpg"
                },
                new MenuItem
                {
                    Id = 8,
                    Name = "Hot Coffee",
                    Cost = 2.90M,
                    Type = "Beverage",
                    ImageUrl = "images/coffee.jpg"
                },
                new MenuItem
                {
                    Id = 9,
                    Name = "Hot Chocolate Lava Cake",
                    Cost = 9.90M,
                    Type = "Dessert",
                    ImageUrl = "images/chocLavaCake.jpg"
                },
                new MenuItem
                {
                    Id = 10,
                    Name = "Tiramisu",
                    Cost = 8.90M,
                    Type = "Dessert",
                    ImageUrl = "images/tiramisu.jpg"
                }
            );
        }
    }
}
