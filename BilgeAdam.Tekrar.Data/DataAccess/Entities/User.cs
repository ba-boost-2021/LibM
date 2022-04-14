﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BilgeAdam.Tekrar.Data.DataAccess.Entities
{
    [Table("User")]
    public class User
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [MaxLength(64)]
        [Required]
        public string Name { get; set; }

        [MaxLength(64)]
        [Required]
        public string Email { get; set; }

        [MaxLength(64)]
        public string Password { get; set; }
    }
}