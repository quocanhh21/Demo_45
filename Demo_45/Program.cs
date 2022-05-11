using System;
using System.Data.Entity.Infrastructure;

namespace Demo_45
{
    public class Program
    {
        static void Main(string[] args)
        {
            //using (var context=new SchoolDBContext())
            //{
            //    var student = context.Students.Single(p => p.StudentID == 2);
            //    student.StudentName = "quoc anh";

            //    context.Database.ExecuteSqlCommand(
            //        "UPDATE Admin.Students SET StudentName = 'Jane' WHERE StudentID = 2");

            //    try
            //    {
            //        context.SaveChanges();
            //    }
            //    catch (DbUpdateConcurrencyException ex)
            //    {
            //        Console.WriteLine($"Can not update: {ex.Message}!");
            //    }
            //}
            using var context = new SchoolDBContext();
            using var transaction = context.Database.BeginTransaction();

            try
            {
                context.Students.Add(new Student { StudentName="Bob"});
                context.SaveChanges();

                context.Students.Add(new Student {StudentName="John",Weight=10 });
                context.SaveChanges();

                var blogs = context.Students
                    .OrderBy(b => b.StudentID)
                    .ToList();

                // Commit transaction if all commands succeed, transaction will auto-rollback
                // when disposed if either commands fails
                transaction.Commit();
            }
            catch (Exception)
            {
                // TODO: Handle failure
            }
        }
    }
}

