using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibM.Data.Entities.Definition
{
    [Table("Books",Schema ="Definition")]
    public class Book : EntityBase
    {
        [Required]
        [MaxLength(164)]
        public string Name { get; set; }

        [Required]
        public Guid AuthorId { get; set; }

        [Required]
        [MaxLength(10000)]
        public int PageCount { get; set; }

        public bool Available { get; set; }

        [Required]
        public Guid TypeId { get; set; }

        [ForeignKey(nameof(TypeId))]
        public Type Type { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public Author Author { get; set; }
    }
}
