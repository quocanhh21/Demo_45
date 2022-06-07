using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_45
{
    public class Method
    {
        public Student GetStudent(int Id)
        {
            using (var context = new SchoolDBContext())
            {
                Student student = context.Students.Single(p => p.StudentID == Id);
                return student;
            }
        }

        public List<Student> GetAllStudents()
        {
            using (var context = new SchoolDBContext())
            {
                List<Student> student = context.Students.ToList();
                return student;
            }
        }
    }
}
