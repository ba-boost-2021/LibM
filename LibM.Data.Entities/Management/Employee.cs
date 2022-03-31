using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibM.Data.Entities.Management
{
    [Table("Employees", Schema = "Management")]
    public class Employee : EntityBase
    {
        [Required]
        [MaxLength(64)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(64)]
        public string LastName { get; set; }

        [MaxLength(64)]
        public string Phone { get; set; }
    }
}