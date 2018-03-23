using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstProject
{
    public class Student
    {
        public int Id { get; set; }
        public string s_name { get; set; }
        public string age { get; set; } 
    }
    public class StudentDbContext:DbContext
    {
        public DbSet<Student> students { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var context = new StudentDbContext();
            Student student = new Student()
            {
                Id = 20,
                s_name = "kavitha",
                age = "30"
            };
            context.students.Add(student);
            context.SaveChanges();
        }
    }
}
