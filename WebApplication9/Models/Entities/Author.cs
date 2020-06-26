using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication9.Models.EnumTypes;

namespace WebApplication9.Models.Entities
{
    public class Author
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Genre Genre { get; set; }
        public DateTime FirstPublishDate { get; set; }
        public string LastBook { get; set; }
        public string FirstBook { get; set; }
        public string HomeLand { get; set; }
        public string CurrentLocation { get; set; }
        public IEnumerable<Book> Books { get; set; }


        public Author()
        {

        }

        public Author(string firstName, string lastName)
            :this(firstName, lastName, Genre.NotDetermine, 
                 DateTime.Now, "Uknown", 
                 "Also unknown", "Kazakghstna", 
                 "Almaty", null)
        {

        }

        public Author(string firstName, string lastName, Genre genre)
            : this(firstName, lastName,
                  genre, DateTime.Now,
                  "Unknown", "Unknown",
                  "Kazakhstan", "Almaty", null)
        {

        }

        public Author(string firstName, string lastName, 
            Genre genre, DateTime firstBookPublish)
            : this(firstName, lastName,
                  genre, firstBookPublish,
                  "Unknown", "Unknown",
                  "Kazakhstan", "Almaty", null)
        {

        }


        public Author(string firstName, string lastName,
            Genre genre, DateTime firstBookPublish, string lastBook)
            : this(firstName, lastName,
                  genre, firstBookPublish,
                  lastBook, "Unknown",
                  "Kazakhstan", "Almaty", null)
        {

        }

        public Author(string firstName, string lastName,
            Genre genre, DateTime firstBookPublish, 
            string lastBook, string firstBook)
            : this(firstName, lastName,
                  genre, firstBookPublish,
                  lastBook, firstBook,
                  "Kazakhstan", "Almaty", null)
        {

        }

        public Author(string firstName, string lastName,
            Genre genre, DateTime firstBookPublish,
            string lastBook, string firstBook, string homeLand)
            : this(firstName, lastName,
                  genre, firstBookPublish,
                  lastBook, firstBook,
                  homeLand, "Almaty", null)
        {

        }


        public Author(string firstName, string lastName,
            Genre genre, DateTime firstPublishDate, 
            string lastBook, string firstBook,
            string homeLand, string currentLocation, IEnumerable<Book> books)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Genre = genre;
            FirstPublishDate = firstPublishDate;
            LastBook = lastBook;
            FirstBook = firstBook;
            HomeLand = homeLand;
            CurrentLocation = currentLocation;
            Books = books;
        }
    }
}
