using LibM.Contracts;
using LibM.Contracts.Books;
using LibM.Data.Access;
using LibM.Data.Access.Managers;
using LibM.Data.Entities.Definition;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

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

        public List<OptionDto> GetBooksByOptionsAsOptions(BooksListOptionDto dto)
        {
            Expression<Func<Book, bool>> predicate;

            if (dto.TypeId != null && dto.AuthorId != null)
            {
                predicate = x => x.TypeId == dto.TypeId && dto.AuthorId == dto.AuthorId;
            }
            else if (dto.AuthorId != null)
            {
                predicate = x => x.AuthorId == dto.AuthorId;
            }
            else if (dto.TypeId != null)
            {
                predicate = x => x.TypeId == dto.TypeId;
            }
            else
            {
                return null;
            }

            var result = context.Books.Where(predicate).Select(x => new OptionDto
            {
                Code = x.Id,
                Label = x.Name
            }).ToList();
            return result;
        }

        public bool AddNewBook(NewBookDto book)
        {

            var entity = new Book()
            {
                Available = book.Available,
                AuthorId = book.AuthorId,
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now,
                Name = book.Name,
                PageCount = book.PageCount,
                TypeId = book.TypeId,
            };
            context.Books.Add(entity);
            var result = context.SaveChanges();
            return result > 0;
        }
    }
}
