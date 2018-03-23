using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstProject
{
    public class Insert
    {
        public static void insert()
        {
            StudentDbContext context = new StudentDbContext();
            Console.WriteLine("enter the id :");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("enter age: ");
            string age = Console.ReadLine();
            Student student = new Student()
            {
                Id = id,
                s_name = name,
                age = age
            };
            context.students.Add(student);
            context.SaveChanges();
            Console.WriteLine("records entered successfully");
        }
    }
}
