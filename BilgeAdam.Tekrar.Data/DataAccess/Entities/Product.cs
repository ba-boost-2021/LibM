using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BilgeAdam.Tekrar.Data.DataAccess.Entities
{
    [Table("Products")]
    public class Product
    {
        [Key]
        [Required]
        public int ProductID { get; set; }

        //[Column("ProductName")]
        public string ProductName { get; set; }

        public decimal? UnitPrice { get; set; }
    }
}