using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new con1Entities1();
            Person person = new Person()
            {
                p_id = 14,
                p_name = "jayasimha"
            };
            context.People.Add(person);
            context.SaveChanges();
        }
    }
}
