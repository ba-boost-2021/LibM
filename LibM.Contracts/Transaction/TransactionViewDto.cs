using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibM.Contracts.Transaction
{
    public class TransactionViewDto
    {
        public string StudentName { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string EmployeeName { get; set; }
        public string BorrowingDate { get; set; }
        public string ReturnDate { get; set; }
    }
}
