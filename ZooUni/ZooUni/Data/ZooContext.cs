using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ZooUni.Data.Models;

namespace ZooUni.Data
{
    public class ZooContext : IdentityDbContext
    {

        public ZooContext(DbContextOptions<ZooContext> options)
                  : base(options)
        {
        }
        public DbSet<Animal> Animals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Animal>().HasData(
                new Animal
                {
                    Id = 1,
                    Type = "Tiger",
                    Name = "Pombercho",
                    URL = "https://www.permaculturenews.org/wp-content/uploads/2020/10/Tiger-Supermarket.jpg",
                    Kind = "Predator"
                },

                new Animal
                {
                    Id = 2,
                    Type = "Lion",
                    Name = "Mufasa",
                    URL = "https://ewscripps.brightspotcdn.com/b8/97/543aa49f42adb4cf0e361b3f556d/t10-0078-002.jpg",
                    Kind = "Predator"
                },

                new Animal
                {
                    Id = 3,
                    Type = "Giraffe",
                    Name = "",
                    URL = "https://www.gannett-cdn.com/presto/2019/06/21/PKNS/6d8c357f-2dd6-4730-8d85-5eb6a481ec2a-kns-zoo-0622_BP.JPG",
                    Kind = "Mammal"
                },

                new Animal
                {
                    Id = 4,
                    Type = "Bear",
                    Name = "",
                    URL = "https://www.indianapoliszoo.com/wp-content/uploads/2018/04/CROPPED_Brown_Bear-Cheryl_Wesselresizedresized.jpg",
                    Kind = "Predator"
                },

                new Animal
                {
                    Id = 5,
                    Type = "Elephant",
                    Name = "",
                    URL = "https://media.npr.org/assets/img/2017/01/10/elephant1_custom-14cf2c849d4a2c5aaac9d1b017f64c4adb9f04e4.jpg",
                    Kind = "Mammal"
                },

                new Animal
                {
                    Id = 6,
                    Type = "Crocodile",
                    Name = "",
                    URL = "https://bristolzoo.org.uk/cmsassets/body/Animals-and-Attractions/Dwarf-Crocodiles/_galleryMainNew/Dwarf-Crododiles-gallery-1.jpg",
                    Kind = "Reptile"
                },

                new Animal
                {
                    Id = 7,
                    Type = "Wolf",
                    Name = "",
                    URL = "https://arc-anglerfish-arc2-prod-tronc.s3.amazonaws.com/public/UXEKVA33VJB6VL4ZEYDXF4NTOY.JPG",
                    Kind = "Predator"
                },

                new Animal
                {
                    Id = 8,
                    Type = "Deer",
                    Name = "",
                    URL = "https://cdn.pixabay.com/photo/2017/05/23/10/22/deer-2336769_960_720.jpg",
                    Kind = "Mammal"
                },

                new Animal
                {
                    Id = 9,
                    Type = "Gorilla",
                    Name = "",
                    URL = "http://cincinnatizoo.org/wp-content/uploads/2014/04/gladys_jomo-005.jpg",
                    Kind = "Mammal"
                },

                new Animal
                {
                    Id = 10,
                    Type = "Hippopotamus",
                    Name = "",
                    URL = "https://s.hdnux.com/photos/70/22/51/14756432/3/rawImage.jpg",
                    Kind = "Predator"
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}