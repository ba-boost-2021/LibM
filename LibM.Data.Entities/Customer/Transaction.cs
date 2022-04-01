using LibM.Data.Entities.Definition;
using LibM.Data.Entities.Management;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibM.Data.Entities.Customer
{
    [Table("Transactions",Schema ="Customer")]
    public class Transaction : EntityBase
    {
        [Required]
        public Guid StudentId { get; set; }

        [Required]
        public Guid BookId { get; set; }

        [Required]
        public Guid EmployeeId { get; set; }

        [Required]
        public DateTime BorrowingDate { get; set; }

        [Required]
        public DateTime ReturnDate { get; set; }
        
        [ForeignKey(nameof(StudentId))]
        public Student Student { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        public Employee Employee { get; set; }

        [ForeignKey(nameof(BookId))]
        public Book Book { get; set; }
    }
}
