﻿using LibM.Contracts;
using LibM.Contracts.Books;
using LibM.Data.Access;
using LibM.Data.Access.Managers;
using LibM.Data.Entities.Definition;
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

        public List<OptionDto> GetBooksByOptionsAsOptions(BooksListOptionDto dto)
        {
            var queryBase = context.Books.AsQueryable();
            if (dto.TypeId != null)
            {
                queryBase = queryBase.Where(x => x.TypeId == dto.TypeId);
            }
            if (dto.AuthorId != null)
            {
                queryBase = queryBase.Where(x => x.AuthorId == dto.AuthorId);
            }
            var result = queryBase.Select(x => new OptionDto
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
