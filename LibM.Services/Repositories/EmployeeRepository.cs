using LibM.Contracts.Employee;
using LibM.Data.Access;
using LibM.Data.Access.Managers;
using LibM.Data.Entities.Management;
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
        public bool CreateNewEmployee(NewEmployeeDto newEmployee)
        {
            var employee = new Employee()
            {
                FirstName = newEmployee.FirstName,
                LastName = newEmployee.LastName,
                Phone = newEmployee.Phone,
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now
            };
            context.Add(employee);
            var result = context.SaveChanges();
            return result == 1;
        }
    }
}
