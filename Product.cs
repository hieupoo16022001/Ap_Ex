
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Paper
{
   public abstract class Product
    {
        int proId;
        string proName;
        double price;
        string producer;
        public Product(int proId, string proName,  string producer)
        {
            this.proId = proId;
            this.proName = proName;
            this.producer = producer;
        }
        public int PproId
        {
            get { return proId; }
            set { proId = value; }
        }
        public string PproName
        {
            get{return proName; }
            set{proName = value;}
        }
       
        public string Pproducer
        {
            get { return producer; }
            set { producer = value; }
        }
        public abstract double computeTax();
    }
    }
