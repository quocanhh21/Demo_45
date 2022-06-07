namespace Demo_45
{
    public class StudentHelper
    {
        public Student GetStudent(int Id)
        {
            using (var context = new SchoolDBContext())
            {
                Student student = context.Students.SingleOrDefault(p => p.StudentID == Id);
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
