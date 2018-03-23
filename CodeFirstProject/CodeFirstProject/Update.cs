using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstProject
{
    public class Update
    {
        public static void update()
        {
            using (StudentDbContext context = new StudentDbContext())
            {
                Console.WriteLine("enter the id of record to be updated");
                int id = Convert.ToInt32(Console.ReadLine());
                try
                {
                    Student student = context.students.FirstOrDefault(r => r.Id == id);
                    Console.WriteLine("enter the name to be updated for current record");
                    student.s_name = Console.ReadLine();
                    context.SaveChanges();
                    Console.WriteLine("records has been updated successfully");
                }
                catch(Exception e)
                {
                    Console.WriteLine("record doesn't exist");
                }
            }
        }
    }
}
