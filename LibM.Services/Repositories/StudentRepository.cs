using LibM.Contracts.Student;
using LibM.Data.Access;
using LibM.Data.Access.Managers;

namespace LibM.Services.Repositories
{
    public class StudentRepository
    {
        private readonly LibMDbContext context;

        public StudentRepository()
        {
            context = ContextManager.GetDbContext();
        }

        public List<StudentViewDto> GetAllStudent()
        {
            return context.Students.Select(x => new StudentViewDto
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                BirthDate = x.BirthDate,
                Gender = x.Gender,
                Grade = x.Grade,
                TransCount = context.Transactions.Count(y => y.StudentId == x.Id)
            }).ToList();
        }
    }
}