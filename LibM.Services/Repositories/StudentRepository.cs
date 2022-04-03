using LibM.Contracts;
using LibM.Contracts.Student;
using LibM.Data.Access;
using LibM.Data.Access.Managers;
using LibM.Data.Entities.Customer;
using System.Linq.Expressions;

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

        public bool AddStudents(NewStudentDto student)
        {
            var stu = new Student
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                Gender = student.Gender,
                BirthDate = student.BirthDate,
                Grade = student.Grade,
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now
                
            };
            context.Students.Add(stu);

            var result = context.SaveChanges();

            return result == 1;

        }

        public List<OptionDto> GetStudentsAsOptions(string filter = null)
        {
            Expression<Func<Student, bool>> predicate = x=>true;
            if (filter is not null)
            {
                predicate = x=>x.FirstName.StartsWith(filter);
            }
            return context.Students.Where(predicate).Select(x => new OptionDto
            {
                Label = $"{x.FirstName} {x.LastName}",
                Code = x.Id
            }).ToList();
        }
    }
}

internal class TransactionDto
{
    public Guid StudentId { get; set; }
    public int Count { get; set; }
}

//var elapsed = Stopwatch.StartNew();
//elapsed.Start();
//var result = context.Students.Select(x => new StudentViewDto
//{
//    Id = x.Id,
//    FirstName = x.FirstName,
//    LastName = x.LastName,
//    BirthDate = x.BirthDate,
//    Gender = x.Gender,
//    Grade = x.Grade
//}).ToList();
//var transactions = context.Transactions.GroupBy(x => x.StudentId)
//    .Select(x => new TransactionDto
//    {
//        StudentId = x.Key,
//        Count = x.Count()
//    }).ToList();

//foreach (var student in result)
//{
//    var trans = transactions.FirstOrDefault(x => x.StudentId == student.Id);
//    student.TransCount = trans is not null ? trans.Count : 0;
//}
//var totalMillisecond = elapsed.Elapsed.TotalMilliseconds;
//elapsed.Stop();


//var students = context.Students.ToList();
//var transactions = context.Transactions.ToList();

//var result = students.GroupJoin(transactions, st => st.Id, tr => tr.StudentId,
//        (st, tr) => new StudentViewDto
//        {
//            FirstName = st.FirstName,
//            Id = st.Id,
//            BirthDate = st.BirthDate,
//            Gender = st.Gender,
//            Grade = st.Grade,
//            LastName = st.LastName,
//            TransCount = tr.Count()
//        }).ToList();

//var result = context.Students.Select(x => new StudentViewDto
//{
//    Id = x.Id,
//    FirstName = x.FirstName,
//    LastName = x.LastName,
//    BirthDate = x.BirthDate,
//    Gender = x.Gender,
//    Grade = x.Grade,
//    TransCount = x.Transactions.Count
//}).ToList();

//var elapsed = Stopwatch.StartNew();
//elapsed.Start();
//var result = context.Students.Select(x => new StudentViewDto
//{
//    Id = x.Id,
//    FirstName = x.FirstName,
//    LastName = x.LastName,
//    BirthDate = x.BirthDate,
//    Gender = x.Gender,
//    Grade = x.Grade,
//    TransCount = context.Transactions.Count(y => y.StudentId == x.Id)
//}).ToList();
//elapsed.Stop();
//var totalMillisecond = elapsed.Elapsed.TotalMilliseconds;