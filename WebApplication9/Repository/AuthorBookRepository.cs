using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication9.Models.ApplicationDbContext;
using WebApplication9.Models.Entities;

namespace WebApplication9.Repository
{
    public class AuthorBookRepository
    {
        private readonly AppDbContext _context;

        public AuthorBookRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Author> GetAuthorAsync(Guid authorId) 
            => await _context.Authors.FirstOrDefaultAsync(x => x.Id == authorId);

        public async Task<IEnumerable<Author>> GetAuthorsAsync()
            => await _context.Authors.ToListAsync();

        public async Task AddAuthorSync(Author author)
        {
            await _context.AddAsync(author);
        }

        public async Task<Book> GetBookAsync(Guid AuthorId, Guid BookId)
            => await _context.Books.FirstOrDefaultAsync(x => x.Id == BookId && x.AuthorId == AuthorId);


        public async Task<IEnumerable<Book>> GetBooksAsync()
            => await _context.Books.ToListAsync();

        public async Task AddBook(Book book)
        {
            await _context.Books.AddAsync(book);
        }

        public async Task SaveAsync()
            => await _context.SaveChangesAsync();

        public void DeleteAuthor(Author author)
        {
            _context.Remove(author);
        }
        public void DeleteBook(Book book)
        {
            _context.Remove(book);
        }
    }
}
