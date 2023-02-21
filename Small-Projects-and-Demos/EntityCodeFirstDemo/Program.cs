using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityCodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                Console.Write("Enter student First Name: ");
                var firstName = Console.ReadLine();
                Console.Write("Enter student Last Name: ");
                var lastName = Console.ReadLine();
                var student = new Student { FirstName = firstName, LastName = lastName };
                db.Students.Add(student);
                db.SaveChanges();

                var query = from b in db.Students
                            orderby b.LastName
                            select b;

                Console.WriteLine("All students in the database: ");
                foreach (var item in query)
                {
                    Console.WriteLine(item.FirstName + " " + item.LastName);
                }

                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
            
        }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual List<Course> Courses { get; set; }

    }

    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }

    public class StudentContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
