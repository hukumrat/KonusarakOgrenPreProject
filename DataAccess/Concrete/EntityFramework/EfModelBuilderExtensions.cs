using KonusarakOgrenPreProject.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;
namespace DataAccess.Concrete.EntityFramework
{
    public static class EfModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData
            (
                new Product()
                {
                    Id = 1,
                    Name = "Lamp",
                    Description = "Mauris nullam consectetuer placerat vulputate eu metus suspendisse natoque cras dis accumsan primis donec fusce si nascetur nisi litora odio",
                    Color = "White",
                    Weight = 11.5,
                    Quantity = 100,
                    Brand ="Philips"
                },
                new Product()
                {
                    Id = 2,
                    Name = "Bicycle",
                    Description = "In velit per rutrum adipiscing nisi ante facilisi cursus montes accumsan suspendisse pulvinar leo tellus mollis metus fusce quis faucibus",
                    Color = "Black",
                    Weight = 23.8,
                    Quantity = 90,
                    Brand = "Sedona"
                },
                new Product()
                {
                    Id = 3,
                    Name = "Table",
                    Description = "Pulvinar tincidunt potenti velit taciti aptent augue conubia gravida odio volutpat rhoncus ipsum inceptos facilisis adipiscing primis dis elit ullamcorper",
                    Color = "Green",
                    Weight = 35.9,
                    Quantity = 80,
                    Brand = "Bellona"
                },
                new Product()
                {
                    Id = 4,
                    Name = "Monitor",
                    Description = "Lorem maximus condimentum est nunc urna purus sem arcu in sit mauris fusce tincidunt tristique maecenas iaculis nec mollis ad",
                    Color = "Blue",
                    Weight = 42.4,
                    Quantity = 70,
                    Brand = "Asus"
                },
                new Product()
                {
                    Id = 5,
                    Name = "Wardrobe",
                    Description = "Ipsum tristique nunc condimentum fusce ante consectetur litora platea ultricies congue etiam eros vivamus pharetra venenatis fringilla maximus integer conubia",
                    Color = "Red",
                    Weight = 56.8,
                    Quantity = 60,
                    Brand = "Bellona"
                },
                new Product()
                {
                    Id = 6,
                    Name = "Vacuum Cleaner",
                    Description = "Proin scelerisque phasellus augue netus nascetur ante purus lorem neque mauris commodo nam quisque finibus vivamus imperdiet nec himenaeos cursus",
                    Color = "Orange",
                    Weight = 68.4,
                    Quantity = 50,
                    Brand = "Fakir"
                },
                new Product()
                {
                    Id = 7,
                    Name = "Fridge",
                    Description = "Eros mauris primis lobortis tellus netus potenti sapien consectetur dui eu magnis dictum gravida parturient est massa non felis sagittis",
                    Color = "White",
                    Weight = 74.8,
                    Quantity = 40,
                    Brand = "Arçelik"
                },
                new Product()
                {
                    Id = 8,
                    Name = "Television",
                    Description = "Feugiat curae quisque pede accumsan sed dis sodales ante convallis parturient cursus lectus platea duis maecenas non netus fermentum maximus",
                    Color = "Black",
                    Weight = 89.5,
                    Quantity = 30,
                    Brand = "LG"
                },
                new Product()
                {
                    Id = 9,
                    Name = "Bed",
                    Description = "Quam leo platea vehicula posuere iaculis adipiscing morbi cursus sollicitudin feugiat dapibus dolor eu tellus tortor accumsan nec tempor hendrerit",
                    Color = "Brown",
                    Weight = 91.5,
                    Quantity = 20,
                    Brand = "Bellona"
                },
                new Product()
                {
                    Id = 10,
                    Name = "Washing Machine",
                    Description = "Scelerisque pulvinar dapibus aptent sodales habitant erat dictum luctus mollis faucibus porttitor augue diam magna hendrerit volutpat quam venenatis velit",
                    Color = "White",
                    Weight = 100.1,
                    Quantity = 10,
                    Brand = "Arçelik"
                }
            );
            modelBuilder.Entity<Photo>().HasData
            (
                new Photo()
                {
                    Id = 1,
                    Path = "/Images/Lamp/1.jpg",
                    ProductId = 1
                },
                new Photo()
                {
                    Id = 2,
                    Path = "/Images/Bicycle/1.jpg",
                    ProductId = 2
                },
                new Photo()
                {
                    Id = 3,
                    Path = "/Images/Table/1.jpg",
                    ProductId = 3
                },
                new Photo()
                {
                    Id = 4,
                    Path = "/Images/Monitor/1.jpg",
                    ProductId = 4
                },
                new Photo()
                {
                    Id = 5,
                    Path = "/Images/Wardrobe/1.jpg",
                    ProductId = 5
                },
                new Photo()
                {
                    Id = 6,
                    Path = "/Images/Vacuum Cleaner/1.jpg",
                    ProductId = 6
                },
                new Photo()
                {
                    Id = 7,
                    Path = "/Images/Fridge/1.jpg",
                    ProductId = 7
                },
                new Photo()
                {
                    Id = 8,
                    Path = "/Images/Television/1.jpg",
                    ProductId = 8
                },
                new Photo()
                {
                    Id = 9,
                    Path = "/Images/Bed/1.jpg",
                    ProductId = 9
                },
                new Photo()
                {
                    Id = 10,
                    Path = "/Images/Washing Machine/1.jpg",
                    ProductId = 10
                }
            );

