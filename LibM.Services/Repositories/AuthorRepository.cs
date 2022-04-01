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
        

    }
}
