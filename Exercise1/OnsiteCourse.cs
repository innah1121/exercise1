using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class OnsiteCourse:Course
    {
        private string companyName;
        private int candidatesNo;

        public OnsiteCourse(string name, int duration, int courseFee, string companyName, int candidatesNo) 
            :base(name, duration, courseFee)
        {
            this.companyName = companyName;
            this.candidatesNo = candidatesNo;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(companyName);
            Console.WriteLine(candidatesNo);
        }

        public override int GetTotalFee()
        {
           int fee = (int)(courseFee +courseFee * 0.1);
           return fee;
        }
        
    }
}
