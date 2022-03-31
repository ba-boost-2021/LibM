using LibM.Data.Entities.Definition;
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
        public Guid StudentID { get; set; }


        [Required]
        public Guid BookID { get; set; }


        [ForeignKey(nameof(BookID))]
        public Book Book { get; set; }

        [Required]
        public DateTime BorrowingData { get; set; }

        [Required]
        public DateTime ReturnDate { get; set; }
        
        [ForeignKey(nameof(StudentID))]
        public Student Student { get; set; }
    }
}
