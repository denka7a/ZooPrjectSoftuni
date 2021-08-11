using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ZooUni.Data.Models;

namespace ZooUni.Data
{
    public class ZooContext : IdentityDbContext<User>
    {

        public ZooContext(DbContextOptions<ZooContext> options)
                  : base(options)
        {
        }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Hospital> Hospital { get; set; }
        public DbSet<Owner> Owners { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Animal>()
                .Property(x => x.HospitalId)
                .IsRequired(false);
           
            modelBuilder.Entity<Animal>().HasData(
                new Animal
                {
                    Id = 1,
                    Type = "Tiger",
                    Name = "Pombercho",
                    URL = "https://www.permaculturenews.org/wp-content/uploads/2020/10/Tiger-Supermarket.jpg",
                    Kind = "Predator",
                    OwnerId = 1
                },

                new Animal
                {
                    Id = 2,
                    Type = "Lion",
                    Name = "Mufasa",
                    URL = "https://ewscripps.brightspotcdn.com/b8/97/543aa49f42adb4cf0e361b3f556d/t10-0078-002.jpg",
                    Kind = "Predator",
                    OwnerId = 1
                },

                new Animal
                {
                    Id = 3,
                    Type = "Giraffe",
                    Name = "Emil",
                    URL = "https://www.gannett-cdn.com/presto/2019/06/21/PKNS/6d8c357f-2dd6-4730-8d85-5eb6a481ec2a-kns-zoo-0622_BP.JPG",
                    Kind = "Mammal",
                    OwnerId = 2
                },

                new Animal
                {
                    Id = 4,
                    Type = "Bear",
                    Name = "Meca",
                    URL = "https://www.indianapoliszoo.com/wp-content/uploads/2018/04/CROPPED_Brown_Bear-Cheryl_Wesselresizedresized.jpg",
                    Kind = "Predator",
                    OwnerId = 1
                },

                new Animal
                {
                    Id = 5,
                    Type = "Elephant",
                    Name = "Ancho",
                    URL = "https://media.npr.org/assets/img/2017/01/10/elephant1_custom-14cf2c849d4a2c5aaac9d1b017f64c4adb9f04e4.jpg",
                    Kind = "Mammal",
                    OwnerId = 2
                },

                new Animal
                {
                    Id = 6,
                    Type = "Crocodile",
                    Name = "Adam",
                    URL = "https://bristolzoo.org.uk/cmsassets/body/Animals-and-Attractions/Dwarf-Crocodiles/_galleryMainNew/Dwarf-Crododiles-gallery-1.jpg",
                    Kind = "Reptile",
                    OwnerId = 3
                },

                new Animal
                {
                    Id = 7,
                    Type = "Wolf",
                    Name = "White Fang",
                    URL = "https://arc-anglerfish-arc2-prod-tronc.s3.amazonaws.com/public/UXEKVA33VJB6VL4ZEYDXF4NTOY.JPG",
                    Kind = "Predator",
                    OwnerId = 1
                },

                new Animal
                {
                    Id = 8,
                    Type = "Deer",
                    Name = "Rudolph",
                    URL = "https://cdn.pixabay.com/photo/2017/05/23/10/22/deer-2336769_960_720.jpg",
                    Kind = "Mammal",
                    OwnerId = 2
                },

                new Animal
                {
                    Id = 9,
                    Type = "Gorilla",
                    Name = "Kong",
                    URL = "http://cincinnatizoo.org/wp-content/uploads/2014/04/gladys_jomo-005.jpg",
                    Kind = "Mammal",
                    OwnerId = 2
                },

                new Animal
                {
                    Id = 10,
                    Type = "Hippopotamus",
                    Name = "Freckles",
                    URL = "https://s.hdnux.com/photos/70/22/51/14756432/3/rawImage.jpg",
                    Kind = "Predator",
                    OwnerId = 1
                },

                new Animal
                {
                    Id = 11,
                    Type = "Turtle",
                    Name = "Franklin",
                    URL = "https://d3i6fh83elv35t.cloudfront.net/static/2017/11/4934015500_711809ea1e_b-1024x747.jpg",
                    Kind = "Reptile",
                    OwnerId = 3
                },
                new Animal
                {
                    Id = 12,
                    Type = "Varan",
                    Name = "Konan",
                    URL = "https://www.sciencemag.org/sites/default/files/styles/article_main_large/public/images/komodo.jpg?itok=z9J3SnRt",
                    Kind = "Reptile",
                    OwnerId = 3
                });

            modelBuilder.Entity<Owner>().HasData(
                new Owner
                {
                    Id = 1,
                    Name = "Tom",
                    Information = "Tom is responsible for cleaning, feeding and maintaining predators. He`s animals are:",
                    URL = "https://i.pinimg.com/originals/92/a6/2f/92a62f0221f58fe503a15fcb13f5c107.png",
                    Animals = new List<Animal>()
                });
            modelBuilder.Entity<Owner>().HasData(
                new Owner
                {
                    Id = 2,
                    Name = "Jerry",
                    Information = "Jerry is responsible for cleaning, feeding and maintaining mammals. He`s animals are:",
                    URL = "https://i.pinimg.com/236x/d3/d7/25/d3d72562121f7dbd87d17d3f39ef9cf0--classic-cartoon-characters-classic-cartoons.jpg",
                    Animals = new List<Animal>()
                });
            modelBuilder.Entity<Owner>().HasData(
                new Owner
                {
                    Id = 3,
                    Name = "Spike",
                    Information = "Spike is responsible for cleaning, feeding and maintaining reptiles. He`s animals are:",
                    URL = "https://www.seekpng.com/png/detail/62-627979_spike-spike-cartoon-character.png",
                    Animals = new List<Animal>()
                });

            modelBuilder.Entity<Hospital>().HasData(
                new Hospital
                {
                    Id = 1,
                    Name = "Hospital"
                });

            modelBuilder.Entity<IdentityRole>().HasData
                (new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                },
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "User",
                    NormalizedName = "USER"
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}