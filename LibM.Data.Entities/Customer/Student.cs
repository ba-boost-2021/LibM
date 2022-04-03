using LibM.Data.Entities.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibM.Data.Entities.Customer
{
    [Table("Students", Schema = "Customer")]
    public class Student : EntityBase
    {
        [Required]
        [MaxLength(32)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(32)]
        public string LastName { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        [MaxLength(20)]
        public string Grade { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime ModifiedAt { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}