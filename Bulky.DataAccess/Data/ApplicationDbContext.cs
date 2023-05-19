

using BulkyBook.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace BulkyBook.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id=1, Name="Action", DisplayOrder=1 },
                 new Category { Id=2, Name="SciFi", DisplayOrder=2 },
                  new Category { Id=3, Name="History", DisplayOrder=3 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Phoebe Fortunes",
                    Author = "Abby Muscles",
                    Description = "Pzexcrtvybunrctvybuni",
                    ISBN = "SWD999900111",
                    ListPrice = 95,
                    Price = 86,
                    Price50 = 78,
                    Price100 = 80,
                    CategoryId = 1,
                    ImageUrl=""
                },
                new Product
                {
                    Id = 2,
                    Title = "Dark Skies",
                    Author = "Valerie Stimac",
                    Description = "zexrctvybunjmbyumio ",
                    ISBN = "CAW777777701",
                    ListPrice = 80,
                    Price = 20,
                    Price50 = 30,
                    Price100 = 65,
                    CategoryId = 1,
                    ImageUrl=""
                },
                new Product
                {
                    Id = 3,
                    Title = "Vanish by Dawn",
                    Author = "JD Wells",
                    Description = "zxctvybunjcgvbhjnvn",
                    ISBN = "RITO5555501",
                    ListPrice = 80,
                    Price = 40,
                    Price50 = 38,
                    Price100 = 70,
                    CategoryId = 1,
                    ImageUrl=""
                },
                new Product
                {
                    Id = 4,
                    Title = "Cotton Candy",
                    Author = "Ted Kooser",
                    Description = "zxrctvybunimokoyujhtrfgdsdcfvgbhjnkm ",
                    ISBN = "WS3333333301",
                    ListPrice = 70,
                    Price = 63,
                    Price50 = 50,
                    Price100 = 60,
                    CategoryId = 2,
                    ImageUrl=""
                },
                new Product
                {
                    Id = 5,
                    Title = "The Rock",
                    Author = "LJ Ross",
                    Description = "mbvcxzsedrftyuiop;lkjhgfdsasxcvbn ",
                    ISBN = "SOTJ1111111101",
                    ListPrice = 75,
                    Price = 24,
                    Price50 = 35,
                    Price100 = 60,
                    CategoryId = 2,
                    ImageUrl=""
                },
                new Product
                {
                    Id = 6,
                    Title = "The Last Book of Wonder",
                    Author = "Lord Dunsany",
                    Description = "qwertyuioplkjhgfdsaZxcvbnmngfd ",
                    ISBN = "FOT000000001",
                    ListPrice = 85,
                    Price = 23,
                    Price50 = 25,
                    Price100 = 70,
                    CategoryId = 3,
                    ImageUrl=""
                }
                );
        }
    }
}


