using LibM.Data.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibM.Contracts.Student
{
    public class NewStudentDto
    {
        
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public Gender Gender { get; set; }

            public DateTime BirthDate { get; set; }

            public string Grade { get; set; }
    }
}

