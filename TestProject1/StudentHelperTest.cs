using Demo_45;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        private StudentHelper _method;
        [SetUp]
        public void Setup()
        {
            _method = new StudentHelper();
        }

        [Test]
        public void GetSingleStudent_ShouldReturnCorrectStudent()
        {
            var testStudents = GetTestStudens();
            Student s= _method.GetStudent(2);

            Assert.AreEqual(testStudents[0].StudentID, s.StudentID);
        }

        [Test]
        public void GetAllStudent_ShouldReturnAllProducts()
        {
            var countTestStudents = GetTestStudens().Count();
            var countMethodStudent = _method.GetAllStudents().Count();    
            
            Assert.AreEqual(countTestStudents, countMethodStudent);
        }

        private List<Student> GetTestStudens()
        {
            var testStudents = new List<Student>();
            testStudents.Add(new Student { StudentID = 2 });
            testStudents.Add(new Student { StudentID = 3 });
            testStudents.Add(new Student { StudentID = 4 });

            return testStudents;
        }
    }
}