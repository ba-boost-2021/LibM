using LibM.Contracts.Student;
using LibM.Data.Access;
using LibM.Services.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System;
using System.IO;

namespace LibM.Test
{
    [TestFixture]
    public class StudentTestFixture : IntegrationTestBase
    {
        public StudentTestFixture()
        {
            Sut = new StudentRepository();
        }
        public StudentRepository Sut { get; set; }
        

        [Test]
        [Order(1)]
        public void CanList_AllStudent()
        {
            var result = Sut.GetAllStudent();
            Assert.AreEqual(result.Count, 2);
        }

        [Test]
        [Order(2)]
        public void CanCreate_New_Student()
        {
            var dto = new NewStudentDto
            {
                FirstName = "Sergen",
                LastName = "Kahraman",
                BirthDate = DateTime.Now,
                Gender = Data.Entities.Enums.Gender.Female,
                Grade = "11-A"
            };

            var result = Sut.AddStudents(dto);
            Assert.IsTrue(result);

            var count = Sut.GetAllStudent().Count;
            Assert.AreEqual(count, 3);
        }

        
    }
}