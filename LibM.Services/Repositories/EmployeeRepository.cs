using LibM.Contracts.Employee;
using LibM.Data.Access;
using LibM.Data.Access.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibM.Services.Repositories
{
    public class EmployeeRepository
    {
        private readonly LibMDbContext context;
        public EmployeeRepository()
        {
            context = ContextManager.GetDbContext();
        }
        public List<EmployeeViewDto> GetAllEmployees()
        {
            return context.Employees.Select(x => new EmployeeViewDto
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                Phone = x.Phone
            }).ToList();
        }

    }
}
