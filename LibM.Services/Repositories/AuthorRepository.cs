using LibM.Contracts;
using LibM.Contracts.Author;
using LibM.Contracts.NewAddAuthor;
using LibM.Data.Access;
using LibM.Data.Access.Managers;
using LibM.Data.Entities.Definition;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibM.Services.Repositories
{
    public class AuthorRepository
    {
        private readonly LibMDbContext context;
        public AuthorRepository()
        {
            context = ContextManager.GetDbContext();
        }
        public List<AuthorViewDto> GetAllAuthors()
        {
            return context.Authors.Select(x => new AuthorViewDto
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
            }).ToList();
        }

        public bool CreateNewAuthor(NewAddAuthorViewDto newAddAuthorViewDto)
        {
            var author = new Author()
            {
                FirstName = newAddAuthorViewDto.FirstName,
                LastName = newAddAuthorViewDto.LastName,

            };
            context.Add(author);
            var result = context.SaveChanges();
            return result == 1;
        }

        public List<OptionDto> GetAuthorsAsOptions()
        {
            return context.Authors.Select(x => new OptionDto
            {
                Code = x.Id,
                Label = $"{x.FirstName} {x.LastName}"
            }).ToList();
        }
    }
}
