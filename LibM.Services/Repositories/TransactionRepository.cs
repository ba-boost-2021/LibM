using LibM.Contracts.Transaction;
using LibM.Data.Access;
using LibM.Data.Access.Managers;
using Microsoft.EntityFrameworkCore;

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
                                            ReturnDate = x.ReturnDate.ToShortDateString(),
                                            EmployeeName = x.Employee.FirstName
                                       }).ToList();
        }
    }
}