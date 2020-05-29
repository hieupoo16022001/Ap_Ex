using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Paper
{
   public class Checking
    {
        static void Main(string[] args)
        {
            Book b1 = new Book(10,1,"SGK","Hieu");
            Console.WriteLine("Books" + b1.ToString());

            MobilePhone m1 = new MobilePhone(20, 1, "Iphone", "Hieu");
            Console.WriteLine("Phone" + m1.ToString());
            Console.ReadLine();

        }
    }
}
