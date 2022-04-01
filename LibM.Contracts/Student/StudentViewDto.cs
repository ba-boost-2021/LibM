using LibM.Data.Entities.Enums;

namespace LibM.Contracts.Student
{
    public class StudentViewDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Gender Gender { get; set; }

        public DateTime BirthDate { get; set; }

        public string Grade { get; set; }
        public int TransCount { get; set; }
    }
}