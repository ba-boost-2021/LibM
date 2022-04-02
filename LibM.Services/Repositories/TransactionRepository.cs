using LibM.Common.Constants;
using LibM.Contracts.Transaction;
using LibM.Data.Access;
using LibM.Data.Access.Managers;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace LibM.Services.Repositories
{
    public class TransactionRepository
    {
        private readonly LibMDbContext context;

        public TransactionRepository()
        {
            context = ContextManager.GetDbContext();
        }

        public List<TransactionViewDto> GetAllTransaction()
        {
            return context.Transactions.Include(t => t.Student)
                                       .Include(z => z.Employee)
                                       .Include(z => z.Book)
                                       .ThenInclude(b => b.Author)
                                       .Select(x => new TransactionViewDto
                                       {
                                            AuthorName = x.Book.Author.FirstName,
                                            BookName = x.Book.Name,
                                            StudentName = x.Student.FirstName,
                                            BorrowingDate = x.BorrowingDate.ToShortDateString(),
                                            ReturnDate = x.ReturnDate.Value.ToShortDateString(),
                                            EmployeeName = x.Employee.FirstName
                                       }).ToList();
        }

        public bool AddNewTransaction(NewTransactionDto dto)
        {
            var entity = new Data.Entities.Customer.Transaction
            {
                StudentId = dto.StudentId,
                BookId = dto.BookId,
                BorrowingDate = DateTime.Now,
                CreatedAt = DateTime.Now,
                EmployeeId = SystemParameters.SystemAdminId,
                ModifiedAt = DateTime.Now,
            };
            context.Transactions.Add(entity);
            return context.SaveChanges() > 0;
        }
    }
}