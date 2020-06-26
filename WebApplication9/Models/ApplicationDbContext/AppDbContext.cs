using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication9.Models.Entities;

namespace WebApplication9.Models.ApplicationDbContext
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Author>().HasData(new Author
            {
                Id = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                FirstName = "Berry",
                LastName = "Griffin Beak Eldritch",
                FirstPublishDate = new DateTime(2022, 7, 23),
                CurrentLocation = "New York, NY, USA",
                HomeLand = "Almaty, Kazakhstan",
                FirstBook = "Man and woman",
                Genre = EnumTypes.Genre.Detective,
                LastBook = "8 half"
            },
            new Author
            {
                Id = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                FirstName = "Nancy",
                LastName = "Swashbuckler Rye",
                FirstPublishDate = new DateTime(1999, 5, 21),
                CurrentLocation = "New York, NY, USA",
                HomeLand = "Baku, Azerbaijan",
                FirstBook = "How to...",
                Genre = EnumTypes.Genre.Adventure,
                LastBook = "Painfull some"
            },
            new Author
            {
                Id = Guid.Parse("2902b665-1190-4c70-9915-b9c2d7680450"),
                FirstName = "Eli",
                LastName = "Ivory Bones Sweet",
                FirstPublishDate = new DateTime(1971, 12, 16),
                CurrentLocation = "Los Angeles, CAL, USA",
                HomeLand = "Krakow, Poland",
                FirstBook = "About me",
                Genre = EnumTypes.Genre.Mystery,
                LastBook = "About everything"
            },
            new Author
            {
                Id = Guid.Parse("102b566b-ba1f-404c-b2df-e2cde39ade09"),
                FirstName = "Arnold",
                LastName = "The Unseen Stafford",
                FirstPublishDate = new DateTime(2002, 3, 6),
                CurrentLocation = "Vankoower, BC, Canada",
                HomeLand = "Moscow, Russia",
                FirstBook = "From London to New York",
                Genre = EnumTypes.Genre.Fantasy,
                LastBook = "From London to New York"
            });

            builder.Entity<Book>().HasData(new Book
            {
                Id = Guid.Parse("5b3621c0-7b12-4e80-9c8b-3398cba7ee05"),
                Description = "Something about book, no mne len' pisat'",
                Genre = EnumTypes.Genre.Detective,
                Name = "8 half",
                AuthorId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35")
            },
            new Book
            {
                Id = Guid.Parse("2aadd2df-7caf-45ab-9355-7f6332985a87"),
                Description = "Something about book, no mne len' pisat'",
                Genre = EnumTypes.Genre.Adventure,
                Name = "Undefieted",
                AuthorId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35")
            },
            new Book
            {
                Id = Guid.Parse("2ee49fe3-edf2-4f91-8409-3eb25ce6ca51"),
                Description = "Something about book, no mne len' pisat'",
                Genre = EnumTypes.Genre.Adventure,
                Name = "Undefieted 2",
                AuthorId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35")
            },
            new Book
            {
                Id = Guid.Parse("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                Description = "Commandeering a ship in rough waters isn't easy.  Commandeering it without getting caught is even harder.  In this course you'll learn how to sail away and avoid those pesky musketeers.",
                Genre = EnumTypes.Genre.Horor,
                Name = "Undefieted 3",
                AuthorId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35")
            },
            new Book
            {
                Id = Guid.Parse("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                Description = "In this course, the author provides tips to avoid, or, if needed, overthrow pirate mutiny..",
                Genre = EnumTypes.Genre.Horor,
                Name = "Azbouk Hororov",
                AuthorId = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96")
            },
             new Book
             {
                 Id = Guid.Parse("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                 Description = "Every good pirate loves rum, but it also has a tendency to get you into trouble...",
                 Genre = EnumTypes.Genre.Mystery,
                 Name = "Rum",
                 AuthorId = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96")
             },
             new Book
             {
                 Id = Guid.Parse("40ff5488-fdab-45b5-bc3a-14302d59869a"),
                 Description = "In this course you'll learn how to sing all-time favourite pirate songs without sounding",
                 Genre = EnumTypes.Genre.Mystery,
                 Name = "Fun with books",
                 AuthorId = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96")
             });

        }
    }
}
