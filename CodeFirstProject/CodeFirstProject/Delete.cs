using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstProject
{
    public class Delete
    {
        public static void delete()
        {
            using (StudentDbContext context = new StudentDbContext())
            {
                Console.WriteLine("enter the id of the record to delete");
                int id = Convert.ToInt32(Console.ReadLine());
                try
                {
                    Student student = context.students.FirstOrDefault(r => r.Id == id);
                    context.students.Remove(student);
                    context.SaveChanges();
                    Console.WriteLine("record has been removed");
                }
                catch(Exception e)
                {
                    Console.WriteLine("record doesn't exist");
                }
            }
        }
    }
}
