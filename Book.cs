using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Paper
{
    public class Book : Product
    {
        private double price;
        public Book( double x)
        {
            this.price = x;
        }
        public Book(double x, int y, string z, string e) : base(y,z,e)
        {
            this.price = x;
        }
        public override String ToString()
        {
            return "Books has: price = " + price +"Id is : " + PproId + "Product Name is :" + PproName +  "Producer is :" + Pproducer ;
        }
        public override double computeTax()
        {
            return Math.PI * price * 8/100;}

    }
}
