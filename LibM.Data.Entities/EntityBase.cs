using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibM.Data.Entities
{
    public class EntityBase
    {
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}



/*
 Cutomer
    Transactions (StudentId(Guid, FK), BookId(Guid, FK), BorrowingDate(DateTime), ReturnDate(DateTime), )
    Students (FirstName, LastName, Gender(Enum), BirthDate(DateTime), Grade(String (Sınıfı temsil ediyor)))
Management
    Employees

Definition
    Books (Name, AuthorId(Guid, FK), TypeId(Guid, FK), PageCount, Available(bool))
    Authors (FirstName, LastName)
    Types (Name)
 
 */
