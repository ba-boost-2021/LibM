using LibM.Contracts;
using LibM.Contracts.Author;
using LibM.Data.Access;
using LibM.Data.Access.Managers;
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

        public List<OptionDto> GetAuthorsAsOptions()
        {
            return context.Authors.Select(x => new OptionDto
            {
                Code = x.Id,
                Label = $"{x.FirstName} {x.LastName}"
            }).ToList();
        }

        public List<OptionDto> GetAuthorsByType(Guid typeId)
        {
            return context.Books.Include(x => x.Type).Where(t => t.TypeId == typeId).Select(x => new OptionDto
            {
                Code = x.Author.Id,
                Label = $"{x.Author.FirstName} {x.Author.LastName}"
            }).Distinct().ToList();
        }
    }
}
