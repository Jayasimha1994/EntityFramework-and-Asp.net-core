using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstProject
{
    class EFCrud
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Sql Query number: \n 1.insert \n 2.update \n 3.delete \n 4.select");
            int num = Convert.ToInt32(Console.ReadLine());
            switch(num)
            {
                case 1: Insert.insert();
                    break;
                case 2: Update.update();
                    break;
                case 3: Delete.delete();
                    break;
                case 4: Select.select();
                    break;
                default: Console.WriteLine("Query not selected");
                    break;
            }
            Console.WriteLine("would you like to continue ? yes or no");
            string str = Console.ReadLine();
            if(str=="yes")
            {
                Main(args);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