            modelBuilder.Entity<Comment>().HasData
            (
                new Comment()
                {
                    Id = 1,
                    Description = "Vestibulum convallis aptent massa mollis aliquam conubia enim purus rutrum orci facilisis aenean dignissim habitasse venenatis phasellus consectetur nascetur sapien",
                    ProductId = 1
                },
                new Comment()
                {
                    Id = 2,
                    Description = "Fames aliquet si tellus lorem eleifend orci nisi netus massa parturient curae sit urna vitae congue risus eros id senectus",
                    ProductId = 2
                },
                new Comment()
                {
                    Id = 3,
                    Description = "Quis justo mollis duis mattis sapien dis si quisque nunc metus class volutpat tempor lectus a nisl hendrerit etiam massa",
                    ProductId = 3
                },
                new Comment()
                {
                    Id = 4,
                    Description = "Maximus aptent cras consequat tristique proin rhoncus urna maecenas a si bibendum egestas augue adipiscing vehicula mus iaculis ultricies quam",
                    ProductId = 4
                },
                new Comment()
                {
                    Id = 5,
                    Description = "Bibendum feugiat viverra nullam interdum mauris venenatis eleifend condimentum augue eu tempor vitae finibus luctus tellus pede nibh egestas facilisis",
                    ProductId = 5
                },
                new Comment()
                {
                    Id = 6,
                    Description = "Metus erat fermentum vivamus scelerisque mollis condimentum nunc tristique nisl nascetur hac egestas blandit phasellus suscipit auctor class consectetur consequat",
                    ProductId = 6
                },
                new Comment()
                {
                    Id = 7,
                    Description = "Consectetuer nullam sollicitudin letius torquent finibus in tincidunt accumsan maximus volutpat ad adipiscing curabitur commodo ut eget nibh suspendisse lacus",
                    ProductId = 7
                },
                new Comment()
                {
                    Id = 8,
                    Description = "Rutrum nullam dictumst habitasse facilisi sit placerat praesent libero felis mauris fringilla porttitor tempor vestibulum bibendum amet nam class est",
                    ProductId = 8
                },
                new Comment()
                {
                    Id = 9,
                    Description = "Molestie odio dictumst rutrum condimentum imperdiet aliquet vel massa accumsan dictum per netus inceptos lacus justo ultricies purus lorem enim",
                    ProductId = 9
                },
                new Comment()
                {
                    Id = 10,
                    Description = "Enim cubilia sodales ligula ornare luctus sapien ut neque dictum laoreet aptent malesuada porta faucibus fames posuere consectetuer pretium adipiscing",
                    ProductId = 10
                }
            );
        }
    }
}
