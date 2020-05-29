using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Paper
{
    public class MobilePhone : Product
    {
        private double price;
        public MobilePhone(double x)
        {
            this.price = x;
        }
        public MobilePhone(double x,int y,string z,string e) : base(y,z,e)
        {
            this.price = x;
        }
        public override String ToString()
        {
            return "Mobile has: Price is :" + price + "ID is : " + PproId + " Name is " + PproName + "Producer is" + Pproducer;
        }
        public override double computeTax()
        {
            return Math.PI*price*10/100;
        }

    }

}
