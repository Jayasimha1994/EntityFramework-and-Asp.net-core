using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstProject
{
    public class Select
    {
        public static void select()
        {
            using (StudentDbContext context = new StudentDbContext())
            {
                Console.WriteLine("enter the id of the record:");
                int id = Convert.ToInt32(Console.ReadLine());
                try
                {
                    Student student = context.students.FirstOrDefault(r => r.Id == id);
                    Console.WriteLine("Id {0}, name {1} age {2}", student.Id, student.s_name,student.age);
                    Console.Read();
                }
                catch(Exception e)
                {
                    Console.WriteLine("record doesn't exist");
                }
            }
        }
    }
}
