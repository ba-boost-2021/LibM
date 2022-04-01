using LibM.Contracts.Books;
using LibM.Data.Access;
using LibM.Data.Access.Managers;
using Microsoft.EntityFrameworkCore;

namespace LibM.Services.Repositories
{
    public class BookRepository
    {
        private readonly LibMDbContext context;
        public BookRepository()
        {
            context = ContextManager.GetDbContext();
        }

        public List<BookViewDto> GetAllBooks()
        {
            return context.Books.Include(x => x.Author)
                                .Include(x => x.Type)
                                .Select(x => new BookViewDto
                                {
                                    Name = x.Name,
                                    AuthorName = $"{x.Author.FirstName} {x.Author.LastName}",
                                    PageCount = x.PageCount,
                                    Available = x.Available,
                                    Type = x.Type.Name
                                }).ToList();
        }
    }
}
